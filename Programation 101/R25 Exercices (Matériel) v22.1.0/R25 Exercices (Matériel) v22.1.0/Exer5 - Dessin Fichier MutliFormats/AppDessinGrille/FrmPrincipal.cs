using System;
using System.IO;
using System.Windows.Forms;
using VisualArrays;

namespace AppDessinGrille
{
    /// <summary>
    /// Un dessin se compose de plusieurs petits motifs placés dans les cellules d'une grille VisualIntArray en mode ImageList
    /// Il y a 9 motifs placés dans une ImageList, les valeurs sont 0 à 8 inclusivement, la valeur spéciale -1 indique une cellule vide.
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        private const string APP_INFO= "(Matériel)";

        #region NE PAS MODIFIER
        //==================================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
            PréparerPalette();
        }
        //==================================================================================================
        private void PréparerPalette()
        {
            for (int index = 0; index < imlSymboles.Images.Count; index++)
            {
                viaGrillePalette[index] = index;
            }
            viaGrillePalette.SelectedIndex = 0;
        }
        //==================================================================================================
        private void ViaNombres_CellMouseDown(object sender, CellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                viaGrilleDessin[e.Address] = viaGrilleDessin.SpecialValue;
            
            if (e.Button == MouseButtons.Left && viaGrillePalette.SelectedIndex != -1)
                viaGrilleDessin[e.Address] = viaGrillePalette.SelectedValue;
        }
        //==================================================================================================
        private void MnuFichierNouveauDessin_Click(object sender, EventArgs e)
        {
            viaGrilleDessin.Clear();
        }
        //==================================================================================================
        private void MnuFormat_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem menu in mnuFormat.DropDownItems)
                menu.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;
        }
        //==================================================================================================
        private void MnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Déterminer le format puis charger et/ou enregistrer
        //==================================================================================================
        private void ChargerDessinSelonFormat()
        {
            if (mnuFormat1.Checked)
                ChargerDessinFormat1("Fichiers/DessinF1.txt");
            if (mnuFormat2.Checked)
                ChargerDessinFormat2("Fichiers/DessinF2.txt");
            if (mnuFormat3.Checked)
                ChargerDessinFormat3("Fichiers/DessinF3.txt");
            if (mnuFormat4.Checked)
                ChargerDessinFormat4("Fichiers/DessinF4.txt");
            if (mnuFormat5.Checked)
                ChargerDessinFormat5("Fichiers/DessinF5.txt");
            if (mnuFormat6.Checked)
                ChargerDessinFormat6("Fichiers/DessinF6.txt");
            if (mnuFormat7.Checked)
                ChargerDessinFormat7("Fichiers/DessinF7.txt");
            if (mnuFormat8.Checked)
                ChargerDessinFormat8("Fichiers/DessinF8.txt");
        }
        //==================================================================================================
        private void mnuFichierCharger_Click(object sender, EventArgs e)
        {
            ChargerDessinSelonFormat();
        }

        //==================================================================================================
        private void mnuFichierEnregistrer_Click(object sender, EventArgs e)
        {
            if (mnuFormat1.Checked)
                EnregistrerDessinFormat1("Fichiers/DessinF1.txt");
            if (mnuFormat2.Checked)
                EnregistrerDessinFormat2("Fichiers/DessinF2.txt");
            if (mnuFormat3.Checked)
                EnregistrerDessinFormat3("Fichiers/DessinF3.txt");
            if (mnuFormat4.Checked)
                EnregistrerDessinFormat4("Fichiers/DessinF4.txt");
            if (mnuFormat5.Checked)
                EnregistrerDessinFormat5("Fichiers/DessinF5.txt");
            if (mnuFormat6.Checked)
                EnregistrerDessinFormat6("Fichiers/DessinF6.txt");
            if (mnuFormat7.Checked)
                EnregistrerDessinFormat7("Fichiers/DessinF7.txt");
            if (mnuFormat8.Checked)
                EnregistrerDessinFormat8("Fichiers/DessinF8.txt");
        }
        #endregion

        #endregion

        #region Charger dessin format #1
        //==================================================================================================
        /// <summary>
        /// TODO 01 : Charger un dessin avec le format #1
        /// Chaque ligne contient une coordonnée suivie du numéro d'un motif séparés par des virgules.
        /// Par exemple 5,0,3 signifie de placer à la rangée 5 et la colonne 0 le motif 3.
        /// </summary>
        /// <param name="pNomDuFichier">Nom du fichier à charger</param>
        private void ChargerDessinFormat1(string pNomDuFichier)
        {
        }
        #endregion

        #region Charger dessin format #2
        //==================================================================================================
        /// <summary>
        /// TODO 02 : Charger un dessin avec le format #2
        /// Chaque ligne contient 3 caractères, le deux premiers sont respectivement la rangée et la colonne et le troisième 
        /// le numéro du motif. Il faut soustraire la lettre 'A' aux deux premières lettres afin d'obtenir le numéro de la rangée 
        /// et de la colonne. Par exemple : AA3 signifie 'A' - 'A' = 0 donc la rangée 0 et la colonne 0 et dessiner la figure 3.
        /// </summary>
        /// <param name="pNomDuFichier">Nom du fichier à charger</param>
        private void ChargerDessinFormat2(string pNomDuFichier)
        {
        }
        #endregion

        #region Charger dessin format #3
        //==================================================================================================
        /// <summary>
        /// TODO 03 : Charger un dessin avec le format #3
        /// Le fichier contient un caractère pour chacune des cellules dans la grille.
        /// Chaque ligne contient séquentiellement toutes les figures pour une rangée
        /// Le fichier contient autant de lignes qu'il y a de rangées dans la grille.
        /// Le numéro de chaque figure est décalé de 1, ainsi tous les 0 sont des -1.
        /// Par exemple : 400000000000005
        /// </summary>
        /// <param name="pNomDuFichier">Nom du fichier à charger</param>
        private void ChargerDessinFormat3(string pNomDuFichier)
        {
        }
        #endregion

        #region Charger dessin format #4
        //==================================================================================================
        /// <summary>
        /// TODO 04 : Charger un dessin avec le format #4
        /// Chaque ligne contient une adresse suivi du numéro d'une figure sans séparateur.
        /// Les deux premiers caractères sont la rangée, les deux suivants la colonne et le dernier le numéro de la figure
        /// Par exemple : 00125 signifie rangée 00 donc 0, colonne 12 et figure #5
        /// </summary>
        /// <param name="pNomDuFichier">Nom du fichier à charger</param>
        private void ChargerDessinFormat4(string pNomDuFichier)
        {
        }
        #endregion

        #region Charger dessin format #5
        //==================================================================================================
        /// <summary>
        /// TODO 05 : Charger un dessin avec le format #5
        /// Idem au format #2 sauf que tous les caractères sont sur la même ligne.
        /// </summary>
        /// <param name="pNomDuFichier">Nom du fichier à charger</param>
        private void ChargerDessinFormat5(string pNomDuFichier)
        {
        }
        #endregion

        #region Charger dessin format #6
        //==================================================================================================
        /// <summary>
        /// TODO 06 : Charger un dessin avec le format #6
        /// Similaire au format #1, mais on utilise deux séparateurs. Toutes les informations sont sur la même ligne
        /// Un premier séparateur le caractère | permet de séparer toutes les figures à dessiner. 
        /// Un deuxième séparateur le caractère , permet de séparer les informations de la rangée de la colonne et de la figure
        /// comme c'est le cas dans le format #1.        
        /// </summary>
        /// <param name="pNomDuFichier">Nom du fichier à charger</param>
        private void ChargerDessinFormat6(string pNomDuFichier)
        {
        }
        #endregion

        #region Charger dessin format #7
        //==================================================================================================
        /// <summary>
        /// TODO 07 : Charger un dessin avec le format #7
        /// Idem au format #3 sauf que tous les caractères sont sur la même ligne
        /// </summary>
        /// <param name="pNomDuFichier">Nom du fichier à charger</param>
        private void ChargerDessinFormat7(string pNomDuFichier)
        {
        }
        #endregion

        #region Charger dessin format #8
        //==================================================================================================
        /// <summary>
        /// TODO 08 : Charger un dessin avec le format #8
        /// Inspiré du format #2. Le fichier contient autant de ligne qu'il y a de motif de figure soit 9.
        /// Chaque ligne contient toutes les adresses ou il est nécessaire de dessiner la figure.
        /// Par exemple si AABB se trouvent sur la première ligne cela signifie de dessiner la figure 0
        /// aux adresses AA et BB, qui deviennent respectivement 0,0 et 1,1.
        /// </summary>
        /// <param name="pNomDuFichier">Nom du fichier à charger</param>
        private void ChargerDessinFormat8(string pNomDuFichier)
        {
        }
        #endregion

        #region Enregistrer dessin format #1
        // TODO 09 : Enregistrer un dessin selon le format #1
        private void EnregistrerDessinFormat1(string pNomDuFichier)
        {
        }
        #endregion

        #region Enregistrer dessin format #2
        // TODO 10 : Enregistrer un dessin selon le format #2
        private void EnregistrerDessinFormat2(string pNomDuFichier)
        {
        }
        #endregion

        #region Enregistrer dessin format #3
        // TODO 11 : Enregistrer un dessin selon le format #3
        private void EnregistrerDessinFormat3(string pNomDuFichier)
        {
        }
        #endregion

        #region Enregistrer dessin format #4
        // TODO 12 : Enregistrer un dessin selon le format #4
        private void EnregistrerDessinFormat4(string pNomDuFichier)
        {
        }
        #endregion

        #region Enregistrer dessin format #5
        // TODO 13 : Enregistrer un dessin selon le format #5
        private void EnregistrerDessinFormat5(string pNomDuFichier)
        {
        }
        #endregion

        #region Enregistrer dessin format #6
        // TODO 14 : Enregistrer un dessin selon le format #6
        private void EnregistrerDessinFormat6(string pNomDuFichier)
        {
        }
        #endregion

        #region Enregistrer dessin format #7
        // TODO 15 : Enregistrer un dessin selon le format #7
        private void EnregistrerDessinFormat7(string pNomDuFichier)
        {
        }
        #endregion

        #region Enregistrer dessin format #8
        // TODO 16 : Enregistrer un dessin selon le format #8
        private void EnregistrerDessinFormat8(string pNomDuFichier)
        {
        }
        #endregion
    }
}
