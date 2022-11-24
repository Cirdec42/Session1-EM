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
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.panSeparateurVertical1 = new System.Windows.Forms.Panel();
            this.panSeparateurVertical2 = new System.Windows.Forms.Panel();
            this.panSeparateurHorizontal1 = new System.Windows.Forms.Panel();
            this.panSeparateurHorizontal2 = new System.Windows.Forms.Panel();
            this.panJeu = new System.Windows.Forms.Panel();
            this.vcaSudoku = new VisualArrays.VisualCharArray();
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
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(78, 29);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(234, 34);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
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
            this.panJeu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panJeu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panJeu.Controls.Add(this.panSeparateurHorizontal2);
            this.panJeu.Controls.Add(this.panSeparateurVertical2);
            this.panJeu.Controls.Add(this.panSeparateurHorizontal1);
            this.panJeu.Controls.Add(this.panSeparateurVertical1);
            this.panJeu.Controls.Add(this.vcaSudoku);
            this.panJeu.Location = new System.Drawing.Point(22, 62);
            this.panJeu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panJeu.Name = "panJeu";
            this.panJeu.Size = new System.Drawing.Size(648, 611);
            this.panJeu.TabIndex = 11;
            // 
            // vcaSudoku
            // 
            this.vcaSudoku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vcaSudoku.CellMargin = 4;
            this.vcaSudoku.CellSize = new System.Drawing.Size(59, 54);
            this.vcaSudoku.ColumnCount = 9;
            this.vcaSudoku.DefaultValue = ' ';
            this.vcaSudoku.DisabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vcaSudoku.DisabledAppearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcaSudoku.DisabledAppearance.Shape = VisualArrays.enuShape.RoundRect;
            this.vcaSudoku.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.vcaSudoku.DisabledAppearance.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vcaSudoku.EnabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.vcaSudoku.EnabledAppearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcaSudoku.EnabledAppearance.Shape = VisualArrays.enuShape.RoundRect;
            this.vcaSudoku.EnabledAppearance.TextColor = System.Drawing.Color.Black;
            this.vcaSudoku.GridAppearance.Color = System.Drawing.Color.Silver;
            this.vcaSudoku.Location = new System.Drawing.Point(9, 11);
            this.vcaSudoku.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vcaSudoku.Name = "vcaSudoku";
            this.vcaSudoku.RowCount = 9;
            this.vcaSudoku.RowHeader.ForeColor = System.Drawing.Color.White;
            this.vcaSudoku.SelectionAppearance.Padding = new System.Windows.Forms.Padding(2, 2, 1, 1);
            this.vcaSudoku.SelectionAppearance.Shape = VisualArrays.enuShape.RoundRect;
            this.vcaSudoku.SelectionMode = System.Windows.Forms.SelectionMode.One;
            this.vcaSudoku.Size = new System.Drawing.Size(625, 580);
            this.vcaSudoku.SpecialValue = ' ';
            this.vcaSudoku.TabIndex = 12;
            this.vcaSudoku.Click += new System.EventHandler(this.vcaSudoku_Click);
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
            this.Text = "Sudoku Vision ";
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
        private System.Windows.Forms.Panel panJeu;
        private VisualArrays.VisualCharArray vcaSudoku;
    }
}

