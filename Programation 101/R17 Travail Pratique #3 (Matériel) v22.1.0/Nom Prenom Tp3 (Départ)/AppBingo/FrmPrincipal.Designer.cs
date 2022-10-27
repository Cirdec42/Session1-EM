namespace AppBingo
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierNouvellePartie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierSep = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécialTest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécialBoulier = new System.Windows.Forms.ToolStripMenuItem();
            this.panMaîtresse = new System.Windows.Forms.Panel();
            this.viaBoulier = new VisualArrays.VisualIntArray();
            this.panBoulier = new System.Windows.Forms.Panel();
            this.vsiNbBoulesRetirées = new VisualArrays.VisualCells.VisualInt();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vsiBoule = new VisualArrays.VisualCells.VisualInt();
            this.vscBoule = new VisualArrays.VisualCells.VisualChar();
            this.lblNbBoules = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRetirer = new System.Windows.Forms.Button();
            this.viaCarteMaîtresse = new VisualArrays.VisualIntArray();
            this.lblCarteAffichée = new System.Windows.Forms.Label();
            this.viaCarte1 = new VisualArrays.VisualIntArray();
            this.sprSegmentCarte1 = new VisualArrays.SegmentSprite();
            this.viaCarte2 = new VisualArrays.VisualIntArray();
            this.sprSegmentCarte2 = new VisualArrays.SegmentSprite();
            this.viaCarte3 = new VisualArrays.VisualIntArray();
            this.sprSegmentCarte3 = new VisualArrays.SegmentSprite();
            this.viaCarte4 = new VisualArrays.VisualIntArray();
            this.sprSegmentCarte4 = new VisualArrays.SegmentSprite();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mnuPrincipal.SuspendLayout();
            this.panMaîtresse.SuspendLayout();
            this.panBoulier.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuSpécial});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(1069, 24);
            this.mnuPrincipal.TabIndex = 2;
            this.mnuPrincipal.Text = "&Spécial";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierNouvellePartie,
            this.mnuFichierSep,
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
            this.mnuFichierNouvellePartie.Text = "&Nouvelle Partie";
            this.mnuFichierNouvellePartie.Click += new System.EventHandler(this.mnuFichierNouvellePartie_Click);
            // 
            // mnuFichierSep
            // 
            this.mnuFichierSep.Name = "mnuFichierSep";
            this.mnuFichierSep.Size = new System.Drawing.Size(194, 6);
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(197, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuSpécial
            // 
            this.mnuSpécial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSpécialTest,
            this.mnuSpécialBoulier});
            this.mnuSpécial.Name = "mnuSpécial";
            this.mnuSpécial.Size = new System.Drawing.Size(56, 20);
            this.mnuSpécial.Text = "&Spécial";
            // 
            // mnuSpécialTest
            // 
            this.mnuSpécialTest.Name = "mnuSpécialTest";
            this.mnuSpécialTest.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuSpécialTest.Size = new System.Drawing.Size(224, 22);
            this.mnuSpécialTest.Text = "Retirer jusqu\'à bingo";
            this.mnuSpécialTest.Click += new System.EventHandler(this.mnuSpécialTest_Click);
            // 
            // mnuSpécialBoulier
            // 
            this.mnuSpécialBoulier.Name = "mnuSpécialBoulier";
            this.mnuSpécialBoulier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnuSpécialBoulier.Size = new System.Drawing.Size(224, 22);
            this.mnuSpécialBoulier.Text = "Voir le boulier";
            this.mnuSpécialBoulier.Click += new System.EventHandler(this.MnuSpécialBoulier_Click);
            // 
            // panMaîtresse
            // 
            this.panMaîtresse.BackColor = System.Drawing.Color.DarkKhaki;
            this.panMaîtresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMaîtresse.Controls.Add(this.viaBoulier);
            this.panMaîtresse.Controls.Add(this.panBoulier);
            this.panMaîtresse.Controls.Add(this.viaCarteMaîtresse);
            this.panMaîtresse.Controls.Add(this.lblCarteAffichée);
            this.panMaîtresse.Location = new System.Drawing.Point(12, 39);
            this.panMaîtresse.Name = "panMaîtresse";
            this.panMaîtresse.Size = new System.Drawing.Size(322, 699);
            this.panMaîtresse.TabIndex = 10;
            // 
            // viaBoulier
            // 
            this.viaBoulier.AddressView = VisualArrays.enuAddressView.Mode2D;
            this.viaBoulier.BackColor = System.Drawing.Color.Beige;
            this.viaBoulier.CellSize = new System.Drawing.Size(52, 22);
            this.viaBoulier.ColumnCount = 5;
            this.viaBoulier.ColumnHeader.BackgroundColor = System.Drawing.Color.Gray;
            this.viaBoulier.ColumnHeader.Font = new System.Drawing.Font("Goudy Stout", 27.75F);
            this.viaBoulier.ColumnHeader.ForeColor = System.Drawing.Color.DarkKhaki;
            this.viaBoulier.ColumnHeader.Height = 48;
            this.viaBoulier.ColumnHeader.Style = VisualArrays.enuHeaderBkgStyle.None;
            this.viaBoulier.ColumnHeader.ValueStyle = VisualArrays.enuDataStyle.User;
            this.viaBoulier.ColumnHeader.Visible = true;
            this.viaBoulier.DisabledAppearance.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.viaBoulier.DisabledAppearance.Font = new System.Drawing.Font("Goudy Stout", 12F);
            this.viaBoulier.DisabledAppearance.StrikeAppearance.Color = System.Drawing.Color.Tomato;
            this.viaBoulier.DisabledAppearance.StrikeAppearance.PenWidth = 2;
            this.viaBoulier.DisabledAppearance.StrikeAppearance.Style = VisualArrays.enuStrikeStyle.Diagonal;
            this.viaBoulier.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.viaBoulier.DisabledAppearance.TextColor = System.Drawing.Color.Gray;
            this.viaBoulier.EnabledAppearance.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.viaBoulier.EnabledAppearance.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaBoulier.EnabledAppearance.TextColor = System.Drawing.Color.Black;
            this.viaBoulier.Location = new System.Drawing.Point(12, 218);
            this.viaBoulier.Name = "viaBoulier";
            this.viaBoulier.RowCount = 15;
            this.viaBoulier.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaBoulier.Size = new System.Drawing.Size(298, 466);
            this.viaBoulier.SpecialValue = 0;
            this.viaBoulier.SpecialValueAppearance.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.viaBoulier.TabIndex = 17;
            this.viaBoulier.Visible = false;
            // 
            // panBoulier
            // 
            this.panBoulier.BackColor = System.Drawing.Color.DarkKhaki;
            this.panBoulier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBoulier.Controls.Add(this.vsiNbBoulesRetirées);
            this.panBoulier.Controls.Add(this.panel2);
            this.panBoulier.Controls.Add(this.lblNbBoules);
            this.panBoulier.Controls.Add(this.pictureBox1);
            this.panBoulier.Controls.Add(this.btnRetirer);
            this.panBoulier.Location = new System.Drawing.Point(11, 14);
            this.panBoulier.Name = "panBoulier";
            this.panBoulier.Size = new System.Drawing.Size(299, 144);
            this.panBoulier.TabIndex = 16;
            // 
            // vsiNbBoulesRetirées
            // 
            this.vsiNbBoulesRetirées.BackColor = System.Drawing.Color.Beige;
            this.vsiNbBoulesRetirées.FocusColor = System.Drawing.Color.Gray;
            this.vsiNbBoulesRetirées.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNbBoulesRetirées.Location = new System.Drawing.Point(140, 57);
            this.vsiNbBoulesRetirées.Name = "vsiNbBoulesRetirées";
            this.vsiNbBoulesRetirées.ReadOnly = true;
            this.vsiNbBoulesRetirées.Size = new System.Drawing.Size(69, 34);
            this.vsiNbBoulesRetirées.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.vsiBoule);
            this.panel2.Controls.Add(this.vscBoule);
            this.panel2.Location = new System.Drawing.Point(215, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(78, 130);
            this.panel2.TabIndex = 11;
            // 
            // vsiBoule
            // 
            this.vsiBoule.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.vsiBoule.FocusColor = System.Drawing.Color.Gray;
            this.vsiBoule.Font = new System.Drawing.Font("Goudy Stout", 20.25F);
            this.vsiBoule.Location = new System.Drawing.Point(6, 70);
            this.vsiBoule.Name = "vsiBoule";
            this.vsiBoule.ReadOnly = true;
            this.vsiBoule.Size = new System.Drawing.Size(63, 53);
            this.vsiBoule.TabIndex = 10;
            // 
            // vscBoule
            // 
            this.vscBoule.BackColor = System.Drawing.Color.Beige;
            this.vscBoule.BorderSize = 0;
            this.vscBoule.FocusColor = System.Drawing.Color.Gray;
            this.vscBoule.Font = new System.Drawing.Font("Goudy Stout", 27.75F);
            this.vscBoule.ForeColor = System.Drawing.Color.DarkKhaki;
            this.vscBoule.Location = new System.Drawing.Point(7, 8);
            this.vscBoule.Minimum = ' ';
            this.vscBoule.Name = "vscBoule";
            this.vscBoule.ReadOnly = true;
            this.vscBoule.Size = new System.Drawing.Size(63, 59);
            this.vscBoule.TabIndex = 9;
            this.vscBoule.Value = ' ';
            // 
            // lblNbBoules
            // 
            this.lblNbBoules.Location = new System.Drawing.Point(140, 13);
            this.lblNbBoules.Name = "lblNbBoules";
            this.lblNbBoules.Size = new System.Drawing.Size(73, 41);
            this.lblNbBoules.TabIndex = 5;
            this.lblNbBoules.Text = "Nombre de boules retirées :";
            this.lblNbBoules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppBingo.Properties.Resources.bingo_caller_online;
            this.pictureBox1.Location = new System.Drawing.Point(6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnRetirer
            // 
            this.btnRetirer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirer.Location = new System.Drawing.Point(140, 107);
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.Size = new System.Drawing.Size(70, 29);
            this.btnRetirer.TabIndex = 4;
            this.btnRetirer.Text = "Retirer";
            this.btnRetirer.UseVisualStyleBackColor = true;
            this.btnRetirer.Click += new System.EventHandler(this.btnRetirerUneBouleDuBoulier_Click);
            // 
            // viaCarteMaîtresse
            // 
            this.viaCarteMaîtresse.AddressView = VisualArrays.enuAddressView.Mode2D;
            this.viaCarteMaîtresse.BackColor = System.Drawing.Color.Beige;
            this.viaCarteMaîtresse.CellSize = new System.Drawing.Size(52, 22);
            this.viaCarteMaîtresse.ColumnCount = 5;
            this.viaCarteMaîtresse.ColumnHeader.BackgroundColor = System.Drawing.Color.Gray;
            this.viaCarteMaîtresse.ColumnHeader.Font = new System.Drawing.Font("Goudy Stout", 27.75F);
            this.viaCarteMaîtresse.ColumnHeader.ForeColor = System.Drawing.Color.DarkKhaki;
            this.viaCarteMaîtresse.ColumnHeader.Height = 48;
            this.viaCarteMaîtresse.ColumnHeader.Style = VisualArrays.enuHeaderBkgStyle.None;
            this.viaCarteMaîtresse.ColumnHeader.ValueStyle = VisualArrays.enuDataStyle.User;
            this.viaCarteMaîtresse.ColumnHeader.Visible = true;
            this.viaCarteMaîtresse.DisabledAppearance.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.viaCarteMaîtresse.DisabledAppearance.Font = new System.Drawing.Font("Goudy Stout", 12F);
            this.viaCarteMaîtresse.DisabledAppearance.StrikeAppearance.Color = System.Drawing.Color.Tomato;
            this.viaCarteMaîtresse.DisabledAppearance.StrikeAppearance.PenWidth = 2;
            this.viaCarteMaîtresse.DisabledAppearance.StrikeAppearance.Style = VisualArrays.enuStrikeStyle.Diagonal;
            this.viaCarteMaîtresse.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.viaCarteMaîtresse.DisabledAppearance.TextColor = System.Drawing.Color.Gray;
            this.viaCarteMaîtresse.EnabledAppearance.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.viaCarteMaîtresse.EnabledAppearance.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaCarteMaîtresse.EnabledAppearance.TextColor = System.Drawing.Color.Black;
            this.viaCarteMaîtresse.Location = new System.Drawing.Point(12, 218);
            this.viaCarteMaîtresse.Name = "viaCarteMaîtresse";
            this.viaCarteMaîtresse.RowCount = 15;
            this.viaCarteMaîtresse.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaCarteMaîtresse.Size = new System.Drawing.Size(298, 466);
            this.viaCarteMaîtresse.SpecialValue = 0;
            this.viaCarteMaîtresse.SpecialValueAppearance.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.viaCarteMaîtresse.TabIndex = 8;
            // 
            // lblCarteAffichée
            // 
            this.lblCarteAffichée.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarteAffichée.Location = new System.Drawing.Point(12, 181);
            this.lblCarteAffichée.Name = "lblCarteAffichée";
            this.lblCarteAffichée.Size = new System.Drawing.Size(293, 34);
            this.lblCarteAffichée.TabIndex = 14;
            this.lblCarteAffichée.Text = "Carte maîtresse";
            this.lblCarteAffichée.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viaCarte1
            // 
            this.viaCarte1.AddressView = VisualArrays.enuAddressView.Mode2D;
            this.viaCarte1.BackColor = System.Drawing.Color.Beige;
            this.viaCarte1.CellSize = new System.Drawing.Size(58, 48);
            this.viaCarte1.ColumnCount = 5;
            this.viaCarte1.ColumnHeader.BackgroundColor = System.Drawing.Color.Gray;
            this.viaCarte1.ColumnHeader.Font = new System.Drawing.Font("Goudy Stout", 27.75F);
            this.viaCarte1.ColumnHeader.ForeColor = System.Drawing.Color.DarkKhaki;
            this.viaCarte1.ColumnHeader.Height = 48;
            this.viaCarte1.ColumnHeader.Style = VisualArrays.enuHeaderBkgStyle.None;
            this.viaCarte1.ColumnHeader.ValueStyle = VisualArrays.enuDataStyle.User;
            this.viaCarte1.ColumnHeader.Visible = true;
            this.viaCarte1.DefaultValue = -1;
            this.viaCarte1.DisabledAppearance.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.viaCarte1.DisabledAppearance.Font = new System.Drawing.Font("Goudy Stout", 20.25F);
            this.viaCarte1.DisabledAppearance.StrikeAppearance.Image = global::AppBingo.Properties.Resources.Rond50X50;
            this.viaCarte1.DisabledAppearance.StrikeAppearance.Style = VisualArrays.enuStrikeStyle.Image;
            this.viaCarte1.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.viaCarte1.EnabledAppearance.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.viaCarte1.EnabledAppearance.Font = new System.Drawing.Font("Goudy Stout", 20.25F);
            this.viaCarte1.EnabledAppearance.TextColor = System.Drawing.Color.Black;
            this.viaCarte1.Location = new System.Drawing.Point(376, 39);
            this.viaCarte1.Name = "viaCarte1";
            this.viaCarte1.RowCount = 5;
            this.viaCarte1.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaCarte1.Size = new System.Drawing.Size(328, 326);
            this.viaCarte1.SpecialValue = 0;
            this.viaCarte1.SpecialValueAppearance.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.viaCarte1.SpecialValueAppearance.Image = global::AppBingo.Properties.Resources.Centre1;
            this.viaCarte1.SpecialValueAppearance.Style = VisualArrays.enuBkgStyle.Image;
            this.viaCarte1.Sprites.AddRange(new VisualArrays.Sprite[] {
            this.sprSegmentCarte1});
            this.viaCarte1.TabIndex = 15;
            this.viaCarte1.Click += new System.EventHandler(this.viaCarte1_Click);
            // 
            // sprSegmentCarte1
            // 
            this.sprSegmentCarte1.Color = System.Drawing.Color.Lime;
            this.sprSegmentCarte1.Name = "sprSegmentCarte1";
            this.sprSegmentCarte1.Visible = false;
            // 
            // viaCarte2
            // 
            this.viaCarte2.AddressView = VisualArrays.enuAddressView.Mode2D;
            this.viaCarte2.BackColor = System.Drawing.Color.Beige;
            this.viaCarte2.CellSize = new System.Drawing.Size(58, 48);
            this.viaCarte2.ColumnCount = 5;
            this.viaCarte2.ColumnHeader.BackgroundColor = System.Drawing.Color.Gray;
            this.viaCarte2.ColumnHeader.Font = new System.Drawing.Font("Goudy Stout", 27.75F);
            this.viaCarte2.ColumnHeader.ForeColor = System.Drawing.Color.DarkKhaki;
            this.viaCarte2.ColumnHeader.Height = 48;
            this.viaCarte2.ColumnHeader.Style = VisualArrays.enuHeaderBkgStyle.None;
            this.viaCarte2.ColumnHeader.ValueStyle = VisualArrays.enuDataStyle.User;
            this.viaCarte2.ColumnHeader.Visible = true;
            this.viaCarte2.DefaultValue = -1;
            this.viaCarte2.DisabledAppearance.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.viaCarte2.DisabledAppearance.Font = new System.Drawing.Font("Goudy Stout", 20.25F);
            this.viaCarte2.DisabledAppearance.StrikeAppearance.Image = global::AppBingo.Properties.Resources.Rond50X50;
            this.viaCarte2.DisabledAppearance.StrikeAppearance.Style = VisualArrays.enuStrikeStyle.Image;
            this.viaCarte2.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.viaCarte2.EnabledAppearance.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.viaCarte2.EnabledAppearance.Font = new System.Drawing.Font("Goudy Stout", 20.25F);
            this.viaCarte2.EnabledAppearance.TextColor = System.Drawing.Color.Black;
            this.viaCarte2.Location = new System.Drawing.Point(723, 39);
            this.viaCarte2.Name = "viaCarte2";
            this.viaCarte2.RowCount = 5;
            this.viaCarte2.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaCarte2.Size = new System.Drawing.Size(328, 326);
            this.viaCarte2.SpecialValue = 0;
            this.viaCarte2.SpecialValueAppearance.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.viaCarte2.SpecialValueAppearance.Image = global::AppBingo.Properties.Resources.Centre1;
            this.viaCarte2.SpecialValueAppearance.Style = VisualArrays.enuBkgStyle.Image;
            this.viaCarte2.Sprites.AddRange(new VisualArrays.Sprite[] {
            this.sprSegmentCarte2});
            this.viaCarte2.TabIndex = 11;
            // 
            // sprSegmentCarte2
            // 
            this.sprSegmentCarte2.Color = System.Drawing.Color.Lime;
            this.sprSegmentCarte2.Name = "sprSegmentCarte2";
            this.sprSegmentCarte2.Visible = false;
            // 
            // viaCarte3
            // 
            this.viaCarte3.AddressView = VisualArrays.enuAddressView.Mode2D;
            this.viaCarte3.BackColor = System.Drawing.Color.Beige;
            this.viaCarte3.CellSize = new System.Drawing.Size(58, 48);
            this.viaCarte3.ColumnCount = 5;
            this.viaCarte3.ColumnHeader.BackgroundColor = System.Drawing.Color.Gray;
            this.viaCarte3.ColumnHeader.Font = new System.Drawing.Font("Goudy Stout", 27.75F);
            this.viaCarte3.ColumnHeader.ForeColor = System.Drawing.Color.DarkKhaki;
            this.viaCarte3.ColumnHeader.Height = 48;
            this.viaCarte3.ColumnHeader.Style = VisualArrays.enuHeaderBkgStyle.None;
            this.viaCarte3.ColumnHeader.ValueStyle = VisualArrays.enuDataStyle.User;
            this.viaCarte3.ColumnHeader.Visible = true;
            this.viaCarte3.DefaultValue = -1;
            this.viaCarte3.DisabledAppearance.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.viaCarte3.DisabledAppearance.Font = new System.Drawing.Font("Goudy Stout", 20.25F);
            this.viaCarte3.DisabledAppearance.StrikeAppearance.Image = global::AppBingo.Properties.Resources.Rond50X50;
            this.viaCarte3.DisabledAppearance.StrikeAppearance.Style = VisualArrays.enuStrikeStyle.Image;
            this.viaCarte3.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.viaCarte3.EnabledAppearance.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.viaCarte3.EnabledAppearance.Font = new System.Drawing.Font("Goudy Stout", 20.25F);
            this.viaCarte3.EnabledAppearance.TextColor = System.Drawing.Color.Black;
            this.viaCarte3.Location = new System.Drawing.Point(376, 398);
            this.viaCarte3.Name = "viaCarte3";
            this.viaCarte3.RowCount = 5;
            this.viaCarte3.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaCarte3.Size = new System.Drawing.Size(328, 326);
            this.viaCarte3.SpecialValue = 0;
            this.viaCarte3.SpecialValueAppearance.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.viaCarte3.SpecialValueAppearance.Image = global::AppBingo.Properties.Resources.Centre1;
            this.viaCarte3.SpecialValueAppearance.Style = VisualArrays.enuBkgStyle.Image;
            this.viaCarte3.Sprites.AddRange(new VisualArrays.Sprite[] {
            this.sprSegmentCarte3});
            this.viaCarte3.TabIndex = 12;
            // 
            // sprSegmentCarte3
            // 
            this.sprSegmentCarte3.Color = System.Drawing.Color.Lime;
            this.sprSegmentCarte3.Name = "sprSegmentCarte3";
            this.sprSegmentCarte3.Visible = false;
            // 
            // viaCarte4
            // 
            this.viaCarte4.AddressView = VisualArrays.enuAddressView.Mode2D;
            this.viaCarte4.BackColor = System.Drawing.Color.Beige;
            this.viaCarte4.CellSize = new System.Drawing.Size(58, 48);
            this.viaCarte4.ColumnCount = 5;
            this.viaCarte4.ColumnHeader.BackgroundColor = System.Drawing.Color.Gray;
            this.viaCarte4.ColumnHeader.Font = new System.Drawing.Font("Goudy Stout", 27.75F);
            this.viaCarte4.ColumnHeader.ForeColor = System.Drawing.Color.DarkKhaki;
            this.viaCarte4.ColumnHeader.Height = 48;
            this.viaCarte4.ColumnHeader.Style = VisualArrays.enuHeaderBkgStyle.None;
            this.viaCarte4.ColumnHeader.ValueStyle = VisualArrays.enuDataStyle.User;
            this.viaCarte4.ColumnHeader.Visible = true;
            this.viaCarte4.DefaultValue = -1;
            this.viaCarte4.DisabledAppearance.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.viaCarte4.DisabledAppearance.Font = new System.Drawing.Font("Goudy Stout", 20.25F);
            this.viaCarte4.DisabledAppearance.StrikeAppearance.Image = global::AppBingo.Properties.Resources.Rond50X50;
            this.viaCarte4.DisabledAppearance.StrikeAppearance.Style = VisualArrays.enuStrikeStyle.Image;
            this.viaCarte4.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.viaCarte4.EnabledAppearance.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.viaCarte4.EnabledAppearance.Font = new System.Drawing.Font("Goudy Stout", 20.25F);
            this.viaCarte4.EnabledAppearance.TextColor = System.Drawing.Color.Black;
            this.viaCarte4.Location = new System.Drawing.Point(723, 398);
            this.viaCarte4.Name = "viaCarte4";
            this.viaCarte4.RowCount = 5;
            this.viaCarte4.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaCarte4.Size = new System.Drawing.Size(328, 326);
            this.viaCarte4.SpecialValue = 0;
            this.viaCarte4.SpecialValueAppearance.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.viaCarte4.SpecialValueAppearance.Image = global::AppBingo.Properties.Resources.Centre1;
            this.viaCarte4.SpecialValueAppearance.Style = VisualArrays.enuBkgStyle.Image;
            this.viaCarte4.Sprites.AddRange(new VisualArrays.Sprite[] {
            this.sprSegmentCarte4});
            this.viaCarte4.TabIndex = 13;
            // 
            // sprSegmentCarte4
            // 
            this.sprSegmentCarte4.Color = System.Drawing.Color.Lime;
            this.sprSegmentCarte4.Name = "sprSegmentCarte4";
            this.sprSegmentCarte4.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(350, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 715);
            this.panel1.TabIndex = 14;
            // 
            // FrmPrincipal
            // 
            this.AcceptButton = this.btnRetirer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1069, 749);
            this.Controls.Add(this.viaCarte1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viaCarte4);
            this.Controls.Add(this.viaCarte3);
            this.Controls.Add(this.viaCarte2);
            this.Controls.Add(this.panMaîtresse);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu de Bingo  ";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.panMaîtresse.ResumeLayout(false);
            this.panBoulier.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip mnuPrincipal;
        public System.Windows.Forms.ToolStripMenuItem mnuFichier;
        public System.Windows.Forms.ToolStripMenuItem mnuFichierNouvellePartie;
        public System.Windows.Forms.ToolStripSeparator mnuFichierSep;
        public System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        public System.Windows.Forms.Button btnRetirer;
        public System.Windows.Forms.Label lblNbBoules;
        public System.Windows.Forms.Panel panMaîtresse;
        public VisualArrays.VisualIntArray viaCarte2;
        public VisualArrays.VisualIntArray viaCarte3;
        public VisualArrays.VisualIntArray viaCarte4;
        public System.Windows.Forms.Label lblCarteAffichée;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public VisualArrays.VisualCells.VisualInt vsiNbBoulesRetirées;
        public System.Windows.Forms.Panel panel2;
        public VisualArrays.VisualCells.VisualInt vsiBoule;
        public VisualArrays.VisualCells.VisualChar vscBoule;
        public VisualArrays.SegmentSprite sprSegmentCarte1;
        public VisualArrays.SegmentSprite sprSegmentCarte2;
        public VisualArrays.SegmentSprite sprSegmentCarte3;
        public VisualArrays.SegmentSprite sprSegmentCarte4;
        public System.Windows.Forms.ToolStripMenuItem mnuSpécial;
        public System.Windows.Forms.ToolStripMenuItem mnuSpécialTest;
        public VisualArrays.VisualIntArray viaCarte1;
        public System.Windows.Forms.Panel panBoulier;
        public System.Windows.Forms.ToolStripMenuItem mnuSpécialBoulier;
        public VisualArrays.VisualIntArray viaBoulier;
        public VisualArrays.VisualIntArray viaCarteMaîtresse;
    }
}

