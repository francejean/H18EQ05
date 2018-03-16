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
    public partial class f_e1 : Form
    {
        public f_e1()
        {
            InitializeComponent();
        }

        private void f_e1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dS_bde1.De'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.TA_de.Fill(this.dS_bde1.De);
            // TODO: cette ligne de code charge les données dans la table 'DS_bd.Reservation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.reservationTableAdapter.Fill(this.DS_bd.Reservation);
            // TODO: cette ligne de code charge les données dans la table 'DS_bd.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.DS_bd.Client);
            this.TA_client.Fill(this.DS_bd.Client);
            Fill();
            Lien();
        }

        private void Fill()
        {
            this.TA_client.Fill(this.DS_bd.Client);
            //this.TA_reservation.Fill(this.DS_bd.Reservation);
            this.TA_reservation.FillBy(this.DS_bd.Reservation);
            this.TA_de.Fill(this.DS_bd.De);
        }
        private void Lien()
        {
            this.BS_client.DataMember = "Client";
            this.BS_client.DataSource = this.DS_bd;

            this.BS_reservation.DataMember = "Reservation";
            this.BS_reservation.DataSource = this.DS_bd;

            this.BS_de.DataMember = "FK_De_IdReser_6EF57B66";
            this.BS_de.DataSource = this.BS_reservation;
            this.dg_reservation.DataSource = BS_de;

            try
            {
                tb_noClient.DataBindings.Add("Text", BS_reservation, "IdCli");
                tb_noReservation.DataBindings.Add("Text", BS_reservation, "IdReser");
                dp_reserveLe.DataBindings.Add("Text", BS_reservation, "DateReser");
                dp_dateDebut.DataBindings.Add("Text", BS_reservation, "DateDebut");
                dp_dateFin.DataBindings.Add("Text", BS_reservation, "DateFin");
                tb_nom.DataBindings.Add("Text", BS_reservation, "Nom");
                tb_adresse.DataBindings.Add("Text", BS_reservation, "Adresse");
                tb_telephone.DataBindings.Add("Text", BS_reservation, "Telephone");
                tb_carte.DataBindings.Add("Text", BS_reservation, "NoCarte");
                tb_typeCarte.DataBindings.Add("Text", BS_reservation, "TypeCarte");
                tb_expiration.DataBindings.Add("Text", BS_reservation, "DatExp");
            }
            catch(Exception ee)
            {
                MessageBox.Show("Erreur");
            }
        }

        // Boutons first, précédent, suivant et dernier
        private void btn_premier_Click(object sender, EventArgs e)
        {
            this.BS_reservation.MoveFirst();
        }
        private void btn_precedent_Click(object sender, EventArgs e)
        {
            this.BS_reservation.MovePrevious();
        }
        private void btn_suivant_Click(object sender, EventArgs e)
        {
            this.BS_reservation.MoveNext();
        }
        private void btn_dernier_Click(object sender, EventArgs e)
        {
            this.BS_reservation.MoveLast();
        }
        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
