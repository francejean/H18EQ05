using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_equipe
{
    public partial class f_e2 : Form
    {
        public int id;
        public f_e2()
        {
            InitializeComponent();
        }

        private void f_e2_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'DS_Eq.Chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.TA_Chambre.Fill(this.DS_bd.Chambre);
            this.TA_Chambre.FillBy(this.DS_bd.Chambre);
            this.TA_T_Cham.Fill(this.DS_bd.TypeCham);
            // TODO: cette ligne de code charge les données dans la table 'DS_Eq.Localisation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            Fill();
            FillBy();
            Lien_Cham();
            LienGrid();
        }

        private void Fill()
        {
            this.TA_Chambre.Fill(this.DS_bd.Chambre);
            this.TA_T_Cham.Fill(this.DS_bd.TypeCham);
            this.TA_Ayant.Fill(this.DS_bd.Ayant);
            this.TA_Comm.Fill(this.DS_bd.Commodite);
        }

        private void LienGrid()
        {
            int i = 0;

            this.BS_Ayantt.Position = 0;
            foreach(DataRow Dtr_Contient in DS_bd.Tables["Ayant"].Rows)
            {
                this.BS_Comm.Position = this.BS_Comm.Find("CodCom", ((DataRowView)this.BS_Ayantt.Current).Row["CodCom"]);

                if (BS_Comm.Position != -1)
                {
                    this.DS_bd.Tables["Ayant"].Rows[i]["DescCom"] = this.DS_bd.Tables["Commodite"].Rows[BS_Comm.Position]["DescCom"];
                }
                i++;
                BS_Ayantt.Position++;
            }
        }

        private void FillBy()
        {
            this.TA_Chambre.FillBy(this.DS_bd.Chambre);
            //this.TA_Ayant.FillBy(this.DS_bd.Ayant);
        }

        private void Lien_Cham()
        {
            this.BS_Chambre.DataMember = "Chambre";
            this.BS_Chambre.DataSource = this.DS_bd;
            this.BS_T_Cham.DataMember = "TypeCham";
            this.BS_T_Cham.DataSource = this.DS_bd;

            try
            {
                tb_Cham.DataBindings.Add("Text", BS_Chambre, "NoCham");
                tb_Etage.DataBindings.Add("Text", BS_Chambre, "Etage");
                tb_Etat.DataBindings.Add("Text", BS_Chambre, "Etat");
                tb_Type.DataBindings.Add("Text", BS_Chambre, "CodTypChan");
                tb_Loc.DataBindings.Add("Text", BS_Chambre, "CodLoc");
                tb_Prix.DataBindings.Add("Text", BS_Chambre, "Prix");
                tb_Memo.DataBindings.Add("Text", BS_Chambre, "Memo");
                tb_D_Type.DataBindings.Add("Text", BS_Chambre, "DescTyp");
                tb_D_Loc.DataBindings.Add("Text", BS_Chambre, "DescLoc");
            }
            catch (Exception ee) { }
        }

        private void btn_premier_Click(object sender, EventArgs e)
        {
            BS_Chambre.MoveFirst();
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            BS_Chambre.MovePrevious();
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            BS_Chambre.MoveNext();
        }

        private void btn_dernier_Click(object sender, EventArgs e)
        {
            BS_Chambre.MoveLast();
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void recherche()
        {
            this.BS_Chambre.Position = this.BS_Chambre.Find("NoCham", this.id);
        }

        private void TxT_Cham_DoubleClick(object sender, EventArgs e)
        {
            f_e2selecteur f = new Projet_equipe.f_e2selecteur(this);
            f.Show();
        }
    }
}
