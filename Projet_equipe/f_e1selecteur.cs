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
    public partial class f_e1selecteur : Form
    {
        f_e1 f;
        public f_e1selecteur(f_e1 inc)
        {
            InitializeComponent();
            this.f = inc;
        }



        private void f_e1selecteur_Load(object sender, EventArgs e)
        {
            this.reservationTableAdapter.Fill(this.DS_bd.Reservation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.f.id = Int32.Parse(dg_selecteur.CurrentRow.Cells[0].Value.ToString());
            this.f.recherche();
            this.Close();
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.f.id = Int32.Parse(dg_selecteur.CurrentRow.Cells[0].Value.ToString());
            this.f.recherche();
            this.Close();
        }
    }
}
