using projetFinal.formulaires;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetFinal
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();

            //Pour faire que le formulaire ne puisse pas est redimentionné
            //Source: https://www.syncfusion.com/kb/12379/how-to-disable-resizing-of-a-winforms-metroform
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// Cette méthode est le gestionnaire d'évènements de l'évènemnt click du bouton client dans le menu principal
        /// </summary>
        /// <param name="sender">Objet qui envoit les évènements</param>
        /// <param name="e">Évènements envoyés par l'objet</param>
        private void btn_client_menu_click(object sender, EventArgs e)
        {
            FormClient formulaireClient = new FormClient();
            this.Hide();
            formulaireClient.ShowDialog();
            this.Show();  
        }

        private void btn_employe_menu_Click(object sender, EventArgs e)
        {
            FormEmploye formulaireEmploye = new FormEmploye();
            this.Hide();
            formulaireEmploye.ShowDialog();
            this.Show();
        }
    }

    
}
