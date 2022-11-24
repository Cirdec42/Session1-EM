using System;
using System.Windows.Forms;
using System.IO;

namespace Exercice_Tab2D_Ventes
{

    /// -----------------------------------------------------------------------------------------------------------------------
    /// <summary>
    /// Description:    Lorsque l'on change d'année, on affiche dans la grille, les ventes correspondantes à l'année choisie.
    ///                 
    /// Concepts:       Boite combo "cboAnnée" permettant de sélectionner une année
    ///                 vdaGrilleVentes --> de 1 x 12 pour afficher les ventes des 12 mois de l'année sélectionnée
    ///                 m_tabVentes  --> un tableau à 2D de 10 X 12 ( il y a 10 années et 12 mois)
    ///                 
    /// </summary>
    /// ------------------------------------------------------------------------------------------------------------------------
    public partial class FrmPrincipal : Form
    {
        const string APP_INFO = "(Matériel)";

        string[] m_tabNomsMois = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet",
                                            "Août", "Septembre", "Octobre", "Novembre", "Décembre"};
        const int ANNEE_DEPART = 2010;
        const int NBR_ANNEES = 10;
        const string NOM_FICHIER_VENTES = "Ventes_2D.txt";

        decimal[,] m_tabVentes;

        #region NE PAS MODIFIER
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
            //-----------------------
            Initialiser();
        }
        //================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Code pour lecture du fichier

        /// ================================================================================================
        /// <summary>
        ///  Compléter la méthode Initialiser.
        ///      - instancier le tableau des ventes :
        ///               nombre de rangées  --> nombre d'années à l'étude
        ///               nombre de colonnes --> 12 mois
        ///      - remplir le tableau des ventes à l'aide des données contenues dans le fichier fourni.
        ///              chaque ligne contient 12 ventes séparées par des ':'
        ///              le fichier a été validé: il contient le bon nombre de données
        ///      - ajouter des entêtes de colonnes à la grille des ventes 
        ///      - remplir la boite combo et sélectionner le 1er élément de la boite.
        /// </summary>
        /// ------------------------------------------------------------------------------------------------
        private void Initialiser()
        {
            // TODO 01 : Instancier un tableau à 2 dimensions de 10 rangées et 12 colonnes, le type des cases est decimal
           
		   
		   
		    
            // TODO 02 : Ajouter le code pour remplir le tableau 2D de 120 cases avec les montants des Ventes annuelles.
            //           Le fichier se nomme "Ventes_2D.txt" (Aller le consulter avant de compléter le code) et contient
            //           12 valeurs par ligne, le fichier contient exactement 10 lignes pour les ventes de 10 années.
            // IMPORTANT : La visualisation des ventes s'effectue dans uniquement dans le cboAnnee_SelectedIndexChanged         
           
		   
		   
		   
			
			
            #region Code pour placer les en-têtes des colonne de la grille (NE PAS MODIFIER)
            for (int colonne = 0; colonne < vdaGrilleVentes.ColumnCount; colonne++)
            {
                vdaGrilleVentes.ColumnHeaderArray[colonne] = m_tabNomsMois[colonne];
            }
            #endregion

            #region Code pour peupler le contenu des items du ComboBox cboAnnee (NE PAS MODIFIER)
            for (int index = 0; index < NBR_ANNEES; index++)
            {
                cboAnnée.Items.Add(ANNEE_DEPART + index);
            }
            cboAnnée.SelectedIndex = 0;
            #endregion
        }
        #endregion

        #region cboAnnee_SelectedIndexChanged
        //========================================================================================================================
        /// <summary>
        ///  Lorsque l'on change d'année, on affiche dans la grille, les ventes correspondantes à l'année choisie.
        /// </summary>
        /// ----------------------------------------------------------------------------------------------------------------------
        private void cboAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO 03 : Lorsque l'on change d'année dans le combo cboAnnée, on doit afficher dans la grille
            //           les ventes correspondantes à l'année choisie. Le truc c'est d'utiliser le SelectedIndex.
          
		  
		  
		  
        }
        #endregion
    }
}
