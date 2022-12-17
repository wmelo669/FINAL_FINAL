namespace projetFinal.formulaires
{
    partial class FormModifierCompte
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
            this.lbl_titreModifierCompte = new System.Windows.Forms.Label();
            this.cb_valeurAModifier_modifierCompte = new System.Windows.Forms.ComboBox();
            this.lbl_numCompte_modifierCompte = new System.Windows.Forms.Label();
            this.txtb_numCompte_modifierCompte = new System.Windows.Forms.TextBox();
            this.btn_validerClient_modiferCompte = new System.Windows.Forms.Button();
            this.lbl_valeurAModifier_modifierCompte = new System.Windows.Forms.Label();
            this.txtb_nouvValeur_modifierCompte = new System.Windows.Forms.TextBox();
            this.lbl_messageEntre_modifierCompte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titreModifierCompte
            // 
            this.lbl_titreModifierCompte.AutoSize = true;
            this.lbl_titreModifierCompte.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreModifierCompte.Location = new System.Drawing.Point(132, 36);
            this.lbl_titreModifierCompte.Name = "lbl_titreModifierCompte";
            this.lbl_titreModifierCompte.Size = new System.Drawing.Size(497, 31);
            this.lbl_titreModifierCompte.TabIndex = 1;
            this.lbl_titreModifierCompte.Text = "Modifiez les informations de votre compte :)";
            // 
            // cb_valeurAModifier_modifierCompte
            // 
            this.cb_valeurAModifier_modifierCompte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_valeurAModifier_modifierCompte.Enabled = false;
            this.cb_valeurAModifier_modifierCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_valeurAModifier_modifierCompte.FormattingEnabled = true;
            this.cb_valeurAModifier_modifierCompte.Items.AddRange(new object[] {
            "nomCompte",
            "prenomCompte",
            "motDePasse"});
            this.cb_valeurAModifier_modifierCompte.Location = new System.Drawing.Point(438, 195);
            this.cb_valeurAModifier_modifierCompte.Name = "cb_valeurAModifier_modifierCompte";
            this.cb_valeurAModifier_modifierCompte.Size = new System.Drawing.Size(191, 26);
            this.cb_valeurAModifier_modifierCompte.TabIndex = 2;
            // 
            // lbl_numCompte_modifierCompte
            // 
            this.lbl_numCompte_modifierCompte.AutoSize = true;
            this.lbl_numCompte_modifierCompte.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numCompte_modifierCompte.Location = new System.Drawing.Point(140, 113);
            this.lbl_numCompte_modifierCompte.Name = "lbl_numCompte_modifierCompte";
            this.lbl_numCompte_modifierCompte.Size = new System.Drawing.Size(158, 21);
            this.lbl_numCompte_modifierCompte.TabIndex = 3;
            this.lbl_numCompte_modifierCompte.Text = "Numero de compte:";
            // 
            // txtb_numCompte_modifierCompte
            // 
            this.txtb_numCompte_modifierCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_numCompte_modifierCompte.Location = new System.Drawing.Point(317, 110);
            this.txtb_numCompte_modifierCompte.Name = "txtb_numCompte_modifierCompte";
            this.txtb_numCompte_modifierCompte.Size = new System.Drawing.Size(180, 24);
            this.txtb_numCompte_modifierCompte.TabIndex = 4;
            // 
            // btn_validerClient_modiferCompte
            // 
            this.btn_validerClient_modiferCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validerClient_modiferCompte.Location = new System.Drawing.Point(538, 106);
            this.btn_validerClient_modiferCompte.Name = "btn_validerClient_modiferCompte";
            this.btn_validerClient_modiferCompte.Size = new System.Drawing.Size(148, 35);
            this.btn_validerClient_modiferCompte.TabIndex = 10;
            this.btn_validerClient_modiferCompte.Text = "Valider";
            this.btn_validerClient_modiferCompte.UseVisualStyleBackColor = true;
            this.btn_validerClient_modiferCompte.Click += new System.EventHandler(this.btn_validerClient_modiferCompte_Click);
            // 
            // lbl_valeurAModifier_modifierCompte
            // 
            this.lbl_valeurAModifier_modifierCompte.AutoSize = true;
            this.lbl_valeurAModifier_modifierCompte.Enabled = false;
            this.lbl_valeurAModifier_modifierCompte.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valeurAModifier_modifierCompte.Location = new System.Drawing.Point(156, 197);
            this.lbl_valeurAModifier_modifierCompte.Name = "lbl_valeurAModifier_modifierCompte";
            this.lbl_valeurAModifier_modifierCompte.Size = new System.Drawing.Size(276, 21);
            this.lbl_valeurAModifier_modifierCompte.TabIndex = 11;
            this.lbl_valeurAModifier_modifierCompte.Text = "Quelle valeur voulez-vous modifier?";
            // 
            // txtb_nouvValeur_modifierCompte
            // 
            this.txtb_nouvValeur_modifierCompte.Enabled = false;
            this.txtb_nouvValeur_modifierCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_nouvValeur_modifierCompte.Location = new System.Drawing.Point(307, 257);
            this.txtb_nouvValeur_modifierCompte.Name = "txtb_nouvValeur_modifierCompte";
            this.txtb_nouvValeur_modifierCompte.Size = new System.Drawing.Size(180, 24);
            this.txtb_nouvValeur_modifierCompte.TabIndex = 12;
            this.txtb_nouvValeur_modifierCompte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtb_nouvValeur_modifierCompte_KeyDown);
            // 
            // lbl_messageEntre_modifierCompte
            // 
            this.lbl_messageEntre_modifierCompte.AutoSize = true;
            this.lbl_messageEntre_modifierCompte.Enabled = false;
            this.lbl_messageEntre_modifierCompte.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_messageEntre_modifierCompte.Location = new System.Drawing.Point(304, 284);
            this.lbl_messageEntre_modifierCompte.Name = "lbl_messageEntre_modifierCompte";
            this.lbl_messageEntre_modifierCompte.Size = new System.Drawing.Size(193, 14);
            this.lbl_messageEntre_modifierCompte.TabIndex = 13;
            this.lbl_messageEntre_modifierCompte.Text = "Pressez le button \"entré\" pour continuer";
            // 
            // FormModifierCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 360);
            this.Controls.Add(this.lbl_messageEntre_modifierCompte);
            this.Controls.Add(this.txtb_nouvValeur_modifierCompte);
            this.Controls.Add(this.lbl_valeurAModifier_modifierCompte);
            this.Controls.Add(this.btn_validerClient_modiferCompte);
            this.Controls.Add(this.txtb_numCompte_modifierCompte);
            this.Controls.Add(this.lbl_numCompte_modifierCompte);
            this.Controls.Add(this.cb_valeurAModifier_modifierCompte);
            this.Controls.Add(this.lbl_titreModifierCompte);
            this.Name = "FormModifierCompte";
            this.Text = "Modifier les informations d\'un compte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormModifierCompte_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titreModifierCompte;
        private System.Windows.Forms.ComboBox cb_valeurAModifier_modifierCompte;
        private System.Windows.Forms.Label lbl_numCompte_modifierCompte;
        private System.Windows.Forms.TextBox txtb_numCompte_modifierCompte;
        private System.Windows.Forms.Button btn_validerClient_modiferCompte;
        private System.Windows.Forms.Label lbl_valeurAModifier_modifierCompte;
        private System.Windows.Forms.TextBox txtb_nouvValeur_modifierCompte;
        private System.Windows.Forms.Label lbl_messageEntre_modifierCompte;
    }
}