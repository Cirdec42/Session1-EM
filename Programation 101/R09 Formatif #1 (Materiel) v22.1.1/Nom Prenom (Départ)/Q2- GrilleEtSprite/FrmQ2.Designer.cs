namespace ExemGrilleEtSprite
{
    partial class FrmQ2
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
            this.lblDéplacement = new System.Windows.Forms.Label();
            this.btnReculerSprite = new System.Windows.Forms.Button();
            this.btnAvancerSprite = new System.Windows.Forms.Button();
            this.bvaGrille = new VisualArrays.BaseGrid();
            this.sprJoueur = new VisualArrays.ImageSprite();
            this.vsiDéplacement = new VisualArrays.VisualCells.VisualInt();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCirculaire = new System.Windows.Forms.Label();
            this.vsbDéplacementCirculaire = new VisualArrays.VisualCells.VisualBool();
            this.SuspendLayout();
            // 
            // lblDéplacement
            // 
            this.lblDéplacement.Location = new System.Drawing.Point(161, 150);
            this.lblDéplacement.Name = "lblDéplacement";
            this.lblDéplacement.Size = new System.Drawing.Size(71, 18);
            this.lblDéplacement.TabIndex = 5;
            this.lblDéplacement.Text = "Déplacement";
            // 
            // btnReculerSprite
            // 
            this.btnReculerSprite.Font = new System.Drawing.Font("Wingdings 3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnReculerSprite.Location = new System.Drawing.Point(24, 168);
            this.btnReculerSprite.Name = "btnReculerSprite";
            this.btnReculerSprite.Size = new System.Drawing.Size(129, 38);
            this.btnReculerSprite.TabIndex = 4;
            this.btnReculerSprite.Text = "f";
            this.btnReculerSprite.UseVisualStyleBackColor = true;
            this.btnReculerSprite.Click += new System.EventHandler(this.btnReculerSprite_Click);
            // 
            // btnAvancerSprite
            // 
            this.btnAvancerSprite.Font = new System.Drawing.Font("Wingdings 3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnAvancerSprite.Location = new System.Drawing.Point(238, 168);
            this.btnAvancerSprite.Name = "btnAvancerSprite";
            this.btnAvancerSprite.Size = new System.Drawing.Size(129, 38);
            this.btnAvancerSprite.TabIndex = 2;
            this.btnAvancerSprite.Text = "g";
            this.btnAvancerSprite.UseVisualStyleBackColor = true;
            this.btnAvancerSprite.Click += new System.EventHandler(this.btnAvancerSprite_Click);
            // 
            // bvaGrille
            // 
            this.bvaGrille.AddressView = VisualArrays.enuAddressView.Mode1D;
            this.bvaGrille.BackColor = System.Drawing.Color.Black;
            this.bvaGrille.CellSize = new System.Drawing.Size(56, 62);
            this.bvaGrille.ColumnCount = 10;
            this.bvaGrille.ColumnHeader.Visible = true;
            this.bvaGrille.EnabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bvaGrille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bvaGrille.ForeColor = System.Drawing.Color.DimGray;
            this.bvaGrille.Location = new System.Drawing.Point(21, 22);
            this.bvaGrille.Name = "bvaGrille";
            this.bvaGrille.Padding = new System.Windows.Forms.Padding(4);
            this.bvaGrille.RowCount = 1;
            this.bvaGrille.RowHeader.ForeColor = System.Drawing.Color.White;
            this.bvaGrille.Size = new System.Drawing.Size(619, 96);
            this.bvaGrille.Sprites.AddRange(new VisualArrays.Sprite[] {
            this.sprJoueur});
            this.bvaGrille.TabIndex = 0;
            this.bvaGrille.TabStop = false;
            // 
            // sprJoueur
            // 
            this.sprJoueur.Duration = 200;
            this.sprJoueur.Image = global::ExemGrilleEtSprite.Properties.Resources.cool_icon;
            this.sprJoueur.Name = "sprJoueur";
            this.sprJoueur.Size = new System.Drawing.Size(48, 48);
            // 
            // vsiDéplacement
            // 
            this.vsiDéplacement.BackColor = System.Drawing.Color.White;
            this.vsiDéplacement.FocusColor = System.Drawing.Color.Gray;
            this.vsiDéplacement.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiDéplacement.Location = new System.Drawing.Point(159, 168);
            this.vsiDéplacement.Maximum = 10;
            this.vsiDéplacement.Minimum = 1;
            this.vsiDéplacement.Name = "vsiDéplacement";
            this.vsiDéplacement.Size = new System.Drawing.Size(73, 38);
            this.vsiDéplacement.TabIndex = 6;
            this.vsiDéplacement.Value = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(239, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Avancer le Sprite selon la valeur du déplacement";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(26, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 27);
            this.label6.TabIndex = 3;
            this.label6.Text = "Reculer le Sprite selon la valeur du déplacement";
            // 
            // lblCirculaire
            // 
            this.lblCirculaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCirculaire.Location = new System.Drawing.Point(483, 185);
            this.lblCirculaire.Name = "lblCirculaire";
            this.lblCirculaire.Size = new System.Drawing.Size(83, 18);
            this.lblCirculaire.TabIndex = 7;
            this.lblCirculaire.Text = "Circulaire :";
            // 
            // vsbDéplacementCirculaire
            // 
            this.vsbDéplacementCirculaire.FocusColor = System.Drawing.Color.Gray;
            this.vsbDéplacementCirculaire.Location = new System.Drawing.Point(572, 183);
            this.vsbDéplacementCirculaire.Name = "vsbDéplacementCirculaire";
            this.vsbDéplacementCirculaire.Size = new System.Drawing.Size(68, 23);
            this.vsbDéplacementCirculaire.TabIndex = 8;
            this.vsbDéplacementCirculaire.TabStop = false;
            this.vsbDéplacementCirculaire.Value = true;
            this.vsbDéplacementCirculaire.ValueAppearance.False.Image = global::ExemGrilleEtSprite.Properties.Resources.Off;
            this.vsbDéplacementCirculaire.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbDéplacementCirculaire.ValueAppearance.True.Image = global::ExemGrilleEtSprite.Properties.Resources.On;
            this.vsbDéplacementCirculaire.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // FrmQ2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 229);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vsiDéplacement);
            this.Controls.Add(this.bvaGrille);
            this.Controls.Add(this.btnAvancerSprite);
            this.Controls.Add(this.btnReculerSprite);
            this.Controls.Add(this.vsbDéplacementCirculaire);
            this.Controls.Add(this.lblDéplacement);
            this.Controls.Add(this.lblCirculaire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmQ2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formatif #1 Q2 : Grille et Sprite";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDéplacement;
        private System.Windows.Forms.Button btnReculerSprite;
        private System.Windows.Forms.Button btnAvancerSprite;
        private VisualArrays.BaseGrid bvaGrille;
        private VisualArrays.ImageSprite sprJoueur;
        private VisualArrays.VisualCells.VisualInt vsiDéplacement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCirculaire;
        private VisualArrays.VisualCells.VisualBool vsbDéplacementCirculaire;
    }
}

