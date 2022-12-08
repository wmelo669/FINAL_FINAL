using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Constructeur static de la classe Outils
        /// </summary>
        static Outils()
        {
            nombreDAuteurs = 0;
            nombreDeLivres = 0;
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
    }
}
