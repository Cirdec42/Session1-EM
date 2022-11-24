using System;
using System.Windows.Forms;
using System.IO;

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
        }
        #endregion

        //================================================================================================
        private void MnuFichierNouvelleGrilleVide_Click(object sender, EventArgs e)
        {
            vcaGrilleCarac.Clear();
        }
        //================================================================================================
        private void MnuFichierChargerLesCaractères_Click(object sender, EventArgs e)
        {
            vcaGrilleCarac.Clear(); // Ne pas modifier

            // TODO 01 : Ouvrir en mode lecture un fichier texte appelé GrilleDeCaractères.txt
            // À compléter
            StreamReader objFichier = new StreamReader("GrilleDeCaractères.txt");
            int ran = 0;
            while (!objFichier.EndOfStream)
            {
             string ligneLue = objFichier.ReadLine();

                for (int i = 0; i < ligneLue.Length; i++)
                {
                    vcaGrilleCarac[ran,i] = ligneLue[i];
                }
                ran++;
            }
            objFichier.Close();

            // TODO 02 : Lire le fichier (tant que ce n'est pas la fin du fichier, lire une ligne à la fois )
			// Ensuite, pour chaque ligne, passez à travers chaque caractère pour transposer chaque caractère dans la grille vcaGrilleCarac
            // À compléter

            // TODO 03 : Fermer le lecteur ouvert en mode lecture
            // À compléter

        }
        //================================================================================================
        private void MnuFichierEnregistrerCaractères_Click(object sender, EventArgs e)
        {
            // TODO 04 : Ouvrir en mode écriture un fichier texte appelé GrilleDeCaractères.txt
            // À compléter
            StreamWriter objFichier = new StreamWriter("GrilleDeCaractères.txt");
            for (int ran = 0; ran < vcaGrilleCarac.RowCount; ran++)
            {
            for (int i = 0; i < vcaGrilleCarac.ColumnCount; i++)
            {
                objFichier.Write(vcaGrilleCarac[ran, i]);
            }
            objFichier.WriteLine();

            }

            // TODO 05 : Passez à travers la grille vcaGrilleCarac et copiez son contenu dans le fichier
            //    une ligne à la fois.
            //    Attention: Quand vous écrivez un caractère sur une même ligne du fichier, utilisez .Write
            //    Attention: Quand vous vous voulez signifier la fin de la ligne du fichier, utilisez .WriteLine
            // À compléter

            // TODO 06 : Fermer le fichier ouvert en mode écriture
            // À compléter

            objFichier.Close();

        }
        //================================================================================================
        private void MnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vcaGrilleCarac_Click(object sender, EventArgs e)
        {

        }
    }
}
