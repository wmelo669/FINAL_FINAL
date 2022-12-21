namespace projetFinal.formulaires
{
    partial class FormRegarderPrets
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
            this.lbl_visualizerPrets_clien = new System.Windows.Forms.Label();
            this.btn_validerNumCompte_visualizerEmprunt = new System.Windows.Forms.Button();
            this.txtb_numCompte_visualizerEmprunt = new System.Windows.Forms.TextBox();
            this.lbl_numCompte_visalizerEmprunt = new System.Windows.Forms.Label();
            this.listView_visualiserPrets = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbl_visualizerPrets_clien
            // 
            this.lbl_visualizerPrets_clien.AutoSize = true;
            this.lbl_visualizerPrets_clien.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_visualizerPrets_clien.Location = new System.Drawing.Point(203, 42);
            this.lbl_visualizerPrets_clien.Name = "lbl_visualizerPrets_clien";
            this.lbl_visualizerPrets_clien.Size = new System.Drawing.Size(400, 31);
            this.lbl_visualizerPrets_clien.TabIndex = 2;
            this.lbl_visualizerPrets_clien.Text = "Visualisation des prets des clients :)";
            // 
            // btn_validerNumCompte_visualizerEmprunt
            // 
            this.btn_validerNumCompte_visualizerEmprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validerNumCompte_visualizerEmprunt.Location = new System.Drawing.Point(515, 97);
            this.btn_validerNumCompte_visualizerEmprunt.Name = "btn_validerNumCompte_visualizerEmprunt";
            this.btn_validerNumCompte_visualizerEmprunt.Size = new System.Drawing.Size(107, 35);
            this.btn_validerNumCompte_visualizerEmprunt.TabIndex = 60;
            this.btn_validerNumCompte_visualizerEmprunt.Text = "Valider";
            this.btn_validerNumCompte_visualizerEmprunt.UseVisualStyleBackColor = true;
            this.btn_validerNumCompte_visualizerEmprunt.Click += new System.EventHandler(this.btn_validerNumCompte_visualizerEmprunt_Click);
            // 
            // txtb_numCompte_visualizerEmprunt
            // 
            this.txtb_numCompte_visualizerEmprunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_numCompte_visualizerEmprunt.Location = new System.Drawing.Point(311, 101);
            this.txtb_numCompte_visualizerEmprunt.Name = "txtb_numCompte_visualizerEmprunt";
            this.txtb_numCompte_visualizerEmprunt.Size = new System.Drawing.Size(187, 24);
            this.txtb_numCompte_visualizerEmprunt.TabIndex = 59;
            // 
            // lbl_numCompte_visalizerEmprunt
            // 
            this.lbl_numCompte_visalizerEmprunt.AutoSize = true;
            this.lbl_numCompte_visalizerEmprunt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numCompte_visalizerEmprunt.Location = new System.Drawing.Point(139, 101);
            this.lbl_numCompte_visalizerEmprunt.Name = "lbl_numCompte_visalizerEmprunt";
            this.lbl_numCompte_visalizerEmprunt.Size = new System.Drawing.Size(154, 21);
            this.lbl_numCompte_visalizerEmprunt.TabIndex = 58;
            this.lbl_numCompte_visalizerEmprunt.Text = "Numéro de compte";
            // 
            // listView_visualiserPrets
            // 
            this.listView_visualiserPrets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_visualiserPrets.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_visualiserPrets.HideSelection = false;
            this.listView_visualiserPrets.Location = new System.Drawing.Point(143, 166);
            this.listView_visualiserPrets.Name = "listView_visualiserPrets";
            this.listView_visualiserPrets.Size = new System.Drawing.Size(555, 176);
            this.listView_visualiserPrets.TabIndex = 61;
            this.listView_visualiserPrets.UseCompatibleStateImageBehavior = false;
            this.listView_visualiserPrets.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numéro de facture";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ISBN";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Numéro de compte";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantité";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date du pret";
            this.columnHeader5.Width = 110;
            // 
            // FormRegarderPrets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 428);
            this.Controls.Add(this.listView_visualiserPrets);
            this.Controls.Add(this.btn_validerNumCompte_visualizerEmprunt);
            this.Controls.Add(this.txtb_numCompte_visualizerEmprunt);
            this.Controls.Add(this.lbl_numCompte_visalizerEmprunt);
            this.Controls.Add(this.lbl_visualizerPrets_clien);
            this.Name = "FormRegarderPrets";
            this.Text = "Emprunts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegarderPrets_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_visualizerPrets_clien;
        private System.Windows.Forms.Button btn_validerNumCompte_visualizerEmprunt;
        private System.Windows.Forms.TextBox txtb_numCompte_visualizerEmprunt;
        private System.Windows.Forms.Label lbl_numCompte_visalizerEmprunt;
        private System.Windows.Forms.ListView listView_visualiserPrets;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}