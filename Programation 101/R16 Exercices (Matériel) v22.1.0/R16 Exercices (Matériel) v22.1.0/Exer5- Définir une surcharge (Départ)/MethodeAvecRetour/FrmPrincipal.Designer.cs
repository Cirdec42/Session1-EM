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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.btnSurcharge4Paramètres = new System.Windows.Forms.Button();
            this.btnEx3Min4Nombres = new System.Windows.Forms.Button();
            this.btnEx3Min3Nombres = new System.Windows.Forms.Button();
            this.btnEx3Min12Et25 = new System.Windows.Forms.Button();
            this.btnEx3Min2Nombres = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblExercice3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vsiRésultat = new VisualArrays.VisualCells.VisualInt();
            this.lblNombre4 = new System.Windows.Forms.Label();
            this.vsiNombre4 = new VisualArrays.VisualCells.VisualInt();
            this.vsiNombre3 = new VisualArrays.VisualCells.VisualInt();
            this.vsiNombre1 = new VisualArrays.VisualCells.VisualInt();
            this.lblNombre3 = new System.Windows.Forms.Label();
            this.vsiNombre2 = new VisualArrays.VisualCells.VisualInt();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.btnSurcharge3Paramètres = new System.Windows.Forms.Button();
            this.mnuPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(530, 24);
            this.mnuPrincipal.TabIndex = 7;
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
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(23, 30);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(56, 13);
            this.lblNombre1.TabIndex = 20;
            this.lblNombre1.Text = "Nombre1 :";
            // 
            // btnSurcharge4Paramètres
            // 
            this.btnSurcharge4Paramètres.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnSurcharge4Paramètres.Location = new System.Drawing.Point(23, 312);
            this.btnSurcharge4Paramètres.Name = "btnSurcharge4Paramètres";
            this.btnSurcharge4Paramètres.Size = new System.Drawing.Size(448, 31);
            this.btnSurcharge4Paramètres.TabIndex = 19;
            this.btnSurcharge4Paramètres.Text = "Surcharger la méthode Minimum pour qu\'elle accepte 4 nombres";
            this.btnSurcharge4Paramètres.UseVisualStyleBackColor = true;
            this.btnSurcharge4Paramètres.Click += new System.EventHandler(this.BtnSurcharge4Paramètres_Click);
            // 
            // btnEx3Min4Nombres
            // 
            this.btnEx3Min4Nombres.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnEx3Min4Nombres.Location = new System.Drawing.Point(23, 207);
            this.btnEx3Min4Nombres.Name = "btnEx3Min4Nombres";
            this.btnEx3Min4Nombres.Size = new System.Drawing.Size(448, 31);
            this.btnEx3Min4Nombres.TabIndex = 18;
            this.btnEx3Min4Nombres.Text = "Déterminer le minimum entre les 4 nombres";
            this.btnEx3Min4Nombres.UseVisualStyleBackColor = true;
            this.btnEx3Min4Nombres.Click += new System.EventHandler(this.BtnMinimumEntre4Nombres_Click);
            // 
            // btnEx3Min3Nombres
            // 
            this.btnEx3Min3Nombres.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnEx3Min3Nombres.Location = new System.Drawing.Point(23, 170);
            this.btnEx3Min3Nombres.Name = "btnEx3Min3Nombres";
            this.btnEx3Min3Nombres.Size = new System.Drawing.Size(448, 31);
            this.btnEx3Min3Nombres.TabIndex = 17;
            this.btnEx3Min3Nombres.Text = "Déterminer le minimum entre les 3 premiers nombres";
            this.btnEx3Min3Nombres.UseVisualStyleBackColor = true;
            this.btnEx3Min3Nombres.Click += new System.EventHandler(this.BtnMinimumEntre3Nombres_Click);
            // 
            // btnEx3Min12Et25
            // 
            this.btnEx3Min12Et25.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnEx3Min12Et25.Location = new System.Drawing.Point(23, 96);
            this.btnEx3Min12Et25.Name = "btnEx3Min12Et25";
            this.btnEx3Min12Et25.Size = new System.Drawing.Size(448, 31);
            this.btnEx3Min12Et25.TabIndex = 16;
            this.btnEx3Min12Et25.Text = "Déterminer la valeur minimum entre 12 et 25";
            this.btnEx3Min12Et25.UseVisualStyleBackColor = true;
            this.btnEx3Min12Et25.Click += new System.EventHandler(this.BtnMinimumEntre12Et25_Click);
            // 
            // btnEx3Min2Nombres
            // 
            this.btnEx3Min2Nombres.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnEx3Min2Nombres.Location = new System.Drawing.Point(23, 133);
            this.btnEx3Min2Nombres.Name = "btnEx3Min2Nombres";
            this.btnEx3Min2Nombres.Size = new System.Drawing.Size(448, 31);
            this.btnEx3Min2Nombres.TabIndex = 11;
            this.btnEx3Min2Nombres.Text = "Déterminer la valeur minimum entre le nombre 1 et le nombre 2";
            this.btnEx3Min2Nombres.UseVisualStyleBackColor = true;
            this.btnEx3Min2Nombres.Click += new System.EventHandler(this.BtnMinimumEntre2Nombres_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Résultat :";
            // 
            // lblExercice3
            // 
            this.lblExercice3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblExercice3.Location = new System.Drawing.Point(12, 38);
            this.lblExercice3.Name = "lblExercice3";
            this.lblExercice3.Size = new System.Drawing.Size(502, 24);
            this.lblExercice3.TabIndex = 8;
            this.lblExercice3.Text = "Imbriquer des appels et définir une surcharge";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSurcharge3Paramètres);
            this.groupBox1.Controls.Add(this.vsiRésultat);
            this.groupBox1.Controls.Add(this.lblNombre4);
            this.groupBox1.Controls.Add(this.vsiNombre4);
            this.groupBox1.Controls.Add(this.btnSurcharge4Paramètres);
            this.groupBox1.Controls.Add(this.lblNombre1);
            this.groupBox1.Controls.Add(this.vsiNombre3);
            this.groupBox1.Controls.Add(this.btnEx3Min4Nombres);
            this.groupBox1.Controls.Add(this.vsiNombre1);
            this.groupBox1.Controls.Add(this.btnEx3Min3Nombres);
            this.groupBox1.Controls.Add(this.lblNombre3);
            this.groupBox1.Controls.Add(this.btnEx3Min2Nombres);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnEx3Min12Et25);
            this.groupBox1.Controls.Add(this.vsiNombre2);
            this.groupBox1.Controls.Add(this.lblNombre2);
            this.groupBox1.Location = new System.Drawing.Point(15, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 365);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appeler une méthode plusieurs fois";
            // 
            // vsiRésultat
            // 
            this.vsiRésultat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vsiRésultat.FocusColor = System.Drawing.Color.Gray;
            this.vsiRésultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiRésultat.GraphAppearance.BarColor = System.Drawing.Color.Red;
            this.vsiRésultat.Location = new System.Drawing.Point(418, 46);
            this.vsiRésultat.Minimum = 0;
            this.vsiRésultat.Name = "vsiRésultat";
            this.vsiRésultat.ReadOnly = true;
            this.vsiRésultat.Size = new System.Drawing.Size(53, 34);
            this.vsiRésultat.TabIndex = 32;
            // 
            // lblNombre4
            // 
            this.lblNombre4.AutoSize = true;
            this.lblNombre4.Location = new System.Drawing.Point(200, 30);
            this.lblNombre4.Name = "lblNombre4";
            this.lblNombre4.Size = new System.Drawing.Size(56, 13);
            this.lblNombre4.TabIndex = 31;
            this.lblNombre4.Text = "Nombre4 :";
            // 
            // vsiNombre4
            // 
            this.vsiNombre4.BackColor = System.Drawing.Color.White;
            this.vsiNombre4.FocusColor = System.Drawing.Color.Gray;
            this.vsiNombre4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNombre4.GraphAppearance.BarColor = System.Drawing.Color.Red;
            this.vsiNombre4.Location = new System.Drawing.Point(201, 46);
            this.vsiNombre4.Minimum = 0;
            this.vsiNombre4.Name = "vsiNombre4";
            this.vsiNombre4.Size = new System.Drawing.Size(53, 34);
            this.vsiNombre4.TabIndex = 30;
            this.vsiNombre4.Value = 3;
            // 
            // vsiNombre3
            // 
            this.vsiNombre3.BackColor = System.Drawing.Color.White;
            this.vsiNombre3.FocusColor = System.Drawing.Color.Gray;
            this.vsiNombre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNombre3.GraphAppearance.BarColor = System.Drawing.Color.Red;
            this.vsiNombre3.Location = new System.Drawing.Point(142, 46);
            this.vsiNombre3.Minimum = 0;
            this.vsiNombre3.Name = "vsiNombre3";
            this.vsiNombre3.Size = new System.Drawing.Size(53, 34);
            this.vsiNombre3.TabIndex = 29;
            this.vsiNombre3.Value = 5;
            // 
            // vsiNombre1
            // 
            this.vsiNombre1.BackColor = System.Drawing.Color.White;
            this.vsiNombre1.FocusColor = System.Drawing.Color.Gray;
            this.vsiNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNombre1.GraphAppearance.BarColor = System.Drawing.Color.Red;
            this.vsiNombre1.Location = new System.Drawing.Point(24, 46);
            this.vsiNombre1.Minimum = 0;
            this.vsiNombre1.Name = "vsiNombre1";
            this.vsiNombre1.Size = new System.Drawing.Size(53, 34);
            this.vsiNombre1.TabIndex = 25;
            this.vsiNombre1.Value = 16;
            // 
            // lblNombre3
            // 
            this.lblNombre3.AutoSize = true;
            this.lblNombre3.Location = new System.Drawing.Point(141, 30);
            this.lblNombre3.Name = "lblNombre3";
            this.lblNombre3.Size = new System.Drawing.Size(56, 13);
            this.lblNombre3.TabIndex = 28;
            this.lblNombre3.Text = "Nombre3 :";
            // 
            // vsiNombre2
            // 
            this.vsiNombre2.BackColor = System.Drawing.Color.White;
            this.vsiNombre2.FocusColor = System.Drawing.Color.Gray;
            this.vsiNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNombre2.GraphAppearance.BarColor = System.Drawing.Color.Red;
            this.vsiNombre2.Location = new System.Drawing.Point(83, 46);
            this.vsiNombre2.Minimum = 0;
            this.vsiNombre2.Name = "vsiNombre2";
            this.vsiNombre2.Size = new System.Drawing.Size(53, 34);
            this.vsiNombre2.TabIndex = 26;
            this.vsiNombre2.Value = 9;
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(82, 30);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(56, 13);
            this.lblNombre2.TabIndex = 27;
            this.lblNombre2.Text = "Nombre2 :";
            // 
            // btnSurcharge3Paramètres
            // 
            this.btnSurcharge3Paramètres.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnSurcharge3Paramètres.Location = new System.Drawing.Point(23, 275);
            this.btnSurcharge3Paramètres.Name = "btnSurcharge3Paramètres";
            this.btnSurcharge3Paramètres.Size = new System.Drawing.Size(448, 31);
            this.btnSurcharge3Paramètres.TabIndex = 33;
            this.btnSurcharge3Paramètres.Text = "Surcharger la méthode Minimum pour qu\'elle accepte 3 nombres";
            this.btnSurcharge3Paramètres.UseVisualStyleBackColor = true;
            this.btnSurcharge3Paramètres.Click += new System.EventHandler(this.BtnSurcharge3Paramètres_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblExercice3);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imbriquer des appels et définir une surcharge ";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Button btnSurcharge4Paramètres;
        private System.Windows.Forms.Button btnEx3Min4Nombres;
        private System.Windows.Forms.Button btnEx3Min3Nombres;
        private System.Windows.Forms.Button btnEx3Min12Et25;
        private System.Windows.Forms.Button btnEx3Min2Nombres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblExercice3;
        private System.Windows.Forms.GroupBox groupBox1;
        public VisualArrays.VisualCells.VisualInt vsiNombre1;
        public VisualArrays.VisualCells.VisualInt vsiNombre2;
        private System.Windows.Forms.Label lblNombre2;
        public VisualArrays.VisualCells.VisualInt vsiRésultat;
        private System.Windows.Forms.Label lblNombre4;
        public VisualArrays.VisualCells.VisualInt vsiNombre4;
        public VisualArrays.VisualCells.VisualInt vsiNombre3;
        private System.Windows.Forms.Label lblNombre3;
        private System.Windows.Forms.Button btnSurcharge3Paramètres;
    }
}

