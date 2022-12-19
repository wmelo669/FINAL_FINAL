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
    public partial class FormCreerAuteur : System.Windows.Forms.Form
    {
        //Variable de validation des données
        bool valideridAuteur = false;
        bool validerNomAuteur = false;
        bool validerPrenomAuteur = false;
        bool validerDateDeNaissance = false;
        bool validerPaysDOrigine = false;
        string messageErreur;

        //Variables globales
        Auteur auteur_ = new Auteur();

        //Vriables pour la base de données
        SqlConnection connexion;
        string query;
        string connexionString = "Data Source=localhost;Initial Catalog=examFinal;User ID=sa;Password=sql";
        SqlCommand commande;

        public FormCreerAuteur()
        {
            InitializeComponent();
        }

        private void FormCreerAuteur_FormClosing(object sender, FormClosingEventArgs e)
        {
            Outils.formCreerAuteurDispo = true;
        }

        private void btn_valider_creerAuteur_Click(object sender, EventArgs e)
        {
            //ID DE L'AUTEUR
            auteur_.IdAuteur = txtb_idAuteur_creerAuteur.Text;
            if(auteur_.IdAuteur == txtb_idAuteur_creerAuteur.Text && Outils.IdAuteurUnique(txtb_idAuteur_creerAuteur.Text))
            {
                valideridAuteur = true;
            }
            else
            {
                txtb_idAuteur_creerAuteur.Clear();
            }

            //NOM DE L'AUTEUR
            auteur_.NomAuteur = txtb_nom_creerAuteur.Text;
            if(auteur_.NomAuteur == txtb_nom_creerAuteur.Text)
            {
                validerNomAuteur = true;
            }
            else
            {
                txtb_nom_creerAuteur.Clear();
            }

            //PRENOM DE L'AUTEUR
            auteur_.PrenomAuteur = txtb_prenom_creerAuteur.Text;
            if(auteur_.PrenomAuteur == txtb_prenom_creerAuteur.Text)
            {
                validerPrenomAuteur = true;
            }
            else
            {
                txtb_prenom_creerAuteur.Clear();
            }

            //DATE DE NAISSANCE
            auteur_.DateDeNaissanceAuteur = dtp_dateNaissance_creerAuteur.Value;
            if(auteur_.DateDeNaissanceAuteur == dtp_dateNaissance_creerAuteur.Value && auteur_.CalculerAge(auteur_.DateDeNaissanceAuteur) > 17)
            {
                validerDateDeNaissance = true;
            }

            //PAYS D'ORIGINE
            auteur_.PaysDOrigineAuteur = txtb_paysNaissance_creerAuteur.Text;
            if(auteur_.PaysDOrigineAuteur == txtb_paysNaissance_creerAuteur.Text)
            {
                validerPaysDOrigine = true;
            }
            else
            {
                txtb_paysNaissance_creerAuteur.Clear();
            }

            //Si tout valide. activation du bouton pour ajouter l'auteur.
            if(valideridAuteur && validerNomAuteur && validerPrenomAuteur && validerDateDeNaissance && validerPaysDOrigine)
            {
                btn_ajouter_creerAuteur.Enabled = true;
            }

            //MESSAGE D'ERREUR DE VALIDATION
            messageErreur = "Faites attention aux éléments suivants:\n";

            if(!valideridAuteur)
            {
                messageErreur += "-L'ID de l'auteur doit etre unique et de 6 caractères numériques.\n";
            }
            if(!validerNomAuteur)
            {
                messageErreur += "-Le nom de l'auteur doit commencer par une mayuscule et doit avoir avoir maximum 50 caractères\n";
            }
            if(!validerPrenomAuteur)
            {
                messageErreur += "-Le prenom de l'auteur doit commencer par une mayuscule et doit avoir avoir maximum 50 caractères\n";
            }
            if(!validerDateDeNaissance)
            {
                messageErreur += "-L'age de la personne doit etre minimum de 18 ans";
            }
            if(!validerPaysDOrigine)
            {
                messageErreur += "Le pays d'origine doit etre un pays existant";
            }

            //Affichage du message final dependament des valeurs erronnées
            if(!valideridAuteur || !validerNomAuteur || !validerPrenomAuteur || !validerDateDeNaissance || !validerPaysDOrigine)
            {
                MessageBox.Show(messageErreur, "Attention!!!");
            }
        }

        /// <summary>
        /// Gestionnaire d'évènements lors que la fenetre creer Auteur charge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCreerAuteur_Load(object sender, EventArgs e)
        {
            dtp_dateNaissance_creerAuteur.CustomFormat = "yyyy dd MM";

        }

        /// <summary>
        /// Cette mtéhode est le gestionnaire d'évènements lors que les valeurs entrées dans les
        /// controles sont modifiés. Donc, oblige a l'usager a valider toutes les donneées a chaque fois
        /// qu'il change le contenue qui a été validé.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputs_creerAuteur_TextChanged(object sender, EventArgs e)
        {
            btn_ajouter_creerAuteur.Enabled = false;
        }


        /// <summary>
        /// Gestionnaire d el'évènement click du boutton ajouter du formulaire pour creer un Auter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ajouter_creerAuteur_Click(object sender, EventArgs e)
        {
            //Une fois tous les valeurs nécessaires valides et validées, sauvegarde dans la base de données
            if(valideridAuteur && validerNomAuteur && validerPrenomAuteur && validerDateDeNaissance && validerPaysDOrigine)
            {
                //Sauvegarde dans la base de données
                query = $"INSERT INTO Auteur_t VALUES ('{auteur_.IdAuteur}', '{auteur_.NomAuteur}', '{auteur_.PrenomAuteur}', '{auteur_.DateDeNaissanceAuteur}', '{auteur_.PaysDOrigineAuteur}');";
                connexion = new SqlConnection();
                connexion.ConnectionString = connexionString;
                commande = new SqlCommand(query, connexion);

                commande.CommandText = query;

                connexion.Open();

                int ligneAffecte = commande.ExecuteNonQuery();

                if (ligneAffecte > 0)
                {
                    MessageBox.Show("L'auteur suivant a été créé avec succès!!:\n" + auteur_.ToString(), "Auteur crée!! :)");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la création de l'auteur", "Erreur de création!");
                }
                connexion.Close();
            }
        }
    }
}
