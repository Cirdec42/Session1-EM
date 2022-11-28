namespace AppVentesTrimestre
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
            this.mnuFichierNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierCharger = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.vdaVentes = new VisualArrays.VisualDecimalArray();
            this.vdaTotauxParMois = new VisualArrays.VisualDecimalArray();
            this.vdaTotauxVilles = new VisualArrays.VisualDecimalArray();
            this.vsdGrandTotal = new VisualArrays.VisualCells.VisualDecimal();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mnuPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.mnuPrincipal.Size = new System.Drawing.Size(866, 35);
            this.mnuPrincipal.TabIndex = 4;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierNouveau,
            this.mnuFichierCharger,
            this.mnuFichierEnregistrer,
            this.toolStripMenuItem1,
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(78, 29);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierNouveau
            // 
            this.mnuFichierNouveau.Name = "mnuFichierNouveau";
            this.mnuFichierNouveau.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFichierNouveau.Size = new System.Drawing.Size(259, 34);
            this.mnuFichierNouveau.Text = "&Nouveau";
            this.mnuFichierNouveau.Click += new System.EventHandler(this.mnuFichierNouveau_Click);
            // 
            // mnuFichierCharger
            // 
            this.mnuFichierCharger.Name = "mnuFichierCharger";
            this.mnuFichierCharger.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFichierCharger.Size = new System.Drawing.Size(259, 34);
            this.mnuFichierCharger.Text = "&Charger";
            this.mnuFichierCharger.Click += new System.EventHandler(this.mnuFichierCharger_Click);
            // 
            // mnuFichierEnregistrer
            // 
            this.mnuFichierEnregistrer.Name = "mnuFichierEnregistrer";
            this.mnuFichierEnregistrer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFichierEnregistrer.Size = new System.Drawing.Size(259, 34);
            this.mnuFichierEnregistrer.Text = "&Enregistrer";
            this.mnuFichierEnregistrer.Click += new System.EventHandler(this.mnuFichierEnregistrer_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(256, 6);
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(259, 34);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // vdaVentes
            // 
            this.vdaVentes.AddressView = VisualArrays.enuAddressView.Mode2D;
            this.vdaVentes.BackColor = System.Drawing.Color.Black;
            this.vdaVentes.CellContentAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vdaVentes.CellSize = new System.Drawing.Size(172, 51);
            this.vdaVentes.ColumnHeader.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.vdaVentes.ColumnHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdaVentes.ColumnHeader.ValueStyle = VisualArrays.enuDataStyle.User;
            this.vdaVentes.ColumnHeader.Visible = true;
            this.vdaVentes.DecimalPlaces = 0;
            this.vdaVentes.EnabledAppearance.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.vdaVentes.EnabledAppearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdaVentes.EnterKeyNextIndex = true;
            this.vdaVentes.Location = new System.Drawing.Point(9, 57);
            this.vdaVentes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vdaVentes.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.vdaVentes.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.vdaVentes.Name = "vdaVentes";
            this.vdaVentes.RowCount = 4;
            this.vdaVentes.RowHeader.BackgroundColor = System.Drawing.Color.SlateGray;
            this.vdaVentes.RowHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdaVentes.RowHeader.ForeColor = System.Drawing.Color.White;
            this.vdaVentes.RowHeader.ValueStyle = VisualArrays.enuDataStyle.User;
            this.vdaVentes.RowHeader.Visible = true;
            this.vdaVentes.RowHeader.Width = 100;
            this.vdaVentes.SelectionAppearance.Color = System.Drawing.Color.DodgerBlue;
            this.vdaVentes.SelectionMode = System.Windows.Forms.SelectionMode.One;
            this.vdaVentes.Size = new System.Drawing.Size(644, 257);
            this.vdaVentes.TabIndex = 0;
            this.vdaVentes.ValueFormat = VisualArrays.enuValueFormat.Currency;
            this.vdaVentes.ValueChanged += new System.EventHandler<VisualArrays.ValueChangedEventArgs>(this.vdaVentes_ValueChanged);
            this.vdaVentes.Click += new System.EventHandler(this.vdaVentes_Click);
            // 
            // vdaTotauxParMois
            // 
            this.vdaTotauxParMois.AddressView = VisualArrays.enuAddressView.Mode1D;
            this.vdaTotauxParMois.BackColor = System.Drawing.Color.Black;
            this.vdaTotauxParMois.CellContentAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vdaTotauxParMois.CellSize = new System.Drawing.Size(172, 59);
            this.vdaTotauxParMois.ColumnHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdaTotauxParMois.DecimalPlaces = 0;
            this.vdaTotauxParMois.EnabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.vdaTotauxParMois.EnabledAppearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdaTotauxParMois.Location = new System.Drawing.Point(9, 326);
            this.vdaTotauxParMois.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vdaTotauxParMois.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.vdaTotauxParMois.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.vdaTotauxParMois.Name = "vdaTotauxParMois";
            this.vdaTotauxParMois.RowCount = 1;
            this.vdaTotauxParMois.RowHeader.BackgroundColor = System.Drawing.Color.SlateGray;
            this.vdaTotauxParMois.RowHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdaTotauxParMois.RowHeader.ForeColor = System.Drawing.Color.White;
            this.vdaTotauxParMois.RowHeader.ValueStyle = VisualArrays.enuDataStyle.User;
            this.vdaTotauxParMois.RowHeader.Visible = true;
            this.vdaTotauxParMois.RowHeader.Width = 100;
            this.vdaTotauxParMois.SelectionAppearance.Color = System.Drawing.Color.DodgerBlue;
            this.vdaTotauxParMois.Size = new System.Drawing.Size(644, 77);
            this.vdaTotauxParMois.TabIndex = 1;
            this.vdaTotauxParMois.TabStop = false;
            this.vdaTotauxParMois.ValueFormat = VisualArrays.enuValueFormat.Currency;
            // 
            // vdaTotauxVilles
            // 
            this.vdaTotauxVilles.AddressView = VisualArrays.enuAddressView.Mode2D;
            this.vdaTotauxVilles.BackColor = System.Drawing.Color.Black;
            this.vdaTotauxVilles.CellContentAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vdaTotauxVilles.CellSize = new System.Drawing.Size(165, 51);
            this.vdaTotauxVilles.ColumnCount = 1;
            this.vdaTotauxVilles.ColumnHeader.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.vdaTotauxVilles.ColumnHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdaTotauxVilles.ColumnHeader.ValueStyle = VisualArrays.enuDataStyle.User;
            this.vdaTotauxVilles.ColumnHeader.Visible = true;
            this.vdaTotauxVilles.DecimalPlaces = 0;
            this.vdaTotauxVilles.EnabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.vdaTotauxVilles.EnabledAppearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdaTotauxVilles.Location = new System.Drawing.Point(666, 57);
            this.vdaTotauxVilles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vdaTotauxVilles.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.vdaTotauxVilles.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.vdaTotauxVilles.Name = "vdaTotauxVilles";
            this.vdaTotauxVilles.RowCount = 4;
            this.vdaTotauxVilles.RowHeader.BackgroundColor = System.Drawing.Color.SlateGray;
            this.vdaTotauxVilles.RowHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdaTotauxVilles.RowHeader.ForeColor = System.Drawing.Color.White;
            this.vdaTotauxVilles.RowHeader.ValueStyle = VisualArrays.enuDataStyle.User;
            this.vdaTotauxVilles.RowHeader.Width = 100;
            this.vdaTotauxVilles.SelectionAppearance.Color = System.Drawing.Color.DodgerBlue;
            this.vdaTotauxVilles.Size = new System.Drawing.Size(183, 257);
            this.vdaTotauxVilles.TabIndex = 2;
            this.vdaTotauxVilles.TabStop = false;
            this.vdaTotauxVilles.ValueFormat = VisualArrays.enuValueFormat.Currency;
            // 
            // vsdGrandTotal
            // 
            this.vsdGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.vsdGrandTotal.DecimalPlaces = 0;
            this.vsdGrandTotal.FocusColor = System.Drawing.Color.Gray;
            this.vsdGrandTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.vsdGrandTotal.ForeColor = System.Drawing.Color.White;
            this.vsdGrandTotal.Location = new System.Drawing.Point(9, 9);
            this.vsdGrandTotal.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.vsdGrandTotal.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.vsdGrandTotal.Name = "vsdGrandTotal";
            this.vsdGrandTotal.Padding = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.vsdGrandTotal.ReadOnly = true;
            this.vsdGrandTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vsdGrandTotal.Size = new System.Drawing.Size(162, 57);
            this.vsdGrandTotal.TabIndex = 5;
            this.vsdGrandTotal.ValueAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vsdGrandTotal.ValueFormat = VisualArrays.enuValueFormat.Currency;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.vsdGrandTotal);
            this.panel1.Location = new System.Drawing.Point(668, 328);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 75);
            this.panel1.TabIndex = 6;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 414);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vdaTotauxVilles);
            this.Controls.Add(this.vdaTotauxParMois);
            this.Controls.Add(this.vdaVentes);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventes Trimestrielles utilisant un fichier avec séparateurs ";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private VisualArrays.VisualDecimalArray vdaVentes;
        private VisualArrays.VisualDecimalArray vdaTotauxParMois;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierNouveau;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private VisualArrays.VisualDecimalArray vdaTotauxVilles;
        private VisualArrays.VisualCells.VisualDecimal vsdGrandTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierCharger;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierEnregistrer;
    }
}

