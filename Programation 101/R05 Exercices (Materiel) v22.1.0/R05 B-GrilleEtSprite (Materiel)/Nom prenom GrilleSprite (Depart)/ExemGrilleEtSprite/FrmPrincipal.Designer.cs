namespace ExemGrilleEtSprite
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
            this.lblDisplayIndex = new System.Windows.Forms.Label();
            this.btnIndexPrecedent = new System.Windows.Forms.Button();
            this.btnIndexSuivant = new System.Windows.Forms.Button();
            this.bvaGrille = new VisualArrays.BaseGrid();
            this.sprJoueur = new VisualArrays.ImageSprite();
            this.vsiPosition = new VisualArrays.VisualCells.VisualInt();
            this.vsbSpriteEstVisible = new VisualArrays.VisualCells.VisualBool();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDisplayIndex
            // 
            this.lblDisplayIndex.Location = new System.Drawing.Point(378, 176);
            this.lblDisplayIndex.Name = "lblDisplayIndex";
            this.lblDisplayIndex.Size = new System.Drawing.Size(142, 18);
            this.lblDisplayIndex.TabIndex = 17;
            this.lblDisplayIndex.Text = "Changer le DisplayIndex";
            // 
            // btnIndexPrecedent
            // 
            this.btnIndexPrecedent.Font = new System.Drawing.Font("Wingdings 3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnIndexPrecedent.Location = new System.Drawing.Point(376, 117);
            this.btnIndexPrecedent.Name = "btnIndexPrecedent";
            this.btnIndexPrecedent.Size = new System.Drawing.Size(162, 38);
            this.btnIndexPrecedent.TabIndex = 5;
            this.btnIndexPrecedent.Text = "f";
            this.btnIndexPrecedent.UseVisualStyleBackColor = true;
            this.btnIndexPrecedent.Click += new System.EventHandler(this.btnIndexPrecedent_Click);
            // 
            // btnIndexSuivant
            // 
            this.btnIndexSuivant.Font = new System.Drawing.Font("Wingdings 3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnIndexSuivant.Location = new System.Drawing.Point(376, 49);
            this.btnIndexSuivant.Name = "btnIndexSuivant";
            this.btnIndexSuivant.Size = new System.Drawing.Size(162, 38);
            this.btnIndexSuivant.TabIndex = 4;
            this.btnIndexSuivant.Text = "g";
            this.btnIndexSuivant.UseVisualStyleBackColor = true;
            this.btnIndexSuivant.Click += new System.EventHandler(this.btnIndexSuivant_Click);
            // 
            // bvaGrille
            // 
            this.bvaGrille.AddressView = VisualArrays.enuAddressView.Mode1D;
            this.bvaGrille.BackColor = System.Drawing.Color.Black;
            this.bvaGrille.CellSize = new System.Drawing.Size(56, 62);
            this.bvaGrille.ColumnCount = 5;
            this.bvaGrille.EnabledAppearance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bvaGrille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bvaGrille.ForeColor = System.Drawing.Color.DimGray;
            this.bvaGrille.Location = new System.Drawing.Point(21, 22);
            this.bvaGrille.Name = "bvaGrille";
            this.bvaGrille.Padding = new System.Windows.Forms.Padding(4);
            this.bvaGrille.RowCount = 4;
            this.bvaGrille.RowHeader.ForeColor = System.Drawing.Color.White;
            this.bvaGrille.Size = new System.Drawing.Size(314, 277);
            this.bvaGrille.Sprites.AddRange(new VisualArrays.Sprite[] {
            this.sprJoueur});
            this.bvaGrille.TabIndex = 20;
            // 
            // sprJoueur
            // 
            this.sprJoueur.Duration = 200;
            this.sprJoueur.Image = global::ExemGrilleEtSprite.Properties.Resources.cool_icon;
            this.sprJoueur.Name = "sprJoueur";
            this.sprJoueur.Size = new System.Drawing.Size(48, 48);
            // 
            // vsiPosition
            // 
            this.vsiPosition.BackColor = System.Drawing.Color.White;
            this.vsiPosition.FocusColor = System.Drawing.Color.Gray;
            this.vsiPosition.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiPosition.Location = new System.Drawing.Point(376, 195);
            this.vsiPosition.Maximum = 19;
            this.vsiPosition.Minimum = 0;
            this.vsiPosition.Name = "vsiPosition";
            this.vsiPosition.Size = new System.Drawing.Size(162, 38);
            this.vsiPosition.TabIndex = 26;
            this.vsiPosition.ValueChanged += new System.EventHandler(this.vsiPosition_ValueChanged);
            // 
            // vsbSpriteEstVisible
            // 
            this.vsbSpriteEstVisible.FocusColor = System.Drawing.Color.Gray;
            this.vsbSpriteEstVisible.Location = new System.Drawing.Point(470, 267);
            this.vsbSpriteEstVisible.Name = "vsbSpriteEstVisible";
            this.vsbSpriteEstVisible.Size = new System.Drawing.Size(68, 23);
            this.vsbSpriteEstVisible.TabIndex = 26;
            this.vsbSpriteEstVisible.Value = true;
            this.vsbSpriteEstVisible.ValueAppearance.False.Image = global::ExemGrilleEtSprite.Properties.Resources.Off;
            this.vsbSpriteEstVisible.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbSpriteEstVisible.ValueAppearance.True.Image = global::ExemGrilleEtSprite.Properties.Resources.On;
            this.vsbSpriteEstVisible.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbSpriteEstVisible.ValueChanged += new System.EventHandler(this.vsbSpriteEstVisible_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(373, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "sprJoueur visible :";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(378, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Incrémenter le DisplayIndex :";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(378, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "Décrémenter le DisplayIndex :";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 322);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vsiPosition);
            this.Controls.Add(this.bvaGrille);
            this.Controls.Add(this.btnIndexSuivant);
            this.Controls.Add(this.btnIndexPrecedent);
            this.Controls.Add(this.vsbSpriteEstVisible);
            this.Controls.Add(this.lblDisplayIndex);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grille et Sprite : Introduction";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDisplayIndex;
        private System.Windows.Forms.Button btnIndexPrecedent;
        private System.Windows.Forms.Button btnIndexSuivant;
        private VisualArrays.BaseGrid bvaGrille;
        private VisualArrays.ImageSprite sprJoueur;
        private VisualArrays.VisualCells.VisualBool vsbSpriteEstVisible;
        private VisualArrays.VisualCells.VisualInt vsiPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

