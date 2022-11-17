using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EditeurListeMots
{
    /// <summary>
    /// Introduction au ListBox 
    ///     - Propriétés Items et méthodes Add, Remove, Contains
    ///     - Propriété SelectedIndex et événement SelectedIndexChanged
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        const string APP_INFOS = "(Matériel)";
        //==============================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFOS;
        }

        #region Code de l'exercice1
        //==============================================================================================
        private void btnAjouterMot_Click(object sender, EventArgs e)
        {
            string nouveauMot = txtNouveauMot.Text.ToLower();
            if (nouveauMot.Length > 0 && !lstMots.Items.Contains(nouveauMot)) // Pour ne pas ajouter le même mot plusieurs fois
            {
                lstMots.Items.Add(nouveauMot);

                txtNouveauMot.Clear();
                txtNouveauMot.Select();
            }
        }

        //==============================================================================================
        private void btnSupprimerMot_Click(object sender, EventArgs e)
        {
            lstMots.Items.Remove(lstMots.SelectedItem);
        }

        //==============================================================================================
        private void lstMots_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSupprimerMot.Enabled = lstMots.SelectedIndex != -1;
            txtSelectedIndex.Text = lstMots.SelectedIndex.ToString();
        }

        //==============================================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        //==============================================================================================
        //TODO 1: Sauvegarder le contenu du ListBox lstMots dans le fichier ListeDeMots.txt
        private void BtnEnregistrerListe_Click(object sender, EventArgs e)
        {
            // À compléter
            StreamWriter Ecrit = new StreamWriter("/../../Liste.txt");
            for (int i = 0; i < lstMots.Height; i++)
            {
                Ecrit.WriteLine(lstMots);
            }
        }
    }
}
