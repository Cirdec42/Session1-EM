using System;
using System.Windows.Forms;

namespace SelectionMultiple
{
    public partial class FrmEx1A5 : Form
    {
        /// =============================================================================================
        /// <summary>
        /// Description :   Exercices d'apprentissage
        /// Concepts    :   Instruction de sélection multiple switch
        ///                 Type char
        ///                 Déclaration de variables locales
        ///                 Algorithme de permutation
        ///
        /// </summary>
        /// =============================================================================================

        public const string APP_INFO = " (Matériel)";

        #region Constructeur - NE PAS MODIFIER
        public FrmEx1A5()
        {
            InitializeComponent();
            this.Text += APP_INFO;
        }
        #endregion

        #region Exercice 1 : Type de données char et contrôle VisualChar

        // --------------------------------------------------------------------------------------------
        private void btnAssignerLettreE_Click(object sender, EventArgs e)
        {
            // TODO 01A : Assigner la lettre 'E' dans le zone caractère.
            vscExer1Lettre.Value = 'E';
        }

        // --------------------------------------------------------------------------------------------
        private void btnÉteindreLumiere_Click(object sender, EventArgs e)
        {
            // TODO 01B : À partir de la lettre contenue dans la zone char, assigner la lettre suivante du jeu de caractères.
            vscExer1Lettre.Value++;
        }

        // --------------------------------------------------------------------------------------------
        private void btnAllumerSiLettreD_Click(object sender, EventArgs e)
        {
            // TODO 01C : Allumer la lumière si la zone VisualChar contient la lettre D.
            if (vscExer1Lettre.Value=='D')
            {
                vsbLumière.Value = true;
            }
            else
            {
                vsbLumière.Value=false;
            }
        }

        // --------------------------------------------------------------------------------------------
        private void btnAllumerLettreBD_Click(object sender, EventArgs e)
        {
            // TODO 01D : Allumer la lumière si la lettre est 'B' ou 'D'
            if (vscExer1Lettre.Value=='B'|| vscExer1Lettre.Value=='D')
            {
                vsbLumière.Value = true;
            }
            else
            {
                vsbLumière.Value = false;
            }
        }

        // --------------------------------------------------------------------------------------------
        private void btnAllumerIntervalleBaE_Click(object sender, EventArgs e)
        {
            // TODO 01E : Allumer la lumière si la lettre est entre 'B' et 'E' inclusivement
            if (vscExer1Lettre.Value>='B'&& vscExer1Lettre.Value<='D')
            {
                vsbLumière.Value = true;
            }
            else
            {
                vsbLumière.Value = false;
            }
        }


        #endregion

        #region Exercice 2 : Allumer la bonne lumière avec une sélection multiple

        // --------------------------------------------------------------------------------------------
        private void btnAllumerLumCorrIfElse_Click(object sender, EventArgs e)
        {
            #region Éteindre toutes les lumières
            vsbEx2LumièreA.Value = false;
            vsbEx2LumièreB.Value = false;
            vsbEx2LumièreC.Value = false;
            vsbEx2LumièreD.Value = false;
            vsbEx2LumièreAvertissement.Value = false;
            #endregion

            // TODO 02A : Allumer la bonne lumière ou la lumière Avertissement autrement
            // Utiliser l'instruction de sélection if
            if (vscExer2Lettre.Value == 'A')
            {
                vsbEx2LumièreA.Value = true;
            }
            else if (vscExer2Lettre.Value == 'B')
            {
                vsbEx2LumièreB.Value = true;
            }
            else if (vscExer2Lettre.Value == 'C')
            {
                vsbEx2LumièreC.Value = true;
            }
            else if (vscExer2Lettre.Value == 'D')
            {
                vsbEx2LumièreD.Value = true;
            }
            else
            {
                vsbEx2LumièreAvertissement.Value = true;
            }
        }

        // --------------------------------------------------------------------------------------------
        private void btnAllumerLumCorrSwitch_Click(object sender, EventArgs e)
        {
            #region Éteindre toutes les lumières
            vsbEx2LumièreA.Value = false;
            vsbEx2LumièreB.Value = false;
            vsbEx2LumièreC.Value = false;
            vsbEx2LumièreD.Value = false;
            vsbEx2LumièreAvertissement.Value = false;
            #endregion

            // TODO 02B : Allumer la bonne lumière ou la lumière Avertissement autrement
            // Utiliser l'instruction de sélection multiple switch
            switch (vscExer2Lettre.Value)
            {
                case 'A':
                    vsbEx2LumièreA.Value = true;
                    break;
                case 'B':
                    vsbEx2LumièreB.Value = true;
                    break;
                case 'C':
                    vsbEx2LumièreC.Value = true;
                    break;
                case 'D':
                    vsbEx2LumièreD.Value = true;
                    break;
                default:
                    vsbEx2LumièreAvertissement.Value = true;
                    break;
            }
        }

