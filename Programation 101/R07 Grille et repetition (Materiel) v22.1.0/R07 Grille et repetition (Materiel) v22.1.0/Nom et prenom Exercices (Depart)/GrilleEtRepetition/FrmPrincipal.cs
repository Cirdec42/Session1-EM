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
            vbaLumières[0] = true; 
        }
        // --------------------------------------------------------------------------------------------
        private void btnAllumerDernLum_Click(object sender, EventArgs e)
        {
            // TODO 01B : Allumer la dernière lumière
            vbaLumières[5] = true;
        }
        // --------------------------------------------------------------------------------------------
        private void btnAllumerLumièreIndex_Click(object sender, EventArgs e)
        {
            // TODO 01C : Allumer la lumière à l'index saisi.
            vbaLumières[vsiExercice1Index.Value] = true;
        }
        // --------------------------------------------------------------------------------------------
        private void BtnRéinitialiserGrilleBool_Click(object sender, EventArgs e)
        {
            // TODO 01D : Réinitialiser la grille en utilisant la méthode Clear().
            vbaLumières.Clear();
        }
        // --------------------------------------------------------------------------------------------
        private void btnInverserLumière_Click(object sender, EventArgs e)
        {
            // TODO 01E : Inverser l'état de la lumière à l'index saisi.
            vbaLumières[vsiExercice1Index.Value] = false;
        }
        // --------------------------------------------------------------------------------------------
        private void BtnAllumerToutesLesLumières_Click(object sender, EventArgs e)
        {
            // TODO 01F : Allumer toutes les lumières en utilisant l'instruction de répétition for(;;)
            for (int i = 0; i < vbaLumières.Length; i++)
            {
                vbaLumières[i] = true;
            }
        }
        #endregion

        #region Exercice 2 : Manipuler une grille de caractères

        // --------------------------------------------------------------------------------------------
        private void btnAssignerA_Click(object sender, EventArgs e)
        {
            // TODO 02A : Assigner la lettre A à la  première cellule.
            vcaCaractères[0] = 'A';
        }
        // --------------------------------------------------------------------------------------------
        private void btnAssignerH_Click(object sender, EventArgs e)
        {
            // TODO 02B : Assigner la lettre H à la  dernière cellule.
            vcaCaractères[1] = 'H';
        }
        // --------------------------------------------------------------------------------------------
        private void btnCopierCellule_Click(object sender, EventArgs e)
        {
            // TODO 02C : Copier la première cellule dans la deuxième.
            vcaCaractères[1] = vcaCaractères[0];
        }
        // --------------------------------------------------------------------------------------------
        private void btnAugmenterCarac_Click(object sender, EventArgs e)
        {
            // TODO 02D : Modifier le caractère de la première cellule pour y afficher le suivant.
            vcaCaractères[0]++;
        }
        // --------------------------------------------------------------------------------------------
        private void btnPermuterCellules_Click(object sender, EventArgs e)
        {
            // TODO 02E : Permuter les cellules aux index 0 et 1.
            char tempo = vcaCaractères[0];
            vcaCaractères[0] = vcaCaractères[1];
            vcaCaractères[1] = tempo;
        }
        // --------------------------------------------------------------------------------------------
        private void btnAssignerLettreIndex_Click(object sender, EventArgs e)
        {
            // TODO 02F : Assigner la lettre saisie à l'index saisi.
            vcaCaractères[vsiIndexEx2.Value] = vscLettre.Value;
        }
        // --------------------------------------------------------------------------------------------
        private void BtnAssignerGDansToutesLesCellules_Click(object sender, EventArgs e)
        {
            // TODO 02G : Assigner la lettre 'G' dans toutes les cellules de la grille en utilisant l'instruction de répétition for(;;)
            for (int i = 0; i < vcaCaractères.Length; i++)
            {
                vcaCaractères[i] = 'G';
            }
        }
        // --------------------------------------------------------------------------------------------
        private void BtnAssignerLettreDansToutesLesCellules_Click(object sender, EventArgs e)
        {
            // TODO 02H : Assigner la lettre choisie dans toutes les cellules de la grille en utilisant l'instruction de répétition for(;;)
            for (int i = 0; i < vcaCaractères.Length; i++)
            {
                vcaCaractères[i] = vscLettre.Value;
            }
        }

        #endregion

        #region Exercice 3 : Manipuler une grille de nombres entiers
        // --------------------------------------------------------------------------------------------
        private void BtnAssigner5DansPremièreCellule_Click(object sender, EventArgs e)
        {
            // TODO 03A : Assigner le nombre 5 dans la première cellule de la grille
            viaNombres[0] = 5;
            

        }
        // --------------------------------------------------------------------------------------------
        private void Button1_Click(object sender, EventArgs e)
        {
            // TODO 03B : Copier le contenu de la première cellule dans la dernière
            viaNombres[9] = viaNombres[0];
        }
        // --------------------------------------------------------------------------------------------
        private void BtnAssigner12DansToutesLesCellules_Click(object sender, EventArgs e)
        {
            // TODO 03C : Assigner 12 dans toutes les cellules en utilisant l'instruction for(;;)
            for (int i = 0; i < viaNombres.Length; i++)
            {
                viaNombres[i] = 12;
            }
        }
        // --------------------------------------------------------------------------------------------
        private void BtnAugmenterDe1ToutesLesCellules_Click(object sender, EventArgs e)
        {
            // TODO 03D : Augmenter de 1 la valeur de toutes les cellules en utilisant l'instruction de répétition for(;;)
            for (int i = 0; i < viaNombres.Length; i++)
            {
                viaNombres[i]++;
            }
        }
        // --------------------------------------------------------------------------------------------
        private void BtnCopierTableau1D_Click(object sender, EventArgs e)
        {
            // TODO 03E : Copier dans la grille toutes les valeurs du tableau 1D ci-dessous en utilisant l'instruction de répétition for(;;)
            int[] tabNombres = { 65, 78, 81, 90, 56, 61, 77, 82, 87, 99 };
            for (int i = 0; i < tabNombres.Length; i++)
            {
                viaNombres[i] = tabNombres[i];
            }

        }
        // --------------------------------------------------------------------------------------------
        private void BtnCalculerLaSommeDesValeurs_Click(object sender, EventArgs e)
        {
            // TODO 03F : Calculer la somme de toutes les valeurs de la grille et placer le résultat
            //              dans la zone numérique vsiTotal. Vous devez utiliser l'instruction de répétition for(;;)
            int total = 0;
            for (int i = 0; i < viaNombres.Length; i++)
            {
                total += viaNombres[i]; 
            }
        }
        // --------------------------------------------------------------------------------------------
        private void BtnCalculer_Click(object sender, EventArgs e)
        {
            // TODO 03G : Compter le nombre de valeurs dans la grille qui sont supérieures à 75. Vous devez utiliser l'instruction de répétition for(;;)
            int compteur = 0;
            for (int i = 0; i < viaNombres.Length; i++)
            {
                if (viaNombres[i]>75)
                {
                    compteur++;
                }
            }
            vsiTotal.Value = compteur;

        }
        #endregion

        private void vbaLumières_Click(object sender, EventArgs e)
        {

        }
    }
}