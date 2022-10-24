using System;
using System.Windows.Forms;

namespace MethodeAvecRetour
{
    /// <summary>
    /// Application pour illustrer l'appel d'une méthode pré-définie qui produit un résultat
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        const string NOM_PRENOM = "(Matériel)";

        #region NE PAS MODIFIER
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += NOM_PRENOM;

        }
        private void MnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Classe Math, appel de méthodes qui retournent un résultat
        //-------------------------------------------------------------------------------
        private void BtnMathAbs_Click(object sender, EventArgs e)
        {
            // TODO 01 : Placer la valeur arrondie de numNombre.Value dans numResultat.Value
            numResultat.Value = Math.Round(numNombre.Value);

        }
        //-------------------------------------------------------------------------------
        private void BtnMathFloor_Click(object sender, EventArgs e)
        {
            // TODO 02 : Placer le plus grand entier inférieur ou égal à numNombre.Value dans numResultat.Value.
            numResultat.Value = Math.Floor(numNombre.Value);

        }
        //-------------------------------------------------------------------------------
        private void BtnMathCeiling_Click(object sender, EventArgs e)
        {
            // TODO 03 : Placer la plus petite valeur intégrale qui est supérieure ou égale au nombre numNombre.Value dans numResultat.Value.
            numResultat.Value = Math.Ceiling(numNombre.Value);

        }
        #endregion

        #region Quelques méthodes de la classe String
        //-------------------------------------------------------------------------------
        private void BtnToUpper_Click(object sender, EventArgs e)
        {
            // TODO 04 : Placer une version majuscule de la chaine txtTexte dans txtResultat
            txtResultat.Text = txtTexte.Text.ToUpper();

        }
        private void BtnToLower_Click(object sender, EventArgs e)
        {
            // TODO 05 : Placer une version minuscule de la chaine txtTexte dans txtResultat
            txtResultat.Text = txtTexte.Text.ToLower();
        }

        #endregion
    }
}
