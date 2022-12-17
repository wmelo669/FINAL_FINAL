using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetFinal.classesEtInterfaces;
using projetFinal.formulaires;

namespace projetFinal.formulaires
{
    public partial class FormClient : Form
    {
        //Variables globales

        public FormClient()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cette méthode est le gestionnaire d'évènements de l'évènemnt click du button creeerCompte dans le menuStrip
        /// </summary>
        /// <param name="sender">Objet qui envoie l'évènement</param>
        /// <param name="e">Évènements envotés par l'objet</param>
        private void espaceClient_creerCompte_click(object sender, EventArgs e)
        {   
            //Vérifier qu'il n'ait pas d'autre formulaire pour creer un compte client
            if(Outils.formCreerClientDispo ==true)
            {
                Outils.formCreerClientDispo = false;
                ms_creerCompte_btn.Enabled = false;
                FormCompte formulaireCreerCompte = new FormCompte();
                formulaireCreerCompte.MdiParent = this;
                formulaireCreerCompte.Show();           
            }

        }

        /// <summary>
        /// Cette méthode est le gestionnaire d'évènements de l'évènemnt FormClosing du formulaire FormClient
        /// </summary>
        /// <param name="sender">Objet qui envoit les évènements</param>
        /// <param name="e">Évènements envoyés par l'objet</param>
        private void FormClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Mise a jour de la varibale pour savoir si formulaire créer ou non
            Outils.formCreerClientDispo = true;
            Outils.formModifierClientDispo = true;
        }

        /// <summary>
        /// Cette méthode est le gestionnaire d'évènements de l'évènemnt click du button rechargerMenu dans le menuStrip.
        /// Actualise le menu si une fenetre est disponible ou non.
        /// </summary>
        /// <param name="sender">Objet qui envoit les évènements</param>
        /// <param name="e">Évènements envoyés par l'objet</param>
        private void rechargerLeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Vérifier si formulaire pour créer compte est disponible
            if(Outils.formCreerClientDispo == true)
            {
                ms_creerCompte_btn.Enabled = true;
            }
            if(Outils.formModifierClientDispo == true)
            {
                modifierCompteToolStripMenuItem.Enabled = true;
            }
        }

        /// <summary>
        /// Cette méthode est le gestionnaire d'évènements de l'évènemnt click du button modifier compte du menuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifierCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Vérifier qu'il n'ait pas d'autre formulaire pour mdofier un compte
            if (Outils.formModifierClientDispo == true)
            {
                Outils.formModifierClientDispo = false;
                modifierCompteToolStripMenuItem.Enabled = false;
                FormModifierCompte formulaireModifierCompte = new FormModifierCompte();
                formulaireModifierCompte.MdiParent = this;
                formulaireModifierCompte.Show();
            }

        }
    }
}
