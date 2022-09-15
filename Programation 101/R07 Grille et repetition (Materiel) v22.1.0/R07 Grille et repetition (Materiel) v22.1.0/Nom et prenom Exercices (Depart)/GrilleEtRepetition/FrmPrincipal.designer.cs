namespace GrilleEtRepetition
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
            this.tabEx3 = new System.Windows.Forms.TabPage();
            this.panExercice3 = new System.Windows.Forms.Panel();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculerLaSommeDesValeurs = new System.Windows.Forms.Button();
            this.vsiTotal = new VisualArrays.VisualCells.VisualInt();
            this.btnCopierTableau1D = new System.Windows.Forms.Button();
            this.btnAugmenterDe1ToutesLesCellules = new System.Windows.Forms.Button();
            this.btnAssigner12DansToutesLesCellules = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAssigner5DansPremièreCellule = new System.Windows.Forms.Button();
            this.viaNombres = new VisualArrays.VisualIntArray();
            this.lblExercice3 = new System.Windows.Forms.Label();
            this.tabEx2 = new System.Windows.Forms.TabPage();
            this.lblExercice2 = new System.Windows.Forms.Label();
            this.panExercice2 = new System.Windows.Forms.Panel();
            this.btnAssignerLettreDansToutesLesCellules = new System.Windows.Forms.Button();
            this.btnAssignerGDansToutesLesCellules = new System.Windows.Forms.Button();
            this.vscLettre = new VisualArrays.VisualCells.VisualChar();
            this.lblCarac = new System.Windows.Forms.Label();
            this.btnAssignerLettreIndex = new System.Windows.Forms.Button();
            this.lblIndexEx2 = new System.Windows.Forms.Label();
            this.vsiIndexEx2 = new VisualArrays.VisualCells.VisualInt();
            this.btnAugmenterCarac = new System.Windows.Forms.Button();
            this.btnPermuterCellules = new System.Windows.Forms.Button();
            this.btnCopierCellule = new System.Windows.Forms.Button();
            this.btnAssignerH = new System.Windows.Forms.Button();
            this.btnAssignerA = new System.Windows.Forms.Button();
            this.vcaCaractères = new VisualArrays.VisualCharArray();
            this.tabEx1 = new System.Windows.Forms.TabPage();
            this.panExercice1 = new System.Windows.Forms.Panel();
            this.panExercice1Index = new System.Windows.Forms.Panel();
            this.vsiExercice1Index = new VisualArrays.VisualCells.VisualInt();
            this.btnAllumerLumièreIndex = new System.Windows.Forms.Button();
            this.btnInverserLumière = new System.Windows.Forms.Button();
            this.lblIndexEx1 = new System.Windows.Forms.Label();
            this.btnRéinitialiserGrilleBool = new System.Windows.Forms.Button();
            this.btnAllumerToutesLesLumières = new System.Windows.Forms.Button();
            this.btnAllumerDernLum = new System.Windows.Forms.Button();
            this.btnAllumerPreLum = new System.Windows.Forms.Button();
            this.vbaLumières = new VisualArrays.VisualBoolArray();
            this.lblExercice1 = new System.Windows.Forms.Label();
            this.tabExercices = new System.Windows.Forms.TabControl();
            this.tabEx3.SuspendLayout();
            this.panExercice3.SuspendLayout();
            this.tabEx2.SuspendLayout();
            this.panExercice2.SuspendLayout();
            this.tabEx1.SuspendLayout();
            this.panExercice1.SuspendLayout();
            this.panExercice1Index.SuspendLayout();
            this.tabExercices.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEx3
            // 
            this.tabEx3.Controls.Add(this.panExercice3);
            this.tabEx3.Controls.Add(this.lblExercice3);
            this.tabEx3.Location = new System.Drawing.Point(4, 27);
            this.tabEx3.Name = "tabEx3";
            this.tabEx3.Padding = new System.Windows.Forms.Padding(3);
            this.tabEx3.Size = new System.Drawing.Size(695, 362);
            this.tabEx3.TabIndex = 3;
            this.tabEx3.Text = "Exercice 3";
            // 
            // panExercice3
            // 
            this.panExercice3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panExercice3.Controls.Add(this.btnCalculer);
            this.panExercice3.Controls.Add(this.label1);
            this.panExercice3.Controls.Add(this.btnCalculerLaSommeDesValeurs);
            this.panExercice3.Controls.Add(this.vsiTotal);
            this.panExercice3.Controls.Add(this.btnCopierTableau1D);
            this.panExercice3.Controls.Add(this.btnAugmenterDe1ToutesLesCellules);
            this.panExercice3.Controls.Add(this.btnAssigner12DansToutesLesCellules);
            this.panExercice3.Controls.Add(this.button1);
            this.panExercice3.Controls.Add(this.btnAssigner5DansPremièreCellule);
            this.panExercice3.Controls.Add(this.viaNombres);
            this.panExercice3.Location = new System.Drawing.Point(14, 49);
            this.panExercice3.Name = "panExercice3";
            this.panExercice3.Size = new System.Drawing.Size(668, 300);
            this.panExercice3.TabIndex = 4;
            // 
            // btnCalculer
            // 
            this.btnCalculer.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculer.Location = new System.Drawing.Point(437, 213);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(221, 62);
            this.btnCalculer.TabIndex = 34;
            this.btnCalculer.Text = "(G) Compter le nombre de valeurs supérieures à 75";
            this.btnCalculer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.BtnCalculer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Total :";
            // 
            // btnCalculerLaSommeDesValeurs
            // 
            this.btnCalculerLaSommeDesValeurs.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculerLaSommeDesValeurs.Location = new System.Drawing.Point(437, 111);
            this.btnCalculerLaSommeDesValeurs.Name = "btnCalculerLaSommeDesValeurs";
            this.btnCalculerLaSommeDesValeurs.Size = new System.Drawing.Size(221, 62);
            this.btnCalculerLaSommeDesValeurs.TabIndex = 32;
            this.btnCalculerLaSommeDesValeurs.Text = "(F) Calculer la somme de toutes les valeurs contenues dans la grille";
            this.btnCalculerLaSommeDesValeurs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculerLaSommeDesValeurs.UseVisualStyleBackColor = true;
            this.btnCalculerLaSommeDesValeurs.Click += new System.EventHandler(this.BtnCalculerLaSommeDesValeurs_Click);
            // 
            // vsiTotal
            // 
            this.vsiTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vsiTotal.FocusColor = System.Drawing.Color.Gray;
            this.vsiTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiTotal.ForeColor = System.Drawing.Color.Black;
            this.vsiTotal.GraphAppearance.BarAlign = VisualArrays.enuBarAlign.Middle;
            this.vsiTotal.GraphAppearance.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.vsiTotal.Location = new System.Drawing.Point(544, 178);
            this.vsiTotal.Maximum = 1000000;
            this.vsiTotal.Minimum = 0;
            this.vsiTotal.Name = "vsiTotal";
            this.vsiTotal.ReadOnly = true;
            this.vsiTotal.Size = new System.Drawing.Size(114, 28);
            this.vsiTotal.TabIndex = 31;
            this.vsiTotal.Text = "visualInt2";
            // 
            // btnCopierTableau1D
            // 
            this.btnCopierTableau1D.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopierTableau1D.Location = new System.Drawing.Point(5, 247);
            this.btnCopierTableau1D.Name = "btnCopierTableau1D";
            this.btnCopierTableau1D.Size = new System.Drawing.Size(413, 28);
            this.btnCopierTableau1D.TabIndex = 30;
            this.btnCopierTableau1D.Text = "(E) Copier toutes les valeurs d\'un tableau 1D";
            this.btnCopierTableau1D.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopierTableau1D.UseVisualStyleBackColor = true;
            this.btnCopierTableau1D.Click += new System.EventHandler(this.BtnCopierTableau1D_Click);
            // 
            // btnAugmenterDe1ToutesLesCellules
            // 
            this.btnAugmenterDe1ToutesLesCellules.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAugmenterDe1ToutesLesCellules.Location = new System.Drawing.Point(5, 213);
            this.btnAugmenterDe1ToutesLesCellules.Name = "btnAugmenterDe1ToutesLesCellules";
            this.btnAugmenterDe1ToutesLesCellules.Size = new System.Drawing.Size(413, 28);
            this.btnAugmenterDe1ToutesLesCellules.TabIndex = 29;
            this.btnAugmenterDe1ToutesLesCellules.Text = "(D) Augmenter de 1 la valeur de toutes les cellules";
            this.btnAugmenterDe1ToutesLesCellules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAugmenterDe1ToutesLesCellules.UseVisualStyleBackColor = true;
            this.btnAugmenterDe1ToutesLesCellules.Click += new System.EventHandler(this.BtnAugmenterDe1ToutesLesCellules_Click);
            // 
            // btnAssigner12DansToutesLesCellules
            // 
            this.btnAssigner12DansToutesLesCellules.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssigner12DansToutesLesCellules.Location = new System.Drawing.Point(5, 179);
            this.btnAssigner12DansToutesLesCellules.Name = "btnAssigner12DansToutesLesCellules";
            this.btnAssigner12DansToutesLesCellules.Size = new System.Drawing.Size(413, 28);
            this.btnAssigner12DansToutesLesCellules.TabIndex = 28;
            this.btnAssigner12DansToutesLesCellules.Text = "(C) Assigner 12 dans toutes les cellules de la grille";
            this.btnAssigner12DansToutesLesCellules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssigner12DansToutesLesCellules.UseVisualStyleBackColor = true;
            this.btnAssigner12DansToutesLesCellules.Click += new System.EventHandler(this.BtnAssigner12DansToutesLesCellules_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(5, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(413, 28);
            this.button1.TabIndex = 27;
            this.button1.Text = "(B) Copier le contenu de la première cellulle dans la dernière.";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnAssigner5DansPremièreCellule
            // 
            this.btnAssigner5DansPremièreCellule.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssigner5DansPremièreCellule.Location = new System.Drawing.Point(5, 111);
            this.btnAssigner5DansPremièreCellule.Name = "btnAssigner5DansPremièreCellule";
            this.btnAssigner5DansPremièreCellule.Size = new System.Drawing.Size(413, 28);
            this.btnAssigner5DansPremièreCellule.TabIndex = 26;
            this.btnAssigner5DansPremièreCellule.Text = "(A) Assigner la valeur 5 dans la première cellule";
            this.btnAssigner5DansPremièreCellule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssigner5DansPremièreCellule.UseVisualStyleBackColor = true;
            this.btnAssigner5DansPremièreCellule.Click += new System.EventHandler(this.BtnAssigner5DansPremièreCellule_Click);
            // 
            // viaNombres
            // 
            this.viaNombres.BackColor = System.Drawing.Color.Black;
            this.viaNombres.CellSize = new System.Drawing.Size(59, 41);
            this.viaNombres.ColumnCount = 10;
            this.viaNombres.ColumnHeader.BackgroundColor = System.Drawing.Color.Teal;
            this.viaNombres.ColumnHeader.Visible = true;
            this.viaNombres.DisabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.viaNombres.DisabledAppearance.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaNombres.DisabledAppearance.StrikeAppearance.Style = VisualArrays.enuStrikeStyle.Cross;
            this.viaNombres.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.viaNombres.DisabledAppearance.TextColor = System.Drawing.Color.LightGray;
            this.viaNombres.EnabledAppearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaNombres.Location = new System.Drawing.Point(5, 10);
            this.viaNombres.Minimum = 0;
            this.viaNombres.Name = "viaNombres";
            this.viaNombres.RowCount = 1;
            this.viaNombres.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaNombres.Size = new System.Drawing.Size(653, 79);
            this.viaNombres.TabIndex = 0;
            this.viaNombres.Text = "visualIntArray1";
            // 
            // lblExercice3
            // 
            this.lblExercice3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblExercice3.Location = new System.Drawing.Point(14, 22);
            this.lblExercice3.Name = "lblExercice3";
            this.lblExercice3.Size = new System.Drawing.Size(477, 24);
            this.lblExercice3.TabIndex = 3;
            this.lblExercice3.Text = "VisualIntArray, une grille de nombres entiers";
            // 
            // tabEx2
            // 
            this.tabEx2.Controls.Add(this.lblExercice2);
            this.tabEx2.Controls.Add(this.panExercice2);
            this.tabEx2.Location = new System.Drawing.Point(4, 27);
            this.tabEx2.Name = "tabEx2";
            this.tabEx2.Padding = new System.Windows.Forms.Padding(3);
            this.tabEx2.Size = new System.Drawing.Size(695, 362);
            this.tabEx2.TabIndex = 1;
            this.tabEx2.Text = "Exercice 2";
            // 
            // lblExercice2
            // 
            this.lblExercice2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblExercice2.Location = new System.Drawing.Point(14, 22);
            this.lblExercice2.Name = "lblExercice2";
            this.lblExercice2.Size = new System.Drawing.Size(477, 24);
            this.lblExercice2.TabIndex = 0;
            this.lblExercice2.Text = "La VisualCharArray, une grille de caractères";
            // 
            // panExercice2
            // 
            this.panExercice2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panExercice2.Controls.Add(this.btnAssignerLettreDansToutesLesCellules);
            this.panExercice2.Controls.Add(this.btnAssignerGDansToutesLesCellules);
            this.panExercice2.Controls.Add(this.vscLettre);
            this.panExercice2.Controls.Add(this.lblCarac);
            this.panExercice2.Controls.Add(this.btnAssignerLettreIndex);
            this.panExercice2.Controls.Add(this.lblIndexEx2);
            this.panExercice2.Controls.Add(this.vsiIndexEx2);
            this.panExercice2.Controls.Add(this.btnAugmenterCarac);
            this.panExercice2.Controls.Add(this.btnPermuterCellules);
            this.panExercice2.Controls.Add(this.btnCopierCellule);
            this.panExercice2.Controls.Add(this.btnAssignerH);
            this.panExercice2.Controls.Add(this.btnAssignerA);
            this.panExercice2.Controls.Add(this.vcaCaractères);
            this.panExercice2.Location = new System.Drawing.Point(14, 49);
            this.panExercice2.Name = "panExercice2";
            this.panExercice2.Size = new System.Drawing.Size(666, 300);
            this.panExercice2.TabIndex = 1;
            // 
            // btnAssignerLettreDansToutesLesCellules
            // 
            this.btnAssignerLettreDansToutesLesCellules.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignerLettreDansToutesLesCellules.Location = new System.Drawing.Point(382, 209);
            this.btnAssignerLettreDansToutesLesCellules.Name = "btnAssignerLettreDansToutesLesCellules";
            this.btnAssignerLettreDansToutesLesCellules.Size = new System.Drawing.Size(267, 62);
            this.btnAssignerLettreDansToutesLesCellules.TabIndex = 35;
            this.btnAssignerLettreDansToutesLesCellules.Text = "(H) Placer la lettre choisie dans toutes les cellules";
            this.btnAssignerLettreDansToutesLesCellules.UseVisualStyleBackColor = true;
            this.btnAssignerLettreDansToutesLesCellules.Click += new System.EventHandler(this.BtnAssignerLettreDansToutesLesCellules_Click);
            // 
            // btnAssignerGDansToutesLesCellules
            // 
            this.btnAssignerGDansToutesLesCellules.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignerGDansToutesLesCellules.Location = new System.Drawing.Point(382, 175);
            this.btnAssignerGDansToutesLesCellules.Name = "btnAssignerGDansToutesLesCellules";
            this.btnAssignerGDansToutesLesCellules.Size = new System.Drawing.Size(267, 28);
            this.btnAssignerGDansToutesLesCellules.TabIndex = 34;
            this.btnAssignerGDansToutesLesCellules.Text = "(G) Placer \'G\' dans toutes les cellules";
            this.btnAssignerGDansToutesLesCellules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignerGDansToutesLesCellules.UseVisualStyleBackColor = true;
            this.btnAssignerGDansToutesLesCellules.Click += new System.EventHandler(this.BtnAssignerGDansToutesLesCellules_Click);
            // 
            // vscLettre
            // 
            this.vscLettre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vscLettre.FocusColor = System.Drawing.Color.Gray;
            this.vscLettre.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vscLettre.Location = new System.Drawing.Point(556, 123);
            this.vscLettre.Name = "vscLettre";
            this.vscLettre.Size = new System.Drawing.Size(43, 46);
            this.vscLettre.TabIndex = 9;
            this.vscLettre.Value = 'X';
            // 
            // lblCarac
            // 
            this.lblCarac.AutoSize = true;
            this.lblCarac.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarac.Location = new System.Drawing.Point(554, 106);
            this.lblCarac.Name = "lblCarac";
            this.lblCarac.Size = new System.Drawing.Size(45, 15);
            this.lblCarac.TabIndex = 33;
            this.lblCarac.Text = "Lettre";
            // 
            // btnAssignerLettreIndex
            // 
            this.btnAssignerLettreIndex.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnAssignerLettreIndex.Location = new System.Drawing.Point(382, 107);
            this.btnAssignerLettreIndex.Name = "btnAssignerLettreIndex";
            this.btnAssignerLettreIndex.Size = new System.Drawing.Size(163, 62);
            this.btnAssignerLettreIndex.TabIndex = 32;
            this.btnAssignerLettreIndex.Text = "(F) Assigner la lettre choisie à l\'index spécifié";
            this.btnAssignerLettreIndex.UseVisualStyleBackColor = true;
            this.btnAssignerLettreIndex.Click += new System.EventHandler(this.btnAssignerLettreIndex_Click);
            // 
            // lblIndexEx2
            // 
            this.lblIndexEx2.AutoSize = true;
            this.lblIndexEx2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndexEx2.Location = new System.Drawing.Point(607, 106);
            this.lblIndexEx2.Name = "lblIndexEx2";
            this.lblIndexEx2.Size = new System.Drawing.Size(42, 15);
            this.lblIndexEx2.TabIndex = 31;
            this.lblIndexEx2.Text = "Index";
            // 
            // vsiIndexEx2
            // 
            this.vsiIndexEx2.BackColor = System.Drawing.Color.White;
            this.vsiIndexEx2.FocusColor = System.Drawing.Color.Gray;
            this.vsiIndexEx2.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiIndexEx2.ForeColor = System.Drawing.Color.Black;
            this.vsiIndexEx2.GraphAppearance.BarAlign = VisualArrays.enuBarAlign.Middle;
            this.vsiIndexEx2.GraphAppearance.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.vsiIndexEx2.Location = new System.Drawing.Point(605, 123);
            this.vsiIndexEx2.Maximum = 9;
            this.vsiIndexEx2.Minimum = 0;
            this.vsiIndexEx2.Name = "vsiIndexEx2";
            this.vsiIndexEx2.Size = new System.Drawing.Size(44, 46);
            this.vsiIndexEx2.TabIndex = 30;
            this.vsiIndexEx2.Text = "visualInt2";
            this.vsiIndexEx2.Value = 2;
            // 
            // btnAugmenterCarac
            // 
            this.btnAugmenterCarac.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAugmenterCarac.Location = new System.Drawing.Point(5, 209);
            this.btnAugmenterCarac.Name = "btnAugmenterCarac";
            this.btnAugmenterCarac.Size = new System.Drawing.Size(334, 28);
            this.btnAugmenterCarac.TabIndex = 29;
            this.btnAugmenterCarac.Text = "(D) Augmenter le caractère de la première cellule";
            this.btnAugmenterCarac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAugmenterCarac.UseVisualStyleBackColor = true;
            this.btnAugmenterCarac.Click += new System.EventHandler(this.btnAugmenterCarac_Click);
            // 
            // btnPermuterCellules
            // 
            this.btnPermuterCellules.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermuterCellules.Location = new System.Drawing.Point(5, 243);
            this.btnPermuterCellules.Name = "btnPermuterCellules";
            this.btnPermuterCellules.Size = new System.Drawing.Size(334, 28);
            this.btnPermuterCellules.TabIndex = 28;
            this.btnPermuterCellules.Text = "(E) Permuter la première cellule avec la deuxième";
            this.btnPermuterCellules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermuterCellules.UseVisualStyleBackColor = true;
            this.btnPermuterCellules.Click += new System.EventHandler(this.btnPermuterCellules_Click);
            // 
            // btnCopierCellule
            // 
            this.btnCopierCellule.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopierCellule.Location = new System.Drawing.Point(5, 175);
            this.btnCopierCellule.Name = "btnCopierCellule";
            this.btnCopierCellule.Size = new System.Drawing.Size(334, 28);
            this.btnCopierCellule.TabIndex = 27;
            this.btnCopierCellule.Text = "(C) Copier la première cellule dans la deuxième";
            this.btnCopierCellule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopierCellule.UseVisualStyleBackColor = true;
            this.btnCopierCellule.Click += new System.EventHandler(this.btnCopierCellule_Click);
            // 
            // btnAssignerH
            // 
            this.btnAssignerH.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignerH.Location = new System.Drawing.Point(5, 141);
            this.btnAssignerH.Name = "btnAssignerH";
            this.btnAssignerH.Size = new System.Drawing.Size(334, 28);
            this.btnAssignerH.TabIndex = 26;
            this.btnAssignerH.Text = "(B) Assigner la lettre \'H\' dans la dernière cellule";
            this.btnAssignerH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignerH.UseVisualStyleBackColor = true;
            this.btnAssignerH.Click += new System.EventHandler(this.btnAssignerH_Click);
            // 
            // btnAssignerA
            // 
            this.btnAssignerA.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignerA.Location = new System.Drawing.Point(5, 107);
            this.btnAssignerA.Name = "btnAssignerA";
            this.btnAssignerA.Size = new System.Drawing.Size(334, 28);
            this.btnAssignerA.TabIndex = 25;
            this.btnAssignerA.Text = "(A) Assigner la lettre \'A\' dans la première cellule";
            this.btnAssignerA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignerA.UseVisualStyleBackColor = true;
            this.btnAssignerA.Click += new System.EventHandler(this.btnAssignerA_Click);
            // 
            // vcaCaractères
            // 
            this.vcaCaractères.AddressView = VisualArrays.enuAddressView.Mode1D;
            this.vcaCaractères.BackColor = System.Drawing.Color.Black;
            this.vcaCaractères.CellSize = new System.Drawing.Size(59, 48);
            this.vcaCaractères.ColumnCount = 10;
            this.vcaCaractères.DefaultValue = ' ';
            this.vcaCaractères.EnabledAppearance.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.vcaCaractères.EnabledAppearance.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcaCaractères.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vcaCaractères.Location = new System.Drawing.Point(5, 10);
            this.vcaCaractères.Name = "vcaCaractères";
            this.vcaCaractères.RowCount = 1;
            this.vcaCaractères.RowHeader.ForeColor = System.Drawing.Color.White;
            this.vcaCaractères.Size = new System.Drawing.Size(653, 66);
            this.vcaCaractères.TabIndex = 10;
            this.vcaCaractères.Text = "visualCharArray1";
            // 
            // tabEx1
            // 
            this.tabEx1.Controls.Add(this.panExercice1);
            this.tabEx1.Controls.Add(this.lblExercice1);
            this.tabEx1.Location = new System.Drawing.Point(4, 27);
            this.tabEx1.Name = "tabEx1";
            this.tabEx1.Padding = new System.Windows.Forms.Padding(3);
            this.tabEx1.Size = new System.Drawing.Size(695, 362);
            this.tabEx1.TabIndex = 0;
            this.tabEx1.Text = "Exercice 1";
            // 
            // panExercice1
            // 
            this.panExercice1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panExercice1.Controls.Add(this.panExercice1Index);
            this.panExercice1.Controls.Add(this.btnRéinitialiserGrilleBool);
            this.panExercice1.Controls.Add(this.btnAllumerToutesLesLumières);
            this.panExercice1.Controls.Add(this.btnAllumerDernLum);
            this.panExercice1.Controls.Add(this.btnAllumerPreLum);
            this.panExercice1.Controls.Add(this.vbaLumières);
            this.panExercice1.Location = new System.Drawing.Point(14, 49);
            this.panExercice1.Name = "panExercice1";
            this.panExercice1.Size = new System.Drawing.Size(666, 300);
            this.panExercice1.TabIndex = 21;
            // 
            // panExercice1Index
            // 
            this.panExercice1Index.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panExercice1Index.Controls.Add(this.vsiExercice1Index);
            this.panExercice1Index.Controls.Add(this.btnAllumerLumièreIndex);
            this.panExercice1Index.Controls.Add(this.btnInverserLumière);
            this.panExercice1Index.Controls.Add(this.lblIndexEx1);
            this.panExercice1Index.Location = new System.Drawing.Point(333, 210);
            this.panExercice1Index.Name = "panExercice1Index";
            this.panExercice1Index.Size = new System.Drawing.Size(324, 78);
            this.panExercice1Index.TabIndex = 30;
            // 
            // vsiExercice1Index
            // 
            this.vsiExercice1Index.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vsiExercice1Index.FocusColor = System.Drawing.Color.Gray;
            this.vsiExercice1Index.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiExercice1Index.ForeColor = System.Drawing.Color.Black;
            this.vsiExercice1Index.GraphAppearance.BarAlign = VisualArrays.enuBarAlign.Middle;
            this.vsiExercice1Index.GraphAppearance.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.vsiExercice1Index.Location = new System.Drawing.Point(268, 30);
            this.vsiExercice1Index.Maximum = 5;
            this.vsiExercice1Index.Minimum = 0;
            this.vsiExercice1Index.Name = "vsiExercice1Index";
            this.vsiExercice1Index.Size = new System.Drawing.Size(44, 28);
            this.vsiExercice1Index.TabIndex = 2;
            this.vsiExercice1Index.Text = "visualInt2";
            this.vsiExercice1Index.Value = 2;
            // 
            // btnAllumerLumièreIndex
            // 
            this.btnAllumerLumièreIndex.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllumerLumièreIndex.Location = new System.Drawing.Point(8, 7);
            this.btnAllumerLumièreIndex.Name = "btnAllumerLumièreIndex";
            this.btnAllumerLumièreIndex.Size = new System.Drawing.Size(239, 28);
            this.btnAllumerLumièreIndex.TabIndex = 22;
            this.btnAllumerLumièreIndex.Text = "(E) Allumer la lumière à l\'index";
            this.btnAllumerLumièreIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllumerLumièreIndex.UseVisualStyleBackColor = true;
            this.btnAllumerLumièreIndex.Click += new System.EventHandler(this.btnAllumerLumièreIndex_Click);
            // 
            // btnInverserLumière
            // 
            this.btnInverserLumière.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverserLumière.Location = new System.Drawing.Point(8, 41);
            this.btnInverserLumière.Name = "btnInverserLumière";
            this.btnInverserLumière.Size = new System.Drawing.Size(239, 28);
            this.btnInverserLumière.TabIndex = 26;
            this.btnInverserLumière.Text = "(F) Inverser la lumière à l\'index";
            this.btnInverserLumière.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInverserLumière.UseVisualStyleBackColor = true;
            this.btnInverserLumière.Click += new System.EventHandler(this.btnInverserLumière_Click);
            // 
            // lblIndexEx1
            // 
            this.lblIndexEx1.AutoSize = true;
            this.lblIndexEx1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndexEx1.Location = new System.Drawing.Point(270, 12);
            this.lblIndexEx1.Name = "lblIndexEx1";
            this.lblIndexEx1.Size = new System.Drawing.Size(42, 15);
            this.lblIndexEx1.TabIndex = 27;
            this.lblIndexEx1.Text = "Index";
            // 
            // btnRéinitialiserGrilleBool
            // 
            this.btnRéinitialiserGrilleBool.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRéinitialiserGrilleBool.Location = new System.Drawing.Point(490, 176);
            this.btnRéinitialiserGrilleBool.Name = "btnRéinitialiserGrilleBool";
            this.btnRéinitialiserGrilleBool.Size = new System.Drawing.Size(167, 28);
            this.btnRéinitialiserGrilleBool.TabIndex = 29;
            this.btnRéinitialiserGrilleBool.Text = "(D) Réinitialiser la grille";
            this.btnRéinitialiserGrilleBool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRéinitialiserGrilleBool.UseVisualStyleBackColor = true;
            this.btnRéinitialiserGrilleBool.Click += new System.EventHandler(this.BtnRéinitialiserGrilleBool_Click);
            // 
            // btnAllumerToutesLesLumières
            // 
            this.btnAllumerToutesLesLumières.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllumerToutesLesLumières.Location = new System.Drawing.Point(8, 253);
            this.btnAllumerToutesLesLumières.Name = "btnAllumerToutesLesLumières";
            this.btnAllumerToutesLesLumières.Size = new System.Drawing.Size(285, 28);
            this.btnAllumerToutesLesLumières.TabIndex = 28;
            this.btnAllumerToutesLesLumières.Text = "(C) Allumer toutes les lumières";
            this.btnAllumerToutesLesLumières.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllumerToutesLesLumières.UseVisualStyleBackColor = true;
            this.btnAllumerToutesLesLumières.Click += new System.EventHandler(this.BtnAllumerToutesLesLumières_Click);
            // 
            // btnAllumerDernLum
            // 
            this.btnAllumerDernLum.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllumerDernLum.Location = new System.Drawing.Point(8, 217);
            this.btnAllumerDernLum.Name = "btnAllumerDernLum";
            this.btnAllumerDernLum.Size = new System.Drawing.Size(285, 28);
            this.btnAllumerDernLum.TabIndex = 25;
            this.btnAllumerDernLum.Text = "(B) Allumer la dernière lumière";
            this.btnAllumerDernLum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllumerDernLum.UseVisualStyleBackColor = true;
            this.btnAllumerDernLum.Click += new System.EventHandler(this.btnAllumerDernLum_Click);
            // 
            // btnAllumerPreLum
            // 
            this.btnAllumerPreLum.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllumerPreLum.Location = new System.Drawing.Point(8, 180);
            this.btnAllumerPreLum.Name = "btnAllumerPreLum";
            this.btnAllumerPreLum.Size = new System.Drawing.Size(285, 28);
            this.btnAllumerPreLum.TabIndex = 24;
            this.btnAllumerPreLum.Text = "(A) Allumer la première lumière";
            this.btnAllumerPreLum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllumerPreLum.UseVisualStyleBackColor = true;
            this.btnAllumerPreLum.Click += new System.EventHandler(this.btnAllumerPreLum_Click);
            // 
            // vbaLumières
            // 
            this.vbaLumières.AddressView = VisualArrays.enuAddressView.Mode1D;
            this.vbaLumières.BackColor = System.Drawing.Color.Black;
            this.vbaLumières.CellSize = new System.Drawing.Size(101, 136);
            this.vbaLumières.ColumnCount = 6;
            this.vbaLumières.DisabledAppearance.StrikeAppearance.Style = VisualArrays.enuStrikeStyle.Cross;
            this.vbaLumières.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.vbaLumières.EnabledAppearance.Image = global::GrilleEtRepetition.Properties.Resources.LightOff;
            this.vbaLumières.EnabledAppearance.Style = VisualArrays.enuBkgStyle.Image;
            this.vbaLumières.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbaLumières.ForeColor = System.Drawing.Color.Silver;
            this.vbaLumières.Location = new System.Drawing.Point(8, 10);
            this.vbaLumières.Name = "vbaLumières";
            this.vbaLumières.RowCount = 1;
            this.vbaLumières.RowHeader.ForeColor = System.Drawing.Color.White;
            this.vbaLumières.Size = new System.Drawing.Size(649, 154);
            this.vbaLumières.SpecialValueAppearance.Image = global::GrilleEtRepetition.Properties.Resources.LightOn;
            this.vbaLumières.SpecialValueAppearance.Style = VisualArrays.enuBkgStyle.Image;
            this.vbaLumières.TabIndex = 23;
            this.vbaLumières.Text = "visualBoolArray1";
            // 
            // lblExercice1
            // 
            this.lblExercice1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblExercice1.Location = new System.Drawing.Point(11, 22);
            this.lblExercice1.Name = "lblExercice1";
            this.lblExercice1.Size = new System.Drawing.Size(477, 24);
            this.lblExercice1.TabIndex = 22;
            this.lblExercice1.Text = "La VisualBoolArray, une grille de booléens";
            // 
            // tabExercices
            // 
            this.tabExercices.Controls.Add(this.tabEx1);
            this.tabExercices.Controls.Add(this.tabEx2);
            this.tabExercices.Controls.Add(this.tabEx3);
            this.tabExercices.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabExercices.Location = new System.Drawing.Point(12, 27);
            this.tabExercices.Name = "tabExercices";
            this.tabExercices.SelectedIndex = 0;
            this.tabExercices.Size = new System.Drawing.Size(703, 393);
            this.tabExercices.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 434);
            this.Controls.Add(this.tabExercices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grille et répétition ";
            this.tabEx3.ResumeLayout(false);
            this.panExercice3.ResumeLayout(false);
            this.panExercice3.PerformLayout();
            this.tabEx2.ResumeLayout(false);
            this.panExercice2.ResumeLayout(false);
            this.panExercice2.PerformLayout();
            this.tabEx1.ResumeLayout(false);
            this.panExercice1.ResumeLayout(false);
            this.panExercice1Index.ResumeLayout(false);
            this.panExercice1Index.PerformLayout();
            this.tabExercices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabEx3;
        private System.Windows.Forms.Panel panExercice3;
        private VisualArrays.VisualIntArray viaNombres;
        private System.Windows.Forms.Label lblExercice3;
        private System.Windows.Forms.TabPage tabEx2;
        private System.Windows.Forms.Label lblExercice2;
        private System.Windows.Forms.Panel panExercice2;
        private VisualArrays.VisualCells.VisualChar vscLettre;
        private System.Windows.Forms.Label lblCarac;
        private System.Windows.Forms.Button btnAssignerLettreIndex;
        private System.Windows.Forms.Label lblIndexEx2;
        private VisualArrays.VisualCells.VisualInt vsiIndexEx2;
        private System.Windows.Forms.Button btnAugmenterCarac;
        private System.Windows.Forms.Button btnPermuterCellules;
        private System.Windows.Forms.Button btnCopierCellule;
        private System.Windows.Forms.Button btnAssignerH;
        private System.Windows.Forms.Button btnAssignerA;
        private VisualArrays.VisualCharArray vcaCaractères;
        private System.Windows.Forms.TabPage tabEx1;
        private System.Windows.Forms.Panel panExercice1;
        private System.Windows.Forms.Label lblIndexEx1;
        private System.Windows.Forms.Button btnInverserLumière;
        private System.Windows.Forms.Button btnAllumerDernLum;
        private System.Windows.Forms.Button btnAllumerPreLum;
        private VisualArrays.VisualCells.VisualInt vsiExercice1Index;
        private VisualArrays.VisualBoolArray vbaLumières;
        private System.Windows.Forms.Button btnAllumerLumièreIndex;
        private System.Windows.Forms.Label lblExercice1;
        private System.Windows.Forms.TabControl tabExercices;
        private System.Windows.Forms.Button btnAllumerToutesLesLumières;
        private System.Windows.Forms.Button btnAssigner5DansPremièreCellule;
        private System.Windows.Forms.Button btnRéinitialiserGrilleBool;
        private System.Windows.Forms.Panel panExercice1Index;
        private System.Windows.Forms.Button btnAssignerLettreDansToutesLesCellules;
        private System.Windows.Forms.Button btnAssignerGDansToutesLesCellules;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAssigner12DansToutesLesCellules;
        private System.Windows.Forms.Button btnAugmenterDe1ToutesLesCellules;
        private System.Windows.Forms.Button btnCopierTableau1D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculerLaSommeDesValeurs;
        private VisualArrays.VisualCells.VisualInt vsiTotal;
        private System.Windows.Forms.Button btnCalculer;
    }
}

