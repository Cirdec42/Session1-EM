namespace EditeurListeMots
{
    partial class FrmPrincipal
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
            this.lstMots = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouterMot = new System.Windows.Forms.Button();
            this.txtNouveauMot = new System.Windows.Forms.TextBox();
            this.btnSupprimerMot = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelectedIndex = new System.Windows.Forms.TextBox();
            this.btnEnregistrerListe = new System.Windows.Forms.Button();
            this.lblInfos = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMots
            // 
            this.lstMots.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMots.FormattingEnabled = true;
            this.lstMots.ItemHeight = 25;
            this.lstMots.Location = new System.Drawing.Point(22, 53);
            this.lstMots.Name = "lstMots";
            this.lstMots.Size = new System.Drawing.Size(219, 279);
            this.lstMots.TabIndex = 0;
            this.lstMots.SelectedIndexChanged += new System.EventHandler(this.lstMots_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mots de la liste courante :";
            // 
            // btnAjouterMot
            // 
            this.btnAjouterMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterMot.Location = new System.Drawing.Point(265, 54);
            this.btnAjouterMot.Name = "btnAjouterMot";
            this.btnAjouterMot.Size = new System.Drawing.Size(189, 36);
            this.btnAjouterMot.TabIndex = 5;
            this.btnAjouterMot.Text = "&Ajouter un nouveau mot";
            this.btnAjouterMot.UseVisualStyleBackColor = true;
            this.btnAjouterMot.Click += new System.EventHandler(this.btnAjouterMot_Click);
            // 
            // txtNouveauMot
            // 
            this.txtNouveauMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNouveauMot.Location = new System.Drawing.Point(265, 96);
            this.txtNouveauMot.Name = "txtNouveauMot";
            this.txtNouveauMot.Size = new System.Drawing.Size(189, 31);
            this.txtNouveauMot.TabIndex = 6;
            // 
            // btnSupprimerMot
            // 
            this.btnSupprimerMot.Enabled = false;
            this.btnSupprimerMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerMot.Location = new System.Drawing.Point(265, 170);
            this.btnSupprimerMot.Name = "btnSupprimerMot";
            this.btnSupprimerMot.Size = new System.Drawing.Size(189, 31);
            this.btnSupprimerMot.TabIndex = 7;
            this.btnSupprimerMot.Text = "&Supprimer mot courant";
            this.btnSupprimerMot.UseVisualStyleBackColor = true;
            this.btnSupprimerMot.Click += new System.EventHandler(this.btnSupprimerMot_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "SelectedIndex :";
            // 
            // txtSelectedIndex
            // 
            this.txtSelectedIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedIndex.Location = new System.Drawing.Point(397, 133);
            this.txtSelectedIndex.Name = "txtSelectedIndex";
            this.txtSelectedIndex.ReadOnly = true;
            this.txtSelectedIndex.Size = new System.Drawing.Size(57, 31);
            this.txtSelectedIndex.TabIndex = 9;
            this.txtSelectedIndex.Text = "-1";
            this.txtSelectedIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnregistrerListe
            // 
            this.btnEnregistrerListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerListe.Location = new System.Drawing.Point(265, 222);
            this.btnEnregistrerListe.Name = "btnEnregistrerListe";
            this.btnEnregistrerListe.Size = new System.Drawing.Size(189, 31);
            this.btnEnregistrerListe.TabIndex = 10;
            this.btnEnregistrerListe.Text = "&Enregistrer la liste";
            this.btnEnregistrerListe.UseVisualStyleBackColor = true;
            this.btnEnregistrerListe.Click += new System.EventHandler(this.BtnEnregistrerListe_Click);
            // 
            // lblInfos
            // 
            this.lblInfos.Location = new System.Drawing.Point(265, 256);
            this.lblInfos.Name = "lblInfos";
            this.lblInfos.Size = new System.Drawing.Size(189, 76);
            this.lblInfos.TabIndex = 11;
            this.lblInfos.Text = "Après avoir cliqué sur le bouton Enregistrer, vous devez aller voir dans le dossi" +
    "er bin de votre application, il devrait y avoir un fichier nommé \"ListeDeMots.tx" +
    "t\"";
            this.lblInfos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AcceptButton = this.btnAjouterMot;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 350);
            this.Controls.Add(this.lblInfos);
            this.Controls.Add(this.btnEnregistrerListe);
            this.Controls.Add(this.txtSelectedIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSupprimerMot);
            this.Controls.Add(this.txtNouveauMot);
            this.Controls.Add(this.btnAjouterMot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMots);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enregistrer avec un StreamWriter ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMots;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouterMot;
        private System.Windows.Forms.TextBox txtNouveauMot;
        private System.Windows.Forms.Button btnSupprimerMot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSelectedIndex;
        private System.Windows.Forms.Button btnEnregistrerListe;
        private System.Windows.Forms.Label lblInfos;
    }
}

