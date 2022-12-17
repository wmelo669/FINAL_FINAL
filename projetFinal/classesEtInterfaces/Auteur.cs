using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace projetFinal.classesEtInterfaces
{
    class Auteur : IAuteur
    {
        //Attributs
        private string nomAuteur;
        private string prenomAuteur;
        private string idAuteur;
        private DateTime datedeNaissanceAuteur;
        private string paysDOrigineAuteur;

        //Propriétés

        //NOM
        public string NomAuteur
        {
            get { return nomAuteur; }
            set
            {
                bool validerNom = Regex.IsMatch(value, "^[A-Z]{1}[a-z]{1,29}$");
                if(validerNom)
                {
                    this.nomAuteur = value;
                }
            }
        }

        //PRENOM AUTEUR 
        public string PrenomAuteur
        {
            get { return prenomAuteur; }
            set
            {
                bool verifierPrenom = Regex.IsMatch(value, "^[A-Z]{1}[a-z]{1,29}$");
                if(verifierPrenom)
                {
                    this.prenomAuteur = value;
                }
            }
        }

        //ID AUTEUR
        public string IdAuteur
        {
            get { return idAuteur; }
            set
            {
                bool verifierNumAuteur = Regex.IsMatch(value, "^[0-9]{6}$");
                if(verifierNumAuteur)
                {
                    this.idAuteur = value;
                }
            }
        }

        //DATE DE NAISSANCE
        public DateTime DateDeNaissanceAuteur
        {
            get { return this.datedeNaissanceAuteur; }
            set
            {
                if((DateTime.Now - value).Days /365 >= 18)
                {
                    this.datedeNaissanceAuteur = value;
                }
            }
        }

        //PAYS D'ORIGINE
        public string PaysDOrigineAuteur
        {
            get { return this.paysDOrigineAuteur; }
            set
            {
                bool verifierPaysDOrigine = Regex.IsMatch(value, "^[A-Z]{1}[a-z]{1,29}$");
                if (verifierPaysDOrigine)
                {
                    this.paysDOrigineAuteur = value;
                }
            }
        }

        /// <summary>
        /// Constructeur de la classe Auteur
        /// </summary>
        /// <param name="pNom">Nom de l'auteur</param>
        /// <param name="pPrenom">Prenom de l'auteur</param>
        /// <param name="pIdAuteur">ID de l'auteur</param>
        /// <param name="pDatedeNaissanceAuteur">Date de naissance de l'auteur</param>
        /// <param name="pPaysDOrigineAuteur">Pays d'origine de l'auteur</param>
        public Auteur(string pNom = "*", string pPrenom = "*", string pIdAuteur = "*", DateTime pDatedeNaissanceAuteur = default(DateTime),
            string pPaysDOrigineAuteur = "*")
        {
            this.nomAuteur = pNom;
            this.prenomAuteur = pPrenom;
            this.idAuteur = pIdAuteur;
            this.datedeNaissanceAuteur = pDatedeNaissanceAuteur;
            this.paysDOrigineAuteur = pPaysDOrigineAuteur;
        }

        //TODO: Les méthode calculerAge et nbDItems doivent etre terminées d'etre dévlopées. (Auteur)
        public int CalculerAge(DateTime pDateDeNaissance)
        {
            DateTime dateEnCeMoment = DateTime.Today;
            TimeSpan calculeDeLage = dateEnCeMoment - pDateDeNaissance;
            int age = calculeDeLage.Days / 365;

            return age;
        }

        public int nbDItems()
        {
            return 0;
        }

        /// <summary>
        /// Méthode override ToString pour afficher les informations de l'auteur
        /// </summary>
        /// <returns>La chaine de caractére contenant les informations de l'auteur!</returns>
        public override string ToString()
        {
            string affichage = $"ID de l'auteur: {this.idAuteur}\nNom de l'auteur: {this.nomAuteur}\n" +
                $"Prenom de l'auteur: {this.prenomAuteur}\nDate de naissnce de l'auteur: {this.datedeNaissanceAuteur}\n" +
                $"Pays d'oigine de l'auteur{this.paysDOrigineAuteur}";
            return affichage;
        }
    }
}
