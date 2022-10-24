namespace MethodeAvecRetour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnSélectionnerMinimum = new System.Windows.Forms.Button();
            this.btnMinimum = new System.Windows.Forms.Button();
            this.btnMoyenne = new System.Windows.Forms.Button();
            this.btnEx5PlacerNbrAléatoires = new System.Windows.Forms.Button();
            this.lblRésultat = new System.Windows.Forms.Label();
            this.viaNombres = new VisualArrays.VisualIntArray();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.vsbValeurÀTrouver = new VisualArrays.VisualCells.VisualBool();
            this.lblExercice5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblÀTrouver = new System.Windows.Forms.Label();
            this.btnSupérieureMoyenne = new System.Windows.Forms.Button();
            this.vsiValeurÀTrouver = new VisualArrays.VisualCells.VisualInt();
            this.vsiRésultat = new VisualArrays.VisualCells.VisualInt();
            this.btnMaximum = new System.Windows.Forms.Button();
            this.btnSomme = new System.Windows.Forms.Button();
            this.btnSélectionnerMaximum = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSélectionnerValeurÀTrouver = new System.Windows.Forms.Button();
            this.mnuPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSélectionnerMinimum
            // 
            this.btnSélectionnerMinimum.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnSélectionnerMinimum.Location = new System.Drawing.Point(11, 35);
            this.btnSélectionnerMinimum.Name = "btnSélectionnerMinimum";
            this.btnSélectionnerMinimum.Size = new System.Drawing.Size(351, 31);
            this.btnSélectionnerMinimum.TabIndex = 20;
            this.btnSélectionnerMinimum.Text = "Sélectionner la plus petite valeur dans la grille";
            this.btnSélectionnerMinimum.UseVisualStyleBackColor = true;
            this.btnSélectionnerMinimum.Click += new System.EventHandler(this.BtnSélectionnerMinimum_Click);
            // 
            // btnMinimum
            // 
            this.btnMinimum.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnMinimum.Location = new System.Drawing.Point(11, 213);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(548, 31);
            this.btnMinimum.TabIndex = 19;
            this.btnMinimum.Text = "Déterminer la valeur minimale dans une méthode qui produit un résultat";
            this.btnMinimum.UseVisualStyleBackColor = true;
            this.btnMinimum.Click += new System.EventHandler(this.BtnMinimum_Click);
            // 
            // btnMoyenne
            // 
            this.btnMoyenne.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnMoyenne.Location = new System.Drawing.Point(11, 176);
            this.btnMoyenne.Name = "btnMoyenne";
            this.btnMoyenne.Size = new System.Drawing.Size(548, 31);
            this.btnMoyenne.TabIndex = 18;
            this.btnMoyenne.Text = "Calculer la moyenne des nombres dans une méthode qui produit un résultat";
            this.btnMoyenne.UseVisualStyleBackColor = true;
            this.btnMoyenne.Click += new System.EventHandler(this.BtnMoyenne_Click);
            // 
            // btnEx5PlacerNbrAléatoires
            // 
            this.btnEx5PlacerNbrAléatoires.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnEx5PlacerNbrAléatoires.Location = new System.Drawing.Point(11, 24);
            this.btnEx5PlacerNbrAléatoires.Name = "btnEx5PlacerNbrAléatoires";
            this.btnEx5PlacerNbrAléatoires.Size = new System.Drawing.Size(296, 31);
            this.btnEx5PlacerNbrAléatoires.TabIndex = 17;
            this.btnEx5PlacerNbrAléatoires.Text = "Placer des nombres aléatoires dans la grille";
            this.btnEx5PlacerNbrAléatoires.UseVisualStyleBackColor = true;
            this.btnEx5PlacerNbrAléatoires.Click += new System.EventHandler(this.BtnPlacerNbrAléatoires_Click);
            // 
            // lblRésultat
            // 
            this.lblRésultat.AutoSize = true;
            this.lblRésultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRésultat.Location = new System.Drawing.Point(517, 30);
            this.lblRésultat.Name = "lblRésultat";
            this.lblRésultat.Size = new System.Drawing.Size(77, 20);
            this.lblRésultat.TabIndex = 12;
            this.lblRésultat.Text = "Résultat :";
            // 
            // viaNombres
            // 
            this.viaNombres.BackColor = System.Drawing.Color.Black;
            this.viaNombres.CellSize = new System.Drawing.Size(42, 35);
            this.viaNombres.ColumnCount = 14;
            this.viaNombres.DisabledAppearance.TextColor = System.Drawing.Color.Silver;
            this.viaNombres.Location = new System.Drawing.Point(11, 61);
            this.viaNombres.Minimum = 0;
            this.viaNombres.Name = "viaNombres";
            this.viaNombres.RowCount = 1;
            this.viaNombres.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaNombres.SelectionAppearance.Color = System.Drawing.Color.Lime;
            this.viaNombres.SelectionMode = System.Windows.Forms.SelectionMode.One;
            this.viaNombres.Size = new System.Drawing.Size(671, 53);
            this.viaNombres.SpecialValueAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viaNombres.SpecialValueAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.viaNombres.TabIndex = 1;
            this.viaNombres.Text = "visualIntArray1";
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(724, 24);
            this.mnuPrincipal.TabIndex = 5;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.MnuFichierQuitter_Click);
            // 
            // vsbValeurÀTrouver
            // 
            this.vsbValeurÀTrouver.FocusColor = System.Drawing.Color.Gray;
            this.vsbValeurÀTrouver.Location = new System.Drawing.Point(600, 195);
            this.vsbValeurÀTrouver.Name = "vsbValeurÀTrouver";
            this.vsbValeurÀTrouver.ReadOnly = true;
            this.vsbValeurÀTrouver.Size = new System.Drawing.Size(82, 123);
            this.vsbValeurÀTrouver.TabIndex = 6;
            this.vsbValeurÀTrouver.Toggle = false;
            this.vsbValeurÀTrouver.ValueAppearance.False.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.vsbValeurÀTrouver.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbValeurÀTrouver.ValueAppearance.True.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.vsbValeurÀTrouver.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // lblExercice5
            // 
            this.lblExercice5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblExercice5.Location = new System.Drawing.Point(12, 35);
            this.lblExercice5.Name = "lblExercice5";
            this.lblExercice5.Size = new System.Drawing.Size(484, 24);
            this.lblExercice5.TabIndex = 4;
            this.lblExercice5.Text = "Produire un résultat à partir d\'une grille de nombres entiers";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblÀTrouver);
            this.groupBox1.Controls.Add(this.btnSupérieureMoyenne);
            this.groupBox1.Controls.Add(this.vsbValeurÀTrouver);
            this.groupBox1.Controls.Add(this.vsiValeurÀTrouver);
            this.groupBox1.Controls.Add(this.vsiRésultat);
            this.groupBox1.Controls.Add(this.btnMaximum);
            this.groupBox1.Controls.Add(this.btnSomme);
            this.groupBox1.Controls.Add(this.viaNombres);
            this.groupBox1.Controls.Add(this.btnEx5PlacerNbrAléatoires);
            this.groupBox1.Controls.Add(this.lblRésultat);
            this.groupBox1.Controls.Add(this.btnMoyenne);
            this.groupBox1.Controls.Add(this.btnMinimum);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 341);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // lblÀTrouver
            // 
            this.lblÀTrouver.AutoSize = true;
            this.lblÀTrouver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÀTrouver.Location = new System.Drawing.Point(601, 135);
            this.lblÀTrouver.Name = "lblÀTrouver";
            this.lblÀTrouver.Size = new System.Drawing.Size(81, 20);
            this.lblÀTrouver.TabIndex = 28;
            this.lblÀTrouver.Text = "À trouver :";
            // 
            // btnSupérieureMoyenne
            // 
            this.btnSupérieureMoyenne.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnSupérieureMoyenne.Location = new System.Drawing.Point(11, 287);
            this.btnSupérieureMoyenne.Name = "btnSupérieureMoyenne";
            this.btnSupérieureMoyenne.Size = new System.Drawing.Size(548, 31);
            this.btnSupérieureMoyenne.TabIndex = 26;
            this.btnSupérieureMoyenne.Text = "Déterminer le nombre de valeurs supérieures à la moyenne";
            this.btnSupérieureMoyenne.UseVisualStyleBackColor = true;
            this.btnSupérieureMoyenne.Click += new System.EventHandler(this.BtnSupérieureMoyenne_Click);
            // 
            // vsiValeurÀTrouver
            // 
            this.vsiValeurÀTrouver.BackColor = System.Drawing.Color.White;
            this.vsiValeurÀTrouver.FocusColor = System.Drawing.Color.Gray;
            this.vsiValeurÀTrouver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiValeurÀTrouver.GraphAppearance.BarColor = System.Drawing.Color.Red;
            this.vsiValeurÀTrouver.Location = new System.Drawing.Point(600, 158);
            this.vsiValeurÀTrouver.Minimum = 0;
            this.vsiValeurÀTrouver.Name = "vsiValeurÀTrouver";
            this.vsiValeurÀTrouver.Size = new System.Drawing.Size(82, 31);
            this.vsiValeurÀTrouver.TabIndex = 27;
            this.vsiValeurÀTrouver.ValueChanged += new System.EventHandler(this.VsiValeurRecherchée_ValueChanged);
            // 
            // vsiRésultat
            // 
            this.vsiRésultat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vsiRésultat.FocusColor = System.Drawing.Color.Gray;
            this.vsiRésultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiRésultat.GraphAppearance.BarColor = System.Drawing.Color.Red;
            this.vsiRésultat.Location = new System.Drawing.Point(600, 23);
            this.vsiRésultat.Maximum = 10000;
            this.vsiRésultat.Minimum = 0;
            this.vsiRésultat.Name = "vsiRésultat";
            this.vsiRésultat.ReadOnly = true;
            this.vsiRésultat.Size = new System.Drawing.Size(82, 31);
            this.vsiRésultat.TabIndex = 24;
            // 
            // btnMaximum
            // 
            this.btnMaximum.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnMaximum.Location = new System.Drawing.Point(11, 250);
            this.btnMaximum.Name = "btnMaximum";
            this.btnMaximum.Size = new System.Drawing.Size(548, 31);
            this.btnMaximum.TabIndex = 23;
            this.btnMaximum.Text = "Déterminer la valeur maximale dans une méthode qui produit un résultat";
            this.btnMaximum.UseVisualStyleBackColor = true;
            this.btnMaximum.Click += new System.EventHandler(this.BtnMaximum_Click);
            // 
            // btnSomme
            // 
            this.btnSomme.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnSomme.Location = new System.Drawing.Point(11, 139);
            this.btnSomme.Name = "btnSomme";
            this.btnSomme.Size = new System.Drawing.Size(548, 31);
            this.btnSomme.TabIndex = 22;
            this.btnSomme.Text = "Calculer la somme des nombres dans une méthode qui produit un résultat";
            this.btnSomme.UseVisualStyleBackColor = true;
            this.btnSomme.Click += new System.EventHandler(this.BtnSomme_Click);
            // 
            // btnSélectionnerMaximum
            // 
            this.btnSélectionnerMaximum.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnSélectionnerMaximum.Location = new System.Drawing.Point(11, 72);
            this.btnSélectionnerMaximum.Name = "btnSélectionnerMaximum";
            this.btnSélectionnerMaximum.Size = new System.Drawing.Size(351, 31);
            this.btnSélectionnerMaximum.TabIndex = 25;
            this.btnSélectionnerMaximum.Text = "Sélectionner la plus grande valeur dans la grille";
            this.btnSélectionnerMaximum.UseVisualStyleBackColor = true;
            this.btnSélectionnerMaximum.Click += new System.EventHandler(this.BtnSélectionnerMaximum_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSélectionnerValeurÀTrouver);
            this.groupBox2.Controls.Add(this.btnSélectionnerMinimum);
            this.groupBox2.Controls.Add(this.btnSélectionnerMaximum);
            this.groupBox2.Location = new System.Drawing.Point(12, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 120);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Utiliser les méthodes qui produisent un résultat";
            // 
            // btnSélectionnerValeurÀTrouver
            // 
            this.btnSélectionnerValeurÀTrouver.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnSélectionnerValeurÀTrouver.Location = new System.Drawing.Point(387, 35);
            this.btnSélectionnerValeurÀTrouver.Name = "btnSélectionnerValeurÀTrouver";
            this.btnSélectionnerValeurÀTrouver.Size = new System.Drawing.Size(296, 68);
            this.btnSélectionnerValeurÀTrouver.TabIndex = 26;
            this.btnSélectionnerValeurÀTrouver.Text = "Sélectionner dans la grille la valeur à trouver (ou rien si non trouvée)";
            this.btnSélectionnerValeurÀTrouver.UseVisualStyleBackColor = true;
            this.btnSélectionnerValeurÀTrouver.Click += new System.EventHandler(this.BtnSélectionnerValeurÀTrouver_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.lblExercice5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produire un résultat à partir d\'une grille ";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEx5PlacerNbrAléatoires;
        private System.Windows.Forms.Label lblRésultat;
        private VisualArrays.VisualIntArray viaNombres;
        private System.Windows.Forms.Button btnMoyenne;
        private System.Windows.Forms.Button btnMinimum;
        private System.Windows.Forms.Button btnSélectionnerMinimum;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private VisualArrays.VisualCells.VisualBool vsbValeurÀTrouver;
        private System.Windows.Forms.Label lblExercice5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMaximum;
        private System.Windows.Forms.Button btnSomme;
        public VisualArrays.VisualCells.VisualInt vsiRésultat;
        private System.Windows.Forms.Button btnSélectionnerMaximum;
        private System.Windows.Forms.Button btnSupérieureMoyenne;
        private System.Windows.Forms.Label lblÀTrouver;
        public VisualArrays.VisualCells.VisualInt vsiValeurÀTrouver;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSélectionnerValeurÀTrouver;
    }
}

