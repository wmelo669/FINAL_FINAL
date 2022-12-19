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
    public partial class FormPrets : System.Windows.Forms.Form
    {
        //Accès a la base de données
        SqlConnection connexion;
        string query;
        string connexionString = "Data Source=localhost;Initial Catalog=examFinal;User ID=sa;Password=sql";
        SqlCommand commande;
        SqlDataReader resultat;

        public FormPrets()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gestionnaire de l'év;nement formClosing lors que le formulaire est en train d'etre fermé.
        /// </summary>
        /// <param name="sender">Le formulaire pour faire des prets</param>
        /// <param name="e">L'évènement formClosing</param>
        private void FormPrets_FormClosing(object sender, FormClosingEventArgs e)
        {
            Outils.formFairePrets = true;
        }

        private void FormPrets_Load(object sender, EventArgs e)
        {
            query = "SELECT L.isbn, L.titre, L.nombreDePages, L.langueDOrigine, L.quantite, A.nomAuteur FROM Livre_t L INNER JOIN Auteur_t A ON L.idAuteur = A.idAuteur";
            connexion = new SqlConnection();
            connexion.ConnectionString = connexionString;
            commande = new SqlCommand(query, connexion);

            commande.CommandText = query;

            connexion.Open();
            resultat = commande.ExecuteReader();

            if (resultat.HasRows)
            {
                while (resultat.Read())
                {
                    dataGridViewEmprunt_emprunterLivre.Rows.Add(resultat[0], resultat[1], resultat[2], resultat[3], resultat[4], resultat[5]);
                }
            }
            else
            {
                MessageBox.Show("La table ne contient aucune ligne", "Erreur!!");
            }

        }

        /// <summary>
        /// Gestionnaire de l'évènement click du bouton ajouter dans l'Emprunt de livres.
        /// </summary>
        /// <param name="sender">Le bouton ajouter dans emprunter livres</param>
        /// <param name="e">L'évènement click</param>
        private void btn_ajouter_emprunterLivre_Click(object sender, EventArgs e)
        {
            //Function qui vérifie qu'il n'ait pas deja un meme ISBN dans le checklistbox.
            //Si l'isbn est dans la checklistbox, retourne true, si non, retourne false
            bool VerificationISBNDansListe(string pIsbn)
            {
                bool elementTrouve = false;
                foreach(string ligne in checkListBox_Prets.Items)
                {
                    string[] ligneArray = ligne.Split('-');
                    if (ligneArray[0].Replace("\t", "") == pIsbn)
                    {
                        elementTrouve = true;
                        break;
                    }
                }
               
                return elementTrouve;
            }

            //Vérifier que la quantité de livres soit plus grande a 0
            bool elemeentDisponible = false;

            //Valider que la quantité souhaité ne soit pas plus grande a celle disponible.
            foreach (DataGridViewRow element in dataGridViewEmprunt_emprunterLivre.Rows)
            {
                //Vérification de l'ISBN soit dans la dataGridView
                if ((string)element.Cells[0].Value == txtb_entrerIsbn_emprunterLivre.Text)
                {
                    //Vérification que 
                    if ((int)element.Cells[4].Value >= (int)numUpDown_quantite_emprunterLivre.Value && 
                        (int)numUpDown_quantite_emprunterLivre.Value > 0 && 
                        VerificationISBNDansListe((string)element.Cells[0].Value) == false)
                    {
                        checkListBox_Prets.Items.Add($"{element.Cells[0].Value}\t-\t{element.Cells[1].Value}\t-\t" +
                            $"{(int)numUpDown_quantite_emprunterLivre.Value}", false);
                        txtb_entrerIsbn_emprunterLivre.Clear();
                        txtb_entrerIsbn_emprunterLivre.Focus();
                        elemeentDisponible = true;
                        break;
                    }
                }
            }

            //Si aucun ISBN est rentré ou un ISBN non valide est rentré.
            if (!elemeentDisponible)
            {
                //Construction du messsage d'erreur
                string mess = "Assurez vous de respecter les éléments suivants!!\n" +
                    "-ISBN valide\n-ISBN disponible dans la liste\n-Quantité valide" +
                    "\nQue l'élément ne soit pas déjà dans la liste des prets.";
                txtb_entrerIsbn_emprunterLivre.Clear();
                MessageBox.Show(mess, "Attention!");
                txtb_entrerIsbn_emprunterLivre.Focus();
            }      
        }

        /// <summary>
        /// Gestionnaire pour l'évènement click du bouton Finalizer dans le pret de livres.
        /// </summary>
        /// <param name="sender">Le bouton finalizer</param>
        /// <param name="e">L'évènement click du bouton finalizer</param>
        private void btn_finalizer_emprunterLivre_Click(object sender, EventArgs e)
        {

            //Vérification que les items mits dans la liste soient cochés pour pouvoir finalizer le pret
            if (checkListBox_Prets.CheckedItems.Count > 0)
            {
                string message = "--Voilà l'info des items empruntés!--\n";

                string numFature = Outils.creerNumFacture();
                int ligneAffecte = 0;
                foreach (string elementCheckListBox in checkListBox_Prets.CheckedItems)
                {
                    //Ajout de chaque livre a la base de données.
                    string[] elementCheckArray = elementCheckListBox.Split('-');
                    
                    query = $"INSERT INTO Facture_t VALUES ('{numFature}', '{elementCheckListBox.Substring(0, 10)}', " +
                        $"'{txtb_numCompte_emprunterLivre.Text}', {elementCheckArray[2].Replace("\t", "")}, '{DateTime.Now}');";
                    connexion = new SqlConnection();
                    connexion.ConnectionString = connexionString;
                    commande = new SqlCommand(query, connexion);

                    commande.CommandText = query;

                    connexion.Open();

                    ligneAffecte = commande.ExecuteNonQuery();

                    //Modification de la quantité de livres empruntés dans la base de données.
                    query = $"UPDATE Livre_t SET quantite = quantite-{int.Parse(elementCheckArray[2].Replace("\t", ""))} WHERE " +
                            $"isbn = '{elementCheckArray[0].Replace("\t", "")}';";
                    SqlDataAdapter adapteur = new SqlDataAdapter();
                    SqlConnection connexion_ = new SqlConnection();
                    connexion_.ConnectionString = connexionString;

                    connexion_.Open();

                    SqlCommand commande_ = new SqlCommand(query, connexion_);

                    adapteur.UpdateCommand = commande_;

                    int ligneAffecte_ = adapteur.UpdateCommand.ExecuteNonQuery();

                    if (ligneAffecte_ < 1)
                    {
                        MessageBox.Show("Un erreur interne est survenu!!.", "Attention!!");
                    }

                    //Ajout dans le message
                    message += $"Le numéro de la facture est: {numFature}\n";
                    message += $"L'ISBN: {elementCheckArray[0]}\n";
                    message += $"Quantité: {elementCheckArray[2]}\n";
                    message += $"Date du pret: {DateTime.Now}\n";
                }
                if(ligneAffecte > 0)
                {
                    //Affichage si l'ajout a été fait avec succès
                    MessageBox.Show(message, "Pret fait avec succès!");
                    this.Close();
                }
                else
                {
                    //Affichage de message d'erreur si inconvenient lors de l'affichage de la facture.
                    MessageBox.Show("Un erreur est survenu lors de la completation de votre facture", "Attention");
                }              
            }
        }

        /// <summary>
        /// Gestionnaire de l'évènement click du bouton valider dans emprunterLivre
        /// </summary>
        /// <param name="sender">Bouton valider</param>
        /// <param name="e">L'évènement click du bouton valider</param>
        private void btn_validerNumCompte_emprunterLivre_Click(object sender, EventArgs e)
        {
            query = $"SELECT * FROM Compte_t WHERE numCompte = '{txtb_numCompte_emprunterLivre.Text}';";
            connexion = new SqlConnection();
            connexion.ConnectionString = connexionString;
            commande = new SqlCommand(query, connexion);

            commande.CommandText = query;

            connexion.Open();
            resultat = commande.ExecuteReader();

            if (resultat.HasRows)
            {
                //Activation de tous les controles pour emprunter un livre.
                btn_ajouter_emprunterLivre.Enabled = true;
                btn_finalizer_emprunterLivre.Enabled = true;
                lbl_quantite_emprunterLivre.Enabled = true;
                lbl_entrerIsbn_emprunterLivre.Enabled = true;
                txtb_entrerIsbn_emprunterLivre.Enabled = true;
                numUpDown_quantite_emprunterLivre.Enabled = true;
                checkListBox_Prets.Enabled = true;
                lbl_titreListeLivres_emprunterLivre.Enabled = true;
                lbl_ordreDetail_emprunterLivre.Enabled = true;

                //Désactivation des controls de validation de numéro de compte
                lbl_numCompte_emprunterLivre.Enabled = false;
                txtb_numCompte_emprunterLivre.Enabled = false;
                btn_validerNumCompte_emprunterLivre.Enabled = false;
            }
            else
            {
                //Affichage du message d'erreur
                txtb_numCompte_emprunterLivre.Clear();
                MessageBox.Show("Assurez vous d'avoir créé un compte avant d'emprunter ou d'entrer " +
                    "un compte valide!", "Erreur!!");
                txtb_numCompte_emprunterLivre.Focus();
            }
        }
    }
}
