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
    public partial class f_e2selectLoc : Form
    {
        f_e2 f;
        public f_e2selectLoc(f_e2 inc)
        {
            InitializeComponent();
            this.f = inc;
        }

        private void f_e2selectLoc_Load(object sender, EventArgs e)
        {
            this.TA_Loc.Fill(this.DS_bd.Localisation);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.f.add = dg_selecteur.CurrentRow.Cells[0].Value.ToString();
            this.f.ValideLoc();
            this.Close();
        }

        private void dg_selecteur_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.f.add = dg_selecteur.CurrentRow.Cells[0].Value.ToString();
            this.f.ValideLoc();
            this.Close();
        }
    }
}
