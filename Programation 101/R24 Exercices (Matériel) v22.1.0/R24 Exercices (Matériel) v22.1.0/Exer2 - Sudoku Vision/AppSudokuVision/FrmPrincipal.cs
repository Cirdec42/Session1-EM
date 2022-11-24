using System;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace AppSudoku
{
    /// <summary>
    /// Une application capable de lire un fichier texte contenant les informations pour un jeu de Sudoku
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";

        #region NE PAS MODIFIER
        //================================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
            ChargerSudoku();
        }
        //================================================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region ChargerSudoku (À COMPLÉTER)
        //================================================================================================
        /// <summary>
        /// Charge un fichier contenant les caractères pour un jeu de Sudoku et les affichent dans une 
        /// grille de caractères.
        /// </summary>
        private void ChargerSudoku()
        {
            vcaSudoku.Clear(); // 
            string nomDuFichier = "Sudoku.txt";

            // TODO 01 : Compléter le code pour afficher uniquement la première rangée dans la grille de Sudoku
            // TODO 02 : Améliorer votre code afin d'afficher toutes les valeurs dans la grille
            // TODO 03 : Désactiver les cellules contenant un caractère entre '1' et '9' inclusivement
            StreamReader objFichier = new StreamReader(nomDuFichier);
            int row = 0;
            while (!objFichier.EndOfStream)
            {
                String ligneLue = objFichier.ReadLine();
                for (int i = 0; i < ligneLue.Length; i++)
                {
                    vcaSudoku[row, i] = ligneLue[i];

                    if (vcaSudoku[row, i] >='1' && vcaSudoku[row,i]<='9')
                    {
                        vcaSudoku.DisableCell(row, i);
                    }
                }
                row++;
            }

        }
        #endregion

        private void vcaSudoku_Click(object sender, EventArgs e)
        {

        }
    }
}
