using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace projetFinal.classesEtInterfaces
{
    class Livre : Item
    {
        //Attributs
        private string isbn;
        private int nombreDePage;
        private int nbDeChapitres;
        private string maisonDEdition;
        private int quantite;

        //Propriétés

        //ISBN
        public string Isbn
        {
            get { return this.isbn; }
            set
            {
                bool validerIsbn = Regex.IsMatch(value, "^[0-9]{10}$");
                if (validerIsbn)
                {
                    this.isbn = value;
                }
            }
        }

        //NOMBRE DE PAGES
        public int NombreDePage
        {
            get { return this.nombreDePage; }
            set
            {
                if (value > 0)
                {
                    this.nombreDePage = value;
                }
            }
        }

        //OMBRE DE CHAPITRES
        public int NbDeChapitres
        {
            get { return this.nbDeChapitres; }
            set
            {
                if (value > 0)
                {
                    this.nbDeChapitres = value;
                }
            }
        }

        //MAISON D'ÉDITION
        public string MaisonDEdition
        {
            get { return this.maisonDEdition; }
            set
            {
                if (value.Length > 0)
                {
                    this.maisonDEdition = value;
                }
            }
        }

        //QUANTITÉ
        public int Quantite
        {
            get { return this.quantite; }
            set
            {
                if (value >= 0)
                {
                    this.quantite = value;  
                }
            }
        }

        // NUMERO D'ITEM
        public override string NumeroItem
        {
            get { return base.numeroItem; }
            set
            {
                bool validerNumItem = Regex.IsMatch(value, "^[0-9]{7}$");
                if (validerNumItem)
                {
                    base.numeroItem = value;
                }
            }
        }

        //TITRE DU LIVRE
        public override string Titre
        {
            get { return base.titre; }
            set
            {
                bool validerTitre = Regex.IsMatch(value, "^.{1,50}$");
                if (validerTitre)
                {
                    base.titre = value;
                }
            }
        }

        //Id Auteur
        public override string IdAuteur
        {
            get { return base.idAuteur; }
            set { base.idAuteur = value; }
        }

        //DATE DE PARUTION
        public override DateTime DateDeParution
        {
            get { return base.dateDeParution; }
            set
            {
                if (value < DateTime.Now)
                {
                    base.dateDeParution = value;
                }
            }
        }

        //LANGUE D'ORIGINE
        public override string LangueDOrigine
        {
            get { return base.langueDOrigine; }
            set
            {
                bool verifierLangue = Regex.IsMatch(value, "^[A-Z]{1}[a-z]{1,49}$");
                if (verifierLangue)
                {
                    this.langueDOrigine = value;
                }
            }
        }

        /// <summary>
        /// Constructeur de la classe Livre
        /// </summary>
        /// <param name="pIsbn">ISBN du livre</param>
        /// <param name="pNombreDePages">Nombre de pages du livre</param>
        /// <param name="pNbDeChapitres">Nombre de chapitres du livre</param>
        /// <param name="pMaisonDEdition">Maison d'édition du livre</param>
        /// <param name="pNumeroItem">Numero d'item livre</param>
        /// <param name="pTitre">Titre du livre</param>
        /// <param name="pIdAuteur">Auteur du livre</param>
        /// <param name="pDateDeParution">Date de parution du livre.</param>
        /// <param name="pLangueDOrigine">Langue d'origine du livre</param>
        public Livre(string pIsbn = "*", int pNombreDePages = 0, int pNbDeChapitres = 0,
            string pMaisonDEdition = "*", int pQuantite = 0, string pNumeroItem = "*", string pTitre = "*",
            string pIdAuteur = "0", DateTime pDateDeParution = default(DateTime),
            string pLangueDOrigine = "*")
            :base(pNumeroItem, pTitre, pIdAuteur, pDateDeParution, pLangueDOrigine)
        {
            this.isbn = pIsbn;
            this.nombreDePage = pNombreDePages;
            this.nbDeChapitres = pNbDeChapitres;
            this.maisonDEdition = pMaisonDEdition;
            this.Quantite = pQuantite;
        }

        public override string ToString()
        {
            string affichage = $"ISBN: {this.isbn}\nNombre de pages: {this.nombreDePage}\nNombre de chapitres: {this.nbDeChapitres}" +
                $"\nMaison d'édition: {this.maisonDEdition}\nNumero d'item: {this.numeroItem}\nTitre: {this.titre}\n" +
                $"ID de l'auteur: {this.idAuteur}\n";
            return affichage;
        }
    }
}
