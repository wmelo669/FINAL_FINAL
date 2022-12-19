using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public static bool formFairePrets;
        public static bool formRegarderPrets;


        /// <summary>
        /// Constructeur static de la classe Outils pour initilizer les données.
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
            formFairePrets = true;
            formRegarderPrets = true;
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

        /// <summary>
        /// Cette méthode sert a returner une information d'un auteur dependament des paramètres
        /// </summary>
        /// <param name="pIdAuteur">ID de l'auteur a regarder pour de l'information.</param>
        /// <param name="pInfoDemande">Le nom, le prenom etc...</param>
        /// <returns></returns>
        public static object AvoirInfoAuteur(string pIdAuteur, string pInfoDemande)
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

            if (resultat.HasRows)
            {
                if(pInfoDemande == "idAuteur")
                {
                    return resultat[0];
                }
                else if (pInfoDemande == "nomAuteur")
                {
                    return resultat[1];
                }
                else if (pInfoDemande == "prenomAuteur")
                {
                    return resultat[2];
                }
                else if (pInfoDemande == "dateDeNaissanceAuteur")
                {
                    return resultat[3];
                }
                else if (pInfoDemande == "paysDOrigine")
                {
                    return resultat[4];
                }
                else
                {
                    return default;
                }
            }
            else
            {
                return default;
            }
        }

        /// <summary>
        /// Cette métho a comme but de creer un string compossé de 5 chiffres de facon aléatoire. Ces
        /// 5 chiffres representeront le numéro de facture.
        /// </summary>
        /// <returns></returns>
        public static string creerNumFacture()
        {
            //Function que crée les numéros aléatoires
            string numAleatoire()
            {
                //Création du numéro de 5 caractères aléatoire
                Random aleatoire = new Random();
                int numeroInt = aleatoire.Next(99999);
                string numeroString = numeroInt.ToString();

                //Ajout de zéros pour que le numéro de facture soit exactement d'un longeur de 5 caractères.
                while (numeroString.Length < 5)
                {
                    numeroString += "0";
                }

                //Rétoure de la valeur finale qui correspond avec la mise en forme voulu.
                return numeroString;
            }

            //Accès a la base de données.
            SqlConnection connexion;
            string query;
            string connexionString = "Data Source=localhost;Initial Catalog=examFinal;User ID=sa;Password=sql";
            SqlCommand commande;
            SqlDataReader resultat;

            string numAl;

            //Cette boucle fini que lorsque lors de la selection dans la base de données, le
            //resultat retourne aucune ligne.
            while (true)
            {
                numAl = numAleatoire();
                connexion = new SqlConnection();
                connexion.ConnectionString = connexionString;
                query = $"SELECT * FROM Facture_t WHERE numeroFacture = '{numAl}'";
                commande = new SqlCommand(query, connexion);

                connexion.Open();
                resultat = commande.ExecuteReader();

                if (resultat.HasRows)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            
            //Retour du numéro de facture avec toute les validations.
            return numAl;
        }
    }
}
