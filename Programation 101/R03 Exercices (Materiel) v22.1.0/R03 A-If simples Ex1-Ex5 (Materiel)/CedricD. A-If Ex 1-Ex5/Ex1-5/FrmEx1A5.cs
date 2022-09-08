using System;
using System.Windows.Forms;

namespace IfSimples
{
    public partial class FrmEx1A5 : Form
    {
        /// =============================================================================================
        /// <summary>
        /// Description :   Exercices d'apprentissage - Chapitre 2 : Sélections / A-IFs simples
        /// Concepts    :
        ///                 Sélection (if)  : https://sites.google.com/site/notionscsharpcem/structure/if
        ///                 
        ///                 Type de données bool : https://sites.google.com/site/notionscsharpcem/type
        ///                 Expresssion booléenne: https://sites.google.com/site/notionscsharpcem/expression
        ///                 Opérateur arithmétique multiplicative : https://sites.google.com/site/notionscsharpcem/operateurs
        ///                
        ///                 Contrôles        : VisualInt  https://sites.google.com/site/notionscsharpcem/gui---visualarrays/visualcells/visualint
        ///                                    VisualBool https://sites.google.com/site/notionscsharpcem/gui---visualarrays/visualcells/visualbool
        ///
        /// Composant   :   dll VisualArrays de Stéphane Desmeules - 2014-11-10
        ///
        /// Auteurs     :   Profs 116 :  Comte / Desmeules/ Savoie
        /// </summary>
        /// =============================================================================================

        const string NOM_ETUDIANT = " (Matériel)";

        public FrmEx1A5()
        {
            InitializeComponent();
            Text += NOM_ETUDIANT;
        }


        #region Exercice 1 : type de données booléen et conntrôle VisualBool

        // --------------------------------------------------------------------------------------------
        private void btnAllumerLumiere_Click(object sender, EventArgs e)
        {
            // TODO 1A : Allumer la lumière.
            vsbLumière.Value = true;
        }

        // --------------------------------------------------------------------------------------------
        private void btnÉteindreLumiere_Click(object sender, EventArgs e)
        {
            // TODO 1B : Éteindre la lumière.
            vsbLumière.Value = false;
        }

        // --------------------------------------------------------------------------------------------
        private void btnRendreLumiereInvisible_Click(object sender, EventArgs e)
        {
            // TODO 1C : Rendre la lumière invisible.
            vsbLumière.Visible = false;
        }

        // --------------------------------------------------------------------------------------------
        private void btnRendreLumiereVisible_Click(object sender, EventArgs e)
        {
            // TODO 1D : Rendre la lumière visible.
            vsbLumière.Visible=true;    
        }

        #endregion

        #region Exercice 2 : If simple avec un vrai et un faux (else) - Statut mineur ou majeur



        // --------------------------------------------------------------------------------------------
        private void btnDeterminerStatutMajeurOuMineur_Click(object sender, EventArgs e)
        {
            // TODO 2 : Allumer la bonne lumière.  L'âge de la majorité est 18 ans.
            if (vsiAge.Value < 18)
            {
                vsbMineur.Value = true;
            }
            else
            {
                    vsbMajeur.Value = true;
            }
        }

        #endregion

        #region Exercice 3 :  If ... else  if ... else

        // --------------------------------------------------------------------------------------------
        private void btnComparer2Nombres_Click(object sender, EventArgs e)
        {
            // TODO 3 : Allumer la lumière du plus grand nombre ou les 2 lumières si les nombres sont égaux.
            if (vsiNombre1.Value > vsiNombre2.Value)
            {
                vsbNombre1.Value = true;
            }
            else if (vsiNombre1.Value<vsiNombre2.Value)
            {
                vsbNombre2.Value = true;
            }
            else if (vsiNombre1.Value==vsiNombre2.Value)
            {
                vsbNombre1.Value = true;
                vsbNombre2.Value =true; 
            }
         
        }

        #endregion

        #region Exercice 4 : Opérateur modulo, le reste de la division entière

        // *** OPérateur %  : Modulo donne le reste de la division entière 
        // --------------------------------------------------------------------------------------------
        private void btnVérifierSiNombreEstPair_Click(object sender, EventArgs e)
        {
            // TODO 4 : Allumer la lumière si le nombre est pair.
            if (vsiNombre.Value % 2 == 0)
            {
                vsbEstPair.Value = true;
            }
            else if (vsiNombre.Value % 2 != 0)
            {
                vsbEstPair.Value=false  ;
            }
        }

        #endregion

        #region Exercice 5 : Génération nombres au hasard et if ... else if ... et variable

        // *** Rappel :
        //     Les images des cartes sont associées aux entiers via un composant imageList du contrôle.
        //     L'image list gère une collection d'images.

        // Les images représentent une suite de coeur, de l'as au roi.
        // Chaque image de carte est associée à un entier.
        //      
        //   Entier :       0   1   2   3   4   5   6   7   8   9    10     11   12 
        //   Carte  :      as   2   3   4   5   6   7   8   9  10   valet  dame  roi 

        // --------------------------------------------------------------------------------------------
        private void btnChoisirCartesAuHasard_Click(object sender, EventArgs e)
        {
            Random objRandom = new Random();
            vsiCarte1.Value = objRandom.Next(0, 13);
            vsiCarte2.Value = objRandom.Next(0, 13);
        }

        // --------------------------------------------------------------------------------------------
        private void btnDeterminerMeilleureCarte_Click(object sender, EventArgs e)
        {
            // TODO 5 : Allumer la lumière de la carte la plus élevée. Seule une lumière doit être allumée.
            if (vsiCarte1.Value>vsiCarte2.Value)
            {
                vsbLumièreCarte1.Value = true;
                vsbLumièreCarte2.Value = false;
            }
            else if (vsiCarte1.Value<vsiCarte2.Value)
            {
                vsbLumièreCarte2.Value = true;
                vsbLumièreCarte1.Value=false;   
            }
            else if (vsiCarte1.Value == vsiCarte2.Value)
            {
                vsbLumièreCarte1.Value = true;
                vsbLumièreCarte2.Value=true; 
            }
        }
        #endregion
    }
}