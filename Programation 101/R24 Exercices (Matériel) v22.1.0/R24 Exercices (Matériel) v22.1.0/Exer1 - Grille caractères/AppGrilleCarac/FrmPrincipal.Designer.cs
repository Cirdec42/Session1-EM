namespace AppSudoku
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierNouvelleGrilleVide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierChargerLesCaractères = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierEnregistrerCaractères = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.panJeu = new System.Windows.Forms.Panel();
            this.vcaGrilleCarac = new VisualArrays.VisualCharArray();
            this.menuPrincipal.SuspendLayout();
            this.panJeu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(696, 35);
            this.menuPrincipal.TabIndex = 6;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierNouvelleGrilleVide,
            this.toolStripMenuItem2,
            this.mnuFichierChargerLesCaractères,
            this.mnuFichierEnregistrerCaractères,
            this.toolStripMenuItem1,
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(78, 29);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierNouvelleGrilleVide
            // 
            this.mnuFichierNouvelleGrilleVide.Name = "mnuFichierNouvelleGrilleVide";
            this.mnuFichierNouvelleGrilleVide.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFichierNouvelleGrilleVide.Size = new System.Drawing.Size(368, 34);
            this.mnuFichierNouvelleGrilleVide.Text = "Nouvelle grille vide";
            this.mnuFichierNouvelleGrilleVide.Click += new System.EventHandler(this.MnuFichierNouvelleGrilleVide_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(365, 6);
            // 
            // mnuFichierChargerLesCaractères
            // 
            this.mnuFichierChargerLesCaractères.Name = "mnuFichierChargerLesCaractères";
            this.mnuFichierChargerLesCaractères.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFichierChargerLesCaractères.Size = new System.Drawing.Size(368, 34);
            this.mnuFichierChargerLesCaractères.Text = "Charger les caractères";
            this.mnuFichierChargerLesCaractères.Click += new System.EventHandler(this.MnuFichierChargerLesCaractères_Click);
            // 
            // mnuFichierEnregistrerCaractères
            // 
            this.mnuFichierEnregistrerCaractères.Name = "mnuFichierEnregistrerCaractères";
            this.mnuFichierEnregistrerCaractères.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFichierEnregistrerCaractères.Size = new System.Drawing.Size(368, 34);
            this.mnuFichierEnregistrerCaractères.Text = "Enregistrer les caractères";
            this.mnuFichierEnregistrerCaractères.Click += new System.EventHandler(this.MnuFichierEnregistrerCaractères_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(365, 6);
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(368, 34);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.MnuFichierQuitter_Click);
            // 
            // panJeu
            // 
            this.panJeu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panJeu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panJeu.Controls.Add(this.vcaGrilleCarac);
            this.panJeu.Location = new System.Drawing.Point(22, 62);
            this.panJeu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panJeu.Name = "panJeu";
            this.panJeu.Size = new System.Drawing.Size(648, 611);
            this.panJeu.TabIndex = 11;
            // 
            // vcaGrilleCarac
            // 
            this.vcaGrilleCarac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vcaGrilleCarac.CellMargin = 4;
            this.vcaGrilleCarac.CellSize = new System.Drawing.Size(59, 54);
            this.vcaGrilleCarac.ColumnCount = 9;
            this.vcaGrilleCarac.DefaultValue = ' ';
            this.vcaGrilleCarac.DisabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vcaGrilleCarac.DisabledAppearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcaGrilleCarac.DisabledAppearance.Shape = VisualArrays.enuShape.RoundRect;
            this.vcaGrilleCarac.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.vcaGrilleCarac.DisabledAppearance.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vcaGrilleCarac.EnabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.vcaGrilleCarac.EnabledAppearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcaGrilleCarac.EnabledAppearance.Shape = VisualArrays.enuShape.RoundRect;
            this.vcaGrilleCarac.EnabledAppearance.TextColor = System.Drawing.Color.Black;
            this.vcaGrilleCarac.GridAppearance.Color = System.Drawing.Color.Silver;
            this.vcaGrilleCarac.Location = new System.Drawing.Point(9, 11);
            this.vcaGrilleCarac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vcaGrilleCarac.Name = "vcaGrilleCarac";
            this.vcaGrilleCarac.RowCount = 9;
            this.vcaGrilleCarac.RowHeader.ForeColor = System.Drawing.Color.White;
            this.vcaGrilleCarac.SelectionAppearance.Padding = new System.Windows.Forms.Padding(2, 2, 1, 1);
            this.vcaGrilleCarac.SelectionAppearance.Shape = VisualArrays.enuShape.RoundRect;
            this.vcaGrilleCarac.SelectionMode = System.Windows.Forms.SelectionMode.One;
            this.vcaGrilleCarac.Size = new System.Drawing.Size(625, 580);
            this.vcaGrilleCarac.SpecialValue = ' ';
            this.vcaGrilleCarac.TabIndex = 12;
            this.vcaGrilleCarac.Click += new System.EventHandler(this.vcaGrilleCarac_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 698);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.panJeu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grille de caractères ";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.panJeu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.Panel panJeu;
        private VisualArrays.VisualCharArray vcaGrilleCarac;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierNouvelleGrilleVide;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierChargerLesCaractères;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierEnregistrerCaractères;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

