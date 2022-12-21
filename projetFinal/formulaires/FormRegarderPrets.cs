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
    public partial class FormRegarderPrets : System.Windows.Forms.Form
    {
        //Accès a la base de données
        SqlConnection connexion;
        string query;
        string connexionString = ConfigurationManager.ConnectionStrings["connexionSqlServer"].ConnectionString;
        SqlCommand commande;
        SqlDataReader resultat;

        public FormRegarderPrets()
        {
            InitializeComponent();
        }

        private void FormRegarderPrets_FormClosing(object sender, FormClosingEventArgs e)
        {
            Outils.formRegarderPrets = true;
        }

        /// <summary>
        /// Gestionnaire de l'évènement click du bouton valider pour afficher les prets d'un compte.
        /// </summary>
        /// <param name="sender">Le bouton valider</param>
        /// <param name="e">L'évènement click.</param>
        private void btn_validerNumCompte_visualizerEmprunt_Click(object sender, EventArgs e)
        {
            query = $"SELECT * FROM Facture_t WHERE numCompte = '{txtb_numCompte_visualizerEmprunt.Text}'";
            connexion = new SqlConnection();
            connexion.ConnectionString = connexionString;
            commande = new SqlCommand(query, connexion);

            commande.CommandText = query;

            connexion.Open();
            resultat = commande.ExecuteReader();

            if (resultat.HasRows)
            {
                //Vider la liste après chaque click pour actualiser la liste view.
                listView_visualiserPrets.Items.Clear();
                while (resultat.Read())
                {                   
                    ListViewItem lvItem = new ListViewItem((string)resultat[0]);    
                    lvItem.SubItems.Add((string)resultat[1]);
                    lvItem.SubItems.Add((string)resultat[2]);
                    lvItem.SubItems.Add(resultat[3].ToString());
                    lvItem.SubItems.Add(resultat[4].ToString());
                    listView_visualiserPrets.Items.Add(lvItem);
                }
            }
            else
            {
                MessageBox.Show("La table ne contient aucune ligne!", "Erreur!");
            }
        }
    }
}
