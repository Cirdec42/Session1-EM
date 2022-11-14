namespace InstancierUnDC
{
    partial class FrmEx1UnDC
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
            this.btnInstancierUnDC = new System.Windows.Forms.Button();
            this.grpInfosDC = new System.Windows.Forms.GroupBox();
            this.lblDureeTotaleSecondes = new System.Windows.Forms.Label();
            this.txtDureeTotaleSecondes = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblDureeTotaleMMSS = new System.Windows.Forms.Label();
            this.lblNbPistes = new System.Windows.Forms.Label();
            this.txtNbPistes = new System.Windows.Forms.TextBox();
            this.txtDureeTotaleMMSS = new System.Windows.Forms.TextBox();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.grpInfosDC.SuspendLayout();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInstancierUnDC
            // 
            this.btnInstancierUnDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstancierUnDC.Location = new System.Drawing.Point(21, 228);
            this.btnInstancierUnDC.Name = "btnInstancierUnDC";
            this.btnInstancierUnDC.Size = new System.Drawing.Size(328, 46);
            this.btnInstancierUnDC.TabIndex = 1;
            this.btnInstancierUnDC.Text = "Instancier un nouveau DisqueCompact";
            this.btnInstancierUnDC.UseVisualStyleBackColor = true;
            this.btnInstancierUnDC.Click += new System.EventHandler(this.btnInstancierUnDC_Click);
            // 
            // grpInfosDC
            // 
            this.grpInfosDC.Controls.Add(this.lblDureeTotaleSecondes);
            this.grpInfosDC.Controls.Add(this.txtDureeTotaleSecondes);
            this.grpInfosDC.Controls.Add(this.lblGenre);
            this.grpInfosDC.Controls.Add(this.txtGenre);
            this.grpInfosDC.Controls.Add(this.lblDureeTotaleMMSS);
            this.grpInfosDC.Controls.Add(this.lblNbPistes);
            this.grpInfosDC.Controls.Add(this.txtNbPistes);
            this.grpInfosDC.Controls.Add(this.txtDureeTotaleMMSS);
            this.grpInfosDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfosDC.Location = new System.Drawing.Point(21, 43);
            this.grpInfosDC.Name = "grpInfosDC";
            this.grpInfosDC.Size = new System.Drawing.Size(328, 171);
            this.grpInfosDC.TabIndex = 0;
            this.grpInfosDC.TabStop = false;
            this.grpInfosDC.Text = "Informations sur le disque compact";
            // 
            // lblDureeTotaleSecondes
            // 
            this.lblDureeTotaleSecondes.AutoSize = true;
            this.lblDureeTotaleSecondes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDureeTotaleSecondes.Location = new System.Drawing.Point(11, 63);
            this.lblDureeTotaleSecondes.Name = "lblDureeTotaleSecondes";
            this.lblDureeTotaleSecondes.Size = new System.Drawing.Size(192, 20);
            this.lblDureeTotaleSecondes.TabIndex = 2;
            this.lblDureeTotaleSecondes.Text = "Durée totale (secondes)  :";
            // 
            // txtDureeTotaleSecondes
            // 
            this.txtDureeTotaleSecondes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDureeTotaleSecondes.Location = new System.Drawing.Point(214, 62);
            this.txtDureeTotaleSecondes.Name = "txtDureeTotaleSecondes";
            this.txtDureeTotaleSecondes.ReadOnly = true;
            this.txtDureeTotaleSecondes.Size = new System.Drawing.Size(91, 26);
            this.txtDureeTotaleSecondes.TabIndex = 3;
            this.txtDureeTotaleSecondes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(11, 131);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(62, 20);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre :";
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(214, 128);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(91, 26);
            this.txtGenre.TabIndex = 7;
            this.txtGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDureeTotaleMMSS
            // 
            this.lblDureeTotaleMMSS.AutoSize = true;
            this.lblDureeTotaleMMSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDureeTotaleMMSS.Location = new System.Drawing.Point(11, 96);
            this.lblDureeTotaleMMSS.Name = "lblDureeTotaleMMSS";
            this.lblDureeTotaleMMSS.Size = new System.Drawing.Size(169, 20);
            this.lblDureeTotaleMMSS.TabIndex = 4;
            this.lblDureeTotaleMMSS.Text = "Durée totale (mm:ss)  :";
            // 
            // lblNbPistes
            // 
            this.lblNbPistes.AutoSize = true;
            this.lblNbPistes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbPistes.Location = new System.Drawing.Point(11, 32);
            this.lblNbPistes.Name = "lblNbPistes";
            this.lblNbPistes.Size = new System.Drawing.Size(141, 20);
            this.lblNbPistes.TabIndex = 0;
            this.lblNbPistes.Text = "Nombre de pistes :";
            // 
            // txtNbPistes
            // 
            this.txtNbPistes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbPistes.Location = new System.Drawing.Point(214, 32);
            this.txtNbPistes.Name = "txtNbPistes";
            this.txtNbPistes.ReadOnly = true;
            this.txtNbPistes.Size = new System.Drawing.Size(91, 26);
            this.txtNbPistes.TabIndex = 1;
            this.txtNbPistes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNbPistes.TextChanged += new System.EventHandler(this.txtNbPistes_TextChanged);
            // 
            // txtDureeTotaleMMSS
            // 
            this.txtDureeTotaleMMSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDureeTotaleMMSS.Location = new System.Drawing.Point(214, 94);
            this.txtDureeTotaleMMSS.Name = "txtDureeTotaleMMSS";
            this.txtDureeTotaleMMSS.ReadOnly = true;
            this.txtDureeTotaleMMSS.Size = new System.Drawing.Size(91, 26);
            this.txtDureeTotaleMMSS.TabIndex = 5;
            this.txtDureeTotaleMMSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(379, 24);
            this.mnuPrincipal.TabIndex = 4;
            this.mnuPrincipal.Text = "menuStrip1";
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
            this.mnuFichierQuitter.Click += new System.EventHandler(this.MnuFichierQuitter_Click);
            // 
            // FrmEx1UnDC
            // 
            this.AcceptButton = this.btnInstancierUnDC;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 289);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.grpInfosDC);
            this.Controls.Add(this.btnInstancierUnDC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEx1UnDC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instancier un DisqueCompact ";
            this.grpInfosDC.ResumeLayout(false);
            this.grpInfosDC.PerformLayout();
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstancierUnDC;
        private System.Windows.Forms.GroupBox grpInfosDC;
        private System.Windows.Forms.TextBox txtNbPistes;
        private System.Windows.Forms.TextBox txtDureeTotaleMMSS;
        private System.Windows.Forms.Label lblDureeTotaleMMSS;
        private System.Windows.Forms.Label lblNbPistes;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblDureeTotaleSecondes;
        private System.Windows.Forms.TextBox txtDureeTotaleSecondes;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
    }
}

