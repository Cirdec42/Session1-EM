using System;
using System.Windows.Forms;
using Librairie1N6;

namespace InstancierUnDC
{
    public partial class FrmEx1UnDC : Form
    {
        ///----------------------------------------------------------------------
        /// <summary>
        /// Description : Instancier un objet de la classe DisqueCompact.
        /// </summary>
        //-----------------------------------------------------------------------
        public const string APP_INFO = "(Matériel)";

        #region NE PAS MODIFIER
        public FrmEx1UnDC()
        {
            InitializeComponent();
            Text += APP_INFO;

        }
        private void MnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion 

        //  ------------------------------------------------------------------------------------------
        private void btnInstancierUnDC_Click(object sender, EventArgs e)
        {
            // TODO 1A : Déclarer et Instancier un objet disque compact avec le constructeur sans paramètre.
            // À compléter
           DisqueCompact objDisque = new DisqueCompact();


            // TODO 1B : Afficher les informations sur le disque instancié dans les zones de texte appropriées:
            //           le nombre de pistes, la durée totale en secondes, la durée totale en MM:SS et le genre de musique.
            //           Pour obtenir la durée totale dans un format MM:SS utiliser la méthode statique FormatMMSS() de la classe DisqueCompact
            //  ATTENTION une méthode statique est appellée à partir de la classe et non à partir de l'objet (Comme une constante qui est statique)
            // À compléter
            txtNbPistes.Text = objDisque.Pistes.Length.ToString();
            txtDureeTotaleSecondes.Text = objDisque.Durée.ToString();
            txtDureeTotaleMMSS.Text = DisqueCompact.FormatMMSS(objDisque.Durée);
            txtGenre.Text = objDisque.Genre.ToString();



		   
		   
        }

        private void txtNbPistes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}