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
        public int id;
        public f_e1()
        {
            InitializeComponent();
            btn_ajouter.Enabled = false;
            btn_modifier.Enabled = false;
            btn_supprimer.Enabled = false;
            btn_consulter.Enabled = false;
            btn_annuler.Enabled = false;
            btn_lister.Enabled = false;
            btn_save.Enabled = false;
        }

        private void f_e1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'DS_bd.Arrive'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.arriveTableAdapter.Fill(this.DS_bd.Arrive);
            // TODO: cette ligne de code charge les données dans la table 'DS_bd.TypeCham'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.TA_typeChambre.Fill(this.DS_bd.TypeCham);
            // TODO: cette ligne de code charge les données dans la table 'DS_bd.Chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambreTableAdapter.Fill(this.DS_bd.Chambre);
            // TODO: cette ligne de code charge les données dans la table 'DS_bd.Chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambreTableAdapter.Fill(this.DS_bd.Chambre);
            Fill();
            Lien();
            LienGrid();
            this.BS_client.Position = this.BS_client.Find("IdCli", ((DataRowView)this.BS_reservation.Current).Row["Idcli"]);
        }

        private void Fill()
        {
            this.TA_client.Fill(this.DS_bd.Client);
            this.TA_reservation.Fill(this.DS_bd.Reservation);
            this.TA_de.Fill(this.DS_bd.De);
            this.TA_typeChambre.Fill(this.DS_bd.TypeCham);
        }
        private void Lien()
        {
            this.BS_client.DataMember = "Client";
            this.BS_client.DataSource = this.DS_bd;

            this.BS_reservation.DataMember = "Reservation";
            this.BS_reservation.DataSource = this.DS_bd;

            try
            {
                tb_noClient.DataBindings.Add("Text", BS_client, "IdCli");
                tb_noReservation.DataBindings.Add("Text", BS_reservation, "IdReser");
                dp_reserveLe.DataBindings.Add("Text", BS_reservation, "DateReser");
                dp_dateDebut.DataBindings.Add("Text", BS_reservation, "DateDebut");
                dp_dateFin.DataBindings.Add("Text", BS_reservation, "DateFin");
                tb_nom.DataBindings.Add("Text", BS_client, "Nom");
                tb_adresse.DataBindings.Add("Text", BS_client, "Adresse");
                tb_telephone.DataBindings.Add("Text", BS_client, "Telephone");
                tb_carte.DataBindings.Add("Text", BS_client, "NoCarte");
                tb_typeCarte.DataBindings.Add("Text", BS_client, "TypeCarte");
                tb_expiration.DataBindings.Add("Text", BS_client, "DatExp");
                tb_solde.DataBindings.Add("Text", BS_client, "SoldeDu");

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void LienGrid()
        {
            int i = 0;
            double solde = 0;
            this.BS_dee.Position = 0;
            foreach (DataRow Dtr_Contient in DS_bd.Tables["De"].Rows)
            {

                // dS_Bon.Tables["Contient"].Rows[Bs_Contient.Position]["Nom_Prod"] = dS_Bon.Tables["Contient"].Rows[Bs_Contient.Position].GetParentRow("fk_connp")["Nom_Prod"].ToString();
                //if (BS_de.Position != -1)

                // Donc ici, pour chaque itération de la table de, on devrait pouvoir aller chercher les infos manquantes
                // On cherche mets toutes les tables à la même place
                this.BS_chambre.Position = this.BS_chambre.Find("NoCham", ((DataRowView)this.BS_dee.Current).Row["NoCham"]);
                this.BS_typeChambre.Position = this.BS_typeChambre.Find("CodTypChan", ((DataRowView)this.BS_chambre.Current).Row["CodTypChan"]);

                // On applique les informations nécessaire dans les bindings sources
                this.DS_bd.Tables["De"].Rows[i]["Prix"] = this.DS_bd.Tables["Chambre"].Rows[BS_chambre.Position]["Prix"];
                this.DS_bd.Tables["De"].Rows[i]["DescTyp"] = this.DS_bd.Tables["TypeCham"].Rows[BS_chambre.Position]["DescTyp"];

                i++;
                this.BS_dee.Position++;
            }
            this.DS_bd.Tables["De"].AcceptChanges();

            /*this.BS_dee.MoveLast();
            this.BS_reservation.MoveLast();
            this.BS_chambre.MoveLast();

            for (int y = 0; y <= this.BS_reservation.Position; y++)  // Pour chaque réservation
            {
                solde = 0;

                for (int z = 0; z <= this.BS_dee.Position; z++)   // Pour chaque De
                {
                    if (this.DS_bd.Tables["Reservation"].Rows[y]["IdReser"].ToString() == this.DS_bd.Tables["De"].Rows[z]["IdReser"].ToString())
                    {
                        for (int ii = 0; ii <= this.BS_chambre.Position; ii++)   // Pour chaque chambre
                        {
                            if (this.DS_bd.Tables["De"].Rows[z]["NoCham"].ToString() == this.DS_bd.Tables["Chambre"].Rows[ii]["NoCham"].ToString())
                                solde += double.Parse(this.DS_bd.Tables["Chambre"].Rows[ii]["Prix"].ToString());
                        }
                    }
                }
                this.DS_bd.Tables["Reservation"].Rows[y]["Solde"] = solde;
            }
            this.BS_reservation.MoveFirst();*/
        }

        // Boutons first, précédent, suivant et dernier
        private void btn_premier_Click(object sender, EventArgs e)
        {
            this.BS_reservation.MoveFirst();
            this.BS_client.Position = this.BS_client.Find("IdCli", ((DataRowView)this.BS_reservation.Current).Row["Idcli"]);
        }
        private void btn_precedent_Click(object sender, EventArgs e)
        {
            this.BS_reservation.MovePrevious();
            this.BS_client.Position = this.BS_client.Find("IdCli", ((DataRowView)this.BS_reservation.Current).Row["Idcli"]);
        }
        private void btn_suivant_Click(object sender, EventArgs e)
        {
            this.BS_reservation.MoveNext();
            this.BS_client.Position = this.BS_client.Find("IdCli", ((DataRowView)this.BS_reservation.Current).Row["Idcli"]);
        }
        private void btn_dernier_Click(object sender, EventArgs e)
        {
            this.BS_reservation.MoveLast();
            this.BS_client.Position = this.BS_client.Find("IdCli", ((DataRowView)this.BS_reservation.Current).Row["Idcli"]);
        }

        public void recherche()
        {
            this.BS_reservation.Position = this.BS_reservation.Find("IdReser", this.id);
            this.BS_client.Position = this.BS_client.Find("IdCli", ((DataRowView)this.BS_reservation.Current).Row["Idcli"]);
        }

        private void btn_quitter_Click(object sender, EventArgs e) { this.Close(); }

        private void tb_noReservation_DoubleClick(object sender, EventArgs e)
        {
            f_e1selecteur f = new Projet_equipe.f_e1selecteur(this);
            f.Show();
        }

        private void btn_liste_Click(object sender, EventArgs e)
        {
            f_e1selecteur f = new Projet_equipe.f_e1selecteur(this);
            f.Show();
        }
    }
}
