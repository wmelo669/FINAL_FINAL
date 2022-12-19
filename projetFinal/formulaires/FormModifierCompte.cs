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
    public partial class FormModifierCompte : System.Windows.Forms.Form
    {
        //Variables d'utilisation globale
        bool compteExistant = false;


        //Variables pour la base de données
        SqlConnection connexion;
        string query;
        string connexionString = "Data Source=localhost;Initial Catalog=examFinal;User ID=sa;Password=sql";
        SqlCommand commande;
        SqlDataReader resultat;

        public FormModifierCompte()
        {
            InitializeComponent();

            //Sert a que le formulaire ne puisse pas etre redimentionné
            //SOURCE: https://www.syncfusion.com/kb/12379/how-to-disable-resizing-of-a-winforms-metroform
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// Cette méthode est le gestionnaire d'évènements de l'évènemnt FormClosing du formulaire modifier
        /// </summary>
        /// <param name="sender">Objet qui envoie les évènements</param>
        /// <param name="e">Évènements envoyés par l'objet</param>
        private void FormModifierCompte_FormClosing(object sender, FormClosingEventArgs e)
        {
            Outils.formModifierClientDispo = true;
            Outils.formModifierEmployeDispo = true;
        }

        /// <summary>
        /// Cette méthode est le gestionnaire d'évènements de l'évènemnt click du bouton valider dans modifierCompte
        /// </summary>
        /// <param name="sender">Évènements envoyés par le bouton valider dans le formulaire modifierCompte</param>
        /// <param name="e">Évènements envoyés par le bouton valider(click)</param>
        private void btn_validerClient_modiferCompte_Click(object sender, EventArgs e)
        {
            //Vérifiaction que le compte existe
            connexion = new SqlConnection();
            connexion.ConnectionString = connexionString;
            query = $"SELECT * FROM Compte_t WHERE numCompte = {txtb_numCompte_modifierCompte.Text}";
            commande = new SqlCommand(query, connexion);

            connexion.Open();
            try
            {
                resultat = commande.ExecuteReader();
            }
            catch(Exception exep_)
            {
                MessageBox.Show(exep_.Message + "\nAssurez vous d'entrer une valeur valide", "Erreur!");
            }
            try
            {
                if (resultat != null)
                {
                    if (resultat.HasRows)
                    {
                        compteExistant = true;
                        //Desactivation des components pas nécessaires pour la modification d'un attribut
                        btn_validerClient_modiferCompte.Enabled = false;
                        txtb_numCompte_modifierCompte.Enabled = false;
                        lbl_numCompte_modifierCompte.Enabled = false;

                        //Activation de components pour modifier le formulaire
                        lbl_valeurAModifier_modifierCompte.Enabled = true;
                        cb_valeurAModifier_modifierCompte.Enabled = true;
                        txtb_nouvValeur_modifierCompte.Enabled = true;
                        lbl_messageEntre_modifierCompte.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Assurez vous d'entrer un numéro de client existant!","Attention!!!");
                        txtb_numCompte_modifierCompte.Clear();
                        txtb_numCompte_modifierCompte.Focus();
                        compteExistant = false;
                    }
                }
            
            }
            catch(Exception exep_)
            {
                MessageBox.Show(exep_.Message, "Erreur!!");
            }
        }

        /// <summary>
        /// Gestionnaire d'évènements lorsque la clé "enter" a été paissé.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtb_nouvValeur_modifierCompte_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (compteExistant == true && cb_valeurAModifier_modifierCompte.SelectedIndex != -1)
                {
                    Compte compteValidation = new Compte();

                    string colonneAModifier = "";

                    if(cb_valeurAModifier_modifierCompte.SelectedIndex == 0)
                    {
                        compteValidation.NomCompte = txtb_nouvValeur_modifierCompte.Text;
                        colonneAModifier = "nomCompte";

                        if (compteValidation.NomCompte == txtb_nouvValeur_modifierCompte.Text)
                        {
                            query = $"UPDATE Compte_t SET {colonneAModifier} = '{txtb_nouvValeur_modifierCompte.Text}' WHERE " +
                            $"numCompte = '{txtb_numCompte_modifierCompte.Text}';";

                            SqlDataAdapter adapteur = new SqlDataAdapter();
                            connexion = new SqlConnection();
                            connexion.ConnectionString = connexionString;

                            connexion.Open();

                            commande = new SqlCommand(query, connexion);

                            adapteur.UpdateCommand = commande;

                            int ligneAffecte = adapteur.UpdateCommand.ExecuteNonQuery();
                            if (ligneAffecte > 0)
                            {
                                MessageBox.Show($"La modification a été realisé!\nVotre nouveau {colonneAModifier} est: {txtb_nouvValeur_modifierCompte.Text}");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Il y a eu un erreur lors de la modification de votre compte", "Erreur!");
                            }
                            commande.Dispose();
                            connexion.Close();
                        }
                        else
                        {
                            MessageBox.Show("Assurez vous d'entrer une valeur valide", "Attention");
                            txtb_nouvValeur_modifierCompte.Clear();
                        }
                    }
                    else if (cb_valeurAModifier_modifierCompte.SelectedIndex == 1)
                    {
                        compteValidation.PrenomCompte = txtb_nouvValeur_modifierCompte.Text;
                        colonneAModifier = "prenomCompte";

                        if (compteValidation.PrenomCompte == txtb_nouvValeur_modifierCompte.Text)
                        {
                            query = $"UPDATE Compte_t SET {colonneAModifier} = '{txtb_nouvValeur_modifierCompte.Text}' WHERE " +
                            $"numCompte = '{txtb_numCompte_modifierCompte.Text}';";

                            SqlDataAdapter adapteur = new SqlDataAdapter();
                            connexion = new SqlConnection();
                            connexion.ConnectionString = connexionString;

                            connexion.Open();

                            commande = new SqlCommand(query, connexion);

                            adapteur.UpdateCommand = commande;

                            int ligneAffecte = adapteur.UpdateCommand.ExecuteNonQuery();
                            if (ligneAffecte > 0)
                            {
                                MessageBox.Show($"La modification a été realisé!\nVotre nouveau {colonneAModifier} est: {txtb_nouvValeur_modifierCompte.Text}");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Il y a eu un erreur lors de la modification de votre compte", "Erreur!");
                            }
                            commande.Dispose();
                            connexion.Close();
                        }
                        else
                        {
                            MessageBox.Show("Assurez vous d'entrer une valeur valide", "Attention");
                            txtb_nouvValeur_modifierCompte.Clear();
                        }
                    }
                    else if(cb_valeurAModifier_modifierCompte.SelectedIndex == 2)
                    {
                        compteValidation.MotDePasse = txtb_nouvValeur_modifierCompte.Text;
                        colonneAModifier = "motDePasse";

                        if (compteValidation.MotDePasse == txtb_nouvValeur_modifierCompte.Text)
                        {
                            query = $"UPDATE Compte_t SET {colonneAModifier} = '{txtb_nouvValeur_modifierCompte.Text}' WHERE " +
                            $"numCompte = '{txtb_numCompte_modifierCompte.Text}';";

                            SqlDataAdapter adapteur = new SqlDataAdapter();
                            connexion = new SqlConnection();
                            connexion.ConnectionString = connexionString;

                            connexion.Open();

                            commande = new SqlCommand(query, connexion);

                            adapteur.UpdateCommand = commande;

                            int ligneAffecte = adapteur.UpdateCommand.ExecuteNonQuery();
                            if (ligneAffecte > 0)
                            {
                                MessageBox.Show($"La modification a été realisé!\nVotre nouveau {colonneAModifier} est: {txtb_nouvValeur_modifierCompte.Text}");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Il y a eu un erreur lors de la modification de votre compte", "Erreur!");
                            }
                            commande.Dispose();
                            connexion.Close();
                        }
                        else
                        {
                            MessageBox.Show("Assurez vous d'entrer une valeur valide", "Attention");
                            txtb_nouvValeur_modifierCompte.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Assurez vous d'entrer une valeur valide!", "Attention!!");
                    
                }
            }
        }
    }
}
