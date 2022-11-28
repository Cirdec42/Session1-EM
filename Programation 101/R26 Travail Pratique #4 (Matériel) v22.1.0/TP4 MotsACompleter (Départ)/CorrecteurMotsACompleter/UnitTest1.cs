using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppJeuEntrecroises;

namespace CorrecteurMotsACompleter

{

    [TestClass]
    public class UnitTest1
    {
        public const int MAX_MOTS = 10;
        private static int m_totalScore;
        private static int m_maxScore;
        private string[] m_tabNomFichiers = { "Mots divers", "Mots en AI", "Mots en OU", "Mots en UI" };
        private static String[,] m_tabLignes = new String[MAX_MOTS,3];
        private static String[] m_tabMots = new String[MAX_MOTS];
        private static int[] m_tabPositions = new int[MAX_MOTS];
        private static int m_nbMots;
        private static int m_nbFichiers;
        private static string[] m_tabSrcFichiers;//contient les noms de fichier

        public const int INDEX_COL_DESCRIPTION = 0;
        public const int INDEX_COL_MOT = 1;
        public const int INDEX_COL_POSITION = 2;
        //  private static string m_messageErreur = "";

        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {

            m_totalScore = 0;//note accumulée de l'étudiant
            m_maxScore = 0;

            m_tabSrcFichiers = Directory.GetFiles("Mots");
            m_nbFichiers = m_tabSrcFichiers.Length;
        }
        [ClassCleanup()]
        public static void MyClassCleanup()
        {

            MessageBox.Show(m_totalScore + "/" + m_maxScore);
        }
        #region Construire tabbleaux

        private static void TraiterUnFichier(int pnumFichier)
        {
              StreamReader fic = new StreamReader(m_tabSrcFichiers[pnumFichier]);
              string chaineFic = fic.ReadToEnd();
              fic.Close();
              string[] tabFic = chaineFic.Split('\n');
              InitialiserTableaux(tabFic);
         }
        private static void InitialiserTableaux(string[] ptabDonnées)
        {
            //FrmPrincipal target = new FrmPrincipal();
            m_nbMots = ptabDonnées.Length;
            if (ptabDonnées.Length > MAX_MOTS)
                m_nbMots = MAX_MOTS;
          
            for (int index = 0; index < m_nbMots  ; index++)
            {
                m_tabLignes[index,INDEX_COL_DESCRIPTION] = ptabDonnées[index].Split('|')[0];
                m_tabLignes[index,INDEX_COL_MOT] = ptabDonnées[index].Split('|')[1].ToUpper();
                m_tabLignes[index,INDEX_COL_POSITION] = int.Parse(ptabDonnées[index].Split('|')[2]).ToString();

                

            }
           
        }
        #endregion
       

       



        [TestMethod]
        public void TestChargerLesLignesDuFichier()
        {
           

            bool[] tabErreursMots = { false, false, false, false, false, false, false, false, false, false };
            bool[] tabErreursDesc = { false, false, false, false, false, false, false, false, false, false };
            bool[] tabErreursPosition = { false, false, false, false, false, false, false, false, false, false };
            m_maxScore += 30;
            int nbPointsObtenus = 30;
            FrmPrincipal target = new FrmPrincipal(1);
           
            
            for (int index = 0; index < m_nbFichiers; index++)
            {
                TraiterUnFichier(index);
                target.cboListeFichiers.SelectedIndex = index;
                target.ChargerLesLignesDuFichier();
                
                

                for (int indice = 0; indice < m_nbMots; indice++)
                {
                    try
                    {
                        Assert.AreEqual(m_tabLignes[indice,INDEX_COL_DESCRIPTION], target.m_tabLignes[indice,INDEX_COL_DESCRIPTION]);
                    }
                    catch
                    {

                        if (!tabErreursDesc[indice])
                        {
                            tabErreursDesc[indice] = true;
                            nbPointsObtenus -= 1;
                        }

                    }
                    try
                    {
                        Assert.AreEqual(m_tabLignes[indice,INDEX_COL_MOT].ToUpper(), target.m_tabLignes[indice,INDEX_COL_MOT]);
                    }
                    catch
                    {
                        if (!tabErreursMots[indice])
                        {
                            tabErreursMots[indice] = true;
                            nbPointsObtenus -= 1;
                        }

                    }
                    try
                    {
                        Assert.AreEqual(m_tabLignes[indice,INDEX_COL_POSITION], target.m_tabLignes[indice,INDEX_COL_POSITION]);
                    }
                    catch
                    {
                        if (!tabErreursPosition[indice])
                        {
                            tabErreursPosition[indice] = true;
                            nbPointsObtenus -= 1;
                        }

                    }

                }
            }
            m_totalScore += nbPointsObtenus;

            Assert.AreEqual(30, nbPointsObtenus);
        }

