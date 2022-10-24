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
            this.btnToUpper = new System.Windows.Forms.Button();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTexte = new System.Windows.Forms.TextBox();
            this.btnMathCeiling = new System.Windows.Forms.Button();
            this.btnMathFloor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numResultat = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numNombre = new System.Windows.Forms.NumericUpDown();
            this.btnMathAbs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblExercice1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnToLower = new System.Windows.Forms.Button();
            this.mnuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResultat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNombre)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(915, 33);
            this.mnuPrincipal.TabIndex = 6;
            this.mnuPrincipal.Text = "menuStrip1";
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
            this.mnuFichierQuitter.Click += new System.EventHandler(this.MnuFichierQuitter_Click);
            // 
            // btnToUpper
            // 
            this.btnToUpper.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnToUpper.Location = new System.Drawing.Point(22, 102);
            this.btnToUpper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(814, 48);
            this.btnToUpper.TabIndex = 10;
            this.btnToUpper.Text = "Transformer le texte en lettres majuscules (ToUpper)";
            this.btnToUpper.UseVisualStyleBackColor = true;
            this.btnToUpper.Click += new System.EventHandler(this.BtnToUpper_Click);
            // 
            // txtResultat
            // 
            this.txtResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultat.Location = new System.Drawing.Point(538, 48);
            this.txtResultat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.ReadOnly = true;
            this.txtResultat.Size = new System.Drawing.Size(296, 35);
            this.txtResultat.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Résultat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Texte :";
            // 
            // txtTexte
            // 
            this.txtTexte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexte.Location = new System.Drawing.Point(114, 48);
            this.txtTexte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTexte.Name = "txtTexte";
            this.txtTexte.Size = new System.Drawing.Size(283, 35);
            this.txtTexte.TabIndex = 2;
            this.txtTexte.Text = "Premier Plan Maison";
            // 
            // btnMathCeiling
            // 
            this.btnMathCeiling.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnMathCeiling.Location = new System.Drawing.Point(22, 197);
            this.btnMathCeiling.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMathCeiling.Name = "btnMathCeiling";
            this.btnMathCeiling.Size = new System.Drawing.Size(814, 48);
            this.btnMathCeiling.TabIndex = 6;
            this.btnMathCeiling.Text = "Calculer et afficher le plafond du nombre (Ceiling)";
            this.btnMathCeiling.UseVisualStyleBackColor = true;
            this.btnMathCeiling.Click += new System.EventHandler(this.BtnMathCeiling_Click);
            // 
            // btnMathFloor
            // 
            this.btnMathFloor.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnMathFloor.Location = new System.Drawing.Point(22, 140);
            this.btnMathFloor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMathFloor.Name = "btnMathFloor";
            this.btnMathFloor.Size = new System.Drawing.Size(814, 48);
            this.btnMathFloor.TabIndex = 5;
            this.btnMathFloor.Text = "Calculer et afficher le plancher du nombre (Floor)";
            this.btnMathFloor.UseVisualStyleBackColor = true;
            this.btnMathFloor.Click += new System.EventHandler(this.BtnMathFloor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Résultat :";
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
            this.numResultat.Location = new System.Drawing.Point(646, 34);
            this.numResultat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numResultat.Size = new System.Drawing.Size(190, 35);
            this.numResultat.TabIndex = 3;
            this.numResultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre à saisir :";
            // 
            // numNombre
            // 
            this.numNombre.DecimalPlaces = 3;
            this.numNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNombre.Location = new System.Drawing.Point(219, 34);
            this.numNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numNombre.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numNombre.Name = "numNombre";
            this.numNombre.Size = new System.Drawing.Size(190, 35);
            this.numNombre.TabIndex = 1;
            this.numNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNombre.Value = new decimal(new int[] {
            12345,
            0,
            0,
            196608});
            // 
            // btnMathAbs
            // 
            this.btnMathAbs.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnMathAbs.Location = new System.Drawing.Point(22, 83);
            this.btnMathAbs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMathAbs.Name = "btnMathAbs";
            this.btnMathAbs.Size = new System.Drawing.Size(814, 48);
            this.btnMathAbs.TabIndex = 0;
            this.btnMathAbs.Text = "Calculer et afficher le valeur arrondie du nombre (Round)";
            this.btnMathAbs.UseVisualStyleBackColor = true;
            this.btnMathAbs.Click += new System.EventHandler(this.BtnMathAbs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMathCeiling);
            this.groupBox1.Controls.Add(this.btnMathAbs);
            this.groupBox1.Controls.Add(this.numNombre);
            this.groupBox1.Controls.Add(this.btnMathFloor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numResultat);
            this.groupBox1.Location = new System.Drawing.Point(26, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(864, 271);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classe Math";
            // 
            // lblExercice1
            // 
            this.lblExercice1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblExercice1.Location = new System.Drawing.Point(21, 60);
            this.lblExercice1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExercice1.Name = "lblExercice1";
            this.lblExercice1.Size = new System.Drawing.Size(854, 37);
            this.lblExercice1.TabIndex = 24;
            this.lblExercice1.Text = "Méthodes pré-définies qui produisent un résultat";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnToLower);
            this.groupBox2.Controls.Add(this.btnToUpper);
            this.groupBox2.Controls.Add(this.txtTexte);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtResultat);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(26, 403);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(864, 226);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autres méthodes qui retournent un résultat";
            // 
            // btnToLower
            // 
            this.btnToLower.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.btnToLower.Location = new System.Drawing.Point(22, 158);
            this.btnToLower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToLower.Name = "btnToLower";
            this.btnToLower.Size = new System.Drawing.Size(814, 48);
            this.btnToLower.TabIndex = 11;
            this.btnToLower.Text = "Transformer le texte en lettres minuscules (ToLower)";
            this.btnToLower.UseVisualStyleBackColor = true;
            this.btnToLower.Click += new System.EventHandler(this.BtnToLower_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 654);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblExercice1);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Méthodes pré-définies avec valeur de retour ";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResultat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNombre)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.Button btnToUpper;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTexte;
        private System.Windows.Forms.Button btnMathCeiling;
        private System.Windows.Forms.Button btnMathFloor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numResultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numNombre;
        private System.Windows.Forms.Button btnMathAbs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblExercice1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnToLower;
    }
}

