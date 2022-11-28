using System;
using System.Windows.Forms;
using System.IO;
using VisualArrays;

namespace AppVentesTrimestre
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";

        #region NE PAS MODIFIER
        // tableau pré-initialisé à 1D des mois
        private string[] m_tabMois = { "Janvier", "Février", "Mars" };

        // tableau pré-initialisé à 1D des villes
        private string[] m_tabVilles = { "Boucherville", "Laval", "Longueuil", "Montréal" };


        //---------------------------------------------------------------------------------
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
            PréparerLesEntêtesDesGrilles();
        }

        #region Préparation des grilles
        //---------------------------------------------------------------------------------
        /// <summary>
        /// On va placer, par programmation, les en-têtes des rangées et des colonnes
        /// </summary>
        private void PréparerLesEntêtesDesGrilles()
        {
            for (int index = 0; index < vdaVentes.RowCount; index++)
            {
                vdaVentes.RowHeaderArray[index] = m_tabVilles[index];
            }

            for (int index = 0; index < vdaVentes.ColumnCount; index++)
            {
                vdaVentes.ColumnHeaderArray[index] = m_tabMois[index];
            }

            vdaTotauxParMois.RowHeaderArray[0] = "Totaux / Mois";
            vdaTotauxVilles.ColumnHeaderArray[0] = "Totaux / Villes";
        }
        #endregion

        #region Options du menu Fichier
        //---------------------------------------------------------------------------------
        /// <summary>
        /// Vide le contenu de la grille des ventes
        /// </summary>		
        private void mnuFichierNouveau_Click(object sender, EventArgs e)
        {
            vdaVentes.Clear();
        }
        //---------------------------------------------------------------------------------
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Méthodes pour calculer les sommes (NE PAS MODIFIER)
        //---------------------------------------------------------------------------------
        /// <summary>
        /// Calculer la somme d'une colonne de vdaVentes
        /// </summary>
        /// <param name="pColonne">index de la colonne à traiter</param>
        /// <returns>Retourne la somme de la colonne</returns>
        private decimal SommeDeLaColonne(int pColonne)
        {
            decimal accVentesDuMois = 0;
            for (int rangée = 0; rangée < vdaVentes.RowCount; rangée++)
            {
                accVentesDuMois += vdaVentes[rangée, pColonne];
            }
            return accVentesDuMois;
          
        }
        //---------------------------------------------------------------------------------
        /// <summary>
        /// Calculer la somme d'une rangée de vdaVentes
        /// </summary>
        /// <param name="pRangée">index de la rangée à traiter</param>
        /// <returns>Retourne la somme de la rangée</returns>
        private decimal SommeDeLaRangée(int pRangée)
        {
            decimal accVentesVille = 0;
            for (int colonne = 0; colonne < vdaVentes.ColumnCount; colonne++)
            {
                accVentesVille += vdaVentes[pRangée, colonne];
            }
            return accVentesVille;
          
        }
        //---------------------------------------------------------------------------------
        /// <summary>
        /// Calculer le grand total de toutes les ventes dans vdaVentes
        /// </summary>
        /// <returns>Retourne la somme de toutes les cases de vdaVentes </returns>
        private decimal GrandTotal()
        {  
            decimal grandTotal = 0;
            //Solution 1 en utilisant les ventes dans vdaVentes
            for (int rangée = 0; rangée < vdaVentes.RowCount; rangée++)
            {
                for (int colonne = 0; colonne < vdaVentes.ColumnCount; colonne++)
                {
                    grandTotal += vdaVentes[rangée, colonne];
                }
            }
            return grandTotal;
          
        }
        #endregion

        #region Événement ValueChanged (NE PAS MODIFIER)
        //---------------------------------------------------------------------------------
        private void vdaVentes_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.Address != Address.Empty) //Valeur changée par un clic sur la cellule
            {
                vdaTotauxParMois[e.Column] = SommeDeLaColonne(e.Column);
                vdaTotauxVilles[e.Row] = SommeDeLaRangée(e.Row);
            }

            else // Valeur changée par programmation
                // dans ce cas il faut tout mettre à jour
            {
                for (int rangée = 0; rangée < vdaVentes.RowCount; rangée++)
                {
                    vdaTotauxVilles[rangée] = SommeDeLaRangée(rangée);
                }
                for (int colonne = 0; colonne < vdaVentes.ColumnCount; colonne++)
                {
                    vdaTotauxParMois[colonne] = SommeDeLaColonne(colonne);
                }
            }
            vsdGrandTotal.Value = GrandTotal();
        }
        #endregion

        #endregion

        #region Charger les ventes  (À COMPLÉTER)
        //====================================================================================
        private void mnuFichierCharger_Click(object sender, EventArgs e)
        {
            // TODO 01 : Compléter le code de cette méthode qui doit lire le contenu du fichier "Ventes.txt"
            //           afin de le visualiser dans la grille vdaVentes. Vous devez utiliser les méthodes
            //           Split et Parse. 
            // Suggestion : Prenez le temps de consulter le fichier "Ventes.txt" avant de compléter cette méthode.
            StreamReader objFichier = new StreamReader("Ventes.txt");

            int rangee = 0;
            while (!objFichier.EndOfStream)
            {
                string ligneLue = objFichier.ReadLine();
                string[] tabm = ligneLue.Split(',');

                for (int i = 0; i < tabm.Length; i++)
                {
                    vdaVentes[rangee, i] = decimal.Parse(tabm[i]);
                }
                rangee++;   
            }
        }
        #endregion

        #region Enregistrer les ventes (À COMPLÉTER)
        //====================================================================================
        private void mnuFichierEnregistrer_Click(object sender, EventArgs e)
        {
            // TODO 02 : Compléter le code cette méthode qui doit enregistrer les valeurs de la grille vdaVentes
            //           dans un fichier avec des séparateurs. Vous devez écrire toutes les valeurs d'ne rangée
            //           sur une même ligne et utiliser une virgule pour séparer les valeurs.
            StreamWriter objFichier = new StreamWriter("Ventes.txt");

            for (int r = 0; r < vdaVentes.RowCount; r++)
            {
                for (int i = 0; i < vdaVentes.ColumnCount - 1; i++)
                {
                    objFichier.Write(vdaVentes[r, i] + ",");
                }
                objFichier.WriteLine(vdaVentes[r, vdaVentes.ColumnCount - 1]);

            }
            objFichier.Close();
        }
        #endregion

        private void vdaVentes_Click(object sender, EventArgs e)
        {

        }
    }
}