        [TestMethod]
        public void TestAfficherLesDescriptions()
        {
            

           
            m_maxScore += 7;
            int nbPointsObtenus = 7;
           
            FrmPrincipal target = new FrmPrincipal(1);

            int index = VisualArrays.VisualArraysTools.RandomInt(0, 4);
            //for (int index = 0; index < m_nbFichiers; index++)
            
                TraiterUnFichier(index);
                target.m_tabLignes = m_tabLignes;
                target.cboListeFichiers.SelectedIndex = index;
                target.AfficherLesDescriptions();


                for (int indice = 0; indice < m_nbMots; indice++)
                {
                    try
                    {

                        Assert.AreEqual(target.vsaDescriptions[indice], m_tabLignes[indice, INDEX_COL_DESCRIPTION]);

                    }
                    catch
                    {


                        nbPointsObtenus -= 1;
                    }
                }


                if (nbPointsObtenus < 0)
                    nbPointsObtenus = 0;

            m_totalScore += nbPointsObtenus;

            Assert.AreEqual(7, nbPointsObtenus);
        }
        [TestMethod]
        public void TestPlacerLesDeuxLettresÀRévéler()
        {

            m_maxScore += 8;

            int nbPointsObtenus = 8;
            bool[] tabErreursLettresMalPlacées = { false, false, false, false, false, false, false, false, false, false };
            bool[] tabErreursCelDesactivées = { false, false, false, false, false, false, false, false, false, false };
           

            FrmPrincipal target = new FrmPrincipal(1);
            int num = VisualArrays.VisualArraysTools.RandomInt(0, 4);
            //for (int num = 0; num < m_nbFichiers; num++)
            {
                TraiterUnFichier(num);
                target.m_tabLignes = m_tabLignes;
               
                int index = VisualArrays.VisualArraysTools.RandomInt(0, target.vsaDescriptions.Length);
                //for (int index = 0; index < m_nbMots; index++)
                {
                    target.PlacerLesDeuxLettresÀRévéler();// index, m_tabMots[index], m_tabPositions[index]);
                    try
                    {
                        
                        Assert.AreEqual(target.vcaMots[index, int.Parse(m_tabLignes[index,INDEX_COL_POSITION])],
                            char.ToUpper(m_tabLignes[index, INDEX_COL_MOT][int.Parse(m_tabLignes[index, INDEX_COL_POSITION])]));
                       
                    }
                    catch (Exception)
                    {
                        nbPointsObtenus -= 2;

                    }
                    try
                    {

                        Assert.AreEqual(target.vcaMots[index, int.Parse(m_tabLignes[index, INDEX_COL_POSITION]) + 1],
                          char.ToUpper(m_tabLignes[index, INDEX_COL_MOT][int.Parse(m_tabLignes[index, INDEX_COL_POSITION]) + 1]));
                    }
                    catch (Exception)
                    {
                        nbPointsObtenus -= 2;

                    }

                    try
                    {
                        Assert.IsFalse(target.vcaMots.GetCellEnabled(index, int.Parse(m_tabLignes[index, INDEX_COL_POSITION])));
                       

                    }
                    catch (Exception)
                    {

                        nbPointsObtenus -= 2;
                    }
                    try
                    {
                       
                        Assert.IsFalse(target.vcaMots.GetCellEnabled(index, int.Parse(m_tabLignes[index, INDEX_COL_POSITION]) + 1));

                    }
                    catch (Exception)
                    {

                        nbPointsObtenus -= 2;
                    }

                }
            }

            m_totalScore += nbPointsObtenus;
            Assert.AreEqual(8, nbPointsObtenus);

        }

