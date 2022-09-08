using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VisualArrays;

namespace ExemGrilleEtSprite
{
    public partial class FrmPrincipal : Form
    {
        /// <summary>
        /// Description: Démonstration de la grille de base avec 1 Sprite.
        /// Concepts:    Utilisation de la grille de base.
        ///                     Notion d'index (position dans la grille)
        ///                     Notion de Sprite et de possitionnement avec la propriété DisplayIndex
        ///                     Obtenir le nombre de cellules dans la grille avec la propriété Length
        ///              Sélection simple.
        ///              Événement ValueChanged
        /// </summary>
        //------------------------------------------------------------------------------------------

        //TODO 0: Écrire votre nom prénom entre les guillemets
        public const String APP_INFO = " (DÉMO)";
         
        #region Constructeur - NE PAS MODIFIER
        public FrmPrincipal()
        {
            InitializeComponent();
            this.Text += APP_INFO;
        }
        #endregion

        //==========================================================================================
        private void btnIndexSuivant_Click(object sender, EventArgs e)
        {
            // TODO 01 : Déplacer le Sprite à l'index suivant. Si le Sprite est au dernier index, le placer à l'index 0.
            switch (sprJoueur.DisplayIndex)
            {
                case 19:
                    sprJoueur.DisplayIndex = 0;
                    break;
                default:
                    sprJoueur.DisplayIndex++;
                    break;
            }

            // TODO 02 : Afficher la position du sprite
            vsiPosition.Value = sprJoueur.DisplayIndex;
        }

        //==========================================================================================
        private void btnIndexPrecedent_Click(object sender, EventArgs e)
        {
            // TODO 03 : Déplacer le Sprite à l'index précédent.
            // Si le Sprite est au premier index, le placer à la fin de la grille.
            switch (sprJoueur.DisplayIndex)
            {
                case 0:
                    sprJoueur.DisplayIndex = 19;
                    break;
                default:
                    sprJoueur.DisplayIndex--;
                    break;
            }


            // TODO 04 : Afficher la position du sprite
            vsiPosition.Value = sprJoueur.DisplayIndex;
        }
        //==========================================================================================
        private void vsiPosition_ValueChanged(object sender, EventArgs e)
        {
            // TODO 05 : Déplacer le sprite à la position indiquée par le contrôle vsiPosition
            sprJoueur.DisplayIndex = vsiPosition.Value;
        }
        //==========================================================================================
        private void vsbSpriteEstVisible_ValueChanged(object sender, EventArgs e)
        {
            // TODO 06 : Appliquer le changement de visibilité au sprite
            sprJoueur.Visible = vsbSpriteEstVisible.Value;
        }
    }
}
