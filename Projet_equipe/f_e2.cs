using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Projet_equipe
{
    public partial class f_e2 : Form
    {
        public int id;
        public string add;
        private DataRow Dtr_Cham;
        private DataRow Dtr_Comm;
        private DataRow Dtr_BK;
        private BindingSource BS_BK_Comm = new BindingSource();
        private f_e2selectComm Ls_Comm = new f_e2selectComm();
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

            BKlist();
        }

        private void Fill()
        {
            this.TA_Loc.Fill(this.DS_bd.Localisation);
            this.TA_T_Cham.Fill(this.DS_bd.TypeCham);
            this.TA_Chambre.Fill(this.DS_bd.Chambre);
            this.TA_Comm.Fill(this.DS_bd.Commodite);
            this.TA_Ayant.FillBy(this.DS_bd.Ayant);
        }

        private void LienGrid()
        {
            int i = 0;

            BS_Ayant.Position = 0;
            /*foreach(DataRow Dtr_Contient in DS_bd.Tables["Ayant"].Rows)
            {
                this.BS_Comm.Position = this.BS_Comm.Find("CodCom", ((DataRowView)this.BS_Ayantt.Current).Row["CodCom"]);

                if (BS_Comm.Position != -1)
                {
                    this.DS_bd.Tables["Ayant"].Rows[i]["DescCom"] = this.DS_bd.Tables["Commodite"].Rows[BS_Comm.Position]["DescCom"];
                }
                i++;
                BS_Ayantt.Position++;
            }*/
            BS_Ayant.DataSource = BS_Chambre;
            BS_Ayant.DataMember = "FK__Ayant__NoCham__6C190EBB";
            dg_selecteur.DataSource = BS_Ayant;
        }

        private void FillBy()
        {
            this.TA_Chambre.FillBy(this.DS_bd.Chambre);
        }

        private void Lien_Cham()
        {
            dg_selecteur.Visible = true;
            this.BS_Chambre.DataMember = "Chambre";
            this.BS_Chambre.DataSource = this.DS_bd;
            this.BS_T_Cham.DataMember = "TypeCham";
            this.BS_T_Cham.DataSource = this.DS_bd;
            this.BS_Loc.DataMember = "Localisation";
            this.BS_Loc.DataSource = this.DS_bd;

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

        private void BKlist()
        {
            BS_BK_Comm.DataSource = DS_bd;
            BS_BK_Comm.DataMember = "BK_Commodite";

            Ls_Comm._dg_comm.DataSource = BS_BK_Comm;
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
            dg_selecteur.Visible = false;
        }

        private void ClearErreur()
        {
            error1.SetError(tb_Cham, "");
            error1.SetError(tb_Etage, "");
            error1.SetError(tb_Etat, "");
            error1.SetError(tb_Memo, "");
            error1.SetError(tb_Prix, "");
            error1.SetError(tb_Loc, "");
            error1.SetError(tb_Type, "");
        }

        private void Copie()
        {
            this.TA_BK_Comm.FillBy(this.DS_bd.BK_Commodite, tb_Cham.Text);

            Ls_Comm._dg_comm.DataSource = BS_BK_Comm;
        }

        private void btn_Ajout_Comm_Click(object sender, EventArgs e)
        {
            //Copie();
            if (Ls_Comm.ShowDialog() == DialogResult.OK)
            {
                Ajout_Contient();
                Ajuster_Calcul_Comm();
            }
        }

        private void Ajout_Contient()
        {
            Dtr_Comm = DS_bd.Tables["Ayant"].NewRow();
            Dtr_Comm["NoCham"] = DS_bd.Tables["Chambre"].Rows[BS_Chambre.Position]["NoCham"];
            Dtr_Comm["CodCom"] = DS_bd.Tables["BK_Commodite"].Rows[BS_BK_Comm.Position]["CodCom"];
            Dtr_Comm["DescCom"] = DS_bd.Tables["BK_Commodite"].Rows[BS_BK_Comm.Position]["DescCom"];

            DS_bd.Tables["Ayant"].Rows.Add(Dtr_Comm);
            
            BS_BK_Comm.RemoveCurrent();
            DS_bd.Tables["BK_Commodite"].AcceptChanges();
        }

        private void Ajuster_Calcul_Comm()
        {
            LienGrid();
        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            if (BS_Ayant.Count > 0)
            {
                MessageBox.Show(dg_selecteur.Rows[BS_Ayant.Position].Cells[dg_selecteur.Columns[0].Index].Value.ToString());

                object Vals = new object();
                Vals = dg_selecteur.Rows[BS_Ayant.Position].Cells[dg_selecteur.Columns[0].Index].Value;
                DataRow foundRow = DS_bd.Tables["Commodite"].Rows.Find(Vals);
                Dtr_BK = DS_bd.Tables["BK_Commodite"].NewRow();
                Dtr_BK.ItemArray = foundRow.ItemArray;
                DS_bd.Tables["BK_Commodite"].Rows.Add(Dtr_BK);

                BS_Ayant.RemoveAt(BS_Ayant.Position);
            }
            Ajuster_Calcul_Comm();
        }

        #region "Gestion bouton navigation"
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
        #endregion
        #region "Liste de sélection"
        public void recherche()
        {
            this.BS_Chambre.Position = this.BS_Chambre.Find("NoCham", this.id);
        }

        public void ValideType()
        {
            this.BS_T_Cham.Position = this.BS_T_Cham.Find("CodTypChan", this.add);
            tb_Type.Text = this.DS_bd.Tables["TypeCham"].Rows[BS_T_Cham.Position]["CodTypChan"].ToString();
            tb_D_Type.Text = this.DS_bd.Tables["TypeCham"].Rows[BS_T_Cham.Position]["DescTyp"].ToString();
        }

        public void ValideLoc()
        {
            this.BS_Loc.Position = this.BS_Loc.Find("CodLoc", this.add);
            tb_Loc.Text = this.DS_bd.Tables["Localisation"].Rows[BS_Loc.Position]["CodLoc"].ToString();
            tb_D_Loc.Text = this.DS_bd.Tables["Localisation"].Rows[BS_Loc.Position]["DescLoc"].ToString();
        }
        #endregion

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

        #region "Activation"
        private void Act_Bout(bool ba,bool bm,bool bs,bool bc,bool bl,bool bli,bool bsa,bool ban,bool f,bool p,bool n,bool l, bool AC, bool SC)
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
            btn_Ajout_Comm.Enabled = AC;
            btn_supp.Enabled = SC;
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
        #endregion

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Act_Bout(false, false, false, false, false, false, false, true, false, false, false, false,false,false);
            Act_Saisie(false, true, true, false, true, true, false);
            abandon = false;
            ajout = true;
            consul = false;
            delier();
            vider();
            tb_Etage.Focus();
        }

        private void btn_consulter_Click(object sender, EventArgs e)
        {
            Act_Bout(true, false, false, false, false, false, false, false, true, true, true, true,false,false);
            Act_Saisie(true, false, false, true, false, false, true);

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
            BS_Chambre.Position = 0;
            Lien_Cham();

            Act_Bout(true, false, false, false, false, false, false, false, true, true, true, true,false,false);
            Act_Saisie(true, false, false, true, false, false, true);
            ajout = false;
            consul = true;
        }

        private void Creer_Cham()
        {
            Dtr_Cham = DS_bd.Tables["Chambre"].NewRow();
            Dtr_Cham["Etage"] = tb_Etage.Text;
            Dtr_Cham["NoCham"] = tb_Cham.Text;
            DS_bd.Tables["Chambre"].Rows.Add(Dtr_Cham);
            BS_Chambre.Position = BS_Chambre.Count - 1;
            Lien_Cham();

            Act_Bout(false, false, false, false, false, false, true, true, false, false, false, false,true,true);
            Act_Saisie(true, false, true, true, true, true, true);
            Copie();
            //tb_Prix.Focus();
        }
        #region "SetError"
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
                    if (tb_Etage.Text.Length != 2)
                    {
                        error1.SetError(tb_Etage, "Entrez 2 caractères");
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
                    error1.SetError(tb_Cham, "Entrez un nombre entre 001 et 999");
                    tb_Cham.Focus();
                }
                else
                {
                    if (tb_Cham.Text.Length != 3)
                    {
                        error1.SetError(tb_Cham, "Entrez 3 caractères");
                        tb_Cham.Focus();
                    }
                    else
                    {
                        if (tb_Cham.Text.StartsWith(tb_Etage.Text))
                        {
                            if (index < 0)
                            {
                                error1.SetError(tb_Cham, "");
                                Creer_Cham();
                            }
                            else
                            {
                                error1.SetError(tb_Cham, "Le numéro de chambre existe déjà");
                                tb_Cham.Focus();
                            }
                        }
                        else
                        {
                            error1.SetError(tb_Cham, "Le numéro doit commencer par le numéro d'étage");
                            tb_Cham.Focus();
                        }
                    }
                }
            }
        }
        #endregion

        private void tb_Type_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ajout == true)
            {
                f_e2selectType f = new Projet_equipe.f_e2selectType(this);
                f.Show();
            }
        }

        private void tb_Loc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ajout == true)
            {
                f_e2selectLoc f = new Projet_equipe.f_e2selectLoc(this);
                f.Show();
            }
        }

        #region "Valide"
        private bool ValidePrix()
        {
            
            if (tb_Prix.Text.Length == 0)
            {
                //tb_Prix.Focus();
                error1.SetError(tb_Prix, "Veuillez entrer un prix");
                return false;
            }
            else
            {
                bool OK = Regex.IsMatch(tb_Prix.Text, @"[0-99999]\,[0-9][0-9]");
                if (OK)
                {
                    error1.SetError(tb_Prix, "");
                    Dtr_Cham["Prix"] = decimal.Parse(tb_Prix.Text);
                    return true;
                }
                else
                {
                    //tb_Prix.Focus();
                    error1.SetError(tb_Prix, "Le prix n'est pas au format '00,00'");
                    return false;
                }
            }
        }

        private bool Valide_Ayant()
        {
            if (BS_Ayant.Count == 0)
            {
                MessageBox.Show("Vous devez entrer au moins une commodite", "Absence de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
        
        private bool Valide()
        {
            bool valide = true;
            if((tb_Etat.Text.Length != 1) || (!IsNumeric(tb_Etat.Text)))
            {
                error1.SetError(tb_Etat, "Entrez 1 ou 0");
                valide = false;
            }
            else
            {
                if ((tb_Etat.Text != "1") && (tb_Etat.Text != "0"))
                {
                    error1.SetError(tb_Etat, "Entrez 1 ou 0");
                    valide = false;
                }
                else error1.SetError(tb_Etat, "");
            }

            if (!ValidePrix()) valide = false;

            if (!Valide_Ayant()) valide = false;

            if (tb_Loc.Text.Length == 0)
            {
                error1.SetError(tb_Loc, "Sélectionnez une localisation");
                valide = false;
            }
            else error1.SetError(tb_Loc, "");

            if (tb_Type.Text.Length == 0)
            {
                error1.SetError(tb_Type, "Sélectionnez un type de chambre");
                valide = false;
            }
            else error1.SetError(tb_Type, "");

            if (tb_Memo.Text.Length > 25)
            {
                error1.SetError(tb_Memo, "Texte trop long. Max 25 caractères");
                valide = false;
            }

            return valide;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Valide())
            {
                BS_Chambre.Position = 0;
                Dtr_Cham.EndEdit();
                this.TA_Chambre.Update(this.DS_bd.Chambre);
                try
                {
                    this.TA_Ayant.Update(this.DS_bd.Ayant);
                    MessageBox.Show("Chambre créer");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Erreur lors de la création");
                }
                Act_Bout(true, false, false, false, false, false, false, false, true, true, true, true,false,false);
                Act_Saisie(true, false, false, true, false, false, true);
                abandon = false;
            }
        }

        private void tb_Prix_Leave(object sender, EventArgs e)
        {
            if (abandon == false)
                ValidePrix();
        }

        private void dg_selecteur_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView Dtr_Contient = (DataRowView)BS_Ayant.Current;
            if (Dtr_Contient != null)
            {
                Dtr_Contient.BeginEdit();
            }
        }

        private void dg_selecteur_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dg_selecteur.Rows[e.RowIndex].Cells[dg_selecteur.Columns[e.ColumnIndex].Index].ErrorText = "";
            dg_selecteur.Rows[e.RowIndex].ErrorText = "";

            
            if (dg_selecteur.Columns[e.ColumnIndex].DataPropertyName == "CodCom")
            {
                if (dg_selecteur == null)
                {
                    dg_selecteur.Rows[e.RowIndex].ErrorText = "au moins une commodite";
                    dg_selecteur.Rows[e.RowIndex].Cells[dg_selecteur.Columns[e.ColumnIndex].Index].ErrorText = "invalidef";
                    e.Cancel = true;
                }
            }
        }

        private void dg_selecteur_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView Dtr_Contient = (DataRowView)BS_Ayant.Current;
            if (Dtr_Contient != null)
            {
                Dtr_Contient.EndEdit();

                dg_selecteur.Rows[e.RowIndex].Cells[dg_selecteur.Columns[e.ColumnIndex].Index].ErrorText = "";

                if (Dtr_Contient != null)
                {
                    BS_Comm.Position = BS_Comm.Find("CodCom", dg_selecteur.Rows[e.RowIndex].Cells[1].Value);
                }
                Ajuster_Calcul_Comm();
            }
        }
        #endregion

        
    }
}
