namespace LecteurUnDC
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
            this.lblPisteCourante = new System.Windows.Forms.Label();
            this.lblDureeTotaleMMSS = new System.Windows.Forms.Label();
            this.lblTempsRestant = new System.Windows.Forms.Label();
            this.btnPisteSuivante = new System.Windows.Forms.Button();
            this.btnPistePrecedente = new System.Windows.Forms.Button();
            this.chkPower = new System.Windows.Forms.CheckBox();
            this.panDisque = new System.Windows.Forms.Panel();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdition = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditionAllumerEteindre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditionSeparateur1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditionInserer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditionInsererDisqueNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditionInsererDisqueTest1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditionInsererDisqueTest2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditionInsererDisqueTest3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditionEjecter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditionSeparateur2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditionPistePrecedente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditionPisteSuivante = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTempsRestant = new System.Windows.Forms.Label();
            this.txtPisteCourante = new System.Windows.Forms.Label();
            this.txtDureeTotaleMMSS = new System.Windows.Forms.Label();
            this.panInfos = new System.Windows.Forms.Panel();
            this.txtGenre = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.mnuPrincipal.SuspendLayout();
            this.panInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPisteCourante
            // 
            this.lblPisteCourante.BackColor = System.Drawing.Color.Transparent;
            this.lblPisteCourante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPisteCourante.Location = new System.Drawing.Point(84, 4);
            this.lblPisteCourante.Name = "lblPisteCourante";
            this.lblPisteCourante.Size = new System.Drawing.Size(88, 16);
            this.lblPisteCourante.TabIndex = 0;
            this.lblPisteCourante.Text = "Piste courante";
            this.lblPisteCourante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDureeTotaleMMSS
            // 
            this.lblDureeTotaleMMSS.BackColor = System.Drawing.Color.Transparent;
            this.lblDureeTotaleMMSS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDureeTotaleMMSS.Location = new System.Drawing.Point(-3, 4);
            this.lblDureeTotaleMMSS.Name = "lblDureeTotaleMMSS";
            this.lblDureeTotaleMMSS.Size = new System.Drawing.Size(88, 16);
            this.lblDureeTotaleMMSS.TabIndex = 5;
            this.lblDureeTotaleMMSS.Text = "Durée totale";
            this.lblDureeTotaleMMSS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsRestant
            // 
            this.lblTempsRestant.BackColor = System.Drawing.Color.Transparent;
            this.lblTempsRestant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTempsRestant.Location = new System.Drawing.Point(170, 4);
            this.lblTempsRestant.Name = "lblTempsRestant";
            this.lblTempsRestant.Size = new System.Drawing.Size(80, 16);
            this.lblTempsRestant.TabIndex = 7;
            this.lblTempsRestant.Text = "Temps restant";
            this.lblTempsRestant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPisteSuivante
            // 
            this.btnPisteSuivante.BackColor = System.Drawing.Color.Transparent;
            this.btnPisteSuivante.Enabled = false;
            this.btnPisteSuivante.FlatAppearance.BorderSize = 0;
            this.btnPisteSuivante.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPisteSuivante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPisteSuivante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPisteSuivante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPisteSuivante.Location = new System.Drawing.Point(710, 191);
            this.btnPisteSuivante.Name = "btnPisteSuivante";
            this.btnPisteSuivante.Size = new System.Drawing.Size(41, 23);
            this.btnPisteSuivante.TabIndex = 2;
            this.btnPisteSuivante.UseVisualStyleBackColor = false;
            this.btnPisteSuivante.Click += new System.EventHandler(this.btnPisteSuivante_Click);
            // 
            // btnPistePrecedente
            // 
            this.btnPistePrecedente.BackColor = System.Drawing.Color.Transparent;
            this.btnPistePrecedente.Enabled = false;
            this.btnPistePrecedente.FlatAppearance.BorderSize = 0;
            this.btnPistePrecedente.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPistePrecedente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPistePrecedente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPistePrecedente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPistePrecedente.Location = new System.Drawing.Point(656, 191);
            this.btnPistePrecedente.Name = "btnPistePrecedente";
            this.btnPistePrecedente.Size = new System.Drawing.Size(41, 23);
            this.btnPistePrecedente.TabIndex = 1;
            this.btnPistePrecedente.UseVisualStyleBackColor = false;
            this.btnPistePrecedente.Click += new System.EventHandler(this.btnPistePrecedente_Click);
            // 
            // chkPower
            // 
            this.chkPower.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPower.BackColor = System.Drawing.Color.Transparent;
            this.chkPower.FlatAppearance.BorderSize = 0;
            this.chkPower.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkPower.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkPower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPower.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkPower.Location = new System.Drawing.Point(29, 127);
            this.chkPower.Name = "chkPower";
            this.chkPower.Size = new System.Drawing.Size(41, 23);
            this.chkPower.TabIndex = 0;
            this.chkPower.UseVisualStyleBackColor = false;
            this.chkPower.CheckedChanged += new System.EventHandler(this.chkPower_CheckedChanged);
            // 
            // panDisque
            // 
            this.panDisque.BackColor = System.Drawing.Color.DodgerBlue;
            this.panDisque.Location = new System.Drawing.Point(357, 146);
            this.panDisque.Name = "panDisque";
            this.panDisque.Size = new System.Drawing.Size(72, 4);
            this.panDisque.TabIndex = 14;
            this.panDisque.Visible = false;
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuEdition});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(786, 24);
            this.mnuPrincipal.TabIndex = 15;
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
            // mnuEdition
            // 
            this.mnuEdition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditionAllumerEteindre,
            this.mnuEditionSeparateur1,
            this.mnuEditionInserer,
            this.mnuEditionEjecter,
            this.mnuEditionSeparateur2,
            this.mnuEditionPistePrecedente,
            this.mnuEditionPisteSuivante});
            this.mnuEdition.Name = "mnuEdition";
            this.mnuEdition.Size = new System.Drawing.Size(56, 20);
            this.mnuEdition.Text = "&Édition";
            // 
            // mnuEditionAllumerEteindre
            // 
            this.mnuEditionAllumerEteindre.Name = "mnuEditionAllumerEteindre";
            this.mnuEditionAllumerEteindre.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuEditionAllumerEteindre.Size = new System.Drawing.Size(209, 22);
            this.mnuEditionAllumerEteindre.Text = "Allumer le lecteur";
            this.mnuEditionAllumerEteindre.Click += new System.EventHandler(this.mnuEditionAllumerEteindre_Click);
            // 
            // mnuEditionSeparateur1
            // 
            this.mnuEditionSeparateur1.Name = "mnuEditionSeparateur1";
            this.mnuEditionSeparateur1.Size = new System.Drawing.Size(206, 6);
            // 
            // mnuEditionInserer
            // 
            this.mnuEditionInserer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditionInsererDisqueNormal,
            this.mnuEditionInsererDisqueTest1,
            this.mnuEditionInsererDisqueTest2,
            this.mnuEditionInsererDisqueTest3});
            this.mnuEditionInserer.Name = "mnuEditionInserer";
            this.mnuEditionInserer.Size = new System.Drawing.Size(209, 22);
            this.mnuEditionInserer.Text = "&Insérer un disque";
            // 
            // mnuEditionInsererDisqueNormal
            // 
            this.mnuEditionInsererDisqueNormal.Name = "mnuEditionInsererDisqueNormal";
            this.mnuEditionInsererDisqueNormal.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuEditionInsererDisqueNormal.Size = new System.Drawing.Size(157, 22);
            this.mnuEditionInsererDisqueNormal.Text = "&Normal";
            this.mnuEditionInsererDisqueNormal.Click += new System.EventHandler(this.mnuEditionInsererDisqueNormal_Click);
            // 
            // mnuEditionInsererDisqueTest1
            // 
            this.mnuEditionInsererDisqueTest1.Name = "mnuEditionInsererDisqueTest1";
            this.mnuEditionInsererDisqueTest1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.mnuEditionInsererDisqueTest1.Size = new System.Drawing.Size(157, 22);
            this.mnuEditionInsererDisqueTest1.Text = "Test &1";
            this.mnuEditionInsererDisqueTest1.Click += new System.EventHandler(this.mnuEditionInsererDisqueTest1_Click);
            // 
            // mnuEditionInsererDisqueTest2
            // 
            this.mnuEditionInsererDisqueTest2.Name = "mnuEditionInsererDisqueTest2";
            this.mnuEditionInsererDisqueTest2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.mnuEditionInsererDisqueTest2.Size = new System.Drawing.Size(157, 22);
            this.mnuEditionInsererDisqueTest2.Text = "Test &2";
            this.mnuEditionInsererDisqueTest2.Click += new System.EventHandler(this.mnuEditionInsererDisqueTest2_Click);
            // 
            // mnuEditionInsererDisqueTest3
            // 
            this.mnuEditionInsererDisqueTest3.Name = "mnuEditionInsererDisqueTest3";
            this.mnuEditionInsererDisqueTest3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.mnuEditionInsererDisqueTest3.Size = new System.Drawing.Size(157, 22);
            this.mnuEditionInsererDisqueTest3.Text = "Test &3";
            this.mnuEditionInsererDisqueTest3.Click += new System.EventHandler(this.mnuEditionInsererDisqueTest3_Click);
            // 
            // mnuEditionEjecter
            // 
            this.mnuEditionEjecter.Name = "mnuEditionEjecter";
            this.mnuEditionEjecter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuEditionEjecter.Size = new System.Drawing.Size(209, 22);
            this.mnuEditionEjecter.Text = "&Éjecter un disque";
            this.mnuEditionEjecter.Click += new System.EventHandler(this.mnuEditionEjecter_Click);
            // 
            // mnuEditionSeparateur2
            // 
            this.mnuEditionSeparateur2.Name = "mnuEditionSeparateur2";
            this.mnuEditionSeparateur2.Size = new System.Drawing.Size(206, 6);
            // 
            // mnuEditionPistePrecedente
            // 
            this.mnuEditionPistePrecedente.Name = "mnuEditionPistePrecedente";
            this.mnuEditionPistePrecedente.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuEditionPistePrecedente.Size = new System.Drawing.Size(209, 22);
            this.mnuEditionPistePrecedente.Text = "Piste &précédente";
            this.mnuEditionPistePrecedente.Click += new System.EventHandler(this.btnPistePrecedente_Click);
            // 
            // mnuEditionPisteSuivante
            // 
            this.mnuEditionPisteSuivante.Name = "mnuEditionPisteSuivante";
            this.mnuEditionPisteSuivante.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuEditionPisteSuivante.Size = new System.Drawing.Size(209, 22);
            this.mnuEditionPisteSuivante.Text = "Piste &suivante";
            this.mnuEditionPisteSuivante.Click += new System.EventHandler(this.btnPisteSuivante_Click);
            // 
            // txtTempsRestant
            // 
            this.txtTempsRestant.BackColor = System.Drawing.Color.Transparent;
            this.txtTempsRestant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempsRestant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtTempsRestant.Location = new System.Drawing.Point(177, 20);
            this.txtTempsRestant.Name = "txtTempsRestant";
            this.txtTempsRestant.Size = new System.Drawing.Size(66, 25);
            this.txtTempsRestant.TabIndex = 17;
            this.txtTempsRestant.Text = "00:00";
            this.txtTempsRestant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPisteCourante
            // 
            this.txtPisteCourante.BackColor = System.Drawing.Color.Transparent;
            this.txtPisteCourante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPisteCourante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPisteCourante.Location = new System.Drawing.Point(98, 20);
            this.txtPisteCourante.Name = "txtPisteCourante";
            this.txtPisteCourante.Size = new System.Drawing.Size(66, 25);
            this.txtPisteCourante.TabIndex = 16;
            this.txtPisteCourante.Text = "00:00";
            this.txtPisteCourante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDureeTotaleMMSS
            // 
            this.txtDureeTotaleMMSS.BackColor = System.Drawing.Color.Transparent;
            this.txtDureeTotaleMMSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDureeTotaleMMSS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtDureeTotaleMMSS.Location = new System.Drawing.Point(10, 21);
            this.txtDureeTotaleMMSS.Name = "txtDureeTotaleMMSS";
            this.txtDureeTotaleMMSS.Size = new System.Drawing.Size(66, 25);
            this.txtDureeTotaleMMSS.TabIndex = 15;
            this.txtDureeTotaleMMSS.Text = "00:00";
            this.txtDureeTotaleMMSS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panInfos
            // 
            this.panInfos.BackColor = System.Drawing.Color.Transparent;
            this.panInfos.Controls.Add(this.txtGenre);
            this.panInfos.Controls.Add(this.lblGenre);
            this.panInfos.Controls.Add(this.txtTempsRestant);
            this.panInfos.Controls.Add(this.lblTempsRestant);
            this.panInfos.Controls.Add(this.txtPisteCourante);
            this.panInfos.Controls.Add(this.lblDureeTotaleMMSS);
            this.panInfos.Controls.Add(this.txtDureeTotaleMMSS);
            this.panInfos.Controls.Add(this.lblPisteCourante);
            this.panInfos.Location = new System.Drawing.Point(222, 176);
            this.panInfos.Name = "panInfos";
            this.panInfos.Size = new System.Drawing.Size(341, 51);
            this.panInfos.TabIndex = 18;
            // 
            // txtGenre
            // 
            this.txtGenre.BackColor = System.Drawing.Color.Transparent;
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtGenre.Location = new System.Drawing.Point(253, 20);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(89, 25);
            this.txtGenre.TabIndex = 19;
            this.txtGenre.Text = "????";
            this.txtGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenre
            // 
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblGenre.Location = new System.Drawing.Point(256, 4);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(80, 16);
            this.lblGenre.TabIndex = 18;
            this.lblGenre.Text = "Genre";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::LecteurUnDC.Properties.Resources.ImageLecteurUnDC1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(786, 259);
            this.Controls.Add(this.panDisque);
            this.Controls.Add(this.panInfos);
            this.Controls.Add(this.chkPower);
            this.Controls.Add(this.btnPisteSuivante);
            this.Controls.Add(this.btnPistePrecedente);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecteur DC ";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.panInfos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnPisteSuivante;
        private System.Windows.Forms.Button btnPistePrecedente;
        private System.Windows.Forms.CheckBox chkPower;
        private System.Windows.Forms.Label lblPisteCourante;
        private System.Windows.Forms.Label lblDureeTotaleMMSS;
        private System.Windows.Forms.Label lblTempsRestant;
        private System.Windows.Forms.Panel panDisque;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuEdition;
        private System.Windows.Forms.ToolStripMenuItem mnuEditionAllumerEteindre;
        private System.Windows.Forms.ToolStripSeparator mnuEditionSeparateur1;
        private System.Windows.Forms.ToolStripMenuItem mnuEditionInserer;
        private System.Windows.Forms.ToolStripMenuItem mnuEditionEjecter;
        private System.Windows.Forms.ToolStripSeparator mnuEditionSeparateur2;
        private System.Windows.Forms.ToolStripMenuItem mnuEditionPistePrecedente;
        private System.Windows.Forms.ToolStripMenuItem mnuEditionPisteSuivante;
        private System.Windows.Forms.ToolStripMenuItem mnuEditionInsererDisqueNormal;
        private System.Windows.Forms.ToolStripMenuItem mnuEditionInsererDisqueTest1;
        private System.Windows.Forms.ToolStripMenuItem mnuEditionInsererDisqueTest2;
        private System.Windows.Forms.ToolStripMenuItem mnuEditionInsererDisqueTest3;
        private System.Windows.Forms.Label txtTempsRestant;
        private System.Windows.Forms.Label txtPisteCourante;
        private System.Windows.Forms.Label txtDureeTotaleMMSS;
        private System.Windows.Forms.Panel panInfos;
        private System.Windows.Forms.Label txtGenre;
        private System.Windows.Forms.Label lblGenre;

    }
}

