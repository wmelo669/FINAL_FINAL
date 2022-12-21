using projetFinal.classesEtInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace projetFinal.formulaires
{
    public partial class FormCompte : System.Windows.Forms.Form
    {
        //Variables d'utilisation globale
        //Variables Globales


        //Variables pour la base de données
        SqlConnection connexion;
        string query;
        string connexionString = ConfigurationManager.ConnectionStrings["connexionSqlServer"].ConnectionString;
        SqlCommand commande;
        SqlDataReader resultat;

        //Instance d'un compte
        Compte compte_ = new Compte();



        public FormCompte()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cette méthode est le gestionnaire de l'évènement click du button valider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_validerCreerCompte_click(object sender, EventArgs e)
        {
            //Variable de validation des données
            bool validerNumCompte = false;
            bool validerNomCompte = false;
            bool validerPrenomCompte = false;
            bool validerMdpCompte = false;
            string messageErreur = "Faites attention aux éléments suivants:\n";

            //NUMERO DE COMPTE
            compte_.NumCompte = txtb_numCompte_creerClient.Text;
            if (compte_.NumCompte == txtb_numCompte_creerClient.Text)
            {
                validerNumCompte = true;
            }

            //NOM DE COMPTE
            compte_.NomCompte = txtb_nomCompte_creerClient.Text;
            if (compte_.NomCompte == txtb_nomCompte_creerClient.Text)
            {
                validerNomCompte = true;
            }

            //PRENOM DE COMPTE
            compte_.PrenomCompte = txtb_prenomCompte_creerClient.Text;
            if (compte_.PrenomCompte == txtb_prenomCompte_creerClient.Text)
            {
                validerPrenomCompte = true;
            }

            //MOT DE PASSE
            compte_.MotDePasse = txtb_mdpClient_creerClient.Text;
            if (compte_.MotDePasse == txtb_mdpClient_creerClient.Text)
            {
                validerMdpCompte = true;
            }

            //TYPE DE COMPTE
            compte_.TypeCompte = "Client";


            if (validerNumCompte && validerNomCompte && validerPrenomCompte && validerMdpCompte)
            {

                btn_ajouterClient_creerClient.Enabled = true;

                connexion = new SqlConnection();
                connexion.ConnectionString = connexionString;
                query = $"SELECT * FROM Compte_t WHERE numCompte = {txtb_numCompte_creerClient.Text}";
                commande = new SqlCommand(query, connexion);

                connexion.Open();
                resultat = commande.ExecuteReader();

                //Si table contient un résultat avec le meme numero de compte
                if (resultat.HasRows)
                {
                    btn_ajouterClient_creerClient.Enabled = false;
                    txtb_numCompte_creerClient.Clear();
                    MessageBox.Show("Attention, assurez d'entrer un numéro de compte qui n'est pas existant!!", "Erreur: Numero de compte");
                }
                else
                {
                    //Activation du bouton pour ajouter le compte de client
                    btn_ajouterClient_creerClient.Enabled = true;
                }
                connexion.Close();
            }

            if (!validerNumCompte)
            {
                messageErreur += "-Le numéro de compte doit avoir 6 chiffres uniquement\n";
                txtb_numCompte_creerClient.Clear();
            }

            if(!validerNomCompte)
            {
                messageErreur += "-Le nom du compte doit commencer par une mayuscule et doit avoir avoir maximum 50 caractères\n";
                txtb_nomCompte_creerClient.Clear();
            }

            if (!validerPrenomCompte)
            {
                messageErreur += "-Le prenom du compte doit commencer par une mayuscule et doit avoir avoir maximum 50 caractères\n";
                txtb_prenomCompte_creerClient.Clear();
            }

            if(!validerMdpCompte)
            {
                messageErreur += "-Assuez vous d'avoir un mot de passe valide\n";
                txtb_mdpClient_creerClient.Clear();
            }

            //Affichage du message selon les champs qui ne sont pas corrects
            if(!validerNumCompte || !validerNomCompte || !validerPrenomCompte || !validerMdpCompte)
            {
                MessageBox.Show(messageErreur, "Attention!!!");
            }

        }

        /// <summary>
        /// Gestionnaire de l'évènement pour l'évènement TextChanged
        /// </summary>
        /// <param name="sender">L'objet qui envoie un évènement.</param>
        /// <param name="e">L'évènement envoyé par l'objet.</param>
        private void txtbTextChanged_creerClient(object sender, EventArgs e)
        {
            //Desactive le bouton pour ajouter le compte pour que l'usager
            //soit obligé de valider les informations avant de continnuer
            btn_ajouterClient_creerClient.Enabled = false;
        }

        private void creerCompte_formClosing(object sender, FormClosingEventArgs e)
        {
            Outils.formCreerClientDispo = true;
            Outils.formCreerClientEmploye = true;
            
        }

        private void btn_ajouterClient_creerClient_Click(object sender, EventArgs e)
        {
            query = $"INSERT INTO Compte_t (numCompte, nomCompte, prenomCompte, typeCompte, motDePasse) VALUES " +
                $"('{compte_.NumCompte}', '{compte_.NomCompte}', '{compte_.PrenomCompte}', '{compte_.TypeCompte}', '{compte_.MotDePasse}');";
            connexion = new SqlConnection();
            connexion.ConnectionString = connexionString;
            commande = new SqlCommand(query, connexion);

            commande.CommandText = query;

            connexion.Open();

            int ligneAffecte = commande.ExecuteNonQuery();

            if(ligneAffecte > 0)
            {
                MessageBox.Show("Le compte a été créé avec succès!!\n" + compte_.ToString(), "Compte crée!! :)");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur lors de la création du compte", "Erreur de création!");
            }
            connexion.Close();

        }
    }
}
