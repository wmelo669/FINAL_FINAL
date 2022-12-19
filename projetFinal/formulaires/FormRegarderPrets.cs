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
    public partial class FormRegarderPrets : System.Windows.Forms.Form
    {
        //Accès a la base de données
        SqlConnection connexion;
        string query;
        string connexionString = "Data Source=localhost;Initial Catalog=examFinal;User ID=sa;Password=sql";
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

        private void btn_validerNumCompte_visualizerEmprunt_Click(object sender, EventArgs e)
        {
            /*
             Dans cette partie, il y a une erreur lors de l'affichage dans la liste view, mais j'ai manqué du temps
            pour l'arranger
             */

            query = $"SELECT * FROM Facture_t WHERE numCompte = '{txtb_numCompte_visualizerEmprunt.Text}'";
            connexion = new SqlConnection();
            connexion.ConnectionString = connexionString;
            commande = new SqlCommand(query, connexion);

            commande.CommandText = query;

            connexion.Open();
            resultat = commande.ExecuteReader();

            if (resultat.HasRows)
            {
                listview_visualizerPrets.Items.Clear();
                while (resultat.Read())
                {                   
                    ListViewItem lvItem = new ListViewItem();
                    lvItem.SubItems.Add((string)resultat[0]);
                    lvItem.SubItems.Add((string)resultat[1]);
                    lvItem.SubItems.Add((string)resultat[2]);
                    lvItem.SubItems.Add(resultat[3].ToString());
                    lvItem.SubItems.Add(resultat[4].ToString());
                    listview_visualizerPrets.Items.Add(lvItem);
               
                }
            }
            else
            {
                MessageBox.Show("La table ne contient aucune ligne!", "Erreur!");
            }
        }
    }
}
