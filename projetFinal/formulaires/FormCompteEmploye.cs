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

namespace projetFinal.formulaires
{
    public partial class FormCompteEmploye : System.Windows.Forms.Form
    {
        //Variables d'utilisation globale
        //Variable de validation des données
        bool validerNumCompte = false;
        bool validerNomCompte = false;
        bool validerPrenomCompte = false;
        bool validerMdpCompte = false;
        string messageErreur;

        

        //Variables pour la base de données
        SqlConnection connexion;
        string query;
        string connexionString = "Data Source=localhost;Initial Catalog=examFinal;User ID=sa;Password=sql";
        SqlCommand commande;
        SqlDataReader resultat;

        //Instance globale d'un Compte employe
        Compte compte_e = new Compte();

        public FormCompteEmploye()
        {
            InitializeComponent();
        }

        private void creerCompte_formClosing(object sender, FormClosingEventArgs e)
        {
            Outils.formCreerEmploye = true;
        }

        private void btn_validerClient_creerClient_Click(object sender, EventArgs e)
        {
            //NUMÉRO DE COMPTE
            compte_e.NumCompte = txtb_numCompte_creerClient.Text;
            if(compte_e.NumCompte == txtb_numCompte_creerClient.Text && Outils.NumCompteUnique(txtb_numCompte_creerClient.Text))
            {
                validerNumCompte = true;
            }
            else
            {
                txtb_numCompte_creerClient.Clear();
            }

            //NOM DU COMPTE
            compte_e.NomCompte = txtb_nomCompte_creerClient.Text;
            if(compte_e.NomCompte == txtb_nomCompte_creerClient.Text)
            {
                validerNomCompte = true;
            }
            else
            {
                txtb_nomCompte_creerClient.Clear();
            }

            //PRENOM DU COMPTE
            compte_e.PrenomCompte = txtb_prenomCompte_creerClient.Text;
            if(compte_e.PrenomCompte == txtb_prenomCompte_creerClient.Text)
            {
                validerPrenomCompte = true;
            }
            else
            {
                txtb_prenomCompte_creerClient.Clear();
            }

            //MOT DE PASSE
            compte_e.MotDePasse = txtb_mdpClient_creerClient.Text;
            if(compte_e.MotDePasse == txtb_mdpClient_creerClient.Text)
            {
                validerMdpCompte = true;
            }
            else
            {
                txtb_mdpClient_creerClient.Clear();
            }

            //TYPE DE COMPTE
            compte_e.TypeCompte = "Employe";

            //Si tout est valide, le bouton pour creer le compte employé est activé
            if(validerNumCompte && validerNomCompte && validerPrenomCompte && validerMdpCompte)
            {
                btn_ajouterClient_creerClient.Enabled = true;
            }

            //MESSAGE D'ERREUR DE VALIDATION
            messageErreur = "Faites attention aux éléments suivants:\n";
            if (!validerNumCompte)
            {
                messageErreur += "-Le numéro de compte doit etre unique et doit avoir exactement 6 caractéres numériques exactement.\n";
            }
            if (!validerNomCompte)
            {
                messageErreur += "-Le nom du compte doit commencer par une mayuscule et doit avoir avoir maximum 50 caractères\n";
            }
            if (!validerPrenomCompte)
            {
                messageErreur += "-Le prenom du compte doit commencer par une mayuscule et doit avoir avoir maximum 50 caractères\n";
            }
            if (!validerMdpCompte)
            {
                messageErreur += messageErreur += "-Assuez vous d'avoir un mot de passe valide\n";
            }

            //Affichage du message selon les champs qui ne sont pas corrects
            if (!validerNumCompte || !validerNomCompte || !validerPrenomCompte || !validerMdpCompte)
            {
                MessageBox.Show(messageErreur, "Attention!!!");
            }
        }

        private void btn_ajouterClient_creerClient_Click(object sender, EventArgs e)
        {
            //Une fois tous les valeurs nécessaires valides et validées, sauvegarde dans la base de données
            if (validerNumCompte && validerNomCompte && validerPrenomCompte && validerMdpCompte)
            {


                query = $"INSERT INTO Compte_t (numCompte, nomCompte, prenomCompte, typeCompte, motDePasse) VALUES " +
                    $"('{compte_e.NumCompte}', '{compte_e.NomCompte}', '{compte_e.PrenomCompte}', '{compte_e.TypeCompte}', '{compte_e.TypeCompte}');";
                connexion = new SqlConnection();
                connexion.ConnectionString = connexionString;
                commande = new SqlCommand(query, connexion);

                commande.CommandText = query;

                connexion.Open();

                int ligneAffecte = commande.ExecuteNonQuery();

                if (ligneAffecte > 0)
                {
                    MessageBox.Show("Le compte a été créé avec succès!!\n" + compte_e.ToString(), "Compte crée!! :)");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la création du compte", "Erreur de création!");
                }
                connexion.Close();
            }

        }

        private void inputs_creerAuteur_TextChanged(object sender, EventArgs e)
        {
            //Desactive le bouton pour ajouter le compte employé pour que l'usager
            //soit obligé de valider les informations avant de continnuer
            btn_ajouterClient_creerClient.Enabled = false;
        }
    }
}
