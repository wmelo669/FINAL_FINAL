namespace projetFinal.formulaires
{
    partial class FormCreerLivre
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
            this.lbl_isbn_creerLivre = new System.Windows.Forms.Label();
            this.txtb_isbn_creerLivre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nombreDePages_creerLivre = new System.Windows.Forms.Label();
            this.txtb_nombreDePages_creerLivre = new System.Windows.Forms.TextBox();
            this.txtb_nombreDeChapitres_creerLivre = new System.Windows.Forms.TextBox();
            this.lbl_nombreDeChapitres_creerLivre = new System.Windows.Forms.Label();
            this.txtb_maisonDEdition_creerLivre = new System.Windows.Forms.TextBox();
            this.lbl_maisonDEdition_creerLivre = new System.Windows.Forms.Label();
            this.btn_valider_creerLivre = new System.Windows.Forms.Button();
            this.btn_ajouter_creerLivre = new System.Windows.Forms.Button();
            this.txtb_idAuteur_creerLivre = new System.Windows.Forms.TextBox();
            this.lbl_idAuteur_creerLivre = new System.Windows.Forms.Label();
            this.txtb_quantite_creerLivre = new System.Windows.Forms.TextBox();
            this.lbl_quantite_creerLivre = new System.Windows.Forms.Label();
            this.txtb_titre_creerLivre = new System.Windows.Forms.TextBox();
            this.lbl_titre_creerLivre = new System.Windows.Forms.Label();
            this.dtp_dateDeParution_creerLivre = new System.Windows.Forms.DateTimePicker();
            this.lbl_dateDeParution_creerLivre = new System.Windows.Forms.Label();
            this.txtb_langueDOrigine_creerLivre = new System.Windows.Forms.TextBox();
            this.lbl_langueDOrigine_creerLivre = new System.Windows.Forms.Label();
            this.txtb_numéroDItem_creerLivre = new System.Windows.Forms.TextBox();
            this.lbl_numeroDItem_creerLivre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_isbn_creerLivre
            // 
            this.lbl_isbn_creerLivre.AutoSize = true;
            this.lbl_isbn_creerLivre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_isbn_creerLivre.Location = new System.Drawing.Point(465, 105);
            this.lbl_isbn_creerLivre.Name = "lbl_isbn_creerLivre";
            this.lbl_isbn_creerLivre.Size = new System.Drawing.Size(56, 21);
            this.lbl_isbn_creerLivre.TabIndex = 6;
            this.lbl_isbn_creerLivre.Text = "ISBN:";
            // 
            // txtb_isbn_creerLivre
            // 
            this.txtb_isbn_creerLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_isbn_creerLivre.Location = new System.Drawing.Point(652, 102);
            this.txtb_isbn_creerLivre.Name = "txtb_isbn_creerLivre";
            this.txtb_isbn_creerLivre.Size = new System.Drawing.Size(180, 24);
            this.txtb_isbn_creerLivre.TabIndex = 16;
            this.txtb_isbn_creerLivre.TextChanged += new System.EventHandler(this.inputComponents_creerLivre_textChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creez un livre :)";
            // 
            // lbl_nombreDePages_creerLivre
            // 
            this.lbl_nombreDePages_creerLivre.AutoSize = true;
            this.lbl_nombreDePages_creerLivre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreDePages_creerLivre.Location = new System.Drawing.Point(465, 150);
            this.lbl_nombreDePages_creerLivre.Name = "lbl_nombreDePages_creerLivre";
            this.lbl_nombreDePages_creerLivre.Size = new System.Drawing.Size(146, 21);
            this.lbl_nombreDePages_creerLivre.TabIndex = 7;
            this.lbl_nombreDePages_creerLivre.Text = "Nombre de pages:";
            // 
            // txtb_nombreDePages_creerLivre
            // 
            this.txtb_nombreDePages_creerLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_nombreDePages_creerLivre.Location = new System.Drawing.Point(652, 150);
            this.txtb_nombreDePages_creerLivre.Name = "txtb_nombreDePages_creerLivre";
            this.txtb_nombreDePages_creerLivre.Size = new System.Drawing.Size(180, 24);
            this.txtb_nombreDePages_creerLivre.TabIndex = 17;
            this.txtb_nombreDePages_creerLivre.TextChanged += new System.EventHandler(this.inputs_creerLivre_textChanged);
            // 
            // txtb_nombreDeChapitres_creerLivre
            // 
            this.txtb_nombreDeChapitres_creerLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_nombreDeChapitres_creerLivre.Location = new System.Drawing.Point(652, 199);
            this.txtb_nombreDeChapitres_creerLivre.Name = "txtb_nombreDeChapitres_creerLivre";
            this.txtb_nombreDeChapitres_creerLivre.Size = new System.Drawing.Size(180, 24);
            this.txtb_nombreDeChapitres_creerLivre.TabIndex = 18;
            this.txtb_nombreDeChapitres_creerLivre.TextChanged += new System.EventHandler(this.inputs_creerLivre_textChanged);
            // 
            // lbl_nombreDeChapitres_creerLivre
            // 
            this.lbl_nombreDeChapitres_creerLivre.AutoSize = true;
            this.lbl_nombreDeChapitres_creerLivre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreDeChapitres_creerLivre.Location = new System.Drawing.Point(465, 199);
            this.lbl_nombreDeChapitres_creerLivre.Name = "lbl_nombreDeChapitres_creerLivre";
            this.lbl_nombreDeChapitres_creerLivre.Size = new System.Drawing.Size(170, 21);
            this.lbl_nombreDeChapitres_creerLivre.TabIndex = 8;
            this.lbl_nombreDeChapitres_creerLivre.Text = "Nombre de chapitres:";
            // 
            // txtb_maisonDEdition_creerLivre
            // 
            this.txtb_maisonDEdition_creerLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_maisonDEdition_creerLivre.Location = new System.Drawing.Point(652, 251);
            this.txtb_maisonDEdition_creerLivre.Name = "txtb_maisonDEdition_creerLivre";
            this.txtb_maisonDEdition_creerLivre.Size = new System.Drawing.Size(180, 24);
            this.txtb_maisonDEdition_creerLivre.TabIndex = 19;
            this.txtb_maisonDEdition_creerLivre.TextChanged += new System.EventHandler(this.inputs_creerLivre_textChanged);
            // 
            // lbl_maisonDEdition_creerLivre
            // 
            this.lbl_maisonDEdition_creerLivre.AutoSize = true;
            this.lbl_maisonDEdition_creerLivre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maisonDEdition_creerLivre.Location = new System.Drawing.Point(465, 251);
            this.lbl_maisonDEdition_creerLivre.Name = "lbl_maisonDEdition_creerLivre";
            this.lbl_maisonDEdition_creerLivre.Size = new System.Drawing.Size(138, 21);
            this.lbl_maisonDEdition_creerLivre.TabIndex = 9;
            this.lbl_maisonDEdition_creerLivre.Text = "Maison d\'édition:";
            // 
            // btn_valider_creerLivre
            // 
            this.btn_valider_creerLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider_creerLivre.Location = new System.Drawing.Point(260, 368);
            this.btn_valider_creerLivre.Name = "btn_valider_creerLivre";
            this.btn_valider_creerLivre.Size = new System.Drawing.Size(148, 35);
            this.btn_valider_creerLivre.TabIndex = 21;
            this.btn_valider_creerLivre.Text = "Valider";
            this.btn_valider_creerLivre.UseVisualStyleBackColor = true;
            this.btn_valider_creerLivre.Click += new System.EventHandler(this.btn_valider_creerLivre_Click);
            // 
            // btn_ajouter_creerLivre
            // 
            this.btn_ajouter_creerLivre.Enabled = false;
            this.btn_ajouter_creerLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter_creerLivre.Location = new System.Drawing.Point(441, 368);
            this.btn_ajouter_creerLivre.Name = "btn_ajouter_creerLivre";
            this.btn_ajouter_creerLivre.Size = new System.Drawing.Size(148, 35);
            this.btn_ajouter_creerLivre.TabIndex = 22;
            this.btn_ajouter_creerLivre.Text = "Ajouter";
            this.btn_ajouter_creerLivre.UseVisualStyleBackColor = true;
            this.btn_ajouter_creerLivre.Click += new System.EventHandler(this.btn_ajouter_creerLivre_Click);
            // 
            // txtb_idAuteur_creerLivre
            // 
            this.txtb_idAuteur_creerLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_idAuteur_creerLivre.Location = new System.Drawing.Point(237, 199);
            this.txtb_idAuteur_creerLivre.Name = "txtb_idAuteur_creerLivre";
            this.txtb_idAuteur_creerLivre.Size = new System.Drawing.Size(180, 24);
            this.txtb_idAuteur_creerLivre.TabIndex = 13;
            this.txtb_idAuteur_creerLivre.TextChanged += new System.EventHandler(this.inputs_creerLivre_textChanged);
            // 
            // lbl_idAuteur_creerLivre
            // 
            this.lbl_idAuteur_creerLivre.AutoSize = true;
            this.lbl_idAuteur_creerLivre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idAuteur_creerLivre.Location = new System.Drawing.Point(50, 199);
            this.lbl_idAuteur_creerLivre.Name = "lbl_idAuteur_creerLivre";
            this.lbl_idAuteur_creerLivre.Size = new System.Drawing.Size(114, 21);
            this.lbl_idAuteur_creerLivre.TabIndex = 3;
            this.lbl_idAuteur_creerLivre.Text = "ID de l\'auteur:";
            // 
            // txtb_quantite_creerLivre
            // 
            this.txtb_quantite_creerLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_quantite_creerLivre.Location = new System.Drawing.Point(652, 299);
            this.txtb_quantite_creerLivre.Name = "txtb_quantite_creerLivre";
            this.txtb_quantite_creerLivre.Size = new System.Drawing.Size(180, 24);
            this.txtb_quantite_creerLivre.TabIndex = 20;
            this.txtb_quantite_creerLivre.TextChanged += new System.EventHandler(this.inputs_creerLivre_textChanged);
            // 
            // lbl_quantite_creerLivre
            // 
            this.lbl_quantite_creerLivre.AutoSize = true;
            this.lbl_quantite_creerLivre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantite_creerLivre.Location = new System.Drawing.Point(465, 299);
            this.lbl_quantite_creerLivre.Name = "lbl_quantite_creerLivre";
            this.lbl_quantite_creerLivre.Size = new System.Drawing.Size(76, 21);
            this.lbl_quantite_creerLivre.TabIndex = 10;
            this.lbl_quantite_creerLivre.Text = "Quantite:";
            // 
            // txtb_titre_creerLivre
            // 
            this.txtb_titre_creerLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_titre_creerLivre.Location = new System.Drawing.Point(237, 102);
            this.txtb_titre_creerLivre.Name = "txtb_titre_creerLivre";
            this.txtb_titre_creerLivre.Size = new System.Drawing.Size(180, 24);
            this.txtb_titre_creerLivre.TabIndex = 11;
            this.txtb_titre_creerLivre.TextChanged += new System.EventHandler(this.inputs_creerLivre_textChanged);
            // 
            // lbl_titre_creerLivre
            // 
            this.lbl_titre_creerLivre.AutoSize = true;
            this.lbl_titre_creerLivre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre_creerLivre.Location = new System.Drawing.Point(50, 102);
            this.lbl_titre_creerLivre.Name = "lbl_titre_creerLivre";
            this.lbl_titre_creerLivre.Size = new System.Drawing.Size(44, 21);
            this.lbl_titre_creerLivre.TabIndex = 1;
            this.lbl_titre_creerLivre.Text = "Titre";
            // 
            // dtp_dateDeParution_creerLivre
            // 
            this.dtp_dateDeParution_creerLivre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dateDeParution_creerLivre.Location = new System.Drawing.Point(234, 249);
            this.dtp_dateDeParution_creerLivre.Name = "dtp_dateDeParution_creerLivre";
            this.dtp_dateDeParution_creerLivre.Size = new System.Drawing.Size(183, 20);
            this.dtp_dateDeParution_creerLivre.TabIndex = 14;
            // 
            // lbl_dateDeParution_creerLivre
            // 
            this.lbl_dateDeParution_creerLivre.AutoSize = true;
            this.lbl_dateDeParution_creerLivre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateDeParution_creerLivre.Location = new System.Drawing.Point(49, 248);
            this.lbl_dateDeParution_creerLivre.Name = "lbl_dateDeParution_creerLivre";
            this.lbl_dateDeParution_creerLivre.Size = new System.Drawing.Size(142, 21);
            this.lbl_dateDeParution_creerLivre.TabIndex = 4;
            this.lbl_dateDeParution_creerLivre.Text = "Date de parution: ";
            // 
            // txtb_langueDOrigine_creerLivre
            // 
            this.txtb_langueDOrigine_creerLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_langueDOrigine_creerLivre.Location = new System.Drawing.Point(237, 288);
            this.txtb_langueDOrigine_creerLivre.Name = "txtb_langueDOrigine_creerLivre";
            this.txtb_langueDOrigine_creerLivre.Size = new System.Drawing.Size(180, 24);
            this.txtb_langueDOrigine_creerLivre.TabIndex = 15;
            this.txtb_langueDOrigine_creerLivre.TextChanged += new System.EventHandler(this.inputs_creerLivre_textChanged);
            // 
            // lbl_langueDOrigine_creerLivre
            // 
            this.lbl_langueDOrigine_creerLivre.AutoSize = true;
            this.lbl_langueDOrigine_creerLivre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_langueDOrigine_creerLivre.Location = new System.Drawing.Point(50, 288);
            this.lbl_langueDOrigine_creerLivre.Name = "lbl_langueDOrigine_creerLivre";
            this.lbl_langueDOrigine_creerLivre.Size = new System.Drawing.Size(137, 21);
            this.lbl_langueDOrigine_creerLivre.TabIndex = 5;
            this.lbl_langueDOrigine_creerLivre.Text = "Langue d\'origine:";
            // 
            // txtb_numéroDItem_creerLivre
            // 
            this.txtb_numéroDItem_creerLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_numéroDItem_creerLivre.Location = new System.Drawing.Point(234, 150);
            this.txtb_numéroDItem_creerLivre.Name = "txtb_numéroDItem_creerLivre";
            this.txtb_numéroDItem_creerLivre.Size = new System.Drawing.Size(180, 24);
            this.txtb_numéroDItem_creerLivre.TabIndex = 12;
            // 
            // lbl_numeroDItem_creerLivre
            // 
            this.lbl_numeroDItem_creerLivre.AutoSize = true;
            this.lbl_numeroDItem_creerLivre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numeroDItem_creerLivre.Location = new System.Drawing.Point(47, 150);
            this.lbl_numeroDItem_creerLivre.Name = "lbl_numeroDItem_creerLivre";
            this.lbl_numeroDItem_creerLivre.Size = new System.Drawing.Size(124, 21);
            this.lbl_numeroDItem_creerLivre.TabIndex = 2;
            this.lbl_numeroDItem_creerLivre.Text = "Numéro d\'item:";
            // 
            // FormCreerLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 472);
            this.Controls.Add(this.txtb_numéroDItem_creerLivre);
            this.Controls.Add(this.lbl_numeroDItem_creerLivre);
            this.Controls.Add(this.txtb_langueDOrigine_creerLivre);
            this.Controls.Add(this.lbl_langueDOrigine_creerLivre);
            this.Controls.Add(this.dtp_dateDeParution_creerLivre);
            this.Controls.Add(this.lbl_dateDeParution_creerLivre);
            this.Controls.Add(this.txtb_titre_creerLivre);
            this.Controls.Add(this.lbl_titre_creerLivre);
            this.Controls.Add(this.txtb_quantite_creerLivre);
            this.Controls.Add(this.lbl_quantite_creerLivre);
            this.Controls.Add(this.txtb_idAuteur_creerLivre);
            this.Controls.Add(this.lbl_idAuteur_creerLivre);
            this.Controls.Add(this.btn_ajouter_creerLivre);
            this.Controls.Add(this.btn_valider_creerLivre);
            this.Controls.Add(this.txtb_maisonDEdition_creerLivre);
            this.Controls.Add(this.lbl_maisonDEdition_creerLivre);
            this.Controls.Add(this.txtb_nombreDeChapitres_creerLivre);
            this.Controls.Add(this.lbl_nombreDeChapitres_creerLivre);
            this.Controls.Add(this.txtb_nombreDePages_creerLivre);
            this.Controls.Add(this.lbl_nombreDePages_creerLivre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_isbn_creerLivre);
            this.Controls.Add(this.lbl_isbn_creerLivre);
            this.Name = "FormCreerLivre";
            this.Text = "Creer Livre :)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCreerLivre_FormClosing);
            this.Load += new System.EventHandler(this.FormCreerLivre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_isbn_creerLivre;
        private System.Windows.Forms.TextBox txtb_isbn_creerLivre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nombreDePages_creerLivre;
        private System.Windows.Forms.TextBox txtb_nombreDePages_creerLivre;
        private System.Windows.Forms.TextBox txtb_nombreDeChapitres_creerLivre;
        private System.Windows.Forms.Label lbl_nombreDeChapitres_creerLivre;
        private System.Windows.Forms.TextBox txtb_maisonDEdition_creerLivre;
        private System.Windows.Forms.Label lbl_maisonDEdition_creerLivre;
        private System.Windows.Forms.Button btn_valider_creerLivre;
        private System.Windows.Forms.Button btn_ajouter_creerLivre;
        private System.Windows.Forms.TextBox txtb_idAuteur_creerLivre;
        private System.Windows.Forms.Label lbl_idAuteur_creerLivre;
        private System.Windows.Forms.TextBox txtb_quantite_creerLivre;
        private System.Windows.Forms.Label lbl_quantite_creerLivre;
        private System.Windows.Forms.TextBox txtb_titre_creerLivre;
        private System.Windows.Forms.Label lbl_titre_creerLivre;
        private System.Windows.Forms.DateTimePicker dtp_dateDeParution_creerLivre;
        private System.Windows.Forms.Label lbl_dateDeParution_creerLivre;
        private System.Windows.Forms.TextBox txtb_langueDOrigine_creerLivre;
        private System.Windows.Forms.Label lbl_langueDOrigine_creerLivre;
        private System.Windows.Forms.TextBox txtb_numéroDItem_creerLivre;
        private System.Windows.Forms.Label lbl_numeroDItem_creerLivre;
    }
}