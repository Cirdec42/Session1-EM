namespace AppDessinGrille
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
            this.viaGrilleDessin = new VisualArrays.VisualIntArray();
            this.imlSymboles = new System.Windows.Forms.ImageList(this.components);
            this.sprOver = new VisualArrays.ShapeSprite();
            this.sprBravo = new VisualArrays.TextSprite();
            this.sprGameOver = new VisualArrays.TextSprite();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSéparateur1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierCharger = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSéparateur2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat6 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat7 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat8 = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrMinuterie = new System.Windows.Forms.Timer(this.components);
            this.viaGrillePalette = new VisualArrays.VisualIntArray();
            this.grpPalette = new System.Windows.Forms.GroupBox();
            this.mnuPrincipal.SuspendLayout();
            this.grpPalette.SuspendLayout();
            this.SuspendLayout();
            // 
            // viaGrilleDessin
            // 
            this.viaGrilleDessin.BackColor = System.Drawing.Color.White;
            this.viaGrilleDessin.CellMargin = 0;
            this.viaGrilleDessin.CellSize = new System.Drawing.Size(30, 30);
            this.viaGrilleDessin.ColumnCount = 15;
            this.viaGrilleDessin.DefaultValue = -1;
            this.viaGrilleDessin.DisabledAppearance.ImageBrightness = 0.3F;
            this.viaGrilleDessin.DisabledAppearance.StrikeAppearance.Image = global::AppDessinGrille.Properties.Resources.Check;
            this.viaGrilleDessin.DisabledAppearance.StrikeAppearance.Style = VisualArrays.enuStrikeStyle.Image;
            this.viaGrilleDessin.EnabledAppearance.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaGrilleDessin.EnabledAppearance.ImageList = this.imlSymboles;
            this.viaGrilleDessin.EnabledAppearance.Style = VisualArrays.enuBkgStyle.None;
            this.viaGrilleDessin.EnabledAppearance.TextColor = System.Drawing.Color.DimGray;
            this.viaGrilleDessin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaGrilleDessin.GridAppearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viaGrilleDessin.Location = new System.Drawing.Point(17, 39);
            this.viaGrilleDessin.Name = "viaGrilleDessin";
            this.viaGrilleDessin.Padding = new System.Windows.Forms.Padding(1);
            this.viaGrilleDessin.RowCount = 12;
            this.viaGrilleDessin.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaGrilleDessin.Size = new System.Drawing.Size(468, 375);
            this.viaGrilleDessin.Sprites.AddRange(new VisualArrays.Sprite[] {
            this.sprOver,
            this.sprBravo,
            this.sprGameOver});
            this.viaGrilleDessin.TabIndex = 0;
            this.viaGrilleDessin.View = VisualArrays.enuIntView.ImageList;
            this.viaGrilleDessin.CellMouseDown += new System.EventHandler<VisualArrays.CellMouseEventArgs>(this.ViaNombres_CellMouseDown);
            // 
            // imlSymboles
            // 
            this.imlSymboles.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlSymboles.ImageStream")));
            this.imlSymboles.TransparentColor = System.Drawing.Color.Transparent;
            this.imlSymboles.Images.SetKeyName(0, "F5.png");
            this.imlSymboles.Images.SetKeyName(1, "F1.png");
            this.imlSymboles.Images.SetKeyName(2, "F2.png");
            this.imlSymboles.Images.SetKeyName(3, "F3.png");
            this.imlSymboles.Images.SetKeyName(4, "F4.png");
            this.imlSymboles.Images.SetKeyName(5, "F6.png");
            this.imlSymboles.Images.SetKeyName(6, "F7.png");
            this.imlSymboles.Images.SetKeyName(7, "F8.png");
            this.imlSymboles.Images.SetKeyName(8, "F9.png");
            // 
            // sprOver
            // 
            this.sprOver.Color = System.Drawing.Color.SkyBlue;
            this.sprOver.Name = "sprOver";
            this.sprOver.PenWidth = 4;
            this.sprOver.Shape = VisualArrays.enuShape.RoundRect;
            this.sprOver.Size = new System.Drawing.Size(54, 52);
            this.sprOver.Visible = false;
            // 
            // sprBravo
            // 
            this.sprBravo.AlignOnGrid = true;
            this.sprBravo.BackgroundShape = VisualArrays.enuShape.RoundRect;
            this.sprBravo.DisplayIndex = -1;
            this.sprBravo.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprBravo.Margin = new System.Windows.Forms.Padding(0);
            this.sprBravo.Name = "sprBravo";
            this.sprBravo.Radius = 25;
            this.sprBravo.ShapeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sprBravo.Text = "BRAVO !";
            this.sprBravo.TextColor = System.Drawing.Color.LimeGreen;
            this.sprBravo.Visible = false;
            // 
            // sprGameOver
            // 
            this.sprGameOver.AlignOnGrid = true;
            this.sprGameOver.BackgroundShape = VisualArrays.enuShape.RoundRect;
            this.sprGameOver.DisplayIndex = -1;
            this.sprGameOver.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprGameOver.Margin = new System.Windows.Forms.Padding(0);
            this.sprGameOver.Name = "sprGameOver";
            this.sprGameOver.Radius = 25;
            this.sprGameOver.ShapeColor = System.Drawing.Color.DarkRed;
            this.sprGameOver.Text = "GAME OVER !";
            this.sprGameOver.Visible = false;
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuFormat});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(706, 24);
            this.mnuPrincipal.TabIndex = 2;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierNouveau,
            this.mnuSéparateur1,
            this.mnuFichierCharger,
            this.mnuFichierEnregistrer,
            this.mnuSéparateur2,
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierNouveau
            // 
            this.mnuFichierNouveau.Name = "mnuFichierNouveau";
            this.mnuFichierNouveau.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFichierNouveau.Size = new System.Drawing.Size(170, 22);
            this.mnuFichierNouveau.Text = "&Nouveau";
            this.mnuFichierNouveau.Click += new System.EventHandler(this.MnuFichierNouveauDessin_Click);
            // 
            // mnuSéparateur1
            // 
            this.mnuSéparateur1.Name = "mnuSéparateur1";
            this.mnuSéparateur1.Size = new System.Drawing.Size(167, 6);
            // 
            // mnuFichierCharger
            // 
            this.mnuFichierCharger.Name = "mnuFichierCharger";
            this.mnuFichierCharger.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFichierCharger.Size = new System.Drawing.Size(170, 22);
            this.mnuFichierCharger.Text = "&Charger";
            this.mnuFichierCharger.Click += new System.EventHandler(this.mnuFichierCharger_Click);
            // 
            // mnuFichierEnregistrer
            // 
            this.mnuFichierEnregistrer.Name = "mnuFichierEnregistrer";
            this.mnuFichierEnregistrer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFichierEnregistrer.Size = new System.Drawing.Size(170, 22);
            this.mnuFichierEnregistrer.Text = "&Enregistrer";
            this.mnuFichierEnregistrer.Click += new System.EventHandler(this.mnuFichierEnregistrer_Click);
            // 
            // mnuSéparateur2
            // 
            this.mnuSéparateur2.Name = "mnuSéparateur2";
            this.mnuSéparateur2.Size = new System.Drawing.Size(167, 6);
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(170, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.MnuFichierQuitter_Click);
            // 
            // mnuFormat
            // 
            this.mnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFormat1,
            this.mnuFormat2,
            this.mnuFormat3,
            this.mnuFormat4,
            this.mnuFormat5,
            this.mnuFormat6,
            this.mnuFormat7,
            this.mnuFormat8});
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.mnuFormat.Size = new System.Drawing.Size(57, 20);
            this.mnuFormat.Text = "&Format";
            // 
            // mnuFormat1
            // 
            this.mnuFormat1.Checked = true;
            this.mnuFormat1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuFormat1.Name = "mnuFormat1";
            this.mnuFormat1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.mnuFormat1.Size = new System.Drawing.Size(172, 22);
            this.mnuFormat1.Text = "Premier";
            this.mnuFormat1.Click += new System.EventHandler(this.MnuFormat_Click);
            // 
            // mnuFormat2
            // 
            this.mnuFormat2.Name = "mnuFormat2";
            this.mnuFormat2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.mnuFormat2.Size = new System.Drawing.Size(172, 22);
            this.mnuFormat2.Text = "Deuxième";
            this.mnuFormat2.Click += new System.EventHandler(this.MnuFormat_Click);
            // 
            // mnuFormat3
            // 
            this.mnuFormat3.Name = "mnuFormat3";
            this.mnuFormat3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.mnuFormat3.Size = new System.Drawing.Size(172, 22);
            this.mnuFormat3.Text = "Troisième";
            this.mnuFormat3.Click += new System.EventHandler(this.MnuFormat_Click);
            // 
            // mnuFormat4
            // 
            this.mnuFormat4.Name = "mnuFormat4";
            this.mnuFormat4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.mnuFormat4.Size = new System.Drawing.Size(172, 22);
            this.mnuFormat4.Text = "Quatrième";
            this.mnuFormat4.Click += new System.EventHandler(this.MnuFormat_Click);
            // 
            // mnuFormat5
            // 
            this.mnuFormat5.Name = "mnuFormat5";
            this.mnuFormat5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.mnuFormat5.Size = new System.Drawing.Size(172, 22);
            this.mnuFormat5.Text = "Cinquième";
            this.mnuFormat5.Click += new System.EventHandler(this.MnuFormat_Click);
            // 
            // mnuFormat6
            // 
            this.mnuFormat6.Name = "mnuFormat6";
            this.mnuFormat6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.mnuFormat6.Size = new System.Drawing.Size(172, 22);
            this.mnuFormat6.Text = "Sixième";
            this.mnuFormat6.Click += new System.EventHandler(this.MnuFormat_Click);
            // 
            // mnuFormat7
            // 
            this.mnuFormat7.Name = "mnuFormat7";
            this.mnuFormat7.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.mnuFormat7.Size = new System.Drawing.Size(172, 22);
            this.mnuFormat7.Text = "Septième";
            this.mnuFormat7.Click += new System.EventHandler(this.MnuFormat_Click);
            // 
            // mnuFormat8
            // 
            this.mnuFormat8.Name = "mnuFormat8";
            this.mnuFormat8.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.mnuFormat8.Size = new System.Drawing.Size(172, 22);
            this.mnuFormat8.Text = "Huitième";
            this.mnuFormat8.Click += new System.EventHandler(this.MnuFormat_Click);
            // 
            // tmrMinuterie
            // 
            this.tmrMinuterie.Interval = 1000;
            // 
            // viaGrillePalette
            // 
            this.viaGrillePalette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.viaGrillePalette.CellMargin = 5;
            this.viaGrillePalette.CellSize = new System.Drawing.Size(30, 30);
            this.viaGrillePalette.DefaultValue = -1;
            this.viaGrillePalette.DisabledAppearance.ImageBrightness = 0.3F;
            this.viaGrillePalette.DisabledAppearance.StrikeAppearance.Image = global::AppDessinGrille.Properties.Resources.Check;
            this.viaGrillePalette.DisabledAppearance.StrikeAppearance.Style = VisualArrays.enuStrikeStyle.Image;
            this.viaGrillePalette.EnabledAppearance.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaGrillePalette.EnabledAppearance.ImageList = this.imlSymboles;
            this.viaGrillePalette.EnabledAppearance.Style = VisualArrays.enuBkgStyle.None;
            this.viaGrillePalette.EnabledAppearance.TextColor = System.Drawing.Color.DimGray;
            this.viaGrillePalette.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaGrillePalette.GridAppearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viaGrillePalette.Location = new System.Drawing.Point(16, 19);
            this.viaGrillePalette.Name = "viaGrillePalette";
            this.viaGrillePalette.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaGrillePalette.SelectionMode = System.Windows.Forms.SelectionMode.One;
            this.viaGrillePalette.Size = new System.Drawing.Size(136, 136);
            this.viaGrillePalette.Sprites.AddRange(new VisualArrays.Sprite[] {
            this.sprOver,
            this.sprBravo,
            this.sprGameOver});
            this.viaGrillePalette.TabIndex = 0;
            this.viaGrillePalette.View = VisualArrays.enuIntView.ImageList;
            // 
            // grpPalette
            // 
            this.grpPalette.Controls.Add(this.viaGrillePalette);
            this.grpPalette.Location = new System.Drawing.Point(514, 39);
            this.grpPalette.Name = "grpPalette";
            this.grpPalette.Size = new System.Drawing.Size(167, 168);
            this.grpPalette.TabIndex = 1;
            this.grpPalette.TabStop = false;
            this.grpPalette.Text = "Palette";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(706, 435);
            this.Controls.Add(this.grpPalette);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.viaGrilleDessin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enregistrement d\'un dessin dans différents formats ";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.grpPalette.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisualArrays.VisualIntArray viaGrilleDessin;
        private System.Windows.Forms.ImageList imlSymboles;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierNouveau;
        private System.Windows.Forms.ToolStripSeparator mnuSéparateur1;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private VisualArrays.ShapeSprite sprOver;
        private System.Windows.Forms.Timer tmrMinuterie;
        private VisualArrays.TextSprite sprBravo;
        private VisualArrays.TextSprite sprGameOver;
        private VisualArrays.VisualIntArray viaGrillePalette;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierCharger;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierEnregistrer;
        private System.Windows.Forms.ToolStripSeparator mnuSéparateur2;
        private System.Windows.Forms.GroupBox grpPalette;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat1;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat2;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat3;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat4;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat5;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat6;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat7;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat8;
    }
}

