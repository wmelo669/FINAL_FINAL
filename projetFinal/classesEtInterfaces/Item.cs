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
        protected string idAuteur;
        protected DateTime dateDeParution;
        protected string langueDOrigine;


        public abstract string NumeroItem { get; set; }
        public abstract string Titre { get; set; }
        public abstract string IdAuteur { get; set; }
        public abstract DateTime DateDeParution { get; set; }
        public abstract string LangueDOrigine { get; set; }

        public Item(string pNumeroItem = "*", string pTitre = "*", string pIdAuteur = "",
            DateTime pDateDeParution = default(DateTime), string pLangueDOrigine = "*")
        {
            this.numeroItem = pNumeroItem;
            this.titre = pTitre;
            this.idAuteur = pIdAuteur;
            this.dateDeParution = pDateDeParution;
            this.langueDOrigine = pLangueDOrigine;
        }

    }
}
