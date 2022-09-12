using System;
using System.Windows.Forms;

namespace TP2_Serpents
{
    /// <summary>
    /// Description : Jeu de serpents et échelles à un joueur.
    /// 
    /// Version     : 2020
    /// </summary>
    /// --------------------------------------------------------------------------------

    public partial class FrmPrincipal : Form
    {
        #region NE PAS MODIFIER
        public const string APP_INFO = " (Matériel)";
        //------------------------------------------------------------------------------
        public FrmPrincipal()
        {
            InitializeComponent();
            btnLancerDe.Select();
            this.Text += APP_INFO;
            DémarrerNouvellePartie();
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Créer une nouvelle partie
        /// </summary>
        private void mnuFichierNouvellePartie_Click(object sender, EventArgs e)
        {
            DémarrerNouvellePartie();
        }
        //-----------------------------------------------------------------------------------
        /// <summary>
        /// Établir la valeur du déplacement
        /// Mettre à jour les contrôles appropriés selon le contexte du jeu.
        /// </summary>
        private void btnLancerDé_Click(object sender, EventArgs e)
        {
            // Établir la valeur du déplacement
            vsiDé.RandomizeValue(1, 6);

            // Rendre disponible ou non les contrôles appropriés selon le contexte du jeu.
            btnLancerDe.Enabled = false;
            btnDéplacerJeton.Enabled = true;

            // Activer le bon contrôle.
            btnDéplacerJeton.Select();
        }
        #endregion

        //------------------------------------------------------------------------------------
        /// <summary>
        /// Déplacer le jeton du joueur
        /// Vérifier si fin de la partie
        /// Mettre à jour les contrôles appropriés selon le contexte du jeu.
        /// </summary>
        private void btnDéplacerJeton_Click(object sender, EventArgs e)
        {
            //--------------------------------------------------------------------------------
            // TODO 01A : Rendre non disponible le bouton pour déplacer le jeton
            btnDéplacerJeton.Enabled = false;
            // TODO 01B : Rendre disponible le bouton pour lancer le dé
            btnLancerDe.Enabled = true;
            // TODO 01C : Placer le focus sur le bouton pour lancer le dé
            btnLancerDe.Focus();

            // -------------------------------------------------------------------------------
            // TODO 01D : Déplacer le jeton du joueur selon la valeur du dé
            sprJoueur.DisplayIndex = sprJoueur.DisplayIndex + vsiDé.Value;
            //      Déterminer la position future et si elle est jouable.
            //      Déplacer le jeton à cette position
            //      Déterminer si un deuxième déplacement est nécessaire et l'effectuer
           
            switch (sprJoueur.DisplayIndex)
            {
                //Case Serpent
                case 18:
                    sprJoueur.FollowGrid = false;
                    sprJoueur.DisplayIndex = 4;
                    sprJoueur.FollowGrid = true;
                    break;
                case 26:
                    sprJoueur.FollowGrid = false;
                    sprJoueur.DisplayIndex = 7;
                    sprJoueur.FollowGrid = true;
                    break;
                case 57:
                    sprJoueur.FollowGrid = false;
                    sprJoueur.DisplayIndex = 40;
                    sprJoueur.FollowGrid = true;
                    break;
                case 61:
                    sprJoueur.FollowGrid = false;
                    sprJoueur.DisplayIndex = 31;
                    sprJoueur.FollowGrid= true;
                    break;

                //Case echelle
                case 2:
                    sprJoueur.FollowGrid = false;
                    sprJoueur.DisplayIndex = 17;
                    sprJoueur.FollowGrid = true;
                    break;
                case 28:
                    sprJoueur.FollowGrid = false;
                    sprJoueur.DisplayIndex = 52;
                    sprJoueur.FollowGrid = true;
                    break;
                case 23:
                    sprJoueur.FollowGrid = false;
                    sprJoueur.DisplayIndex = 38;
                    sprJoueur.FollowGrid = true;
                    break;
                case 47:
                    sprJoueur.FollowGrid = false;
                    sprJoueur.DisplayIndex = 61;
                    sprJoueur.FollowGrid = true;
                    break;

                //Soleil
                case 15:
                case 58:
                    sprJoueur.Animated = false;
                    sprJoueur.DisplayIndex = 63;
                    sprJoueur.Animated = true;
                    break;

                //Serpents enroullés
                case 42:
                case 51:
                    sprJoueur.Animated = false;
                    sprJoueur.DisplayIndex = 0;
                    sprJoueur.Animated = true;
                    break;

                    
                default:
                    break;
            }


            // -------------------------------------------------------------------------------
            // TODO 01E : Arréter la partie
            //      Vérifier si on atteint le sommet
            //      Si le sommet est atteint, mettre à jour les contrôles pour arrêter la partie 
            if (sprJoueur.DisplayIndex == 63)
            {
                sprFinPartie.Visible = true;
                btnDéplacerJeton.Enabled = false;
                btnLancerDe.Enabled = false;
            }

        }
        //----------------------------------------------------------------------------------
        /// <summary>
        /// Préparer le jeu pour une nouvelle partie
        /// Mettre à jour les contrôles appropriés selon le contexte du jeu.
        /// </summary>
        private void DémarrerNouvellePartie()
        {
            // TODO 02A : Préparer l'état du formulaire pour une nouvelle partie.
            sprJoueur.Animated = false;
            sprJoueur.DisplayIndex = 0;
            sprJoueur.Animated = true;
            sprJoueur.FollowGrid = true;
            btnLancerDe.Enabled = true;



            // TODO 02B : Rendre disponible ou non les contrôles appropriés selon le contexte du jeu.



            #region NE PAS MODIFIER
            btnLancerDe.Select();
            mnuSpécialModeTest.Checked = false;
            vsiDé.ReadOnly = true;
            #endregion
        }

        #region NE PAS MODIFIER
        //-----------------------------------------------------------------------------------------------
        private void MnuSpécialModeTest_Click(object sender, EventArgs e)
        {
            vsiDé.ReadOnly = !mnuSpécialModeTest.Checked || sprFinPartie.Visible;
        }
        //-----------------------------------------------------------------------------------------------
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void bvaGrille_Click(object sender, EventArgs e)
        {

        }
    }
}

