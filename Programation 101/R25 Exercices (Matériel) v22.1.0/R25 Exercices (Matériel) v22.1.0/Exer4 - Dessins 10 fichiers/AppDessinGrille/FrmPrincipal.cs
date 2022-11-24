using System;
using System.IO;
using System.Windows.Forms;
using VisualArrays;

namespace AppDessinGrille
{ 
    public partial class FrmPrincipal : Form
    {
        private const string APP_INFO= "(Matériel)";

        #region NE PAS MODIFIER
        //==================================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
            cboDessinCourant.SelectedIndex = 0;
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
        private void viaNombres_CellMouseDown(object sender, CellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                viaGrilleDessin[e.Address] = viaGrilleDessin.SpecialValue;
            
            if (e.Button == System.Windows.Forms.MouseButtons.Left && viaGrillePalette.SelectedIndex != -1)
                viaGrilleDessin[e.Address] = viaGrillePalette.SelectedValue;
        }
        //==================================================================================================
        private void mnuFichierNouveauDessin_Click(object sender, EventArgs e)
        {
            viaGrilleDessin.Clear();
        }
        //==================================================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        //==================================================================================================
        //Charger un fichier selon la valeur choisie dans le comboBox cboDessinCourant
        private void mnuFichierCharger_Click(object sender, EventArgs e)
        {
            ChargerUnDessin("Fichiers/Dessin" + cboDessinCourant.SelectedIndex + ".txt");
        }

        //==================================================================================================
        //Enregister un fichier selon la valeur choisie dans le comboBox cboDessinCourant
        private void mnuFichierEnregistrer_Click(object sender, EventArgs e)
        {
            EnregistrerUnDessin("Fichiers/Dessin" + cboDessinCourant.SelectedIndex + ".txt");
        }

        //==================================================================================================
        //Charger un fichier selon la valeur choisie dans le comboBox cboDessinCourant
        private void cboDessinCourant_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerUnDessin("Fichiers/Dessin" + cboDessinCourant.SelectedIndex + ".txt");
        }
        #endregion

        #region ChargerUnDessin
        //==================================================================================================
        /// <summary>
        /// Charge un dessin dans la grille viaGrilleDessin
        /// </summary>
        /// <param name="pNomDuFichier">nom du fichier contenant le dessin à charger</param>
        private void ChargerUnDessin(string pNomDuFichier)
        {
            // TODO 01 : Compléter le code pour lire le fichier pNomDuFichier et afficher le dessin
            //           dans la grille viaGrilleDessin. Chaque ligne du fichier contient: rangée,colonne,motif
            //          Vous devez utiliser les méthodes Split et Parse.

        }
        #endregion

        #region EnregistrerUnDessin
        //==================================================================================================
        /// <summary>
        /// Permet d'enregistrer le dessin affiché dans viaGrilleDessin dans un fichier texte.
        /// Une ligne par motif : index rangée , index colonne , valeur du motif
        /// </summary>
        /// <param name="pNomDuFichier">nom du fichier d'enregistrement</param>
        private void EnregistrerUnDessin(string pNomDuFichier)
        {
            // TODO 02 : Parcourir toutes les cellules de la grille afin d'écrire dans le fichier pNomDuFichier
            //           tous les motifs (autre que -1) sur différentes lignes.
            //           Le format du fichier est : rangée,colonne,motif

        }
        #endregion

    }
}
