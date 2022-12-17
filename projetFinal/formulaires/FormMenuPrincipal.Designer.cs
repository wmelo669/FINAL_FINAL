namespace projetFinal
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titre_menu = new System.Windows.Forms.Label();
            this.btn_client_menu = new System.Windows.Forms.Button();
            this.btn_employe_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titre_menu
            // 
            this.lbl_titre_menu.AutoSize = true;
            this.lbl_titre_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre_menu.Location = new System.Drawing.Point(114, 38);
            this.lbl_titre_menu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titre_menu.Name = "lbl_titre_menu";
            this.lbl_titre_menu.Size = new System.Drawing.Size(285, 26);
            this.lbl_titre_menu.TabIndex = 0;
            this.lbl_titre_menu.Text = "Gestion de bibliotheque :)";
            // 
            // btn_client_menu
            // 
            this.btn_client_menu.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_client_menu.Location = new System.Drawing.Point(104, 128);
            this.btn_client_menu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_client_menu.Name = "btn_client_menu";
            this.btn_client_menu.Size = new System.Drawing.Size(115, 44);
            this.btn_client_menu.TabIndex = 1;
            this.btn_client_menu.Text = "Client";
            this.btn_client_menu.UseVisualStyleBackColor = true;
            this.btn_client_menu.Click += new System.EventHandler(this.btn_client_menu_click);
            // 
            // btn_employe_menu
            // 
            this.btn_employe_menu.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employe_menu.Location = new System.Drawing.Point(266, 128);
            this.btn_employe_menu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_employe_menu.Name = "btn_employe_menu";
            this.btn_employe_menu.Size = new System.Drawing.Size(115, 44);
            this.btn_employe_menu.TabIndex = 2;
            this.btn_employe_menu.Text = "Employé";
            this.btn_employe_menu.UseVisualStyleBackColor = true;
            this.btn_employe_menu.Click += new System.EventHandler(this.btn_employe_menu_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 219);
            this.Controls.Add(this.btn_employe_menu);
            this.Controls.Add(this.btn_client_menu);
            this.Controls.Add(this.lbl_titre_menu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMenuPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre_menu;
        private System.Windows.Forms.Button btn_client_menu;
        private System.Windows.Forms.Button btn_employe_menu;
    }
}

