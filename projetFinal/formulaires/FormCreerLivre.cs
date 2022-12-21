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
    public partial class FormCreerLivre : System.Windows.Forms.Form
    {
        //Variables d'utilisation globale
        Livre livre_ = new Livre();
        string messageErreur;

        //Vriables pour la base de données
        SqlConnection connexion;
        string query;
        string connexionString = ConfigurationManager.ConnectionStrings["connexionSqlServer"].ConnectionString;
        SqlCommand commande;
        SqlDataReader resultat;

        //Variable de validation des données
        bool validerIsbn = false;
        bool valideridAuteur = false;
        bool validernombreDePages = false;
        bool validernombreDeChapitres = false;
        bool validerMaisonDEdition = false;
        bool validerNumeroDItem = false;
        bool validerTitre = false;
        bool validerDateDeParution = false;
        bool validerLangueDOrigine = false;
        bool validerQuantite = false;

        public FormCreerLivre()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Méthode gestionnaire de l'évènement FormClosing
        /// </summary>
        /// <param name="sender">Le formulaire</param>
        /// <param name="e">Évènement envoyé par le formulaire</param>
        private void FormCreerLivre_FormClosing(object sender, FormClosingEventArgs e)
        {
            Outils.formCreerLivre = true;
        }

        /// <summary>
        /// Ce gestionnaire d'évènements a come but que chaque fois que le valeur d'un component est modifié,
        /// l'utilisateur doit re-cliquer sur valider et desactive le bouton pour ajouter l'employé
        /// </summary>
        /// <param name="sender">Le coponent qui sont contenu a été modifié</param>
        /// <param name="e">L'évènement textChanged</param>
        private void inputComponents_creerLivre_textChanged(object sender, EventArgs e)
        {
            btn_ajouter_creerLivre.Enabled = false;
        }

        private void btn_valider_creerLivre_Click(object sender, EventArgs e)
        {
            messageErreur = "Faites attention aux éléments suivants:\n";
            //ISBN DU LIVRE
            livre_.Isbn = txtb_isbn_creerLivre.Text;
            if (livre_.Isbn == txtb_isbn_creerLivre.Text && Outils.IsbnUnique(livre_.Isbn))
            {
                validerIsbn = true;
            }
            else
            {
                txtb_isbn_creerLivre.Clear();
                messageErreur += "-Assurez vous d'entrer un ISBN correct.\n";
            }

            //ID DE L'AUTEUR
            livre_.IdAuteur = txtb_idAuteur_creerLivre.Text;
            if (livre_.IdAuteur == txtb_idAuteur_creerLivre.Text && Outils.IdAuteurExistant(livre_.IdAuteur))
            {
                valideridAuteur = true;
            }
            else
            {
                txtb_idAuteur_creerLivre.Clear();
                messageErreur += "-Assurez vous d'entrer un ID d'auteur valide et existant.\n";
            }

            //NOMBRE DE PAGES
            //Vérifiaction que la veleur entré est bel et bien un numéro int
            bool nombreDePagesValide = int.TryParse(txtb_nombreDePages_creerLivre.Text, out int nombreDePagesInt);

            if (nombreDePagesValide)
            {
                livre_.NombreDePage = nombreDePagesInt;
                if (livre_.NombreDePage == nombreDePagesInt)
                {
                    validernombreDePages = true;
                }
                else
                {
                    messageErreur += "-Le nombre de pages doit etre plus grand a 0.\n";
                }
            }
            else
            {
                messageErreur += "-Le nombre de pages doit etre un nombre entier.\n";
            }

            //NOMBRE DE CHAPITRES
            //Vérifiaction que la veleur entré est bel et bien un numéro int
            bool nombreDeChapitresValide = int.TryParse(txtb_nombreDePages_creerLivre.Text, out int nombreDeChapitresInt);

            if (nombreDeChapitresValide)
            {
                livre_.NbDeChapitres = nombreDeChapitresInt;
                if (livre_.NbDeChapitres == nombreDeChapitresInt)
                {
                    validernombreDeChapitres = true;
                }
                else
                {
                    messageErreur += "-Le nombre de chapitres doit etre plus grand a 0.\n";
                }
            }
            else
            {
                messageErreur += "-Le nombre de chapitres doit etre un numéro entier\n";
            }

            //MAISON D'ÉDITION
            livre_.MaisonDEdition = txtb_maisonDEdition_creerLivre.Text;
            if (livre_.MaisonDEdition == txtb_maisonDEdition_creerLivre.Text)
            {
                validerMaisonDEdition = true;
            }
            else
            {
                txtb_maisonDEdition_creerLivre.Clear();
                messageErreur += "-Entrez une maison d'édition valide\n";
            }

            //NUMERO D'ITEM
            livre_.NumeroItem = txtb_numéroDItem_creerLivre.Text;
            if (livre_.NumeroItem == txtb_numéroDItem_creerLivre.Text && Outils.NumItemUnique(livre_.NumeroItem))
            {
                validerNumeroDItem = true;
            }
            else
            {
                txtb_numéroDItem_creerLivre.Clear();
                messageErreur += "-Le numéro de l'item doit etre unique!!\n";
            }

            //TITRE
            livre_.Titre = txtb_titre_creerLivre.Text;
            if (livre_.Titre == txtb_titre_creerLivre.Text)
            {
                validerTitre = true;
            }
            else
            {
                txtb_titre_creerLivre.Clear();
                messageErreur += "-Assurez vous d'entrer un titre valide\n";
            }

            //DATE DE PARUTION
            livre_.DateDeParution = dtp_dateDeParution_creerLivre.Value;
            if (livre_.DateDeParution == dtp_dateDeParution_creerLivre.Value)
            {
                validerDateDeParution = true;
            }
            else
            {
                messageErreur += "-Assurez vous d'entrer une date valide.\n";
            }

            //LANUE D'ORIGINE
            livre_.LangueDOrigine = txtb_langueDOrigine_creerLivre.Text;
            if (livre_.LangueDOrigine == txtb_langueDOrigine_creerLivre.Text)
            {
                validerLangueDOrigine = true;
            }
            else
            {
                txtb_langueDOrigine_creerLivre.Clear();
                messageErreur += "-Assurez vous d'entrer une langue existante.\n";
            }

            //QUANTITÉ
            bool quantiteValide = int.TryParse(txtb_quantite_creerLivre.Text, out int quantiteInt);

            if (quantiteValide)
            {
                livre_.Quantite = quantiteInt;
                validerQuantite = true;
            }
            else
            {
                txtb_quantite_creerLivre.Clear();
                messageErreur += "-La quantité doit etre plus grand ou égal a 0\n";
            }


            //Si tout valide. activation du bouton pour ajouter le livre.
            if (validerIsbn && valideridAuteur && validernombreDePages && validernombreDeChapitres && validerNumeroDItem 
                && validerMaisonDEdition && validerTitre && validerDateDeParution && validerLangueDOrigine && validerQuantite)
            {
                btn_ajouter_creerLivre.Enabled = true;
            }

            //Affichage du message final dependament des valeurs erronnées
            if (!validerIsbn || !valideridAuteur || !validernombreDePages || !validernombreDeChapitres ||
                !validerMaisonDEdition ||!validerNumeroDItem || !validerTitre || !validerDateDeParution || !validerLangueDOrigine ||
                !validerQuantite)
            {
                MessageBox.Show(messageErreur, "Attention");
            }

        }

        /// <summary>
        /// Gestionnaire de l'évènement text changed dans les components qui demandent
        /// d'entrer des données. A comme fonction de faire tout le temps valider les
        /// données une fois un changement fait dans n'importe quel des componenets.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputs_creerLivre_textChanged(object sender, EventArgs e)
        {
            btn_ajouter_creerLivre.Enabled = false;
        }

        /// <summary>
        /// Gestionnaire d'évènements lorsque le formulaire est load
        /// </summary>
        /// <param name="sender">Le formulaire actuel</param>
        /// <param name="e">L'évènement load du formulaire</param>
        private void FormCreerLivre_Load(object sender, EventArgs e)
        {
            dtp_dateDeParution_creerLivre.CustomFormat = "yyyy dd MM";
        }

        /// <summary>
        /// Gestionnaire de l'évènement click du bouton ajouuter dans créer livre
        /// </summary>
        /// <param name="sender">Le bouton ajouter</param>
        /// <param name="e">L'évènement click</param>
        private void btn_ajouter_creerLivre_Click(object sender, EventArgs e)
        {
            {
                //Une fois tous les valeurs nécessaires valides et validées, sauvegarde dans la base de données
                if (validerIsbn && valideridAuteur && validernombreDePages && validernombreDeChapitres &&
                    validerMaisonDEdition && validerNumeroDItem && validerTitre && validerDateDeParution && validerLangueDOrigine)
                {
                    //Sauvegarde dans la base de données
                    query = $"INSERT INTO Livre_t VALUES ('{livre_.Isbn}', '{livre_.IdAuteur}', '{livre_.NombreDePage}', " +
                        $"'{livre_.NbDeChapitres}', '{livre_.MaisonDEdition}', '{livre_.NumeroItem}', '{livre_.Titre}', '{livre_.DateDeParution}', " +
                        $"'{livre_.LangueDOrigine}', '{livre_.Quantite}');";
                    connexion = new SqlConnection();
                    connexion.ConnectionString = connexionString;
                    commande = new SqlCommand(query, connexion);

                    commande.CommandText = query;

                    connexion.Open();

                    int ligneAffecte = commande.ExecuteNonQuery();

                    if (ligneAffecte > 0)
                    {
                        MessageBox.Show("Le livre a été créé avec succès!\n" + livre_.ToString(), "Livre créé!! :)");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la création du livre", "Erreur de création!");
                    }
                    connexion.Close();
                }
            }
        }
    }
}
