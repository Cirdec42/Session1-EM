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

        //==============================================================================================
        //TODO 1: Ajouter un mot , en caractères minuscules, dans le listBox
        //Le mot doit être unique
        //Préparer le champ texte txtNouveauMot à recevoir un nouveau mot
        private void btnAjouterMot_Click(object sender, EventArgs e)
        {
            // À compléter
            string newmot = txtNouveauMot.Text;
            if (newmot.Length > 0)
            {
                lstMots.Items.Add(newmot.ToLower());
                txtNouveauMot.Clear();
                txtNouveauMot.Select();
            }
        }

        //==============================================================================================
        //TODO 2 : Retirer le mot sélectionné du listBox
        private void btnSupprimerMot_Click(object sender, EventArgs e)
        {
            // À compléter
            lstMots.Items.Remove(lstMots.SelectedItem);
        }

        //==============================================================================================
        //TODO 3: Rendre disponible le bouton btnSupprimerMot selon le contexte et le mettre à jour le champ texte txtSelectedIndex
        private void lstMots_SelectedIndexChanged(object sender, EventArgs e)
        {
            //À compléter
            txtSelectedIndex.Text = lstMots.SelectedIndex.ToString();
            btnSupprimerMot.Enabled = lstMots.SelectedIndex != -1;

        }

        //==============================================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
