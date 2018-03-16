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
    public partial class f_accueil : Form
    {

        public f_e1 fE1;
        public f_e2 fE2;
        public f_accueil()
        {
            InitializeComponent();
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
            fE1 = new f_e1();
            fE1.Show();
        }

        private void btn_chambre_Click(object sender, EventArgs e)
        {
            fE2 = new f_e2();
            fE2.Show();
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
