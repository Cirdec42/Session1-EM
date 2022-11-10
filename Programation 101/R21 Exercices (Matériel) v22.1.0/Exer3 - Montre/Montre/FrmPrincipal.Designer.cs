namespace ApplicationMontre
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
            this.tmrHorloge = new System.Windows.Forms.Timer(this.components);
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpcialAvancerDuneSeconde = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécialFixer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécialDémarrer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécialSynchroniser = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTemps = new System.Windows.Forms.Label();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrHorloge
            // 
            this.tmrHorloge.Interval = 1000;
            this.tmrHorloge.Tick += new System.EventHandler(this.MnuSpcialAvancerDuneSeconde_Click);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuSpécial});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(322, 24);
            this.mnuPrincipal.TabIndex = 4;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuSpécial
            // 
            this.mnuSpécial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSpcialAvancerDuneSeconde,
            this.mnuSpécialFixer,
            this.mnuSpécialDémarrer,
            this.mnuSpécialSynchroniser});
            this.mnuSpécial.Name = "mnuSpécial";
            this.mnuSpécial.Size = new System.Drawing.Size(56, 20);
            this.mnuSpécial.Text = "Spécial";
            // 
            // mnuSpcialAvancerDuneSeconde
            // 
            this.mnuSpcialAvancerDuneSeconde.Name = "mnuSpcialAvancerDuneSeconde";
            this.mnuSpcialAvancerDuneSeconde.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuSpcialAvancerDuneSeconde.Size = new System.Drawing.Size(239, 22);
            this.mnuSpcialAvancerDuneSeconde.Text = "Avancer d\'une seconde";
            this.mnuSpcialAvancerDuneSeconde.Click += new System.EventHandler(this.MnuSpcialAvancerDuneSeconde_Click);
            // 
            // mnuSpécialFixer
            // 
            this.mnuSpécialFixer.Name = "mnuSpécialFixer";
            this.mnuSpécialFixer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuSpécialFixer.Size = new System.Drawing.Size(239, 22);
            this.mnuSpécialFixer.Text = "Fixer à \"20:45:55\"";
            this.mnuSpécialFixer.Click += new System.EventHandler(this.MnuSpécialFixer_Click);
            // 
            // mnuSpécialDémarrer
            // 
            this.mnuSpécialDémarrer.Name = "mnuSpécialDémarrer";
            this.mnuSpécialDémarrer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mnuSpécialDémarrer.Size = new System.Drawing.Size(239, 22);
            this.mnuSpécialDémarrer.Text = "Démarrer Horloge";
            this.mnuSpécialDémarrer.Click += new System.EventHandler(this.MnuSpécialDémarrer_Click);
            // 
            // mnuSpécialSynchroniser
            // 
            this.mnuSpécialSynchroniser.Name = "mnuSpécialSynchroniser";
            this.mnuSpécialSynchroniser.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSpécialSynchroniser.Size = new System.Drawing.Size(239, 22);
            this.mnuSpécialSynchroniser.Text = "Synchroniser";
            this.mnuSpécialSynchroniser.Click += new System.EventHandler(this.MnuSpécialSynchroniser_Click);
            // 
            // lblTemps
            // 
            this.lblTemps.BackColor = System.Drawing.Color.Transparent;
            this.lblTemps.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemps.ForeColor = System.Drawing.Color.LightGreen;
            this.lblTemps.Location = new System.Drawing.Point(87, 150);
            this.lblTemps.Name = "lblTemps";
            this.lblTemps.Size = new System.Drawing.Size(143, 35);
            this.lblTemps.TabIndex = 5;
            this.lblTemps.Text = "00:00:00";
            this.lblTemps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackgroundImage = global::ApplicationMontre.Properties.Resources.Montre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(322, 333);
            this.Controls.Add(this.lblTemps);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Montre ";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Timer tmrHorloge;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.Label lblTemps;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécial;
        private System.Windows.Forms.ToolStripMenuItem mnuSpcialAvancerDuneSeconde;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécialDémarrer;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécialSynchroniser;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécialFixer;
    }
}

