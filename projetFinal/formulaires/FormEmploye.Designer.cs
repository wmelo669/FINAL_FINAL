namespace projetFinal.formulaires
{
    partial class FormEmploye
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rechargerLeMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerAuteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerEmployéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerLivreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirEmployésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirPretsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirBibliothequeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechargerLeMenuToolStripMenuItem,
            this.creerAuteurToolStripMenuItem,
            this.creerEmployéToolStripMenuItem,
            this.creerClientToolStripMenuItem,
            this.creerLivreToolStripMenuItem,
            this.voirEmployésToolStripMenuItem,
            this.voirPretsToolStripMenuItem,
            this.voirBibliothequeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rechargerLeMenuToolStripMenuItem
            // 
            this.rechargerLeMenuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rechargerLeMenuToolStripMenuItem.Name = "rechargerLeMenuToolStripMenuItem";
            this.rechargerLeMenuToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.rechargerLeMenuToolStripMenuItem.Text = "Recharger le menu";
            this.rechargerLeMenuToolStripMenuItem.Click += new System.EventHandler(this.rechargerLeMenuToolStripMenuItem_Click);
            // 
            // creerAuteurToolStripMenuItem
            // 
            this.creerAuteurToolStripMenuItem.Name = "creerAuteurToolStripMenuItem";
            this.creerAuteurToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.creerAuteurToolStripMenuItem.Text = "Creer auteur";
            this.creerAuteurToolStripMenuItem.Click += new System.EventHandler(this.creerAuteurToolStripMenuItem_Click);
            // 
            // creerEmployéToolStripMenuItem
            // 
            this.creerEmployéToolStripMenuItem.Name = "creerEmployéToolStripMenuItem";
            this.creerEmployéToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.creerEmployéToolStripMenuItem.Text = "Creer employé";
            this.creerEmployéToolStripMenuItem.Click += new System.EventHandler(this.creerEmployéToolStripMenuItem_Click);
            // 
            // creerClientToolStripMenuItem
            // 
            this.creerClientToolStripMenuItem.Name = "creerClientToolStripMenuItem";
            this.creerClientToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.creerClientToolStripMenuItem.Text = "Creer client";
            this.creerClientToolStripMenuItem.Click += new System.EventHandler(this.creerClientToolStripMenuItem_Click);
            // 
            // creerLivreToolStripMenuItem
            // 
            this.creerLivreToolStripMenuItem.Name = "creerLivreToolStripMenuItem";
            this.creerLivreToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.creerLivreToolStripMenuItem.Text = "Creer livre";
            this.creerLivreToolStripMenuItem.Click += new System.EventHandler(this.creerLivreToolStripMenuItem_Click);
            // 
            // voirEmployésToolStripMenuItem
            // 
            this.voirEmployésToolStripMenuItem.Name = "voirEmployésToolStripMenuItem";
            this.voirEmployésToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.voirEmployésToolStripMenuItem.Text = "Voir employés";
            this.voirEmployésToolStripMenuItem.Click += new System.EventHandler(this.voirEmployésToolStripMenuItem_Click);
            // 
            // voirPretsToolStripMenuItem
            // 
            this.voirPretsToolStripMenuItem.Name = "voirPretsToolStripMenuItem";
            this.voirPretsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.voirPretsToolStripMenuItem.Text = "Voir prets";
            this.voirPretsToolStripMenuItem.Click += new System.EventHandler(this.voirPretsToolStripMenuItem_Click);
            // 
            // voirBibliothequeToolStripMenuItem
            // 
            this.voirBibliothequeToolStripMenuItem.Name = "voirBibliothequeToolStripMenuItem";
            this.voirBibliothequeToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.voirBibliothequeToolStripMenuItem.Text = "Voir bibliotheque";
            // 
            // FormEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEmploye";
            this.Text = "Fomulaire employé";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmploye_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creerEmployéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerLivreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerAuteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirEmployésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirPretsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirBibliothequeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechargerLeMenuToolStripMenuItem;
    }
}