using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal.classesEtInterfaces
{
    /// <summary>
    /// Classe statique Outils
    /// </summary>
    static class Outils
    {

        //Propriétés 
        public static int nombreDAuteurs;
        public static int nombreDeLivres;
        public static bool formCreerClientDispo;
        public static bool formModifierClientDispo;
        public static bool formCreerAuteurDispo;
        public static bool formCreerEmploye;
        public static bool formCreerClientEmploye;
        public static bool formCreerLivre;
        public static bool formVisualiserEmployes;
        public static bool formModifierEmployeDispo;

        /// <summary>
        /// Constructeur static de la classe Outils
        /// </summary>
        static Outils()
        {
            nombreDAuteurs = 0;
            nombreDeLivres = 0;
            formCreerClientDispo = true;
            formModifierClientDispo = true;
            formCreerAuteurDispo = true;
            formCreerEmploye = true;
            formCreerClientEmploye = true;
            formCreerLivre = true;
            formVisualiserEmployes = true;
            formModifierEmployeDispo = true;


        }

        /// <summary>
        /// Cette méthode calcule et retourne l'age par rapport a une date recu.
        /// </summary>
        /// <param name="pDate">La date pour calculer l'age</param>
        /// <returns></returns>
        static int CalculerAge(DateTime pDate)
        {
            return (DateTime.Now - pDate).Days / 365;
        }

        //Cette méthode sert a vérifier que le numéro d'ID soit unique
        public static bool IdAuteurUnique(string pIdAuteur)
        {
            //Accès a la base de données
            SqlConnection connexion;
            string query;
            string connexionString = "Data Source=localhost;Initial Catalog=examFinal;User ID=sa;Password=sql";
            SqlCommand commande;
            SqlDataReader resultat;

            connexion = new SqlConnection();
            connexion.ConnectionString = connexionString;
            query = $"SELECT * FROM Auteur_t WHERE idAuteur = {pIdAuteur}";
            commande = new SqlCommand(query, connexion);

            connexion.Open();
            resultat = commande.ExecuteReader();

            if (resultat != null)
            {
                if (resultat.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        //Cette méthode verifie que le numéro de compte soit unique
        public static bool NumCompteUnique(string p_NumCompte)
        {
            //Accès a la base de données
            SqlConnection connexion;
            string query;
            string connexionString = "Data Source=localhost;Initial Catalog=examFinal;User ID=sa;Password=sql";
            SqlCommand commande;
            SqlDataReader resultat;

            connexion = new SqlConnection();
            connexion.ConnectionString = connexionString;
            query = $"SELECT * FROM Compte_t WHERE numCompte = {p_NumCompte}";
            commande = new SqlCommand(query, connexion);

            connexion.Open();
            resultat = commande.ExecuteReader();

            if (resultat != null)
            {
                if (resultat.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool IdAuteurExistant(string pNumAuteur)
        {
            //Accès a la base de données
            SqlConnection connexion;
            string query;
            string connexionString = "Data Source=localhost;Initial Catalog=examFinal;User ID=sa;Password=sql";
            SqlCommand commande;
            SqlDataReader resultat;

            connexion = new SqlConnection();
            connexion.ConnectionString = connexionString;
            query = $"SELECT * FROM Auteur_t WHERE idAuteur = '{pNumAuteur}'";
            commande = new SqlCommand(query, connexion);

            connexion.Open();
            resultat = commande.ExecuteReader();

            if (resultat != null)
            {
                if (resultat.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool IsbnUnique(string pIsbn)
        {
            //Accès a la base de données
            SqlConnection connexion;
            string query;
            string connexionString = "Data Source=localhost;Initial Catalog=examFinal;User ID=sa;Password=sql";
            SqlCommand commande;
            SqlDataReader resultat;

            connexion = new SqlConnection();
            connexion.ConnectionString = connexionString;
            query = $"SELECT * FROM Livre_t WHERE isbn = {pIsbn}";
            commande = new SqlCommand(query, connexion);

            connexion.Open();
            resultat = commande.ExecuteReader();

            if (resultat != null)
            {
                if (resultat.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool NumItemUnique(string pNumItem)
        {
            //Accès a la base de données
            SqlConnection connexion;
            string query;
            string connexionString = "Data Source=localhost;Initial Catalog=examFinal;User ID=sa;Password=sql";
            SqlCommand commande;
            SqlDataReader resultat;

            connexion = new SqlConnection();
            connexion.ConnectionString = connexionString;
            query = $"SELECT * FROM Livre_t WHERE numeroItem = {pNumItem}";
            commande = new SqlCommand(query, connexion);

            connexion.Open();
            resultat = commande.ExecuteReader();

            if (resultat != null)
            {
                if (resultat.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
