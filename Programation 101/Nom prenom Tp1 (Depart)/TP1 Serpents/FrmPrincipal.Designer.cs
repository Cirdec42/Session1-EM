namespace TP2_Serpents
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierNouvellePartie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierSeparateur = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécialModeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDéplacerJeton = new System.Windows.Forms.Button();
            this.btnLancerDe = new System.Windows.Forms.Button();
            this.imlDés = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vsiDé = new VisualArrays.VisualCells.VisualInt();
            this.sprFinPartie = new VisualArrays.TextSprite();
            this.bvaGrille = new VisualArrays.BaseGrid();
            this.sprJoueur = new VisualArrays.ImageSprite();
            this.mnuPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuSpécial});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(792, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierNouvellePartie,
            this.mnuFichierSeparateur,
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Tag = "A14PC";
            this.mnuFichier.Text = "Fichier";
            // 
            // mnuFichierNouvellePartie
            // 
            this.mnuFichierNouvellePartie.Name = "mnuFichierNouvellePartie";
            this.mnuFichierNouvellePartie.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFichierNouvellePartie.Size = new System.Drawing.Size(197, 22);
            this.mnuFichierNouvellePartie.Text = "Nouvelle Partie";
            this.mnuFichierNouvellePartie.Click += new System.EventHandler(this.mnuFichierNouvellePartie_Click);
            // 
            // mnuFichierSeparateur
            // 
            this.mnuFichierSeparateur.Name = "mnuFichierSeparateur";
            this.mnuFichierSeparateur.Size = new System.Drawing.Size(194, 6);
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(197, 22);
            this.mnuFichierQuitter.Text = "Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuSpécial
            // 
            this.mnuSpécial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSpécialModeTest});
            this.mnuSpécial.Name = "mnuSpécial";
            this.mnuSpécial.Size = new System.Drawing.Size(56, 20);
            this.mnuSpécial.Text = "Spécial";
            // 
            // mnuSpécialModeTest
            // 
            this.mnuSpécialModeTest.CheckOnClick = true;
            this.mnuSpécialModeTest.Name = "mnuSpécialModeTest";
            this.mnuSpécialModeTest.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.mnuSpécialModeTest.Size = new System.Drawing.Size(167, 22);
            this.mnuSpécialModeTest.Text = "Mode test";
            this.mnuSpécialModeTest.Click += new System.EventHandler(this.MnuSpécialModeTest_Click);
            // 
            // btnDéplacerJeton
            // 
            this.btnDéplacerJeton.Enabled = false;
            this.btnDéplacerJeton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDéplacerJeton.Location = new System.Drawing.Point(13, 66);
            this.btnDéplacerJeton.Name = "btnDéplacerJeton";
            this.btnDéplacerJeton.Size = new System.Drawing.Size(152, 33);
            this.btnDéplacerJeton.TabIndex = 15;
            this.btnDéplacerJeton.Text = "&Déplacer le jeton";
            this.btnDéplacerJeton.UseVisualStyleBackColor = true;
            this.btnDéplacerJeton.Click += new System.EventHandler(this.btnDéplacerJeton_Click);
            // 
            // btnLancerDe
            // 
            this.btnLancerDe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancerDe.Location = new System.Drawing.Point(15, 27);
            this.btnLancerDe.Name = "btnLancerDe";
            this.btnLancerDe.Size = new System.Drawing.Size(150, 33);
            this.btnLancerDe.TabIndex = 13;
            this.btnLancerDe.Text = "&Lancer le dé";
            this.btnLancerDe.UseVisualStyleBackColor = true;
            this.btnLancerDe.Click += new System.EventHandler(this.btnLancerDé_Click);
            // 
            // imlDés
            // 
            this.imlDés.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlDés.ImageStream")));
            this.imlDés.TransparentColor = System.Drawing.Color.Transparent;
            this.imlDés.Images.SetKeyName(0, "Vide.png");
            this.imlDés.Images.SetKeyName(1, "1.png");
            this.imlDés.Images.SetKeyName(2, "2.png");
            this.imlDés.Images.SetKeyName(3, "3.png");
            this.imlDés.Images.SetKeyName(4, "4.png");
            this.imlDés.Images.SetKeyName(5, "5.png");
            this.imlDés.Images.SetKeyName(6, "6.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLancerDe);
            this.groupBox1.Controls.Add(this.vsiDé);
            this.groupBox1.Controls.Add(this.btnDéplacerJeton);
            this.groupBox1.Location = new System.Drawing.Point(513, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 124);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // vsiDé
            // 
            this.vsiDé.BackColor = System.Drawing.Color.White;
            this.vsiDé.FocusColor = System.Drawing.Color.Gray;
            this.vsiDé.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiDé.ImageList = this.imlDés;
            this.vsiDé.Location = new System.Drawing.Point(173, 27);
            this.vsiDé.Minimum = 0;
            this.vsiDé.Name = "vsiDé";
            this.vsiDé.ReadOnly = true;
            this.vsiDé.Size = new System.Drawing.Size(71, 72);
            this.vsiDé.TabIndex = 29;
            this.vsiDé.Text = "visualInt1";
            this.vsiDé.View = VisualArrays.enuIntView.ImageList;
            // 
            // sprFinPartie
            // 
            this.sprFinPartie.AlignOnGrid = true;
            this.sprFinPartie.BackgroundShape = VisualArrays.enuShape.RoundRect;
            this.sprFinPartie.DisplayIndex = -1;
            this.sprFinPartie.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprFinPartie.Location = new System.Drawing.Point(0, 220);
            this.sprFinPartie.Name = "sprFinPartie";
            this.sprFinPartie.Radius = 25;
            this.sprFinPartie.ShapeColor = System.Drawing.Color.LightSteelBlue;
            this.sprFinPartie.Size = new System.Drawing.Size(480, 40);
            this.sprFinPartie.Text = "Fin de la partie";
            this.sprFinPartie.TextColor = System.Drawing.Color.Olive;
            this.sprFinPartie.Visible = false;
            // 
            // bvaGrille
            // 
            this.bvaGrille.AddressMode = VisualArrays.enuAddressMode.StairsBottomLeft;
            this.bvaGrille.AddressView = VisualArrays.enuAddressView.Mode1D;
            this.bvaGrille.BackgroundImage = global::SerpentsEchelles.Properties.Resources.Serpents;
            this.bvaGrille.CellSize = new System.Drawing.Size(56, 56);
            this.bvaGrille.ColumnCount = 8;
            this.bvaGrille.EnabledAppearance.Style = VisualArrays.enuBkgStyle.None;
            this.bvaGrille.GridAppearance.LineSize = 0;
            this.bvaGrille.Location = new System.Drawing.Point(12, 45);
            this.bvaGrille.Name = "bvaGrille";
            this.bvaGrille.Padding = new System.Windows.Forms.Padding(0);
            this.bvaGrille.RowCount = 8;
            this.bvaGrille.RowHeader.ForeColor = System.Drawing.Color.White;
            this.bvaGrille.Size = new System.Drawing.Size(480, 480);
            this.bvaGrille.Sprites.AddRange(new VisualArrays.Sprite[] {
            this.sprJoueur,
            this.sprFinPartie});
            this.bvaGrille.TabIndex = 24;
            this.bvaGrille.TabStop = false;
            this.bvaGrille.Click += new System.EventHandler(this.bvaGrille_Click);
            // 
            // sprJoueur
            // 
            this.sprJoueur.Animated = true;
            this.sprJoueur.Duration = 250;
            this.sprJoueur.FollowGrid = true;
            this.sprJoueur.Image = global::SerpentsEchelles.Properties.Resources.cool_icon;
            this.sprJoueur.Name = "sprJoueur";
            this.sprJoueur.Size = new System.Drawing.Size(48, 48);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bvaGrille);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP1 - Serpents et échelles -";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierNouvellePartie;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.Button btnDéplacerJeton;
        private System.Windows.Forms.Button btnLancerDe;
        private VisualArrays.BaseGrid bvaGrille;
        private System.Windows.Forms.ToolStripSeparator mnuFichierSeparateur;
        private VisualArrays.ImageSprite sprJoueur;
        private VisualArrays.TextSprite sprFinPartie;
        private VisualArrays.VisualCells.VisualInt vsiDé;
        private System.Windows.Forms.ImageList imlDés;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécial;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécialModeTest;
    }
}

