using Librairie1N6;
using System.Windows.Forms;

namespace ApplicationMontre
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";

        // TODO 01 : Définir une variable privée pour un objet Montre appelée m_objMontre


        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            // TODO 02A : Instancier une Montre à 10 heures, 45 minutes et 52 secondes
           

            // TODO 02B : Afficher le temps courant de la Montre
          
        }
        //============================================================================
        private void mnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        //============================================================================
        private void MnuSpcialAvancerDuneSeconde_Click(object sender, System.EventArgs e)
        {
            // TODO 03A : Avancer le temps de la Montre d'une seconde
           
            // TODO 03B : Afficher le temps courant de la Montre
           
        }
        //============================================================================
        private void MnuSpécialSynchroniser_Click(object sender, System.EventArgs e)
        {
            // TODO 04A : Synchroniser le temps de la Montre à l'aide de la méthode AjusterAutomatiquement
           
            // TODO 04B : Afficher le temps courant de la Montre
            
        }
        //============================================================================
        private void MnuSpécialDémarrer_Click(object sender, System.EventArgs e)
        {
            // TODO 05 : Modifier le texte du menu mnuSpécialDémarrer pour indiquer 
            //           "Démarrer" ou "Arrêter"
            //         : Démarrer ou arrêter le minuteur de l'horloge (tmrHorloge) en conséquence
            
           
        }
        //============================================================================
        private void MnuSpécialFixer_Click(object sender, System.EventArgs e)
        {
            // TODO 06A : Modifier les propriétés appropriées 
           
            // TODO 06B : Afficher le temps courant de la Montre 
           
        }
    }
}
