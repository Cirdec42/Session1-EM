namespace Exercice_Tab2D_Ventes
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
            this.cboAnnée = new System.Windows.Forms.ComboBox();
            this.lblAnnée = new System.Windows.Forms.Label();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.vdaGrilleVentes = new VisualArrays.VisualDecimalArray();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboAnnée
            // 
            this.cboAnnée.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnnée.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAnnée.FormattingEnabled = true;
            this.cboAnnée.Location = new System.Drawing.Point(851, 32);
            this.cboAnnée.Name = "cboAnnée";
            this.cboAnnée.Size = new System.Drawing.Size(93, 24);
            this.cboAnnée.TabIndex = 0;
            this.cboAnnée.SelectedIndexChanged += new System.EventHandler(this.cboAnnee_SelectedIndexChanged);
            // 
            // lblAnnée
            // 
            this.lblAnnée.AutoSize = true;
            this.lblAnnée.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnée.Location = new System.Drawing.Point(785, 35);
            this.lblAnnée.Name = "lblAnnée";
            this.lblAnnée.Size = new System.Drawing.Size(60, 16);
            this.lblAnnée.TabIndex = 1;
            this.lblAnnée.Text = "Année :";
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(958, 24);
            this.mnuPrincipal.TabIndex = 3;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // vdaGrilleVentes
            // 
            this.vdaGrilleVentes.BackColor = System.Drawing.Color.Black;
            this.vdaGrilleVentes.CellSize = new System.Drawing.Size(71, 22);
            this.vdaGrilleVentes.ColumnCount = 12;
            this.vdaGrilleVentes.ColumnHeader.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(96)))));
            this.vdaGrilleVentes.ColumnHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdaGrilleVentes.ColumnHeader.ForeColor = System.Drawing.Color.Silver;
            this.vdaGrilleVentes.ColumnHeader.Height = 22;
            this.vdaGrilleVentes.ColumnHeader.ValueStyle = VisualArrays.enuDataStyle.User;
            this.vdaGrilleVentes.ColumnHeader.Visible = true;
            this.vdaGrilleVentes.DecimalPlaces = 2;
            this.vdaGrilleVentes.EnabledAppearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdaGrilleVentes.Location = new System.Drawing.Point(11, 66);
            this.vdaGrilleVentes.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.vdaGrilleVentes.Name = "vdaGrilleVentes";
            this.vdaGrilleVentes.Padding = new System.Windows.Forms.Padding(10);
            this.vdaGrilleVentes.RowCount = 1;
            this.vdaGrilleVentes.RowHeader.ForeColor = System.Drawing.Color.White;
            this.vdaGrilleVentes.Size = new System.Drawing.Size(933, 70);
            this.vdaGrilleVentes.TabIndex = 4;
            this.vdaGrilleVentes.ValueFormat = VisualArrays.enuValueFormat.Currency;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 145);
            this.Controls.Add(this.vdaGrilleVentes);
            this.Controls.Add(this.lblAnnée);
            this.Controls.Add(this.cboAnnée);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventes annuelles et Tableau 2D ";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAnnée;
        private System.Windows.Forms.Label lblAnnée;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private VisualArrays.VisualDecimalArray vdaGrilleVentes;
    }
}

