namespace projetFinal.formulaires
{
    partial class FormCreerAuteur
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
            this.lbl_ddn_creerAuteur = new System.Windows.Forms.Label();
            this.btn_ajouter_creerAuteur = new System.Windows.Forms.Button();
            this.btn_valider_creerAuteur = new System.Windows.Forms.Button();
            this.txtb_prenom_creerAuteur = new System.Windows.Forms.TextBox();
            this.lbl_prenom_creerAuteur = new System.Windows.Forms.Label();
            this.txtb_nom_creerAuteur = new System.Windows.Forms.TextBox();
            this.lbl_nom_creerAuteur = new System.Windows.Forms.Label();
            this.lbl_titre_creerAuteur = new System.Windows.Forms.Label();
            this.txtb_paysNaissance_creerAuteur = new System.Windows.Forms.TextBox();
            this.lbl_paysNaissance_creerAuteur = new System.Windows.Forms.Label();
            this.dtp_dateNaissance_creerAuteur = new System.Windows.Forms.DateTimePicker();
            this.txtb_idAuteur_creerAuteur = new System.Windows.Forms.TextBox();
            this.lbl_idAuteur_creerAuteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ddn_creerAuteur
            // 
            this.lbl_ddn_creerAuteur.AutoSize = true;
            this.lbl_ddn_creerAuteur.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ddn_creerAuteur.Location = new System.Drawing.Point(73, 152);
            this.lbl_ddn_creerAuteur.Name = "lbl_ddn_creerAuteur";
            this.lbl_ddn_creerAuteur.Size = new System.Drawing.Size(147, 21);
            this.lbl_ddn_creerAuteur.TabIndex = 34;
            this.lbl_ddn_creerAuteur.Text = "Date de naissance:";
            // 
            // btn_ajouter_creerAuteur
            // 
            this.btn_ajouter_creerAuteur.Enabled = false;
            this.btn_ajouter_creerAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter_creerAuteur.Location = new System.Drawing.Point(444, 269);
            this.btn_ajouter_creerAuteur.Name = "btn_ajouter_creerAuteur";
            this.btn_ajouter_creerAuteur.Size = new System.Drawing.Size(148, 35);
            this.btn_ajouter_creerAuteur.TabIndex = 33;
            this.btn_ajouter_creerAuteur.Text = "Ajouter";
            this.btn_ajouter_creerAuteur.UseVisualStyleBackColor = true;
            this.btn_ajouter_creerAuteur.Click += new System.EventHandler(this.btn_ajouter_creerAuteur_Click);
            // 
            // btn_valider_creerAuteur
            // 
            this.btn_valider_creerAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider_creerAuteur.Location = new System.Drawing.Point(263, 269);
            this.btn_valider_creerAuteur.Name = "btn_valider_creerAuteur";
            this.btn_valider_creerAuteur.Size = new System.Drawing.Size(148, 35);
            this.btn_valider_creerAuteur.TabIndex = 32;
            this.btn_valider_creerAuteur.Text = "Valider";
            this.btn_valider_creerAuteur.UseVisualStyleBackColor = true;
            this.btn_valider_creerAuteur.Click += new System.EventHandler(this.btn_valider_creerAuteur_Click);
            // 
            // txtb_prenom_creerAuteur
            // 
            this.txtb_prenom_creerAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_prenom_creerAuteur.Location = new System.Drawing.Point(632, 101);
            this.txtb_prenom_creerAuteur.Name = "txtb_prenom_creerAuteur";
            this.txtb_prenom_creerAuteur.Size = new System.Drawing.Size(180, 24);
            this.txtb_prenom_creerAuteur.TabIndex = 31;
            this.txtb_prenom_creerAuteur.TextChanged += new System.EventHandler(this.inputs_creerAuteur_TextChanged);
            // 
            // lbl_prenom_creerAuteur
            // 
            this.lbl_prenom_creerAuteur.AutoSize = true;
            this.lbl_prenom_creerAuteur.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prenom_creerAuteur.Location = new System.Drawing.Point(477, 104);
            this.lbl_prenom_creerAuteur.Name = "lbl_prenom_creerAuteur";
            this.lbl_prenom_creerAuteur.Size = new System.Drawing.Size(72, 21);
            this.lbl_prenom_creerAuteur.TabIndex = 30;
            this.lbl_prenom_creerAuteur.Text = "Prenom:";
            // 
            // txtb_nom_creerAuteur
            // 
            this.txtb_nom_creerAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_nom_creerAuteur.Location = new System.Drawing.Point(229, 104);
            this.txtb_nom_creerAuteur.Name = "txtb_nom_creerAuteur";
            this.txtb_nom_creerAuteur.Size = new System.Drawing.Size(180, 24);
            this.txtb_nom_creerAuteur.TabIndex = 29;
            this.txtb_nom_creerAuteur.TextChanged += new System.EventHandler(this.inputs_creerAuteur_TextChanged);
            // 
            // lbl_nom_creerAuteur
            // 
            this.lbl_nom_creerAuteur.AutoSize = true;
            this.lbl_nom_creerAuteur.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_creerAuteur.Location = new System.Drawing.Point(73, 102);
            this.lbl_nom_creerAuteur.Name = "lbl_nom_creerAuteur";
            this.lbl_nom_creerAuteur.Size = new System.Drawing.Size(51, 21);
            this.lbl_nom_creerAuteur.TabIndex = 28;
            this.lbl_nom_creerAuteur.Text = "Nom:";
            // 
            // lbl_titre_creerAuteur
            // 
            this.lbl_titre_creerAuteur.AutoSize = true;
            this.lbl_titre_creerAuteur.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre_creerAuteur.Location = new System.Drawing.Point(319, 39);
            this.lbl_titre_creerAuteur.Name = "lbl_titre_creerAuteur";
            this.lbl_titre_creerAuteur.Size = new System.Drawing.Size(210, 31);
            this.lbl_titre_creerAuteur.TabIndex = 27;
            this.lbl_titre_creerAuteur.Text = "Creez un auteur :)";
            // 
            // txtb_paysNaissance_creerAuteur
            // 
            this.txtb_paysNaissance_creerAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_paysNaissance_creerAuteur.Location = new System.Drawing.Point(632, 149);
            this.txtb_paysNaissance_creerAuteur.Name = "txtb_paysNaissance_creerAuteur";
            this.txtb_paysNaissance_creerAuteur.Size = new System.Drawing.Size(180, 24);
            this.txtb_paysNaissance_creerAuteur.TabIndex = 37;
            this.txtb_paysNaissance_creerAuteur.TextChanged += new System.EventHandler(this.inputs_creerAuteur_TextChanged);
            // 
            // lbl_paysNaissance_creerAuteur
            // 
            this.lbl_paysNaissance_creerAuteur.AutoSize = true;
            this.lbl_paysNaissance_creerAuteur.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paysNaissance_creerAuteur.Location = new System.Drawing.Point(477, 151);
            this.lbl_paysNaissance_creerAuteur.Name = "lbl_paysNaissance_creerAuteur";
            this.lbl_paysNaissance_creerAuteur.Size = new System.Drawing.Size(149, 21);
            this.lbl_paysNaissance_creerAuteur.TabIndex = 36;
            this.lbl_paysNaissance_creerAuteur.Text = "Pays de naissance:";
            // 
            // dtp_dateNaissance_creerAuteur
            // 
            this.dtp_dateNaissance_creerAuteur.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dateNaissance_creerAuteur.Location = new System.Drawing.Point(229, 153);
            this.dtp_dateNaissance_creerAuteur.Name = "dtp_dateNaissance_creerAuteur";
            this.dtp_dateNaissance_creerAuteur.Size = new System.Drawing.Size(183, 20);
            this.dtp_dateNaissance_creerAuteur.TabIndex = 38;
            this.dtp_dateNaissance_creerAuteur.ValueChanged += new System.EventHandler(this.inputs_creerAuteur_TextChanged);
            // 
            // txtb_idAuteur_creerAuteur
            // 
            this.txtb_idAuteur_creerAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_idAuteur_creerAuteur.Location = new System.Drawing.Point(229, 202);
            this.txtb_idAuteur_creerAuteur.Name = "txtb_idAuteur_creerAuteur";
            this.txtb_idAuteur_creerAuteur.Size = new System.Drawing.Size(180, 24);
            this.txtb_idAuteur_creerAuteur.TabIndex = 40;
            this.txtb_idAuteur_creerAuteur.TextChanged += new System.EventHandler(this.inputs_creerAuteur_TextChanged);
            // 
            // lbl_idAuteur_creerAuteur
            // 
            this.lbl_idAuteur_creerAuteur.AutoSize = true;
            this.lbl_idAuteur_creerAuteur.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idAuteur_creerAuteur.Location = new System.Drawing.Point(73, 200);
            this.lbl_idAuteur_creerAuteur.Name = "lbl_idAuteur_creerAuteur";
            this.lbl_idAuteur_creerAuteur.Size = new System.Drawing.Size(114, 21);
            this.lbl_idAuteur_creerAuteur.TabIndex = 39;
            this.lbl_idAuteur_creerAuteur.Text = "ID de l\'auteur:";
            // 
            // FormCreerAuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 382);
            this.Controls.Add(this.txtb_idAuteur_creerAuteur);
            this.Controls.Add(this.lbl_idAuteur_creerAuteur);
            this.Controls.Add(this.dtp_dateNaissance_creerAuteur);
            this.Controls.Add(this.txtb_paysNaissance_creerAuteur);
            this.Controls.Add(this.lbl_paysNaissance_creerAuteur);
            this.Controls.Add(this.lbl_ddn_creerAuteur);
            this.Controls.Add(this.btn_ajouter_creerAuteur);
            this.Controls.Add(this.btn_valider_creerAuteur);
            this.Controls.Add(this.txtb_prenom_creerAuteur);
            this.Controls.Add(this.lbl_prenom_creerAuteur);
            this.Controls.Add(this.txtb_nom_creerAuteur);
            this.Controls.Add(this.lbl_nom_creerAuteur);
            this.Controls.Add(this.lbl_titre_creerAuteur);
            this.Name = "FormCreerAuteur";
            this.Text = "Creer un auteur :)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCreerAuteur_FormClosing);
            this.Load += new System.EventHandler(this.FormCreerAuteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ddn_creerAuteur;
        private System.Windows.Forms.Button btn_ajouter_creerAuteur;
        private System.Windows.Forms.Button btn_valider_creerAuteur;
        private System.Windows.Forms.TextBox txtb_prenom_creerAuteur;
        private System.Windows.Forms.Label lbl_prenom_creerAuteur;
        private System.Windows.Forms.TextBox txtb_nom_creerAuteur;
        private System.Windows.Forms.Label lbl_nom_creerAuteur;
        private System.Windows.Forms.Label lbl_titre_creerAuteur;
        private System.Windows.Forms.TextBox txtb_paysNaissance_creerAuteur;
        private System.Windows.Forms.Label lbl_paysNaissance_creerAuteur;
        private System.Windows.Forms.DateTimePicker dtp_dateNaissance_creerAuteur;
        private System.Windows.Forms.TextBox txtb_idAuteur_creerAuteur;
        private System.Windows.Forms.Label lbl_idAuteur_creerAuteur;
    }
}