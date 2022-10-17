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
            this.mnuFichierNouvellePartie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAide = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAideSolutionner = new System.Windows.Forms.ToolStripMenuItem();
            this.panSeparateurVertical1 = new System.Windows.Forms.Panel();
            this.panSeparateurVertical2 = new System.Windows.Forms.Panel();
            this.panSeparateurHorizontal1 = new System.Windows.Forms.Panel();
            this.panSeparateurHorizontal2 = new System.Windows.Forms.Panel();
            this.panJeu = new System.Windows.Forms.Panel();
            this.viaGrille = new VisualArrays.VisualIntArray();
            this.menuPrincipal.SuspendLayout();
            this.panJeu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuAide});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(462, 24);
            this.menuPrincipal.TabIndex = 6;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierNouvellePartie,
            this.mnuFichierSep1,
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierNouvellePartie
            // 
            this.mnuFichierNouvellePartie.Name = "mnuFichierNouvellePartie";
            this.mnuFichierNouvellePartie.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFichierNouvellePartie.Size = new System.Drawing.Size(197, 22);
            this.mnuFichierNouvellePartie.Text = "&Nouvelle partie";
            this.mnuFichierNouvellePartie.Click += new System.EventHandler(this.mnuFichierNouvellePartie_Click);
            // 
            // mnuFichierSep1
            // 
            this.mnuFichierSep1.Name = "mnuFichierSep1";
            this.mnuFichierSep1.Size = new System.Drawing.Size(194, 6);
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(197, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuAide
            // 
            this.mnuAide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAideSolutionner});
            this.mnuAide.Name = "mnuAide";
            this.mnuAide.Size = new System.Drawing.Size(43, 20);
            this.mnuAide.Text = "&Aide";
            // 
            // mnuAideSolutionner
            // 
            this.mnuAideSolutionner.Name = "mnuAideSolutionner";
            this.mnuAideSolutionner.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuAideSolutionner.Size = new System.Drawing.Size(175, 22);
            this.mnuAideSolutionner.Text = "&Solutionner";
            this.mnuAideSolutionner.Click += new System.EventHandler(this.mnuAideSolutionner_Click);
            // 
            // panSeparateurVertical1
            // 
            this.panSeparateurVertical1.BackColor = System.Drawing.Color.Gray;
            this.panSeparateurVertical1.Location = new System.Drawing.Point(146, 13);
            this.panSeparateurVertical1.Name = "panSeparateurVertical1";
            this.panSeparateurVertical1.Size = new System.Drawing.Size(5, 370);
            this.panSeparateurVertical1.TabIndex = 7;
            // 
            // panSeparateurVertical2
            // 
            this.panSeparateurVertical2.BackColor = System.Drawing.Color.Gray;
            this.panSeparateurVertical2.Location = new System.Drawing.Point(279, 13);
            this.panSeparateurVertical2.Name = "panSeparateurVertical2";
            this.panSeparateurVertical2.Size = new System.Drawing.Size(5, 370);
            this.panSeparateurVertical2.TabIndex = 8;
            // 
            // panSeparateurHorizontal1
            // 
            this.panSeparateurHorizontal1.BackColor = System.Drawing.Color.Gray;
            this.panSeparateurHorizontal1.Location = new System.Drawing.Point(13, 134);
            this.panSeparateurHorizontal1.Name = "panSeparateurHorizontal1";
            this.panSeparateurHorizontal1.Size = new System.Drawing.Size(406, 5);
            this.panSeparateurHorizontal1.TabIndex = 8;
            // 
            // panSeparateurHorizontal2
            // 
            this.panSeparateurHorizontal2.BackColor = System.Drawing.Color.Gray;
            this.panSeparateurHorizontal2.Location = new System.Drawing.Point(13, 257);
            this.panSeparateurHorizontal2.Name = "panSeparateurHorizontal2";
            this.panSeparateurHorizontal2.Size = new System.Drawing.Size(406, 5);
            this.panSeparateurHorizontal2.TabIndex = 9;
            // 
            // panJeu
            // 
            this.panJeu.BackColor = System.Drawing.Color.Green;
            this.panJeu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panJeu.Controls.Add(this.panSeparateurHorizontal2);
            this.panJeu.Controls.Add(this.panSeparateurVertical2);
            this.panJeu.Controls.Add(this.panSeparateurHorizontal1);
            this.panJeu.Controls.Add(this.panSeparateurVertical1);
            this.panJeu.Controls.Add(this.viaGrille);
            this.panJeu.Location = new System.Drawing.Point(15, 40);
            this.panJeu.Name = "panJeu";
            this.panJeu.Size = new System.Drawing.Size(433, 398);
            this.panJeu.TabIndex = 11;
            // 
            // viaGrille
            // 
            this.viaGrille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viaGrille.CellMargin = 4;
            this.viaGrille.CellSize = new System.Drawing.Size(36, 32);
            this.viaGrille.ColumnCount = 9;
            this.viaGrille.DisabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viaGrille.DisabledAppearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaGrille.DisabledAppearance.Shape = VisualArrays.enuShape.RoundRect;
            this.viaGrille.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.viaGrille.DisabledAppearance.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viaGrille.EnabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.viaGrille.EnabledAppearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaGrille.EnabledAppearance.Shape = VisualArrays.enuShape.RoundRect;
            this.viaGrille.EnabledAppearance.TextColor = System.Drawing.Color.Black;
            this.viaGrille.GridAppearance.Color = System.Drawing.Color.Silver;
            this.viaGrille.Location = new System.Drawing.Point(6, 7);
            this.viaGrille.Maximum = 9;
            this.viaGrille.Minimum = 0;
            this.viaGrille.Name = "viaGrille";
            this.viaGrille.RowCount = 9;
            this.viaGrille.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaGrille.SelectionAppearance.Padding = new System.Windows.Forms.Padding(2, 2, 1, 1);
            this.viaGrille.SelectionAppearance.Shape = VisualArrays.enuShape.RoundRect;
            this.viaGrille.SelectionMode = System.Windows.Forms.SelectionMode.One;
            this.viaGrille.Size = new System.Drawing.Size(418, 382);
            this.viaGrille.SpecialValue = 0;
            this.viaGrille.TabIndex = 12;
            this.viaGrille.ValueChanged += new System.EventHandler<VisualArrays.ValueChangedEventArgs>(this.viaGrille_ValueChanged);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 453);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.panJeu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu du Sudoku ";
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
        private System.Windows.Forms.Panel panSeparateurVertical1;
        private System.Windows.Forms.Panel panSeparateurVertical2;
        private System.Windows.Forms.Panel panSeparateurHorizontal1;
        private System.Windows.Forms.Panel panSeparateurHorizontal2;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierNouvellePartie;
        private System.Windows.Forms.ToolStripSeparator mnuFichierSep1;
        private System.Windows.Forms.Panel panJeu;
        private VisualArrays.VisualIntArray viaGrille;
        private System.Windows.Forms.ToolStripMenuItem mnuAide;
        private System.Windows.Forms.ToolStripMenuItem mnuAideSolutionner;
    }
}

