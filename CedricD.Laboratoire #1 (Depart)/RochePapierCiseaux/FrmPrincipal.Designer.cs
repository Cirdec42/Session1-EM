namespace RochePapierCiseaux
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
            this.imlJeu = new System.Windows.Forms.ImageList(this.components);
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierNouvellePartie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierSeperateur = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialModeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialModeBonus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAide = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAideCommentJouer = new System.Windows.Forms.ToolStripMenuItem();
            this.vsbLumièreJoueur1 = new VisualArrays.VisualCells.VisualBool();
            this.vsbLumièreJoueur2 = new VisualArrays.VisualCells.VisualBool();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panConfrontations = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConfrontationsNulles = new System.Windows.Forms.Label();
            this.vsiNbConfrontationsNulles = new VisualArrays.VisualCells.VisualInt();
            this.lblConfrontations = new System.Windows.Forms.Label();
            this.vsiNbConfPourCettePartie = new VisualArrays.VisualCells.VisualInt();
            this.vsiNbConfGagnéesJoueur2 = new VisualArrays.VisualCells.VisualInt();
            this.vsiNbConfGagnéesJoueur1 = new VisualArrays.VisualCells.VisualInt();
            this.vsiChoixJoueur1 = new VisualArrays.VisualCells.VisualInt();
            this.vsiChoixJoueur2 = new VisualArrays.VisualCells.VisualInt();
            this.lblJoueur2 = new System.Windows.Forms.Label();
            this.lblJoueur1 = new System.Windows.Forms.Label();
            this.btnJouer = new System.Windows.Forms.Button();
            this.vsiNbPartiesGagnéesJoueur1 = new VisualArrays.VisualCells.VisualInt();
            this.vsiNbPartiesGagnéesJoueur2 = new VisualArrays.VisualCells.VisualInt();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mnuPrincipal.SuspendLayout();
            this.panConfrontations.SuspendLayout();
            this.SuspendLayout();
            // 
            // imlJeu
            // 
            this.imlJeu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlJeu.ImageStream")));
            this.imlJeu.TransparentColor = System.Drawing.Color.Transparent;
            this.imlJeu.Images.SetKeyName(0, "roche.png");
            this.imlJeu.Images.SetKeyName(1, "papier.png");
            this.imlJeu.Images.SetKeyName(2, "ciseaux.png");
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuSpecial,
            this.mnuAide});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(653, 24);
            this.mnuPrincipal.TabIndex = 13;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierNouvellePartie,
            this.mnuFichierSeperateur,
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
            this.mnuFichierNouvellePartie.Text = "Nouvelle partie";
            this.mnuFichierNouvellePartie.Click += new System.EventHandler(this.mnuFichierNouvellePartie_Click);
            // 
            // mnuFichierSeperateur
            // 
            this.mnuFichierSeperateur.Name = "mnuFichierSeperateur";
            this.mnuFichierSeperateur.Size = new System.Drawing.Size(194, 6);
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(197, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuSpecial
            // 
            this.mnuSpecial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSpecialModeTest,
            this.mnuSpecialModeBonus});
            this.mnuSpecial.Name = "mnuSpecial";
            this.mnuSpecial.Size = new System.Drawing.Size(56, 20);
            this.mnuSpecial.Text = "&Spécial";
            // 
            // mnuSpecialModeTest
            // 
            this.mnuSpecialModeTest.CheckOnClick = true;
            this.mnuSpecialModeTest.Name = "mnuSpecialModeTest";
            this.mnuSpecialModeTest.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.mnuSpecialModeTest.Size = new System.Drawing.Size(182, 22);
            this.mnuSpecialModeTest.Text = "Mode &Test";
            this.mnuSpecialModeTest.Click += new System.EventHandler(this.mnuSpecialModeTest_Click);
            // 
            // mnuSpecialModeBonus
            // 
            this.mnuSpecialModeBonus.CheckOnClick = true;
            this.mnuSpecialModeBonus.Name = "mnuSpecialModeBonus";
            this.mnuSpecialModeBonus.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnuSpecialModeBonus.Size = new System.Drawing.Size(182, 22);
            this.mnuSpecialModeBonus.Text = "Mode &Bonus";
            // 
            // mnuAide
            // 
            this.mnuAide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAideCommentJouer});
            this.mnuAide.Name = "mnuAide";
            this.mnuAide.Size = new System.Drawing.Size(43, 20);
            this.mnuAide.Text = "&Aide";
            // 
            // mnuAideCommentJouer
            // 
            this.mnuAideCommentJouer.CheckOnClick = true;
            this.mnuAideCommentJouer.Name = "mnuAideCommentJouer";
            this.mnuAideCommentJouer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.mnuAideCommentJouer.Size = new System.Drawing.Size(199, 22);
            this.mnuAideCommentJouer.Text = "&Comment jouer";
            this.mnuAideCommentJouer.Click += new System.EventHandler(this.mnuAideCommentJouer_Click);
            // 
            // vsbLumièreJoueur1
            // 
            this.vsbLumièreJoueur1.FocusColor = System.Drawing.Color.Gray;
            this.vsbLumièreJoueur1.Location = new System.Drawing.Point(15, 93);
            this.vsbLumièreJoueur1.Name = "vsbLumièreJoueur1";
            this.vsbLumièreJoueur1.Size = new System.Drawing.Size(102, 143);
            this.vsbLumièreJoueur1.TabIndex = 19;
            this.vsbLumièreJoueur1.TabStop = false;
            this.vsbLumièreJoueur1.Toggle = false;
            this.vsbLumièreJoueur1.ValueAppearance.False.Image = global::RochePapierCiseaux.Properties.Resources.LightOff;
            this.vsbLumièreJoueur1.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbLumièreJoueur1.ValueAppearance.True.Image = global::RochePapierCiseaux.Properties.Resources.LightOn;
            this.vsbLumièreJoueur1.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // vsbLumièreJoueur2
            // 
            this.vsbLumièreJoueur2.FocusColor = System.Drawing.Color.Gray;
            this.vsbLumièreJoueur2.Location = new System.Drawing.Point(533, 90);
            this.vsbLumièreJoueur2.Name = "vsbLumièreJoueur2";
            this.vsbLumièreJoueur2.Size = new System.Drawing.Size(102, 143);
            this.vsbLumièreJoueur2.TabIndex = 20;
            this.vsbLumièreJoueur2.TabStop = false;
            this.vsbLumièreJoueur2.Toggle = false;
            this.vsbLumièreJoueur2.ValueAppearance.False.Image = global::RochePapierCiseaux.Properties.Resources.LightOff;
            this.vsbLumièreJoueur2.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbLumièreJoueur2.ValueAppearance.True.Image = global::RochePapierCiseaux.Properties.Resources.LightOn;
            this.vsbLumièreJoueur2.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 46);
            this.label3.TabIndex = 27;
            this.label3.Text = "Allumée lorsque le Joueur #1 a remporté la partie";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(530, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 46);
            this.label4.TabIndex = 28;
            this.label4.Text = "Allumée lorsque le Joueur #2 a remporté la partie";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panConfrontations
            // 
            this.panConfrontations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panConfrontations.Controls.Add(this.label2);
            this.panConfrontations.Controls.Add(this.label1);
            this.panConfrontations.Controls.Add(this.lblConfrontationsNulles);
            this.panConfrontations.Controls.Add(this.vsiNbConfrontationsNulles);
            this.panConfrontations.Controls.Add(this.lblConfrontations);
            this.panConfrontations.Controls.Add(this.vsiNbConfPourCettePartie);
            this.panConfrontations.Controls.Add(this.vsiNbConfGagnéesJoueur2);
            this.panConfrontations.Controls.Add(this.vsiNbConfGagnéesJoueur1);
            this.panConfrontations.Controls.Add(this.vsiChoixJoueur1);
            this.panConfrontations.Controls.Add(this.vsiChoixJoueur2);
            this.panConfrontations.Controls.Add(this.lblJoueur2);
            this.panConfrontations.Controls.Add(this.lblJoueur1);
            this.panConfrontations.Controls.Add(this.btnJouer);
            this.panConfrontations.Location = new System.Drawing.Point(130, 37);
            this.panConfrontations.Name = "panConfrontations";
            this.panConfrontations.Size = new System.Drawing.Size(383, 296);
            this.panConfrontations.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(251, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 36);
            this.label2.TabIndex = 39;
            this.label2.Text = "Confrontations gagnées par Joueur #2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 36);
            this.label1.TabIndex = 38;
            this.label1.Text = "Confrontations  gagnées par Joueur #1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConfrontationsNulles
            // 
            this.lblConfrontationsNulles.Location = new System.Drawing.Point(148, 164);
            this.lblConfrontationsNulles.Name = "lblConfrontationsNulles";
            this.lblConfrontationsNulles.Size = new System.Drawing.Size(90, 35);
            this.lblConfrontationsNulles.TabIndex = 37;
            this.lblConfrontationsNulles.Text = "Confrontations nulles";
            this.lblConfrontationsNulles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vsiNbConfrontationsNulles
            // 
            this.vsiNbConfrontationsNulles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vsiNbConfrontationsNulles.FocusColor = System.Drawing.Color.Gray;
            this.vsiNbConfrontationsNulles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNbConfrontationsNulles.ForeColor = System.Drawing.Color.Black;
            this.vsiNbConfrontationsNulles.GraphAppearance.BarAlign = VisualArrays.enuBarAlign.Middle;
            this.vsiNbConfrontationsNulles.GraphAppearance.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.vsiNbConfrontationsNulles.Location = new System.Drawing.Point(155, 199);
            this.vsiNbConfrontationsNulles.Maximum = 10;
            this.vsiNbConfrontationsNulles.Minimum = 0;
            this.vsiNbConfrontationsNulles.Name = "vsiNbConfrontationsNulles";
            this.vsiNbConfrontationsNulles.ReadOnly = true;
            this.vsiNbConfrontationsNulles.Size = new System.Drawing.Size(71, 22);
            this.vsiNbConfrontationsNulles.TabIndex = 36;
            this.vsiNbConfrontationsNulles.TabStop = false;
            this.vsiNbConfrontationsNulles.Text = "visualInt2";
            this.vsiNbConfrontationsNulles.View = VisualArrays.enuIntView.GraphNumber;
            // 
            // lblConfrontations
            // 
            this.lblConfrontations.Location = new System.Drawing.Point(13, 233);
            this.lblConfrontations.Name = "lblConfrontations";
            this.lblConfrontations.Size = new System.Drawing.Size(356, 18);
            this.lblConfrontations.TabIndex = 35;
            this.lblConfrontations.Text = "Nombre de confrontations dans cette partie ( le maximum est 10 )";
            this.lblConfrontations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vsiNbConfPourCettePartie
            // 
            this.vsiNbConfPourCettePartie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vsiNbConfPourCettePartie.FocusColor = System.Drawing.Color.Gray;
            this.vsiNbConfPourCettePartie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNbConfPourCettePartie.ForeColor = System.Drawing.Color.Black;
            this.vsiNbConfPourCettePartie.GraphAppearance.BarAlign = VisualArrays.enuBarAlign.Middle;
            this.vsiNbConfPourCettePartie.GraphAppearance.BarColor = System.Drawing.Color.DodgerBlue;
            this.vsiNbConfPourCettePartie.Location = new System.Drawing.Point(13, 254);
            this.vsiNbConfPourCettePartie.Maximum = 10;
            this.vsiNbConfPourCettePartie.Minimum = 0;
            this.vsiNbConfPourCettePartie.Name = "vsiNbConfPourCettePartie";
            this.vsiNbConfPourCettePartie.ReadOnly = true;
            this.vsiNbConfPourCettePartie.Size = new System.Drawing.Size(356, 27);
            this.vsiNbConfPourCettePartie.TabIndex = 34;
            this.vsiNbConfPourCettePartie.TabStop = false;
            this.vsiNbConfPourCettePartie.Text = "visualInt2";
            this.vsiNbConfPourCettePartie.View = VisualArrays.enuIntView.GraphNumber;
            // 
            // vsiNbConfGagnéesJoueur2
            // 
            this.vsiNbConfGagnéesJoueur2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vsiNbConfGagnéesJoueur2.FocusColor = System.Drawing.Color.Gray;
            this.vsiNbConfGagnéesJoueur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNbConfGagnéesJoueur2.ForeColor = System.Drawing.Color.Black;
            this.vsiNbConfGagnéesJoueur2.GraphAppearance.BarAlign = VisualArrays.enuBarAlign.Reverse;
            this.vsiNbConfGagnéesJoueur2.Location = new System.Drawing.Point(248, 199);
            this.vsiNbConfGagnéesJoueur2.Maximum = 6;
            this.vsiNbConfGagnéesJoueur2.Minimum = 0;
            this.vsiNbConfGagnéesJoueur2.Name = "vsiNbConfGagnéesJoueur2";
            this.vsiNbConfGagnéesJoueur2.ReadOnly = true;
            this.vsiNbConfGagnéesJoueur2.Size = new System.Drawing.Size(121, 22);
            this.vsiNbConfGagnéesJoueur2.TabIndex = 30;
            this.vsiNbConfGagnéesJoueur2.TabStop = false;
            this.vsiNbConfGagnéesJoueur2.Text = "visualInt1";
            this.vsiNbConfGagnéesJoueur2.View = VisualArrays.enuIntView.GraphNumber;
            // 
            // vsiNbConfGagnéesJoueur1
            // 
            this.vsiNbConfGagnéesJoueur1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vsiNbConfGagnéesJoueur1.FocusColor = System.Drawing.Color.Gray;
            this.vsiNbConfGagnéesJoueur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNbConfGagnéesJoueur1.ForeColor = System.Drawing.Color.Black;
            this.vsiNbConfGagnéesJoueur1.Location = new System.Drawing.Point(13, 199);
            this.vsiNbConfGagnéesJoueur1.Maximum = 6;
            this.vsiNbConfGagnéesJoueur1.Minimum = 0;
            this.vsiNbConfGagnéesJoueur1.Name = "vsiNbConfGagnéesJoueur1";
            this.vsiNbConfGagnéesJoueur1.ReadOnly = true;
            this.vsiNbConfGagnéesJoueur1.Size = new System.Drawing.Size(120, 22);
            this.vsiNbConfGagnéesJoueur1.TabIndex = 31;
            this.vsiNbConfGagnéesJoueur1.TabStop = false;
            this.vsiNbConfGagnéesJoueur1.Text = "visualInt2";
            this.vsiNbConfGagnéesJoueur1.View = VisualArrays.enuIntView.GraphNumber;
            // 
            // vsiChoixJoueur1
            // 
            this.vsiChoixJoueur1.BackColor = System.Drawing.Color.Gainsboro;
            this.vsiChoixJoueur1.FocusColor = System.Drawing.Color.Gray;
            this.vsiChoixJoueur1.ImageList = this.imlJeu;
            this.vsiChoixJoueur1.Location = new System.Drawing.Point(13, 39);
            this.vsiChoixJoueur1.Maximum = 2;
            this.vsiChoixJoueur1.Minimum = 0;
            this.vsiChoixJoueur1.Name = "vsiChoixJoueur1";
            this.vsiChoixJoueur1.ReadOnly = true;
            this.vsiChoixJoueur1.Size = new System.Drawing.Size(120, 122);
            this.vsiChoixJoueur1.TabIndex = 33;
            this.vsiChoixJoueur1.TabStop = false;
            this.vsiChoixJoueur1.Text = "visualInt1";
            this.vsiChoixJoueur1.View = VisualArrays.enuIntView.ImageList;
            // 
            // vsiChoixJoueur2
            // 
            this.vsiChoixJoueur2.BackColor = System.Drawing.Color.Gainsboro;
            this.vsiChoixJoueur2.FocusColor = System.Drawing.Color.Gray;
            this.vsiChoixJoueur2.ImageList = this.imlJeu;
            this.vsiChoixJoueur2.Location = new System.Drawing.Point(249, 39);
            this.vsiChoixJoueur2.Maximum = 2;
            this.vsiChoixJoueur2.Minimum = 0;
            this.vsiChoixJoueur2.Name = "vsiChoixJoueur2";
            this.vsiChoixJoueur2.ReadOnly = true;
            this.vsiChoixJoueur2.Size = new System.Drawing.Size(120, 122);
            this.vsiChoixJoueur2.TabIndex = 32;
            this.vsiChoixJoueur2.TabStop = false;
            this.vsiChoixJoueur2.Text = "visualInt1";
            this.vsiChoixJoueur2.View = VisualArrays.enuIntView.ImageList;
            // 
            // lblJoueur2
            // 
            this.lblJoueur2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoueur2.Location = new System.Drawing.Point(248, 13);
            this.lblJoueur2.Name = "lblJoueur2";
            this.lblJoueur2.Size = new System.Drawing.Size(122, 23);
            this.lblJoueur2.TabIndex = 29;
            this.lblJoueur2.Text = "Joueur #2";
            this.lblJoueur2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJoueur1
            // 
            this.lblJoueur1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoueur1.Location = new System.Drawing.Point(13, 13);
            this.lblJoueur1.Name = "lblJoueur1";
            this.lblJoueur1.Size = new System.Drawing.Size(120, 23);
            this.lblJoueur1.TabIndex = 28;
            this.lblJoueur1.Text = "Joueur #1";
            this.lblJoueur1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJouer
            // 
            this.btnJouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJouer.Location = new System.Drawing.Point(148, 66);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(90, 71);
            this.btnJouer.TabIndex = 27;
            this.btnJouer.Text = "Jouer";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // vsiNbPartiesGagnéesJoueur1
            // 
            this.vsiNbPartiesGagnéesJoueur1.BackColor = System.Drawing.Color.Silver;
            this.vsiNbPartiesGagnéesJoueur1.BorderSize = 2;
            this.vsiNbPartiesGagnéesJoueur1.FocusColor = System.Drawing.Color.Gray;
            this.vsiNbPartiesGagnéesJoueur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNbPartiesGagnéesJoueur1.ForeColor = System.Drawing.Color.Black;
            this.vsiNbPartiesGagnéesJoueur1.Location = new System.Drawing.Point(15, 291);
            this.vsiNbPartiesGagnéesJoueur1.Maximum = 99999;
            this.vsiNbPartiesGagnéesJoueur1.Name = "vsiNbPartiesGagnéesJoueur1";
            this.vsiNbPartiesGagnéesJoueur1.ReadOnly = true;
            this.vsiNbPartiesGagnéesJoueur1.Size = new System.Drawing.Size(99, 27);
            this.vsiNbPartiesGagnéesJoueur1.TabIndex = 23;
            this.vsiNbPartiesGagnéesJoueur1.TabStop = false;
            // 
            // vsiNbPartiesGagnéesJoueur2
            // 
            this.vsiNbPartiesGagnéesJoueur2.BackColor = System.Drawing.Color.Silver;
            this.vsiNbPartiesGagnéesJoueur2.BorderSize = 2;
            this.vsiNbPartiesGagnéesJoueur2.FocusColor = System.Drawing.Color.Gray;
            this.vsiNbPartiesGagnéesJoueur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNbPartiesGagnéesJoueur2.ForeColor = System.Drawing.Color.Black;
            this.vsiNbPartiesGagnéesJoueur2.Location = new System.Drawing.Point(533, 291);
            this.vsiNbPartiesGagnéesJoueur2.Maximum = 99999;
            this.vsiNbPartiesGagnéesJoueur2.Name = "vsiNbPartiesGagnéesJoueur2";
            this.vsiNbPartiesGagnéesJoueur2.ReadOnly = true;
            this.vsiNbPartiesGagnéesJoueur2.Size = new System.Drawing.Size(99, 27);
            this.vsiNbPartiesGagnéesJoueur2.TabIndex = 30;
            this.vsiNbPartiesGagnéesJoueur2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 46);
            this.label5.TabIndex = 31;
            this.label5.Text = "Nombre de parties gagnées par le Joueur #1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(533, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 46);
            this.label6.TabIndex = 32;
            this.label6.Text = "Nombre de parties gagnées par le Joueur #2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 349);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vsiNbPartiesGagnéesJoueur2);
            this.Controls.Add(this.panConfrontations);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vsiNbPartiesGagnéesJoueur1);
            this.Controls.Add(this.vsbLumièreJoueur2);
            this.Controls.Add(this.vsbLumièreJoueur1);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roche/Papier/Ciseaux";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.panConfrontations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imlJeu;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierNouvellePartie;
        private System.Windows.Forms.ToolStripSeparator mnuFichierSeperateur;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuAide;
        private System.Windows.Forms.ToolStripMenuItem mnuAideCommentJouer;
        private VisualArrays.VisualCells.VisualBool vsbLumièreJoueur1;
        private VisualArrays.VisualCells.VisualBool vsbLumièreJoueur2;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecial;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialModeTest;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialModeBonus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panConfrontations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConfrontationsNulles;
        private VisualArrays.VisualCells.VisualInt vsiNbConfrontationsNulles;
        private System.Windows.Forms.Label lblConfrontations;
        private VisualArrays.VisualCells.VisualInt vsiNbConfPourCettePartie;
        private VisualArrays.VisualCells.VisualInt vsiNbConfGagnéesJoueur2;
        private VisualArrays.VisualCells.VisualInt vsiNbConfGagnéesJoueur1;
        private VisualArrays.VisualCells.VisualInt vsiChoixJoueur1;
        private VisualArrays.VisualCells.VisualInt vsiChoixJoueur2;
        private System.Windows.Forms.Label lblJoueur2;
        private System.Windows.Forms.Label lblJoueur1;
        private System.Windows.Forms.Button btnJouer;
        private VisualArrays.VisualCells.VisualInt vsiNbPartiesGagnéesJoueur1;
        private VisualArrays.VisualCells.VisualInt vsiNbPartiesGagnéesJoueur2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