        [TestMethod]
        public void TestTronquerLesCellulesInutilisées()
        {

            m_maxScore += 10;

            int nbPointsObtenus = 10;
            int nbATronquer;
            bool[] tabErreursCeltronquées = { false, false, false, false, false, false, false, false, false, false };
           
            FrmPrincipal target = new FrmPrincipal(1);
            int num = 0;// VisualArrays.VisualArraysTools.RandomInt(0, 4);
            //for (int num = 0; num < m_nbFichiers; num++)
            {
                TraiterUnFichier(num);
                target.m_tabLignes = m_tabLignes;
                int index = 3; // VisualArrays.VisualArraysTools.RandomInt(0, target.vcaMots.RowCount);
                string mot = m_tabLignes[index, INDEX_COL_MOT];
                nbATronquer = target.vcaMots.ColumnCount - mot.Length;
                int nbTronquées = 0;
                //for (int index = 0; index < m_nbMots; index++)
                
                    target.TronquerLesCellulesInutilisées();


                    for (int col = m_tabLignes[index, INDEX_COL_MOT].Length; col < target.vcaMots.ColumnCount; col++)
                    {

                        try
                        {
                            Assert.AreEqual(target.vcaMots[index, col], target.vcaMots.SpecialValue);
                        nbTronquées++;
                        }
                        catch
                        {
                           
                            //if (!tabErreursCeltronquées[index])
                            //{
                            //    tabErreursCeltronquées[index] = true;
                            //    nbPointsObtenus -= 1;
                            //}
                        }
                    }
                    if(nbATronquer==nbTronquées)
                {
                    nbPointsObtenus = 10;
                }else if ((nbATronquer - nbTronquées) <=1) //((decimal) nbTronquées / nbATronquer ) >= 0.75m)
                {
                    nbPointsObtenus = 8;
                } else if ((nbATronquer - nbTronquées) <= 2)  //(((decimal)nbTronquées / nbATronquer) >= 0.50m)
                {
                    nbPointsObtenus = 6;
                }else if ((nbATronquer - nbTronquées) <= 3)  //(((decimal)nbTronquées / nbATronquer) >= 0.25m)
                {
                    nbPointsObtenus = 4;
                }
                else if ((nbATronquer - nbTronquées) <= 4)  //(((decimal)nbTronquées / nbATronquer) >= 0.25m)
                {
                    nbPointsObtenus = 2;
                }
                else
                {
                    nbPointsObtenus = 0;
                }




            }
            m_totalScore += nbPointsObtenus;
            Assert.AreEqual(10, nbPointsObtenus);
        }
        [TestMethod]
        public void TestMotEstValide()
        {


            bool erreur = false;
            int nbPointsObtenus = 7;
            FrmPrincipal target = new FrmPrincipal(1);
            m_maxScore += 7;
            for (int num = 0; num < m_nbFichiers; num++)
            {
                TraiterUnFichier(num);//,0);

                //target.cboListeDeMots.SelectedIndex = num;

                int rowAleatoire = VisualArrays.VisualArraysTools.RandomInt(0, m_nbMots);
                string mot = m_tabLignes[rowAleatoire, INDEX_COL_MOT];
                target.vcaMots.Clear();
                for (int col = 0; col < mot.Length; col++)
                    target.vcaMots[rowAleatoire, col] = VisualArrays.VisualArraysTools.RandomChar('A', 'Z');
                try
                {
                    Assert.IsFalse(target.MotEstValide(rowAleatoire, mot));
                }
                catch
                {

                    erreur = true;
                }

                target.vcaMots.Clear();

                mot = m_tabLignes[rowAleatoire, INDEX_COL_MOT];
                for (int col = 0; col < mot.Length; col++)
                    target.vcaMots[rowAleatoire, col] = mot[col];
                try
                {
                    Assert.IsTrue(target.MotEstValide(rowAleatoire, mot));
                }
                catch
                {


                    erreur = true;
                }

            }

            if (erreur) nbPointsObtenus = 0;
            m_totalScore += nbPointsObtenus;
            Assert.AreEqual(7, nbPointsObtenus);
        }

        [TestMethod]
        public void TestDésactiverMot()
        {
            int nbPointsObtenus = 7;

            m_maxScore += 7;
            FrmPrincipal target = new FrmPrincipal(1);


            int rowAleatoire = VisualArrays.VisualArraysTools.RandomInt(0, m_nbMots);
            int tailleMotAléatoire = VisualArrays.VisualArraysTools.RandomInt(1, target.vcaMots.ColumnCount);
            string mot = "";
            for (int col = 0; col < tailleMotAléatoire; col++)
                mot = mot + VisualArrays.VisualArraysTools.RandomChar('A', 'Z');


            target.vcaMots.Clear();

            target.DésactiverMot(rowAleatoire, mot.Length);
            try
            {
                Assert.IsFalse(target.vsaDescriptions.GetCellEnabled(rowAleatoire));
            }
            catch
            {
                nbPointsObtenus -= 2;
            }

            try
            {
                for (int col = 0; col < mot.Length; col++)
                {
                    Assert.IsFalse(target.vcaMots.GetCellEnabled(rowAleatoire, col));
                }
            }
            catch
            {
                nbPointsObtenus -= 5;
            }


            m_totalScore += nbPointsObtenus;
            Assert.AreEqual(7, nbPointsObtenus);
        }

