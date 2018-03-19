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
    public partial class f_e2selecteur : Form
    {
        f_e2 f;
        public f_e2selecteur(f_e2 inc)
        {
            InitializeComponent();
            this.f = inc;
        }

        private void f_e2selecteur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'DS_bd.Chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.TA_Chambre.Fill(this.DS_bd.Chambre);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.f.id = Int32.Parse(dg_selecteur.CurrentRow.Cells[0].Value.ToString());
            this.f.recherche();
            this.Close();
        }

        private void dg_selecteur_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.f.id = Int32.Parse(dg_selecteur.CurrentRow.Cells[0].Value.ToString());
            this.f.recherche();
            this.Close();
        }
    }
}
