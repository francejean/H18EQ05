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
    public partial class f_e2selectComm : Form
    {
        f_e2 f;
        public f_e2selectComm()
        {
            InitializeComponent();
            //this.f = inc;
        }
        public DataGridView _dg_comm
        {
            get
            {
                return dg_comm;
            }
            set
            {
            }
        }

       /* private void f_e2selectComm_Load(object sender, EventArgs e)
        {
            this.TA_Comm.Fill(this.DS_bd.Commodite);
            this.TA_BK_Comm.FillBy(this.DS_bd.BK_Commodite, this.DS_bd.Tables["Chambre"].Rows[BS_Chambre.Position]["NoCham"].ToString());
        }*/

        private void btn_ok_Click(object sender, EventArgs e)
        {
            /*this.f.id = Int32.Parse(dg_selecteur.CurrentRow.Cells[0].Value.ToString());
            this.f.recherche();
            this.Close();*/
            this.Visible = false;
        }

        private void dg_selecteur_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*this.f.id = Int32.Parse(dg_selecteur.CurrentRow.Cells[0].Value.ToString());
            this.f.recherche();
            this.Close();*/
        }

        private void dg_selecteur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
