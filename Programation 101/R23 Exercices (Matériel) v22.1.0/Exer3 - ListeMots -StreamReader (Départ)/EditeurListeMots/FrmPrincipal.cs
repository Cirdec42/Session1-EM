using System;
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
        //Ajouter un mot , en caractères minuscules, dans le listBox
        //Le mot doit être unique
        //Préparer le champ texte txtNouveauMot à recevoir un nouveau mot
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
        //Retirer le mot sélectionné du listBox
        private void btnSupprimerMot_Click(object sender, EventArgs e)
        {
            lstMots.Items.Remove(lstMots.SelectedItem);
        }

        //==============================================================================================
        //Rendre disponible le bouton btnSupprimerMot selon le contexte.
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
        //TODO 1 : Vider le ListBox lstMots
        private void BtnViderListe_Click(object sender, EventArgs e)
        {
            //À compléter
        }
        //==============================================================================================
        //TODO 2 : Remplir le ListBox lstMots à partir du fichier ListeDeMots.txt
        private void BtnLireListe_Click(object sender, EventArgs e)
        {
            //À compléter

        }

        //==============================================================================================
        //TODO 3: Sauvegarder le contenu du ListBox lstMots dans le fichier ListeDeMots.txt
        private void BtnEnregistrerListe_Click(object sender, EventArgs e)
        {
            //À compléter

        }
    }
}
