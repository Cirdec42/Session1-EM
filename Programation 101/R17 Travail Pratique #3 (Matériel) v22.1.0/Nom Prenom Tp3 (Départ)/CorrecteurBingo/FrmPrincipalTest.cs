//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace CorrecteurBingo2
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void TestMethod1()
//        {
//        }
//    }
//}
using AppBingo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using VisualArrays;
using System.Text;
using System.Linq.Expressions;

namespace CorrecteurBingo2
{
    //**********************************************************************************************************************
    //                                           REMARQUE au professeur 
    //     il faut crééer un dossier "_RésultatsÉtudiants" un niveau au dessus de la solution (le fichier .sln)
    //**********************************************************************************************************************


    /// <summary>
    ///V1.1 Modification du test C en trois parties avec un boucle pour répéter le test à cause du fait aléatoire du jeu
    ///</summary>
    [TestClass()]
    public class FrmPrincipalTest
    {

        private static String m_version = "Correcteur V20.2.2 (2020.10.01)";

        //J'ai fait vite alors ...
        //Copie des constantes du TP : deviendra un problème de mise à jour de ce correcteur
        const string NOM_JEU = "BINGO";
        const int COLONNE_MILIEU = 2;
        const int RANGÉE_MILIEU = 2;
        const int NB_VALEURS_PAR_COLONNE = 15;
        const int TAILLE_CARTE = 5; // 5 par 5
        const int NON_TROUVÉE = -1;



        //private static StreamWriter m_StreamWriter;
        //private static List<ClsDetailCorrection> m_lstDetailTest;
        #region Attributs de tests supplémentaires
        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }


        private static int m_totalScore;
        private static int m_maxScore;
        private static RapportCorrection m_rapport;

