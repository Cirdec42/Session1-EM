using System;
using System.Drawing;
using System.Windows.Forms;

namespace RochePapierCiseaux
{
    /// =============================================================================================
    /// <summary>
    /// Description :   Simuler le jeu de roche-papier-ciseaux
    /// Concepts           
    ///         Type de données  : https://sites.google.com/site/notionscsharpcem/type (bool et int)
    ///         Constante        : https://sites.google.com/site/notionscsharpcem/constantes
    ///         Assignation      : https://sites.google.com/site/notionscsharpcem/assignation
    ///         Opérateurs       : https://sites.google.com/site/notionscsharpcem/operateurs/logiques
    ///         Sélection (if)   : https://sites.google.com/site/notionscsharpcem/structure/if
    /// VisualArrays
    ///         VisualInt        : https://sites.google.com/site/notionscsharpcem/visualarrays-llibrairie/visualint
    ///         VisualBool       : https://sites.google.com/site/notionscsharpcem/gui---visualarrays/visualcells/visualbool
    ///                   
    /// Description   :   Chaque joueur est représenté par un controle VisualInt.
    ///                   Dans les VisualInt des joueurs, une image est affichée.
    ///                         Soit une main ciseau, une main fermée ou une main roche.
    ///                         Chaque image est associée à un entier :
    ///                         0 pour la roche / 1 pour le papier / 2 pour les ciseaux.
    ///                      
    ///                          Règles du jeu :
    ///                         La roche bat le ciseau, Le ciseau bat le papier, Le papier bat la roche.
    ///                         
    ///                 Consulter la version démo pour plus de détails sur le fonctionnement du programme à réaliser
    ///                         
    /// </summary>
    /// =============================================================================================

    public partial class FrmPrincipal : Form
    {
        #region Constantes à utiliser
        const int ROCHE = 0;
        const int PAPIER = 1;
        const int CISEAUX = 2;
        #endregion

        #region Constructeur du formulaire (NE PAS MODIFIER)
        public const string APP_INFO = " (Matériel)";
        // ------------------------------------------------------------------------------------------
        public FrmPrincipal()
        {
            InitializeComponent();
            this.Text += APP_INFO;
        }
        #endregion

        // ------------------------------------------------------------------------------------------
        private void btnJouer_Click(object sender, EventArgs e)
        {
            // TODO 1 : compléter ce gestionnaire d'événement
            if (vsiChoixJoueur1.Value > vsiChoixJoueur2.Value)
            {
                vsiNbConfGagnéesJoueur1.Value++;
                vsiNbConfPourCettePartie.Value++;
                vsiChoixJoueur1.BackColor = Color.Green;
                vsiChoixJoueur2.BackColor = Color.Red; 

            }
            else if (vsiChoixJoueur1.Value < vsiChoixJoueur2.Value)
            {
                vsiNbConfGagnéesJoueur2.Value++;
                vsiNbConfPourCettePartie.Value++;
                vsiChoixJoueur2.BackColor = Color.Green;
                vsiChoixJoueur1.BackColor = Color.Red;
            }
            else if (vsiChoixJoueur1.Value == vsiChoixJoueur2.Value)
            {
                vsiNbConfrontationsNulles.Value++;
                vsiNbConfPourCettePartie.Value++;
            }
            else{}

            if (vsiNbConfPourCettePartie.Value == vsiNbConfPourCettePartie.Maximum)
            {
                vsiChoixJoueur1.Enabled = false;
                vsiChoixJoueur2.Enabled = false;
                btnJouer.Enabled = false;
                vsiChoixJoueur1.BackColor = Color.Gray;
                vsiChoixJoueur2.BackColor = Color.Gray;
            }
            else{}

            if (vsiNbConfPourCettePartie.Value == vsiNbConfPourCettePartie.Maximum && vsiNbConfGagnéesJoueur1.Value > vsiNbConfGagnéesJoueur2.Value)
            {
                vsbLumièreJoueur1.Value = true;
                vsbLumièreJoueur2.Value = false;
                vsiNbPartiesGagnéesJoueur1.Value++;
            }
            else if (vsiNbConfPourCettePartie.Value == vsiNbConfPourCettePartie.Maximum && vsiNbConfGagnéesJoueur1.Value < vsiNbConfGagnéesJoueur2.Value)
            {
                vsbLumièreJoueur1.Value = false;
                vsbLumièreJoueur2.Value = true;
                vsiNbPartiesGagnéesJoueur2.Value++;
            }


            #region Gestion du mode test (NE PAS MODIFIER)
            if (!mnuSpecialModeTest.Checked)
            {
                vsiChoixJoueur1.RandomizeValue();
                vsiChoixJoueur2.RandomizeValue();
            }
            #endregion

            // À COMPLÉTER ICI...

        }
        private void mnuFichierNouvellePartie_Click(object sender, EventArgs e)
        {
            // TODO 2 : compléter ce gestionnaire d'événement
            btnJouer.Enabled = true;
            vsiNbConfGagnéesJoueur1.Value = 0;
            vsiNbConfGagnéesJoueur2.Value = 0;
            vsiNbConfPourCettePartie.Value = 0;
            vsiNbConfrontationsNulles.Value = 0;
            vsbLumièreJoueur1.Value = false;
            vsbLumièreJoueur2.Value=false;
            vsiChoixJoueur1.BackColor = DefaultBackColor;
            vsiChoixJoueur2.BackColor = DefaultBackColor;   

            // À COMPLÉTER ICI...

        }

        #region Gestion des options des menus (NE PAS MODIFIER)

        // ---------------------------------------------------------------------------------
        private void mnuAideCommentJouer_Click(object sender, EventArgs e)
        {
            string message = "Cliquez sur le bouton Jouer pour attribuer à chaque joueur soit une roche, un papier ou un ciseau";
            message += "et trouver le joueur gagnant de la confrontation!\n\n";
            message += "Règles du jeu : 1 point par confrontation gagnée. ";
            message += "\n      La roche bat le ciseau. \n      Le ciseau bat le papier. \n      Le papier bat la roche.";
            message += "\nLe gagnant d'une partie est celui qui a le plus de confrontations gagnées.";
            message += "\n\nChaque partie peut avoir au maximum 10 confrontations.";
            MessageBox.Show(message, Text);
        }

        // ---------------------------------------------------------------------------------
        private void mnuSpecialModeTest_Click(object sender, EventArgs e)
        {
            vsiChoixJoueur1.ReadOnly = !mnuSpecialModeTest.Checked;
            vsiChoixJoueur2.ReadOnly = !mnuSpecialModeTest.Checked;
        }

        // ---------------------------------------------------------------------------------
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

    }
}
