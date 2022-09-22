using System;
using System.Windows.Forms;

namespace IndexEtContenu
{
    // ==================================================================================
    /// <summary>
    /// Description :   Formatif 1 - Question 3
    /// </summary>
    /// ==================================================================================
    public partial class FrmQ3 : Form
    {
        const string NOM_ETUDIANT = "(Matériel)";

        #region Constructeur du formulaire

        // ------------------------------------------------------------------------------
        public FrmQ3()
        {
            InitializeComponent();
            Text += NOM_ETUDIANT;
        }

        #endregion Constructeur du formulaire

        #region Exercice 1 : Manipuler une grille de booléens.

        // --------------------------------------------------------------------------------------------
        private void btnAllumerLumiereMilieu_Click(object sender, EventArgs e)
        {
            // TODO Q3 Ex1 A : Allumer la lumière du milieu.
    


        }

        // --------------------------------------------------------------------------------------------
        private void btnAllumerDernereLumiere_Click(object sender, EventArgs e)
        {
            // TODO Q3 Ex1 B : Allumer la dernière lumière.
  


        }

        // --------------------------------------------------------------------------------------------
        private void btnAllumerLumièreIndex_Click(object sender, EventArgs e)
        {
            // TODO Q3 Ex1 C : Allumer la lumière à l'index saisi.
 


        }
        // --------------------------------------------------------------------------------------------
        private void btnInverserLumière_Click(object sender, EventArgs e)
        {
            // TODO Q3 Ex1 D : Inverser l'état de la lumière à l'index saisi.
 


        }

        #endregion Exercice 1

        #region Exercice 2 : Manipuler une grille de caractères.

        // --------------------------------------------------------------------------------------------
        private void btnAssignerCaractereAIndex_Click(object sender, EventArgs e)
        {
            // TODO Q3 Ex2 A : Assigner le caractère saisi à l'index saisi.
   


        }
        
        // --------------------------------------------------------------------------------------------
        private void btnAssignerA2eCellule_Click(object sender, EventArgs e)
        {
            // TODO Q3 Ex2 B : Assigner le caractère '#' dans la deuxième cellule.
   


        }

        // --------------------------------------------------------------------------------------------
        private void btnAssigner9_Click(object sender, EventArgs e)
        {
            // TODO Q3 Ex2 C : Assigner le caractère '9' à la dernière cellule.
  



        }

        // --------------------------------------------------------------------------------------------
        private void btnCopierCellule_Click(object sender, EventArgs e)
        {
            // TODO Q3 Ex2 D : Copier la troisième cellule dans l'avant-dernière.
  



        }

        // --------------------------------------------------------------------------------------------
        private void btnAugmenterCaractere_Click(object sender, EventArgs e)
        {
            // TODO Q3 Ex2 E : Modifier le caractère de la quatrième cellule pour y afficher le suivant.
  



        }
        // --------------------------------------------------------------------------------------------
        private void btnPermuterCellules_Click(object sender, EventArgs e)
        {
            // TODO Q3 Ex2 F : Permuter la première cellule et la dernière.
 




        }
     
        #endregion 
    }
}