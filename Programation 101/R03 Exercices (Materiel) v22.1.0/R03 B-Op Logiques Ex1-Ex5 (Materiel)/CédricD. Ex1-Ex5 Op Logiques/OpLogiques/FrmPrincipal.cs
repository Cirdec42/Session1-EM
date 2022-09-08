using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VisualArrays;

namespace IfSimples
{
    public partial class FrmPrincipal : Form
    {
        /// ==================================================================================
        /// <summary>
        /// Description :   Exercices - B EX1 à EX5 - sélection
        /// Concepts    :   Opérateurs logiques
        ///                 https://sites.google.com/site/notionscsharpcem/operateurs/logiques
        ///  
        /// Auteurs     :   Profs 116
        /// </summary>
        /// ==================================================================================

        const string NOM_ETUDIANT = " (Matériel)";

        public FrmPrincipal()
        {
            InitializeComponent();
            this.Text += NOM_ETUDIANT;
        }

        #region Exercice 1 : Opérateur unaire NON

        // ----------------------------------------------------------------------------------
        private void btnInverserÉtatAvecif_Click(object sender, EventArgs e)
        {
            // TODO 1A : Inverser l'état de la lumière en utilisant l'instruction if.
            if (vsbLumièreOpLogiqueNon.Value != true)
            {
                vsbLumièreOpLogiqueNon.Value = true;
            }
            else if (vsbLumièreOpLogiqueNon.Value == true)
            {
                vsbLumièreOpLogiqueNon.Value = false;  
            }
        }

        // ----------------------------------------------------------------------------------
        private void btnInverserÉtatAvecAssigantion_Click(object sender, EventArgs e)
        {
            // TODO 1B : Inverser l'état de la lumière avec une assignation. (SANS if).
             vsbLumièreOpLogiqueNon.Value = !vsbLumièreOpLogiqueNon.Value ;
        }

        #endregion

        #region Exercice 2 : Opérateur logique ET

        // ----------------------------------------------------------------------------------
        private void btnEvaluerOpLogiqueET_Click(object sender, EventArgs e)
        {
            // TODO 2 : Allumer la lumière si les 3 lumières sont allumées.
            if (vsbOpEtLum1.Value && vsbOpEtLum2.Value && vsbOpEtLum3.Value)
            {
                vsbOpEtRésultat.Value = true;
            }
            else
            {
                vsbOpEtRésultat.Value = false;
            }
        }

        #endregion

        #region Exercice 3 : Opérateur logique OU

        // ----------------------------------------------------------------------------------
        private void btnEvaluerEx2_Click(object sender, EventArgs e)
        {
            // TODO 3 : Allumer la lumière résultat si une des 3 lumière est allumée.
            if (vsbOpOuLum1.Value || vsbOpOuLum2.Value || vsbOpOuLum3.Value)
            {
                vsbOpOuRésultat.Value = true;
            }
            else
            {
                vsbOpOuRésultat.Value = false;
            }
        }

        #endregion

        #region Exercice 4 : Déterminer si les 3 nombres sont égaux et/ou pairs.

        // ----------------------------------------------------------------------------------
        private void btnComparer3Nombres_Click(object sender, EventArgs e)
        {
            // TODO 4 : Allumer la lumière Nombres égaux ou Nombre Pairs selon la valeur des nombres 1 à 3.
            if (vsiNombre1.Value == vsiNombre2.Value && vsiNombre1.Value == vsiNombre3.Value)
            {
                vsbNombresEgaux.Value = true;
            }
            else
            {
                vsbNombresEgaux.Value= false;
            }
            if (vsiNombre1.Value % 2 == 0 && vsiNombre2.Value % 2 ==0 && vsiNombre3.Value % 2 == 0 )
            {
                vsbNombresPairs.Value = true    ;
            }
            else
            {
                vsbNombresPairs.Value = false ; 
            }
        }

        #endregion

        #region Exercice 5 : Évaluer la valeur d'une main de 3 cartes.

        // Les images représentent une suite de coeur, de l'as au roi.
        // Chaque image de carte est associée à un entier.     
        //   Entier :       0   1   2   3   4   5   6   7   8   9    10     11   12 
        //   Carte  :      as   2   3   4   5   6   7   8   9  10   valet  dame  roi

        // ----------------------------------------------------------------------------------
        private void btnChoisirCartes_Click(object sender, EventArgs e)
        {
             Random objRandom = new Random();
            vsiCarte1.Value = objRandom.Next(0, 13);
            vsiCarte2.Value = objRandom.Next(0, 13);
            vsiCarte3.Value = objRandom.Next(0, 13);

        }

        // ----------------------------------------------------------------------------------
        private void btnÉvaluerMainCartes_Click(object sender, EventArgs e)
        {
            // TODO 5 : Afficher le score selon les règles.
            // Règles :
            //          3 cartes pareilles valent 100 points
            //          2 cartes pareilles valent 50 points
            //          3 cartes différentes valent la somme des valeurs des cartes
            //                 As vaut 1 point, 2 vaut 2 points, ..., K vaut 13 points.

            if (vsiCarte1.Value == vsiCarte2.Value && vsiCarte1.Value == vsiCarte3.Value && vsiCarte2.Value == vsiCarte3.Value)
            {
                vsiScore.Value = 100;
            }
            else if (vsiCarte1.Value == vsiCarte2.Value || vsiCarte1.Value == vsiCarte3.Value || vsiCarte2.Value == vsiCarte3.Value)
            {
                vsiScore.Value = 50;
            }
            else if (vsiCarte1.Value != vsiCarte2.Value || vsiCarte1.Value != vsiCarte3.Value || vsiCarte2.Value != vsiCarte3.Value)
            {
                vsiScore.Value = vsiCarte1.Value + vsiCarte2.Value + vsiCarte3.Value;
            }
        }

      #endregion
    }
}
