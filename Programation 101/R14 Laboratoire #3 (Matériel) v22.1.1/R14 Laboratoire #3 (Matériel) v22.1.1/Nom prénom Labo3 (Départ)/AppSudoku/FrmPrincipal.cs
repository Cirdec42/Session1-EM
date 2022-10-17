using System;
using System.Drawing;
using System.Windows.Forms;
using VisualArrays;

namespace AppSudoku
{
    public partial class FrmPrincipal : Form
    {
        /// <summary>
        /// NOTIONS :
        ///  - Copier des éléments d'un tableau 2D dans une grille
        ///  - Désactiver des cellules de la grille
        ///  - Utiliser une valeur spéciale dont l'apparence est différente des autres valeurs
        ///  - Parcourir les cellules d'une grille en deux dimensions
        ///     - Parcourir des rangées, des colonnes ou des zones de 3 X 3
        ///  - Utiliser un tableau de booléens pour marquer les nombres utilisés.
        /// </summary>

        public const string APP_INFO = "(Matériel)";

        #region Sudoku Moyen (SEUL LE MOYEN EST UTILISÉ)
        int[,] m_tabSudokuMoyen =
        {
            {-5,2,4,3,1,7,-8,6,-9},
            {3,1,7,-6,-8,-9,4,5,2},
            {-8,-9,6,4,-2,5,1,-3,7},
            {2,8,1,-9,3,-6,5,-7,4},
            {-4,6,-5,8,-7,2,-3,9,-1},
            {9,-7,3,-5,4,-1,6,2,8},
            {7,-5,8,1,-9,3,2,-4,-6},
            {6,4,9,-2,-5,-8,7,1,3},
            {-1,3,-2,7,6,4,9,8,-5}
        };
        #region Sudoku Facile
        int[,] m_tabSudokuFacile = {
            {5,1,-2,-4,8,6,9,-7,-3},
            {6,-7,-9,2,3,-1,-5,-4,8},
            {-8,4,3,-5,9,-7,2,6,-1},
            {2,3,5,7,1,8,4,9,-6},
            {7,-9,1,-3,-6,-4,8,-2,5},
            {-4,6,8,9,5,2,3,1,7},
            {-1,5,7,-8,2,-9,6,3,-4},
            {3,-2,-6,-1,4,5,-7,8,9},
            {-9,-8,4,6,7,-3,-1,5,2},
        };
        #endregion
        #region Sudoku Difficile
        int[,] m_tabSudokuDifficile =
        {
            {5,9,6,-2,7,-4,-8,1,3},
            {-7,2,8,1,3,9,6,-4,-5},
            {4,-3,1,5,8,-6,-2,7,-9},
            {-9,4,3,-6,-1,2,-5,8,7},
            {-8,5,2,3,9,7,1,6,-4},
            {6,1,-7,4,-5,-8,9,3,-2},
            {-3,8,-4,-9,6,5,7,-2,1},
            {-1,-7,5,8,2,3,4,9,-6},
            {2,6,-9,-7,4,-1,3,5,8 }
        };
        #endregion
        #endregion

        #region NE PAS MODIFIER
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
            PréparerNouvellePartie();
        }
        /// <summary>
        /// Démarre une nouvelle partie
        /// </summary>
        private void mnuFichierNouvellePartie_Click(object sender, EventArgs e)
        {
            PréparerNouvellePartie();
        }
        //================================================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region PréparerNouvellePartie
        //================================================================================================
        /// <summary>
        /// TODO 01 : Copier uniquement les valeurs négatives (à rendre positive) du tableau m_tabSudokuMoyen 
        /// dans la grille et désélectionner les cellules recevant les valeurs, il s'agit des valeurs fixes 
        /// du jeu Sudoku. Les autres cellules vont contenir la valeur spéciale 0.
        /// </summary>
        private void PréparerNouvellePartie()
        {
			// À COMPLÉTER...

        }
        #endregion

        #region Solutionner le Sudoku
        //================================================================================================
        /// <summary>
        /// TODO 02 : Afficher la solution du Sudoku en copiant toutes les valeurs du tableau m_tabSudokuMoyen
        /// dans la grille. Attention : les valeurs fixes du jeu sont négatives et les autres sont positives.
        /// Désactiver l'option pour solutionner, et mettre le SelectedIndex à -1 pour la grille.
        /// </summary>
        private void mnuAideSolutionner_Click(object sender, EventArgs e)
        {
			// À COMPLÉTER...

        }
        #endregion

        #region VérifierLaFinDeLaPartie
        /// <summary>
        /// TODO 03 : Vérifier la fin d'une partie, vous devez compter le nombre de valeurs égale à 0,
        /// S'il n'y a aucune valeur à 0 et que : panJeu.BackColor == Color.Green alors la partie est terminée
        /// Il faut rendre inactive la grille et changer la couleur du panJeu pour Color.Orange
        /// 
        /// </summary>
        private void VérifierLaFinDeLaPartie()
        {
			// À COMPLÉTER...

        }
        #endregion

        #region Vérifier l'intégrité du Sudoku
        //================================================================================================
        /// <summary>
        /// TODO 04* : En utilisant un tableau de booléens, vous devez parcourir toutes les rangées afin 
        /// de mettre en rouge avec : panJeu.BackColor = Color.Red; le panneau panJeu si deux valeurs autres
        /// que la valeur spéciale se retrouvent sur une même rangée. 
        /// 
        /// Voici le tableau de booléens à utiliser :
        /// bool[] tabDesChiffresPrésents = { false, false, false, false, false, false, false, false, false, false };
        /// </summary>
        private void VérifierToutesLesRangées()
        {
			// À COMPLÉTER...

        }
        //================================================================================================
        /// <summary>
        /// TODO 05* : En utilisant un tableau de booléens, vous devez parcourir toutes les colonnes afin 
        /// de mettre en rouge avec : panJeu.BackColor = Color.Red; le panneau panJeu si deux valeurs autres
        /// que la valeur spéciale se retrouvent sur une même colonne. 
        /// 
        /// Voici le tableau de booléens à utiliser :
        /// bool[] tabDesChiffresPrésents = { false, false, false, false, false, false, false, false, false, false };
        /// </summary>
        private void VérifierToutesLesColonnes()
        {
			// À COMPLÉTER...

        }
        //================================================================================================
        /// <summary>
        /// TODO 06*** : En utilisant un tableau de booléens, vous devez parcourir toutes les regions afin 
        /// de mettre en rouge avec : panJeu.BackColor = Color.Red; le panneau panJeu si deux valeurs autres
        /// que la valeur spéciale se retrouvent sur une même région. 
        /// 
        /// Voici le tableau de booléens à utiliser :
        /// bool[] tabDesChiffresPrésents = { false, false, false, false, false, false, false, false, false, false };
        /// </summary>
        private void VérifierToutesLesRegions()
        {
			// À COMPLÉTER...

        }
        #endregion

        #region viaGrille_ValueChanged (À CONSULTER/NE PAS MODIFIER)
        //================================================================================================
        /// <summary>
        /// Vérifie l'intégrité du jeu et si la partie est terminée à chaque changement de valeur dans la grille.
        /// </summary>
        private void viaGrille_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            panJeu.BackColor = Color.Green;
            VérifierToutesLesColonnes();
            VérifierToutesLesRangées();
            VérifierToutesLesRegions();
            VérifierLaFinDeLaPartie();
        }
        #endregion
    }
}
