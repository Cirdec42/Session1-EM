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
     
  








        }

        //==========================================================================================
        private void btnReculerSprite_Click(object sender, EventArgs e)
        {
            // TODO 02 : Reculer le Sprite selon la valeur de la zone numérique vsiDéplacement
            // Faire fonctionner votre solution avec un déplacement de 1
     








        }
    }
}