        //[TestMethod]
        //public void TestvcaMots_ValueChangedUneLettre()
        //{
        //    int nbPointsObtenus = 4;
        //    m_maxScore += 4;

        //    FrmPrincipal target = new FrmPrincipal(1);

        //    int numFichier = VisualArrays.VisualArraysTools.RandomInt(0, 4);
        //    TraiterUnFichier(numFichier);

        //    int rowAleatoire = VisualArrays.VisualArraysTools.RandomInt(0, MAX_MOTS);
        //    target.m_tabLignes = m_tabLignes;
        //    string mot = target.m_tabLignes[rowAleatoire, INDEX_COL_MOT];
        //    target.vcaMots.Clear();
        //    target.vsaDescriptions.Clear();
        //    int col = 0;
        //    int position = -1;
        //    target.vcaMots.SelectedIndex = rowAleatoire;
        //    while (col < mot.Length && position == -1)
        //    {
        //        bool active = target.vcaMots.GetCellEnabled(rowAleatoire, col);
        //        if (active)
        //        {
        //            target.vcaMots[rowAleatoire, col] = char.ToLower(mot[col]);
        //            position = col;
        //        }
        //    }

        //    try
        //    {
        //        Assert.AreEqual(char.ToUpper(mot[col]), target.vcaMots[rowAleatoire, position]);
        //    }
        //    catch
        //    {
        //        nbPointsObtenus -= 4;
        //    }



        //    m_totalScore += nbPointsObtenus;
        //    Assert.AreEqual(4, nbPointsObtenus);
        //}
        [TestMethod]
        public void TestvcaMots_ValueChangedMotValide()
        {
            int nbPointsObtenus = 8;
            m_maxScore += 8;

            FrmPrincipal target = new FrmPrincipal(1);

            int numFichier = VisualArrays.VisualArraysTools.RandomInt(0, 4);
            TraiterUnFichier(numFichier);

            int rowAleatoire = VisualArrays.VisualArraysTools.RandomInt(0, MAX_MOTS);
            target.m_tabLignes = m_tabLignes;
            string mot = target.m_tabLignes[rowAleatoire, INDEX_COL_MOT];
            target.vcaMots.Clear();
            target.vsaDescriptions.Clear();


            target.vcaMots.SelectedIndex = rowAleatoire;
            for (int col = 0; col < mot.Length; col++)
            {

                target.vcaMots[rowAleatoire, col] = char.ToUpper(mot[col]);


            }
            //try
            //{

            //    for (int col = 0; col < mot.Length; col++)
            //    {

            //        Assert.AreEqual(char.ToUpper(target.vcaMots[rowAleatoire, col]), target.vcaMots[rowAleatoire, col]);
                    

            //    }


            //}
            //catch
            //{
            //    nbPointsObtenus -= 2;
            //}
            try
            {

                for (int col = 0; col < mot.Length; col++)
                {

                    Assert.IsFalse(target.vcaMots.GetCellEnabled(rowAleatoire, col));


                }


            }
            catch
            {
                nbPointsObtenus -= 4;
            }
            try
            {


                Assert.IsFalse(target.vsaDescriptions.GetCellEnabled(rowAleatoire));


            }
            catch
            {
                nbPointsObtenus -= 4;
            }


            m_totalScore += nbPointsObtenus;
            Assert.AreEqual(8, nbPointsObtenus);
        }
        [TestMethod]
        public void TestMnuAideVoirLaLettre()
        {
           
            m_maxScore += 7;

            int nbPointsObtenus = 7;
           
            FrmPrincipal target = new FrmPrincipal(1);

            int numFichier = VisualArrays.VisualArraysTools.RandomInt(0, 4);
            TraiterUnFichier(numFichier);
            target.vcaMots.Clear();
            target.vsaDescriptions.Clear();

            int rowAleatoire = VisualArrays.VisualArraysTools.RandomInt(0, target.vsaDescriptions.Length);
            string mot = m_tabLignes[rowAleatoire, INDEX_COL_MOT];
            
            int colAleatoire = VisualArrays.VisualArraysTools.RandomInt(0, mot.Length);
            target.vcaMots.SelectedAddress = new VisualArrays.Address(rowAleatoire,colAleatoire);
            //target.vcaMots.SelectedIndex = rowAleatoire * target.vcaMots.ColumnCount + colAleatoire;
            target.m_tabLignes = m_tabLignes;
            

            target.MnuAideVoirLaLettre_Click(null, null);

            try
            {
                char lettre = target.vcaMots[rowAleatoire, colAleatoire];
                Assert.AreEqual(mot[colAleatoire],target.vcaMots[rowAleatoire,colAleatoire]);
                //    vcaMots.DisableCell(rangée, colonne);
            }
            catch
            {
                nbPointsObtenus -= 4;
                
            }
            try
            {
                Assert.IsFalse(target.vcaMots.GetCellEnabled(rowAleatoire*target.vcaMots.ColumnCount+colAleatoire));
               
            }
            catch
            {
                nbPointsObtenus -= 3;
               
            }

            m_totalScore += nbPointsObtenus;
            Assert.AreEqual(7, nbPointsObtenus);
        }

