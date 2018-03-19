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
        }

        private void Fill()
        {
            this.TA_Chambre.Fill(this.DS_bd.Chambre);
            this.TA_T_Cham.Fill(this.DS_bd.TypeCham);
        }

        private void FillBy()
        {
            this.TA_Chambre.FillBy(this.DS_bd.Chambre);
        }

        private void Lien_Cham()
        {
            this.BS_Chambre.DataMember = "Chambre";
            this.BS_Chambre.DataSource = this.DS_bd;
            this.BS_T_Cham.DataMember = "TypeCham";
            this.BS_T_Cham.DataSource = this.DS_bd;

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
            }
            catch (Exception ee) { }
        }

        private void btn_premier_Click(object sender, EventArgs e)
        {
            BS_Chambre.MoveFirst();
            //BS_T_Cham.Position = BS_T_Cham.Find("DescTyp", DS_bd.Tables["Chambre"].Rows[BS_Chambre.Position]["CodTypChan"]);
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            BS_Chambre.MovePrevious();
            //BS_T_Cham.Position = BS_T_Cham.Find("DescTyp", DS_bd.Tables["Chambre"].Rows[BS_Chambre.Position]["CodTypChan"]);
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            BS_Chambre.MoveNext();
            //BS_T_Cham.Position = BS_T_Cham.Find("DescTyp", DS_bd.Tables["Chambre"].Rows[BS_Chambre.Position]["CodTypChan"]);
        }

        private void btn_dernier_Click(object sender, EventArgs e)
        {
            BS_Chambre.MoveLast();
            //BS_T_Cham.Position = BS_T_Cham.Find("DescTyp", DS_bd.Tables["Chambre"].Rows[BS_Chambre.Position]["CodTypChan"]);
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
