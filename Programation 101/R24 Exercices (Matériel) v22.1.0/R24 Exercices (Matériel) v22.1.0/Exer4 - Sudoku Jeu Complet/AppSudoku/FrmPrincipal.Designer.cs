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
            this.viaGrilleSudoku = new VisualArrays.VisualIntArray();
            this.lblSudoku = new System.Windows.Forms.Label();
            this.cboSudoku = new System.Windows.Forms.ComboBox();
            this.viaGrilleDuBas = new VisualArrays.VisualIntArray();
            this.viaGrilleDeDroite = new VisualArrays.VisualIntArray();
            this.menuPrincipal.SuspendLayout();
            this.panJeu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuAide});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(738, 35);
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
            this.mnuFichier.Size = new System.Drawing.Size(78, 29);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierNouvellePartie
            // 
            this.mnuFichierNouvellePartie.Name = "mnuFichierNouvellePartie";
            this.mnuFichierNouvellePartie.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFichierNouvellePartie.Size = new System.Drawing.Size(297, 34);
            this.mnuFichierNouvellePartie.Text = "&Nouvelle partie";
            this.mnuFichierNouvellePartie.Click += new System.EventHandler(this.mnuFichierNouvellePartie_Click);
            // 
            // mnuFichierSep1
            // 
            this.mnuFichierSep1.Name = "mnuFichierSep1";
            this.mnuFichierSep1.Size = new System.Drawing.Size(294, 6);
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(297, 34);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuAide
            // 
            this.mnuAide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAideSolutionner});
            this.mnuAide.Name = "mnuAide";
            this.mnuAide.Size = new System.Drawing.Size(64, 29);
            this.mnuAide.Text = "&Aide";
            // 
            // mnuAideSolutionner
            // 
            this.mnuAideSolutionner.Name = "mnuAideSolutionner";
            this.mnuAideSolutionner.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuAideSolutionner.Size = new System.Drawing.Size(266, 34);
            this.mnuAideSolutionner.Text = "&Solutionner";
            this.mnuAideSolutionner.Click += new System.EventHandler(this.mnuAideSolutionner_Click);
            // 
            // panSeparateurVertical1
            // 
            this.panSeparateurVertical1.BackColor = System.Drawing.Color.Gray;
            this.panSeparateurVertical1.Location = new System.Drawing.Point(219, 20);
            this.panSeparateurVertical1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panSeparateurVertical1.Name = "panSeparateurVertical1";
            this.panSeparateurVertical1.Size = new System.Drawing.Size(8, 569);
            this.panSeparateurVertical1.TabIndex = 7;
            // 
            // panSeparateurVertical2
            // 
            this.panSeparateurVertical2.BackColor = System.Drawing.Color.Gray;
            this.panSeparateurVertical2.Location = new System.Drawing.Point(418, 20);
            this.panSeparateurVertical2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panSeparateurVertical2.Name = "panSeparateurVertical2";
            this.panSeparateurVertical2.Size = new System.Drawing.Size(8, 569);
            this.panSeparateurVertical2.TabIndex = 8;
            // 
            // panSeparateurHorizontal1
            // 
            this.panSeparateurHorizontal1.BackColor = System.Drawing.Color.Gray;
            this.panSeparateurHorizontal1.Location = new System.Drawing.Point(20, 206);
            this.panSeparateurHorizontal1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panSeparateurHorizontal1.Name = "panSeparateurHorizontal1";
            this.panSeparateurHorizontal1.Size = new System.Drawing.Size(609, 8);
            this.panSeparateurHorizontal1.TabIndex = 8;
            // 
            // panSeparateurHorizontal2
            // 
            this.panSeparateurHorizontal2.BackColor = System.Drawing.Color.Gray;
            this.panSeparateurHorizontal2.Location = new System.Drawing.Point(20, 395);
            this.panSeparateurHorizontal2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panSeparateurHorizontal2.Name = "panSeparateurHorizontal2";
            this.panSeparateurHorizontal2.Size = new System.Drawing.Size(609, 8);
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
            this.panJeu.Controls.Add(this.viaGrilleSudoku);
            this.panJeu.Location = new System.Drawing.Point(18, 131);
            this.panJeu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panJeu.Name = "panJeu";
            this.panJeu.Size = new System.Drawing.Size(648, 611);
            this.panJeu.TabIndex = 11;
            // 
            // viaGrilleSudoku
            // 
            this.viaGrilleSudoku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viaGrilleSudoku.CellMargin = 4;
            this.viaGrilleSudoku.CellSize = new System.Drawing.Size(59, 54);
            this.viaGrilleSudoku.ColumnCount = 9;
            this.viaGrilleSudoku.DisabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viaGrilleSudoku.DisabledAppearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaGrilleSudoku.DisabledAppearance.Shape = VisualArrays.enuShape.RoundRect;
            this.viaGrilleSudoku.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.viaGrilleSudoku.DisabledAppearance.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viaGrilleSudoku.EnabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.viaGrilleSudoku.EnabledAppearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaGrilleSudoku.EnabledAppearance.Shape = VisualArrays.enuShape.RoundRect;
            this.viaGrilleSudoku.EnabledAppearance.TextColor = System.Drawing.Color.Black;
            this.viaGrilleSudoku.GridAppearance.Color = System.Drawing.Color.Silver;
            this.viaGrilleSudoku.Location = new System.Drawing.Point(9, 11);
            this.viaGrilleSudoku.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viaGrilleSudoku.Maximum = 9;
            this.viaGrilleSudoku.Minimum = 0;
            this.viaGrilleSudoku.Name = "viaGrilleSudoku";
            this.viaGrilleSudoku.RowCount = 9;
            this.viaGrilleSudoku.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaGrilleSudoku.SelectionAppearance.Padding = new System.Windows.Forms.Padding(2, 2, 1, 1);
            this.viaGrilleSudoku.SelectionAppearance.Shape = VisualArrays.enuShape.RoundRect;
            this.viaGrilleSudoku.SelectionMode = System.Windows.Forms.SelectionMode.One;
            this.viaGrilleSudoku.Size = new System.Drawing.Size(625, 580);
            this.viaGrilleSudoku.SpecialValue = 0;
            this.viaGrilleSudoku.TabIndex = 12;
            this.viaGrilleSudoku.ValueChanged += new System.EventHandler<VisualArrays.ValueChangedEventArgs>(this.viaSudoku_ValueChanged);
            this.viaGrilleSudoku.Click += new System.EventHandler(this.viaGrilleSudoku_Click);
            // 
            // lblSudoku
            // 
            this.lblSudoku.AutoSize = true;
            this.lblSudoku.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSudoku.Location = new System.Drawing.Point(22, 69);
            this.lblSudoku.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSudoku.Name = "lblSudoku";
            this.lblSudoku.Size = new System.Drawing.Size(234, 33);
            this.lblSudoku.TabIndex = 12;
            this.lblSudoku.Text = "Sudoku courant :";
            // 
            // cboSudoku
            // 
            this.cboSudoku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSudoku.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSudoku.FormattingEnabled = true;
            this.cboSudoku.Items.AddRange(new object[] {
            "A) Facile #1",
            "A) Facile #2",
            "B) Moyen #1",
            "B) Moyen #2",
            "B) Moyen #3",
            "B) Moyen #4",
            "C) Difficile #1",
            "C) Difficile #2"});
            this.cboSudoku.Location = new System.Drawing.Point(276, 65);
            this.cboSudoku.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSudoku.Name = "cboSudoku";
            this.cboSudoku.Size = new System.Drawing.Size(370, 41);
            this.cboSudoku.Sorted = true;
            this.cboSudoku.TabIndex = 13;
            this.cboSudoku.SelectedIndexChanged += new System.EventHandler(this.cboSudoku_SelectedIndexChanged);
            // 
            // viaGrilleDuBas
            // 
            this.viaGrilleDuBas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viaGrilleDuBas.CellMargin = 1;
            this.viaGrilleDuBas.CellSize = new System.Drawing.Size(64, 38);
            this.viaGrilleDuBas.ColumnCount = 9;
            this.viaGrilleDuBas.DisabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viaGrilleDuBas.DisabledAppearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaGrilleDuBas.DisabledAppearance.Shape = VisualArrays.enuShape.RoundRect;
            this.viaGrilleDuBas.DisabledAppearance.StrikeAppearance.Style = VisualArrays.enuStrikeStyle.Cross;
            this.viaGrilleDuBas.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.viaGrilleDuBas.DisabledAppearance.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viaGrilleDuBas.EnabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viaGrilleDuBas.EnabledAppearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaGrilleDuBas.EnabledAppearance.TextColor = System.Drawing.Color.Gray;
            this.viaGrilleDuBas.GridAppearance.Color = System.Drawing.Color.Silver;
            this.viaGrilleDuBas.Location = new System.Drawing.Point(34, 754);
            this.viaGrilleDuBas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viaGrilleDuBas.Maximum = 81;
            this.viaGrilleDuBas.Minimum = 0;
            this.viaGrilleDuBas.Name = "viaGrilleDuBas";
            this.viaGrilleDuBas.Padding = new System.Windows.Forms.Padding(2);
            this.viaGrilleDuBas.RowCount = 1;
            this.viaGrilleDuBas.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaGrilleDuBas.SelectionAppearance.Padding = new System.Windows.Forms.Padding(2, 2, 1, 1);
            this.viaGrilleDuBas.SelectionAppearance.Shape = VisualArrays.enuShape.RoundRect;
            this.viaGrilleDuBas.Size = new System.Drawing.Size(608, 46);
            this.viaGrilleDuBas.SpecialValue = 0;
            this.viaGrilleDuBas.TabIndex = 14;
            // 
            // viaGrilleDeDroite
            // 
            this.viaGrilleDeDroite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viaGrilleDeDroite.CellMargin = 1;
            this.viaGrilleDeDroite.CellSize = new System.Drawing.Size(37, 60);
            this.viaGrilleDeDroite.ColumnCount = 1;
            this.viaGrilleDeDroite.DisabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viaGrilleDeDroite.DisabledAppearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaGrilleDeDroite.DisabledAppearance.Shape = VisualArrays.enuShape.RoundRect;
            this.viaGrilleDeDroite.DisabledAppearance.StrikeAppearance.Style = VisualArrays.enuStrikeStyle.Cross;
            this.viaGrilleDeDroite.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.viaGrilleDeDroite.DisabledAppearance.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viaGrilleDeDroite.EnabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viaGrilleDeDroite.EnabledAppearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaGrilleDeDroite.EnabledAppearance.TextColor = System.Drawing.Color.Gray;
            this.viaGrilleDeDroite.GridAppearance.Color = System.Drawing.Color.Silver;
            this.viaGrilleDeDroite.Location = new System.Drawing.Point(678, 149);
            this.viaGrilleDeDroite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viaGrilleDeDroite.Maximum = 81;
            this.viaGrilleDeDroite.Minimum = 0;
            this.viaGrilleDeDroite.Name = "viaGrilleDeDroite";
            this.viaGrilleDeDroite.Padding = new System.Windows.Forms.Padding(2);
            this.viaGrilleDeDroite.RowCount = 9;
            this.viaGrilleDeDroite.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaGrilleDeDroite.SelectionAppearance.Padding = new System.Windows.Forms.Padding(2, 2, 1, 1);
            this.viaGrilleDeDroite.SelectionAppearance.Shape = VisualArrays.enuShape.RoundRect;
            this.viaGrilleDeDroite.Size = new System.Drawing.Size(45, 572);
            this.viaGrilleDeDroite.SpecialValue = 0;
            this.viaGrilleDeDroite.TabIndex = 15;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 812);
            this.Controls.Add(this.viaGrilleDuBas);
            this.Controls.Add(this.viaGrilleDeDroite);
            this.Controls.Add(this.cboSudoku);
            this.Controls.Add(this.lblSudoku);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.panJeu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku Jeu Complet ";
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
        private VisualArrays.VisualIntArray viaGrilleSudoku;
        private System.Windows.Forms.Label lblSudoku;
        private System.Windows.Forms.ComboBox cboSudoku;
        private System.Windows.Forms.ToolStripMenuItem mnuAide;
        private System.Windows.Forms.ToolStripMenuItem mnuAideSolutionner;
        private VisualArrays.VisualIntArray viaGrilleDuBas;
        private VisualArrays.VisualIntArray viaGrilleDeDroite;
    }
}

