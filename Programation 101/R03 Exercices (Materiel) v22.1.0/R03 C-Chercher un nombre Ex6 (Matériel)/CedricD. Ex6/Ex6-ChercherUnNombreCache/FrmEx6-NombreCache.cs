using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VisualArrays;

namespace ChercherUnNombreCache
{
    public partial class FrmEx6ChercherUnNombreCache : Form
    {
        /// =============================================================================================
        /// <summary>
        /// Description :   Exercices d'apprentissage - Chapitre 2 : Structures de sélection. A- ifs simples
        /// Concepts    :       
        ///                 Type de données  : https://sites.google.com/site/notionscsharpcem/type
        ///                 Sélection (if)   : https://sites.google.com/site/notionscsharpcem/structure/if
        ///                 VisualCells      : https://sites.google.com/site/notionscsharpcem/visualarrays-llibrairie/visualcells
        ///                 VisualInt        : https://sites.google.com/site/notionscsharpcem/visualarrays-llibrairie/visualint
        ///                 VisualBool       : https://sites.google.com/site/notionscsharpcem/gui---visualarrays/visualcells/visualbool
        ///                 Formulaire       : https://sites.google.com/site/notionscsharpcem/guicontroles/form
        ///                 
        ///                 
        /// Auteurs     :   Profs 106 :  Desmeules / Savoie / Comte
        /// </summary>
        /// =============================================================================================
        const string NOM_ETUDIANT = " (Matériel)";
        public FrmEx6ChercherUnNombreCache()
        {
            InitializeComponent();
            Text += NOM_ETUDIANT;
            mnuFichierNouvellePartie.PerformClick();
        }

        // TODO 6A : Observer la propriété AcceptButton du formulaire. Lire la description de la propriété.
        // ***  Propriétés d'un formulaire https://sites.google.com/site/notionscsharpcem/guicontroles/form
        // TODO 6B : Observer les propriétés View, Minimum et Maximum du nombre à vérifier.
        //-----------------------------------------------------------------------------------------------
        private void mnuFichierNouvellePartie_Click(object sender, EventArgs e)
        {
            Random objRandom = new Random();
            // TODO 6C : Initialiser le nombre d'essais
            vsiNbEssais.Value = 0;

            // TODO 6D : Initialiser le nombre à vérifier à la moitié de son maximum.
            vsiNombreAVerifier.Value = vsiNombreAVerifier.Maximum / 2;

            // Générer un nombre aléatoire entre 1 et 100 pour le nombre recherché.
            vsiNombreCaché.Value = objRandom.Next(1, 101);

            // Assigner la bonne couleur de fond au nombre à vérifier.
            vsiNombreAVerifier.BackColor = Color.White;

            // TODO 6E : Rendre invisible le nombre caché.
            vsiNombreCaché.Visible = false;
            
            #region NE PAS MODIFIER
            // On active les contrôles du jeu pour une nouvelle partie
            vsiNombreAVerifier.Enabled = true;
            vsbPlusGrand.Value = false;
            vsbPlusPetit.Value = false;
            btnAccepter.Enabled = true;
            mnuSpécialModeTest.Checked = false;
            #endregion 
        }

        // -----------------------------------------------------------------------------------------------
        private void btnAccepter_Click(object sender, EventArgs e)
        {
            // TODO 6F : Allumer ou éteindre les lumières "Nombre plus petit" ou "Nombre plus grand" selon le cas.
            //        : Dans le cas où le nombre a été trouvé, il faut ajuster (mettre à jour) la couleur et la disponibilité
            //          de certains contrôles, ce que nous appelons « Mettre à jour selon le contexte ».

            if (vsiNombreAVerifier.Value<vsiNombreCaché.Value)
            {
                vsbPlusPetit.Value = true;
                vsbPlusGrand.Value = false;
            }
            else if (vsiNombreAVerifier.Value>vsiNombreCaché.Value)
            {
                vsbPlusGrand.Value = true;
                vsbPlusPetit.Value = false;
            }
            if (vsiNbEssais.Value!=vsiNbEssais.Maximum)
            {
                vsiNbEssais.Value++;
            }
            else if (vsiNbEssais.Value==vsiNbEssais.Maximum)
            {
                vsiNombreCaché.Visible = true;
                btnAccepter.Enabled = false;
            }



            // TODO 6G : Ajuster les contrôles si le nombre d'essais permis est atteint.
            if (vsiNbEssais.Value == vsiNbEssais.Maximum)
            {
                vsiNombreAVerifier.BackColor = Color.Red;
            }
            else if (vsiNbEssais.Value != vsiNbEssais.Maximum && vsiNombreAVerifier.Value == vsiNombreCaché.Value)
            {
                vsiNombreAVerifier.BackColor = Color.Green;
            }
        }

        #region Menus NE PAS MODIFIER

        //-----------------------------------------------------------------------------------------------
        private void mnuSpécialModeTest_Click(object sender, EventArgs e)
        {
            lblNombreCaché.Visible = mnuSpécialModeTest.Checked;
            vsiNombreCaché.Visible = mnuSpécialModeTest.Checked;
        }

        //-----------------------------------------------------------------------------------------------
        private void mnuAideCommentJouer_Click(object sender, EventArgs e)
        {
            string message = "Le but du jeu est de trouver un nombre caché.\n\n";
            message += "Saisir un nombre à comparer au nombre caché. ";
            message += "\n   Si le nombre est plus grand que le nombre recherché, \n         la lumière Plus grand s'allume.";
            message += "\n   Si le nombre est plus petit que le nombre recherché, \n         la lumière Plus petit s'allume.";

            message += "\n\nChaque partie peut avoir au maximum 10 essais.";
            MessageBox.Show(message, Text);
        }

        //-----------------------------------------------------------------------------------------------
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion Menus

        private void vsbPlusPetit_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
