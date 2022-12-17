namespace projetFinal.formulaires
{
    partial class FormRegarderEmployes
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
            this.dataGridViewEmployes_visualiserEmployes = new System.Windows.Forms.DataGridView();
            this.dtgrid_numCompte_visualisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrid_nomCompte_visualisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrid_prenomCompte_visualisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrid_typeCompte_visualisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrid_mdpCompte_visualisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_titre_visualiserEmployes = new System.Windows.Forms.Label();
            this.btn_valider_creerLivre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployes_visualiserEmployes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployes_visualiserEmployes
            // 
            this.dataGridViewEmployes_visualiserEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployes_visualiserEmployes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgrid_numCompte_visualisation,
            this.dtgrid_nomCompte_visualisation,
            this.dtgrid_prenomCompte_visualisation,
            this.dtgrid_typeCompte_visualisation,
            this.dtgrid_mdpCompte_visualisation});
            this.dataGridViewEmployes_visualiserEmployes.Location = new System.Drawing.Point(76, 177);
            this.dataGridViewEmployes_visualiserEmployes.Name = "dataGridViewEmployes_visualiserEmployes";
            this.dataGridViewEmployes_visualiserEmployes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployes_visualiserEmployes.Size = new System.Drawing.Size(944, 150);
            this.dataGridViewEmployes_visualiserEmployes.TabIndex = 0;
            // 
            // dtgrid_numCompte_visualisation
            // 
            this.dtgrid_numCompte_visualisation.HeaderText = "Numéro de compte";
            this.dtgrid_numCompte_visualisation.Name = "dtgrid_numCompte_visualisation";
            this.dtgrid_numCompte_visualisation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_numCompte_visualisation.Width = 180;
            // 
            // dtgrid_nomCompte_visualisation
            // 
            this.dtgrid_nomCompte_visualisation.HeaderText = "Nom du compte";
            this.dtgrid_nomCompte_visualisation.Name = "dtgrid_nomCompte_visualisation";
            this.dtgrid_nomCompte_visualisation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_nomCompte_visualisation.Width = 180;
            // 
            // dtgrid_prenomCompte_visualisation
            // 
            this.dtgrid_prenomCompte_visualisation.HeaderText = "Prenom du compte";
            this.dtgrid_prenomCompte_visualisation.Name = "dtgrid_prenomCompte_visualisation";
            this.dtgrid_prenomCompte_visualisation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_prenomCompte_visualisation.Width = 180;
            // 
            // dtgrid_typeCompte_visualisation
            // 
            this.dtgrid_typeCompte_visualisation.HeaderText = "Type de compte";
            this.dtgrid_typeCompte_visualisation.Name = "dtgrid_typeCompte_visualisation";
            this.dtgrid_typeCompte_visualisation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_typeCompte_visualisation.Width = 180;
            // 
            // dtgrid_mdpCompte_visualisation
            // 
            this.dtgrid_mdpCompte_visualisation.HeaderText = "Mot de passe";
            this.dtgrid_mdpCompte_visualisation.Name = "dtgrid_mdpCompte_visualisation";
            this.dtgrid_mdpCompte_visualisation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_mdpCompte_visualisation.Width = 180;
            // 
            // lbl_titre_visualiserEmployes
            // 
            this.lbl_titre_visualiserEmployes.AutoSize = true;
            this.lbl_titre_visualiserEmployes.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre_visualiserEmployes.Location = new System.Drawing.Point(377, 35);
            this.lbl_titre_visualiserEmployes.Name = "lbl_titre_visualiserEmployes";
            this.lbl_titre_visualiserEmployes.Size = new System.Drawing.Size(329, 31);
            this.lbl_titre_visualiserEmployes.TabIndex = 1;
            this.lbl_titre_visualiserEmployes.Text = "Visualisation des employés :)";
            // 
            // btn_valider_creerLivre
            // 
            this.btn_valider_creerLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider_creerLivre.Location = new System.Drawing.Point(469, 102);
            this.btn_valider_creerLivre.Name = "btn_valider_creerLivre";
            this.btn_valider_creerLivre.Size = new System.Drawing.Size(148, 36);
            this.btn_valider_creerLivre.TabIndex = 22;
            this.btn_valider_creerLivre.Text = "Supprimer";
            this.btn_valider_creerLivre.UseVisualStyleBackColor = true;
            this.btn_valider_creerLivre.Click += new System.EventHandler(this.btn_supprimer_visualiserEmployes);
            // 
            // FormRegarderEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 377);
            this.Controls.Add(this.btn_valider_creerLivre);
            this.Controls.Add(this.lbl_titre_visualiserEmployes);
            this.Controls.Add(this.dataGridViewEmployes_visualiserEmployes);
            this.Name = "FormRegarderEmployes";
            this.Text = "Visualisation des employés :)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegarderEmployes_FormClosing);
            this.Load += new System.EventHandler(this.FormRegarderEmployes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployes_visualiserEmployes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployes_visualiserEmployes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrid_numCompte_visualisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrid_nomCompte_visualisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrid_prenomCompte_visualisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrid_typeCompte_visualisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrid_mdpCompte_visualisation;
        private System.Windows.Forms.Label lbl_titre_visualiserEmployes;
        private System.Windows.Forms.Button btn_valider_creerLivre;
    }
}