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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_client_menu = new System.Windows.Forms.Button();
            this.btn_employe_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de bibliotheque :)";
            // 
            // btn_client_menu
            // 
            this.btn_client_menu.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_client_menu.Location = new System.Drawing.Point(138, 157);
            this.btn_client_menu.Name = "btn_client_menu";
            this.btn_client_menu.Size = new System.Drawing.Size(153, 54);
            this.btn_client_menu.TabIndex = 1;
            this.btn_client_menu.Text = "Client";
            this.btn_client_menu.UseVisualStyleBackColor = true;
            // 
            // btn_employe_menu
            // 
            this.btn_employe_menu.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employe_menu.Location = new System.Drawing.Point(355, 157);
            this.btn_employe_menu.Name = "btn_employe_menu";
            this.btn_employe_menu.Size = new System.Drawing.Size(153, 54);
            this.btn_employe_menu.TabIndex = 2;
            this.btn_employe_menu.Text = "Employé";
            this.btn_employe_menu.UseVisualStyleBackColor = true;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 269);
            this.Controls.Add(this.btn_employe_menu);
            this.Controls.Add(this.btn_client_menu);
            this.Controls.Add(this.label1);
            this.Name = "FormMenuPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_client_menu;
        private System.Windows.Forms.Button btn_employe_menu;
    }
}

