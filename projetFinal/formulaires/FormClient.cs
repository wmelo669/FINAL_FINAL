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
    public partial class FormClient : System.Windows.Forms.Form
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
            Outils.formFairePrets = true;
            Outils.formRegarderPrets = true;
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
            if (Outils.formFairePrets == true)
            {
                faireUnPretToolStripMenuItem.Enabled = true;
            }
            if(Outils.formRegarderPrets == true)
            {
                regarderPretToolStripMenuItem.Enabled = true;
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

        /// <summary>
        /// Gestionanaire de l'évènement click envoyé par le bouton du menu strip faire prets
        /// </summary>
        /// <param name="sender">Bouton menu strip faire pret</param>
        /// <param name="e">Évènement click du bouton fiare pret dans le menu strip</param>
        private void faireUnPretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Outils.formFairePrets == true)
            {
                Outils.formFairePrets = false;
                faireUnPretToolStripMenuItem.Enabled = false;
                FormPrets formulairePrets = new FormPrets();
                formulairePrets.MdiParent = this;
                formulairePrets.Show();
            }
        }

        private void regarderPretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Outils.formRegarderPrets == true)
            {
                Outils.formRegarderPrets = false;
                regarderPretToolStripMenuItem.Enabled = false;
                FormRegarderPrets formRegarderPrets = new FormRegarderPrets();
                formRegarderPrets.MdiParent = this;
                formRegarderPrets.Show();
            }
        }
    }
}
