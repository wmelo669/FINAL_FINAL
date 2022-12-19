namespace projetFinal.formulaires
{
    partial class FormClient
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
            this.ms_client = new System.Windows.Forms.MenuStrip();
            this.rechargerLeMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_creerCompte_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faireUnPretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regarderPretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_client.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_client
            // 
            this.ms_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_client.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_client.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechargerLeMenuToolStripMenuItem,
            this.ms_creerCompte_btn,
            this.modifierCompteToolStripMenuItem,
            this.faireUnPretToolStripMenuItem,
            this.regarderPretToolStripMenuItem});
            this.ms_client.Location = new System.Drawing.Point(0, 0);
            this.ms_client.Name = "ms_client";
            this.ms_client.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.ms_client.Size = new System.Drawing.Size(800, 24);
            this.ms_client.TabIndex = 1;
            this.ms_client.Text = "menuStrip1";
            // 
            // rechargerLeMenuToolStripMenuItem
            // 
            this.rechargerLeMenuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rechargerLeMenuToolStripMenuItem.Name = "rechargerLeMenuToolStripMenuItem";
            this.rechargerLeMenuToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.rechargerLeMenuToolStripMenuItem.Text = "Recharger le menu";
            this.rechargerLeMenuToolStripMenuItem.Click += new System.EventHandler(this.rechargerLeMenuToolStripMenuItem_Click);
            // 
            // ms_creerCompte_btn
            // 
            this.ms_creerCompte_btn.Name = "ms_creerCompte_btn";
            this.ms_creerCompte_btn.Size = new System.Drawing.Size(91, 20);
            this.ms_creerCompte_btn.Text = "Créer compte";
            this.ms_creerCompte_btn.Click += new System.EventHandler(this.espaceClient_creerCompte_click);
            // 
            // modifierCompteToolStripMenuItem
            // 
            this.modifierCompteToolStripMenuItem.Name = "modifierCompteToolStripMenuItem";
            this.modifierCompteToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.modifierCompteToolStripMenuItem.Text = "Modifier compte";
            this.modifierCompteToolStripMenuItem.Click += new System.EventHandler(this.modifierCompteToolStripMenuItem_Click);
            // 
            // faireUnPretToolStripMenuItem
            // 
            this.faireUnPretToolStripMenuItem.Name = "faireUnPretToolStripMenuItem";
            this.faireUnPretToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.faireUnPretToolStripMenuItem.Text = "Faire un pret";
            this.faireUnPretToolStripMenuItem.Click += new System.EventHandler(this.faireUnPretToolStripMenuItem_Click);
            // 
            // regarderPretToolStripMenuItem
            // 
            this.regarderPretToolStripMenuItem.Name = "regarderPretToolStripMenuItem";
            this.regarderPretToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.regarderPretToolStripMenuItem.Text = "Regarder pret";
            this.regarderPretToolStripMenuItem.Click += new System.EventHandler(this.regarderPretToolStripMenuItem_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ms_client);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_client;
            this.Name = "FormClient";
            this.Text = "Espace client :)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClient_FormClosing);
            this.ms_client.ResumeLayout(false);
            this.ms_client.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_client;
        private System.Windows.Forms.ToolStripMenuItem ms_creerCompte_btn;
        private System.Windows.Forms.ToolStripMenuItem faireUnPretToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regarderPretToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechargerLeMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierCompteToolStripMenuItem;
    }
}