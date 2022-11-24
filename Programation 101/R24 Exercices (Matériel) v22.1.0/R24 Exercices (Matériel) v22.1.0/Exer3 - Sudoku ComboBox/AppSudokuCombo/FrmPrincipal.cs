using System;
using System.Windows.Forms;
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

        #region ChargerSudoku (À COMPLÉTER)
        //================================================================================================
        /// <summary>
        /// Charge un fichier contenant les caractères pour un jeu de Sudoku et les affichent dans une 
        /// grille de caractères.
        /// </summary>
        private void ChargerSudoku()
        {
            vcaSudoku.Clear(); // Ne pas modifier

            // TODO 01 : COnstruire le nom du fichier à partir du texte de la liste déroulante cboSudoku (voir vidéo au besoin)
            // TODO 02 : Compléter le code pour afficher uniquement la première rangée dans la grille de Sudoku
            // TODO 03 : Améliorer votre code afin d'afficher toutes les valeurs dans la grille
            // TODO 04 : Désactiver les cellules de la grille qui contiennent un caractère inférieur à 'A'
            string nomDuFichier = "Sudoku\\" + cboSudoku.Text + ".txt";
            StreamReader objFichier = new StreamReader(nomDuFichier);
            int row = 0;
            while (!objFichier.EndOfStream)
            {
                string uneLigne = objFichier.ReadLine();
                for (int index = 0; index < uneLigne.Length; index++)
                {
                    char carac = uneLigne[index];
                    {
                        vcaSudoku[row, index] = carac;
                        if (carac >= '1' && carac <= '9')
                            vcaSudoku.DisableCell(row, index);
                    }
                }
                row++;
            }
            objFichier.Close();
        }
        #endregion

        #region Gestionnaires d'événements (NE PAS MODIFIER)

        //================================================================================================
        /// <summary>
        /// Prépare une nouvelle partie, charge le fichier sélectionné et affiche le sudoku de départ
        /// </summary>
        private void PréparerNouvellePartie()
        {
            vcaSudoku.Enabled = true;
            ChargerSudoku();
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
            ChargerSudoku();
        }

        //================================================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void vcaSudoku_Click(object sender, EventArgs e)
        {

        }
    }
}
