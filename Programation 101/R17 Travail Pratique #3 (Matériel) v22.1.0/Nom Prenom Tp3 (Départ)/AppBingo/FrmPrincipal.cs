using System;
using System.Windows.Forms;
using VisualArrays;

namespace AppBingo
{
    /// <summary>
    /// Bingo à 75 boules.
    /// Le jeu du bingo à 75 boules se joue avec une carte de 5 rangées et de 5 colonnes,
    /// avec en tout 24 numéros dans les cases et une case gratuite au centre.
    /// Les 75 boules (chacune marquée d’un numéro compris entre 1 et 75) sont tirées de façon aléatoire 
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        // TODO 00 Écrire votre NOM et PRÉNOM  
        public const string APP_INFO = "DAIGNEAULT CEDRIC";
        //------------------------------------------------------------------------------------------
        const string NOM_JEU = "BINGO";
        const int COLONNE_MILIEU = 2;
        const int RANGÉE_MILIEU = 2;
        const int NB_VALEURS_PAR_COLONNE = 15;
        const int TAILLE_CARTE = 5; // 5 par 5
        const int NON_TROUVÉE = -1;

        #region NE PAS MODIFIER
        //==========================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            PréparerUneNouvellePartie();
        }
        //==========================================================================================
        private void mnuFichierNouvellePartie_Click(object sender, EventArgs e)
        {
            PréparerUneNouvellePartie();
        }
        //=================================================================================================
        private void mnuSpécialTest_Click(object sender, EventArgs e)
        {
            // Enlever les commentaires lorsque l'application sera complétée
            //while (btnRetirer.Enabled)
            //    btnRetirer.PerformClick();
        }
        //==========================================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region PlacerLesEntetesDesColonnes (NE PAS MODIFIER)
        //==========================================================================================
        /// <summary>
        /// Place les en-têtes des chacune des colonnes soit les lettres B I N G O
        /// </summary>
        /// <param name="pCarte">Carte à préparer</param>
        private void PlacerLesEntetesDesColonnes(VisualIntArray pCarte)
        {
            // On va placer les en-têtes des colonnes
            for (int index = 0; index < NOM_JEU.Length; index++)
            {
                pCarte.ColumnHeaderArray[index] = NOM_JEU[index].ToString();
            }
                
        }
        #endregion

        #region PréparerUneNouvellePartie (À COMPLÉTER)
        public void PréparerUneNouvellePartie()
        {
            // À COMPLÉTER...
            viaCarteMaîtresse.Clear();
            viaBoulier.Clear();
            vsiNbBoulesRetirées.Value = 0;
            PréparerCarteMaîtresse();
            PréparerBoulier();
            PréparerCarteDeBingo(viaCarte1);
            PréparerCarteDeBingo(viaCarte2);
            PréparerCarteDeBingo(viaCarte3);
            PréparerCarteDeBingo(viaCarte4);

            btnRetirer.Enabled = true;




            // TODO 10 (2 pts) Ajuster l'état du formulaire conséquemment avec la démo

            // À COMPLÉTER...
        }
        #endregion

        #region PréparerCarteMaîtresse (TODO 01)
        // TODO 01 (15 pts) Préparer la carte maîtresse
        //==========================================================================================
        /// <summary>
        /// Prépare la carte maîtresse, celle utilisée par le crieur, elle contient toutes les boules
        /// de 1 à 75 disposées sur 5 colonnes de 15 rangées
        /// Méthode à appeler : PlacerLesEntetesDesColonnes 
        /// Appeler cette méthode dans PréparerUneNouvellePartie
        /// </summary>
        private void PréparerCarteMaîtresse()
        {
            // À COMPLÉTER...
            PlacerLesEntetesDesColonnes(viaCarteMaîtresse);
            int numero = 1;
            for (int col = 0; col < viaCarteMaîtresse.ColumnCount; col++)
            {
                for (int ran = 0; ran < viaCarteMaîtresse.RowCount; ran++)
                {
                    viaCarteMaîtresse[ran, col] = numero;
                    numero++;
                }
            }
        }
        #endregion

        #region PréparerBoulier (TODO 02)
        // TODO 02 (8 pts) Préparer le boulier
        /// <summary>
        /// Place les 75 valeurs du boulier séquentiellement, puis mélange les cases de la grille.
        /// Appeler cette méthode dans PréparerUneNouvellePartie
        /// </summary>
        public void PréparerBoulier()
        {
            // À COMPLÉTER...
            for (int col = 0; col < viaBoulier.ColumnCount; col++)
            {
                for (int ran = 0; ran < viaBoulier.RowCount; ran++)
                {
                    viaBoulier[ran,col] = viaCarteMaîtresse[ran,col];
                    
                }
            }
            viaBoulier.MixUp();
        }
        #endregion

        #region MnuSpécialBoulier_Click (TODO 03)
        // TODO 03 (6 pts) Rendre visible ou non la grille du boulier
        /// <summary>
        /// Rend visible le boulier viaBoulier et ajuster le texte en conséquence (voir démo)
        /// Pour tester : Choisir l'option Voir le boulier dans le menu Spécial
        /// </summary>
        public void MnuSpécialBoulier_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            if (viaBoulier.Visible== false)
            {
                viaBoulier.Visible = true;
            }
            else
            {
                viaBoulier.Visible= false;
            }
        }
        #endregion

        #region ObtenirUnNuméroDeBoule (NE PAS MODIFIER)
        /// <summary>
        /// Fournit un numéro de boule unique à placer sur une carte
        /// </summary>
        /// <param name="pCarte">Carte sur laquelle placer le nouveau numéro de boule</param>
        /// <param name="pColonne">Colonne dans laquelle placer le nouveau numéro de boule</param>
        /// <returns>Nouveau numéro de boule à placer sur la carte</returns>
        private int ObtenirUnNuméroDeBoule(VisualIntArray pCarte, int pColonne)
        {
            #region NE PAS MODIFIER
            int nouvelleValeur;
            do
            {
                nouvelleValeur = pCarte.RandomValue(pColonne * 15 + 1, (pColonne + 1) * 15);
            } while (pCarte.ContainsValue(nouvelleValeur));
            return nouvelleValeur;
            #endregion
        }
        #endregion

        #region PlacerNombresSurCarteDeBingo (TODO 04)
        // TODO 04 (15 pts) Placer les nombres sur les cartes de bingo
        //==========================================================================================
        /// <summary>
        /// Remplir la carte (sauf case gratuite) en utilisant les nombres obtenus par la méthode ObtenirUnNuméroDeBoule
        /// Méthode à appeler : ObtenirUnNuméroDeBoule
        /// Pour tester : Appeler la méthode dans PréparerUneNouvellePartie, avec viaCarte1. 
        /// Après votre test, enlever cet appel.
        /// </summary>
        /// <param name="pCarte">Carte à initialiser</param>
        public void PlacerNombresSurCarteDeBingo(VisualIntArray pCarte)
        {
            // À COMPLÉTER...
            for (int col = 0; col < viaCarte1.ColumnCount; col++)
            {
                for (int ran = 0; ran < viaCarte1.RowCount; ran++)
                {
                    viaCarte1[ran, col] = ObtenirUnNuméroDeBoule(viaCarte1,col);
                }
            }
            for (int col = 0; col < viaCarte2.ColumnCount; col++)
            {
                for (int ran = 0; ran < viaCarte2.RowCount; ran++)
                {
                    viaCarte2[ran, col] = ObtenirUnNuméroDeBoule(viaCarte2, col);
                }
            }
            for (int col = 0; col < viaCarte3.ColumnCount; col++)
            {
                for (int ran = 0; ran < viaCarte3.RowCount; ran++)
                {
                    viaCarte3[ran, col] = ObtenirUnNuméroDeBoule(viaCarte3, col);
                }
            }
            for (int col = 0; col < viaCarte4.ColumnCount; col++)
            {
                for (int ran = 0; ran < viaCarte4.RowCount; ran++)
                {
                    viaCarte4[ran, col] = ObtenirUnNuméroDeBoule(viaCarte4, col);
                }
            }
            viaCarte1[2, 2] = 0;
            viaCarte2[2, 2] = 0;
            viaCarte3[2, 2] = 0;
            viaCarte4[2, 2] = 0;

        }
        #endregion

        #region PréparerCarteDeBingo (TODO 05)
        // TODO 05 (3 pts) Préparer une carte de bingo pour une nouvelle partie
        /// <summary>
        /// Prépare une carte de bingo pour une nouvelle partie.
        /// Méthodes à appeler : PlacerLesEntetesDesColonnes et PlacerNombresSurCarteDeBingo
        /// Appeler la méthode PréparerCarteDeBingo pour chacune des cartes dans PréparerUneNouvellePartie
        /// </summary>
        /// <param name="pCarte">Carte à préparer</param>
        public void PréparerCarteDeBingo(VisualIntArray pCarte)
        {
            pCarte.Clear(); // NE PAS MODIFIER
            pCarte.Sprites[0].Visible = false; // NE PAS MODIFIER
            // À COMPLÉTER...
            PlacerLesEntetesDesColonnes(pCarte);
            PlacerNombresSurCarteDeBingo(pCarte);

        }
        #endregion

        #region ColonneDeLaBouleSurLaCarte (TODO 06)
        // TODO 06 (6 pts) Déterminer la colonne correspondant au numéro de la boule
        /// <summary>
        /// Permet de calculer la colonne correspondante à la valeur d'une boule.
        /// </summary>
        /// <param name="pNuméroBoule">Un numéro de boule entre 1 et 75</param>
        /// <returns>Un index de colonne de base 0 en fonction du numéro de la boule</returns>
        public int ColonneDeLaBouleSurLaCarte(int pNuméroBoule)
        {

            // À COMPLÉTER...
            return (pNuméroBoule-1)/NB_VALEURS_PAR_COLONNE;
        }
        #endregion

        #region RangéeDeLaBouleSurLaCarte (NE PAS MODIFIER)
        /// Détermine si une boule se retrouve sur une carte, si oui alors on retourne le numéro de la rangée
        /// ou la boule à été trouvée.
        /// </summary>
        /// <param name="pCarte">Carte à vérifier</param>
        /// <param name="pBoule">Numéro d'une boule entre 1 et 75</param>
        /// <returns>Numéro de la rangée de base 0, retourne -1 si non trouvée</returns>
        private int RangéeDeLaBouleSurLaCarte(VisualIntArray pCarte, int pBoule)
        {
            int colonne = ColonneDeLaBouleSurLaCarte(pBoule);
            for (int rangée = 0; rangée < pCarte.RowCount; rangée++)
            {
                if (pCarte[rangée, colonne] == pBoule)
                {
                    return rangée;
                }
            }
            return NON_TROUVÉE;
        }
        #endregion

        #region TraiterLaBouleRetirée (TODO 08)
        // TODO 08 (10 pts) Traiter la boule retirée du boulier
        // ===========================================================================================
        /// <summary>
        /// Désactive la cellule contenant la boule si elle existe sur la carte et vérifie s'il y a un bingo.
        /// Méthode à appeler : ColonneDeLaBouleSurLaCarte, RangéeDeLaBouleSurLaCarte et BingoExisteSurLaCarte
        /// </summary>
        /// <param name="pCarte">Carte à traiter</param>
        /// <param name="pNuméroBoule">Numéro de la boule entre 1 et 75</param>
        public void TraiterLaBouleRetirée(VisualIntArray pCarte, int pNuméroBoule)
        {
            if (RangéeDeLaBouleSurLaCarte(pCarte,pNuméroBoule) !=-1)
            {
                pCarte.DisableCell(RangéeDeLaBouleSurLaCarte(pCarte, vsiBoule.Value), ColonneDeLaBouleSurLaCarte(vsiBoule.Value));
            }
            if (BingoExisteSurLaCarte(pCarte))
            {
                btnRetirer.Enabled = false;
                
            }
            // À COMPLÉTER...
            int col = ColonneDeLaBouleSurLaCarte(pNuméroBoule);
            int ran = RangéeDeLaBouleSurLaCarte(pCarte,pNuméroBoule);
            bool bingo = BingoExisteSurLaCarte(pCarte);


        }
        #endregion

        #region BingoExisteSurLaCarte (TODO 09)
        // TODO 09 (15 pts) Vérifier si un bingo existe sur une carte
        // =====================================================================================================
        /// <summary>
        /// Détermine si un Bingo existe sur une carte. Cette méthode effectue plusieurs appels à la méthode SuiteGagnante
        /// </summary>
        /// <param name="pCarte">Carte à vérifier</param>
        /// <returns>Vrai, si un Bingo existe sur cette carte</returns>
        public bool BingoExisteSurLaCarte(VisualIntArray pCarte)
        {
            // À COMPLÉTER...
            //rangée
            //rangée
            for (int i = 0; i < 5; i++)
            {
                if (SuiteGaganteSurLaCarte(pCarte, i, 0, i, 4))
                {
                    return true;
                }
            }

            //colone
            for (int i = 0; i < 5; i++)
            {
                
                if (SuiteGaganteSurLaCarte(pCarte, 0, i, 4, i))
                {
                return true;
                }
            }
            //diagonale
            if (SuiteGaganteSurLaCarte(pCarte, 0, 0, 4, 4) || SuiteGaganteSurLaCarte(pCarte, 4, 0, 0, 4))
            {
                return true;
            }
            





            return false;
        }
        #endregion

        #region btnRetirerUneBouleDuBoulier_Click (TODO 07)
        /// <summary>
        /// S'exécute lorsque l'utilisateur retire une boule du boulier
        /// Méthodes à appeler : ColonneDeLaBouleSurLaCarte, TraiterLaBouleRetirée
        /// </summary>
        public void btnRetirerUneBouleDuBoulier_Click(object sender, EventArgs e)
        {
            // TODO 07 (20 pts) Retirer une boule du boulier
            // Récupérer un numéro de boule du boulier, en utilisant vsiNbBoulesRetirées.Value 
            // comme index dans viaBoulier et augmenter le nombre de boules retirées.
            // Désactiver la boule retirée dans le boulier
            // Déterminer la rangée ainsi que la colonne de la boule retirée sur la carte maîtresse
            // afin de la désactiver. Appeler la méthode ColonneDeLaBouleSurLaCarte
 
            int index = vsiNbBoulesRetirées.Value;
            int boule = viaBoulier[index];
            viaBoulier.DisableCell(index);
            vsiBoule.Value = boule;
            vsiNbBoulesRetirées.Value++;

            viaCarteMaîtresse.DisableCell(RangéeDeLaBouleSurLaCarte(viaCarteMaîtresse,boule), ColonneDeLaBouleSurLaCarte(boule));
            // Afficher la boule retirée ainsi que sa lettre correspondante (voir démo)
            vscBoule.Value = NOM_JEU[ColonneDeLaBouleSurLaCarte(boule)];
            // Compléter le TODO 08 et ajouter ensuite les appels à TraiterLaBouleRetirée pour chacune des cartes.
            TraiterLaBouleRetirée(viaCarte1, boule);
            TraiterLaBouleRetirée(viaCarte2, boule);
            TraiterLaBouleRetirée(viaCarte3, boule);
            TraiterLaBouleRetirée(viaCarte4, boule);
        }
        #endregion

        #region SuiteGaganteSurLaCarte (NE PAS MODIFIER)
        /// <summary>
        /// Permet de déterminer si une suite gagnante existe sur une carte en tenant compte des coordonnées
        /// passées en paramètres.
        /// </summary>
        /// <param name="pCarte">Carte à vérifier</param>
        /// <param name="pRangéeDébut">Rangée de la position de départ</param>
        /// <param name="pColonneDébut">Colonne de la position de départ</param>
        /// <param name="pRangéeFin">Rangée de la position de fin</param>
        /// <param name="pColonneFin">Colonne de la position de fin</param>
        /// <returns>Vrai, si une suite gagnante existe sur la carte</returns>
        private bool SuiteGaganteSurLaCarte(VisualIntArray pCarte, int pRangéeDébut, int pColonneDébut, int pRangéeFin, int pColonneFin)
        {
            #region NE PAS MODIFIER
            int rangée = pRangéeDébut;
            int colonne = pColonneDébut;

            int dplRangée, dplColonne;

            if (pRangéeFin > pRangéeDébut)
            {
                dplRangée = (pRangéeFin - pRangéeDébut + 1) / pCarte.RowCount;
            }
            else
            {
                dplRangée = -(pRangéeDébut - pRangéeFin + 1) / pCarte.RowCount;
            }

            if (pColonneFin > pColonneDébut)
            {
                dplColonne = (pColonneFin - pColonneDébut + 1) / pCarte.ColumnCount;
            }
            else
            {
                dplColonne = -(pColonneDébut - pColonneFin + 1) / pCarte.ColumnCount;
            }
                

            for (int position = 0; position < TAILLE_CARTE; position++)
            {
                if ((rangée != RANGÉE_MILIEU || colonne != COLONNE_MILIEU) && pCarte.GetCellEnabled(rangée, colonne))
                {
                    return false;
                }
                rangée += dplRangée;
                colonne += dplColonne;
            }

            SegmentSprite spriteSegment = (SegmentSprite)pCarte.Sprites[0];
            spriteSegment.RelocateAt(pRangéeDébut, pColonneDébut, pRangéeFin, pColonneFin);
            spriteSegment.Visible = true;
            return true;
            #endregion
        }
        #endregion

        private void viaCarte1_Click(object sender, EventArgs e)
        {

        }
    }
}
