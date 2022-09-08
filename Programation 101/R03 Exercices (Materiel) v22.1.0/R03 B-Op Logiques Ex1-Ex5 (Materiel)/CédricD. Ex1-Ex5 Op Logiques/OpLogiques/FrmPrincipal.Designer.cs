namespace IfSimples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.tabIfSimples = new System.Windows.Forms.TabControl();
            this.tabEx1 = new System.Windows.Forms.TabPage();
            this.panExercice1 = new System.Windows.Forms.Panel();
            this.btnInverserÉtatAvecAssignation = new System.Windows.Forms.Button();
            this.btnInverserÉtatAvecif = new System.Windows.Forms.Button();
            this.vsbLumièreOpLogiqueNon = new VisualArrays.VisualCells.VisualBool();
            this.lblExercice1 = new System.Windows.Forms.Label();
            this.tabEx2 = new System.Windows.Forms.TabPage();
            this.panExercice2 = new System.Windows.Forms.Panel();
            this.lblCliquerLumierePourInverserEt = new System.Windows.Forms.Label();
            this.lblRésultatOpLogiquetEt = new System.Windows.Forms.Label();
            this.btnEvaluerOpLogiqueEt = new System.Windows.Forms.Button();
            this.panEx2Separateur = new System.Windows.Forms.Panel();
            this.vsbOpEtRésultat = new VisualArrays.VisualCells.VisualBool();
            this.vsbOpEtLum3 = new VisualArrays.VisualCells.VisualBool();
            this.vsbOpEtLum2 = new VisualArrays.VisualCells.VisualBool();
            this.vsbOpEtLum1 = new VisualArrays.VisualCells.VisualBool();
            this.lblOpLogiqueET = new System.Windows.Forms.Label();
            this.tabEx3 = new System.Windows.Forms.TabPage();
            this.panExercice3 = new System.Windows.Forms.Panel();
            this.lblCliquerLumierePourInverserOU = new System.Windows.Forms.Label();
            this.lblRésultatOpLogiqueOu = new System.Windows.Forms.Label();
            this.btnEvaluerOpLogiqueOu = new System.Windows.Forms.Button();
            this.panEx3Separateur = new System.Windows.Forms.Panel();
            this.vsbOpOuRésultat = new VisualArrays.VisualCells.VisualBool();
            this.vsbOpOuLum3 = new VisualArrays.VisualCells.VisualBool();
            this.vsbOpOuLum2 = new VisualArrays.VisualCells.VisualBool();
            this.vsbOpOuLum1 = new VisualArrays.VisualCells.VisualBool();
            this.lblOpLogiqueOU = new System.Windows.Forms.Label();
            this.tabEx4 = new System.Windows.Forms.TabPage();
            this.lblExercice4 = new System.Windows.Forms.Label();
            this.panExercice4 = new System.Windows.Forms.Panel();
            this.lblNombresPairs = new System.Windows.Forms.Label();
            this.vsbNombresPairs = new VisualArrays.VisualCells.VisualBool();
            this.lblNombreEgaux = new System.Windows.Forms.Label();
            this.lblNombre3 = new System.Windows.Forms.Label();
            this.vsiNombre2 = new VisualArrays.VisualCells.VisualInt();
            this.vsiNombre3 = new VisualArrays.VisualCells.VisualInt();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.btnComparer3Nombres = new System.Windows.Forms.Button();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.vsiNombre1 = new VisualArrays.VisualCells.VisualInt();
            this.vsbNombresEgaux = new VisualArrays.VisualCells.VisualBool();
            this.tabEx5 = new System.Windows.Forms.TabPage();
            this.lblExercice5 = new System.Windows.Forms.Label();
            this.panExercice5 = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.vsiScore = new VisualArrays.VisualCells.VisualInt();
            this.btnEvaluerMainCartes = new System.Windows.Forms.Button();
            this.panEx5Separateur = new System.Windows.Forms.Panel();
            this.btnChoisirCartes = new System.Windows.Forms.Button();
            this.lblCarte3 = new System.Windows.Forms.Label();
            this.vsiCarte3 = new VisualArrays.VisualCells.VisualInt();
            this.imlCartes = new System.Windows.Forms.ImageList(this.components);
            this.vsiCarte1 = new VisualArrays.VisualCells.VisualInt();
            this.lblCarte2 = new System.Windows.Forms.Label();
            this.vsiCarte2 = new VisualArrays.VisualCells.VisualInt();
            this.lblCarte1 = new System.Windows.Forms.Label();
            this.tabIfSimples.SuspendLayout();
            this.tabEx1.SuspendLayout();
            this.panExercice1.SuspendLayout();
            this.tabEx2.SuspendLayout();
            this.panExercice2.SuspendLayout();
            this.tabEx3.SuspendLayout();
            this.panExercice3.SuspendLayout();
            this.tabEx4.SuspendLayout();
            this.panExercice4.SuspendLayout();
            this.tabEx5.SuspendLayout();
            this.panExercice5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabIfSimples
            // 
            this.tabIfSimples.Controls.Add(this.tabEx1);
            this.tabIfSimples.Controls.Add(this.tabEx2);
            this.tabIfSimples.Controls.Add(this.tabEx3);
            this.tabIfSimples.Controls.Add(this.tabEx4);
            this.tabIfSimples.Controls.Add(this.tabEx5);
            this.tabIfSimples.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabIfSimples.Location = new System.Drawing.Point(12, 27);
            this.tabIfSimples.Name = "tabIfSimples";
            this.tabIfSimples.SelectedIndex = 0;
            this.tabIfSimples.Size = new System.Drawing.Size(649, 357);
            this.tabIfSimples.TabIndex = 0;
            // 
            // tabEx1
            // 
            this.tabEx1.Controls.Add(this.panExercice1);
            this.tabEx1.Controls.Add(this.lblExercice1);
            this.tabEx1.Location = new System.Drawing.Point(4, 27);
            this.tabEx1.Name = "tabEx1";
            this.tabEx1.Padding = new System.Windows.Forms.Padding(3);
            this.tabEx1.Size = new System.Drawing.Size(641, 326);
            this.tabEx1.TabIndex = 6;
            this.tabEx1.Text = "Exercice 1";
            // 
            // panExercice1
            // 
            this.panExercice1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panExercice1.Controls.Add(this.btnInverserÉtatAvecAssignation);
            this.panExercice1.Controls.Add(this.btnInverserÉtatAvecif);
            this.panExercice1.Controls.Add(this.vsbLumièreOpLogiqueNon);
            this.panExercice1.Location = new System.Drawing.Point(14, 49);
            this.panExercice1.Name = "panExercice1";
            this.panExercice1.Size = new System.Drawing.Size(611, 261);
            this.panExercice1.TabIndex = 1;
            // 
            // btnInverserÉtatAvecAssignation
            // 
            this.btnInverserÉtatAvecAssignation.Location = new System.Drawing.Point(29, 148);
            this.btnInverserÉtatAvecAssignation.Name = "btnInverserÉtatAvecAssignation";
            this.btnInverserÉtatAvecAssignation.Size = new System.Drawing.Size(337, 51);
            this.btnInverserÉtatAvecAssignation.TabIndex = 2;
            this.btnInverserÉtatAvecAssignation.Text = "Inverser l\'état de la lumière\r\nVersion courte - avec une assignation";
            this.btnInverserÉtatAvecAssignation.UseVisualStyleBackColor = true;
            this.btnInverserÉtatAvecAssignation.Click += new System.EventHandler(this.btnInverserÉtatAvecAssigantion_Click);
            // 
            // btnInverserÉtatAvecif
            // 
            this.btnInverserÉtatAvecif.Location = new System.Drawing.Point(29, 47);
            this.btnInverserÉtatAvecif.Name = "btnInverserÉtatAvecif";
            this.btnInverserÉtatAvecif.Size = new System.Drawing.Size(337, 51);
            this.btnInverserÉtatAvecif.TabIndex = 1;
            this.btnInverserÉtatAvecif.Text = "Inverser l\'état de la lumière\r\nVersion longue - avec if";
            this.btnInverserÉtatAvecif.UseVisualStyleBackColor = true;
            this.btnInverserÉtatAvecif.Click += new System.EventHandler(this.btnInverserÉtatAvecif_Click);
            // 
            // vsbLumièreOpLogiqueNon
            // 
            this.vsbLumièreOpLogiqueNon.FocusColor = System.Drawing.Color.Gray;
            this.vsbLumièreOpLogiqueNon.Location = new System.Drawing.Point(427, 47);
            this.vsbLumièreOpLogiqueNon.Name = "vsbLumièreOpLogiqueNon";
            this.vsbLumièreOpLogiqueNon.ReadOnly = true;
            this.vsbLumièreOpLogiqueNon.Size = new System.Drawing.Size(108, 152);
            this.vsbLumièreOpLogiqueNon.TabIndex = 0;
            this.vsbLumièreOpLogiqueNon.Toggle = false;
            this.vsbLumièreOpLogiqueNon.ValueAppearance.False.Image = global::IfSimples.Properties.Resources.LightOff;
            this.vsbLumièreOpLogiqueNon.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbLumièreOpLogiqueNon.ValueAppearance.True.Image = global::IfSimples.Properties.Resources.LightOn;
            this.vsbLumièreOpLogiqueNon.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // lblExercice1
            // 
            this.lblExercice1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblExercice1.Location = new System.Drawing.Point(14, 19);
            this.lblExercice1.Name = "lblExercice1";
            this.lblExercice1.Size = new System.Drawing.Size(611, 24);
            this.lblExercice1.TabIndex = 0;
            this.lblExercice1.Text = "Opérateur logique unaire NON";
            // 
            // tabEx2
            // 
            this.tabEx2.Controls.Add(this.panExercice2);
            this.tabEx2.Controls.Add(this.lblOpLogiqueET);
            this.tabEx2.Location = new System.Drawing.Point(4, 27);
            this.tabEx2.Name = "tabEx2";
            this.tabEx2.Padding = new System.Windows.Forms.Padding(3);
            this.tabEx2.Size = new System.Drawing.Size(641, 326);
            this.tabEx2.TabIndex = 0;
            this.tabEx2.Text = "Exercice 2";
            // 
            // panExercice2
            // 
            this.panExercice2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panExercice2.Controls.Add(this.lblCliquerLumierePourInverserEt);
            this.panExercice2.Controls.Add(this.lblRésultatOpLogiquetEt);
            this.panExercice2.Controls.Add(this.btnEvaluerOpLogiqueEt);
            this.panExercice2.Controls.Add(this.panEx2Separateur);
            this.panExercice2.Controls.Add(this.vsbOpEtRésultat);
            this.panExercice2.Controls.Add(this.vsbOpEtLum3);
            this.panExercice2.Controls.Add(this.vsbOpEtLum2);
            this.panExercice2.Controls.Add(this.vsbOpEtLum1);
            this.panExercice2.Location = new System.Drawing.Point(14, 49);
            this.panExercice2.Name = "panExercice2";
            this.panExercice2.Size = new System.Drawing.Size(611, 261);
            this.panExercice2.TabIndex = 1;
            // 
            // lblCliquerLumierePourInverserEt
            // 
            this.lblCliquerLumierePourInverserEt.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblCliquerLumierePourInverserEt.Location = new System.Drawing.Point(28, 13);
            this.lblCliquerLumierePourInverserEt.Name = "lblCliquerLumierePourInverserEt";
            this.lblCliquerLumierePourInverserEt.Size = new System.Drawing.Size(339, 53);
            this.lblCliquerLumierePourInverserEt.TabIndex = 0;
            this.lblCliquerLumierePourInverserEt.Text = "Cliquer sur une lumière \r\npour inverser son état";
            this.lblCliquerLumierePourInverserEt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRésultatOpLogiquetEt
            // 
            this.lblRésultatOpLogiquetEt.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblRésultatOpLogiquetEt.Location = new System.Drawing.Point(449, 54);
            this.lblRésultatOpLogiquetEt.Name = "lblRésultatOpLogiquetEt";
            this.lblRésultatOpLogiquetEt.Size = new System.Drawing.Size(111, 27);
            this.lblRésultatOpLogiquetEt.TabIndex = 5;
            this.lblRésultatOpLogiquetEt.Text = "Résultat";
            this.lblRésultatOpLogiquetEt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEvaluerOpLogiqueEt
            // 
            this.btnEvaluerOpLogiqueEt.Location = new System.Drawing.Point(452, 20);
            this.btnEvaluerOpLogiqueEt.Name = "btnEvaluerOpLogiqueEt";
            this.btnEvaluerOpLogiqueEt.Size = new System.Drawing.Size(108, 31);
            this.btnEvaluerOpLogiqueEt.TabIndex = 7;
            this.btnEvaluerOpLogiqueEt.Text = "&Évaluer";
            this.btnEvaluerOpLogiqueEt.UseVisualStyleBackColor = true;
            this.btnEvaluerOpLogiqueEt.Click += new System.EventHandler(this.btnEvaluerOpLogiqueET_Click);
            // 
            // panEx2Separateur
            // 
            this.panEx2Separateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panEx2Separateur.Location = new System.Drawing.Point(405, 2);
            this.panEx2Separateur.Name = "panEx2Separateur";
            this.panEx2Separateur.Size = new System.Drawing.Size(2, 254);
            this.panEx2Separateur.TabIndex = 4;
            // 
            // vsbOpEtRésultat
            // 
            this.vsbOpEtRésultat.FocusColor = System.Drawing.Color.Gray;
            this.vsbOpEtRésultat.Location = new System.Drawing.Point(452, 84);
            this.vsbOpEtRésultat.Name = "vsbOpEtRésultat";
            this.vsbOpEtRésultat.ReadOnly = true;
            this.vsbOpEtRésultat.Size = new System.Drawing.Size(108, 152);
            this.vsbOpEtRésultat.TabIndex = 6;
            this.vsbOpEtRésultat.Toggle = false;
            this.vsbOpEtRésultat.ValueAppearance.False.Image = global::IfSimples.Properties.Resources.LightOff;
            this.vsbOpEtRésultat.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbOpEtRésultat.ValueAppearance.True.Image = global::IfSimples.Properties.Resources.LightOn;
            this.vsbOpEtRésultat.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // vsbOpEtLum3
            // 
            this.vsbOpEtLum3.FocusColor = System.Drawing.Color.Gray;
            this.vsbOpEtLum3.Location = new System.Drawing.Point(259, 84);
            this.vsbOpEtLum3.Name = "vsbOpEtLum3";
            this.vsbOpEtLum3.Size = new System.Drawing.Size(108, 152);
            this.vsbOpEtLum3.TabIndex = 3;
            this.vsbOpEtLum3.ValueAppearance.False.Image = global::IfSimples.Properties.Resources.LightOff;
            this.vsbOpEtLum3.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbOpEtLum3.ValueAppearance.True.Image = global::IfSimples.Properties.Resources.LightOn;
            this.vsbOpEtLum3.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // vsbOpEtLum2
            // 
            this.vsbOpEtLum2.FocusColor = System.Drawing.Color.Gray;
            this.vsbOpEtLum2.Location = new System.Drawing.Point(145, 84);
            this.vsbOpEtLum2.Name = "vsbOpEtLum2";
            this.vsbOpEtLum2.Size = new System.Drawing.Size(108, 152);
            this.vsbOpEtLum2.TabIndex = 2;
            this.vsbOpEtLum2.ValueAppearance.False.Image = global::IfSimples.Properties.Resources.LightOff;
            this.vsbOpEtLum2.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbOpEtLum2.ValueAppearance.True.Image = global::IfSimples.Properties.Resources.LightOn;
            this.vsbOpEtLum2.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // vsbOpEtLum1
            // 
            this.vsbOpEtLum1.FocusColor = System.Drawing.Color.Gray;
            this.vsbOpEtLum1.Location = new System.Drawing.Point(31, 84);
            this.vsbOpEtLum1.Name = "vsbOpEtLum1";
            this.vsbOpEtLum1.Size = new System.Drawing.Size(108, 152);
            this.vsbOpEtLum1.TabIndex = 1;
            this.vsbOpEtLum1.ValueAppearance.False.Image = global::IfSimples.Properties.Resources.LightOff;
            this.vsbOpEtLum1.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbOpEtLum1.ValueAppearance.True.Image = global::IfSimples.Properties.Resources.LightOn;
            this.vsbOpEtLum1.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // lblOpLogiqueET
            // 
            this.lblOpLogiqueET.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblOpLogiqueET.Location = new System.Drawing.Point(14, 19);
            this.lblOpLogiqueET.Name = "lblOpLogiqueET";
            this.lblOpLogiqueET.Size = new System.Drawing.Size(257, 24);
            this.lblOpLogiqueET.TabIndex = 0;
            this.lblOpLogiqueET.Text = "Opérateur logique ET";
            // 
            // tabEx3
            // 
            this.tabEx3.Controls.Add(this.panExercice3);
            this.tabEx3.Controls.Add(this.lblOpLogiqueOU);
            this.tabEx3.Location = new System.Drawing.Point(4, 27);
            this.tabEx3.Name = "tabEx3";
            this.tabEx3.Padding = new System.Windows.Forms.Padding(3);
            this.tabEx3.Size = new System.Drawing.Size(641, 326);
            this.tabEx3.TabIndex = 1;
            this.tabEx3.Text = "Exercice 3";
            // 
            // panExercice3
            // 
            this.panExercice3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panExercice3.Controls.Add(this.lblCliquerLumierePourInverserOU);
            this.panExercice3.Controls.Add(this.lblRésultatOpLogiqueOu);
            this.panExercice3.Controls.Add(this.btnEvaluerOpLogiqueOu);
            this.panExercice3.Controls.Add(this.panEx3Separateur);
            this.panExercice3.Controls.Add(this.vsbOpOuRésultat);
            this.panExercice3.Controls.Add(this.vsbOpOuLum3);
            this.panExercice3.Controls.Add(this.vsbOpOuLum2);
            this.panExercice3.Controls.Add(this.vsbOpOuLum1);
            this.panExercice3.Location = new System.Drawing.Point(14, 49);
            this.panExercice3.Name = "panExercice3";
            this.panExercice3.Size = new System.Drawing.Size(611, 261);
            this.panExercice3.TabIndex = 1;
            // 
            // lblCliquerLumierePourInverserOU
            // 
            this.lblCliquerLumierePourInverserOU.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblCliquerLumierePourInverserOU.Location = new System.Drawing.Point(28, 13);
            this.lblCliquerLumierePourInverserOU.Name = "lblCliquerLumierePourInverserOU";
            this.lblCliquerLumierePourInverserOU.Size = new System.Drawing.Size(339, 53);
            this.lblCliquerLumierePourInverserOU.TabIndex = 0;
            this.lblCliquerLumierePourInverserOU.Text = "Cliquer sur une lumière\r\npour inverser son état";
            this.lblCliquerLumierePourInverserOU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRésultatOpLogiqueOu
            // 
            this.lblRésultatOpLogiqueOu.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblRésultatOpLogiqueOu.Location = new System.Drawing.Point(449, 54);
            this.lblRésultatOpLogiqueOu.Name = "lblRésultatOpLogiqueOu";
            this.lblRésultatOpLogiqueOu.Size = new System.Drawing.Size(111, 27);
            this.lblRésultatOpLogiqueOu.TabIndex = 5;
            this.lblRésultatOpLogiqueOu.Text = "Résultat";
            this.lblRésultatOpLogiqueOu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEvaluerOpLogiqueOu
            // 
            this.btnEvaluerOpLogiqueOu.Location = new System.Drawing.Point(452, 20);
            this.btnEvaluerOpLogiqueOu.Name = "btnEvaluerOpLogiqueOu";
            this.btnEvaluerOpLogiqueOu.Size = new System.Drawing.Size(108, 31);
            this.btnEvaluerOpLogiqueOu.TabIndex = 7;
            this.btnEvaluerOpLogiqueOu.Text = "&Évaluer";
            this.btnEvaluerOpLogiqueOu.UseVisualStyleBackColor = true;
            this.btnEvaluerOpLogiqueOu.Click += new System.EventHandler(this.btnEvaluerEx2_Click);
            // 
            // panEx3Separateur
            // 
            this.panEx3Separateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panEx3Separateur.Location = new System.Drawing.Point(405, 2);
            this.panEx3Separateur.Name = "panEx3Separateur";
            this.panEx3Separateur.Size = new System.Drawing.Size(2, 254);
            this.panEx3Separateur.TabIndex = 4;
            // 
            // vsbOpOuRésultat
            // 
            this.vsbOpOuRésultat.FocusColor = System.Drawing.Color.Gray;
            this.vsbOpOuRésultat.Location = new System.Drawing.Point(452, 84);
            this.vsbOpOuRésultat.Name = "vsbOpOuRésultat";
            this.vsbOpOuRésultat.ReadOnly = true;
            this.vsbOpOuRésultat.Size = new System.Drawing.Size(108, 152);
            this.vsbOpOuRésultat.TabIndex = 6;
            this.vsbOpOuRésultat.Toggle = false;
            this.vsbOpOuRésultat.ValueAppearance.False.Image = global::IfSimples.Properties.Resources.LightOff;
            this.vsbOpOuRésultat.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbOpOuRésultat.ValueAppearance.True.Image = global::IfSimples.Properties.Resources.LightOn;
            this.vsbOpOuRésultat.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // vsbOpOuLum3
            // 
            this.vsbOpOuLum3.FocusColor = System.Drawing.Color.Gray;
            this.vsbOpOuLum3.Location = new System.Drawing.Point(259, 84);
            this.vsbOpOuLum3.Name = "vsbOpOuLum3";
            this.vsbOpOuLum3.Size = new System.Drawing.Size(108, 152);
            this.vsbOpOuLum3.TabIndex = 3;
            this.vsbOpOuLum3.ValueAppearance.False.Image = global::IfSimples.Properties.Resources.LightOff;
            this.vsbOpOuLum3.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbOpOuLum3.ValueAppearance.True.Image = global::IfSimples.Properties.Resources.LightOn;
            this.vsbOpOuLum3.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // vsbOpOuLum2
            // 
            this.vsbOpOuLum2.FocusColor = System.Drawing.Color.Gray;
            this.vsbOpOuLum2.Location = new System.Drawing.Point(145, 84);
            this.vsbOpOuLum2.Name = "vsbOpOuLum2";
            this.vsbOpOuLum2.Size = new System.Drawing.Size(108, 152);
            this.vsbOpOuLum2.TabIndex = 2;
            this.vsbOpOuLum2.ValueAppearance.False.Image = global::IfSimples.Properties.Resources.LightOff;
            this.vsbOpOuLum2.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbOpOuLum2.ValueAppearance.True.Image = global::IfSimples.Properties.Resources.LightOn;
            this.vsbOpOuLum2.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // vsbOpOuLum1
            // 
            this.vsbOpOuLum1.FocusColor = System.Drawing.Color.Gray;
            this.vsbOpOuLum1.Location = new System.Drawing.Point(31, 84);
            this.vsbOpOuLum1.Name = "vsbOpOuLum1";
            this.vsbOpOuLum1.Size = new System.Drawing.Size(108, 152);
            this.vsbOpOuLum1.TabIndex = 1;
            this.vsbOpOuLum1.ValueAppearance.False.Image = global::IfSimples.Properties.Resources.LightOff;
            this.vsbOpOuLum1.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbOpOuLum1.ValueAppearance.True.Image = global::IfSimples.Properties.Resources.LightOn;
            this.vsbOpOuLum1.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // lblOpLogiqueOU
            // 
            this.lblOpLogiqueOU.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblOpLogiqueOU.Location = new System.Drawing.Point(14, 19);
            this.lblOpLogiqueOU.Name = "lblOpLogiqueOU";
            this.lblOpLogiqueOU.Size = new System.Drawing.Size(257, 24);
            this.lblOpLogiqueOU.TabIndex = 0;
            this.lblOpLogiqueOU.Text = "Opérateur logique OU";
            // 
            // tabEx4
            // 
            this.tabEx4.Controls.Add(this.lblExercice4);
            this.tabEx4.Controls.Add(this.panExercice4);
            this.tabEx4.Location = new System.Drawing.Point(4, 27);
            this.tabEx4.Name = "tabEx4";
            this.tabEx4.Size = new System.Drawing.Size(641, 326);
            this.tabEx4.TabIndex = 2;
            this.tabEx4.Text = "Exercice 4";
            // 
            // lblExercice4
            // 
            this.lblExercice4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblExercice4.Location = new System.Drawing.Point(14, 19);
            this.lblExercice4.Name = "lblExercice4";
            this.lblExercice4.Size = new System.Drawing.Size(477, 24);
            this.lblExercice4.TabIndex = 0;
            this.lblExercice4.Text = "Déterminer si 3 nombres sont égaux et/ou pairs";
            // 
            // panExercice4
            // 
            this.panExercice4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panExercice4.Controls.Add(this.lblNombresPairs);
            this.panExercice4.Controls.Add(this.vsbNombresPairs);
            this.panExercice4.Controls.Add(this.lblNombreEgaux);
            this.panExercice4.Controls.Add(this.lblNombre3);
            this.panExercice4.Controls.Add(this.vsiNombre2);
            this.panExercice4.Controls.Add(this.vsiNombre3);
            this.panExercice4.Controls.Add(this.lblNombre2);
            this.panExercice4.Controls.Add(this.btnComparer3Nombres);
            this.panExercice4.Controls.Add(this.lblNombre1);
            this.panExercice4.Controls.Add(this.vsiNombre1);
            this.panExercice4.Controls.Add(this.vsbNombresEgaux);
            this.panExercice4.Location = new System.Drawing.Point(14, 49);
            this.panExercice4.Name = "panExercice4";
            this.panExercice4.Size = new System.Drawing.Size(611, 261);
            this.panExercice4.TabIndex = 1;
            // 
            // lblNombresPairs
            // 
            this.lblNombresPairs.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombresPairs.Location = new System.Drawing.Point(462, 25);
            this.lblNombresPairs.Name = "lblNombresPairs";
            this.lblNombresPairs.Size = new System.Drawing.Size(110, 22);
            this.lblNombresPairs.TabIndex = 8;
            this.lblNombresPairs.Text = "Nombres pairs";
            this.lblNombresPairs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vsbNombresPairs
            // 
            this.vsbNombresPairs.FocusColor = System.Drawing.Color.Gray;
            this.vsbNombresPairs.Location = new System.Drawing.Point(464, 50);
            this.vsbNombresPairs.Name = "vsbNombresPairs";
            this.vsbNombresPairs.ReadOnly = true;
            this.vsbNombresPairs.Size = new System.Drawing.Size(108, 152);
            this.vsbNombresPairs.TabIndex = 9;
            this.vsbNombresPairs.Toggle = false;
            this.vsbNombresPairs.ValueAppearance.False.Image = global::IfSimples.Properties.Resources.LightOff;
            this.vsbNombresPairs.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbNombresPairs.ValueAppearance.True.Image = global::IfSimples.Properties.Resources.LightOn;
            this.vsbNombresPairs.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // lblNombreEgaux
            // 
            this.lblNombreEgaux.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEgaux.Location = new System.Drawing.Point(325, 25);
            this.lblNombreEgaux.Name = "lblNombreEgaux";
            this.lblNombreEgaux.Size = new System.Drawing.Size(110, 22);
            this.lblNombreEgaux.TabIndex = 6;
            this.lblNombreEgaux.Text = "Nombres égaux";
            this.lblNombreEgaux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre3
            // 
            this.lblNombre3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre3.Location = new System.Drawing.Point(32, 122);
            this.lblNombre3.Name = "lblNombre3";
            this.lblNombre3.Size = new System.Drawing.Size(106, 23);
            this.lblNombre3.TabIndex = 4;
            this.lblNombre3.Text = "Nombre 3 :";
            this.lblNombre3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vsiNombre2
            // 
            this.vsiNombre2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vsiNombre2.FocusColor = System.Drawing.Color.Gray;
            this.vsiNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNombre2.ForeColor = System.Drawing.Color.Black;
            this.vsiNombre2.GraphAppearance.BarAlign = VisualArrays.enuBarAlign.Reverse;
            this.vsiNombre2.GraphAppearance.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.vsiNombre2.Location = new System.Drawing.Point(144, 85);
            this.vsiNombre2.Maximum = 125;
            this.vsiNombre2.Minimum = 0;
            this.vsiNombre2.Name = "vsiNombre2";
            this.vsiNombre2.Size = new System.Drawing.Size(103, 22);
            this.vsiNombre2.TabIndex = 3;
            this.vsiNombre2.Text = "visualInt2";
            // 
            // vsiNombre3
            // 
            this.vsiNombre3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vsiNombre3.FocusColor = System.Drawing.Color.Gray;
            this.vsiNombre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNombre3.ForeColor = System.Drawing.Color.Black;
            this.vsiNombre3.GraphAppearance.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.vsiNombre3.Location = new System.Drawing.Point(144, 122);
            this.vsiNombre3.Maximum = 125;
            this.vsiNombre3.Minimum = 0;
            this.vsiNombre3.Name = "vsiNombre3";
            this.vsiNombre3.Size = new System.Drawing.Size(103, 22);
            this.vsiNombre3.TabIndex = 5;
            this.vsiNombre3.Text = "visualInt2";
            // 
            // lblNombre2
            // 
            this.lblNombre2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre2.Location = new System.Drawing.Point(32, 84);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(106, 23);
            this.lblNombre2.TabIndex = 2;
            this.lblNombre2.Text = "Nombre 2 :";
            this.lblNombre2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnComparer3Nombres
            // 
            this.btnComparer3Nombres.Location = new System.Drawing.Point(48, 169);
            this.btnComparer3Nombres.Name = "btnComparer3Nombres";
            this.btnComparer3Nombres.Size = new System.Drawing.Size(199, 31);
            this.btnComparer3Nombres.TabIndex = 10;
            this.btnComparer3Nombres.Text = "&Évaluer";
            this.btnComparer3Nombres.UseVisualStyleBackColor = true;
            this.btnComparer3Nombres.Click += new System.EventHandler(this.btnComparer3Nombres_Click);
            // 
            // lblNombre1
            // 
            this.lblNombre1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre1.Location = new System.Drawing.Point(32, 50);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(106, 22);
            this.lblNombre1.TabIndex = 0;
            this.lblNombre1.Text = "Nombre 1 :";
            this.lblNombre1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vsiNombre1
            // 
            this.vsiNombre1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vsiNombre1.FocusColor = System.Drawing.Color.Gray;
            this.vsiNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiNombre1.ForeColor = System.Drawing.Color.Black;
            this.vsiNombre1.GraphAppearance.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.vsiNombre1.Location = new System.Drawing.Point(144, 50);
            this.vsiNombre1.Maximum = 125;
            this.vsiNombre1.Minimum = 0;
            this.vsiNombre1.Name = "vsiNombre1";
            this.vsiNombre1.Size = new System.Drawing.Size(103, 22);
            this.vsiNombre1.TabIndex = 1;
            this.vsiNombre1.Text = "visualInt2";
            // 
            // vsbNombresEgaux
            // 
            this.vsbNombresEgaux.FocusColor = System.Drawing.Color.Gray;
            this.vsbNombresEgaux.Location = new System.Drawing.Point(327, 50);
            this.vsbNombresEgaux.Name = "vsbNombresEgaux";
            this.vsbNombresEgaux.ReadOnly = true;
            this.vsbNombresEgaux.Size = new System.Drawing.Size(108, 152);
            this.vsbNombresEgaux.TabIndex = 7;
            this.vsbNombresEgaux.Toggle = false;
            this.vsbNombresEgaux.ValueAppearance.False.Image = global::IfSimples.Properties.Resources.LightOff;
            this.vsbNombresEgaux.ValueAppearance.False.Style = VisualArrays.enuBkgStyle.Image;
            this.vsbNombresEgaux.ValueAppearance.True.Image = global::IfSimples.Properties.Resources.LightOn;
            this.vsbNombresEgaux.ValueAppearance.True.Style = VisualArrays.enuBkgStyle.Image;
            // 
            // tabEx5
            // 
            this.tabEx5.Controls.Add(this.lblExercice5);
            this.tabEx5.Controls.Add(this.panExercice5);
            this.tabEx5.Location = new System.Drawing.Point(4, 27);
            this.tabEx5.Name = "tabEx5";
            this.tabEx5.Padding = new System.Windows.Forms.Padding(3);
            this.tabEx5.Size = new System.Drawing.Size(641, 326);
            this.tabEx5.TabIndex = 5;
            this.tabEx5.Text = "Exercice 5";
            // 
            // lblExercice5
            // 
            this.lblExercice5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblExercice5.Location = new System.Drawing.Point(14, 19);
            this.lblExercice5.Name = "lblExercice5";
            this.lblExercice5.Size = new System.Drawing.Size(477, 24);
            this.lblExercice5.TabIndex = 0;
            this.lblExercice5.Text = "Calculer la valeur d\'une main de 3 cartes";
            // 
            // panExercice5
            // 
            this.panExercice5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panExercice5.Controls.Add(this.lblDescription);
            this.panExercice5.Controls.Add(this.lblScore);
            this.panExercice5.Controls.Add(this.vsiScore);
            this.panExercice5.Controls.Add(this.btnEvaluerMainCartes);
            this.panExercice5.Controls.Add(this.panEx5Separateur);
            this.panExercice5.Controls.Add(this.btnChoisirCartes);
            this.panExercice5.Controls.Add(this.lblCarte3);
            this.panExercice5.Controls.Add(this.vsiCarte3);
            this.panExercice5.Controls.Add(this.vsiCarte1);
            this.panExercice5.Controls.Add(this.lblCarte2);
            this.panExercice5.Controls.Add(this.vsiCarte2);
            this.panExercice5.Controls.Add(this.lblCarte1);
            this.panExercice5.Location = new System.Drawing.Point(14, 49);
            this.panExercice5.Name = "panExercice5";
            this.panExercice5.Size = new System.Drawing.Size(611, 261);
            this.panExercice5.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(339, 177);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(234, 68);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "- 3 pareilles donne 100 points\r\n- 2 pareilles donne 50 points\r\n- 3 cartes différe" +
    "ntes donne \r\n   la somme des valeurs des cartes";
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(337, 112);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(106, 42);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "Score :";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vsiScore
            // 
            this.vsiScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vsiScore.FocusColor = System.Drawing.Color.Gray;
            this.vsiScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiScore.ForeColor = System.Drawing.Color.Black;
            this.vsiScore.GraphAppearance.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.vsiScore.Location = new System.Drawing.Point(470, 112);
            this.vsiScore.Maximum = 125;
            this.vsiScore.Minimum = 0;
            this.vsiScore.Name = "vsiScore";
            this.vsiScore.Size = new System.Drawing.Size(103, 42);
            this.vsiScore.TabIndex = 10;
            this.vsiScore.Text = "visualInt2";
            // 
            // btnEvaluerMainCartes
            // 
            this.btnEvaluerMainCartes.Location = new System.Drawing.Point(341, 27);
            this.btnEvaluerMainCartes.Name = "btnEvaluerMainCartes";
            this.btnEvaluerMainCartes.Size = new System.Drawing.Size(232, 58);
            this.btnEvaluerMainCartes.TabIndex = 0;
            this.btnEvaluerMainCartes.Text = "Évaluer la main";
            this.btnEvaluerMainCartes.UseVisualStyleBackColor = true;
            this.btnEvaluerMainCartes.Click += new System.EventHandler(this.btnÉvaluerMainCartes_Click);
            // 
            // panEx5Separateur
            // 
            this.panEx5Separateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panEx5Separateur.Location = new System.Drawing.Point(304, 3);
            this.panEx5Separateur.Name = "panEx5Separateur";
            this.panEx5Separateur.Size = new System.Drawing.Size(2, 254);
            this.panEx5Separateur.TabIndex = 1;
            // 
            // btnChoisirCartes
            // 
            this.btnChoisirCartes.Location = new System.Drawing.Point(28, 27);
            this.btnChoisirCartes.Name = "btnChoisirCartes";
            this.btnChoisirCartes.Size = new System.Drawing.Size(232, 58);
            this.btnChoisirCartes.TabIndex = 6;
            this.btnChoisirCartes.Text = "Choisir les cartes au hasard";
            this.btnChoisirCartes.UseVisualStyleBackColor = true;
            this.btnChoisirCartes.Click += new System.EventHandler(this.btnChoisirCartes_Click);
            // 
            // lblCarte3
            // 
            this.lblCarte3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarte3.Location = new System.Drawing.Point(193, 112);
            this.lblCarte3.Name = "lblCarte3";
            this.lblCarte3.Size = new System.Drawing.Size(70, 13);
            this.lblCarte3.TabIndex = 4;
            this.lblCarte3.Text = "Carte #3";
            this.lblCarte3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vsiCarte3
            // 
            this.vsiCarte3.BorderColor = System.Drawing.Color.White;
            this.vsiCarte3.FocusColor = System.Drawing.Color.Gray;
            this.vsiCarte3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiCarte3.ImageList = this.imlCartes;
            this.vsiCarte3.Location = new System.Drawing.Point(196, 128);
            this.vsiCarte3.Maximum = 12;
            this.vsiCarte3.Minimum = 0;
            this.vsiCarte3.Name = "vsiCarte3";
            this.vsiCarte3.Size = new System.Drawing.Size(67, 88);
            this.vsiCarte3.TabIndex = 5;
            this.vsiCarte3.Value = 12;
            this.vsiCarte3.View = VisualArrays.enuIntView.ImageList;
            // 
            // imlCartes
            // 
            this.imlCartes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlCartes.ImageStream")));
            this.imlCartes.TransparentColor = System.Drawing.Color.Transparent;
            this.imlCartes.Images.SetKeyName(0, "1.bmp");
            this.imlCartes.Images.SetKeyName(1, "2.bmp");
            this.imlCartes.Images.SetKeyName(2, "3.bmp");
            this.imlCartes.Images.SetKeyName(3, "4.bmp");
            this.imlCartes.Images.SetKeyName(4, "5.bmp");
            this.imlCartes.Images.SetKeyName(5, "6.bmp");
            this.imlCartes.Images.SetKeyName(6, "7.bmp");
            this.imlCartes.Images.SetKeyName(7, "8.bmp");
            this.imlCartes.Images.SetKeyName(8, "9.bmp");
            this.imlCartes.Images.SetKeyName(9, "10.bmp");
            this.imlCartes.Images.SetKeyName(10, "11.bmp");
            this.imlCartes.Images.SetKeyName(11, "12.bmp");
            this.imlCartes.Images.SetKeyName(12, "13.bmp");
            // 
            // vsiCarte1
            // 
            this.vsiCarte1.BorderColor = System.Drawing.Color.White;
            this.vsiCarte1.FocusColor = System.Drawing.Color.Gray;
            this.vsiCarte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiCarte1.ImageList = this.imlCartes;
            this.vsiCarte1.Location = new System.Drawing.Point(28, 128);
            this.vsiCarte1.Maximum = 12;
            this.vsiCarte1.Minimum = 0;
            this.vsiCarte1.Name = "vsiCarte1";
            this.vsiCarte1.Size = new System.Drawing.Size(67, 88);
            this.vsiCarte1.TabIndex = 1;
            this.vsiCarte1.View = VisualArrays.enuIntView.ImageList;
            // 
            // lblCarte2
            // 
            this.lblCarte2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarte2.Location = new System.Drawing.Point(109, 112);
            this.lblCarte2.Name = "lblCarte2";
            this.lblCarte2.Size = new System.Drawing.Size(70, 13);
            this.lblCarte2.TabIndex = 2;
            this.lblCarte2.Text = "Carte #2";
            this.lblCarte2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vsiCarte2
            // 
            this.vsiCarte2.BorderColor = System.Drawing.Color.White;
            this.vsiCarte2.FocusColor = System.Drawing.Color.Gray;
            this.vsiCarte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsiCarte2.ImageList = this.imlCartes;
            this.vsiCarte2.Location = new System.Drawing.Point(112, 128);
            this.vsiCarte2.Maximum = 12;
            this.vsiCarte2.Minimum = 0;
            this.vsiCarte2.Name = "vsiCarte2";
            this.vsiCarte2.Size = new System.Drawing.Size(67, 88);
            this.vsiCarte2.TabIndex = 3;
            this.vsiCarte2.Value = 12;
            this.vsiCarte2.View = VisualArrays.enuIntView.ImageList;
            // 
            // lblCarte1
            // 
            this.lblCarte1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarte1.Location = new System.Drawing.Point(28, 112);
            this.lblCarte1.Name = "lblCarte1";
            this.lblCarte1.Size = new System.Drawing.Size(67, 13);
            this.lblCarte1.TabIndex = 0;
            this.lblCarte1.Text = "Carte #1";
            this.lblCarte1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 400);
            this.Controls.Add(this.tabIfSimples);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "If simples - Opérateurs logiques";
            this.tabIfSimples.ResumeLayout(false);
            this.tabEx1.ResumeLayout(false);
            this.panExercice1.ResumeLayout(false);
            this.tabEx2.ResumeLayout(false);
            this.panExercice2.ResumeLayout(false);
            this.tabEx3.ResumeLayout(false);
            this.panExercice3.ResumeLayout(false);
            this.tabEx4.ResumeLayout(false);
            this.panExercice4.ResumeLayout(false);
            this.tabEx5.ResumeLayout(false);
            this.panExercice5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabIfSimples;
        private System.Windows.Forms.TabPage tabEx2;
        private System.Windows.Forms.TabPage tabEx3;
        private System.Windows.Forms.TabPage tabEx4;
        private System.Windows.Forms.TabPage tabEx5;
        private System.Windows.Forms.Label lblCarte1;
        private System.Windows.Forms.ImageList imlCartes;
        private System.Windows.Forms.Label lblCarte2;
        private VisualArrays.VisualCells.VisualInt vsiCarte2;
        private VisualArrays.VisualCells.VisualInt vsiCarte1;
        private System.Windows.Forms.Panel panExercice2;
        private System.Windows.Forms.Label lblOpLogiqueET;
        private VisualArrays.VisualCells.VisualBool vsbOpEtLum1;
        private System.Windows.Forms.Label lblExercice4;
        private VisualArrays.VisualCells.VisualInt vsiNombre2;
        private VisualArrays.VisualCells.VisualInt vsiNombre1;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Button btnChoisirCartes;
        private VisualArrays.VisualCells.VisualBool vsbOpEtRésultat;
        private VisualArrays.VisualCells.VisualBool vsbOpEtLum3;
        private VisualArrays.VisualCells.VisualBool vsbOpEtLum2;
        private System.Windows.Forms.Label lblCliquerLumierePourInverserEt;
        private System.Windows.Forms.Label lblRésultatOpLogiquetEt;
        private System.Windows.Forms.Button btnEvaluerOpLogiqueEt;
        private System.Windows.Forms.Panel panEx2Separateur;
        private System.Windows.Forms.Panel panExercice3;
        private System.Windows.Forms.Label lblCliquerLumierePourInverserOU;
        private System.Windows.Forms.Label lblRésultatOpLogiqueOu;
        private System.Windows.Forms.Button btnEvaluerOpLogiqueOu;
        private System.Windows.Forms.Panel panEx3Separateur;
        private VisualArrays.VisualCells.VisualBool vsbOpOuRésultat;
        private VisualArrays.VisualCells.VisualBool vsbOpOuLum3;
        private VisualArrays.VisualCells.VisualBool vsbOpOuLum2;
        private VisualArrays.VisualCells.VisualBool vsbOpOuLum1;
        private System.Windows.Forms.Label lblOpLogiqueOU;
        private System.Windows.Forms.Panel panExercice4;
        private System.Windows.Forms.Label lblNombreEgaux;
        private System.Windows.Forms.Label lblNombre3;
        private VisualArrays.VisualCells.VisualInt vsiNombre3;
        private System.Windows.Forms.Button btnComparer3Nombres;
        private VisualArrays.VisualCells.VisualBool vsbNombresEgaux;
        private System.Windows.Forms.Label lblNombresPairs;
        private VisualArrays.VisualCells.VisualBool vsbNombresPairs;
        private System.Windows.Forms.Label lblExercice5;
        private System.Windows.Forms.Panel panExercice5;
        private System.Windows.Forms.Panel panEx5Separateur;
        private System.Windows.Forms.Label lblCarte3;
        private VisualArrays.VisualCells.VisualInt vsiCarte3;
        private System.Windows.Forms.Label lblScore;
        private VisualArrays.VisualCells.VisualInt vsiScore;
        private System.Windows.Forms.Button btnEvaluerMainCartes;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TabPage tabEx1;
        private System.Windows.Forms.Label lblExercice1;
        private System.Windows.Forms.Panel panExercice1;
        private System.Windows.Forms.Button btnInverserÉtatAvecAssignation;
        private System.Windows.Forms.Button btnInverserÉtatAvecif;
        private VisualArrays.VisualCells.VisualBool vsbLumièreOpLogiqueNon;
    }
}

