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
        private bool abandon = true;
        private bool ajout = false;
        private bool consul = true;
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
            LienGrid();
        }

        private void delier()
        {
            tb_Cham.DataBindings.Clear();
            tb_Etage.DataBindings.Clear();
            tb_Etat.DataBindings.Clear();
            tb_Type.DataBindings.Clear();
            tb_Loc.DataBindings.Clear();
            tb_Prix.DataBindings.Clear();
            tb_Memo.DataBindings.Clear();
            tb_D_Type.DataBindings.Clear();
            tb_D_Loc.DataBindings.Clear();
        }

        private void vider()
        {
            tb_Cham.Clear();
            tb_Etage.Clear();
            tb_Etat.Clear();
            tb_Type.Clear();
            tb_Loc.Clear();
            tb_Prix.Clear();
            tb_Memo.Clear();
            tb_D_Type.Clear();
            tb_D_Loc.Clear();
        }

        private void ClearErreur()
        {
            error1.SetError(tb_Cham, "");
            error1.SetError(tb_Etage, "");
            error1.SetError(tb_Etat, "");
            error1.SetError(tb_Memo, "");
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

        public void ValideType()
        {
            //this.BS_T_Cham.Position = this.BS_T_Cham.Find("CodTypChan", this.id);
            tb_Type.Text = this.BS_T_Cham.Find("CodTypChan", this.id).ToString();
        }

        private void TxT_Cham_DoubleClick(object sender, EventArgs e)
        {
            if (consul == true)
            {
                f_e2selecteur f = new Projet_equipe.f_e2selecteur(this);
                f.Show();
            }
        }

        public bool IsNumeric(string Nombre)
        {
            try
            {
                int.Parse(Nombre);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void Act_Bout(bool ba,bool bm,bool bs,bool bc,bool bl,bool bli,bool bsa,bool ban,bool f,bool p,bool n,bool l)
        {
            btn_ajouter.Enabled = ba;
            btn_modifier.Enabled = bm;
            btn_supprimer.Enabled = bs;
            btn_consulter.Enabled = bc;
            btn_lister.Enabled = bl;
            btn_liste.Enabled = bli;
            btn_save.Enabled = bsa;
            btn_annuler.Enabled = ban;
            btn_premier.Enabled = f;
            btn_precedent.Enabled = p;
            btn_suivant.Enabled = n;
            btn_dernier.Enabled = l;
        }

        private void Act_Saisie(bool Ch, bool Et, bool Eta, bool Lo,bool Me,bool Pr,bool Ty)
        {
            tb_Cham.ReadOnly = Ch;
            tb_Etage.Enabled = Et;
            tb_Etat.Enabled = Eta;
            tb_Loc.Enabled = Lo;
            tb_Memo.Enabled = Me;
            tb_Prix.Enabled = Pr;
            tb_Type.Enabled = Ty;
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Act_Bout(false, false, false, false, false, false, true, true, false, false, false, false);
            Act_Saisie(false, true, true, true, true, true, true);
            abandon = false;
            ajout = true;
            consul = false;
            delier();
            vider();
            tb_Etage.Focus();
        }

        private void btn_consulter_Click(object sender, EventArgs e)
        {
            Act_Bout(true, false, false, false, false, false, false, false, true, true, true, true);
            Act_Saisie(true, false, false, false, false, false, false);

            ajout = false;
            consul = true;
            Lien_Cham();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            abandon = true;
            ClearErreur();
            DS_bd.Tables["Chambre"].RejectChanges();
            BS_Chambre.ResetCurrentItem();
            Lien_Cham();

            Act_Bout(true, false, false, false, false, false, false, false, true, true, true, true);
            Act_Saisie(true, false, false, false, false, false, false);
            ajout = false;
            consul = true;
        }

        private void tb_Etage_Validating(object sender, CancelEventArgs e)
        {
            if (abandon == false)
            {
                if ((tb_Etage.Text.Length == 0) || (!IsNumeric(tb_Etage.Text)))
                {
                    error1.SetError(tb_Etage, "Entrez un nombre entre 01 et 99");
                    tb_Etage.Focus();
                }
                else
                {
                    if (tb_Etage.Text.Length > 2)
                    {
                        error1.SetError(tb_Etage, "Entrez 1 ou 2 caractères");
                        tb_Etage.Focus();
                    }
                    else
                    {
                        error1.SetError(tb_Etage, "");
                        tb_Cham.Focus();
                    }
                }
            }
        }

        private void tb_Cham_Validating(object sender, CancelEventArgs e)
        {
            if (abandon == false)
            {
                int index = BS_Chambre.Find("NoCham", tb_Cham.Text);

                if ((tb_Cham.Text.Length == 0) || (!IsNumeric(tb_Cham.Text)))
                {
                    error1.SetError(tb_Cham, "Entrez un nombre entre 0001 et 9999");
                    tb_Cham.Focus();
                }
                else
                {
                    if (tb_Cham.Text.Length > 4)
                    {
                        error1.SetError(tb_Cham, "Entrez 3 ou 4 caractères");
                        tb_Cham.Focus();
                    }
                    else
                    {
                        if (index < 0)
                        {
                            error1.SetError(tb_Cham, "");
                        }
                        else
                        {
                            error1.SetError(tb_Cham, "Le numéro de chambre existe déjà");
                            tb_Cham.Focus();
                        }
                    }
                }
            }
        }

        private void tb_Type_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ajout == true)
            {
                f_e2selectType f = new Projet_equipe.f_e2selectType(this);
                f.Show();
            }
        }
    }
}
