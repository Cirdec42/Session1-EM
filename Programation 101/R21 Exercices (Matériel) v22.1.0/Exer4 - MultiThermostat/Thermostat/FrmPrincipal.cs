using System;
using System.Windows.Forms;
using Librairie1N6;

namespace MultiThermostat
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";

        /// =================================================================================
        // TODO 01A : Déclarer une variable et Instancier un Thermostat pour la chambre à 25
        Thermostat cham = new Thermostat(25);

        // TODO 01B : Déclarer une variable et Instancier un Thermostat pour la cuisine à 20
        Thermostat cui = new Thermostat(20);

        // TODO 01C : Déclarer une variable et Instancier un Thermostat pour le salon à 22
        Thermostat sal = new Thermostat(22);

        // TODO 01D : Déclarer une variable supplémentaire pour référer sur le Thermostat courant (NE PAS INSTANCIER)
        Thermostat courant;
        //====================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            // TODO 02A : Fixer le Thermostat courant à celui de la chambre
            courant = cui;

            // TODO 02B : Afficher la température du Thermostat courant
            lblTemperature.Text = courant.Température.ToString();
        }

        //====================================================================================
        private void radChambre_CheckedChanged(object sender, EventArgs e)
        {
            // TODO 03A : Modifier le Thermostat courant pour référer sur celui de la chambre
            courant = cham;
            // TODO 03B : Afficher la température du Thermostat courant
            lblTemperature.Text = courant.Température.ToString();
            // TODO 03C : Appeler la méthode ActualiserBoutonsSelonContexte
            ActualiserBoutonsSelonContexte();
        }
        //====================================================================================
        private void radCuisine_CheckedChanged(object sender, EventArgs e)
        {
            // TODO 04A : Modifier le Thermostat courant pour référer sur celui de la cuisine
            courant = cui;
            // TODO 04B : Afficher la température du Thermostat courant
            lblTemperature.Text = courant.Température.ToString();
            // TODO 04C : Appeler la méthode ActualiserBoutonsSelonContexte
            ActualiserBoutonsSelonContexte();
        }
        //====================================================================================
        private void radSalon_CheckedChanged(object sender, EventArgs e)
        {
            // TODO 05A : Modifier le Thermostat courant pour référer sur celui du salon
            courant = sal;
            // TODO 05B : Afficher la température du Thermostat courant
            lblTemperature.Text = courant.Température.ToString();
            // TODO 05C : Appeler la méthode ActualiserBoutonsSelonContexte
            ActualiserBoutonsSelonContexte();
        }
        //====================================================================================
        private void btnAugmenter_Click(object sender, System.EventArgs e)
        {
            // TODO 06A : Augmenter la température du Thermostat courant
            courant.AugmenterTemperature();
            // TODO 06B : Afficher la température du Thermostat courant
            lblTemperature.Text = courant.Température.ToString();
            // TODO 06C : Appeler la méthode ActualiserBoutonsSelonContexte
            ActualiserBoutonsSelonContexte();
        }
        //====================================================================================
        private void btnDiminuer_Click(object sender, System.EventArgs e)
        {
            // TODO 07A : Diminuer la température du Thermostat courant
            courant.DiminuerTemperature();
            // TODO 07B : Afficher la température du Thermostat courant
            lblTemperature.Text = courant.Température.ToString();
            // TODO 07C : Appeler la méthode ActualiserBoutonsSelonContexte
            ActualiserBoutonsSelonContexte();
        }
        //====================================================================================
        private void mnuAffichageTempMin_Click(object sender, EventArgs e)
        {
            // TODO 08A : Afficher la température minimale permise par un Thermostat
            lblTemperature.Text = Thermostat.TEMPÉRATURE_MINIMALE.ToString();
            // TODO 08B : Démarrer l'horloge tmrTempératureCourante
            tmrTempératureCourante.Start();
        }
        //====================================================================================
        private void mnuAffichageTempMax_Click(object sender, EventArgs e)
        {
            // TODO 09A : Afficher la température maximale permise par un Thermostat
            lblTemperature.Text = Thermostat.TEMPÉRATURE_MAXIMALE.ToString();
            // TODO 09B : Démarrer l'horloge tmrTempératureCourante
            tmrTempératureCourante.Start();
        }
        //====================================================================================
        private void TmrTempératureCourante_Tick(object sender, EventArgs e)
        {
            // TODO 10A : Arrêter l'horloge tmrTempérature
            tmrTempératureCourante.Stop();
            // TODO 10B : Afficher la température actuelle du Thermostat courant
            lblTemperature.Text = courant.Température.ToString();
        }
        //====================================================================================
        private void ActualiserBoutonsSelonContexte()
        {
            // TODO 11A : btnDiminuer est actif seulement si la température courante est supérieure à TEMPÉRATURE_MINIMALE
            if (courant.Température>Thermostat.TEMPÉRATURE_MINIMALE)
            {
                btnDiminuer.Enabled = true;
            }
            else
            {
                btnDiminuer.Enabled = false;
            }
            // TODO 11B : btnAugmenter est actif seulement si la température courante est inférieure à TEMPÉRATURE_MAXIMALE
            if (courant.Température<Thermostat.TEMPÉRATURE_MAXIMALE)
            {
                btnAugmenter.Enabled = true;
            }
            else
            {
                btnAugmenter.Enabled = false;
            }
        }

        //====================================================================================
        private void mnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}