using System;
using System.Drawing;
using System.Windows.Forms;
using VisualArrays;
using System.IO;

namespace AppSudoku
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";
        //================================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
            cboSudoku.SelectedIndex = 0;

            PréparerNouvellePartie();
        }

        #region Charger sudoku
        //================================================================================================
        /// <summary>
        /// Remplir les zones du sudoku en utilisant le fichier texte sélectionné dans le combobox 
        /// ou le fichier texte du répertoire SudokuSolution 
        /// </summary>
        /// <param name="pSolution">Vrai si on charge un fichier contenant la solution</param>
        private void ChargerSudoku(bool pSolution)
        {
            viaGrilleSudoku.Clear(); //  ne pas modifier

            // TODO 01 : Construire le nom du fichier à partir de la liste déroulante cboSudoku
            string nomFichier = "Sudoku\\" + cboSudoku.Text + ".txt";
            // TODO 02 : Compléter le code pour afficher uniquement la première rangée dans la grille de Sudoku
            //           Si le caractère dans le fichier est supérieur ou égal à 'A', affichez le caractère - 'A' dans la grille
            //           Si le caractère dans le fichier est inférieur à 'A', affichez le caractère - '0' dans la grille
            // TODO 03 : Améliorer votre code afin d'afficher toutes les valeurs dans la grille
            // TODO 04 : Améliorer votre code pour que quand le caractère du fichier est un caractère inférieur à 'A', désactiver les cellules de la grille 

            StreamReader objFichier = new StreamReader(nomFichier);
            int row = 0;
            while (!objFichier.EndOfStream)
            {
                string ligneLue = objFichier.ReadLine();
                for (int col = 0; col < ligneLue.Length; col++)
                {
                    if (ligneLue[col] >= 'A' && pSolution == true)
                    {
                        viaGrilleSudoku[row, col] = ligneLue[col] - 'A';
                    }
                    else if (ligneLue[col] < 'A')
                    {
                        viaGrilleSudoku[row, col] = ligneLue[col] - '0';
                        viaGrilleSudoku.DisableCell(row,col);
                    }
                }
                row++;
            }


            // TODO 05 : Améliorer votre code pour vérifier s'il faut montrer ou non la solution, selon la valeur de pSolution)
            if (pSolution == true)
            {
                mnuAideSolutionner.Enabled = true;
            }
            else
            {
                mnuAideSolutionner.Enabled = false;
            }

        }
        #endregion

        #region Gestionnaires d'événements

        //================================================================================================
        /// <summary>
        /// Prépare une nouvelle partie, charge le fichier sélectionné et affiche le sudoku de départ
        /// </summary>
        private void PréparerNouvellePartie()
        {
            viaGrilleSudoku.Enabled = true;
            ChargerSudoku(false);
            mnuAideSolutionner.Enabled = true;
        }

        //================================================================================================

        /// <summary>
        /// Démarre une nouvelle partie
        /// </summary>
        private void mnuFichierNouvellePartie_Click(object sender, EventArgs e)
        {
            PréparerNouvellePartie();
        }

        //================================================================================================
        /// <summary>
        /// Provoque le démarrage d'une nouvelle partie
        /// </summary>
        private void cboSudoku_SelectedIndexChanged(object sender, EventArgs e)
        {
            PréparerNouvellePartie();
        }
        //================================================================================================
        /// <summary>
        /// Terminer la partie.
        /// </summary>
        private void TerminerLaPartie()
        {
            viaGrilleSudoku.SelectedIndex = -1;
            viaGrilleSudoku.Enabled = false;
        }
        //================================================================================================
        /// <summary>
        /// Affiche la solution le Sudoku et termine la partie
        /// </summary>
        private void mnuAideSolutionner_Click(object sender, EventArgs e)
        {
            ChargerSudoku(true);
            TerminerLaPartie();
            panJeu.BackColor = Color.Green;
            mnuAideSolutionner.Enabled = false;
        }

        //================================================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Jouer et vérifier de l'intégrité du Sudoku

        //================================================================================================
        /// <summary>
        /// Vérifie la validité des rangées : les chiffres de 1 à 9 une seule fois.
        /// </summary>
        /// <param name="pRangée">index de la rangée à vérifier</param>
        /// <returns>true si la rangée est valide false sinon</returns>
        private bool RangeeValide(int pRangée)
        {
            bool[] tabDesChiffresPrésents = new bool[10];
            for (int colonne = 0; colonne < viaGrilleSudoku.ColumnCount; colonne++)
            {
                int chiffreCourant = viaGrilleSudoku[pRangée, colonne];
                if (chiffreCourant != 0)
                {
                    if (tabDesChiffresPrésents[chiffreCourant])
                    {
                        return false;
                    }
                    tabDesChiffresPrésents[chiffreCourant] = true;
                }
            }
            return true;
        }

        //================================================================================================
        /// <summary>
        /// Vérifie la validité des colonnes : les chiffres de 1 à 9 une seule fois.
        /// </summary>
        /// <param name="pColonne">index de la colonne à vérifier</param>
        /// <returns>true si la colonne est valide false sinon</returns>
        private bool ColonneValide(int pColonne)
        {
            bool[] tabDesChiffresPrésents = new bool[10];
            for (int rangee = 0; rangee < viaGrilleSudoku.RowCount; rangee++)
            {
                int chiffreCourant = viaGrilleSudoku[rangee, pColonne];
                if (chiffreCourant != 0)
                {
                    if (tabDesChiffresPrésents[chiffreCourant])
                    {
                        return false;
                    }
                    tabDesChiffresPrésents[chiffreCourant] = true;
                }
            }
            return true;
        }

        //================================================================================================
        /// <summary>
        /// Vérifie la validité d'une région : les chiffres de 1 à 9 une seule fois.
        /// </summary>
        /// <param name="pAdresse">adresse d'une case dans la région à vérifier</param>
        /// <returns>true si la région est valide false sinon</returns>
        private bool RegionValide(Address pAdresse)
        {
            int regionV = IndexDebutRegion(pAdresse.Row);
            int regionH = IndexDebutRegion(pAdresse.Column);

            bool[] tabDesChiffresPrésents = new bool[10];
            for (int rangee = regionV; rangee < regionV + 3; rangee++)
                for (int col = regionH; col < regionH + 3; col++)
                {
                    int chiffreCourant = viaGrilleSudoku[rangee, col];
                    if (chiffreCourant != 0)
                    {
                        if (tabDesChiffresPrésents[chiffreCourant])
                        {
                            return false;
                        }
                        tabDesChiffresPrésents[chiffreCourant] = true;
                    }
                }
            return true;
        }
        //================================================================================================
        /// <summary>
        /// Déterminer si l'intégrité du Sudoku est respectée
        /// </summary>
        /// <returns>true, si l'intégrité est respectée, false autrement</returns>
        private bool IntégritéRespectée()
        {
            for (int row = 0; row < viaGrilleSudoku.RowCount; row++)
                if (!RangeeValide(row)) return false;
            for (int col = 0; col < viaGrilleSudoku.ColumnCount; col++)
                if (!ColonneValide(col)) return false;

            for (int row = 0; row < viaGrilleSudoku.RowCount; row += 3)
                for (int col = 0; col < viaGrilleSudoku.ColumnCount; col += 3)
                    if (!RegionValide(new Address(row, col))) return false;

            return true;
        }
        //================================================================================================
        /// <summary>
        /// Vérifie s'il reste des cases du jeu à remplir
        /// </summary>
        /// <returns>true si la grille est complète sinon retourne false</returns>
        private bool GrilleEstComplète()
        {
            foreach (int chiffreCourant in viaGrilleSudoku)
                if (chiffreCourant == 0)
                    return false;

            return true;
        }
        //================================================================================================

        /// <summary>
        /// Terminer la partie après avoir gagner.
        /// </summary>
        private void Gagner()
        {
            TerminerLaPartie();
            panJeu.BackColor = Color.Orange;
        }

        /// <summary>
        /// Vérifie l'intégrité du jeu et si la partie est terminée à chaque changement de valeur dans la grille.
        /// </summary>
        private void viaSudoku_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //Console.WriteLine("viaSudoku_ValueChanged");
            for (int index = 0; index < 9; index++)
            {
                viaGrilleDuBas[index] = SommeColonne(index);
                viaGrilleDeDroite[index] = SommeRangée(index);
            }


            if (mnuAideSolutionner.Checked)
                return; // On n'a pas vérifier la validité si la solution est donnée par l'ordinateur

            if (e.Address != Address.Empty && IntégritéRespectée())
            {
                panJeu.BackColor = Color.Green;
                if (GrilleEstComplète())
                    Gagner();
            }
            else
            {
                panJeu.BackColor = Color.Red;
            }
        }


        //================================================================================================
        //NE PAS MODIFIER
        /// <summary>
        /// Détermine l'index de début d'un axe (une rangée ou une colonne) dans une région
        /// </summary>
        /// <param name="pRowCol">index d'une case dans un axe</param>
        /// <returns>l'index de début d'un axe dans cette région</returns>
        private int IndexDebutRegion(int pRowCol)
        {
            return pRowCol / 3 * 3;
        }

        #endregion 

        #region SommeRangée
        /// <summary>
        /// TODO 06 : Calcul la somme des valeurs pour une certaine rangée.
        /// </summary>
        /// <param name="pRangée">Rangée ciblée par le calcul</param>
        /// <returns>Somme des valeurs pour pRangée</returns>
        private int SommeRangée(int pRangée)
        {
            int sumRan=0;
                for (int col = 0; col < viaGrilleSudoku.ColumnCount; col++)
            {
                sumRan += viaGrilleSudoku[pRangée, col];
            }
            return sumRan;
        }
        #endregion

        #region SommeColonne
        /// <summary>
        /// TODO 07 : Calcul la somme des valeurs pour une certaine colonne
        /// </summary>
        /// <param name="pColonne">Colonne ciblée par le calcul</param>
        /// <returns>Somme des valeurs dans pColonne</returns>
        private int SommeColonne(int pColonne)
        {
            int sumCol = 0;
            for (int ran = 0; ran < viaGrilleSudoku.ColumnCount; ran++)
            {
                sumCol += viaGrilleSudoku[ran, pColonne];
            }
            return sumCol;
        }
        #endregion

        private void viaGrilleSudoku_Click(object sender, EventArgs e)
        {

        }
    }
}
