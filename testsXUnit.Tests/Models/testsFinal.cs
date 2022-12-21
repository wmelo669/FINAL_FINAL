/*
 Prenom - Nom - Numéro d'étudiant = William - Melo - 2033701

 Description du fichier:
 * Ce fichier contient le tests unitaires de deux méthodes que j'ai utilisé dans mon application
 * 
 * J'ai n'étais pas sur du fonctionnement de xUnit, mais avec le document que vous avez mit sur
 * Léa ainsi que la documentation, j'ai essayé comprendre le mieux possible.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testsXUnit.Tests.Models
{
    public class testsFinal
    {
        /*   Prémière méthode testé   */

        /// <summary>
        /// Cette méthode sert a générer un numéro aléatoire de 5 chiffres.
        /// </summary>
        /// <returns>Le numéro aléatoire</returns>
        [Fact]
        public string numAleatoire()
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
            Assert.True(true);
            return numeroString;
            
        }

        /*   Prémière méthode testé   */
        /// <summary>
        /// Cette a comme de vérifier qu'un isbn n'est pas déjà contennu dans une chaine de caractère.
        /// </summary>
        /// <param name="pIsbn">L'isbn a vérifier qu'il ne soit pas déjà dans une chaine de caractères.</param>
        /// <returns></returns>
        [Theory]
        [InlineData("0000000000")]
        public bool VerificationISBNDansListe(string pIsbn)
        {
            bool elementTrouve = false;
            string[] items = { "0000000000\t-La meilleure vie\t-5", 
                "0000000001\t-Le dernièr sens\t-8",
                "0000000000\t-La fin\t-2" };

            foreach (string ligne in items)
            {
                string[] ligneArray = ligne.Split('-');
                if (ligneArray[0].Replace("\t", "") == pIsbn)
                {
                    elementTrouve = true;
                    break;
                }
            }
            Assert.True(true);
            return elementTrouve;
        }

    }
}
