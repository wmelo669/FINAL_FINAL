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
    public partial class FormRegarderEmployes : System.Windows.Forms.Form
    {
        //Variables globales

        //Accès a la base de données
        SqlConnection connexion;
        string query;
        string connexionString = ConfigurationManager.ConnectionStrings["connexionSqlServer"].ConnectionString; 
        SqlCommand commande;
        SqlDataReader resultat;

        public FormRegarderEmployes()
        {
            InitializeComponent();
        }

        

        private void FormRegarderEmployes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Outils.formVisualiserEmployes = true;
        }

        /// <summary>
        /// Gestionnaire de l'évènement click du boutton supprimer dans visualiser les employés
        /// </summary>
        /// <param name="sender">Le boutton supprimer</param>
        /// <param name="e">L'évènement click</param>
        private void btn_supprimer_visualiserEmployes(object sender, EventArgs e)
        {
            
            foreach(DataGridViewRow row in dataGridViewEmployes_visualiserEmployes.SelectedRows)
            {
                try
                {
                    //Requete SQL
                    query = $"DELETE FROM Compte_t WHERE numCompte = '{row.Cells[0].Value}'";

                    //Connexion avec la base de donnée
                    connexion = new SqlConnection();
                    connexion.ConnectionString = connexionString;
                    commande = new SqlCommand(query, connexion);
                    connexion.Open();
                    SqlDataAdapter resultat = new SqlDataAdapter();

                    //Execution de commande
                    resultat.DeleteCommand = commande;
                    resultat.DeleteCommand.ExecuteNonQuery();
                    commande.Dispose();
                    connexion.Close();
                    dataGridViewEmployes_visualiserEmployes.Rows.RemoveAt(row.Index);

                }
                catch(Exception ex)
                {
                    //Si la dernière cellule qui est vide qui est tout le temps créer automatiquement est selectionné.
                    MessageBox.Show(ex + "\n\nAssurez vous de prendre de selectionner une ligne valide!!", "Attention!!!");
                }
            }
           
        }

        /// <summary>
        /// Gestionnaire d'évènements lors du chargement de la fenetre pour regarder les employés
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormRegarderEmployes_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM Compte_t WHERE typeCompte = 'Employe';";
            connexion = new SqlConnection();
            connexion.ConnectionString = connexionString;
            commande = new SqlCommand(query, connexion);

            commande.CommandText = query;

            connexion.Open();
            resultat = commande.ExecuteReader();

            if(resultat.HasRows)
            {
                while (resultat.Read())
                {
                    dataGridViewEmployes_visualiserEmployes.Rows.Add(resultat[0], resultat[1], resultat[2],
                        resultat[3], resultat[4]);
                }
            }
            else
            {
                //Si la table ne contient aucune ligne
                MessageBox.Show("La table de compte employé es vide", "");
            }

        }
    }
}
