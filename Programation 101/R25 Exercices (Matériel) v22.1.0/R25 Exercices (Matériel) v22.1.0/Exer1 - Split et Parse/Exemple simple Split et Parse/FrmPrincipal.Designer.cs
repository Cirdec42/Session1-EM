namespace Exemple_simple_Split_et_Parse
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreEntier = new System.Windows.Forms.TextBox();
            this.btnConvertirEnInt = new System.Windows.Forms.Button();
            this.vsiNombre1 = new VisualArrays.VisualCells.VisualInt();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvertirEnDecimal = new System.Windows.Forms.Button();
            this.numNombre = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAjouter100AuTextBox = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.vsiNombre2 = new VisualArrays.VisualCells.VisualInt();
            this.btnAjouter100 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.viaNombres = new VisualArrays.VisualIntArray();
            this.btnPlacerDansLaGrilleDeNombres = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtListeDeNombres = new System.Windows.Forms.TextBox();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numNombre)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre dans un textbox:";
            // 
            // txtNombreEntier
            // 
            this.txtNombreEntier.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEntier.Location = new System.Drawing.Point(39, 83);
            this.txtNombreEntier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreEntier.Name = "txtNombreEntier";
            this.txtNombreEntier.Size = new System.Drawing.Size(181, 44);
            this.txtNombreEntier.TabIndex = 1;
            this.txtNombreEntier.Text = "1234";
            this.txtNombreEntier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNombreEntier.TextChanged += new System.EventHandler(this.txtNombreEntier_TextChanged);
            // 
            // btnConvertirEnInt
            // 
            this.btnConvertirEnInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirEnInt.Location = new System.Drawing.Point(268, 29);
            this.btnConvertirEnInt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvertirEnInt.Name = "btnConvertirEnInt";
            this.btnConvertirEnInt.Size = new System.Drawing.Size(298, 46);
            this.btnConvertirEnInt.TabIndex = 2;
            this.btnConvertirEnInt.Text = "Convertir en int";
            this.btnConvertirEnInt.UseVisualStyleBackColor = true;
            this.btnConvertirEnInt.Click += new System.EventHandler(this.btnConvertirEnInt_Click);
            // 
            // vsiNombre1
            // 
            this.vsiNombre1.FocusColor = System.Drawing.Color.Gray;
            this.vsiNombre1.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.vsiNombre1.Location = new System.Drawing.Point(592, 29);
            this.vsiNombre1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vsiNombre1.Maximum = 999999;
            this.vsiNombre1.Minimum = -999999;
            this.vsiNombre1.Name = "vsiNombre1";
            this.vsiNombre1.Size = new System.Drawing.Size(111, 46);
            this.vsiNombre1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "VisualInt";
            // 
            // btnConvertirEnDecimal
            // 
            this.btnConvertirEnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirEnDecimal.Location = new System.Drawing.Point(268, 85);
            this.btnConvertirEnDecimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvertirEnDecimal.Name = "btnConvertirEnDecimal";
            this.btnConvertirEnDecimal.Size = new System.Drawing.Size(298, 46);
            this.btnConvertirEnDecimal.TabIndex = 3;
            this.btnConvertirEnDecimal.Text = "Convertir en Decimal";
            this.btnConvertirEnDecimal.UseVisualStyleBackColor = true;
            this.btnConvertirEnDecimal.Click += new System.EventHandler(this.btnConvertirEnDecimal_Click);
            // 
            // numNombre
            // 
            this.numNombre.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.numNombre.Location = new System.Drawing.Point(592, 82);
            this.numNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numNombre.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numNombre.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numNombre.Name = "numNombre";
            this.numNombre.Size = new System.Drawing.Size(130, 44);
            this.numNombre.TabIndex = 9;
            this.numNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(732, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "NumericUpDown";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAjouter100AuTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.vsiNombre2);
            this.groupBox1.Controls.Add(this.btnAjouter100);
            this.groupBox1.Controls.Add(this.numNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreEntier);
            this.groupBox1.Controls.Add(this.btnConvertirEnDecimal);
            this.groupBox1.Controls.Add(this.btnConvertirEnInt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.vsiNombre1);
            this.groupBox1.Location = new System.Drawing.Point(40, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(921, 257);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utilisation de la méthode Parse";
            // 
            // btnAjouter100AuTextBox
            // 
            this.btnAjouter100AuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter100AuTextBox.Location = new System.Drawing.Point(268, 195);
            this.btnAjouter100AuTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjouter100AuTextBox.Name = "btnAjouter100AuTextBox";
            this.btnAjouter100AuTextBox.Size = new System.Drawing.Size(298, 46);
            this.btnAjouter100AuTextBox.TabIndex = 5;
            this.btnAjouter100AuTextBox.Text = "Ajouter 100 à la zone de texte";
            this.btnAjouter100AuTextBox.UseVisualStyleBackColor = true;
            this.btnAjouter100AuTextBox.Click += new System.EventHandler(this.btnAjouter100AuTextBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(729, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "VisualInt";
            // 
            // vsiNombre2
            // 
            this.vsiNombre2.FocusColor = System.Drawing.Color.Gray;
            this.vsiNombre2.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.vsiNombre2.Location = new System.Drawing.Point(592, 140);
            this.vsiNombre2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vsiNombre2.Maximum = 999999;
            this.vsiNombre2.Minimum = -999999;
            this.vsiNombre2.Name = "vsiNombre2";
            this.vsiNombre2.Size = new System.Drawing.Size(111, 46);
            this.vsiNombre2.TabIndex = 11;
            // 
            // btnAjouter100
            // 
            this.btnAjouter100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter100.Location = new System.Drawing.Point(268, 140);
            this.btnAjouter100.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjouter100.Name = "btnAjouter100";
            this.btnAjouter100.Size = new System.Drawing.Size(298, 46);
            this.btnAjouter100.TabIndex = 4;
            this.btnAjouter100.Text = "Ajouter 100 au nombre";
            this.btnAjouter100.UseVisualStyleBackColor = true;
            this.btnAjouter100.Click += new System.EventHandler(this.btnAjouter100_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viaNombres);
            this.groupBox2.Controls.Add(this.btnPlacerDansLaGrilleDeNombres);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtListeDeNombres);
            this.groupBox2.Location = new System.Drawing.Point(40, 340);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(921, 318);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Utilisation de la méthode Split";
            // 
            // viaNombres
            // 
            this.viaNombres.BackColor = System.Drawing.Color.Black;
            this.viaNombres.CellSize = new System.Drawing.Size(60, 62);
            this.viaNombres.ColumnCount = 10;
            this.viaNombres.Location = new System.Drawing.Point(39, 203);
            this.viaNombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viaNombres.Maximum = 999;
            this.viaNombres.Minimum = -99;
            this.viaNombres.Name = "viaNombres";
            this.viaNombres.ReadOnly = true;
            this.viaNombres.RowCount = 1;
            this.viaNombres.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaNombres.Size = new System.Drawing.Size(663, 80);
            this.viaNombres.TabIndex = 15;
            this.viaNombres.TabStop = false;
            this.viaNombres.Text = "visualIntArray1";
            // 
            // btnPlacerDansLaGrilleDeNombres
            // 
            this.btnPlacerDansLaGrilleDeNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlacerDansLaGrilleDeNombres.Location = new System.Drawing.Point(39, 145);
            this.btnPlacerDansLaGrilleDeNombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlacerDansLaGrilleDeNombres.Name = "btnPlacerDansLaGrilleDeNombres";
            this.btnPlacerDansLaGrilleDeNombres.Size = new System.Drawing.Size(664, 49);
            this.btnPlacerDansLaGrilleDeNombres.TabIndex = 14;
            this.btnPlacerDansLaGrilleDeNombres.Text = "Placer les nombres dans la grille";
            this.btnPlacerDansLaGrilleDeNombres.UseVisualStyleBackColor = true;
            this.btnPlacerDansLaGrilleDeNombres.Click += new System.EventHandler(this.BtnPlacerDansLaGrilleDeNombres_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(596, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Zone de texte contenant des nombres entiers ( -99 à 999 ) séparés par une virgule" +
    " :";
            // 
            // txtListeDeNombres
            // 
            this.txtListeDeNombres.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListeDeNombres.Location = new System.Drawing.Point(39, 86);
            this.txtListeDeNombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtListeDeNombres.MaxLength = 30;
            this.txtListeDeNombres.Name = "txtListeDeNombres";
            this.txtListeDeNombres.Size = new System.Drawing.Size(662, 44);
            this.txtListeDeNombres.TabIndex = 13;
            this.txtListeDeNombres.Text = "1,22,33,41,56,66,71,81,-99,100";
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mnuPrincipal.Size = new System.Drawing.Size(987, 35);
            this.mnuPrincipal.TabIndex = 10;
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
            // FrmPrincipal
            // 
            this.AcceptButton = this.btnPlacerDansLaGrilleDeNombres;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 683);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les méthodes Parse et Split ";
            ((System.ComponentModel.ISupportInitialize)(this.numNombre)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEntier;
        private System.Windows.Forms.Button btnConvertirEnInt;
        private VisualArrays.VisualCells.VisualInt vsiNombre1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConvertirEnDecimal;
        private System.Windows.Forms.NumericUpDown numNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAjouter100;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPlacerDansLaGrilleDeNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtListeDeNombres;
        private VisualArrays.VisualIntArray viaNombres;
        private System.Windows.Forms.Label label6;
        private VisualArrays.VisualCells.VisualInt vsiNombre2;
        private System.Windows.Forms.Button btnAjouter100AuTextBox;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
    }
}

