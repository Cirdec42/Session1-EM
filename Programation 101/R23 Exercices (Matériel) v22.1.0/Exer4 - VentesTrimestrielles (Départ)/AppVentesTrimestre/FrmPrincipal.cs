using System;
using System.IO;
using System.Windows.Forms;
using VisualArrays;

namespace AppVentesTrimestre
{
    /// <summary>
    /// Manipulation de tableaux à 1D et 2D
    /// Méthodes avec paramètres
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        private const string APP_INFO = "(Matériel)";

        // tableau pré-initialisé à 2D contenant les ventes pour chaque ville à chaque mois
        private decimal[,] m_tabVentes = {
                                         { 12455, 14522, 19111 },
                                         { 33450, 36232, 42244 },
                                         { 31150, 32350, 22250 },
                                         { 33432, 36745, 42278 } };
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
        /// Placer des valeurs aléatoires dans la grille des ventes seulement
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

        #region Méthodes pour calculer les sommes : À COMPLÉTER
        //---------------------------------------------------------------------------------
        /// <summary>
        /// TODO 01 : Calculer la somme des colonnes et placer le résultat dans vdaTotauxParMois
        /// </summary>
        private void CalculerLaSommeDesColonnes()
        {
            // À compléter
        }
        //---------------------------------------------------------------------------------
        /// <summary>
        /// TODO 02 : Calculer la somme des rangées et placer le résultat dans vdaTotauxVilles
        /// </summary>
        private void CalculerLaSommeDesRangées()
        {
           // À compléter

        }
        //---------------------------------------------------------------------------------
        /// <summary>
        /// TODO 03 : Calculer le grand total de toutes les ventes et placer le résultat dans vsdGrandTotal
        /// </summary>
        private void CalculerGrandTotal()
        {
            // À compléter

        }
        #endregion

        #region Menu Spécial : À COMPLÉTER
        //=============================================================================================
        private void MnuSpécialMultiples_Click(object sender, EventArgs e)
        {
            // TODO 04 : Placer des multiples de 10 dans la grille vdaVentes
            vdaVentes.BeginUpdate();
            
            // À compléter

            vdaVentes.EndUpdate();
        }
        //=============================================================================================
        private void MnuSpécialTableauVersGrille_Click(object sender, EventArgs e)
        {
            // TODO 05 : Copier toutes les valeurs du tableau 2D m_tabVentes dans la grille vdaVentes
            vdaVentes.BeginUpdate();
            
            // À compléter

            vdaVentes.EndUpdate();
        }
        //=============================================================================================
        private void MnuSpécialGrilleVersTableau_Click(object sender, EventArgs e)
        {
            // TODO 06 : Copier toutes les valeurs de la grille vdaVentes dans le tableau m_tabVentes
            
            // À compléter
        }
        #endregion

        #region Événement ValueChanged : NE PAS MODIFIER
        //---------------------------------------------------------------------------------
        private void vdaVentes_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            CalculerLaSommeDesColonnes();
            CalculerLaSommeDesRangées();
            CalculerGrandTotal();
        }
        #endregion

        #region Menu Enregistrer et charger fichier : À COMPLÉTER
        private void MnuFichierEnregistrer_Click(object sender, EventArgs e)
        {
            // TODO 07 : Copier toutes les valeurs de la grille vdaVentes dans le fichier Ventes.txt

            // À compléter
        }

        private void MnuFichierCharger_Click(object sender, EventArgs e)
        {
            // TODO 08 : Copier toutes les valeurs de la grille vdaVentes dans le fichier Ventes.txt
            // Àcompléter


        }
        #endregion

    }
}
