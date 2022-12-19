using projetFinal.classesEtInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetFinal.formulaires
{
    public partial class FormEmploye : System.Windows.Forms.Form
    {
        public FormEmploye()
        {
            InitializeComponent();
        }

        private void rechargerLeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Outils.formCreerAuteurDispo)
            {
                creerAuteurToolStripMenuItem.Enabled = true;
            }
            if (Outils.formCreerEmploye)
            {
                creerEmployéToolStripMenuItem.Enabled = true;
            }
            if(Outils.formCreerClientEmploye)
            {
                creerClientToolStripMenuItem.Enabled = true;
            }
            if (Outils.formCreerLivre)
            {
                creerLivreToolStripMenuItem.Enabled = true;
            }
            if (Outils.formVisualiserEmployes)
            {
                voirEmployésToolStripMenuItem.Enabled = true;
            }
            if (Outils.formModifierEmployeDispo)
            {
                modifierEmployéToolStripMenuItem.Enabled = true;
            }
        }

        private void creerAuteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Vérifier qu'il n'ait pas d'autre formulaire pour creer un auteur
            if (Outils.formCreerAuteurDispo == true)
            {
                Outils.formCreerAuteurDispo = false;
                creerAuteurToolStripMenuItem.Enabled = false;
                FormCreerAuteur formulaireCreerAuteur = new FormCreerAuteur();
                formulaireCreerAuteur.MdiParent = this;
                formulaireCreerAuteur.Show();
            }
        }

        private void FormEmploye_FormClosing(object sender, FormClosingEventArgs e)
        {
            Outils.formCreerAuteurDispo = true;
            Outils.formCreerEmploye = true;
            Outils.formCreerClientEmploye = true;
            Outils.formCreerLivre = true;
            Outils.formVisualiserEmployes = true;
            Outils.formModifierEmployeDispo = true;
        }

        /// <summary>
        /// Cette méthode est le gestionnaire d'évènements lors que l'évènement click est
        /// deckanché dans le menu strip dans l'option créer employé.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void creerEmployéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Outils.formCreerEmploye)
            {
                Outils.formCreerEmploye = false;
                creerEmployéToolStripMenuItem.Enabled = false;
                FormCompteEmploye formulaireCreerCompte_e = new FormCompteEmploye();
                formulaireCreerCompte_e.MdiParent = this;
                formulaireCreerCompte_e.Show();
            }
        }

        /// <summary>
        /// Gestionnaire de l'évènement click du button créér du menu strip dans la
        /// section pour les employés
        /// </summary>
        /// <param name="sender">Le bouton voir employé dans le menu strip</param>
        /// <param name="e">L'évènement click envoyé par la bouton creer client</param>
        private void creerClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Outils.formCreerClientEmploye)
            {
                Outils.formCreerClientEmploye = false;
                creerClientToolStripMenuItem.Enabled = false;
                FormCompte formulaireCreerCompte_c = new FormCompte();
                formulaireCreerCompte_c.MdiParent = this;
                formulaireCreerCompte_c.Show();
            }
        }

        /// <summary>
        /// Gestionnaire de l'évènement click du bouton pour creer un livre dans le
        /// secteur pour les employées.
        /// </summary>
        /// <param name="sender">Le bouton pour creer un livre</param>
        /// <param name="e">L'évènement click du bouton click pour crééer un livre.</param>
        private void creerLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Outils.formCreerLivre)
            {
                Outils.formCreerLivre = false;
                creerLivreToolStripMenuItem.Enabled = false;
                FormCreerLivre formulaireCreerLivre = new FormCreerLivre();
                formulaireCreerLivre.MdiParent = this;
                formulaireCreerLivre.Show();
            }
        }

        /// <summary>
        /// Gestionnaire de l'évènement click du bouton pour voir les employés dans le
        /// menu strip dans le secteur pour les employés.
        /// </summary>
        /// <param name="sender">Le bouton pour voir les employé dans le secteur pour les employés.</param>
        /// <param name="e"></param>
        private void voirEmployésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Outils.formVisualiserEmployes)
            {
                Outils.formVisualiserEmployes = false;
                voirEmployésToolStripMenuItem.Enabled = false;
                FormRegarderEmployes formulaireRegarderEmployes = new FormRegarderEmployes();
                formulaireRegarderEmployes.MdiParent = this;
                formulaireRegarderEmployes.Show();
            }
        }

        private void modifierEmployéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Outils.formModifierEmployeDispo)
            {
                Outils.formModifierEmployeDispo = false;
                modifierEmployéToolStripMenuItem.Enabled = false;
                FormModifierCompte formulaireModifierCompte = new FormModifierCompte();
                formulaireModifierCompte.MdiParent = this;
                formulaireModifierCompte.Show();
            }
        }
    }
}
