namespace projetFinal.formulaires
{
    partial class Form1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.creerEmployéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerLivreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizerEmployésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizerPretsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizerBibliothequeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerEmployéToolStripMenuItem,
            this.creerLivreToolStripMenuItem,
            this.visualizerEmployésToolStripMenuItem,
            this.visualizerPretsToolStripMenuItem,
            this.visualizerBibliothequeToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(759, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // creerEmployéToolStripMenuItem
            // 
            this.creerEmployéToolStripMenuItem.Name = "creerEmployéToolStripMenuItem";
            this.creerEmployéToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.creerEmployéToolStripMenuItem.Text = "Creer employé";
            // 
            // creerLivreToolStripMenuItem
            // 
            this.creerLivreToolStripMenuItem.Name = "creerLivreToolStripMenuItem";
            this.creerLivreToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.creerLivreToolStripMenuItem.Text = "Creer Livre";
            // 
            // visualizerEmployésToolStripMenuItem
            // 
            this.visualizerEmployésToolStripMenuItem.Name = "visualizerEmployésToolStripMenuItem";
            this.visualizerEmployésToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.visualizerEmployésToolStripMenuItem.Text = "Visualizer employés";
            // 
            // visualizerPretsToolStripMenuItem
            // 
            this.visualizerPretsToolStripMenuItem.Name = "visualizerPretsToolStripMenuItem";
            this.visualizerPretsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.visualizerPretsToolStripMenuItem.Text = "Visualizer prets";
            // 
            // visualizerBibliothequeToolStripMenuItem
            // 
            this.visualizerBibliothequeToolStripMenuItem.Name = "visualizerBibliothequeToolStripMenuItem";
            this.visualizerBibliothequeToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.visualizerBibliothequeToolStripMenuItem.Text = "Visualizer bibliotheque";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 445);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem creerEmployéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerLivreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizerEmployésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizerPretsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizerBibliothequeToolStripMenuItem;
    }
}