using System;
using System.Windows.Forms;

namespace MethodeAvecRetour
{
    /// <summary>
    /// Application qui illustre comment obtenir des statistiques à partir d'une grille de nombres
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        const string NOM_PRENOM = "(Matériel)";

        #region NE PAS MODIFIER
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += NOM_PRENOM;
            for (int index = 0; index < viaNombres.Length; index++)
                viaNombres[index] = viaNombres.RandomValue();
        }
        private void MnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Placer des nombres aléatoires dans la grille (NE PAS MODIFIER)
        /// -----------------------------------------------------------------------------------------
        private void BtnPlacerNbrAléatoires_Click(object sender, EventArgs e)
        {
            viaNombres.Clear();
            for (int index = 0; index < viaNombres.Length; index++)
                viaNombres[index] = viaNombres.RandomValue();
        }
        #endregion

        #region Somme des valeurs de la grille
        // -----------------------------------------------------------------------------------------
        /// <summary>
        /// Retourne la somme des valeurs de la grille viaNombres
        /// </summary>
        /// <returns>Somme des valeurs de la grille viaNombres</returns>
        private int SommeDesValeursDeLagrille()
        {
            // TODO 01A : Compléter la méthode, voir summary au dessus
            int accTotal = 0;

            for (int i = 0; i < viaNombres.Length; i++)
            {
                accTotal += viaNombres[i];
            }
            return accTotal;
        }

        private void BtnSomme_Click(object sender, EventArgs e)
        {
            // TODO 01B : Appeler la méthode SommeDesValeursDeLagrille pour changer la valeur de vsiRésultat
            vsiRésultat.Value = SommeDesValeursDeLagrille();
        }
        #endregion

        #region Moyenne des valeurs dans la grille
        // -----------------------------------------------------------------------------------------
        /// <summary>
        /// Retourne la moyenne des valeurs de la grille viaNombres
        /// </summary>
        /// <returns>moyenne des valeurs de la grille viaNombres</returns>
        private int MoyenneDesValeursDeLaGrille()
        {
            // TODO 02A : Compléter la méthode, voir summary au dessus
            int moyenne = 0;

            for (int i = 0; i < viaNombres.Length; i++)
            {
                moyenne += viaNombres[i];
            }
            moyenne = moyenne / viaNombres.Length;
            return moyenne;
        }
        // -----------------------------------------------------------------------------------------
        private void BtnMoyenne_Click(object sender, EventArgs e)
        {
            // TODO 02B : Appeler la méthode MoyenneDesValeursDeLaGrille pour changer la valeur de vsiRésultat
            vsiRésultat.Value=MoyenneDesValeursDeLaGrille();
        }
        #endregion

        #region Minimum des valeurs dans la grille
        // -----------------------------------------------------------------------------------------
        /// <summary>
        /// Retourne la plus petite valeur de la grille viaNombres
        /// </summary>
        /// <returns>plus petite valeur de la grille viaNombres</returns>
        private int MinimumDesValeursDansLaGrille()
        {
            // TODO 03A : Compléter la méthode, voir summary au dessus
            int minimum = viaNombres[0];

            for (int i = 0; i < viaNombres.Length; i++)
            {
                if (viaNombres[i]< minimum)
                {
                    minimum = viaNombres[i];
                }
            }
            return minimum;
        }
        /// -----------------------------------------------------------------------------------------
        private void BtnMinimum_Click(object sender, EventArgs e)
        {
            // TODO 03B : Appeler la méthode MinimumDesValeursDansLaGrille pour changer la valeur de vsiRésultat
            vsiRésultat.Value = MinimumDesValeursDansLaGrille();
        }
        #endregion

        #region Maximum des valeurs dans la grille
        // -----------------------------------------------------------------------------------------
        /// <summary>
        /// Retourne la plus grande valeur de la grille viaNombres
        /// </summary>
        /// <returns>plus grande valeur de la grille viaNombres</returns>
        private int MaximumDesValeursDansLaGrille()
        {
            // TODO 04A : Compléter la méthode, voir summary au dessus
            int maximum = viaNombres[0];

            for (int i = 0; i < viaNombres.Length; i++)
            {
                if (viaNombres[i]>maximum)
                {
                    maximum = viaNombres[i];
                }
            }
            return maximum;
        }
        /// -----------------------------------------------------------------------------------------
        private void BtnMaximum_Click(object sender, EventArgs e)
        {
            // TODO 04B : Appeler la méthode MaximumDesValeursDansLaGrille pour changer la valeur de vsiRésultat
            vsiRésultat.Value = MaximumDesValeursDansLaGrille();
        }
        #endregion

        #region Nombre de valeurs supérieures à la moyenne
        // -----------------------------------------------------------------------------------------
        /// <summary>
        /// Détermine le nombre de valeurs qui sont supérieures à la moyenne des nombres dans viaNombres
        /// </summary>
        /// <returns>nombre de valeurs supérieures à la moyenne</returns>
        private int NbValeursSupérieuresALaMoyenne()
        {
            // TODO 05A : Compléter la méthode, voir summary au dessus
            int moyennesup = MoyenneDesValeursDeLaGrille();
            int cptValeurSup = 0;
            for (int i = 0; i < viaNombres.Length; i++)
            {
                if (viaNombres[i]>moyennesup)
                {
                    cptValeurSup++;
                }
            }
            return cptValeurSup;
        }
        private void BtnSupérieureMoyenne_Click(object sender, EventArgs e)
        {
            // TODO 05B : Appeler la méthode NbValeursSupérieuresALaMoyenne pour changer la valeur de vsiRésultat
            vsiRésultat.Value = NbValeursSupérieuresALaMoyenne();
        }
        #endregion

        #region Valeur à rechercher dans la grille
        /// <summary>
        /// Détermine si une valeur se trouve ou pas dans la grille viaNombres
        /// </summary>
        /// <param name="pValeur">Valeur à trouver dans la grille</param>
        /// <returns>true si la valeur à trouver est dans la grille, false autrement</returns>
        private bool EstDansLaGrille(int pValeur)
        {
            // TODO 06A : Compléter la méthode, voir summary au dessus
            for (int i = 0; i < viaNombres.Length; i++)
            {
                if (viaNombres[i] == pValeur)
                {
                    return true;
                }
            }
            return false;
        }
        private void VsiValeurRecherchée_ValueChanged(object sender, EventArgs e)
        {
            // TODO 06B : Appeler la méthode EstDansLaGrille pour changer la valeur de vsbValeurÀTrouver
            vsbValeurÀTrouver.Value = EstDansLaGrille(vsiValeurÀTrouver.Value);
        }
        #endregion

        #region On utilise les méthodes ci-hauts
        private void BtnSélectionnerMinimum_Click(object sender, EventArgs e)
        {
            // TODO 07 : Vous devez sélectionner la plus petite valeur qui se trouve dans la grille 
			//           en utilisant la propriété SelectedIndex de la grille et la méthode MinimumDesValeursDansLaGrille définie auparavant
            int minimum
                =0;
            for (int i = 0; i < viaNombres.Length; i++)
            {
                if (viaNombres[i]==minimum)
                {
                    viaNombres.SelectedIndex = i;
                }
            }
        }
        private void BtnSélectionnerMaximum_Click(object sender, EventArgs e)
        {
            // TODO 08 : Vous devez sélectionner la plus grande valeur qui se trouve dans la grille 
            //           en utilisant la propriété SelectedIndex de la grille et la méthode MaximumDesValeursDansLaGrille définie auparavant
            int maximum = 0;
            for (int i = 0; i < viaNombres.Length; i++)
            {
                if (viaNombres[i]==maximum)
                {
                    viaNombres.SelectedIndex = i;
                }
            }
        }
        private void BtnSélectionnerValeurÀTrouver_Click(object sender, EventArgs e)
        {
            // TODO 09 : Vous devez sélectionner la valeur à trouver dans la grille, 
            //           en utilisant la propriété SelectedIndex de la grille
            //           Si la valeur à trouver n'est pas dans la grille, sélectionner rien avec -1 comme valeur de SelectedIndex
            int atrouver = 0;
            for (int i = 0; i < viaNombres.Length; i++)
            {
                if (viaNombres[i]==atrouver)
                {
                    viaNombres.SelectedIndex = i;
                }
                else
                {
                    viaNombres.SelectedIndex = -1;
                }
            }
        }
        #endregion
    }
}