        #endregion

        #region Exercice 3 : Voyelle ou consonne?

        #region btnEteindreLes2Lumières
        // --------------------------------------------------------------------------------------------
        private void btnEteindreLes2Lumières_Click(object sender, EventArgs e)
        {
            vsbVoyelle.Value = false;
            vsbConsonne.Value = false;
        }
        #endregion

        // --------------------------------------------------------------------------------------------
        private void btnVoyelleConsonneSwitch_Click(object sender, EventArgs e)
        {
            // TODO 03A : Allumer la bonne lumière selon qu'il s'agisse d'une voyelle ou d'une consonne avec un switch
            // A E I O U Y
            switch (vscExer3Lettre.Value)
            {
                case 'A':
                    vsbVoyelle.Value=true;
                    break;
                case 'E':
                    vsbVoyelle.Value = true;
                    break;
                case 'I':
                    vsbVoyelle.Value = true;
                    break;
                case 'O':
                    vsbVoyelle.Value = true;
                    break;
                case 'U':
                    vsbVoyelle.Value = true;
                    break;
                case 'Y':
                    vsbVoyelle.Value = true;
                    break;
                default:
                    vsbConsonne.Value = true;
                    break;
            }
        }

        // --------------------------------------------------------------------------------------------
        private void btnVoyelleConsonneIfElse_Click(object sender, EventArgs e)
        {
            // TODO 03B : Allumer la bonne lumière selon qu'il s'agisse d'une voyelle ou d'une consonne avec un if
            if (vscExer3Lettre.Value== 'A'|| vscExer3Lettre.Value == 'E'|| vscExer3Lettre.Value == 'I'|| vscExer3Lettre.Value == 'O'|| vscExer3Lettre.Value == 'U'|| vscExer3Lettre.Value == 'Y')
            {
                vsbVoyelle.Value = true;
            }
            else
            {
                vsbConsonne.Value = true;
            }
        }

        #endregion

        #region Exercice 4 : Calculer une prime

        // --------------------------------------------------------------------------------------------
        // 0 accident prime de 0$
        // 1 accident prime de 50$
        // 2 ou 3 accidents prime de 100$
        // 4, 5 ou 6 accidents prime de 250$
        // 7 et plus accidents prime de 500$

        private void btnCalculerLaPrime_Click(object sender, EventArgs e)
        {
            // TODO 04 : Déterminer la prime en fonction du nombre d'accidents.Utiliser un switch
            switch (vsiNbAccidents.Value)
            {
                case 0:
                    vsiPrimeAPayer.Value=0;
                    break;
                case 1:
                    vsiPrimeAPayer.Value = 50;
                    break;
                case 2:
                case 3:
                    vsiPrimeAPayer.Value = 100;
                    break;
                case 4:
                case 5:
                case 6:
                    vsiPrimeAPayer.Value = 250;
                    break;
                case 7:
                    vsiPrimeAPayer.Value = 500;
                    break;
                default:
                    vsiPrimeAPayer.Value = 500;
                    break;
            }
        }
        #endregion

        #region Exercice 5 : Permuter les contenus des zones de gauche avec celles de droite

        // --------------------------------------------------------------------------------------------
        private void btnPermuter_Click(object sender, EventArgs e)
        {
            // TODO 05A Permuter les valeurs des 2 caractères
            char temporaireChar = vscCaracDeGauche.Value;
            vscCaracDeGauche.Value = vscCaracDeDroite.Value;
            vscCaracDeDroite.Value = temporaireChar;
            // TODO 05B Permuter les valeurs des 2 nombres
            int TempoNum = vsiNombreAGauche.Value;
            vsiNombreAGauche.Value = vsiNombreADroite.Value;
            vsiNombreADroite.Value=temporaireChar;

            // TODO 05C Permuter les valeurs des 2 lumières
            bool TempoLum = vsbLumDeGauche.Value;
            vsbLumDeGauche.Value = vsbLumDeDroite.Value;
            vsbLumDeDroite.Value = TempoLum;
        }
        #endregion
    }
}