using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CorrecteurBingo2
{
    /// <summary>
    /// Version du 2014/10/02
    /// </summary>
    public class ClsDetailCorrection : IComparable<ClsDetailCorrection>
    {
        private String m_questionID;
        /// <summary>
        /// Clée unique utilisée pour trier
        /// </summary>
        public String QuestionID
        {
            get { return m_questionID; }
            set { m_questionID = value; }
        }

        private String m_descrption;

        public String Description
        {
            get { return m_descrption; }
            set { m_descrption = value; }
        }

        private String m_message;

        public String MessageErreur
        {
            get { return m_message; }
            set { m_message = value; }
        }
        private int m_ponderation;

        public int Ponderation
        {
            get { return m_ponderation; }
            set { m_ponderation = value; }
        }
        private int m_pointObtenu;

        public int PointObtenu
        {
            get { return m_pointObtenu; }
            set { m_pointObtenu = value; }
        }

        public ClsDetailCorrection(String pQuestionID, string pDescription, int pPonderation)
        {
            QuestionID = pQuestionID;
            Description = pDescription;
            MessageErreur = String.Empty;
            Ponderation = pPonderation;
            PointObtenu = 0;
        }

        public void AjouterMsgErreur(String pMessage)
        {
            MessageErreur += "\n\t\t" + pMessage;
        }

        public int CompareTo(ClsDetailCorrection other)
        {
            return this.m_questionID.CompareTo(other.m_questionID);
        }
    }
}
