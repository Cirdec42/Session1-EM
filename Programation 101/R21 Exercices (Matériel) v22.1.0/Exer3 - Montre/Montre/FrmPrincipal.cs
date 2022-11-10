using Librairie1N6;
using System.Windows.Forms;

namespace ApplicationMontre
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";

        // TODO 01 : Définir une variable privée pour un objet Montre appelée m_objMontre
        Montre x = new Montre();

        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            // TODO 02A : Instancier une Montre à 10 heures, 45 minutes et 52 secondes
            x.Heures = 10;
            x.Minutes = 45;
            x.Secondes = 52;

            // TODO 02B : Afficher le temps courant de la Montre
            lblTemps.Text = x.TempsCourant;
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
            x.AvancerUneSeconde();
            // TODO 03B : Afficher le temps courant de la Montre
            lblTemps.Text = x.TempsCourant;
        }
        //============================================================================
        private void MnuSpécialSynchroniser_Click(object sender, System.EventArgs e)
        {
            // TODO 04A : Synchroniser le temps de la Montre à l'aide de la méthode AjusterAutomatiquement
            x.AjusterAutomatiquement();
            // TODO 04B : Afficher le temps courant de la Montre
            lblTemps.Text = x.TempsCourant;
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
            x.Heures = 20;
            x.Minutes = 45;
            x.Secondes = 55;
            // TODO 06B : Afficher le temps courant de la Montre 
            lblTemps.Text = x.TempsCourant;
        }

        private void FrmPrincipal_Load(object sender, System.EventArgs e)
        {

        }
    }
}
