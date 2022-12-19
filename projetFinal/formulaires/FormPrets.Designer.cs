namespace projetFinal.formulaires
{
    partial class FormPrets
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
            this.dataGridViewEmprunt_emprunterLivre = new System.Windows.Forms.DataGridView();
            this.dtgrid_numCompte_visualisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrid_prenomCompte_visualisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrid_nomCompte_visualisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrid_typeCompte_visualisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrid_mdpCompte_visualisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgv_nomAuteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_titre_Emprunter = new System.Windows.Forms.Label();
            this.txtb_entrerIsbn_emprunterLivre = new System.Windows.Forms.TextBox();
            this.lbl_entrerIsbn_emprunterLivre = new System.Windows.Forms.Label();
            this.btn_ajouter_emprunterLivre = new System.Windows.Forms.Button();
            this.btn_finalizer_emprunterLivre = new System.Windows.Forms.Button();
            this.lbl_quantite_emprunterLivre = new System.Windows.Forms.Label();
            this.checkListBox_Prets = new System.Windows.Forms.CheckedListBox();
            this.numUpDown_quantite_emprunterLivre = new System.Windows.Forms.NumericUpDown();
            this.lbl_titreListeLivres_emprunterLivre = new System.Windows.Forms.Label();
            this.lbl_ordreDetail_emprunterLivre = new System.Windows.Forms.Label();
            this.txtb_numCompte_emprunterLivre = new System.Windows.Forms.TextBox();
            this.lbl_numCompte_emprunterLivre = new System.Windows.Forms.Label();
            this.btn_validerNumCompte_emprunterLivre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprunt_emprunterLivre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_quantite_emprunterLivre)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmprunt_emprunterLivre
            // 
            this.dataGridViewEmprunt_emprunterLivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmprunt_emprunterLivre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgrid_numCompte_visualisation,
            this.dtgrid_prenomCompte_visualisation,
            this.dtgrid_nomCompte_visualisation,
            this.dtgrid_typeCompte_visualisation,
            this.dtgrid_mdpCompte_visualisation,
            this.dtgv_nomAuteur});
            this.dataGridViewEmprunt_emprunterLivre.Location = new System.Drawing.Point(37, 84);
            this.dataGridViewEmprunt_emprunterLivre.Name = "dataGridViewEmprunt_emprunterLivre";
            this.dataGridViewEmprunt_emprunterLivre.ReadOnly = true;
            this.dataGridViewEmprunt_emprunterLivre.RowHeadersWidth = 51;
            this.dataGridViewEmprunt_emprunterLivre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmprunt_emprunterLivre.Size = new System.Drawing.Size(1133, 150);
            this.dataGridViewEmprunt_emprunterLivre.TabIndex = 1;
            // 
            // dtgrid_numCompte_visualisation
            // 
            this.dtgrid_numCompte_visualisation.HeaderText = "ISBN";
            this.dtgrid_numCompte_visualisation.MinimumWidth = 6;
            this.dtgrid_numCompte_visualisation.Name = "dtgrid_numCompte_visualisation";
            this.dtgrid_numCompte_visualisation.ReadOnly = true;
            this.dtgrid_numCompte_visualisation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_numCompte_visualisation.Width = 180;
            // 
            // dtgrid_prenomCompte_visualisation
            // 
            this.dtgrid_prenomCompte_visualisation.HeaderText = "Titre";
            this.dtgrid_prenomCompte_visualisation.MinimumWidth = 6;
            this.dtgrid_prenomCompte_visualisation.Name = "dtgrid_prenomCompte_visualisation";
            this.dtgrid_prenomCompte_visualisation.ReadOnly = true;
            this.dtgrid_prenomCompte_visualisation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_prenomCompte_visualisation.Width = 180;
            // 
            // dtgrid_nomCompte_visualisation
            // 
            this.dtgrid_nomCompte_visualisation.HeaderText = "Nombre de pages";
            this.dtgrid_nomCompte_visualisation.MinimumWidth = 6;
            this.dtgrid_nomCompte_visualisation.Name = "dtgrid_nomCompte_visualisation";
            this.dtgrid_nomCompte_visualisation.ReadOnly = true;
            this.dtgrid_nomCompte_visualisation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_nomCompte_visualisation.Width = 180;
            // 
            // dtgrid_typeCompte_visualisation
            // 
            this.dtgrid_typeCompte_visualisation.HeaderText = "Langue";
            this.dtgrid_typeCompte_visualisation.MinimumWidth = 6;
            this.dtgrid_typeCompte_visualisation.Name = "dtgrid_typeCompte_visualisation";
            this.dtgrid_typeCompte_visualisation.ReadOnly = true;
            this.dtgrid_typeCompte_visualisation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_typeCompte_visualisation.Width = 180;
            // 
            // dtgrid_mdpCompte_visualisation
            // 
            this.dtgrid_mdpCompte_visualisation.HeaderText = "Quantite";
            this.dtgrid_mdpCompte_visualisation.MinimumWidth = 6;
            this.dtgrid_mdpCompte_visualisation.Name = "dtgrid_mdpCompte_visualisation";
            this.dtgrid_mdpCompte_visualisation.ReadOnly = true;
            this.dtgrid_mdpCompte_visualisation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_mdpCompte_visualisation.Width = 180;
            // 
            // dtgv_nomAuteur
            // 
            this.dtgv_nomAuteur.HeaderText = "Nom de l\'auteur";
            this.dtgv_nomAuteur.MinimumWidth = 6;
            this.dtgv_nomAuteur.Name = "dtgv_nomAuteur";
            this.dtgv_nomAuteur.ReadOnly = true;
            this.dtgv_nomAuteur.Width = 180;
            // 
            // lbl_titre_Emprunter
            // 
            this.lbl_titre_Emprunter.AutoSize = true;
            this.lbl_titre_Emprunter.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre_Emprunter.Location = new System.Drawing.Point(503, 22);
            this.lbl_titre_Emprunter.Name = "lbl_titre_Emprunter";
            this.lbl_titre_Emprunter.Size = new System.Drawing.Size(242, 31);
            this.lbl_titre_Emprunter.TabIndex = 2;
            this.lbl_titre_Emprunter.Text = "Empruntez des livres";
            // 
            // txtb_entrerIsbn_emprunterLivre
            // 
            this.txtb_entrerIsbn_emprunterLivre.Enabled = false;
            this.txtb_entrerIsbn_emprunterLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_entrerIsbn_emprunterLivre.Location = new System.Drawing.Point(494, 305);
            this.txtb_entrerIsbn_emprunterLivre.Name = "txtb_entrerIsbn_emprunterLivre";
            this.txtb_entrerIsbn_emprunterLivre.Size = new System.Drawing.Size(180, 24);
            this.txtb_entrerIsbn_emprunterLivre.TabIndex = 47;
            // 
            // lbl_entrerIsbn_emprunterLivre
            // 
            this.lbl_entrerIsbn_emprunterLivre.AutoSize = true;
            this.lbl_entrerIsbn_emprunterLivre.Enabled = false;
            this.lbl_entrerIsbn_emprunterLivre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entrerIsbn_emprunterLivre.Location = new System.Drawing.Point(323, 305);
            this.lbl_entrerIsbn_emprunterLivre.Name = "lbl_entrerIsbn_emprunterLivre";
            this.lbl_entrerIsbn_emprunterLivre.Size = new System.Drawing.Size(165, 21);
            this.lbl_entrerIsbn_emprunterLivre.TabIndex = 46;
            this.lbl_entrerIsbn_emprunterLivre.Text = "Entrez l\'isbn du livre:";
            // 
            // btn_ajouter_emprunterLivre
            // 
            this.btn_ajouter_emprunterLivre.Enabled = false;
            this.btn_ajouter_emprunterLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter_emprunterLivre.Location = new System.Drawing.Point(327, 391);
            this.btn_ajouter_emprunterLivre.Name = "btn_ajouter_emprunterLivre";
            this.btn_ajouter_emprunterLivre.Size = new System.Drawing.Size(107, 35);
            this.btn_ajouter_emprunterLivre.TabIndex = 45;
            this.btn_ajouter_emprunterLivre.Text = "Ajouter";
            this.btn_ajouter_emprunterLivre.UseVisualStyleBackColor = true;
            this.btn_ajouter_emprunterLivre.Click += new System.EventHandler(this.btn_ajouter_emprunterLivre_Click);
            // 
            // btn_finalizer_emprunterLivre
            // 
            this.btn_finalizer_emprunterLivre.Enabled = false;
            this.btn_finalizer_emprunterLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizer_emprunterLivre.Location = new System.Drawing.Point(567, 391);
            this.btn_finalizer_emprunterLivre.Name = "btn_finalizer_emprunterLivre";
            this.btn_finalizer_emprunterLivre.Size = new System.Drawing.Size(107, 35);
            this.btn_finalizer_emprunterLivre.TabIndex = 48;
            this.btn_finalizer_emprunterLivre.Text = "Finalizer";
            this.btn_finalizer_emprunterLivre.UseVisualStyleBackColor = true;
            this.btn_finalizer_emprunterLivre.Click += new System.EventHandler(this.btn_finalizer_emprunterLivre_Click);
            // 
            // lbl_quantite_emprunterLivre
            // 
            this.lbl_quantite_emprunterLivre.AutoSize = true;
            this.lbl_quantite_emprunterLivre.Enabled = false;
            this.lbl_quantite_emprunterLivre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantite_emprunterLivre.Location = new System.Drawing.Point(323, 348);
            this.lbl_quantite_emprunterLivre.Name = "lbl_quantite_emprunterLivre";
            this.lbl_quantite_emprunterLivre.Size = new System.Drawing.Size(76, 21);
            this.lbl_quantite_emprunterLivre.TabIndex = 49;
            this.lbl_quantite_emprunterLivre.Text = "Quantité:";
            // 
            // checkListBox_Prets
            // 
            this.checkListBox_Prets.Enabled = false;
            this.checkListBox_Prets.FormattingEnabled = true;
            this.checkListBox_Prets.Location = new System.Drawing.Point(717, 305);
            this.checkListBox_Prets.Name = "checkListBox_Prets";
            this.checkListBox_Prets.Size = new System.Drawing.Size(453, 124);
            this.checkListBox_Prets.TabIndex = 51;
            // 
            // numUpDown_quantite_emprunterLivre
            // 
            this.numUpDown_quantite_emprunterLivre.Enabled = false;
            this.numUpDown_quantite_emprunterLivre.Location = new System.Drawing.Point(494, 351);
            this.numUpDown_quantite_emprunterLivre.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numUpDown_quantite_emprunterLivre.Name = "numUpDown_quantite_emprunterLivre";
            this.numUpDown_quantite_emprunterLivre.Size = new System.Drawing.Size(180, 20);
            this.numUpDown_quantite_emprunterLivre.TabIndex = 52;
            // 
            // lbl_titreListeLivres_emprunterLivre
            // 
            this.lbl_titreListeLivres_emprunterLivre.AutoSize = true;
            this.lbl_titreListeLivres_emprunterLivre.Enabled = false;
            this.lbl_titreListeLivres_emprunterLivre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreListeLivres_emprunterLivre.Location = new System.Drawing.Point(846, 269);
            this.lbl_titreListeLivres_emprunterLivre.Name = "lbl_titreListeLivres_emprunterLivre";
            this.lbl_titreListeLivres_emprunterLivre.Size = new System.Drawing.Size(206, 21);
            this.lbl_titreListeLivres_emprunterLivre.TabIndex = 53;
            this.lbl_titreListeLivres_emprunterLivre.Text = "Liste de livres a emprunter";
            // 
            // lbl_ordreDetail_emprunterLivre
            // 
            this.lbl_ordreDetail_emprunterLivre.AutoSize = true;
            this.lbl_ordreDetail_emprunterLivre.Enabled = false;
            this.lbl_ordreDetail_emprunterLivre.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ordreDetail_emprunterLivre.Location = new System.Drawing.Point(886, 290);
            this.lbl_ordreDetail_emprunterLivre.Name = "lbl_ordreDetail_emprunterLivre";
            this.lbl_ordreDetail_emprunterLivre.Size = new System.Drawing.Size(115, 14);
            this.lbl_ordreDetail_emprunterLivre.TabIndex = 54;
            this.lbl_ordreDetail_emprunterLivre.Text = "(ISBN, Titre, Quantité)";
            // 
            // txtb_numCompte_emprunterLivre
            // 
            this.txtb_numCompte_emprunterLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_numCompte_emprunterLivre.Location = new System.Drawing.Point(37, 331);
            this.txtb_numCompte_emprunterLivre.Name = "txtb_numCompte_emprunterLivre";
            this.txtb_numCompte_emprunterLivre.Size = new System.Drawing.Size(187, 24);
            this.txtb_numCompte_emprunterLivre.TabIndex = 56;
            // 
            // lbl_numCompte_emprunterLivre
            // 
            this.lbl_numCompte_emprunterLivre.AutoSize = true;
            this.lbl_numCompte_emprunterLivre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numCompte_emprunterLivre.Location = new System.Drawing.Point(52, 307);
            this.lbl_numCompte_emprunterLivre.Name = "lbl_numCompte_emprunterLivre";
            this.lbl_numCompte_emprunterLivre.Size = new System.Drawing.Size(154, 21);
            this.lbl_numCompte_emprunterLivre.TabIndex = 55;
            this.lbl_numCompte_emprunterLivre.Text = "Numéro de compte";
            // 
            // btn_validerNumCompte_emprunterLivre
            // 
            this.btn_validerNumCompte_emprunterLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validerNumCompte_emprunterLivre.Location = new System.Drawing.Point(80, 361);
            this.btn_validerNumCompte_emprunterLivre.Name = "btn_validerNumCompte_emprunterLivre";
            this.btn_validerNumCompte_emprunterLivre.Size = new System.Drawing.Size(107, 35);
            this.btn_validerNumCompte_emprunterLivre.TabIndex = 57;
            this.btn_validerNumCompte_emprunterLivre.Text = "Valider";
            this.btn_validerNumCompte_emprunterLivre.UseVisualStyleBackColor = true;
            this.btn_validerNumCompte_emprunterLivre.Click += new System.EventHandler(this.btn_validerNumCompte_emprunterLivre_Click);
            // 
            // FormPrets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 471);
            this.Controls.Add(this.btn_validerNumCompte_emprunterLivre);
            this.Controls.Add(this.txtb_numCompte_emprunterLivre);
            this.Controls.Add(this.lbl_numCompte_emprunterLivre);
            this.Controls.Add(this.lbl_ordreDetail_emprunterLivre);
            this.Controls.Add(this.lbl_titreListeLivres_emprunterLivre);
            this.Controls.Add(this.numUpDown_quantite_emprunterLivre);
            this.Controls.Add(this.checkListBox_Prets);
            this.Controls.Add(this.lbl_quantite_emprunterLivre);
            this.Controls.Add(this.btn_finalizer_emprunterLivre);
            this.Controls.Add(this.txtb_entrerIsbn_emprunterLivre);
            this.Controls.Add(this.lbl_entrerIsbn_emprunterLivre);
            this.Controls.Add(this.btn_ajouter_emprunterLivre);
            this.Controls.Add(this.lbl_titre_Emprunter);
            this.Controls.Add(this.dataGridViewEmprunt_emprunterLivre);
            this.Name = "FormPrets";
            this.Text = "Faire un pret";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrets_FormClosing);
            this.Load += new System.EventHandler(this.FormPrets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprunt_emprunterLivre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_quantite_emprunterLivre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmprunt_emprunterLivre;
        private System.Windows.Forms.Label lbl_titre_Emprunter;
        private System.Windows.Forms.TextBox txtb_entrerIsbn_emprunterLivre;
        private System.Windows.Forms.Label lbl_entrerIsbn_emprunterLivre;
        private System.Windows.Forms.Button btn_ajouter_emprunterLivre;
        private System.Windows.Forms.Button btn_finalizer_emprunterLivre;
        private System.Windows.Forms.Label lbl_quantite_emprunterLivre;
        private System.Windows.Forms.CheckedListBox checkListBox_Prets;
        private System.Windows.Forms.NumericUpDown numUpDown_quantite_emprunterLivre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrid_numCompte_visualisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrid_prenomCompte_visualisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrid_nomCompte_visualisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrid_typeCompte_visualisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrid_mdpCompte_visualisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgv_nomAuteur;
        private System.Windows.Forms.Label lbl_titreListeLivres_emprunterLivre;
        private System.Windows.Forms.Label lbl_ordreDetail_emprunterLivre;
        private System.Windows.Forms.TextBox txtb_numCompte_emprunterLivre;
        private System.Windows.Forms.Label lbl_numCompte_emprunterLivre;
        private System.Windows.Forms.Button btn_validerNumCompte_emprunterLivre;
    }
}