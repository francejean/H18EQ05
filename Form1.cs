using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Trigger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'DS_Eq.Chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.TA_Chambre.Fill(this.DS_Eq.Chambre);
            this.TA_Chambre.FillBy(this.DS_Eq.Chambre);
            // TODO: cette ligne de code charge les données dans la table 'DS_Eq.Localisation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.TA_Loc.Fill(this.DS_Eq.Localisation);
            Fill();
            FillBy();
            Lien_Cham();
        }
        private void Fill()
        {
            this.TA_Chambre.Fill(this.DS_Eq.Chambre);
            this.TA_Ayant.Fill(this.DS_Eq.Ayant);
        }

        private void FillBy()
        {
            this.TA_Chambre.FillBy(this.DS_Eq.Chambre);
            this.TA_Ayant.FillBy(this.DS_Eq.Ayant);
        }
        
        private void Lien_Cham()
        {
            this.BS_Chambre.DataMember = "Chambre";
            this.BS_Chambre.DataSource = this.DS_Eq;

            try
            {
                TxT_Cham.DataBindings.Add("Text", BS_Chambre, "NoCham");
                TxT_Etage.DataBindings.Add("Text", BS_Chambre, "Etage");
                TxT_Etat.DataBindings.Add("Text", BS_Chambre, "Etat");
                TxT_Type.DataBindings.Add("Text", BS_Chambre, "CodTypChan");
                TxT_Loc.DataBindings.Add("Text", BS_Chambre, "CodLoc");
                TxT_Prix.DataBindings.Add("Text", BS_Chambre, "Prix");
                TxT_Memo.DataBindings.Add("Text", BS_Chambre, "Memo");
                D_Type.DataBindings.Add("Text", BS_Chambre, "DescTyp");
                D_Loc.DataBindings.Add("Text", BS_Chambre, "DescLoc");
                /*if (this.BS_Loc.DataSource != null)
                {
                    TxT_Cham.Text = "OK";
                }
                else
                {
                    TxT_Cham.Text = "NO";
                }*/
            }
            catch (Exception ee) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BS_Chambre.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BS_Chambre.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BS_Chambre.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BS_Chambre.MoveLast();
        }
    }
}
