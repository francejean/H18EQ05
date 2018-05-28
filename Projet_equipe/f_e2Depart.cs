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
    public partial class f_e2Depart : Form
    {
        public int id;
        private int idx;
        private bool dans;
        private bool valide = false;
        private f_e2Conf Conf = new f_e2Conf();
        public f_e2Depart()
        {
            InitializeComponent();
            this.TA_Arrive.Fill(this.DS_bd.Arrive);
            this.TA_Depart.Fill(this.DS_bd.Depart);
            this.TA_De.Fill(this.DS_bd.De);
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            f_e2Arrive f = new Projet_equipe.f_e2Arrive(this);
            f.Show();
        }

        public void Add()
        {
            this.BS_Arrive.Position = this.BS_Arrive.Find("IdArrive", this.id);
            this.BS_Arrive.DataMember = "Arrive";
            this.BS_Arrive.DataSource = this.DS_bd;

            try
            {
                tb_cham.DataBindings.Add("Text", BS_Arrive, "NoCham");
                tb_reser.DataBindings.Add("Text", BS_Arrive, "IdReser");
                tb_cli.DataBindings.Add("Text", BS_Arrive, "IdCli");
            }
            catch (Exception ee) { }

        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_conf_Validating(object sender, CancelEventArgs e)
        {
            if ((tb_conf.Text.Length == 0) || (IsNumeric(tb_conf.Text)))
                {
                    error1.SetError(tb_conf, "Entrez deux caractère");
                    tb_conf.Focus();
                    valide = false;
                }
                else
                {
                    if (tb_conf.Text.Length != 2)
                    {
                        error1.SetError(tb_conf, "Entrez 2 caractères");
                        tb_conf.Focus();
                        valide = false;
                    }
                    else
                    {
                        error1.SetError(tb_conf, "");
                        valide = true;
                    }
                }
            Valide();
        }

        private void Valide()
        {
            if (tb_reser.Text.Length == 0)
            {
                error1.SetError(tb_reser, "Sélectionnez une arrive");
                valide = false;
            }
            else
            {
                error1.SetError(tb_reser, "");
                valide = true;
            }

            if (tb_cham.Text.Length == 0)
            {
                error1.SetError(tb_cham, "Sélectionnez une arrive");
                valide = false;
            }
            else
            {
                error1.SetError(tb_cham, "");
                valide = true;
            }

            if (tb_cli.Text.Length == 0)
            {
                error1.SetError(tb_cli, "Sélectionnez une arrive");
                valide = false;
            }
            else
            {
                error1.SetError(tb_cli, "");
                valide = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (valide == true)
            {
                if (Conf.ShowDialog() == DialogResult.OK)
                {
                    test();
                }
            }
            else
            {
                tb_conf.Focus();
                error1.SetError(tb_conf, "Entrez deux caractère");
            }
        }

        private void test()
        {
            BS_Depart.Position = 0;
            dans = false;
            foreach(DataRow Dtr_Depart in DS_bd.Tables["Depart"].Rows)
            {
                idx = 0;
                if (tb_reser.Text == DS_bd.Tables["Depart"].Rows[BS_Depart.Position]["IdReser"].ToString())
                {
                    idx += 1;
                }
                if (tb_cham.Text == DS_bd.Tables["Depart"].Rows[BS_Depart.Position]["NoCham"].ToString())
                {
                    idx += 1;
                }
                if (tb_cli.Text == DS_bd.Tables["Depart"].Rows[BS_Depart.Position]["IdCli"].ToString())
                {
                    idx += 1;
                }
                if (idx >= 3)
                {
                    dans = true;
                }
                BS_Depart.Position += 1;
            }
            if (dans == false)
            {
                MessageBox.Show("Le depart ajouter");
                Save();
            }
            else
            {
                MessageBox.Show("Le depart existe déjà");
            }
        }

        private void Save()
        {
            DataRow Dtr_add;
            Dtr_add = DS_bd.Tables["Depart"].NewRow();
            Dtr_add["ConfirmerPar"] = tb_conf.Text;
            Dtr_add["IdReser"] = Convert.ToInt32(tb_reser.Text);
            Dtr_add["NoCham"] = tb_cham.Text;
            Dtr_add["IdCli"] = Convert.ToInt32(tb_cli.Text);
            Dtr_add["DateDepart"] = dp_Depart.Value;
            DS_bd.Tables["Depart"].Rows.Add(Dtr_add);
            this.TA_Depart.Update(this.DS_bd.Depart);
            DE();
        }

        private void DE()
        {
            BS_De.Position = 0;
            foreach (DataRow Dtr_De in DS_bd.Tables["De"].Rows)
            {
                idx = 0;
                if (tb_reser.Text == DS_bd.Tables["De"].Rows[BS_De.Position]["IdReser"].ToString())
                {
                    idx += 1;
                }
                if (tb_cham.Text == DS_bd.Tables["De"].Rows[BS_De.Position]["NoCham"].ToString())
                {
                    idx += 1;
                }
                if (idx >= 2)
                {
                    TA_De.Update1(Convert.ToInt32(tb_reser.Text), tb_cham.Text);
                }
                BS_De.Position += 1;
            }
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            f_e2Liste l = new Projet_equipe.f_e2Liste();
            l.Show();
        }
    }
}
