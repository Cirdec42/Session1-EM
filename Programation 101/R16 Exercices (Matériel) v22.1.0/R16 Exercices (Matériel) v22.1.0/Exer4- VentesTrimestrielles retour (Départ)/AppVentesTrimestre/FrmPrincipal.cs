using System;
using System.Windows.Forms;
using VisualArrays;

namespace AppVentesTrimestre
{
    /// <summary>
    /// Méthodes qui produisent un résultat
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        private const string APP_INFO = "(Matériel)";

        #region InitialiserLesGrilles (NE PAS MODIFIER)
        // tableau pré-initialisé à 1D des mois
        private string[] m_tabMois = { "Janvier", "Février", "Mars" };

        // tableau pré-initialisé à 1D des villes
        private string[] m_tabVilles = { "Boucherville", "Laval", "Longueuil", "Montréal" };

        //---------------------------------------------------------------------------------
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
            InitialiserLesGrilles();
        }
        //---------------------------------------------------------------------------------
        /// <summary>
        /// On va placer par programmation les en-têtes des rangées et des colonnes
        /// </summary>
        private void InitialiserLesGrilles()
        {
            for (int index = 0; index < vdaVentes.RowCount; index++)
                vdaVentes.RowHeaderArray[index] = m_tabVilles[index];

            for (int index = 0; index < vdaVentes.ColumnCount; index++)
                vdaVentes.ColumnHeaderArray[index] = m_tabMois[index];

            vdaTotauxParMois.RowHeaderArray[0] = "Totaux / Mois";
            vdaTotauxVilles.ColumnHeaderArray[0] = "Totaux / Villes";
        }
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
        //---------------------------------------------------------------------------------
        /// <summary>
        /// Place des valeurs aléatoires dans la grille des ventes seulement
        /// </summary>		
        private void mnuSpécialValeursAléatoires_Click(object sender, EventArgs e)
        {
            vdaVentes.BeginUpdate();
            for (int rangée = 0; rangée < vdaVentes.RowCount; rangée++)
            {
                for (int colonne = 0; colonne < vdaVentes.ColumnCount; colonne++)
                {
                    vdaVentes[rangée, colonne] = vdaVentes.RandomValue();
                }
            }
            vdaVentes.EndUpdate();
        }
        #endregion

        #region Méthodes pour calculer les sommes (À COMPLÉTER)

        /// <summary>
        /// Calcule la somme de toutes les valeurs pour une certaine colonne de la grille des ventes
        /// </summary>
        /// <param name="pColonne">Colonne à totaliser</param>
        /// <returns>Somme des valeurs dans pColonne</returns>
        private decimal SommeDuneColonne(int pColonne)
        {
            // TODO 01 : Effectuer la somme d'une colonne puis retourner le résultat en utilisant return
            
			return 0;
        }
        /// <summary>
        /// Calcule la somme de toutes les valeurs pour une certaine rangée de la grille des ventes
        /// </summary>
        /// <param name="pRangée">Rangée à totaliser</param>
        /// <returns>Somme des valeurs dans pRangée</returns>
        private decimal SommeDuneRangée(int pRangée)
        {
            // TODO 02 : Effectuer la somme d'une rangée puis retourner le résultat en utilisant return
           
		   return 0;
        }
        //---------------------------------------------------------------------------------
        /// <summary>
        /// Calcule la somme de toutes les valeurs dans la grille des ventes
        /// </summary>
        /// <returns>Somme de toutes les valeurs</returns>
        private decimal GrandTotal()
        {
            // TODO 03 : Effectuer la somme de toutes les valeurs de la grille des ventes et retourner le résultat en utilisant return
        
			return 0;
		}
        #endregion

        #region Événement ValueChanged (À COMPLÉTER)
        //---------------------------------------------------------------------------------
        private void vdaVentes_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            // TODO 04 : Appeler la méthode SommeDuneColonne pour afficher la somme de chacune des colonnes


            // TODO 05 : Appeler la méthode SommeDuneRangée pour afficher la somme de chacune des colonnes


            // TODO 06 : Appeler la méthode GrandTotal pour afficher la somme des toutes les valeurs

        }
        #endregion

    }
}
