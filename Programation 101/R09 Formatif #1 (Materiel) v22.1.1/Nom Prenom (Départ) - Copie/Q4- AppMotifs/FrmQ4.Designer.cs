namespace AppMotifs
{
    partial class FrmQ4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQ4));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCinquièmeMotifNumérique = new System.Windows.Forms.Button();
            this.btnQuatrièmeMotifNumérique = new System.Windows.Forms.Button();
            this.btnTroisièmeMotifNumérique = new System.Windows.Forms.Button();
            this.btnPremierMotifNumérique = new System.Windows.Forms.Button();
            this.btnDeuxièmeMotifNumérique = new System.Windows.Forms.Button();
            this.viaGrilleNumérique = new VisualArrays.VisualIntArray();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCinquièmeMotifCaractères = new System.Windows.Forms.Button();
            this.vcaGrilleCaractères = new VisualArrays.VisualCharArray();
            this.btnQuatrièmeMotifCaractères = new System.Windows.Forms.Button();
            this.btnTroisièmeMotifCaractères = new System.Windows.Forms.Button();
            this.btnPremierMotifCaractères = new System.Windows.Forms.Button();
            this.btnDeuxièmeMotifCaractères = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCinquièmeMotifBooléen = new System.Windows.Forms.Button();
            this.btnQuatrièmeMotifBooléen = new System.Windows.Forms.Button();
            this.btnTroisièmeMotifBooléen = new System.Windows.Forms.Button();
            this.btnDeuxièmeMotifBooléen = new System.Windows.Forms.Button();
            this.btnPremierMotifBooléen = new System.Windows.Forms.Button();
            this.vbaGrilleBooléens = new VisualArrays.VisualBoolArray();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.btnCinquièmeMotifNumérique);
            this.groupBox3.Controls.Add(this.btnQuatrièmeMotifNumérique);
            this.groupBox3.Controls.Add(this.btnTroisièmeMotifNumérique);
            this.groupBox3.Controls.Add(this.btnPremierMotifNumérique);
            this.groupBox3.Controls.Add(this.btnDeuxièmeMotifNumérique);
            this.groupBox3.Controls.Add(this.viaGrilleNumérique);
            this.groupBox3.Location = new System.Drawing.Point(12, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(847, 157);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motifs numériques";
            // 
            // btnCinquièmeMotifNumérique
            // 
            this.btnCinquièmeMotifNumérique.Location = new System.Drawing.Point(674, 100);
            this.btnCinquièmeMotifNumérique.Name = "btnCinquièmeMotifNumérique";
            this.btnCinquièmeMotifNumérique.Size = new System.Drawing.Size(155, 38);
            this.btnCinquièmeMotifNumérique.TabIndex = 26;
            this.btnCinquièmeMotifNumérique.Text = "5- Cinquième motif numérique";
            this.btnCinquièmeMotifNumérique.UseVisualStyleBackColor = true;
            this.btnCinquièmeMotifNumérique.Click += new System.EventHandler(this.BtnCinquièmeMotifNumérique_Click);
            // 
            // btnQuatrièmeMotifNumérique
            // 
            this.btnQuatrièmeMotifNumérique.Location = new System.Drawing.Point(510, 100);
            this.btnQuatrièmeMotifNumérique.Name = "btnQuatrièmeMotifNumérique";
            this.btnQuatrièmeMotifNumérique.Size = new System.Drawing.Size(155, 38);
            this.btnQuatrièmeMotifNumérique.TabIndex = 25;
            this.btnQuatrièmeMotifNumérique.Text = "4- Quatrième motif numérique";
            this.btnQuatrièmeMotifNumérique.UseVisualStyleBackColor = true;
            this.btnQuatrièmeMotifNumérique.Click += new System.EventHandler(this.BtnQuatrièmeMotifNumérique_Click);
            // 
            // btnTroisièmeMotifNumérique
            // 
            this.btnTroisièmeMotifNumérique.Location = new System.Drawing.Point(344, 100);
            this.btnTroisièmeMotifNumérique.Name = "btnTroisièmeMotifNumérique";
            this.btnTroisièmeMotifNumérique.Size = new System.Drawing.Size(155, 38);
            this.btnTroisièmeMotifNumérique.TabIndex = 24;
            this.btnTroisièmeMotifNumérique.Text = "3- Troisième motif numérique";
            this.btnTroisièmeMotifNumérique.UseVisualStyleBackColor = true;
            this.btnTroisièmeMotifNumérique.Click += new System.EventHandler(this.BtnTroisièmeMotifNumérique_Click);
            // 
            // btnPremierMotifNumérique
            // 
            this.btnPremierMotifNumérique.Location = new System.Drawing.Point(16, 100);
            this.btnPremierMotifNumérique.Name = "btnPremierMotifNumérique";
            this.btnPremierMotifNumérique.Size = new System.Drawing.Size(155, 38);
            this.btnPremierMotifNumérique.TabIndex = 22;
            this.btnPremierMotifNumérique.Text = "1- Premier motif numérique";
            this.btnPremierMotifNumérique.UseVisualStyleBackColor = true;
            this.btnPremierMotifNumérique.Click += new System.EventHandler(this.BtnPremierMotifNumérique_Click);
            // 
            // btnDeuxièmeMotifNumérique
            // 
            this.btnDeuxièmeMotifNumérique.Location = new System.Drawing.Point(180, 100);
            this.btnDeuxièmeMotifNumérique.Name = "btnDeuxièmeMotifNumérique";
            this.btnDeuxièmeMotifNumérique.Size = new System.Drawing.Size(155, 38);
            this.btnDeuxièmeMotifNumérique.TabIndex = 23;
            this.btnDeuxièmeMotifNumérique.Text = "2- Deuxième motif numérique";
            this.btnDeuxièmeMotifNumérique.UseVisualStyleBackColor = true;
            this.btnDeuxièmeMotifNumérique.Click += new System.EventHandler(this.BtnDeuxièmeMotifNumérique_Click);
            // 
            // viaGrilleNumérique
            // 
            this.viaGrilleNumérique.AddressView = VisualArrays.enuAddressView.Mode1D;
            this.viaGrilleNumérique.BackColor = System.Drawing.Color.Black;
            this.viaGrilleNumérique.CellSize = new System.Drawing.Size(48, 38);
            this.viaGrilleNumérique.ColumnCount = 15;
            this.viaGrilleNumérique.ColumnHeader.BackgroundColor = System.Drawing.Color.Teal;
            this.viaGrilleNumérique.Delay = 75;
            this.viaGrilleNumérique.DisabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(79)))));
            this.viaGrilleNumérique.DisabledAppearance.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaGrilleNumérique.DisabledAppearance.StrikeAppearance.Style = VisualArrays.enuStrikeStyle.Cross;
            this.viaGrilleNumérique.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.viaGrilleNumérique.DisabledAppearance.TextColor = System.Drawing.Color.LightGray;
            this.viaGrilleNumérique.EnabledAppearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaGrilleNumérique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viaGrilleNumérique.Location = new System.Drawing.Point(17, 29);
            this.viaGrilleNumérique.Maximum = 999;
            this.viaGrilleNumérique.Minimum = -99;
            this.viaGrilleNumérique.Name = "viaGrilleNumérique";
            this.viaGrilleNumérique.RowCount = 1;
            this.viaGrilleNumérique.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaGrilleNumérique.Size = new System.Drawing.Size(808, 56);
            this.viaGrilleNumérique.SpecialValue = 0;
            this.viaGrilleNumérique.SpecialValueAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(79)))));
            this.viaGrilleNumérique.SpecialValueAppearance.ShowValue = true;
            this.viaGrilleNumérique.SpecialValueAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.viaGrilleNumérique.SpecialValueAppearance.TextColor = System.Drawing.Color.Silver;
            this.viaGrilleNumérique.TabIndex = 12;
            this.viaGrilleNumérique.Text = "visualIntArray1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnCinquièmeMotifCaractères);
            this.groupBox2.Controls.Add(this.vcaGrilleCaractères);
            this.groupBox2.Controls.Add(this.btnQuatrièmeMotifCaractères);
            this.groupBox2.Controls.Add(this.btnTroisièmeMotifCaractères);
            this.groupBox2.Controls.Add(this.btnPremierMotifCaractères);
            this.groupBox2.Controls.Add(this.btnDeuxièmeMotifCaractères);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 157);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motifs caractères";
            // 
            // btnCinquièmeMotifCaractères
            // 
            this.btnCinquièmeMotifCaractères.Location = new System.Drawing.Point(674, 99);
            this.btnCinquièmeMotifCaractères.Name = "btnCinquièmeMotifCaractères";
            this.btnCinquièmeMotifCaractères.Size = new System.Drawing.Size(155, 38);
            this.btnCinquièmeMotifCaractères.TabIndex = 21;
            this.btnCinquièmeMotifCaractères.Text = "5- Cinquième motif caractères";
            this.btnCinquièmeMotifCaractères.UseVisualStyleBackColor = true;
            this.btnCinquièmeMotifCaractères.Click += new System.EventHandler(this.BtnCinquièmeMotifCaractères_Click);
            // 
            // vcaGrilleCaractères
            // 
            this.vcaGrilleCaractères.AddressView = VisualArrays.enuAddressView.Mode1D;
            this.vcaGrilleCaractères.BackColor = System.Drawing.Color.White;
            this.vcaGrilleCaractères.CellMargin = 1;
            this.vcaGrilleCaractères.CellSize = new System.Drawing.Size(44, 46);
            this.vcaGrilleCaractères.ColumnCount = 17;
            this.vcaGrilleCaractères.DefaultValue = '.';
            this.vcaGrilleCaractères.Delay = 75;
            this.vcaGrilleCaractères.DisabledAppearance.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.vcaGrilleCaractères.DisabledAppearance.StrikeAppearance.Color = System.Drawing.SystemColors.ActiveCaption;
            this.vcaGrilleCaractères.DisabledAppearance.StrikeAppearance.Style = VisualArrays.enuStrikeStyle.Cross;
            this.vcaGrilleCaractères.DisabledAppearance.TextColor = System.Drawing.SystemColors.InactiveCaption;
            this.vcaGrilleCaractères.DragAppearance.ShowSource = false;
            this.vcaGrilleCaractères.EnabledAppearance.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcaGrilleCaractères.EnabledAppearance.Image = global::AppMotifs.Properties.Resources.FondBleu40X40;
            this.vcaGrilleCaractères.EnabledAppearance.Style = VisualArrays.enuBkgStyle.Image;
            this.vcaGrilleCaractères.EnabledAppearance.TextColor = System.Drawing.Color.DodgerBlue;
            this.vcaGrilleCaractères.GridAppearance.Color = System.Drawing.Color.PowderBlue;
            this.vcaGrilleCaractères.Location = new System.Drawing.Point(16, 19);
            this.vcaGrilleCaractères.Name = "vcaGrilleCaractères";
            this.vcaGrilleCaractères.ReadOnly = true;
            this.vcaGrilleCaractères.RowCount = 1;
            this.vcaGrilleCaractères.RowHeader.ForeColor = System.Drawing.Color.White;
            this.vcaGrilleCaractères.Size = new System.Drawing.Size(812, 62);
            this.vcaGrilleCaractères.TabIndex = 7;
            // 
            // btnQuatrièmeMotifCaractères
            // 
            this.btnQuatrièmeMotifCaractères.Location = new System.Drawing.Point(510, 99);
            this.btnQuatrièmeMotifCaractères.Name = "btnQuatrièmeMotifCaractères";
            this.btnQuatrièmeMotifCaractères.Size = new System.Drawing.Size(155, 38);
            this.btnQuatrièmeMotifCaractères.TabIndex = 20;
            this.btnQuatrièmeMotifCaractères.Text = "4- Quatrième motif caractères";
            this.btnQuatrièmeMotifCaractères.UseVisualStyleBackColor = true;
            this.btnQuatrièmeMotifCaractères.Click += new System.EventHandler(this.BtnQuatrièmeMotifCaractères_Click);
            // 
            // btnTroisièmeMotifCaractères
            // 
            this.btnTroisièmeMotifCaractères.Location = new System.Drawing.Point(344, 99);
            this.btnTroisièmeMotifCaractères.Name = "btnTroisièmeMotifCaractères";
            this.btnTroisièmeMotifCaractères.Size = new System.Drawing.Size(155, 38);
            this.btnTroisièmeMotifCaractères.TabIndex = 19;
            this.btnTroisièmeMotifCaractères.Text = "3- Troisième motif caractères";
            this.btnTroisièmeMotifCaractères.UseVisualStyleBackColor = true;
            this.btnTroisièmeMotifCaractères.Click += new System.EventHandler(this.BtnTroisièmeMotifCaractères_Click);
            // 
            // btnPremierMotifCaractères
            // 
            this.btnPremierMotifCaractères.Location = new System.Drawing.Point(16, 99);
            this.btnPremierMotifCaractères.Name = "btnPremierMotifCaractères";
            this.btnPremierMotifCaractères.Size = new System.Drawing.Size(155, 38);
            this.btnPremierMotifCaractères.TabIndex = 17;
            this.btnPremierMotifCaractères.Text = "1- Premier motif caractères";
            this.btnPremierMotifCaractères.UseVisualStyleBackColor = true;
            this.btnPremierMotifCaractères.Click += new System.EventHandler(this.BtnPremierMotifCaractères_Click);
            // 
            // btnDeuxièmeMotifCaractères
            // 
            this.btnDeuxièmeMotifCaractères.Location = new System.Drawing.Point(180, 99);
            this.btnDeuxièmeMotifCaractères.Name = "btnDeuxièmeMotifCaractères";
            this.btnDeuxièmeMotifCaractères.Size = new System.Drawing.Size(155, 38);
            this.btnDeuxièmeMotifCaractères.TabIndex = 18;
            this.btnDeuxièmeMotifCaractères.Text = "2- Deuxième motif caractères";
            this.btnDeuxièmeMotifCaractères.UseVisualStyleBackColor = true;
            this.btnDeuxièmeMotifCaractères.Click += new System.EventHandler(this.BtnDeuxièmeMotifCaractères_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnCinquièmeMotifBooléen);
            this.groupBox1.Controls.Add(this.btnQuatrièmeMotifBooléen);
            this.groupBox1.Controls.Add(this.btnTroisièmeMotifBooléen);
            this.groupBox1.Controls.Add(this.btnDeuxièmeMotifBooléen);
            this.groupBox1.Controls.Add(this.btnPremierMotifBooléen);
            this.groupBox1.Controls.Add(this.vbaGrilleBooléens);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 133);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motifs booléens";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCinquièmeMotifBooléen
            // 
            this.btnCinquièmeMotifBooléen.Location = new System.Drawing.Point(674, 79);
            this.btnCinquièmeMotifBooléen.Name = "btnCinquièmeMotifBooléen";
            this.btnCinquièmeMotifBooléen.Size = new System.Drawing.Size(155, 38);
            this.btnCinquièmeMotifBooléen.TabIndex = 16;
            this.btnCinquièmeMotifBooléen.Text = "5- Cinquième motif booléens";
            this.btnCinquièmeMotifBooléen.UseVisualStyleBackColor = true;
            this.btnCinquièmeMotifBooléen.Click += new System.EventHandler(this.BtnCinquièmeMotifBooléen_Click);
            // 
            // btnQuatrièmeMotifBooléen
            // 
            this.btnQuatrièmeMotifBooléen.Location = new System.Drawing.Point(510, 79);
            this.btnQuatrièmeMotifBooléen.Name = "btnQuatrièmeMotifBooléen";
            this.btnQuatrièmeMotifBooléen.Size = new System.Drawing.Size(155, 38);
            this.btnQuatrièmeMotifBooléen.TabIndex = 15;
            this.btnQuatrièmeMotifBooléen.Text = "4- Quatrième motif booléens";
            this.btnQuatrièmeMotifBooléen.UseVisualStyleBackColor = true;
            this.btnQuatrièmeMotifBooléen.Click += new System.EventHandler(this.BtnQuatrièmeMotifBooléen_Click);
            // 
            // btnTroisièmeMotifBooléen
            // 
            this.btnTroisièmeMotifBooléen.Location = new System.Drawing.Point(344, 79);
            this.btnTroisièmeMotifBooléen.Name = "btnTroisièmeMotifBooléen";
            this.btnTroisièmeMotifBooléen.Size = new System.Drawing.Size(155, 38);
            this.btnTroisièmeMotifBooléen.TabIndex = 14;
            this.btnTroisièmeMotifBooléen.Text = "3- Troisième motif booléens";
            this.btnTroisièmeMotifBooléen.UseVisualStyleBackColor = true;
            this.btnTroisièmeMotifBooléen.Click += new System.EventHandler(this.BtnTroisièmeMotifBooléen_Click);
            // 
            // btnDeuxièmeMotifBooléen
            // 
            this.btnDeuxièmeMotifBooléen.Location = new System.Drawing.Point(180, 79);
            this.btnDeuxièmeMotifBooléen.Name = "btnDeuxièmeMotifBooléen";
            this.btnDeuxièmeMotifBooléen.Size = new System.Drawing.Size(155, 38);
            this.btnDeuxièmeMotifBooléen.TabIndex = 13;
            this.btnDeuxièmeMotifBooléen.Text = "2- Deuxième motif booléens";
            this.btnDeuxièmeMotifBooléen.UseVisualStyleBackColor = true;
            this.btnDeuxièmeMotifBooléen.Click += new System.EventHandler(this.BtnDeuxièmeMotifBooléen_Click);
            // 
            // btnPremierMotifBooléen
            // 
            this.btnPremierMotifBooléen.Location = new System.Drawing.Point(16, 79);
            this.btnPremierMotifBooléen.Name = "btnPremierMotifBooléen";
            this.btnPremierMotifBooléen.Size = new System.Drawing.Size(155, 38);
            this.btnPremierMotifBooléen.TabIndex = 8;
            this.btnPremierMotifBooléen.Text = "1- Premier motif booléens";
            this.btnPremierMotifBooléen.UseVisualStyleBackColor = true;
            this.btnPremierMotifBooléen.Click += new System.EventHandler(this.BtnPremierMotifBooléen_Click);
            // 
            // vbaGrilleBooléens
            // 
            this.vbaGrilleBooléens.AddressView = VisualArrays.enuAddressView.Mode1D;
            this.vbaGrilleBooléens.BackColor = System.Drawing.Color.Black;
            this.vbaGrilleBooléens.CellMargin = 0;
            this.vbaGrilleBooléens.CellSize = new System.Drawing.Size(39, 35);
            this.vbaGrilleBooléens.ColumnCount = 20;
            this.vbaGrilleBooléens.Delay = 75;
            this.vbaGrilleBooléens.EnabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.vbaGrilleBooléens.EnabledAppearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.vbaGrilleBooléens.EnabledAppearance.Style = VisualArrays.enuBkgStyle.Image;
            this.vbaGrilleBooléens.ForeColor = System.Drawing.Color.Silver;
            this.vbaGrilleBooléens.Location = new System.Drawing.Point(17, 19);
            this.vbaGrilleBooléens.Name = "vbaGrilleBooléens";
            this.vbaGrilleBooléens.RowCount = 1;
            this.vbaGrilleBooléens.RowHeader.ForeColor = System.Drawing.Color.White;
            this.vbaGrilleBooléens.Size = new System.Drawing.Size(813, 49);
            this.vbaGrilleBooléens.SpecialValueAppearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.vbaGrilleBooléens.SpecialValueAppearance.Style = VisualArrays.enuBkgStyle.Image;
            this.vbaGrilleBooléens.TabIndex = 12;
            // 
            // FrmQ4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 529);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmQ4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formatif #1 Q4 : Motifs à reproduire (Matériel)";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private VisualArrays.VisualBoolArray vbaGrilleBooléens;
        private VisualArrays.VisualCharArray vcaGrilleCaractères;
        private VisualArrays.VisualIntArray viaGrilleNumérique;
        private System.Windows.Forms.Button btnCinquièmeMotifNumérique;
        private System.Windows.Forms.Button btnQuatrièmeMotifNumérique;
        private System.Windows.Forms.Button btnTroisièmeMotifNumérique;
        private System.Windows.Forms.Button btnPremierMotifNumérique;
        private System.Windows.Forms.Button btnDeuxièmeMotifNumérique;
        private System.Windows.Forms.Button btnCinquièmeMotifCaractères;
        private System.Windows.Forms.Button btnQuatrièmeMotifCaractères;
        private System.Windows.Forms.Button btnTroisièmeMotifCaractères;
        private System.Windows.Forms.Button btnPremierMotifCaractères;
        private System.Windows.Forms.Button btnDeuxièmeMotifCaractères;
        private System.Windows.Forms.Button btnCinquièmeMotifBooléen;
        private System.Windows.Forms.Button btnQuatrièmeMotifBooléen;
        private System.Windows.Forms.Button btnTroisièmeMotifBooléen;
        private System.Windows.Forms.Button btnDeuxièmeMotifBooléen;
        private System.Windows.Forms.Button btnPremierMotifBooléen;
    }
}

