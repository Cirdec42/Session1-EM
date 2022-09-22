using System;
using System.Windows.Forms;

namespace AppMotifs
{
    public partial class FrmQ4 : Form
    {
        public FrmQ4()
        {
            InitializeComponent();
        }

        #region 5 motifs booléens
        private void BtnPremierMotifBooléen_Click(object sender, EventArgs e)
        {
            // TODO Premier Motif Booléens
            vbaGrilleBooléens.Clear();

            // À COMPLÉTER...
            for (int i = 0; i < vbaGrilleBooléens.Length/2; i++)
            {
                vbaGrilleBooléens[i] = true;
            }


        }

        private void BtnDeuxièmeMotifBooléen_Click(object sender, EventArgs e)
        {
            // TODO Deuxième Motif Booléens
            vbaGrilleBooléens.Clear();

            // À COMPLÉTER...
            for (int i = 1; i < vbaGrilleBooléens.Length-1; i++)
            {
                vbaGrilleBooléens[i] = true;
            }




        }

        private void BtnTroisièmeMotifBooléen_Click(object sender, EventArgs e)
        {
            // TODO Troisième Motif Booléens
            vbaGrilleBooléens.Clear();

            // À COMPLÉTER...
            for (int i = 0; i < vbaGrilleBooléens.Length; i+=2)
            {
                vbaGrilleBooléens[i] = true;
            }


        }

        private void BtnQuatrièmeMotifBooléen_Click(object sender, EventArgs e)
        {
            // TODO Quatrième Motif Booléens
            vbaGrilleBooléens.Clear();

            // À COMPLÉTER...
            for (int i = 1; i < vbaGrilleBooléens.Length; i += 2)
            {
                vbaGrilleBooléens[i] = true;
            }


        }

        private void BtnCinquièmeMotifBooléen_Click(object sender, EventArgs e)
        {
            // TODO Cinquième Motif Booléens 
            vbaGrilleBooléens.Clear();

            // À COMPLÉTER...
            for (int i = 0; i < vbaGrilleBooléens.Length; i++)
            {
                if (i % 5 != 0)
                {
                    vbaGrilleBooléens[i] = true;
                }
                else
                {
                    vbaGrilleBooléens[i] = false;
                }
            }

        }
        #endregion

        #region 5 motifs caractères
        private void BtnPremierMotifCaractères_Click(object sender, EventArgs e)
        {
            // TODO Premier Motif Caractères 
            vcaGrilleCaractères.Clear();

            // À COMPLÉTER...
            for (int i = 0; i <5; i++)
            {
                vcaGrilleCaractères[i] = 'X';
            }


        }

        private void BtnDeuxièmeMotifCaractères_Click(object sender, EventArgs e)
        {
            // TODO Deuxième Motif Caractères 
            vcaGrilleCaractères.Clear();

            // À COMPLÉTER...
            for (int i = 0; i < vcaGrilleCaractères.Length; i++)
            {
                vcaGrilleCaractères[i] = 'X';
            }


        }

        private void BtnTroisièmeMotifCaractères_Click(object sender, EventArgs e)
        {
            // TODO Troisième Motif Caractères
            vcaGrilleCaractères.Clear();

            // À COMPLÉTER...
            for (int i = 0; i < vcaGrilleCaractères.Length; i++)
            {
                switch (i)
                {
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                    case 16:
                        vcaGrilleCaractères[i] = 'X';
                        break;

                    default:
                        break;
                }

            }
        }

        private void BtnQuatrièmeMotifCaractères_Click(object sender, EventArgs e)
        {
            // TODO Quatrième Motif Caractères 
            vcaGrilleCaractères.Clear();

            // À COMPLÉTER...
            char lettre = 'A';
            for (int i = 0; i < vcaGrilleCaractères.Length;i++)
            {
                vcaGrilleCaractères[i] = lettre;
                lettre++;
            }

        }

        private void BtnCinquièmeMotifCaractères_Click(object sender, EventArgs e)
        {
            // TODO Cinquième Motif Caractères 
            vcaGrilleCaractères.Clear();

            // À COMPLÉTER...
            char lettre = 'A';
            for (int i = 0; i < vcaGrilleCaractères.Length; i++)
            {
                if (i<vcaGrilleCaractères.Length/2)
                {
                    vcaGrilleCaractères[i] = lettre;
                    lettre++;
                }
                else if (i == vcaGrilleCaractères.Length/2)
                {
                    vcaGrilleCaractères[i] = '.';
                    lettre--;
                }
                else
                {
                    vcaGrilleCaractères[i]= lettre;
                    lettre--;
                }
                
            }





        }
        #endregion

        #region 5 motifs numériques
        private void BtnPremierMotifNumérique_Click(object sender, EventArgs e)
        {
            // TODO Premier Motif Numérique
            viaGrilleNumérique.Clear();

            // À COMPLÉTER...
            for (int i = 0; i < viaGrilleNumérique.Length; i++)
            {
                viaGrilleNumérique[i] = 99;
            }



        }

        private void BtnDeuxièmeMotifNumérique_Click(object sender, EventArgs e)
        {
            // TODO Deuxième Motif Numérique
            viaGrilleNumérique.Clear();

            // À COMPLÉTER...
            int num = 1;
            for (int i = 0; i < viaGrilleNumérique.Length; i++)
            {
                viaGrilleNumérique[i] = num;
                num++;
            }




        }

        private void BtnTroisièmeMotifNumérique_Click(object sender, EventArgs e)
        {
            // TODO Troisième Motif Numérique
            viaGrilleNumérique.Clear();

            // À COMPLÉTER...
            int num = 1;
            for (int i = 0; i < viaGrilleNumérique.Length; i++)
            {
                viaGrilleNumérique[i] = num;
                num += 4;
            }




        }

        private void BtnQuatrièmeMotifNumérique_Click(object sender, EventArgs e)
        {
            // TODO Troisième Motif Numérique
            int[] tabNombres = { 81, 67, 47, 90, 54, 63, 93, 98, 100, 75, 77, 82, 84, 94, 53 };
            viaGrilleNumérique.Clear();

            // À COMPLÉTER...
            for (int i = 0; i < viaGrilleNumérique.Length; i++)
            {
                viaGrilleNumérique[i] = tabNombres[i];
            }




        }

        private void BtnCinquièmeMotifNumérique_Click(object sender, EventArgs e)
        {
            // TODO Troisième Motif Numérique
            int[] tabNombres = { 81, 67, 47, 90, 54, 63, 93, 98, 100, 75, 77, 82, 84, 94, 53 };
            viaGrilleNumérique.Clear();

            // À COMPLÉTER...
            for (int i = 0; i < viaGrilleNumérique.Length; i++)
            {
                switch (i)
                {   
                    case 0:
                    case 3:
                    case 6:
                    case 7:
                    case 8:
                    case 11:
                    case 12:
                    case 13:
                        viaGrilleNumérique [i] = tabNombres[i];
                        break;
                    default:
                        break;
                }
            }




        }
        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
