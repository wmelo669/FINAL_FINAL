using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace projetFinal.classesEtInterfaces
{
    class Compte
    {
        //Attributs de la classe Compte
        private string numCompte;
        private string nomCompte;
        private string prenomCompte;
        private string typeCompte;
        private string motDePasse;

        //Proprétés

        //NUMÉRO DE COMPTE
        public string NumCompte
        {
            get { return this.numCompte; }
            set
            {
                bool validerNumCompt = Regex.IsMatch(value, "^[0-9]{6}$");
                if(validerNumCompt)
                {
                    this.numCompte = value;
                }
            }
        }

        //NOM DE COMPTE
        public string NomCompte
        {
            get { return this.nomCompte; }
            set
            {
                bool valideNomCompte = Regex.IsMatch(value, "^[A-Z]{1}[a-z]{1,49}$");
                if (valideNomCompte)
                {
                    this.nomCompte = value;
                }
            }
        }

        //PRENOM DE COMPTE
        public string PrenomCompte
        {
            get { return this.prenomCompte; }
            set
            {
                bool validePrennomCompte = Regex.IsMatch(value, "^[A-Z]{1}[a-z]{1,49}$");
                if(validePrennomCompte)
                {
                    this.prenomCompte = value;
                }
            }
        }

        //TYPE DE COMPTE
        public string TypeCompte
        {
            get { return this.typeCompte; }
            set { this.typeCompte = value; }
        }

        //MOT DE PASSE DU COMPTE
        public string MotDePasse
        {
            get { return this.motDePasse; }
            set
            {
                if(value.Length  > 0)
                {
                    this.motDePasse = value;
                }
            }
        }

        /// <summary>
        /// Constructeur de la classe Compte
        /// </summary>
        /// <param name="pNumCompte">Numero du compte</param>
        /// <param name="pNomCompte">Nom de la personne</param>
        /// <param name="pPrenomCompte">Prenom de la personne</param>
        /// <param name="pTypeCompte">Type de compte, donc employé ou client</param>
        /// <param name="pMotDePasse">Mot de passe du compte</param>
        public Compte(string pNumCompte = "*", string pNomCompte = "*", string pPrenomCompte = "*",
            string pTypeCompte = "*", string pMotDePasse = "*")
        {
            this.numCompte = pNumCompte;
            this.nomCompte = pNomCompte;
            this.prenomCompte = pPrenomCompte;
            this.typeCompte = pTypeCompte;
            this.motDePasse = pMotDePasse;
        }

        public override string ToString()
        {
            string affichage = $"Numero du compte: {this.numCompte}\nNom: {this.nomCompte}\nPrenom: {this.prenomCompte}\n" +
                $"Type de compte: {this.typeCompte}\n";
            return affichage;
        }

    }
}
