namespace Projet_equipe
{
    partial class f_e1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dp_dateFin = new System.Windows.Forms.DateTimePicker();
            this.dp_dateDebut = new System.Windows.Forms.DateTimePicker();
            this.dp_reserveLe = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Solde = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_reservation = new System.Windows.Forms.DataGridView();
            this.deBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_bde1 = new Projet_equipe.DS_bde1();
            this.tb_noReservation = new System.Windows.Forms.TextBox();
            this.tb_solde = new System.Windows.Forms.TextBox();
            this.tb_expiration = new System.Windows.Forms.TextBox();
            this.tb_typeCarte = new System.Windows.Forms.TextBox();
            this.tb_carte = new System.Windows.Forms.TextBox();
            this.tb_telephone = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_noClient = new System.Windows.Forms.TextBox();
            this.btn_dernier = new System.Windows.Forms.Button();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_premier = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_liste = new System.Windows.Forms.Button();
            this.btn_consulter = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_lister = new System.Windows.Forms.Button();
            this.BS_reservation = new System.Windows.Forms.BindingSource(this.components);
            this.DS_bd = new Projet_equipe.DS_bde1();
            this.BS_client = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Projet_equipe.DS_bde1TableAdapters.ClientTableAdapter();
            this.TA_client = new Projet_equipe.DS_bde1TableAdapters.ClientTableAdapter();
            this.TA_reservation = new Projet_equipe.DS_bde1TableAdapters.ReservationTableAdapter();
            this.TA_de = new Projet_equipe.DS_bde1TableAdapters.DeTableAdapter();
            this.BS_de = new System.Windows.Forms.BindingSource(this.components);
            this.BS_dee = new System.Windows.Forms.BindingSource(this.components);
            this.BS_chambre = new System.Windows.Forms.BindingSource(this.components);
            this.chambreTableAdapter = new Projet_equipe.DS_bde1TableAdapters.ChambreTableAdapter();
            this.BS_typeChambre = new System.Windows.Forms.BindingSource(this.components);
            this.TA_typeChambre = new Projet_equipe.DS_bde1TableAdapters.TypeChamTableAdapter();
            this.arriveTableAdapter = new Projet_equipe.DS_bde1TableAdapters.ArriveTableAdapter();
            this.NoCham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attribuee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_bde1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_reservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_de)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_dee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_typeChambre)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dp_dateFin);
            this.panel1.Controls.Add(this.dp_dateDebut);
            this.panel1.Controls.Add(this.dp_reserveLe);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Solde);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dg_reservation);
            this.panel1.Controls.Add(this.tb_noReservation);
            this.panel1.Controls.Add(this.tb_solde);
            this.panel1.Controls.Add(this.tb_expiration);
            this.panel1.Controls.Add(this.tb_typeCarte);
            this.panel1.Controls.Add(this.tb_carte);
            this.panel1.Controls.Add(this.tb_telephone);
            this.panel1.Controls.Add(this.tb_adresse);
            this.panel1.Controls.Add(this.tb_nom);
            this.panel1.Controls.Add(this.tb_noClient);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 428);
            this.panel1.TabIndex = 25;
            // 
            // dp_dateFin
            // 
            this.dp_dateFin.Location = new System.Drawing.Point(552, 185);
            this.dp_dateFin.Name = "dp_dateFin";
            this.dp_dateFin.Size = new System.Drawing.Size(200, 20);
            this.dp_dateFin.TabIndex = 27;
            // 
            // dp_dateDebut
            // 
            this.dp_dateDebut.Location = new System.Drawing.Point(552, 149);
            this.dp_dateDebut.Name = "dp_dateDebut";
            this.dp_dateDebut.Size = new System.Drawing.Size(200, 20);
            this.dp_dateDebut.TabIndex = 26;
            // 
            // dp_reserveLe
            // 
            this.dp_reserveLe.Location = new System.Drawing.Point(552, 105);
            this.dp_reserveLe.Name = "dp_reserveLe";
            this.dp_reserveLe.Size = new System.Drawing.Size(200, 20);
            this.dp_reserveLe.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(487, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Date de fin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label11.Location = new System.Drawing.Point(471, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Date de début";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(487, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Réservé le";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(462, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "No. Réservation";
            // 
            // Solde
            // 
            this.Solde.AutoSize = true;
            this.Solde.Location = new System.Drawing.Point(603, 222);
            this.Solde.Name = "Solde";
            this.Solde.Size = new System.Drawing.Size(34, 13);
            this.Solde.TabIndex = 20;
            this.Solde.Text = "Solde";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Expiration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Type de Carte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "No. Carte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Téléphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Client no";
            // 
            // dg_reservation
            // 
            this.dg_reservation.AllowUserToAddRows = false;
            this.dg_reservation.AllowUserToDeleteRows = false;
            this.dg_reservation.AutoGenerateColumns = false;
            this.dg_reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_reservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoCham,
            this.DescTyp,
            this.Prix,
            this.Attribuee});
            this.dg_reservation.DataSource = this.BS_de;
            this.dg_reservation.Location = new System.Drawing.Point(4, 271);
            this.dg_reservation.Name = "dg_reservation";
            this.dg_reservation.ReadOnly = true;
            this.dg_reservation.Size = new System.Drawing.Size(778, 154);
            this.dg_reservation.TabIndex = 12;
            // 
            // deBindingSource
            // 
            this.deBindingSource.DataMember = "De";
            this.deBindingSource.DataSource = this.dS_bde1;
            // 
            // dS_bde1
            // 
            this.dS_bde1.DataSetName = "DS_bde1";
            this.dS_bde1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_noReservation
            // 
            this.tb_noReservation.Location = new System.Drawing.Point(552, 68);
            this.tb_noReservation.Name = "tb_noReservation";
            this.tb_noReservation.Size = new System.Drawing.Size(200, 20);
            this.tb_noReservation.TabIndex = 8;
            this.tb_noReservation.DoubleClick += new System.EventHandler(this.tb_noReservation_DoubleClick);
            // 
            // tb_solde
            // 
            this.tb_solde.Location = new System.Drawing.Point(652, 219);
            this.tb_solde.Name = "tb_solde";
            this.tb_solde.Size = new System.Drawing.Size(100, 20);
            this.tb_solde.TabIndex = 7;
            // 
            // tb_expiration
            // 
            this.tb_expiration.Location = new System.Drawing.Point(81, 219);
            this.tb_expiration.Name = "tb_expiration";
            this.tb_expiration.Size = new System.Drawing.Size(100, 20);
            this.tb_expiration.TabIndex = 6;
            // 
            // tb_typeCarte
            // 
            this.tb_typeCarte.Location = new System.Drawing.Point(81, 172);
            this.tb_typeCarte.Name = "tb_typeCarte";
            this.tb_typeCarte.Size = new System.Drawing.Size(321, 20);
            this.tb_typeCarte.TabIndex = 5;
            // 
            // tb_carte
            // 
            this.tb_carte.Location = new System.Drawing.Point(258, 119);
            this.tb_carte.Name = "tb_carte";
            this.tb_carte.Size = new System.Drawing.Size(144, 20);
            this.tb_carte.TabIndex = 4;
            // 
            // tb_telephone
            // 
            this.tb_telephone.Location = new System.Drawing.Point(81, 119);
            this.tb_telephone.Name = "tb_telephone";
            this.tb_telephone.Size = new System.Drawing.Size(100, 20);
            this.tb_telephone.TabIndex = 3;
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(81, 75);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(321, 20);
            this.tb_adresse.TabIndex = 2;
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(245, 38);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(157, 20);
            this.tb_nom.TabIndex = 1;
            // 
            // tb_noClient
            // 
            this.tb_noClient.Location = new System.Drawing.Point(81, 38);
            this.tb_noClient.Name = "tb_noClient";
            this.tb_noClient.Size = new System.Drawing.Size(100, 20);
            this.tb_noClient.TabIndex = 0;
            // 
            // btn_dernier
            // 
            this.btn_dernier.Location = new System.Drawing.Point(455, 475);
            this.btn_dernier.Name = "btn_dernier";
            this.btn_dernier.Size = new System.Drawing.Size(35, 25);
            this.btn_dernier.TabIndex = 24;
            this.btn_dernier.Text = ">>";
            this.btn_dernier.UseVisualStyleBackColor = true;
            this.btn_dernier.Click += new System.EventHandler(this.btn_dernier_Click);
            // 
            // btn_suivant
            // 
            this.btn_suivant.Location = new System.Drawing.Point(414, 475);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(35, 25);
            this.btn_suivant.TabIndex = 23;
            this.btn_suivant.Text = ">";
            this.btn_suivant.UseVisualStyleBackColor = true;
            this.btn_suivant.Click += new System.EventHandler(this.btn_suivant_Click);
            // 
            // btn_precedent
            // 
            this.btn_precedent.Location = new System.Drawing.Point(359, 475);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(35, 25);
            this.btn_precedent.TabIndex = 22;
            this.btn_precedent.Text = "<";
            this.btn_precedent.UseVisualStyleBackColor = true;
            this.btn_precedent.Click += new System.EventHandler(this.btn_precedent_Click);
            // 
            // btn_premier
            // 
            this.btn_premier.Location = new System.Drawing.Point(318, 475);
            this.btn_premier.Name = "btn_premier";
            this.btn_premier.Size = new System.Drawing.Size(35, 25);
            this.btn_premier.TabIndex = 21;
            this.btn_premier.Text = "<<";
            this.btn_premier.UseVisualStyleBackColor = true;
            this.btn_premier.Click += new System.EventHandler(this.btn_premier_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(722, 11);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(75, 23);
            this.btn_quitter.TabIndex = 20;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(640, 11);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 19;
            this.btn_annuler.Text = "En dév";
            this.btn_annuler.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(558, 11);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "En dév";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_liste
            // 
            this.btn_liste.Location = new System.Drawing.Point(476, 11);
            this.btn_liste.Name = "btn_liste";
            this.btn_liste.Size = new System.Drawing.Size(75, 23);
            this.btn_liste.TabIndex = 17;
            this.btn_liste.Text = "Liste";
            this.btn_liste.UseVisualStyleBackColor = true;
            this.btn_liste.Click += new System.EventHandler(this.btn_liste_Click);
            // 
            // btn_consulter
            // 
            this.btn_consulter.Location = new System.Drawing.Point(257, 11);
            this.btn_consulter.Name = "btn_consulter";
            this.btn_consulter.Size = new System.Drawing.Size(75, 23);
            this.btn_consulter.TabIndex = 16;
            this.btn_consulter.Text = "Consulter";
            this.btn_consulter.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(175, 11);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 15;
            this.btn_supprimer.Text = "En dév";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(93, 11);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 14;
            this.btn_modifier.Text = "En dév";
            this.btn_modifier.UseVisualStyleBackColor = true;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(12, 11);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 13;
            this.btn_ajouter.Text = "En dév";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            // 
            // btn_lister
            // 
            this.btn_lister.Location = new System.Drawing.Point(339, 11);
            this.btn_lister.Name = "btn_lister";
            this.btn_lister.Size = new System.Drawing.Size(75, 23);
            this.btn_lister.TabIndex = 26;
            this.btn_lister.Text = "En dév";
            this.btn_lister.UseVisualStyleBackColor = true;
            // 
            // BS_reservation
            // 
            this.BS_reservation.DataMember = "Reservation";
            this.BS_reservation.DataSource = this.DS_bd;
            // 
            // DS_bd
            // 
            this.DS_bd.DataSetName = "DS_bde1";
            this.DS_bd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BS_client
            // 
            this.BS_client.DataMember = "Client";
            this.BS_client.DataSource = this.DS_bd;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // TA_client
            // 
            this.TA_client.ClearBeforeFill = true;
            // 
            // TA_reservation
            // 
            this.TA_reservation.ClearBeforeFill = true;
            // 
            // TA_de
            // 
            this.TA_de.ClearBeforeFill = true;
            // 
            // BS_de
            // 
            this.BS_de.DataMember = "FK__De__IdReser__6EF57B66";
            this.BS_de.DataSource = this.BS_reservation;
            // 
            // BS_dee
            // 
            this.BS_dee.DataMember = "De";
            this.BS_dee.DataSource = this.DS_bd;
            // 
            // BS_chambre
            // 
            this.BS_chambre.DataMember = "Chambre";
            this.BS_chambre.DataSource = this.DS_bd;
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // BS_typeChambre
            // 
            this.BS_typeChambre.DataMember = "TypeCham";
            this.BS_typeChambre.DataSource = this.DS_bd;
            // 
            // TA_typeChambre
            // 
            this.TA_typeChambre.ClearBeforeFill = true;
            // 
            // arriveTableAdapter
            // 
            this.arriveTableAdapter.ClearBeforeFill = true;
            // 
            // NoCham
            // 
            this.NoCham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NoCham.DataPropertyName = "NoCham";
            this.NoCham.HeaderText = "NoCham";
            this.NoCham.Name = "NoCham";
            // 
            // DescTyp
            // 
            this.DescTyp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescTyp.DataPropertyName = "DescTyp";
            this.DescTyp.HeaderText = "DescTyp";
            this.DescTyp.Name = "DescTyp";
            // 
            // Prix
            // 
            this.Prix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prix.DataPropertyName = "Prix";
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            // 
            // Attribuee
            // 
            this.Attribuee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Attribuee.DataPropertyName = "Attribuee";
            this.Attribuee.HeaderText = "Attribuee";
            this.Attribuee.Name = "Attribuee";
            // 
            // f_e1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(809, 506);
            this.Controls.Add(this.btn_lister);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_dernier);
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.btn_precedent);
            this.Controls.Add(this.btn_premier);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_liste);
            this.Controls.Add(this.btn_consulter);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Name = "f_e1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Réservation";
            this.Load += new System.EventHandler(this.f_e1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_bde1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_reservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_de)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_dee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_typeChambre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_dernier;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_premier;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_liste;
        private System.Windows.Forms.Button btn_consulter;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_lister;
        private System.Windows.Forms.TextBox tb_noClient;
        private System.Windows.Forms.DataGridView dg_reservation;
        private System.Windows.Forms.TextBox tb_noReservation;
        private System.Windows.Forms.TextBox tb_solde;
        private System.Windows.Forms.TextBox tb_expiration;
        private System.Windows.Forms.TextBox tb_typeCarte;
        private System.Windows.Forms.TextBox tb_carte;
        private System.Windows.Forms.TextBox tb_telephone;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.DateTimePicker dp_dateFin;
        private System.Windows.Forms.DateTimePicker dp_dateDebut;
        private System.Windows.Forms.DateTimePicker dp_reserveLe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Solde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource BS_client;
        private DS_bde1 DS_bd;
        private DS_bde1TableAdapters.ClientTableAdapter clientTableAdapter;
        private DS_bde1TableAdapters.ClientTableAdapter TA_client;
        private System.Windows.Forms.BindingSource BS_reservation;
        private DS_bde1TableAdapters.ReservationTableAdapter TA_reservation;
        private DS_bde1TableAdapters.DeTableAdapter TA_de;
        private System.Windows.Forms.BindingSource BS_de;
        private DS_bde1 dS_bde1;
        private System.Windows.Forms.BindingSource deBindingSource;
        private System.Windows.Forms.BindingSource BS_dee;
        private System.Windows.Forms.BindingSource BS_chambre;
        private DS_bde1TableAdapters.ChambreTableAdapter chambreTableAdapter;
        private System.Windows.Forms.BindingSource BS_typeChambre;
        private DS_bde1TableAdapters.TypeChamTableAdapter TA_typeChambre;
        private DS_bde1TableAdapters.ArriveTableAdapter arriveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoCham;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescTyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attribuee;
    }
}