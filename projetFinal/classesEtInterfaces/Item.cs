using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal.classesEtInterfaces
{
    abstract class Item
    {
        //Attributs
        protected string numeroItem;
        protected string titre;
        protected Auteur auteur_;
        protected DateTime dateDeParution;
        protected string langueDOrigine;


        public abstract string NumeroItem { get; set; }
        public abstract string Titre { get; set; }
        public abstract Auteur Auteur_ { get; set; }
        public abstract DateTime DateDeParution { get; set; }
        public abstract string LangueDOrigine { get; set; }

        public Item(string pNumeroItem = "*", string pTitre = "*", Auteur pAuteur = default(Auteur),
            DateTime pDateDeParution = default(DateTime), string pLangueDOrigine = "*")
        {
            this.numeroItem = pNumeroItem;
            this.titre = pTitre;
            this.auteur_ = pAuteur;
            this.dateDeParution = pDateDeParution;
            this.langueDOrigine = pLangueDOrigine;
        }

    }
}
