using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal.classesEtInterfaces
{
    interface IAuteur
    {
        //Propriétées
        string NomAuteur { get; set; } 
        string PrenomAuteur { get; set; }
        string IdAuteur { get; set; }
        DateTime DateDeNaissanceAuteur { get; set; }
        string PaysDOrigineAuteur { get; set; }

        //Méthodes
        int CalculerAge();
        int nbDItems();
    }
}
