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
            if (vsiEx1Nombre.Value >=20 && vsiEx1Nombre.Value <=60)
            {
                vsbEx1LumiereNombre.Value = true;
            }
            else
            {
                vsbEx1LumiereNombre.Value = false;
            }


        }

        // --------------------------------------------------------------------------------------
        private void vsiEx1Lettre_ValueChanged(object sender, EventArgs e)
        {
            // TODO Q1 Ex1 B : Allumer la lumière de la lettre si la lettre est entre D et K inclusivement.

            if (vsiEx1Lettre.Value >= 'D' && vsiEx1Lettre.Value <='K')
            {
                vsbEx1LumiereLettre.Value = true;
            }
            else
            {
                vsbEx1LumiereLettre.Value = false;
            }

        }

        #endregion Exercice 1 : Sélection avec intervalles

        #region Exercice 2 : Statut d'une personne

        // ----------------------------------------------------------------------------------
        private void vsiEx2Age_ValueChanged(object sender, EventArgs e)
        {
            // TODO Q1 Ex2 : Allumer la lumière correspondant à la catégorie d'une personne.
            //               Catégories  
            //               Enfant : 0 à 12 ans, Adolescent : 13 à 17 ans. Adulte : 18 ans et plus
            if (vsiEx2Age.Value >= 0 && vsiEx2Age.Value <=12)
            {
                vsbEx2Enfant.Value = true;
                vsbEx2Adolescent.Value = false;
                vsbEx2Adulte.Value = false;
            }
            else if (vsiEx2Age.Value >=13 && vsiEx2Age.Value<=17)
            {
                vsbEx2Enfant.Value = false;
                vsbEx2Adolescent.Value = true;
                vsbEx2Adulte.Value = false;
            }
            else
            {
                vsbEx2Enfant.Value = false;
                vsbEx2Adolescent.Value = false;
                vsbEx2Adulte.Value=true;
            }




        }

        #endregion Exercice 2 :Statut d'un personne

        #region Exercice 3 : Première et dernière allumées

        // ----------------------------------------------------------------------------------
        private void vsbEx3Lumiere1A3_ValueChanged(object sender, EventArgs e)
        {
            // TODO Q1 Ex3 : Allumer la lumière résultat si la première et la dernière lumière sont allumées.
            if (vsbEx3Lumiere1.Value==true && vsbEx3Lumiere3.Value == true )
            {
                vsbEx3Résultat.Value = true;
            }
            else
            {
                vsbEx3Résultat.Value = false;
            }



        }
        #endregion Exercice 3 : Première et dernière allumées

        #region Exercice 4 : Trois lumières avec le même état

        // ----------------------------------------------------------------------------------
        private void vsbEx4Lumiere1A4_ValueChanged(object sender, EventArgs e)
        {
            // TODO Q1 Ex4 : Allumer la lumière résultat si les 3 lumières ont le même état.
            if (vsbEx4Lumiere1.Value == vsbEx4Lumiere2.Value && vsbEx4Lumiere2.Value == vsbEx4Lumiere3.Value && vsbEx4Lumiere1.Value == vsbEx4Lumiere3.Value)
            {
                vsbEx4Résultat.Value = true;
            }
            else
            {
                vsbEx4Résultat.Value = false;
            }


        }

        #endregion Exercice 4 : Trois lumières avec le même état

        #region Exercice 5 : Nombres différents et/ou en ordre

        // ----------------------------------------------------------------------------------
        private void vsiEx5Nombre1A3_ValueChanged(object sender, EventArgs e)
        {
            // TODO Q1 Ex5 : Allumer la lumière "Nombres différents" si les 3 nombres sont différents
            //               et la lumière "Ordre croissant" si les nombres sont en ordre croissant.
            if (vsiEx5Nombre1.Value == vsiEx5Nombre2.Value && vsiEx5Nombre1.Value == vsiEx5Nombre3.Value)
            {
                vsbEx5NombresDifferents.Value = false;
            }
            else
            {
                vsbEx5NombresDifferents.Value = true;
            }
            if (vsiEx5Nombre1.Value<vsiEx5Nombre2.Value && vsiEx5Nombre2.Value < vsiEx5Nombre3.Value)
            {
                vsbEx5OrdreCroissant.Value = true;
            }
            else
            {
                vsbEx5OrdreCroissant.Value = false;
            }   




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
            if (vsiCarte1.Value == ROI && vsiCarte1.Value == vsiCarte2.Value && vsiCarte1.Value == vsiCarte3.Value)
            {
                vsiScore.Value = 100;
            }
            else if (vsiCarte1.Value == DAME || vsiCarte1.Value == VALET && vsiCarte1.Value == vsiCarte2.Value && vsiCarte1.Value == vsiCarte3.Value)
            {
                vsiScore.Value = 75;
            }
            else if (vsiCarte1.Value == vsiCarte2.Value && vsiCarte1.Value == vsiCarte3.Value)
            {
                vsiScore.Value = 50;
            }
            else
            {
                vsiScore.Value = vsiCarte1.Value + vsiCarte2.Value + vsiCarte3.Value;
            }




        }

        #endregion Exercice 6 : Évaluer la valeur d'une main de 3 cartes.

        private void panExercice1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
