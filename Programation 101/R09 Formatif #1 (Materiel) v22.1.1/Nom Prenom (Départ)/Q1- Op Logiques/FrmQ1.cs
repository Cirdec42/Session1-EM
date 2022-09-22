using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpLogiques
{
    /// ==================================================================================
    /// <summary>
    /// Description :   Formatif 1 - Question 1
    /// </summary>
    /// ==================================================================================
    public partial class FrmQ1 : Form
    {
        const string NOM_ETUDIANT = "(Matériel)";

        public FrmQ1()
        {
            InitializeComponent();
            Text += NOM_ETUDIANT;
        }

        #region Exercice 1 : Sélection avec des intervalles

        // --------------------------------------------------------------------------------------
        private void vsiEx1Nombre_ValueChanged(object sender, EventArgs e)
        {
            // TODO Q1 Ex1 A : Allumer la lumière du nombre si le nombre est entre 20 et 60 inclusivement.
 



        }

        // --------------------------------------------------------------------------------------
        private void vsiEx1Lettre_ValueChanged(object sender, EventArgs e)
        {
            // TODO Q1 Ex1 B : Allumer la lumière de la lettre si la lettre est entre D et K inclusivement.
  



        }

        #endregion Exercice 1 : Sélection avec intervalles

        #region Exercice 2 : Statut d'une personne

        // ----------------------------------------------------------------------------------
        private void vsiEx2Age_ValueChanged(object sender, EventArgs e)
        {
            // TODO Q1 Ex2 : Allumer la lumière correspondant à la catégorie d'une personne.
            //               Catégories  
            //               Enfant : 0 à 12 ans, Adolescent : 13 à 17 ans. Adulte : 18 ans et plus
    




        }

        #endregion Exercice 2 :Statut d'un personne

        #region Exercice 3 : Première et dernière allumées

        // ----------------------------------------------------------------------------------
        private void vsbEx3Lumiere1A3_ValueChanged(object sender, EventArgs e)
        {
            // TODO Q1 Ex3 : Allumer la lumière résultat si la première et la dernière lumière sont allumées.
    



        }
        #endregion Exercice 3 : Première et dernière allumées

        #region Exercice 4 : Trois lumières avec le même état

        // ----------------------------------------------------------------------------------
        private void vsbEx4Lumiere1A4_ValueChanged(object sender, EventArgs e)
        {
            // TODO Q1 Ex4 : Allumer la lumière résultat si les 3 lumières ont le même état.
   



        }

        #endregion Exercice 4 : Trois lumières avec le même état

        #region Exercice 5 : Nombres différents et/ou en ordre

        // ----------------------------------------------------------------------------------
        private void vsiEx5Nombre1A3_ValueChanged(object sender, EventArgs e)
        {
            // TODO Q1 Ex5 : Allumer la lumière "Nombres différents" si les 3 nombres sont différents
            //               et la lumière "Ordre croissant" si les nombres sont en ordre croissant.
   




        }


        #endregion Exercice 5 : Nombres différents et/ou en ordre

        #region Exercice 6 : Évaluer la valeur d'une main de 3 cartes.

        // *** Rappel :
        //     Les images des cartes sont associées aux entiers via un composant imageList.
        //     L'image list gère une collection d'images.

        // Les images représentent une suite de coeur, de l'as au roi.
        // Chaque image de carte est associée à un entier.
        //   Entier :       0   1   2   3   4   5   6   7   8   9    10     11   12
        //   Carte  :      as   2   3   4   5   6   7   8   9  10   valet  dame  roi

        // ----------------------------------------------------------------------------------
        private void btnChoisirCartes_Click(object sender, EventArgs e)
        {
            // TODO Q1 Ex6 A : Afficher 3 cartes au hasard.

            vsiCarte1.RandomizeValue();
            vsiCarte2.RandomizeValue();
            vsiCarte3.RandomizeValue();
        }

        // ----------------------------------------------------------------------------------
        const int ROI = 12;
        const int DAME = 11;
        const int VALET = 10;
        // --------------------------------------------------------------------------------
        private void vsiCarte1A3_ValueChanged(object sender, EventArgs e)
        {
            // TODO Q1 Ex6 B : Évaluer la main.   
            //           3 rois : 100 points / 3 dames ou 3 valets : 75 points / 3 pareilles 50
            //           autrement la somme des 3 cartes.
            //  ATTENTION, utilisez les constantes ROI, DAME et VALET quand cela est possible





        }

        #endregion Exercice 6 : Évaluer la valeur d'une main de 3 cartes.
    }
}
