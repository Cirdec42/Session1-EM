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
    public partial class FrmQ2 : Form
    {
        /// <summary>
        /// Description: Grille de base avec 1 Sprite.
        /// </summary>
        //------------------------------------------------------------------------------------------

        public const string APP_INFO = " (Matériel)";
         
        #region Constructeur - NE PAS MODIFIER
        public FrmQ2()
        {
            InitializeComponent();
            this.Text += APP_INFO;
        }
        #endregion

        //==========================================================================================
        private void btnAvancerSprite_Click(object sender, EventArgs e)
        {
            // TODO 01 : Avancer le Sprite selon la valeur de la zone numérique vsiDéplacement
            // Faire fonctionner votre solution avec un déplacement de 1
            if (sprJoueur.DisplayIndex == 9)
            {
                sprJoueur.DisplayIndex = 0-1 + vsiDéplacement.Value;
            }
            else if (sprJoueur.DisplayIndex + vsiDéplacement.Value > 9)
            {
                sprJoueur.DisplayIndex = 0-1 - sprJoueur.DisplayIndex + vsiDéplacement.Value;
            }
            else
            {
                sprJoueur.DisplayIndex = sprJoueur.DisplayIndex + vsiDéplacement.Value;
            }









        }

        //==========================================================================================
        private void btnReculerSprite_Click(object sender, EventArgs e)
        {
            // TODO 02 : Reculer le Sprite selon la valeur de la zone numérique vsiDéplacement
            // Faire fonctionner votre solution avec un déplacement de 1
            if (sprJoueur.DisplayIndex==0)
            {
                sprJoueur.DisplayIndex = 10 - vsiDéplacement.Value;
            }
            else if (sprJoueur.DisplayIndex - vsiDéplacement.Value <0)
            {
                sprJoueur.DisplayIndex = 10 + sprJoueur.DisplayIndex - vsiDéplacement.Value;
            }
            else
            {
                sprJoueur.DisplayIndex = sprJoueur.DisplayIndex - vsiDéplacement.Value;
            }








        }

        private void bvaGrille_Click(object sender, EventArgs e)
        {

        }
    }
}
