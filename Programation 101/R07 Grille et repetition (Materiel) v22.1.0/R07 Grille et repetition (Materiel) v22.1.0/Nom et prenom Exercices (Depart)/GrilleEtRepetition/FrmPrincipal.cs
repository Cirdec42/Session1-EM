using System;
using System.Windows.Forms;
using VisualArrays;

namespace GrilleEtRepetition
{
    public partial class FrmPrincipal : Form
    {
        /// =============================================================================================
        /// <summary>
        /// Concepts    :  Index, contenu et répétition
        ///                Utilisation des grilles VisualBoolArray, VisualCharArray et VisualIntArray
        /// </summary>
        /// =============================================================================================
        public const string APP_INFO = "(Matériel)";
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
        }

        #region Exercice 1 : Manipuler une grille de booléens.

        // --------------------------------------------------------------------------------------------
        private void btnAllumerPreLum_Click(object sender, EventArgs e)
        {
            // TODO 01A : Allumer la première lumière.

        }
        // --------------------------------------------------------------------------------------------
        private void btnAllumerDernLum_Click(object sender, EventArgs e)
        {
            // TODO 01B : Allumer la dernière lumière

        }
        // --------------------------------------------------------------------------------------------
        private void btnAllumerLumièreIndex_Click(object sender, EventArgs e)
        {
            // TODO 01C : Allumer la lumière à l'index saisi.

        }
        // --------------------------------------------------------------------------------------------
        private void BtnRéinitialiserGrilleBool_Click(object sender, EventArgs e)
        {
            // TODO 01D : Réinitialiser la grille en utilisant la méthode Clear().

        }
        // --------------------------------------------------------------------------------------------
        private void btnInverserLumière_Click(object sender, EventArgs e)
        {
            // TODO 01E : Inverser l'état de la lumière à l'index saisi.

        }
        // --------------------------------------------------------------------------------------------
        private void BtnAllumerToutesLesLumières_Click(object sender, EventArgs e)
        {
            // TODO 01F : Allumer toutes les lumières en utilisant l'instruction de répétition for(;;)

        }
        #endregion

        #region Exercice 2 : Manipuler une grille de caractères

        // --------------------------------------------------------------------------------------------
        private void btnAssignerA_Click(object sender, EventArgs e)
        {
            // TODO 02A : Assigner la lettre A à la  première cellule.

        }
        // --------------------------------------------------------------------------------------------
        private void btnAssignerH_Click(object sender, EventArgs e)
        {
            // TODO 02B : Assigner la lettre H à la  dernière cellule.

        }
        // --------------------------------------------------------------------------------------------
        private void btnCopierCellule_Click(object sender, EventArgs e)
        {
            // TODO 02C : Copier la première cellule dans la deuxième.

        }
        // --------------------------------------------------------------------------------------------
        private void btnAugmenterCarac_Click(object sender, EventArgs e)
        {
            // TODO 02D : Modifier le caractère de la première cellule pour y afficher le suivant.

        }
        // --------------------------------------------------------------------------------------------
        private void btnPermuterCellules_Click(object sender, EventArgs e)
        {
            // TODO 02E : Permuter les cellules aux index 0 et 1.

        }
        // --------------------------------------------------------------------------------------------
        private void btnAssignerLettreIndex_Click(object sender, EventArgs e)
        {
            // TODO 02F : Assigner la lettre saisie à l'index saisi.

        }
        // --------------------------------------------------------------------------------------------
        private void BtnAssignerGDansToutesLesCellules_Click(object sender, EventArgs e)
        {
            // TODO 02G : Assigner la lettre 'G' dans toutes les cellules de la grille en utilisant l'instruction de répétition for(;;)

        }
        // --------------------------------------------------------------------------------------------
        private void BtnAssignerLettreDansToutesLesCellules_Click(object sender, EventArgs e)
        {
            // TODO 02H : Assigner la lettre choisie dans toutes les cellules de la grille en utilisant l'instruction de répétition for(;;)

        }

        #endregion

        #region Exercice 3 : Manipuler une grille de nombres entiers
        // --------------------------------------------------------------------------------------------
        private void BtnAssigner5DansPremièreCellule_Click(object sender, EventArgs e)
        {
            // TODO 03A : Assigner le nombre 5 dans la première cellule de la grille

        }
        // --------------------------------------------------------------------------------------------
        private void Button1_Click(object sender, EventArgs e)
        {
            // TODO 03B : Copier le contenu de la première cellule dans la dernière

        }
        // --------------------------------------------------------------------------------------------
        private void BtnAssigner12DansToutesLesCellules_Click(object sender, EventArgs e)
        {
            // TODO 03C : Assigner 12 dans toutes les cellules en utilisant l'instruction for(;;)

        }
        // --------------------------------------------------------------------------------------------
        private void BtnAugmenterDe1ToutesLesCellules_Click(object sender, EventArgs e)
        {
            // TODO 03D : Augmenter de 1 la valeur de toutes les cellules en utilisant l'instruction de répétition for(;;)

        }
        // --------------------------------------------------------------------------------------------
        private void BtnCopierTableau1D_Click(object sender, EventArgs e)
        {
            // TODO 03E : Copier dans la grille toutes les valeurs du tableau 1D ci-dessous en utilisant l'instruction de répétition for(;;)
            int[] tabNombres = { 65, 78, 81, 90, 56, 61, 77, 82, 87, 99 };

        }
        // --------------------------------------------------------------------------------------------
        private void BtnCalculerLaSommeDesValeurs_Click(object sender, EventArgs e)
        {
            // TODO 03F : Calculer la somme de toutes les valeurs de la grille et placer le résultat
            //              dans la zone numérique vsiTotal. Vous devez utiliser l'instruction de répétition for(;;)

        }
        // --------------------------------------------------------------------------------------------
        private void BtnCalculer_Click(object sender, EventArgs e)
        {
            // TODO 03G : Compter le nombre de valeurs dans la grille qui sont supérieures à 75. Vous devez utiliser l'instruction de répétition for(;;)

        }
        #endregion
    }
}