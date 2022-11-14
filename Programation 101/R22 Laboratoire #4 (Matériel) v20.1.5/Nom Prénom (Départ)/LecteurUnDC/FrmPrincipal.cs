using System.Windows.Forms;
using Librairie1N6;

namespace LecteurUnDC
{
    /// <summary>
    /// Instanciation et manipulation d'un objet de la classe DisqueCompact
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFOS = "(Daigneault et Cédric)";

        #region Variables membres

        // TODO 01 : Déclarer et initialiser à null une variable membre m_objDisqueCourant pour le disque courant.
        //           Déclarer et initialiser à -1 une variable membre m_indexPisteCourante pour l'index de la piste courante.
        DisqueCompact m_objDisqueCourant = null;
        DisqueCompact m_indexPisteCourante;
        //À compléter


        #endregion

        //---------------------------------------------------------------------------------
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFOS;

            // Initialiser l'application.
            MettreAJourSelonContexte();

            // Mettre vos tests ici
            InitialiserAffichageDuLecteur();
            // À compléter
            

        }

        #region InitialiserAffichageDuLecteur
        private void InitialiserAffichageDuLecteur()
        {
            // TODO 02: Remettre à "00:00" la durée totale en MMSS et le temps restant
            txtDureeTotaleMMSS.Text = "00:00";
            txtTempsRestant.Text = "00:00";
            //          Remettre à "00/00" la piste courante  et à "????" le genre de musique
            txtPisteCourante.Text = "00/00";
            txtGenre.Text = "????";
            // Pour tester: Faites un appel de cette méthode dans le constructeur du formulaire FrmPrincipal
            //              et enlevez cet appel après le test.
            //    ATTENTION: enlevez les commentaires sur la première ligne de code de MettreAJourSelonContexte()
			
            //À compléter

        }
        #endregion


        #region Événements du menu pour allumer ou éteindre le lecteur

        /// -------------------------------------------------------------------------------
        private void mnuEditionAllumerEteindre_Click(object sender, System.EventArgs e)
        {
            // TODO 03: Changer la valeur de la propriété Checked de l'objet chkPower
            chkPower.Checked = true;
            if (chkPower.Checked == true)
            {
                mnuEditionAllumerEteindre.Text = "Éteindre le lecteur";
            }
            else
            {
                mnuEditionAllumerEteindre.Text = "Allumer le lecteur";
            }
            //         ( Remarquez que cette instruction déclenche l'évènement chkPower_CheckedChanged qui fera des appels)
            //    ATTENTION: 
            //         Dans MettreAJourSelonContexte, changez également le texte du mnuEditionAllumerEteindre de façon appropriée

            //À compléter

        }
        #endregion

        #region InsererUnDisque
        /// -----------------------------------------------------------------------------
        /// <summary>
        ///		Insère un disque d'une certaine sorte.
        /// </summary>
        /// <param name="pSorteDeDisque">La sorte de disque, un disque normal ou de test.</param>
        /// ------------------------------------------------------------------------------
        private void InsererUnDisque(SorteDeDisque pSorteDeDisque)
        {
            // TODO 04: Instanciez un nouveau disque de la sorte pSorteDeDisque, 
            //   initialisez la piste courant à 0
            m_objDisqueCourant = new DisqueCompact(pSorteDeDisque) ;
            //   puis appelez la méthode AfficherInfosDisqueCourant 
            AfficherInfosDisqueCourant();
            //             et la méthode MettreAJourSelonContexte
            MettreAJourSelonContexte();
 
            //    ATTENTION: on ne peut encore rien tester à cette étape
            //À compléter


        }
        #endregion 

        #region AfficherInfosDisqueCourant
        /// -------------------------------------------------------------------------------
        /// <summary>
        ///		Affiche les informations du disque courant soit :
        ///		la durée totale, la piste courante, le temps restant et le genre de musique.
        /// </summary>
        /// -------------------------------------------------------------------------------
        private void AfficherInfosDisqueCourant()
        {
            // TODO 05: Afficher les infos du disque courant
            //       Vérifiez s'il y a un disque dans le lecteur
            //           Si oui,  
            if (true)
            {

            }
            //             -	Affichez la durée totale en minutes et secondes
            txtDureeTotaleMMSS.Text = m_objDisqueCourant.Durée.ToString("0000");
            //             -    Affichez la piste courante
            txtPisteCourante.Text = m_objDisqueCourant.Pistes.ToString();
			//  ATTENTION, pour afficher un nombre avec deux chiffres, utilisez .ToString("00")  au lieu de .ToString()
 			//
            //             -    Appelez la méthode TempsRestant et affichez le temps restant en minutes et secondes
            //           Si non,
            //             -	Appelez la méthode InitialiserAffichageDuLecteur

            //   IMPORTANT POUR TESTER, enlevez InitialiserAffichageDuLecteur() du contructeur FrmPrincipal
            //             Et faites l'appel de la méthode InsererUnDisque(SorteDeDisque.Test1)
            //             Remarquez qu'on peut voir les infos du disque 
            //             et qu'un disque est inséré dans le lecteur
			
            //À compléter

        }

        #endregion

        #region TempsRestant
        /// -------------------------------------------------------------------------------
        /// <summary>
        /// Calcul le temps restant d'un disque en considérant la piste courante
        /// </summary>
        /// <returns>Temps restant à jouer</returns>
        private int TempsRestant()
        {
            // TODO 06: Calculez le temps restant 
            //               en accumulant, à partir de la piste courante, les secondes des pistes
            //               qui restent
            //          (Pistes de DisqueCompact est indexé comme un tableau,
            //                avec chaque valeur étant la durée en secondes de chaque piste du disque)
            //  
            //  N'oubliez pas de retourner le résultat à la fin de cette méthode
            //
            //  POUR TESTER:  réexécuter simplement

            //À compléter


            return 0;  
        }
        #endregion

        #region Événements des menus pour insérer un disque
        /// -------------------------------------------------------------------------------
        private void mnuEditionInsererDisqueNormal_Click(object sender, System.EventArgs e)
        {
            // TODO 07A: Appel de la méthode InsererUnDisque avec la SorteDeDisque Normal
            //    ATTENTION: Enlever les deux appels qu'on avait mis dans le constructeur FrmPrincipal()

            //À compléter
        }

        /// -------------------------------------------------------------------------------
        private void mnuEditionInsererDisqueTest1_Click(object sender, System.EventArgs e)
        {
            // TODO 07B: Appel de la méthode InsererUnDisque avec la SorteDeDisque Test1

            //À compléter
        }

        /// -------------------------------------------------------------------------------
        private void mnuEditionInsererDisqueTest2_Click(object sender, System.EventArgs e)
        {
            // TODO 07C: Appel de la méthode InsererUnDisque avec la SorteDeDisque Test2

            //À compléter
        }

        /// -------------------------------------------------------------------------------
        private void mnuEditionInsererDisqueTest3_Click(object sender, System.EventArgs e)
        {
            // TODO 07D: Appel de la méthode InsererUnDisque avec la SorteDeDisque Test3

            //À compléter
        }

        #endregion

        #region MettreAJourSelonContexte avec les boutons pistes suivantes et pistes précédentes

        /// -------------------------------------------------------------------------------
        private void btnPisteSuivante_Click(object sender, System.EventArgs e)
        {
            // TODO 08:   Bouton pour voir la piste suivante
            //     faites les 3 étapes suivantes:
            //           1. Avancez à la piste suivante
            //           2. Si vous êtes rendus à la fin du disque courant, revenez à la piste du début
            //           3. Appelez la méthode AfficherInfosDisqueCourant pour que l'affichage s'ajuste

            //À compléter

        }

        /// -------------------------------------------------------------------------------
        /// <summary>
        ///		Met à jour les contrôles du lecteur s'il est éteint ou non
        ///		et s'il y a un disque ou non.
        /// </summary>
        /// -------------------------------------------------------------------------------
        private void MettreAJourSelonContexte()
        {
            panInfos.Visible = chkPower.Checked;  //Enlever le commentaire comme spécifié dans le todo 02 
            //panDisque.Visible = chkPower.Checked && m_objDisqueCourant != null; //Enlever le commentaire comme spécifié dans le todo 05 

            //   Suite du TODO 3
           // --- Menu Édition ------------------------------------------------------------ 			
			// À compléter
			
			
			
			
			
         
            //TODO 09:    Mettre à jour les menus et les boutons selon le contexte
            //      Faites les étapes suivantes:
            //           1. Créez une variable bool qui vérifiera que le disque est allumé et s'il y a un disque dans le lecteur
            //              (la valeur de la propriété Checked de chkPower et que le disque courant n'est pas null)
            //           2. Utilisez cette variable pour activer ou non les objets suivants:
            //              btnPisteSuivante et  mnuEditionPistePrecedente,
            //              btnPistePrecedente et  mnuEditionPisteSuivante,
            //              mnuEditionEjecter   
            //           
            //  

            // À compléter


        }

        /// -------------------------------------------------------------------------------
        private void btnPistePrecedente_Click(object sender, System.EventArgs e)
        {
            // TODO 10:   Bouton pour voir la piste précédente
            //      faites les 3 étapes suivantes:
            //           1. Reculez à la piste suivante
            //           2. Si vous êtes rendus au début du disque courant, revenez à la piste de la fin
            //           3. Appelez la méthode AfficherInfosDisqueCourant pour que l'affichage s'ajuste

            //À compléter

        }
        #endregion

        #region Événements du menu pour éjecter un disque
        /// -------------------------------------------------------------------------------
        private void mnuEditionEjecter_Click(object sender, System.EventArgs e)
        {
            // TODO 11:  Éjecter un disque du lecteur
            //     Faites les étapes suivantes:
            //          On met l’index de la piste courante à -1
            //          et le disque courant à null 
            //          Appellez les méthodes AfficherInfosDisqueCourant et MettreAJourSelonContexte

            //À compléter



         
        }
        #endregion

        



        #region NE PAS MODIFIER

        /// -------------------------------------------------------------------------------
        private void chkPower_CheckedChanged(object sender, System.EventArgs e)
        {
            AfficherInfosDisqueCourant();  // Ne pas modifier
            MettreAJourSelonContexte();    // Ne pas modifier
        }
       

        /// -----------------------------------------------------------------------
        private void MnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #endregion

        private void FrmPrincipal_Load(object sender, System.EventArgs e)
        {

        }
    }
}