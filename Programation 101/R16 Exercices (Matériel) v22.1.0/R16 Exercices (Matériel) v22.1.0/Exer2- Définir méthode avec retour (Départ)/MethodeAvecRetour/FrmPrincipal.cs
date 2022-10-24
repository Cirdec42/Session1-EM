using System;
using System.Windows.Forms;

namespace MethodeAvecRetour
{
    /// <summary>
    /// Application qui illustre comment définir de nouvelles méthodes qui produisent un résultat
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        const string NOM_PRENOM = "(NOM_PRENOM)";

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

        #region LivresEnKilos
        //-------------------------------------------------------------------------------
        /// <summary>
        /// Retourne la valeur en kilo d'un poids en livre 
        /// </summary>
        /// <param name="pLivres">poids en livre à convertir</param>
        /// <returns>Retourne un decimal représentant la conversion de pLivre en kilogramme</returns>
        private decimal LivresEnKilos(decimal pLivres)
        {
            // TODO 01A : Compléter la méthode sachant qu'il y a 2.205 livres dans un kilo 
            //            ( divisez pLivres par 2.205m)
            //            Assurez-vous d'utiliser return pour retourner le résultat approprié
            return pLivres / 2.205m;
        }
        //-------------------------------------------------------------------------------
        private void BtnLivresEnKilos_Click(object sender, EventArgs e)
        {
            lblUnitéSource.Text = "Livres";
            lblUnitéFinale.Text = "Kilos";
            // TODO 01B : En utilisant la méthode LivresEnKilos, convertir numNombre en kilo et placer le résultat dans numResultat
            numResultat.Value = LivresEnKilos(numNombre.Value);

        }
        #endregion

        #region CelsiusEnFahrenheit
        //-------------------------------------------------------------------------------
        /// <summary>
        /// Retourne la valeur en Fahrenheit d'un température exprimée en Celsius
        /// </summary>
        /// <param name="pCelsius">valeur de Celsius à convertir</param>
        /// <returns>Retourne un Decimal représentant la conversion de pCelsius en Fahrenheit</returns>
        private decimal CelsiusEnFahrenheit(decimal pCelsius)
        {
            // TODO 02A : Compléter la méthode sachant que F = C * 9/5 + 32
 			//            Assurez-vous d'utiliser return pour retourner le résultat approprié  
			return pCelsius * 9/5 +32;
        }
        //-------------------------------------------------------------------------------
        private void BtnCelsiusEnFahrenheit_Click(object sender, EventArgs e)
        {
            lblUnitéSource.Text = "Celsius";
            lblUnitéFinale.Text = "Fahrenheit";
            // TODO 02B : En utilisant la méthode CelsiusEnFahrenheit, convertir numNombre en Fahrenheit et placer le résultat dans numResultat
            numResultat.Value = CelsiusEnFahrenheit(numNombre.Value);
        }
        #endregion

        #region PoucesEnCentimètres
        //-------------------------------------------------------------------------------
        /// <summary>
        /// Retourne le résultat de la convertion d'une donnée exprimée en pouce en une valeur exprimée en centimètre
        /// </summary>
        /// <param name="pPouces">valeur en pouce à convertir</param>
        /// <returns>Retourne un Decimal représentant la conversion de pPouces en centimètre</returns>
        private decimal PoucesEnCentimètres(decimal pPouces)
        {
            // TODO 03A: Compléter la méthode sachant qu'il y a 2.54 centimètres dans un pouce
            //            ( multipliez le paramètre par 2.54m)
            //            Assurez-vous d'utiliser return pour retourner le résultat approprié
            return pPouces * 2.54m; ;
        }
        //-------------------------------------------------------------------------------
        private void BtnPoucesEnCentimètres_Click(object sender, EventArgs e)
        {
            lblUnitéSource.Text = "Pouces";
            lblUnitéFinale.Text = "Centimètres";
            // TODO 03B: En utilisant la méthode PoucesEnCentimètres, convertir numNombre en centimètre et placer le résultat dans numResultat
            numResultat.Value = PoucesEnCentimètres(numNombre.Value);
        }
        #endregion

        #region Année paire/bissextile
        /// ------------------------------------------------------------------------------------------
        /// <summary>
        /// Détermine si une année est paire ou pas.
        /// L’année est paire si le reste de sa division entière par 2 est 0
        /// </summary>
        /// <param name="pAnnee">Année à vérifier.</param>
        /// <returns>True si année est paire, false sinon.</returns>
        /// ------------------------------------------------------------------------------------------
        private bool EstPaire(int pAnnée)
        {
            // TODO 04A : Modifier la signature de la méthode pour ajouter l'année en paramètre.
            // TODO 04B : Modifier l'entête de la méthode pour retourner une valeur booléenne.
            // TODO 04C : Compléter la méthode et assurez-vous d'utiliser return pour retourner le résultat approprié
            return pAnnée % 2 == 0;
             
			 
        }
        #endregion

        #region Année bissextile
        /// ------------------------------------------------------------------------------------------
        /// <summary>
        /// Détermine si une année est bissextile ou pas.
        /// L’année est bissextile
        ///      si l’année est un multiple de 400 ou 
        ///      si l’année est un multiple 4 mais pas un multiple de 100 .
        /// </summary>
        /// <param name="pAnnee">Année à vérifier.</param>
        /// <returns>True si bissextile, false sinon.</returns>
        /// ------------------------------------------------------------------------------------------
        private bool EstBissextile(int pAnnéee)
        {
            // TODO 05A : Modifier la signature de la méthode pour ajouter l'année en paramètre.
            // TODO 05B : Modifier l'entêtre de la méthode pour retourner une valeur booléenne.
            // TODO 05C : Compléter la méthode et assurez-vous d'utiliser return pour retourner le résultat approprié
            return pAnnéee % 2 == 1;
       
	   
        }
        //-------------------------------------------------------------------------------
        private void VsiAnnée_ValueChanged(object sender, EventArgs e)
        {
            // TODO 04D : En utilisant la méthode EstPaire, allumer vsbAnnéePaire seulement si l'année est paire
            vsbAnnéePaire.Value = EstPaire(vsiAnnée.Value);

            // TODO 05D : En utilisant la méthode EstBissextile, allumer vsbAnnéeBissextile seulement si l'année est bissextile
            vsbAnnéeBissextile.Value = EstBissextile(vsiAnnée.Value);

        }
        #endregion
    }
}