        [TestMethod]
        public void TestMnuAideVoirLeMot()
        {


            m_maxScore += 8;

            int nbPointsObtenus = 8;

            FrmPrincipal target = new FrmPrincipal(1);

            int numFichier = VisualArrays.VisualArraysTools.RandomInt(0, 4);
            TraiterUnFichier(numFichier);
            target.vcaMots.Clear();
            target.vsaDescriptions.Clear();

            int rowAleatoire = VisualArrays.VisualArraysTools.RandomInt(0, target.vsaDescriptions.Length);
            //target.vcaMots.SelectedIndex = rowAleatoire;

            
            string mot = m_tabLignes[rowAleatoire, INDEX_COL_MOT];
           

            target.m_tabLignes = m_tabLignes;
            
           // target.vcaMots.SelectedIndex = rowAleatoire * target.vcaMots.ColumnCount + 0;
            target.vcaMots.SelectedAddress = new VisualArrays.Address(rowAleatoire, 0);



            target.MnuAideVoirLeMot_Click(null, null);
            
            try
            {

                for (int col = 0; col < mot.Length; col++)
                {
                    Assert.AreEqual(mot[col], target.vcaMots[rowAleatoire,col]);
                    
                }
                
              
            }
            catch
            {
                nbPointsObtenus -= 3;
            }
            try
            {

                for (int col = 0; col < mot.Length; col++)
                {
                    Assert.IsFalse(target.vcaMots.GetCellEnabled(rowAleatoire, col));
                   
                }

                
            }
            catch
            {
                nbPointsObtenus -= 3;
            }
            try
            {

                    Assert.IsFalse(target.vsaDescriptions.GetCellEnabled(rowAleatoire));

                
            }
            catch
            {
                nbPointsObtenus -= 2;
            }
           

            m_totalScore += nbPointsObtenus;
            Assert.AreEqual(8, nbPointsObtenus);
        }

        [TestMethod]
        public void TestMnuAideVoirTousLesMots()
        {


            m_maxScore += 8;

            int nbPointsObtenus = 8;

            FrmPrincipal target = new FrmPrincipal(1);

            int numFichier = VisualArrays.VisualArraysTools.RandomInt(0, 4);
            TraiterUnFichier(numFichier);
            target.vcaMots.Clear();
            target.vsaDescriptions.Clear();

            target.m_tabLignes = m_tabLignes;
            

            target.MnuAideVoirTousLesMots_Click(null, null);

            try
            {
                for (int row = 0; row < target.vcaMots.RowCount; row++)
                {
                    string mot = target.m_tabLignes[row, INDEX_COL_MOT];
                    for (int col = 0; col < mot.Length; col++)
                    {
                        Assert.AreEqual(mot[col], target.vcaMots[row, col]);

                    }
                }
                    


            }
            catch
            {
                nbPointsObtenus -= 2;
            }
            try
            {

                for (int row = 0; row < target.vcaMots.RowCount; row++)
                {
                    string mot = target.m_tabLignes[row, INDEX_COL_MOT];
                    for (int col = 0; col < mot.Length; col++)
                    {
                        Assert.IsFalse(target.vcaMots.GetCellEnabled(row, col));

                    }
                }
               


            }
            catch
            {
                nbPointsObtenus -= 2;
            }
            try
            {

                for (int row = 0; row < target.vcaMots.RowCount; row++)
                {
                    Assert.IsFalse(target.vsaDescriptions.GetCellEnabled(row));
                }
               



               
            }
            catch
            {
                nbPointsObtenus -= 2;
            }
            try
            {

               
                    Assert.IsFalse(target.vcaMots.Enabled);
                    Assert.AreEqual(-1,target.vcaMots.SelectedIndex);




            }
            catch
            {
                nbPointsObtenus -= 2;
            }

            m_totalScore += nbPointsObtenus;
            Assert.AreEqual(8, nbPointsObtenus);
        }
       
       

        
        

       
       

    }
}
