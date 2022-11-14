namespace AfficherInfosPistes
{
    partial class FrmEx2InfosPistes
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
            this.grpInfoDC = new System.Windows.Forms.GroupBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.vsaGrilleInfosPistes = new VisualArrays.VisualStringArray();
            this.txtDureeMoyenne = new System.Windows.Forms.TextBox();
            this.lblDureeMoyenne = new System.Windows.Forms.Label();
            this.txtDureeMaximum = new System.Windows.Forms.TextBox();
            this.lblDureeMaximum = new System.Windows.Forms.Label();
            this.txtNbPistesSupA5Min = new System.Windows.Forms.TextBox();
            this.lblNbPistesSupA5Min = new System.Windows.Forms.Label();
            this.txtDureeTotale = new System.Windows.Forms.TextBox();
            this.lblDureeTotale = new System.Windows.Forms.Label();
            this.txtNbPistes = new System.Windows.Forms.TextBox();
            this.lblNbPistes = new System.Windows.Forms.Label();
            this.btnInstancierUnDisqueNormal = new System.Windows.Forms.Button();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInstancierUnDisqueTest1 = new System.Windows.Forms.Button();
            this.btnInstancierUnDisqueTest2 = new System.Windows.Forms.Button();
            this.btnInstancierUnDisqueTest3 = new System.Windows.Forms.Button();
            this.grpInfoDC.SuspendLayout();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfoDC
            // 
            this.grpInfoDC.Controls.Add(this.txtGenre);
            this.grpInfoDC.Controls.Add(this.lblGenre);
            this.grpInfoDC.Controls.Add(this.vsaGrilleInfosPistes);
            this.grpInfoDC.Controls.Add(this.txtDureeMoyenne);
            this.grpInfoDC.Controls.Add(this.lblDureeMoyenne);
            this.grpInfoDC.Controls.Add(this.txtDureeMaximum);
            this.grpInfoDC.Controls.Add(this.lblDureeMaximum);
            this.grpInfoDC.Controls.Add(this.txtNbPistesSupA5Min);
            this.grpInfoDC.Controls.Add(this.lblNbPistesSupA5Min);
            this.grpInfoDC.Controls.Add(this.txtDureeTotale);
            this.grpInfoDC.Controls.Add(this.lblDureeTotale);
            this.grpInfoDC.Controls.Add(this.txtNbPistes);
            this.grpInfoDC.Controls.Add(this.lblNbPistes);
            this.grpInfoDC.Location = new System.Drawing.Point(20, 215);
            this.grpInfoDC.Name = "grpInfoDC";
            this.grpInfoDC.Size = new System.Drawing.Size(470, 395);
            this.grpInfoDC.TabIndex = 2;
            this.grpInfoDC.TabStop = false;
            this.grpInfoDC.Enter += new System.EventHandler(this.grpInfoDC_Enter);
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(208, 63);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(101, 26);
            this.txtGenre.TabIndex = 13;
            this.txtGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGenre
            // 
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(93, 66);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(104, 21);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Genre :";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vsaGrilleInfosPistes
            // 
            this.vsaGrilleInfosPistes.BackColor = System.Drawing.Color.DimGray;
            this.vsaGrilleInfosPistes.CellSize = new System.Drawing.Size(60, 18);
            this.vsaGrilleInfosPistes.ColumnCount = 1;
            this.vsaGrilleInfosPistes.ColumnHeader.BackgroundColor = System.Drawing.Color.Black;
            this.vsaGrilleInfosPistes.ColumnHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsaGrilleInfosPistes.ColumnHeader.Height = 16;
            this.vsaGrilleInfosPistes.ColumnHeader.ValueStyle = VisualArrays.enuDataStyle.User;
            this.vsaGrilleInfosPistes.ColumnHeader.Visible = true;
            this.vsaGrilleInfosPistes.DefaultValue = "";
            this.vsaGrilleInfosPistes.EnabledAppearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsaGrilleInfosPistes.Location = new System.Drawing.Point(343, 19);
            this.vsaGrilleInfosPistes.Name = "vsaGrilleInfosPistes";
            this.vsaGrilleInfosPistes.RowCount = 14;
            this.vsaGrilleInfosPistes.RowHeader.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vsaGrilleInfosPistes.RowHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsaGrilleInfosPistes.RowHeader.ForeColor = System.Drawing.Color.White;
            this.vsaGrilleInfosPistes.RowHeader.ValueStyle = VisualArrays.enuDataStyle.IndexBase1;
            this.vsaGrilleInfosPistes.RowHeader.Visible = true;
            this.vsaGrilleInfosPistes.Size = new System.Drawing.Size(98, 351);
            this.vsaGrilleInfosPistes.SpecialValueAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(79)))));
            this.vsaGrilleInfosPistes.SpecialValueAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.vsaGrilleInfosPistes.TabIndex = 11;
            // 
            // txtDureeMoyenne
            // 
            this.txtDureeMoyenne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDureeMoyenne.Location = new System.Drawing.Point(208, 140);
            this.txtDureeMoyenne.Name = "txtDureeMoyenne";
            this.txtDureeMoyenne.ReadOnly = true;
            this.txtDureeMoyenne.Size = new System.Drawing.Size(101, 26);
            this.txtDureeMoyenne.TabIndex = 10;
            this.txtDureeMoyenne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDureeMoyenne
            // 
            this.lblDureeMoyenne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDureeMoyenne.Location = new System.Drawing.Point(6, 143);
            this.lblDureeMoyenne.Name = "lblDureeMoyenne";
            this.lblDureeMoyenne.Size = new System.Drawing.Size(191, 24);
            this.lblDureeMoyenne.TabIndex = 9;
            this.lblDureeMoyenne.Text = "Durée moyenne (mm:ss) :";
            // 
            // txtDureeMaximum
            // 
            this.txtDureeMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDureeMaximum.Location = new System.Drawing.Point(208, 275);
            this.txtDureeMaximum.Name = "txtDureeMaximum";
            this.txtDureeMaximum.ReadOnly = true;
            this.txtDureeMaximum.Size = new System.Drawing.Size(101, 26);
            this.txtDureeMaximum.TabIndex = 8;
            this.txtDureeMaximum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDureeMaximum
            // 
            this.lblDureeMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDureeMaximum.Location = new System.Drawing.Point(6, 279);
            this.lblDureeMaximum.Name = "lblDureeMaximum";
            this.lblDureeMaximum.Size = new System.Drawing.Size(196, 22);
            this.lblDureeMaximum.TabIndex = 7;
            this.lblDureeMaximum.Text = "Durée maximum (mm:ss) :";
            this.lblDureeMaximum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNbPistesSupA5Min
            // 
            this.txtNbPistesSupA5Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbPistesSupA5Min.Location = new System.Drawing.Point(208, 232);
            this.txtNbPistesSupA5Min.Name = "txtNbPistesSupA5Min";
            this.txtNbPistesSupA5Min.ReadOnly = true;
            this.txtNbPistesSupA5Min.Size = new System.Drawing.Size(101, 26);
            this.txtNbPistesSupA5Min.TabIndex = 6;
            this.txtNbPistesSupA5Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNbPistesSupA5Min
            // 
            this.lblNbPistesSupA5Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbPistesSupA5Min.Location = new System.Drawing.Point(20, 195);
            this.lblNbPistesSupA5Min.Name = "lblNbPistesSupA5Min";
            this.lblNbPistesSupA5Min.Size = new System.Drawing.Size(177, 63);
            this.lblNbPistesSupA5Min.TabIndex = 5;
            this.lblNbPistesSupA5Min.Text = "Nombre de pistes dont la durée est supérieure à 5 minutes :";
            this.lblNbPistesSupA5Min.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDureeTotale
            // 
            this.txtDureeTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDureeTotale.Location = new System.Drawing.Point(208, 107);
            this.txtDureeTotale.Name = "txtDureeTotale";
            this.txtDureeTotale.ReadOnly = true;
            this.txtDureeTotale.Size = new System.Drawing.Size(101, 26);
            this.txtDureeTotale.TabIndex = 4;
            this.txtDureeTotale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDureeTotale
            // 
            this.lblDureeTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDureeTotale.Location = new System.Drawing.Point(6, 109);
            this.lblDureeTotale.Name = "lblDureeTotale";
            this.lblDureeTotale.Size = new System.Drawing.Size(191, 24);
            this.lblDureeTotale.TabIndex = 3;
            this.lblDureeTotale.Text = "Durée totale (mm:ss) :";
            this.lblDureeTotale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNbPistes
            // 
            this.txtNbPistes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbPistes.Location = new System.Drawing.Point(208, 25);
            this.txtNbPistes.Name = "txtNbPistes";
            this.txtNbPistes.ReadOnly = true;
            this.txtNbPistes.Size = new System.Drawing.Size(101, 26);
            this.txtNbPistes.TabIndex = 1;
            this.txtNbPistes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNbPistes
            // 
            this.lblNbPistes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbPistes.Location = new System.Drawing.Point(53, 28);
            this.lblNbPistes.Name = "lblNbPistes";
            this.lblNbPistes.Size = new System.Drawing.Size(144, 21);
            this.lblNbPistes.TabIndex = 0;
            this.lblNbPistes.Text = "Nombre de pistes :";
            this.lblNbPistes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnInstancierUnDisqueNormal
            // 
            this.btnInstancierUnDisqueNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstancierUnDisqueNormal.Location = new System.Drawing.Point(20, 41);
            this.btnInstancierUnDisqueNormal.Name = "btnInstancierUnDisqueNormal";
            this.btnInstancierUnDisqueNormal.Size = new System.Drawing.Size(470, 35);
            this.btnInstancierUnDisqueNormal.TabIndex = 1;
            this.btnInstancierUnDisqueNormal.Text = "Instancier un disque de type normal";
            this.btnInstancierUnDisqueNormal.Click += new System.EventHandler(this.BtnInstancierUnDisqueNormal_Click);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(512, 24);
            this.mnuPrincipal.TabIndex = 0;
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
            this.mnuFichierQuitter.Text = "Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // btnInstancierUnDisqueTest1
            // 
            this.btnInstancierUnDisqueTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstancierUnDisqueTest1.Location = new System.Drawing.Point(20, 81);
            this.btnInstancierUnDisqueTest1.Name = "btnInstancierUnDisqueTest1";
            this.btnInstancierUnDisqueTest1.Size = new System.Drawing.Size(470, 35);
            this.btnInstancierUnDisqueTest1.TabIndex = 3;
            this.btnInstancierUnDisqueTest1.Text = "Instancier un disque de type Test1";
            this.btnInstancierUnDisqueTest1.Click += new System.EventHandler(this.BtnInstancierUnDisqueTest1_Click);
            // 
            // btnInstancierUnDisqueTest2
            // 
            this.btnInstancierUnDisqueTest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstancierUnDisqueTest2.Location = new System.Drawing.Point(20, 122);
            this.btnInstancierUnDisqueTest2.Name = "btnInstancierUnDisqueTest2";
            this.btnInstancierUnDisqueTest2.Size = new System.Drawing.Size(470, 35);
            this.btnInstancierUnDisqueTest2.TabIndex = 4;
            this.btnInstancierUnDisqueTest2.Text = "Instancier un disque de type Test2";
            this.btnInstancierUnDisqueTest2.Click += new System.EventHandler(this.BtnInstancierUnDisqueTest2_Click);
            // 
            // btnInstancierUnDisqueTest3
            // 
            this.btnInstancierUnDisqueTest3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstancierUnDisqueTest3.Location = new System.Drawing.Point(20, 163);
            this.btnInstancierUnDisqueTest3.Name = "btnInstancierUnDisqueTest3";
            this.btnInstancierUnDisqueTest3.Size = new System.Drawing.Size(470, 35);
            this.btnInstancierUnDisqueTest3.TabIndex = 5;
            this.btnInstancierUnDisqueTest3.Text = "Instancier un disque de type Test3";
            this.btnInstancierUnDisqueTest3.Click += new System.EventHandler(this.BtnInstancierUnDisqueTest3_Click);
            // 
            // FrmEx2InfosPistes
            // 
            this.AcceptButton = this.btnInstancierUnDisqueNormal;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(512, 624);
            this.Controls.Add(this.btnInstancierUnDisqueTest3);
            this.Controls.Add(this.btnInstancierUnDisqueTest2);
            this.Controls.Add(this.btnInstancierUnDisqueTest1);
            this.Controls.Add(this.btnInstancierUnDisqueNormal);
            this.Controls.Add(this.grpInfoDC);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 450);
            this.Name = "FrmEx2InfosPistes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informations sur les pistes et sorte de disque ";
            this.grpInfoDC.ResumeLayout(false);
            this.grpInfoDC.PerformLayout();
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox txtNbPistes;
        private System.Windows.Forms.TextBox txtDureeTotale;
        private System.Windows.Forms.Button btnInstancierUnDisqueNormal;
        private System.Windows.Forms.TextBox txtDureeMoyenne;
        private System.Windows.Forms.Label lblDureeMoyenne;
        private System.Windows.Forms.TextBox txtDureeMaximum;
        private System.Windows.Forms.Label lblDureeMaximum;
        private System.Windows.Forms.TextBox txtNbPistesSupA5Min;
        private System.Windows.Forms.GroupBox grpInfoDC;
        private System.Windows.Forms.Label lblDureeTotale;
        private System.Windows.Forms.Label lblNbPistes;
        private System.Windows.Forms.Label lblNbPistesSupA5Min;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private VisualArrays.VisualStringArray vsaGrilleInfosPistes;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Button btnInstancierUnDisqueTest1;
        private System.Windows.Forms.Button btnInstancierUnDisqueTest2;
        private System.Windows.Forms.Button btnInstancierUnDisqueTest3;
    }
}

