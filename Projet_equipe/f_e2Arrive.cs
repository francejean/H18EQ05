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
    public partial class f_e2Arrive : Form
    {
        f_e2Depart f;
        public f_e2Arrive(f_e2Depart inc)
        {
            InitializeComponent();
            this.f = inc;
        }

        private void f_e2Arrive_Load(object sender, EventArgs e)
        {
            //this.TA_Arrive.Fill(this.DS_bd.Arrive);
            this.TA_Arrive.FillBy(this.DS_bd.Arrive);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.f.id = Int32.Parse(dg_selecteur.CurrentRow.Cells[0].Value.ToString());
            this.f.Add();
            this.Close();
        }

        private void dg_selecteur_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.f.id = Int32.Parse(dg_selecteur.CurrentRow.Cells[0].Value.ToString());
            this.f.Add();
            this.Close();
        }
    }
}
