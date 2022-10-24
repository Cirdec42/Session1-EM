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
            this.lblExercice2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEx2PcEnCt = new System.Windows.Forms.Button();
            this.btnEx2CelEnFah = new System.Windows.Forms.Button();
            this.btnEx2LbEnKl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numResultat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numNombre = new System.Windows.Forms.NumericUpDown();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.vsbAnnéeBissextile = new VisualArrays.VisualCells.VisualBool();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vsbAnnéePaire = new VisualArrays.VisualCells.VisualBool();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vsiAnnée = new VisualArrays.VisualCells.VisualInt();
            this.lblUnitéSource = new System.Windows.Forms.Label();
            this.lblUnitéFinale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numResultat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNombre)).BeginInit();
            this.mnuPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExercice2
            // 
            this.lblExercice2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblExercice2.Location = new System.Drawing.Point(12, 36);
            this.lblExercice2.Name = "lblExercice2";
            this.lblExercice2.Size = new System.Drawing.Size(477, 24);
            this.lblExercice2.TabIndex = 0;
            this.lblExercice2.Text = "Définir et utiliser des méthodes qui retournent un résultat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(416, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Année bissextile :";
            // 
            // btnEx2PcEnCt
            // 
            this.btnEx2PcEnCt.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnEx2PcEnCt.Location = new System.Drawing.Point(19, 159);
            this.btnEx2PcEnCt.Name = "btnEx2PcEnCt";
            this.btnEx2PcEnCt.Size = new System.Drawing.Size(543, 31);
            this.btnEx2PcEnCt.TabIndex = 11;
            this.btnEx2PcEnCt.Text = "Convertir le nombre de : pouces en centimètres";
            this.btnEx2PcEnCt.UseVisualStyleBackColor = true;
            this.btnEx2PcEnCt.Click += new System.EventHandler(this.BtnPoucesEnCentimètres_Click);
            // 
            // btnEx2CelEnFah
            // 
            this.btnEx2CelEnFah.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnEx2CelEnFah.Location = new System.Drawing.Point(19, 122);
            this.btnEx2CelEnFah.Name = "btnEx2CelEnFah";
            this.btnEx2CelEnFah.Size = new System.Drawing.Size(543, 31);
            this.btnEx2CelEnFah.TabIndex = 10;
            this.btnEx2CelEnFah.Text = "Convertir le nombre de : celsius en fahrenheit";
            this.btnEx2CelEnFah.UseVisualStyleBackColor = true;
            this.btnEx2CelEnFah.Click += new System.EventHandler(this.BtnCelsiusEnFahrenheit_Click);
            // 
            // btnEx2LbEnKl
            // 
            this.btnEx2LbEnKl.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnEx2LbEnKl.Location = new System.Drawing.Point(19, 85);
            this.btnEx2LbEnKl.Name = "btnEx2LbEnKl";
            this.btnEx2LbEnKl.Size = new System.Drawing.Size(543, 31);
            this.btnEx2LbEnKl.TabIndex = 9;
            this.btnEx2LbEnKl.Text = "Convertir le nombre de : livres en kilos";
            this.btnEx2LbEnKl.UseVisualStyleBackColor = true;
            this.btnEx2LbEnKl.Click += new System.EventHandler(this.BtnLivresEnKilos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(337, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Résultat :";
            // 
            // numResultat
            // 
            this.numResultat.DecimalPlaces = 3;
            this.numResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numResultat.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numResultat.Location = new System.Drawing.Point(435, 44);
            this.numResultat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numResultat.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numResultat.Name = "numResultat";
            this.numResultat.ReadOnly = true;
            this.numResultat.Size = new System.Drawing.Size(127, 26);
            this.numResultat.TabIndex = 7;
            this.numResultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre à saisir :";
            // 
            // numNombre
            // 
            this.numNombre.DecimalPlaces = 1;
            this.numNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNombre.Location = new System.Drawing.Point(162, 44);
            this.numNombre.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNombre.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numNombre.Name = "numNombre";
            this.numNombre.Size = new System.Drawing.Size(127, 26);
            this.numNombre.TabIndex = 5;
            this.numNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNombre.Value = new decimal(new int[] {
            405,
            0,
            0,
            65536});
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(612, 24);
            this.mnuPrincipal.TabIndex = 6;
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
            // vsbAnnéeBissextile
            // 
            this.vsbAnnéeBissextile.FocusColor = System.Drawing.Color.Gray;
            this.vsbAnnéeBissextile.Location = new System.Drawing.Point(419, 40);
            this.vsbAnnéeBissextile.Name = "vsbAnnéeBissextile";
            this.vsbAnnéeBissextile.ReadOnly = true;
            this.vsbAnnéeBissextile.Size = new System.Drawing.Size(103, 141);
            this.vsbAnnéeBissextile.TabIndex = 17;
            this.vsbAnnéeBissextile.Toggle = false;
            this.vsbAnnéeBissextile.ValueAppearance.False.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.vsbAnnéeBissextile.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbAnnéeBissextile.ValueAppearance.True.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.vsbAnnéeBissextile.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUnitéFinale);
            this.groupBox1.Controls.Add(this.lblUnitéSource);
            this.groupBox1.Controls.Add(this.btnEx2PcEnCt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numResultat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnEx2CelEnFah);
            this.groupBox1.Controls.Add(this.numNombre);
            this.groupBox1.Controls.Add(this.btnEx2LbEnKl);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 211);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trois méthodes de conversions d\'unités";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vsiAnnée);
            this.groupBox2.Controls.Add(this.vsbAnnéePaire);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.vsbAnnéeBissextile);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 193);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Méthodes qui produisent un résultat booléen";
            // 
            // vsbAnnéePaire
            // 
            this.vsbAnnéePaire.FocusColor = System.Drawing.Color.Gray;
            this.vsbAnnéePaire.Location = new System.Drawing.Point(59, 40);
            this.vsbAnnéePaire.Name = "vsbAnnéePaire";
            this.vsbAnnéePaire.ReadOnly = true;
            this.vsbAnnéePaire.Size = new System.Drawing.Size(103, 141);
            this.vsbAnnéePaire.TabIndex = 19;
            this.vsbAnnéePaire.Toggle = false;
            this.vsbAnnéePaire.ValueAppearance.False.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.vsbAnnéePaire.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbAnnéePaire.ValueAppearance.True.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.vsbAnnéePaire.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Année paire :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(233, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Année à saisir :";
            // 
            // vsiAnnée
            // 
            this.vsiAnnée.BackColor = System.Drawing.Color.White;
            this.vsiAnnée.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiAnnée.GraphAppearance.BarColor = System.Drawing.Color.Red;
            this.vsiAnnée.Location = new System.Drawing.Point(230, 88);
            this.vsiAnnée.Maximum = 2200;
            this.vsiAnnée.Minimum = 0;
            this.vsiAnnée.Name = "vsiAnnée";
            this.vsiAnnée.Size = new System.Drawing.Size(120, 52);
            this.vsiAnnée.TabIndex = 20;
            this.vsiAnnée.Value = 2021;
            this.vsiAnnée.ValueChanged += new System.EventHandler(this.VsiAnnée_ValueChanged);
            // 
            // lblUnitéSource
            // 
            this.lblUnitéSource.BackColor = System.Drawing.Color.LightBlue;
            this.lblUnitéSource.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitéSource.Location = new System.Drawing.Point(162, 25);
            this.lblUnitéSource.Name = "lblUnitéSource";
            this.lblUnitéSource.Size = new System.Drawing.Size(127, 16);
            this.lblUnitéSource.TabIndex = 12;
            this.lblUnitéSource.Text = "Unité source";
            this.lblUnitéSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnitéFinale
            // 
            this.lblUnitéFinale.BackColor = System.Drawing.Color.LightBlue;
            this.lblUnitéFinale.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitéFinale.Location = new System.Drawing.Point(435, 25);
            this.lblUnitéFinale.Name = "lblUnitéFinale";
            this.lblUnitéFinale.Size = new System.Drawing.Size(127, 16);
            this.lblUnitéFinale.TabIndex = 13;
            this.lblUnitéFinale.Text = "Unité finale";
            this.lblUnitéFinale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblExercice2);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Définir et utiliser des méthodes qui produisent un résultat ";
            ((System.ComponentModel.ISupportInitialize)(this.numResultat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNombre)).EndInit();
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblExercice2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEx2PcEnCt;
        private System.Windows.Forms.Button btnEx2CelEnFah;
        private System.Windows.Forms.Button btnEx2LbEnKl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numResultat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numNombre;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private VisualArrays.VisualCells.VisualBool vsbAnnéeBissextile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private VisualArrays.VisualCells.VisualBool vsbAnnéePaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        public VisualArrays.VisualCells.VisualInt vsiAnnée;
        private System.Windows.Forms.Label lblUnitéFinale;
        private System.Windows.Forms.Label lblUnitéSource;
    }
}