        private bool m_testD3Réussi = false;
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            m_rapport = new RapportCorrection(FrmPrincipal.APP_INFO, "TP3Bingo.txt");
            m_totalScore = 0;   //note accumulée de l'étudiant
            m_maxScore = 0;     //
        }
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            m_rapport.ProduireRapport(m_totalScore, m_maxScore, m_version);
        }
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        //==============================================================================================================
        /// <summary>
        ///Vérifier les valeurs de la carte maitresse
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO1B_VérifierValeurCarteMaitresse_12pts()
        {
            const int PONDÉRATION = 12;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = PONDÉRATION;
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO1B", "Vérifier valeur carte Maitresse", PONDÉRATION);


            FrmPrincipal target = new FrmPrincipal();
            bool leTestEstBon = true;
            int val = 1;

            try
            {
                for (int c = 0; c < target.viaCarteMaîtresse.ColumnCount; c++)
                {
                    for (int r = 0; r < target.viaCarteMaîtresse.RowCount; r++)
                    {
                        leTestEstBon &= val == target.viaCarteMaîtresse[r, c];
                        val++;
                    }
                }
                Assert.IsTrue(leTestEstBon, "Erreur d'initialisation de la carte maitresse");
            }
            catch (Exception e)
            {
                pointAccumuléSiToutBon = 0;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                throw e;
            }
            finally
            {
                m_totalScore += pointAccumuléSiToutBon;
                objCorr.PointObtenu = pointAccumuléSiToutBon;
                m_rapport.Ajouter(objCorr);
            }
        }

        //==============================================================================================================
        /// <summary>
        ///Vérifier les entêtes des 5 carte
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO1A_VérifierAppelPlacerLesEntetesDesColonnes_3pts()
        {
            const int PONDÉRATION = 3;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = PONDÉRATION;
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO1A", "Vérifier les entêtes colonne des 5 cartes", PONDÉRATION);

            try
            {
                FrmPrincipal target = new FrmPrincipal();
                String bingo = "BINGO";

                for (int col = 0; col < bingo.Length; col++)
                {
                    Assert.AreEqual(bingo[col].ToString(), target.viaCarteMaîtresse.ColumnHeaderArray[col], "Entêtes des colonne de la carte maitresse");
                    Assert.AreEqual(bingo[col].ToString(), target.viaCarte1.ColumnHeaderArray[col], "Entêtes des colonne de la carte viaCarte1");
                    Assert.AreEqual(bingo[col].ToString(), target.viaCarte2.ColumnHeaderArray[col], "Entêtes des colonne de la carte viaCarte1");
                    Assert.AreEqual(bingo[col].ToString(), target.viaCarte3.ColumnHeaderArray[col], "Entêtes des colonne de la carte viaCarte1");
                    Assert.AreEqual(bingo[col].ToString(), target.viaCarte4.ColumnHeaderArray[col], "Entêtes des colonne de la carte viaCarte1");
                }
            }
            catch (Exception e)
            {
                pointAccumuléSiToutBon = 0;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                throw e;
            }
            finally
            {
                m_totalScore += pointAccumuléSiToutBon;
                objCorr.PointObtenu = pointAccumuléSiToutBon;
                m_rapport.Ajouter(objCorr);
            }
        }

        //PréparerBoulier
        //==============================================================================================================
        /// <summary>
        ///Vérifier si les valeurs sont placées dans le boulier
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO2A_PréparerBoulier_5pts()
        {
            const int PONDÉRATION = 5;
            m_maxScore += PONDÉRATION;
            int pointAccumulé = 0;
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO2A", "Vérifier si les valeurs sont placées dans le boulier", 5);
            

            FrmPrincipal target = new FrmPrincipal();
           
            try
            {
                
                target.PréparerBoulier();
               
                for (int index = 1; index <= target.viaBoulier.Length; index++)
                {
                    Assert.IsTrue(target.viaBoulier.ContainsValue(index), "La valeur #" + index + " n'est pas placée");
                }
                pointAccumulé += 5;

                
            }
            catch (Exception e)
            {
                
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                throw e;
            }
            finally
            {
                m_totalScore += pointAccumulé;
                objCorr.PointObtenu = pointAccumulé;
                m_rapport.Ajouter(objCorr);
            }

           


        }

        //PréparerBoulier
        //==============================================================================================================
        /// <summary>
        ///Vérifier si les valeurs sont mélangées
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO2B_PréparerBoulierMixUp_3pts()
        {
            const int PONDÉRATION = 3;
            m_maxScore += PONDÉRATION;
           
            bool erreur = false;
            ClsDetailCorrection objCorrMixUp = new ClsDetailCorrection("TODO2B", "Vérifier si les valeurs sont mélangées", 3);

            FrmPrincipal target = new FrmPrincipal();
            
           

            int nbreMixUp = 0;
            int pointAccumuléMixUp = 0;
           


            try
            {
                target.PréparerBoulier();

                for (int index = 0; index < target.viaBoulier.Length; index++)
                {
                    if (target.viaBoulier.ContainsValue(index) && target.viaBoulier[index] - 1 != index)
                        nbreMixUp++;
                }
               
                Assert.IsTrue(nbreMixUp >= 5);
                pointAccumuléMixUp += 3;
            }
            catch (Exception e)
            {

                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorrMixUp.AjouterMsgErreur("bogue " + msg);
                throw e;
            }
            finally
            {
                m_totalScore += pointAccumuléMixUp;
                objCorrMixUp.PointObtenu = pointAccumuléMixUp;
                m_rapport.Ajouter(objCorrMixUp);
            }
           


        }



        //==============================================================================================================
        /// <summary>
        ///(6 pts) Rendre visible ou non les boules du boulier
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO3_MnuSpécialBoulier_Click_6pts()
        {
            const int PONDÉRATION = 6;
            m_maxScore += PONDÉRATION;
            int pointAccumulé = PONDÉRATION;
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO3", "Rendre visible ou non les boules du boulier", PONDÉRATION);
            FrmPrincipal target = new FrmPrincipal();
            // Initialisation
            bool erreur = false;
            target.viaBoulier.Visible = true;
            target.mnuSpécialBoulier.Text = "Cacher le boulier";// ;
            target.lblCarteAffichée.Text = "Contenu du boulier"; // ;

            target.Show();
            //target.viaBoulier.Visible = true;
            //mnuSpécialBoulier.Text = "Voir le boulier";
            //lblCarteAffichée.Text = "Carte Maîtresse";
            //target.viaBoulier.Visible = false;

            target.MnuSpécialBoulier_Click(null, null);

            try
            {
                Assert.IsTrue(!target.viaBoulier.Visible,"Le boulier doit être caché") ;
            }
            catch (Exception e)
            {
                pointAccumulé -= 1;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                erreur = true;
            }
            try
            {
                Assert.AreEqual(target.mnuSpécialBoulier.Text, "Voir le boulier","Le texte du menu spécial doit être -Voir le boulier-");

            }
            catch (Exception e)
            {
                pointAccumulé -= 1;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                erreur = true;
            }
            try
            {
               
                Assert.AreEqual(target.lblCarteAffichée.Text, "Carte Maîtresse", "Le texte du lblCarteAffichée doit être -Carte Maîtresse-");

            }
            catch (Exception e)
            {
                pointAccumulé -= 1;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                erreur = true;
            }
            // Tester avec viaBoulier.Visible = false
            // Initialisation
            erreur = false;
            target.viaBoulier.Visible = false;
            target.mnuSpécialBoulier.Text = "Voir le boulier";
            target.lblCarteAffichée.Text = "Carte Maîtresse";

            target.Show();
            //target.viaBoulier.Visible = true;
            //target.mnuSpécialBoulier.Text = "Cacher le boulier";// ;
            //target.lblCarteAffichée.Text = "Contenu du boulier"; // ;
           

            target.MnuSpécialBoulier_Click(null, null);

            try
            {
                Assert.IsTrue(target.viaBoulier.Visible, "Le boulier doit être visible");
            }
            catch (Exception e)
            {
                pointAccumulé -= 1;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                erreur = true;
            }
            try
            {
                Assert.AreEqual(target.mnuSpécialBoulier.Text, "Cacher le boulier", "Le texte du menu spécial doit être -Cacher le boulier-");

            }
            catch (Exception e)
            {
                pointAccumulé -= 1;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                erreur = true;
            }
            try
            {

                Assert.AreEqual(target.lblCarteAffichée.Text, "Contenu du boulier", "Le texte du lblCarteAffichée doit être -Contenu du boulier-");

            }
            catch (Exception e)
            {
                pointAccumulé -= 1;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                erreur = true;
            }

            m_totalScore += pointAccumulé;
            objCorr.PointObtenu = pointAccumulé; 
            m_rapport.Ajouter(objCorr);
            if (erreur)
                Assert.Fail();
         
        }
        //==============================================================================================================
        /// <summary>
        ///(9/15 pts) Placer les nombres sur les cartes de bingo
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO4A_PlacerNombresSurCarteDeBingoVérifierBouleDansBonneColonneCarteBingo_9pts()
        {

            const int PONDÉRATION = 9;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = PONDÉRATION;
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO4A", "Vérifier boule dans bonne colonne carte Bingo", PONDÉRATION);
            FrmPrincipal target = new FrmPrincipal();
            try
            {

                for (int nbTest = 0; nbTest < 10; nbTest++)
                {
                    target.PlacerNombresSurCarteDeBingo(target.viaCarte1);
                    Assert.IsTrue(VérifierBouleDansBonneColonne(target.viaCarte1), "Carte de bingo 1 a des valeurs pas dans la bonne colonne");
                    //Assert.IsTrue(VérifierBouleDansBonneColonne(target.viaCarte2), "Carte de bingo 2 a des valeurs pas dans la bonne colonne");
                    //Assert.IsTrue(VérifierBouleDansBonneColonne(target.viaCarte3), "Carte de bingo 3 a des valeurs pas dans la bonne colonne");
                    //Assert.IsTrue(VérifierBouleDansBonneColonne(target.viaCarte4), "Carte de bingo 4 a des valeurs pas dans la bonne colonne");
                }
            }
            catch (Exception e)
            {
                pointAccumuléSiToutBon = 0;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                throw e;
            }
            finally
            {
                m_totalScore += pointAccumuléSiToutBon;
                objCorr.PointObtenu = pointAccumuléSiToutBon;
                m_rapport.Ajouter(objCorr);
            }
        }

        //==============================================================================================================
        /// <summary>
        ///(4/15 pts) Placer les nombres sur les cartes de bingo
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO4B_PlacerNombresSurCarteDeBingoVérifierRedondanceSurUneCarteBingo_4pts()
        {
            const int PONDÉRATION = 4;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = PONDÉRATION;
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO4B", "Vérifier Redondance sur une carte Bingo", PONDÉRATION);
            FrmPrincipal target = new FrmPrincipal();
            try
            {
                for (int nbTest = 0; nbTest < 10; nbTest++)
                {
                    target.PlacerNombresSurCarteDeBingo(target.viaCarte1);
                   
                    Assert.IsTrue(VérifierRedondanceSurUneCarte(target.viaCarte1), "Carte de bingo 1 a des valeurs en double");
                   
                }
            }
            catch (Exception e)
            {
                pointAccumuléSiToutBon = 0;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                throw e;
            }
            finally
            {
                m_totalScore += pointAccumuléSiToutBon;
                objCorr.PointObtenu = pointAccumuléSiToutBon;
                m_rapport.Ajouter(objCorr);
            }
        }

        //==============================================================================================================
        /// <summary>
        //(2/15 pts) Placer les nombres sur les cartes de bingo
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO4C_PlacerNombresSurCarteDeBingoVérifierLeCentreCarteBingo_2pts()
        {

            const int PONDÉRATION = 2;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = PONDÉRATION;
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO4C", "Vérifier le centre carte Bingo", PONDÉRATION);
            FrmPrincipal target = new FrmPrincipal();
            try
            {

                target.PlacerNombresSurCarteDeBingo(target.viaCarte1);
                //Tester le centre
                Assert.AreEqual(0, target.viaCarte1[2, 2]);
                Assert.AreEqual(0, target.viaCarte2[2, 2]);
                Assert.AreEqual(0, target.viaCarte3[2, 2]);
                Assert.AreEqual(0, target.viaCarte4[2, 2]);
               

            }
            catch (Exception e)
            {
                pointAccumuléSiToutBon = 0;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                throw e;
            }
            finally
            {
                m_totalScore += pointAccumuléSiToutBon;
                objCorr.PointObtenu = pointAccumuléSiToutBon;
                m_rapport.Ajouter(objCorr);
            }
        }
        private bool VérifierRedondanceSurUneCarte(VisualIntArray pCarte)
        {
            List<int> lstValeurSurCarte = new List<int>();
            for (int c = 0; c < pCarte.ColumnCount; c++)
            {

                for (int r = 0; r < pCarte.RowCount; r++)
                {
                    if (lstValeurSurCarte.Contains(pCarte[r, c]))
                        return false;
                    lstValeurSurCarte.Add(pCarte[r, c]);
                }
            }
            return true;
        }
        private bool VérifierBouleDansBonneColonne(VisualIntArray pCarte)
        {
            for (int c = 0; c < pCarte.ColumnCount; c++)
            {
                for (int r = 0; r < pCarte.RowCount; r++)
                {
                    // regarde si boule dans la bonne colonne
                    if (!(r == 2 & c == 2)) //saute le centre
                        if (ColonneDeLaBoule(pCarte[r, c]) != c)
                        {
                            // Console.WriteLine("VérifierBouleDansBonneColonne :C=" + ColonneDeLaBoule(pCarte[r, c]) + "boule=" + pCarte[r, c]);
                            return false;

                        }
                }
            }
            return true;
        }


        //==============================================================================================================
        /// <summary>
        // (3 pts) Préparer une carte de bingo pour une nouvelle partie
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO5_PréparerCarteDeBingo_3pts()
        {

            const int PONDÉRATION = 3;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = PONDÉRATION;
            bool erreur = false;
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO5", "Préparer une carte de bingo pour une nouvelle partie", PONDÉRATION);
            FrmPrincipal target = new FrmPrincipal();
            for (int index = 0; index < NOM_JEU.Length; index++)
                target.viaCarte1.ColumnHeaderArray[index] = "Test";
            try
            {
                
                //for (int index = 0; index < NOM_JEU.Length; index++)
                //    target.viaCarte1.ColumnHeaderArray[index] = NOM_JEU[index].ToString();

                target.PréparerCarteDeBingo(target.viaCarte1);
                //Tester le centre
                for (int index = 0; index < NOM_JEU.Length; index++)
                {
                    Assert.AreEqual(target.viaCarte1.ColumnHeaderArray[index], NOM_JEU[index].ToString(), "Méthode PlacerLesEntetesDesColonnes non appelée (-1)");
                }
                

            }
            catch (Exception e)
            {
                pointAccumuléSiToutBon -= 1;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                erreur = true;
            }
            //Initialisations
            for (int index = 0; index < target.viaCarte1.Length; index++)
                target.viaCarte1[index] = 0;
            try
            {

               

                target.PréparerCarteDeBingo(target.viaCarte1);
                //Tester d'appel des méthodes
                Assert.IsTrue(VérifierBouleDansBonneColonne(target.viaCarte1), "Méthode PlacerNombresSurCarteDeBingo non appelée (-2)");
                Assert.IsTrue(VérifierRedondanceSurUneCarte(target.viaCarte1), "Méthode PlacerNombresSurCarteDeBingo non appelée (-2)");
                Assert.AreEqual(0, target.viaCarte1[2, 2], "Méthode PlacerNombresSurCarteDeBingo non appelée");

                
            }
            catch (Exception e)
            {
                pointAccumuléSiToutBon -= 2;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                erreur = true;
            }
           
                m_totalScore += pointAccumuléSiToutBon;
                objCorr.PointObtenu = pointAccumuléSiToutBon;
                m_rapport.Ajouter(objCorr);
            if (erreur)
                Assert.Fail();
            
        }

        //==============================================================================================================
        /// <summary>
        // (6 pts) Déterminer la colonne correspondant au numéro de la boule
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO6_ColonneDeLaBouleSurLaCarte_6pts()
        {

            const int PONDÉRATION = 6;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = PONDÉRATION;
            bool erreur = false;
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO6", "Déterminer la colonne correspondant au numéro de la boule", PONDÉRATION);
            FrmPrincipal target = new FrmPrincipal();
            
            try
            {
                int colonne;
                for(int numéroBoule = 1; numéroBoule < 75; numéroBoule++)
                {
                    colonne = target.ColonneDeLaBouleSurLaCarte(numéroBoule);
                    Assert.AreEqual(((numéroBoule - 1) / NB_VALEURS_PAR_COLONNE),colonne,"Colonne non valide pour la valeur #" + numéroBoule );
                }
               
            }
            catch (Exception e)
            {
                pointAccumuléSiToutBon -= 6;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                throw e;
               
            }finally
            {
                m_totalScore += pointAccumuléSiToutBon;
                objCorr.PointObtenu = pointAccumuléSiToutBon;
                m_rapport.Ajouter(objCorr);
            }
            

           
           

        }
        //==============================================================================================================
        /// <summary>
        ///16/20 Test pour btnRetirerUneBoule_Click
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO7A_RetirerUneBouleUniqueValeur_16pts()
        {

            const int PONDÉRATION = 16;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = 0;//on ajoute les points dans la boucle de tests
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO7A", "Retirer une boule unique Teste Valeur", PONDÉRATION);
            bool erreur = false, erreur1 = false,erreur2 = false,erreur3=false,erreur4=false,erreur5=false;
           
            try
            {
                FrmPrincipal target = new FrmPrincipal();
                
                for (int index = 0; index < target.viaBoulier.Length; index++)
                {

                    target.viaBoulier[index] = index + 1;
                    target.viaCarteMaîtresse.EnableCell(index);
                }
                
                //On désactive toutes les cellules

                //for (int colonne = 0; colonne < target.viaCarteMaîtresse.ColumnCount; colonne++)
                //{
                //    for (int rangée = 0; rangée < target.viaCarteMaîtresse.RowCount; rangée++)
                //        target.viaCarteMaîtresse.DisableCell(rangée, colonne);
                //}

                String bingo = "BINGO";
                for (int col = 0; col < bingo.Length; col++)
                {
                    target.vsiNbBoulesRetirées.Value = col*15;
                    target.viaBoulier.EnableCell (target.vsiNbBoulesRetirées.Value);
                    int boulRetirée = col * 15 + 1;
                    int colonne = col;
                    int rangée = 0;
                    target.viaCarteMaîtresse.EnableCell(rangée, colonne);
                    target.vscBoule.Value = '#';//NOM_JEU[colonne];
                    target.vsiBoule.Value = 0;//bouleRetirée;

                    //viaCarteMaîtresse.DisableCell(rangée, colonne);


                    //target.viaCarteMaîtresse.SetCellEnabled(0, col, true); // on active une seule cellule
                    //Donc le programme doit retirer la boule à la position [0 , col]
                    target.btnRetirerUneBouleDuBoulier_Click(null, null);

                    //On vérifie que
                    //target.Show();

                    try
                    {
                        Assert.AreEqual(target.vsiBoule.Value, boulRetirée);
                    }
                    catch
                    {
                        //pointAccumuléSiToutBon -= 2;
                        erreur1 = true;
                        string messageErreur = "La valeur affichée ne correspond pas à la boule selectionnée (-3)";
                        objCorr.AjouterMsgErreur("bogue " + messageErreur);
                    }

                    

                    //Assert.AreEqual((col * 15 + 1), target.vsiBoule.Value, "La valeur de la boule n'est pas bonne");
                    //try
                    //    {
                    //    Assert.IsFalse(target.viaBoulier.GetCellEnabled(0, col));
                    //}
                    //catch{
                    //    erreur2 = true;
                    //    string messageErreur = "La cellule n'est pas désactivée sur le boulier";
                    //    objCorr.AjouterMsgErreur("bogue " + messageErreur);
                    //}
                    try
                    {
                        Assert.IsFalse(target.viaCarteMaîtresse.GetCellEnabled(0, col));
                    }
                    catch
                    {
                        //pointAccumuléSiToutBon -= 2;
                        erreur3 = true;
                        string messageErreur = "La cellule n'est pas désactivée sur la carte maitresse (-2)";
                        objCorr.AjouterMsgErreur("bogue " + messageErreur);
                    }
                    try
                    {
                        Assert.AreEqual(target.vsiNbBoulesRetirées.Value , (col * 15 + 1));
                    }
                    catch 
                    {
                        //pointAccumuléSiToutBon -= 2;
                        erreur4 = true;
                        string messageErreur = "Le nombre de boules retirées n'est pas mis à jour (-3)";
                        objCorr.AjouterMsgErreur("bogue " + messageErreur);
                    }
                    try
                    {
                        Assert.AreEqual(target.vscBoule.Value , NOM_JEU[colonne]);
                    }
                   catch
                    {
                        //pointAccumuléSiToutBon -= 2;
                        erreur5 = true;
                        string messageErreur = "La lettre affichée ne correspond pas à la colonne (-3)";
                        objCorr.AjouterMsgErreur("bogue " + messageErreur);
                    }
                    

                    //pointAccumuléSiToutBon += 3; //5 fois 3 points
                }
                if (!erreur1) pointAccumuléSiToutBon += 4;
                //if (!erreur2) pointAccumuléSiToutBon += 2;
                if (!erreur3) pointAccumuléSiToutBon += 4;
                if (!erreur4) pointAccumuléSiToutBon += 4;
                if (!erreur5) pointAccumuléSiToutBon += 4;
               
            }
            catch (Exception e)
            {
                erreur = true;
            }
            m_totalScore += pointAccumuléSiToutBon;
            objCorr.PointObtenu = pointAccumuléSiToutBon;
            m_rapport.Ajouter(objCorr);
            if (erreur1 /* erreur2*/ || erreur3 || erreur4 || erreur5 || erreur) Assert.Fail();
               
           
        }

        //==============================================================================================================
        /// <summary>
        ///04/20 Test pour btnRetirerUneBoule_Click
        ///// Tester l'appel de la méthode TraiterLaBouleRetirée pour chaque Grille
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO7B_RetirerUneBouleAppelMéthodes_4pts()
        {

            const int PONDÉRATION = 4;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = 0;//on ajoute les points dans la boucle de tests
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO7B", "Retirer une boule Appel méthodes TraiterLaBouleRetirée", PONDÉRATION);

            FrmPrincipal target = new FrmPrincipal();
            target.viaCarte1.Clear();
            target.viaCarte2.Clear();
            target.viaCarte3.Clear();
            target.viaCarte4.Clear();
            for (int colonne = 0; colonne < target.viaCarte1.ColumnCount; colonne++)
            {
                for (int rangée = 0; rangée < target.viaCarte1.RowCount; rangée++)
                {
                    if (rangée != 2 && colonne != 2)
                    {
                        target.viaCarte1[rangée, colonne] = colonne * 15 + rangée + 1;
                        target.viaCarte1.EnableCell(rangée, colonne);
                        target.viaCarte2[rangée, colonne] = colonne * 15 + rangée + 1;
                        target.viaCarte2.EnableCell(rangée, colonne);
                        target.viaCarte3[rangée, colonne] = colonne * 15 + rangée + 1;
                        target.viaCarte3.EnableCell(rangée, colonne);
                        target.viaCarte4[rangée, colonne] = colonne * 15 + rangée + 1;
                        target.viaCarte4.EnableCell(rangée, colonne);
                    }

                }

            }
            target.vsiNbBoulesRetirées.Value = 0;
            target.viaBoulier[0] = 1;
            try
            {
               
                target.btnRetirerUneBouleDuBoulier_Click(null, null);
                Assert.IsFalse(target.viaCarte1.GetCellEnabled(0, 0), "La méthode TraiterLaBouleRetirée n'est pas appelée pour viaCarte1");
                pointAccumuléSiToutBon += 1;
                Assert.IsFalse(target.viaCarte2.GetCellEnabled(0, 0), "La méthode TraiterLaBouleRetirée n'est pas appelée pour viaCarte2");
                pointAccumuléSiToutBon += 1;
                Assert.IsFalse(target.viaCarte3.GetCellEnabled(0, 0), "La méthode TraiterLaBouleRetirée n'est pas appelée pour viaCarte3");
                pointAccumuléSiToutBon += 1;
                Assert.IsFalse(target.viaCarte4.GetCellEnabled(0, 0), "La méthode TraiterLaBouleRetirée n'est pas appelée pour viaCarte4");
                pointAccumuléSiToutBon += 1;
            }
            catch (Exception e)
            {
               
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                throw e;
            }
           finally
            {
                m_totalScore += pointAccumuléSiToutBon;
                objCorr.PointObtenu = pointAccumuléSiToutBon;
                m_rapport.Ajouter(objCorr);
            }

           
           


        }

        //==============================================================================================================
        /// <summary>
        ///6/10 TraiterLaBouleRetirée
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO8A_TraiterLaBouleRetiréeValeurTrouvée_6pts()
        {

            const int PONDÉRATION = 6;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = 0;//on ajoute les points dans la boucle de tests
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO8A", "TraiterLaBouleRetirée si valeur trouvée", PONDÉRATION);
            FrmPrincipal target = new FrmPrincipal();
            target.viaCarte1.Clear();
            for (int colonne = 0; colonne < target.viaCarte1.ColumnCount; colonne++)
            {
                for (int rangée = 0; rangée < target.viaCarte1.RowCount; rangée++)
                {
                    if (rangée != 2 && colonne != 2)
                    {
                        target.viaCarte1[rangée, colonne] = colonne * 15 + rangée + 1;
                        target.viaCarte1.EnableCell(rangée, colonne);
                    }

                }

            }
            try
            {

                for (int colonne = 0; colonne < target.viaCarte1.ColumnCount; colonne++)
                {
                    for (int rangée = 0; rangée < target.viaCarte1.RowCount; rangée++)
                    {
                        if (rangée != 2 && colonne != 2)
                        {
                            target.TraiterLaBouleRetirée(target.viaCarte1, target.viaCarte1[rangée, colonne]);
                            Assert.IsFalse(target.viaCarte1.GetCellEnabled(rangée, colonne), "La valeur #" + target.viaCarte1[rangée, colonne] + "n'est pas désactivée");
                        }
                    

                    }

                }
                
                pointAccumuléSiToutBon += PONDÉRATION;
            }
            catch(Exception e)
            {
                pointAccumuléSiToutBon += 0;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                throw e;
            }
            finally
            {
                m_totalScore += pointAccumuléSiToutBon;
                objCorr.PointObtenu = pointAccumuléSiToutBon;
                m_rapport.Ajouter(objCorr);
            }






        }

       
        //==============================================================================================================
        /// <summary>
        ///4/10 TraiterLaBouleRetirée
        ///</summary>
        //[TestMethod(), Timeout(3000)]
        //[DeploymentItem("AppBingo.exe")]
        //public void TODO8B_TraiterLaBouleRetiréeValeurNonTrouvée_4pts()
        //{

        //    const int PONDÉRATION = 4;
        //    m_maxScore += PONDÉRATION;
        //    int pointAccumuléSiToutBon = 0;//on ajoute les points dans la boucle de tests
        //    ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO8B", "TraiterLaBouleRetirée si valeur non trouvée", PONDÉRATION);
        //    FrmPrincipal target = new FrmPrincipal();
        //    target.viaCarte1.Clear();
        //    for (int colonne = 0; colonne < target.viaCarte1.ColumnCount; colonne++)
        //    {
        //        for (int rangée = 0; rangée < target.viaCarte1.RowCount; rangée++)
        //        {
        //            if (rangée == 2 && colonne == 2)
        //            {
        //            }
        //            else
        //            { 
        //                target.viaCarte1[rangée, colonne] = colonne * 15 + rangée + 1;
        //                target.viaCarte1.EnableCell(rangée, colonne);
        //            }

        //        }

        //    }
        //    try
        //    {
        //        target.TraiterLaBouleRetirée(target.viaCarte1, 75);

        //        for (int colonne = 0; colonne < target.viaCarte1.ColumnCount; colonne++)
        //        {
        //            for (int rangée = 0; rangée < target.viaCarte1.RowCount; rangée++)
        //            {
        //                if (rangée == 2 && colonne == 2)
        //                {
        //                }
        //                else
        //                {
        //                    Assert.IsTrue(target.viaCarte1.GetCellEnabled(rangée,colonne), "La valeur #" + target.viaCarte1[rangée,colonne] + "ne doit pas être désactivée");
        //                }
        //            }


                   

        //        }
               
        //        pointAccumuléSiToutBon += PONDÉRATION;
        //    }
        //    catch (Exception e)
        //    {
        //        pointAccumuléSiToutBon += 0;
        //        String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
        //        objCorr.AjouterMsgErreur("bogue " + msg);
        //        throw e;
        //    }
        //    finally
        //    {
        //        m_totalScore += pointAccumuléSiToutBon;
        //        objCorr.PointObtenu = pointAccumuléSiToutBon;
        //        m_rapport.Ajouter(objCorr);
        //    }






        //}

        //==============================================================================================================
        /// <summary>
        ///4/10 TraiterLaBouleRetirée
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO8B_TraiterLaBouleRetiréeBingo_4pts()
        {

            const int PONDÉRATION = 4;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = 0;//on ajoute les points dans la boucle de tests
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO8B", "TraiterLaBouleRetirée si avec Bingo", PONDÉRATION);
            FrmPrincipal target = new FrmPrincipal();
            target.viaCarte1.Clear();
            for (int colonne = 0; colonne < target.viaCarte1.ColumnCount; colonne++)
            {
                for (int rangée = 0; rangée < target.viaCarte1.RowCount; rangée++)
                {
                    if (rangée == 2 && colonne == 2) { }
                        else
                    {
                        target.viaCarte1[rangée, colonne] = colonne * 15 + rangée + 1;
                        target.viaCarte1.DisableCell(rangée, colonne);
                        if (rangée == colonne || (rangée +colonne) == 4)
                        {
                            
                            target.viaCarte1.EnableCell(rangée, colonne);
                        }
                    }
                    

                }

            }
            target.btnRetirer.Enabled = true;
            try
            {
                target.TraiterLaBouleRetirée(target.viaCarte1, target.viaCarte1[0, 0]);
                
                Assert.IsFalse(target.btnRetirer.Enabled, "Un bingo non détecté");
                 

                pointAccumuléSiToutBon += 4;
            }
            catch (Exception e)
            {
                pointAccumuléSiToutBon += 0;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                throw e;
            }
            finally
            {
                m_totalScore += pointAccumuléSiToutBon;
                objCorr.PointObtenu = pointAccumuléSiToutBon;
                m_rapport.Ajouter(objCorr);
            }






        }
        //==============================================================================================================
        /// <summary>
        /// (3/15 pts) Vérifier si une bingo existe sur carte
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO9A_BingoExisteSurLaCarteRangée_3pts()
        {

            const int PONDÉRATION = 3;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = 0;//on ajoute les points dans la boucle de tests
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO9A", "Vérifier si un bingo existe sur une rangée sur la carte", PONDÉRATION);
            FrmPrincipal target = new FrmPrincipal();

            try
            {
                for (int rangée = 0; rangée < target.viaCarte1.RowCount; rangée++)
                {
                    if (rangée != 2)
                    {
                        target.viaCarte1.Clear();
                        bool a = target.viaCarte1.GetCellEnabled(0, 0);
                        for (int colonne = 0; colonne < target.viaCarte1.ColumnCount; colonne++)
                        {
                            target.viaCarte1.DisableCell(rangée, colonne);
                        }

                        Assert.IsTrue(target.BingoExisteSurLaCarte(target.viaCarte1),"Bingo non vérifié sur la rangée #" + rangée);
                    }

                }
                pointAccumuléSiToutBon += PONDÉRATION;
            }
            catch(Exception e)
            {
                pointAccumuléSiToutBon = 0;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                throw e;
            }
            finally
            {
                m_totalScore += pointAccumuléSiToutBon;
                objCorr.PointObtenu = pointAccumuléSiToutBon;
                
                m_rapport.Ajouter(objCorr);
               //if (pointAccumuléSiToutBon != PONDÉRATION) Assert.Fail();
            }
               
            
            

        }

        //==============================================================================================================
        /// <summary>
        /// (2/15 pts) Vérifier si une bingo existe sur carte
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO9B_BingoExisteSurLaCarteRangéeMilieu_2pts()
        {

            const int PONDÉRATION = 2;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = 0;//on ajoute les points dans la boucle de tests
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO9B", "Vérifier si un bingo existe sur la rangée du milieu sur la carte", PONDÉRATION);
            FrmPrincipal target = new FrmPrincipal();

            try
            {
               
                        target.viaCarte1.Clear();
                        bool a = target.viaCarte1.GetCellEnabled(0, 0);
                        for (int colonne = 0; colonne < target.viaCarte1.ColumnCount; colonne++)
                        {
                            if(colonne != 2) target.viaCarte1.DisableCell(2, colonne);
                        }

                        Assert.IsTrue(target.BingoExisteSurLaCarte(target.viaCarte1), "Bingo non vérifié sur la rangée #2");
                    

                pointAccumuléSiToutBon += PONDÉRATION;
            }
            catch (Exception e)
            {
                pointAccumuléSiToutBon = 0;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                throw e;
            }
            finally
            {
                m_totalScore += pointAccumuléSiToutBon;
                objCorr.PointObtenu = pointAccumuléSiToutBon;

                m_rapport.Ajouter(objCorr);
                //if (pointAccumuléSiToutBon != PONDÉRATION) Assert.Fail();
            }




        }
        //==============================================================================================================
        /// <summary>
        /// (3/15 pts) Vérifier si une bingo existe sur carte
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO9C_BingoExisteSurLaCarteColonne_3pts()
        {

            const int PONDÉRATION = 3;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = 0;//on ajoute les points dans la boucle de tests
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO9C", "Vérifier si un bingo existe sur une colonne sur la carte", PONDÉRATION);
            FrmPrincipal target = new FrmPrincipal();

            try
            {

                for (int colonne = 0; colonne < target.viaCarte1.ColumnCount; colonne++)
                {
                    if (colonne != 2)
                    {
                        target.viaCarte1.Clear();
                        bool a = target.viaCarte1.GetCellEnabled(0, 0);
                        for (int rangée = 0; rangée < target.viaCarte1.RowCount; rangée++)
                        {
                            target.viaCarte1.DisableCell(rangée, colonne);
                        }

                        Assert.IsTrue(target.BingoExisteSurLaCarte(target.viaCarte1), "Bingo non vérifié sur la colonne #" + colonne);
                    }

                }
                pointAccumuléSiToutBon += PONDÉRATION;
            }
            catch (Exception e)
            {
                pointAccumuléSiToutBon = 0;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                throw e;
            }
            finally
            {
                m_totalScore += pointAccumuléSiToutBon;
                objCorr.PointObtenu = pointAccumuléSiToutBon;

                m_rapport.Ajouter(objCorr);
                //if (pointAccumuléSiToutBon != PONDÉRATION) Assert.Fail();
            }




        }

        //==============================================================================================================
        /// <summary>
        /// (2/15 pts) Vérifier si une bingo existe sur carte
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO9D_BingoExisteSurLaCarteColonneeMilieu_2pts()
        {

            const int PONDÉRATION = 2;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = 0;//on ajoute les points dans la boucle de tests
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO9D", "Vérifier si un bingo existe sur la colonne du milieu sur la carte", PONDÉRATION);
            FrmPrincipal target = new FrmPrincipal();

            try
            {

                target.viaCarte1.Clear();
                bool a = target.viaCarte1.GetCellEnabled(0, 0);
                for (int rangée = 0; rangée < target.viaCarte1.RowCount; rangée++)
                {
                    if (rangée != 2) target.viaCarte1.DisableCell(rangée, 2);
                }

                Assert.IsTrue(target.BingoExisteSurLaCarte(target.viaCarte1), "Bingo non vérifié sur la colonne #2");


                pointAccumuléSiToutBon += PONDÉRATION;
            }
            catch (Exception e)
            {
                pointAccumuléSiToutBon = 0;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                throw e;
            }
            finally
            {
                m_totalScore += pointAccumuléSiToutBon;
                objCorr.PointObtenu = pointAccumuléSiToutBon;

                m_rapport.Ajouter(objCorr);
                //if (pointAccumuléSiToutBon != PONDÉRATION) Assert.Fail();
            }




        }

        //==============================================================================================================
        /// <summary>
        /// (3/15 pts) Vérifier si une bingo existe sur carte
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO9E_BingoExisteSurLaCarteDiagonale_3pts()
        {

            const int PONDÉRATION = 3;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = 0;//on ajoute les points dans la boucle de tests
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO9E", "Vérifier si un bingo existe sur la diagonale #1", PONDÉRATION);
            FrmPrincipal target = new FrmPrincipal();

            try
            {
                target.viaCarte1.Clear();
                for (int rangée = 0; rangée < target.viaCarte1.RowCount; rangée++)
                {
                    for (int colonne = 0; colonne < target.viaCarte1.ColumnCount; colonne++)

                    {
                        if(rangée == colonne) target.viaCarte1.DisableCell(rangée, colonne);
                    }
                }
                    

                Assert.IsTrue(target.BingoExisteSurLaCarte(target.viaCarte1), "Bingo non vérifié sur la diagonale  #1");
                   
                pointAccumuléSiToutBon += PONDÉRATION;
            }
            catch (Exception e)
            {
                pointAccumuléSiToutBon = 0;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                throw e;
            }
            finally
            {
                m_totalScore += pointAccumuléSiToutBon;
                objCorr.PointObtenu = pointAccumuléSiToutBon;

                m_rapport.Ajouter(objCorr);
                //if (pointAccumuléSiToutBon != PONDÉRATION) Assert.Fail();
            }




        }

        //==============================================================================================================
        /// <summary>
        /// (2/15 pts) Vérifier si une bingo existe sur carte
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO9F_BingoExisteSurLaCarteDiagonale_2pts()
        {

            const int PONDÉRATION = 2;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = 0;//on ajoute les points dans la boucle de tests
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO9F", "Vérifier si un bingo existe sur la diagonale #2", PONDÉRATION);
            FrmPrincipal target = new FrmPrincipal();

            try
            {
                target.viaCarte1.Clear();
                for (int rangée = 0; rangée < target.viaCarte1.RowCount; rangée++)
                {
                    for (int colonne = 0; colonne < target.viaCarte1.ColumnCount; colonne++)

                    {
                        if (rangée+colonne == 4) target.viaCarte1.DisableCell(rangée, colonne);
                    }
                }


                Assert.IsTrue(target.BingoExisteSurLaCarte(target.viaCarte1), "Bingo non vérifié sur la diagonale  #2");

                pointAccumuléSiToutBon += PONDÉRATION;
            }
            catch (Exception e)
            {
                pointAccumuléSiToutBon = 0;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                throw e;
            }
            finally
            {
                m_totalScore += pointAccumuléSiToutBon;
                objCorr.PointObtenu = pointAccumuléSiToutBon;

                m_rapport.Ajouter(objCorr);
                //if (pointAccumuléSiToutBon != PONDÉRATION) Assert.Fail();
            }




        }

        //==============================================================================================================
        /// <summary>
        /// (2 pts) Ajuster l'état du formulaire conséquemment avec la démo
        ///</summary>
        [TestMethod(), Timeout(3000)]
        [DeploymentItem("AppBingo.exe")]
        public void TODO_10_PréparerUneNouvellePartieAjusterFormulaire_2pts()
        {

            const int PONDÉRATION = 2;
            m_maxScore += PONDÉRATION;
            int pointAccumuléSiToutBon = 0;//on ajoute les points dans la boucle de tests
            ClsDetailCorrection objCorr = new ClsDetailCorrection("TODO10", "Ajuster l'état du formulaire conséquemment avec la démo", PONDÉRATION);
            FrmPrincipal target = new FrmPrincipal();
          
            target.vscBoule.Value = '#';
            target.vsiBoule.Value = 10;
            target.vsiNbBoulesRetirées.Value = 10;
            target.btnRetirer.Enabled = false;
            try
            {
                target.PréparerUneNouvellePartie();
                

                Assert.AreEqual(target.vscBoule.Value,' ');
                Assert.AreEqual(target.vsiBoule.Value,0);
                Assert.AreEqual(target.vsiNbBoulesRetirées.Value , 0);
                Assert.AreEqual(target.btnRetirer.Enabled , true);
                pointAccumuléSiToutBon += PONDÉRATION;
            }
            catch (Exception e)
            {
                pointAccumuléSiToutBon = 0;
                String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
                objCorr.AjouterMsgErreur("bogue " + msg);
                throw e;
            }
            finally
            {
                m_totalScore += pointAccumuléSiToutBon;
                objCorr.PointObtenu = pointAccumuléSiToutBon;

                m_rapport.Ajouter(objCorr);
                
            }




        }
        ////==============================================================================================================
        ///// <summary>
        /////Test pour btnRetirerUneBoule_Click
        /////</summary>
        //[TestMethod(), Timeout(3000)]
        //[DeploymentItem("AppBingo.exe")]
        //public void D2_RetirerUneBouleUniqueLettre_5pts()
        //{

        //    const int PONDÉRATION = 5;
        //    m_maxScore += PONDÉRATION;
        //    int pointAccumuléSiToutBon = 0;//on ajoute les points dans la boucle de tests
        //    ClsDetailCorrection objCorr = new ClsDetailCorrection("D2", "Retirer une boule unique Teste Lettre", PONDÉRATION);

        //    try
        //    {
        //        FrmPrincipal target = new FrmPrincipal();
        //        String bingo = "BINGO";

        //        for (int colonneActive = 0; colonneActive < bingo.Length; colonneActive++)
        //        {
        //            //On désactive toutes les colonnes sauf une à chaque itération
        //            for (int colonneCible = 0; colonneCible < target.viaCarteMaîtresse.ColumnCount; colonneCible++)
        //            {
        //                if (colonneCible != colonneActive)
        //                {
        //                    for (int rangée = 0; rangée < target.viaCarteMaîtresse.RowCount; rangée++)
        //                        target.viaCarteMaîtresse.DisableCell(rangée, colonneCible);
        //                }
        //                else
        //                {
        //                    for (int rangée = 0; rangée < target.viaCarteMaîtresse.RowCount; rangée++)
        //                        target.viaCarteMaîtresse.EnableCell(rangée, colonneCible);
        //                }
        //            }

        //            //Donc le programme doit retirer la boule de la colonne active 
        //            //et on arrête lorsque l'on a retiré au moins 3 boule et un multiple de 15 (la dernière rangée qui est problématique)
        //            int cptBouleRetirée = 0;
        //            bool okOnAUnMultipleDe15 = false;
        //            do
        //            {
        //                target.btnRetirerUneBouleDuBoulier_Click(null, null);
        //                cptBouleRetirée++;
        //                okOnAUnMultipleDe15 = target.vscBoule.Value % 15 == 0;
        //                Assert.AreEqual(bingo[colonneActive], target.vscBoule.Value, target.vscBoule.Value + " " + target.vsiBoule.Value + " :La lettre de la boule n'est pas bonne");
        //            } while (cptBouleRetirée < 3 && !okOnAUnMultipleDe15);

        //            pointAccumuléSiToutBon += 1;
        //        }

        //    }
        //    catch (Exception e)
        //    {

        //        String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
        //        objCorr.AjouterMsgErreur("bogue " + msg);
        //        throw e;
        //    }
        //    finally
        //    {
        //        m_totalScore += pointAccumuléSiToutBon;
        //        objCorr.PointObtenu = pointAccumuléSiToutBon;
        //        m_rapport.Ajouter(objCorr);
        //    }
        //}
        //==============================================================================================================
        /// <summary>
        /////Test pour btnRetirerUneBoule_Click
        /////</summary>
        //[TestMethod(), Timeout(3000)]
        //[DeploymentItem("AppBingo.exe")]
        //public void D3_TirerBouleDésactiverCaseCarteMaitresse_5pts()
        //{

        //    const int PONDÉRATION = 5;
        //    m_maxScore += PONDÉRATION;
        //    int pointAccumuléSiToutBon = 0;//on ajoute les points dans la boucle de tests
        //    ClsDetailCorrection objCorr = new ClsDetailCorrection("D3", "Tirer boule Désactiver case carte Maitresse", PONDÉRATION);

        //    try
        //    {
        //        FrmPrincipal target = new FrmPrincipal();
        //        //On désactive toutes les cellules sauf une
        //        //for (int colonne = 0; colonne < target.viaCarteMaîtresse.ColumnCount; colonne++)
        //        //{
        //        //    for (int rangée = 0; rangée < target.viaCarteMaîtresse.RowCount; rangée++)
        //        //        target.viaCarteMaîtresse.DisableCell(rangée, colonne);
        //        //}

        //        String bingo = "BINGO";
        //        //for (int col = 0; col < bingo.Length; col++)
        //        //{
        //        //    target.viaCarteMaîtresse.SetCellEnabled(0, col, true);
        //        //    //Donc le programme doit retirer la boule de la rangée 0 , col
        //        //    target.btnRetirerUneBoule_Click(null, null);
        //        //    Assert.IsFalse(target.viaCarteMaîtresse.GetCellEnabled(0, col), "La cellule devrait être désactivée après avoir tiré une boule");
        //        //    pointAccumuléSiToutBon += 1;
        //        //}
        //        for (int colonneActive = 0; colonneActive < bingo.Length; colonneActive++)
        //        {
        //            //On désactive toutes les colonnes sauf une à chaque itération
        //            for (int colonneCible = 0; colonneCible < target.viaCarteMaîtresse.ColumnCount; colonneCible++)
        //            {
        //                if (colonneCible != colonneActive)
        //                {
        //                    for (int rangée = 0; rangée < target.viaCarteMaîtresse.RowCount; rangée++)
        //                        target.viaCarteMaîtresse.DisableCell(rangée, colonneCible);
        //                }
        //                else
        //                {
        //                    for (int rangée = 0; rangée < target.viaCarteMaîtresse.RowCount; rangée++)
        //                        target.viaCarteMaîtresse.EnableCell(rangée, colonneCible);
        //                }
        //            }

        //            //Donc le programme doit retirer la boule de la colonne active 
        //            target.btnRetirerUneBouleDuBoulier_Click(null, null);


        //            int row = RangéeDeLaBouleSurLaCarte(target.viaCarteMaîtresse, target.vsiBoule.Value);
        //            String msg = "La cellule[" + row + "," + colonneActive + "] devrait être désactivée après avoir tiré une boule:" + target.vsiBoule.Value;
        //            Assert.IsFalse(target.viaCarteMaîtresse.GetCellEnabled(row, colonneActive), msg);


        //            pointAccumuléSiToutBon += 1;
        //        }
        //        m_testD3Réussi = true;
        //    }
        //    catch (Exception e)
        //    {

        //        String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
        //        objCorr.AjouterMsgErreur("bogue " + msg);
        //        throw e;
        //    }
        //    finally
        //    {
        //        m_totalScore += pointAccumuléSiToutBon;
        //        objCorr.PointObtenu = pointAccumuléSiToutBon;
        //        m_rapport.Ajouter(objCorr);
        //    }
        //}
       
        //==============================================================================================================
        ///---------------------------------------------------------------------------------
        /// <summary>
        ///Test pour vérifier que toutes les boules tirées on été cochées sur les cartes
        ///</summary>

        //[TestMethod(), Timeout(3000)]
        //[DeploymentItem("AppBingo.exe")]
        //public void F_VérifierBoulesSurCartesBingo_25pts()
        //{

        //    const int PONDÉRATION = 25;
        //    m_maxScore += PONDÉRATION;
        //    int pointAccumuléSiToutBon = PONDÉRATION;
        //    ClsDetailCorrection objCorr = new ClsDetailCorrection("F", "Vérifier boules sur cartes Bingo", PONDÉRATION);

        //    try
        //    {
        //        FrmPrincipal target = new FrmPrincipal();

        //        //Jouer jusqu'à un Bingo ou avoir tiré 40 boules (en cas de boucle infinie)
        //        int cptBoule = 0;
        //        while (target.btnRetirer.Enabled && cptBoule < 40)
        //        {
        //            target.btnRetirerUneBouleDuBoulier_Click(null, null);
        //            cptBoule++;
        //        }
        //        //Le cas tirée une boule et cocher la carte maitresse a été corrigé, donc ici
        //        //on vérifie si le les boules marquées sur la carte maitresse sont marquées sur les cartes de jeux.
        //        //Il est possible qu'un étudiant réussise ce test même après un échec avec D3_TirerBouleDésactiverCaseCarteMaitresse_5pts

        //        int cptBoulesCochées = 0;
        //        //cptBoulesCochées devrait être égale au cptBoule si l'étudiant avait passé le test D3
        //        //sinon le cptBoulesCochées devrait au moins > 50% de cptBoule. Tout ceci pour contrer un étudiant
        //        //qui a pas fait tirer une boule et que le correcteur lui donnait tout ses points dans ce test.


        //        //Vérifier que chaque boule tirée a été cochée sur les cartes.
        //        for (int colonne = 0; colonne < target.viaCarteMaîtresse.ColumnCount; colonne++)
        //        {
        //            for (int rangée = 0; rangée < target.viaCarteMaîtresse.RowCount; rangée++)
        //            {
        //                if (!target.viaCarteMaîtresse.GetCellEnabled(rangée, colonne))
        //                {
        //                    cptBoulesCochées++;
        //                    Assert.IsTrue(VérifierQueLaBouleEstCochée(target.viaCarte1, target.viaCarteMaîtresse[rangée, colonne]), "Une boule n'est pas cochée sur Carte Bingo1");
        //                    Assert.IsTrue(VérifierQueLaBouleEstCochée(target.viaCarte2, target.viaCarteMaîtresse[rangée, colonne]), "Une boule n'est pas cochée sur Carte Bingo2");
        //                    Assert.IsTrue(VérifierQueLaBouleEstCochée(target.viaCarte3, target.viaCarteMaîtresse[rangée, colonne]), "Une boule n'est pas cochée sur Carte Bingo3");
        //                    Assert.IsTrue(VérifierQueLaBouleEstCochée(target.viaCarte4, target.viaCarteMaîtresse[rangée, colonne]), "Une boule n'est pas cochée sur Carte Bingo4");
        //                }
        //            }
        //        }

        //        if (m_testD3Réussi)
        //            Assert.AreEqual(cptBoule, cptBoulesCochées, "Le nombre de boule tirées et cochées est différent");
        //        else
        //            Assert.IsTrue(cptBoulesCochées >= 0.5 * cptBoule, "Le nombre de boule tirées et cochées est différent");

        //    }
        //    catch (Exception e)
        //    {
        //        pointAccumuléSiToutBon = 0;
        //        String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
        //        objCorr.AjouterMsgErreur("bogue " + msg);
        //        throw e;
        //    }
        //    finally
        //    {
        //        m_totalScore += pointAccumuléSiToutBon;
        //        objCorr.PointObtenu = pointAccumuléSiToutBon;
        //        m_rapport.Ajouter(objCorr);
        //    }
        //}

       
        //==============================================================================================================
        //Vérifier que le sprSegment est bien placé.
        /// <summary>
        ///Test pour vérifier que toutes les boules tirées on été cochées sur les cartes
        ///</summary>
        //[TestMethod(), Timeout(3000)]
        //[DeploymentItem("AppBingo.exe")]
        //public void G_VérifierSprSegmentBienPlacé_15pts()
        //{

        //    const int PONDÉRATION = 15;
        //    m_maxScore += PONDÉRATION;
        //    int pointAccumuléSiToutBon = PONDÉRATION;
        //    ClsDetailCorrection objCorr = new ClsDetailCorrection("G", "Vérifier SprSegment bien placé", PONDÉRATION);

        //    try
        //    {
        //        FrmPrincipal target = new FrmPrincipal();

        //        //Jouer jusqu'à un Bingo ou avoir tiré 75 boules
        //        int cptBoule = 0;
        //        while (target.btnRetirer.Enabled && cptBoule < 75)
        //        {
        //            target.btnRetirerUneBouleDuBoulier_Click(null, null);
        //            cptBoule++;
        //        }

        //        bool auMoinsUnBingoExiste = false;
        //        if (BingoExiste(target.viaCarte1))
        //        {
        //            AssertQueSprSegmentEstBon(target.viaCarte1);
        //            auMoinsUnBingoExiste = true;
        //        }
        //        else
        //        {
        //            Assert.IsFalse(target.viaCarte1.Sprites[0].Visible);
        //        }

        //        if (BingoExiste(target.viaCarte2))
        //        {
        //            AssertQueSprSegmentEstBon(target.viaCarte2);
        //            auMoinsUnBingoExiste = true;
        //        }
        //        else
        //        {
        //            Assert.IsFalse(target.viaCarte2.Sprites[0].Visible);
        //        }
        //        if (BingoExiste(target.viaCarte3))
        //        {
        //            AssertQueSprSegmentEstBon(target.viaCarte3);
        //            auMoinsUnBingoExiste = true;
        //        }
        //        else
        //        {
        //            Assert.IsFalse(target.viaCarte3.Sprites[0].Visible);

        //        }

        //        if (BingoExiste(target.viaCarte4))
        //        {
        //            AssertQueSprSegmentEstBon(target.viaCarte4);
        //            auMoinsUnBingoExiste = true;
        //        }
        //        else
        //        {
        //            Assert.IsFalse(target.viaCarte4.Sprites[0].Visible);
        //        }
        //        Assert.IsTrue(auMoinsUnBingoExiste, "Il devrait avoir au moins un BINGO");

        //    }
        //    catch (Exception e)
        //    {
        //        pointAccumuléSiToutBon = 0;
        //        String msg = e.Message.Substring(e.Message.LastIndexOf(".") + 1);
        //        objCorr.AjouterMsgErreur("bogue " + msg);
        //        throw e;
        //    }
        //    finally
        //    {
        //        m_totalScore += pointAccumuléSiToutBon;
        //        objCorr.PointObtenu = pointAccumuléSiToutBon;
        //        m_rapport.Ajouter(objCorr);
        //    }
        //}

        private void AssertQueSprSegmentEstBon(VisualIntArray pCarte)
        {
            SegmentSprite segSprite = (SegmentSprite)pCarte.Sprites[0];
            Assert.IsTrue(segSprite.Visible);
            Address source = segSprite.DisplayAddress;
            Address destination = segSprite.DestinationAddress;

            int dplRow = 0; int dplCol = 0;
            if (source.Row < destination.Row)
                dplRow = 1;
            else if (source.Row > destination.Row)
                dplRow = -1;

            if (source.Column < destination.Column)
                dplCol = 1;
            else if (source.Column > destination.Column)
                dplCol = -1;

            Assert.IsTrue(SuiteGagante(pCarte, source.Row, source.Column, dplRow, dplCol), "Bogue avec SuiteGagante[" + source.Row + "," + source.Column + "]" + dplRow + ":" + dplCol);

        }

        /// <summary>
        /// Détermine si un Bingo existe sur une carte. Cette méthode effectue plusieurs appels à la méthode SuiteGagnante
        /// </summary>
        /// <param name="pCarte">Carte à vérifier</param>
        /// <returns>Vrai, si un Bingo existe sur cette carte</returns>
        private bool BingoExiste(VisualIntArray pCarte)
        {

            for (int rangée = 0; rangée < pCarte.RowCount; rangée++)
                if (SuiteGagante(pCarte, rangée, 0, 0, 1))
                {
                    return true;
                }

            for (int colonne = 0; colonne < pCarte.ColumnCount; colonne++)
                if (SuiteGagante(pCarte, 0, colonne, 1, 0))
                {
                    return true;

                }

            if (SuiteGagante(pCarte, 0, 0, 1, 1))
            {
                return true;
            }

            if (SuiteGagante(pCarte, 0, pCarte.ColumnCount - 1, 1, -1))
            {
                return true;
            }

            return false;
        }


        #region Méthodes utilitaires empruntées de la solution
        ///===========================================================================================
        /// <summary>
        /// Permet de déterminer si une suite gagnante existe sur une carte en tenant compte des coordonnées
        /// passées en paramètres.
        /// </summary>
        /// <param name="pCarte">Carte à vérifier</param>
        /// <param name="pRow">Rangée de départ</param>
        /// <param name="pCol">Colonne de départ</param>
        /// <param name="pDplRow">Déplacement en terme de rangée</param>
        /// <param name="pDplCol">Déplacement en terme de colonne</param>
        /// <returns>Vrai, si une suite gagnante existe sur la carte</returns>
        private bool SuiteGagante(VisualIntArray pCarte, int pRow, int pCol, int pDplRow, int pDplCol)
        {
            for (int position = 0; position < TAILLE_CARTE; position++)
            {
                if ((pRow != RANGÉE_MILIEU || pCol != COLONNE_MILIEU) && pCarte.GetCellEnabled(pRow, pCol)) return false;
                pRow += pDplRow;
                pCol += pDplCol;
            }
            return true;
        }
        /// ===========================================================================================
        /// <summary>
        /// Permet de marquer si possible la boule sur la carte et de vérifier si cela provoque un bingo
        /// </summary>
        /// <param name="pCarte">Carte à traiter</param>
        /// <param name="pBoule">Numéro de la boule entre 1 et 75</param>
        private bool VérifierQueLaBouleEstCochée(VisualIntArray pCarte, int pBoule)
        {
            // marquer la boule sur la carte
            int colonne = ColonneDeLaBoule(pBoule);
            int rangée = RangéeDeLaBouleSurLaCarte(pCarte, pBoule);
            if (rangée == NON_TROUVÉE)
                return true;//cette boule n'est pas sur la carte alors rien à cocher

            return !pCarte.GetCellEnabled(rangée, colonne);

        }

        ///==========================================================================================
        /// <summary>
        /// Permet de calculer la colonne correspondante à la valeur d'une boule.
        /// </summary>
        /// <param name="pBoule">Un numéro de boule entre 1 et 75</param>
        /// <returns>Un numéro de colonne de base 0 en fonction de la boule</returns>
        private int ColonneDeLaBoule(int pBoule)
        {
            return (pBoule - 1) / 15;
        }
        ///==========================================================================================
        /// <summary>
        /// Détermine si une boule se retrouve sur une carte, si oui alors on retourne le numéro de la rangée
        /// ou la boule à été trouvée.
        /// </summary>
        /// <param name="pCarte">Carte à vérifier</param>
        /// <param name="pBoule">Numéro d'une boule entre 1 et 75</param>
        /// <returns>Numéro de la rangée de base 0</returns>
        private int RangéeDeLaBouleSurLaCarte(VisualIntArray pCarte, int pBoule)
        {
            int colonne = ColonneDeLaBoule(pBoule);
            for (int rangée = 0; rangée < pCarte.RowCount; rangée++)
                if (pCarte[rangée, colonne] == pBoule)
                    return rangée;
            return NON_TROUVÉE;
        }
    }
    #endregion


}
