using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CorrecteurBingo2
{
    /// <summary>
    /// Version 2015/12/04
    /// Paul
    /// </summary>
    class RapportCorrection
    {
        private  StreamWriter m_StreamWriter;
        private  List<ClsDetailCorrection> m_lstDescriptionDeTests;
        private String m_nomEtutiant;
        private String m_nomFichier;
        public RapportCorrection(String pNomEtudiant, String pNomFichier)
        {
            m_nomEtutiant=pNomEtudiant;
            m_nomFichier = pNomFichier;
            m_lstDescriptionDeTests = new List<ClsDetailCorrection>();
        }

        public void ProduireRapport(int pTotalScore, int pMaxScore, String pVersion)
        {
            m_StreamWriter = new StreamWriter("../../../_RésultatsÉtudiants/" + m_nomEtutiant + " " + m_nomFichier);
            m_StreamWriter.WriteLine(m_nomEtutiant);
            m_StreamWriter.WriteLine();

            m_lstDescriptionDeTests.Sort();

            foreach (ClsDetailCorrection item in m_lstDescriptionDeTests)
            {

                String étatDuTest = (item.PointObtenu == item.Ponderation) ? "Bon" : "Erreur";
                String ligne = String.Format("{0,-7} {1,-85}: {2,3}/{3,3} : {4,-7} {5}",
                                              item.QuestionID, item.Description, item.PointObtenu, item.Ponderation, étatDuTest, item.MessageErreur);
               
                m_StreamWriter.WriteLine(ligne);
            }

            m_StreamWriter.WriteLine(String.Format("{0,93}: {1,3}/{2,3} : {3}",pVersion , pTotalScore, pMaxScore,"TOTAL" ));
            m_StreamWriter.WriteLine(String.Format("{0,93}  {1}"," ", "-------"));
            m_StreamWriter.WriteLine(String.Format("{0,93}: {1,3}", "Points enlevés pour le code et commentaire", 0));
            m_StreamWriter.WriteLine(String.Format("{0,93}: {1,3}%", "Nouveau total", "00"));
            m_StreamWriter.Close();
        }

        public void Ajouter(ClsDetailCorrection pObjDetail)
        {
            m_lstDescriptionDeTests.Add(pObjDetail);
        }

    }
}
