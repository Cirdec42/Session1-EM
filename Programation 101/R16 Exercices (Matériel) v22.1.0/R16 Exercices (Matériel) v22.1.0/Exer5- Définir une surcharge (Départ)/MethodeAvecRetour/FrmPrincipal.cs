using System;
using System.Windows.Forms;

namespace MethodeAvecRetour
{
    /// <summary>
    /// Application qui illsutre comment effectuer des appels imbriqués de méthodes qui produisent un résultat.
    /// Également, comment surcharger (re-définir) une méthode avec une signature différente.
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        const string NOM_PRENOM = "(Matériel)";

        #region NE PAS MODIFIER
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += NOM_PRENOM;

        }
        private void MnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Méthode MinimumEntre
        //---------------------------------------------------------------------------------
        /// <summary>
        /// Détermine le minimum entre deux valeurs entières
        /// </summary>
        /// <param name="pNombre1">Nombre 1</param>
        /// <param name="pNombre2">Nombre 2</param>
        /// <returns>Le plus petit des deux nombres</returns>
        private int MinimumEntre(int pNombre1, int pNombre2)
        {
            // TODO 01A : Modifier la signature de la méthode pour ajouter deux paramètres entier.
            // TODO 01B : Modifier l'entête de la méthode pour retourner une valeur entière.
            // TODO 01C : Compléter la méthode et n'oubliez pas d'utiliser return pour retourner le résultat approprié
            if (pNombre1<pNombre2)
            {
                return pNombre1;
            }
            else
            {
                return pNombre2;
            }
        }
        #endregion

        #region Appeler la méthode MinimumEntre
        //---------------------------------------------------------------------------------
        private void BtnMinimumEntre12Et25_Click(object sender, EventArgs e)
        {
            // TODO 02 : Utilisant la méthode MinimumEntre, pour placer la plus petite valeur entre 12 et 25 dans vsiRésultat.Value
            vsiRésultat.Value = MinimumEntre(12, 25);
        }
        //---------------------------------------------------------------------------------
        private void BtnMinimumEntre2Nombres_Click(object sender, EventArgs e)
        {
            // TODO 03 : Utilisant la méthode MinimumEntre, placer la plus petite valeur entre vsiNombre1.Value et vsiNombre2.Value dans vsiRésultat.Value
            vsiRésultat.Value = MinimumEntre(vsiNombre1.Value, vsiNombre2.Value);
        }
        //---------------------------------------------------------------------------------
        private void BtnMinimumEntre3Nombres_Click(object sender, EventArgs e)
        {
            // TODO 04 : Utilisant la méthode MinimumEntre, placer la plus petite valeur entre les 3 premiers nombres dans vsiRésultat.Value
            //           ATTENTION : sans modifier la méthode MinimumEntre ou ajouter d'autres méthodes
            vsiRésultat.Value = MinimumEntre(vsiNombre1.Value, MinimumEntre(vsiNombre2.Value, vsiNombre3.Value));
        }
        //---------------------------------------------------------------------------------
        private void BtnMinimumEntre4Nombres_Click(object sender, EventArgs e)
        {
            // TODO 05 : Utilisant la méthode MinimumEntre à deux paramètres, placer la plus petite valeur entre les 4 nombres
            //           ATTENTION : sans modifier la méthode MinimumEntre ou ajouter d'autres méthodes
            vsiRésultat.Value = MinimumEntre(MinimumEntre(vsiNombre1.Value,vsiNombre2.Value),MinimumEntre(vsiNombre3.Value,vsiNombre4.Value));
        }
        #endregion

        #region Définir une surcharge de la méthode MinimumEntre à 3 paramètres
        //---------------------------------------------------------------------------------
        /// <summary>
        /// Détermine le minimum entre trois valeurs entières
        /// </summary>
        /// <param name="pNombre1">Nombre 1</param>
        /// <param name="pNombre2">Nombre 2</param>
        /// <param name="pNombre3">Nombre 3</param>
        /// <returns>Le plus petit des quatres nombres</returns>
        private int MinimumEntre(int pNombre1, int pNombre2, int pNombre3)
        {
            // TODO 06A : Créer une surcharge de la méthode MinimumEntre avec trois paramètres qui retourne une valeur entière
            // TODO 06B : Compléter la méthode et n'oubliez pas d'utiliser return pour retourner le résultat approprié
            return MinimumEntre(pNombre1,MinimumEntre(pNombre2,pNombre3));
        }
        private void BtnSurcharge3Paramètres_Click(object sender, EventArgs e)
        {
            // TODO 06C : Utilisant la méthode MinimumEntre à trois paramètres, afficher la plus petite des valeurs de vsiNombre1.Value, vsiNombre2.Value et vsiNombre3.Value
           vsiRésultat.Value= MinimumEntre(vsiNombre1.Value,vsiNombre2.Value,vsiNombre3.Value);
        }
        #endregion

        #region Définir une surcharge de la méthode MinimumEntre à 4 paramètres
        //---------------------------------------------------------------------------------
        /// <summary>
        /// Détermine le minimum entre quatre valeurs entières
        /// </summary>
        /// <param name="pNombre1">Nombre 1</param>
        /// <param name="pNombre2">Nombre 2</param>
        /// <param name="pNombre3">Nombre 3</param>
        /// <param name="pNombre4">Nombre 4</param>
        /// <returns>Le plus petit des quatres nombres</returns>
        private int MinimumEntre(int pNombre1, int pNombre2, int pNombre3, int pNombre4)
        {
            // TODO 07A : Créer une surcharge de la méthode MinimumEntre avec quatre paramètres qui retourne une valeur entière
            // TODO 07B : Compléter la méthode et n'oubliez pas d'utiliser return pour retourner le résultat approprié/
            return MinimumEntre(MinimumEntre(pNombre1, pNombre2), MinimumEntre(pNombre3, pNombre4));
        }
        //---------------------------------------------------------------------------------
        private void BtnSurcharge4Paramètres_Click(object sender, EventArgs e)
        {
            // TODO 07C : Utilisant la méthode MinimumEntre à quatre paramètres, placer la plus petite valeur dans la zone résultat
            vsiRésultat.Value= MinimumEntre(vsiNombre1.Value, vsiNombre2.Value, vsiNombre3.Value, vsiNombre4.Value);
            
        }
        #endregion


    }
}
