namespace ChercherUnNombreCache
{
    partial class FrmEx6ChercherUnNombreCache
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
            this.vsiNbEssais = new VisualArrays.VisualCells.VisualInt();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierNouvellePartie = new System.Windows.Forms.ToolStripMenuItem();
            this.tspFichier = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAide = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAideCommentJouer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécialModeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.vsiNombreAVerifier = new VisualArrays.VisualCells.VisualInt();
            this.vsbPlusPetit = new VisualArrays.VisualCells.VisualBool();
            this.vsbPlusGrand = new VisualArrays.VisualCells.VisualBool();
            this.lblNbEssais = new System.Windows.Forms.Label();
            this.btnAccepter = new System.Windows.Forms.Button();
            this.lblPlusPetitQueNombreCache = new System.Windows.Forms.Label();
            this.lblPlusGrandQueNombreCache = new System.Windows.Forms.Label();
            this.lblNombreAVerifier = new System.Windows.Forms.Label();
            this.vsiNombreCaché = new VisualArrays.VisualCells.VisualInt();
            this.lblNombreCaché = new System.Windows.Forms.Label();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // vsiNbEssais
            // 
            this.vsiNbEssais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vsiNbEssais.FocusColor = System.Drawing.Color.Gray;
            this.vsiNbEssais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNbEssais.ForeColor = System.Drawing.Color.Black;
            this.vsiNbEssais.GraphAppearance.BarAlign = VisualArrays.enuBarAlign.Middle;
            this.vsiNbEssais.GraphAppearance.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.vsiNbEssais.Location = new System.Drawing.Point(232, 268);
            this.vsiNbEssais.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vsiNbEssais.Maximum = 10;
            this.vsiNbEssais.Minimum = 0;
            this.vsiNbEssais.Name = "vsiNbEssais";
            this.vsiNbEssais.ReadOnly = true;
            this.vsiNbEssais.Size = new System.Drawing.Size(172, 45);
            this.vsiNbEssais.TabIndex = 12;
            this.vsiNbEssais.Text = "visualInt2";
            this.vsiNbEssais.View = VisualArrays.enuIntView.GraphNumber;
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuAide,
            this.mnuSpécial});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(640, 35);
            this.mnuPrincipal.TabIndex = 13;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierNouvellePartie,
            this.tspFichier,
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
            this.mnuFichierNouvellePartie.Text = "Nouvelle partie";
            this.mnuFichierNouvellePartie.Click += new System.EventHandler(this.mnuFichierNouvellePartie_Click);
            // 
            // tspFichier
            // 
            this.tspFichier.Name = "tspFichier";
            this.tspFichier.Size = new System.Drawing.Size(294, 6);
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
            this.mnuAideCommentJouer});
            this.mnuAide.Name = "mnuAide";
            this.mnuAide.Size = new System.Drawing.Size(64, 29);
            this.mnuAide.Text = "&Aide";
            // 
            // mnuAideCommentJouer
            // 
            this.mnuAideCommentJouer.Name = "mnuAideCommentJouer";
            this.mnuAideCommentJouer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.mnuAideCommentJouer.Size = new System.Drawing.Size(297, 34);
            this.mnuAideCommentJouer.Text = "Comment &Jouer";
            this.mnuAideCommentJouer.Click += new System.EventHandler(this.mnuAideCommentJouer_Click);
            // 
            // mnuSpécial
            // 
            this.mnuSpécial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSpécialModeTest});
            this.mnuSpécial.Name = "mnuSpécial";
            this.mnuSpécial.Size = new System.Drawing.Size(83, 29);
            this.mnuSpécial.Text = "&Spécial";
            // 
            // mnuSpécialModeTest
            // 
            this.mnuSpécialModeTest.CheckOnClick = true;
            this.mnuSpécialModeTest.Name = "mnuSpécialModeTest";
            this.mnuSpécialModeTest.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.mnuSpécialModeTest.Size = new System.Drawing.Size(497, 34);
            this.mnuSpécialModeTest.Text = "Mode Test : Afficher le nombre recherché";
            this.mnuSpécialModeTest.Click += new System.EventHandler(this.mnuSpécialModeTest_Click);
            // 
            // vsiNombreAVerifier
            // 
            this.vsiNombreAVerifier.BackColor = System.Drawing.Color.White;
            this.vsiNombreAVerifier.FocusColor = System.Drawing.Color.Gray;
            this.vsiNombreAVerifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNombreAVerifier.ForeColor = System.Drawing.Color.Black;
            this.vsiNombreAVerifier.GraphAppearance.BarAlign = VisualArrays.enuBarAlign.Middle;
            this.vsiNombreAVerifier.GraphAppearance.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.vsiNombreAVerifier.Location = new System.Drawing.Point(232, 77);
            this.vsiNombreAVerifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vsiNombreAVerifier.Minimum = 1;
            this.vsiNombreAVerifier.Name = "vsiNombreAVerifier";
            this.vsiNombreAVerifier.Size = new System.Drawing.Size(172, 40);
            this.vsiNombreAVerifier.TabIndex = 15;
            this.vsiNombreAVerifier.Text = "visualInt2";
            this.vsiNombreAVerifier.Value = 50;
            // 
            // vsbPlusPetit
            // 
            this.vsbPlusPetit.FocusColor = System.Drawing.Color.Gray;
            this.vsbPlusPetit.Location = new System.Drawing.Point(18, 78);
            this.vsbPlusPetit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vsbPlusPetit.Name = "vsbPlusPetit";
            this.vsbPlusPetit.Size = new System.Drawing.Size(178, 234);
            this.vsbPlusPetit.TabIndex = 19;
            this.vsbPlusPetit.Toggle = false;
            this.vsbPlusPetit.ValueAppearance.False.Image = global::ChercherUnNombreCache.Properties.Resources.LightOff;
            this.vsbPlusPetit.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbPlusPetit.ValueAppearance.True.Image = global::ChercherUnNombreCache.Properties.Resources.LightOn;
            this.vsbPlusPetit.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbPlusPetit.ValueChanged += new System.EventHandler(this.vsbPlusPetit_ValueChanged);
            // 
            // vsbPlusGrand
            // 
            this.vsbPlusGrand.FocusColor = System.Drawing.Color.Gray;
            this.vsbPlusGrand.Location = new System.Drawing.Point(444, 78);
            this.vsbPlusGrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vsbPlusGrand.Name = "vsbPlusGrand";
            this.vsbPlusGrand.Size = new System.Drawing.Size(178, 234);
            this.vsbPlusGrand.TabIndex = 20;
            this.vsbPlusGrand.Toggle = false;
            this.vsbPlusGrand.ValueAppearance.False.Image = global::ChercherUnNombreCache.Properties.Resources.LightOff;
            this.vsbPlusGrand.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbPlusGrand.ValueAppearance.True.Image = global::ChercherUnNombreCache.Properties.Resources.LightOn;
            this.vsbPlusGrand.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // lblNbEssais
            // 
            this.lblNbEssais.Location = new System.Drawing.Point(232, 243);
            this.lblNbEssais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbEssais.Name = "lblNbEssais";
            this.lblNbEssais.Size = new System.Drawing.Size(172, 20);
            this.lblNbEssais.TabIndex = 14;
            this.lblNbEssais.Text = "Nombre d\'essais";
            this.lblNbEssais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAccepter
            // 
            this.btnAccepter.Location = new System.Drawing.Point(232, 128);
            this.btnAccepter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccepter.Name = "btnAccepter";
            this.btnAccepter.Size = new System.Drawing.Size(172, 38);
            this.btnAccepter.TabIndex = 21;
            this.btnAccepter.Text = "Accepter";
            this.btnAccepter.UseVisualStyleBackColor = true;
            this.btnAccepter.Click += new System.EventHandler(this.btnAccepter_Click);
            // 
            // lblPlusPetitQueNombreCache
            // 
            this.lblPlusPetitQueNombreCache.Location = new System.Drawing.Point(-10, 52);
            this.lblPlusPetitQueNombreCache.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlusPetitQueNombreCache.Name = "lblPlusPetitQueNombreCache";
            this.lblPlusPetitQueNombreCache.Size = new System.Drawing.Size(238, 35);
            this.lblPlusPetitQueNombreCache.TabIndex = 22;
            this.lblPlusPetitQueNombreCache.Text = "Plus petit que nombre caché";
            this.lblPlusPetitQueNombreCache.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPlusGrandQueNombreCache
            // 
            this.lblPlusGrandQueNombreCache.Location = new System.Drawing.Point(418, 52);
            this.lblPlusGrandQueNombreCache.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlusGrandQueNombreCache.Name = "lblPlusGrandQueNombreCache";
            this.lblPlusGrandQueNombreCache.Size = new System.Drawing.Size(226, 35);
            this.lblPlusGrandQueNombreCache.TabIndex = 23;
            this.lblPlusGrandQueNombreCache.Text = "Plus grand que nombre caché";
            this.lblPlusGrandQueNombreCache.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombreAVerifier
            // 
            this.lblNombreAVerifier.Location = new System.Drawing.Point(232, 52);
            this.lblNombreAVerifier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreAVerifier.Name = "lblNombreAVerifier";
            this.lblNombreAVerifier.Size = new System.Drawing.Size(172, 35);
            this.lblNombreAVerifier.TabIndex = 24;
            this.lblNombreAVerifier.Text = "Nombre à vérifier";
            this.lblNombreAVerifier.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vsiNombreCaché
            // 
            this.vsiNombreCaché.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vsiNombreCaché.FocusColor = System.Drawing.Color.Gray;
            this.vsiNombreCaché.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNombreCaché.ForeColor = System.Drawing.Color.Black;
            this.vsiNombreCaché.GraphAppearance.BarColor = System.Drawing.Color.DodgerBlue;
            this.vsiNombreCaché.Location = new System.Drawing.Point(232, 194);
            this.vsiNombreCaché.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vsiNombreCaché.Minimum = 1;
            this.vsiNombreCaché.Name = "vsiNombreCaché";
            this.vsiNombreCaché.ReadOnly = true;
            this.vsiNombreCaché.Size = new System.Drawing.Size(172, 45);
            this.vsiNombreCaché.TabIndex = 25;
            this.vsiNombreCaché.Text = "visualInt2";
            this.vsiNombreCaché.Value = 50;
            this.vsiNombreCaché.Visible = false;
            // 
            // lblNombreCaché
            // 
            this.lblNombreCaché.Location = new System.Drawing.Point(234, 171);
            this.lblNombreCaché.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCaché.Name = "lblNombreCaché";
            this.lblNombreCaché.Size = new System.Drawing.Size(172, 20);
            this.lblNombreCaché.TabIndex = 26;
            this.lblNombreCaché.Text = "Nombre caché";
            this.lblNombreCaché.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombreCaché.Visible = false;
            // 
            // FrmEx6ChercherUnNombreCache
            // 
            this.AcceptButton = this.btnAccepter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 352);
            this.Controls.Add(this.lblNombreCaché);
            this.Controls.Add(this.vsiNombreCaché);
            this.Controls.Add(this.btnAccepter);
            this.Controls.Add(this.vsbPlusGrand);
            this.Controls.Add(this.vsbPlusPetit);
            this.Controls.Add(this.vsiNombreAVerifier);
            this.Controls.Add(this.lblNbEssais);
            this.Controls.Add(this.vsiNbEssais);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.lblPlusPetitQueNombreCache);
            this.Controls.Add(this.lblPlusGrandQueNombreCache);
            this.Controls.Add(this.lblNombreAVerifier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmEx6ChercherUnNombreCache";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ex6 : Chercher un nombre caché ";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierNouvellePartie;
        private System.Windows.Forms.ToolStripSeparator tspFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private VisualArrays.VisualCells.VisualInt vsiNbEssais;
        private VisualArrays.VisualCells.VisualInt vsiNombreAVerifier;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécial;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécialModeTest;
        private VisualArrays.VisualCells.VisualBool vsbPlusPetit;
        private VisualArrays.VisualCells.VisualBool vsbPlusGrand;
        private System.Windows.Forms.Label lblNbEssais;
        private System.Windows.Forms.Button btnAccepter;
        private System.Windows.Forms.Label lblPlusPetitQueNombreCache;
        private System.Windows.Forms.Label lblPlusGrandQueNombreCache;
        private System.Windows.Forms.Label lblNombreAVerifier;
        private VisualArrays.VisualCells.VisualInt vsiNombreCaché;
        private System.Windows.Forms.Label lblNombreCaché;
        private System.Windows.Forms.ToolStripMenuItem mnuAide;
        private System.Windows.Forms.ToolStripMenuItem mnuAideCommentJouer;
    }
}

