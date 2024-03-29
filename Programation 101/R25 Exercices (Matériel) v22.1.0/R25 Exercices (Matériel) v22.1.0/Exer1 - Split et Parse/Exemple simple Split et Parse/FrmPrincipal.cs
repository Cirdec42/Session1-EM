﻿using System;
using System.Windows.Forms;

namespace Exemple_simple_Split_et_Parse
{
    /// <summary>
    /// Exemple démontrant l'utilisation de la méthode Parse et de la méthode string.Split()
    /// 
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";

        #region NE PAS MODIFIER
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
        }
        private void MnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Utilisation de la méthode Parse 
        //-----------------------------------------------------------------------------------
        private void btnConvertirEnInt_Click(object sender, EventArgs e)
        {
            // TODO 01 : Convertir le texte de la zone txtNombreEntier pour l'afficher dans la zone vsiNombre1
            vsiNombre1.Value = int.Parse(txtNombreEntier.Text);
        }

        //-----------------------------------------------------------------------------------
        private void btnConvertirEnDecimal_Click(object sender, EventArgs e)
        {
            // TODO 02 : Convertir le texte de la zone txtNombreEntier pour l'afficher dans la zone numNombre
            numNombre.Value = decimal.Parse(txtNombreEntier.Text);
        }

        //-----------------------------------------------------------------------------------
        private void btnAjouter100_Click(object sender, EventArgs e)
        {
            // TODO 03 : Convertir le texte de la zone txtNombreEntier en un nombre entier
            //           Ajouter 100 au nombre entier puis l'afficher dans la zone vsiNombre2
            vsiNombre2.Value = int.Parse(txtNombreEntier.Text) + 100;
        }

        //----------------------------------------------------------------------------------
        private void btnAjouter100AuTextBox_Click(object sender, EventArgs e)
        {
            // TODO 04 : Convertir le texte de la zone txtNombreEntier en un nombre entier
            //           Ajouter 100 au nombre entier puis l'assigner de nouveau dans la zone txtNombreEntier
            txtNombreEntier.Text = (int.Parse(txtNombreEntier.Text) + 100).ToString();
        }
        #endregion

        #region Utilisation de la méthode Split
        private void BtnPlacerDansLaGrilleDeNombres_Click(object sender, EventArgs e)
        {
            // TODO 05 : Séparer le texte de la zone txtListeDeNombres en utilisant la virgule comme séparateur.
            //           Redimensionner la grille en modifiant sa propriété ColumnCount.
            //           Utiliser une boucle pour placer toutes les valeurs dans la grille.
            //           Ajouter une instruction de sélection afin d'ignorer les valeurs qui ne sont pas dans l'interval
            //           viaNombres.Minimum et viaNombre.Maximum
            string nb = txtListeDeNombres.Text;
            string[] tabnb = nb.Split(',');

            for (int i = 0; i < viaNombres.Length; i++)
            {
                viaNombres[i] = int.Parse(tabnb[i]);
            }
        }
        #endregion

        private void txtNombreEntier_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
