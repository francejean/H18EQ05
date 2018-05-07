namespace Projet_equipe
{
    partial class f_e2
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
            this.btn_lister = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Ajout_Comm = new System.Windows.Forms.Button();
            this.dg_selecteur = new System.Windows.Forms.DataGridView();
            this.BS_Ayant = new System.Windows.Forms.BindingSource(this.components);
            this.DS_bd = new Projet_equipe.DS_bd();
            this.tb_Prix = new System.Windows.Forms.TextBox();
            this.tb_Memo = new System.Windows.Forms.TextBox();
            this.tb_D_Loc = new System.Windows.Forms.TextBox();
            this.tb_D_Type = new System.Windows.Forms.TextBox();
            this.tb_Type = new System.Windows.Forms.TextBox();
            this.tb_Loc = new System.Windows.Forms.TextBox();
            this.tb_Etat = new System.Windows.Forms.TextBox();
            this.tb_Etage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Cham = new System.Windows.Forms.TextBox();
            this.BS_Chambre = new System.Windows.Forms.BindingSource(this.components);
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
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TA_Chambre = new Projet_equipe.DS_bdTableAdapters.ChambreTableAdapter();
            this.TA_Ayant = new Projet_equipe.DS_bdTableAdapters.AyantTableAdapter();
            this.TA_Comm = new Projet_equipe.DS_bdTableAdapters.CommoditeTableAdapter();
            this.BS_Comm = new System.Windows.Forms.BindingSource(this.components);
            this.TA_Loc = new Projet_equipe.DS_bdTableAdapters.LocalisationTableAdapter();
            this.BS_Loc = new System.Windows.Forms.BindingSource(this.components);
            this.TA_T_Cham = new Projet_equipe.DS_bdTableAdapters.TypeChamTableAdapter();
            this.BS_T_Cham = new System.Windows.Forms.BindingSource(this.components);
            this.BS_Ayantt = new System.Windows.Forms.BindingSource(this.components);
            this.TA_BK_Comm = new Projet_equipe.DS_bdTableAdapters.BK_CommoditeTableAdapter();
            this.btn_supp = new System.Windows.Forms.Button();
            this.codComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_selecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Ayant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Comm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Loc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_T_Cham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Ayantt)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_lister
            // 
            this.btn_lister.Enabled = false;
            this.btn_lister.Location = new System.Drawing.Point(339, 9);
            this.btn_lister.Name = "btn_lister";
            this.btn_lister.Size = new System.Drawing.Size(75, 23);
            this.btn_lister.TabIndex = 40;
            this.btn_lister.Text = "En dév";
            this.btn_lister.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_supp);
            this.panel1.Controls.Add(this.btn_Ajout_Comm);
            this.panel1.Controls.Add(this.dg_selecteur);
            this.panel1.Controls.Add(this.tb_Prix);
            this.panel1.Controls.Add(this.tb_Memo);
            this.panel1.Controls.Add(this.tb_D_Loc);
            this.panel1.Controls.Add(this.tb_D_Type);
            this.panel1.Controls.Add(this.tb_Type);
            this.panel1.Controls.Add(this.tb_Loc);
            this.panel1.Controls.Add(this.tb_Etat);
            this.panel1.Controls.Add(this.tb_Etage);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_Cham);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 428);
            this.panel1.TabIndex = 39;
            // 
            // btn_Ajout_Comm
            // 
            this.btn_Ajout_Comm.Enabled = false;
            this.btn_Ajout_Comm.Location = new System.Drawing.Point(41, 165);
            this.btn_Ajout_Comm.Name = "btn_Ajout_Comm";
            this.btn_Ajout_Comm.Size = new System.Drawing.Size(45, 23);
            this.btn_Ajout_Comm.TabIndex = 19;
            this.btn_Ajout_Comm.Text = "Ajout";
            this.btn_Ajout_Comm.UseVisualStyleBackColor = true;
            this.btn_Ajout_Comm.Click += new System.EventHandler(this.btn_Ajout_Comm_Click);
            // 
            // dg_selecteur
            // 
            this.dg_selecteur.AllowUserToAddRows = false;
            this.dg_selecteur.AllowUserToDeleteRows = false;
            this.dg_selecteur.AllowUserToResizeColumns = false;
            this.dg_selecteur.AllowUserToResizeRows = false;
            this.dg_selecteur.AutoGenerateColumns = false;
            this.dg_selecteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_selecteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codComDataGridViewTextBoxColumn,
            this.descComDataGridViewTextBoxColumn});
            this.dg_selecteur.DataSource = this.BS_Ayant;
            this.dg_selecteur.Location = new System.Drawing.Point(17, 194);
            this.dg_selecteur.Name = "dg_selecteur";
            this.dg_selecteur.ReadOnly = true;
            this.dg_selecteur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg_selecteur.Size = new System.Drawing.Size(752, 208);
            this.dg_selecteur.TabIndex = 18;
            this.dg_selecteur.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_selecteur_CellEndEdit);
            this.dg_selecteur.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_selecteur_CellEnter);
            this.dg_selecteur.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dg_selecteur_CellValidating);
            // 
            // BS_Ayant
            // 
            this.BS_Ayant.AllowNew = true;
            this.BS_Ayant.DataMember = "Ayant";
            this.BS_Ayant.DataSource = this.DS_bd;
            // 
            // DS_bd
            // 
            this.DS_bd.DataSetName = "DS_bd";
            this.DS_bd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_Prix
            // 
            this.tb_Prix.Enabled = false;
            this.tb_Prix.Location = new System.Drawing.Point(293, 100);
            this.tb_Prix.Name = "tb_Prix";
            this.tb_Prix.Size = new System.Drawing.Size(100, 20);
            this.tb_Prix.TabIndex = 17;
            this.tb_Prix.Leave += new System.EventHandler(this.tb_Prix_Leave);
            // 
            // tb_Memo
            // 
            this.tb_Memo.Enabled = false;
            this.tb_Memo.Location = new System.Drawing.Point(446, 149);
            this.tb_Memo.Name = "tb_Memo";
            this.tb_Memo.Size = new System.Drawing.Size(323, 20);
            this.tb_Memo.TabIndex = 16;
            // 
            // tb_D_Loc
            // 
            this.tb_D_Loc.Location = new System.Drawing.Point(550, 69);
            this.tb_D_Loc.Name = "tb_D_Loc";
            this.tb_D_Loc.ReadOnly = true;
            this.tb_D_Loc.Size = new System.Drawing.Size(100, 20);
            this.tb_D_Loc.TabIndex = 15;
            // 
            // tb_D_Type
            // 
            this.tb_D_Type.Location = new System.Drawing.Point(550, 35);
            this.tb_D_Type.Name = "tb_D_Type";
            this.tb_D_Type.ReadOnly = true;
            this.tb_D_Type.Size = new System.Drawing.Size(100, 20);
            this.tb_D_Type.TabIndex = 14;
            // 
            // tb_Type
            // 
            this.tb_Type.Location = new System.Drawing.Point(360, 29);
            this.tb_Type.Name = "tb_Type";
            this.tb_Type.ReadOnly = true;
            this.tb_Type.Size = new System.Drawing.Size(100, 20);
            this.tb_Type.TabIndex = 13;
            this.tb_Type.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tb_Type_MouseDoubleClick);
            // 
            // tb_Loc
            // 
            this.tb_Loc.Location = new System.Drawing.Point(360, 69);
            this.tb_Loc.Name = "tb_Loc";
            this.tb_Loc.ReadOnly = true;
            this.tb_Loc.Size = new System.Drawing.Size(100, 20);
            this.tb_Loc.TabIndex = 12;
            this.tb_Loc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tb_Loc_MouseDoubleClick);
            // 
            // tb_Etat
            // 
            this.tb_Etat.Enabled = false;
            this.tb_Etat.Location = new System.Drawing.Point(104, 103);
            this.tb_Etat.Name = "tb_Etat";
            this.tb_Etat.Size = new System.Drawing.Size(100, 20);
            this.tb_Etat.TabIndex = 11;
            // 
            // tb_Etage
            // 
            this.tb_Etage.Enabled = false;
            this.tb_Etage.Location = new System.Drawing.Point(104, 69);
            this.tb_Etage.Name = "tb_Etage";
            this.tb_Etage.Size = new System.Drawing.Size(100, 20);
            this.tb_Etage.TabIndex = 10;
            this.tb_Etage.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Etage_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mémo :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Desc :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Desc :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Prix :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Code Localisation :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Code Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "État :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Étage :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. Cham :";
            // 
            // tb_Cham
            // 
            this.tb_Cham.Location = new System.Drawing.Point(104, 29);
            this.tb_Cham.Name = "tb_Cham";
            this.tb_Cham.ReadOnly = true;
            this.tb_Cham.Size = new System.Drawing.Size(100, 20);
            this.tb_Cham.TabIndex = 0;
            this.tb_Cham.DoubleClick += new System.EventHandler(this.TxT_Cham_DoubleClick);
            this.tb_Cham.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Cham_Validating);
            // 
            // BS_Chambre
            // 
            this.BS_Chambre.DataMember = "Chambre";
            this.BS_Chambre.DataSource = this.DS_bd;
            // 
            // btn_dernier
            // 
            this.btn_dernier.Location = new System.Drawing.Point(455, 473);
            this.btn_dernier.Name = "btn_dernier";
            this.btn_dernier.Size = new System.Drawing.Size(35, 25);
            this.btn_dernier.TabIndex = 38;
            this.btn_dernier.Text = ">>";
            this.btn_dernier.UseVisualStyleBackColor = true;
            this.btn_dernier.Click += new System.EventHandler(this.btn_dernier_Click);
            // 
            // btn_suivant
            // 
            this.btn_suivant.Location = new System.Drawing.Point(414, 473);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(35, 25);
            this.btn_suivant.TabIndex = 37;
            this.btn_suivant.Text = ">";
            this.btn_suivant.UseVisualStyleBackColor = true;
            this.btn_suivant.Click += new System.EventHandler(this.btn_suivant_Click);
            // 
            // btn_precedent
            // 
            this.btn_precedent.Location = new System.Drawing.Point(359, 473);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(35, 25);
            this.btn_precedent.TabIndex = 36;
            this.btn_precedent.Text = "<";
            this.btn_precedent.UseVisualStyleBackColor = true;
            this.btn_precedent.Click += new System.EventHandler(this.btn_precedent_Click);
            // 
            // btn_premier
            // 
            this.btn_premier.Location = new System.Drawing.Point(318, 473);
            this.btn_premier.Name = "btn_premier";
            this.btn_premier.Size = new System.Drawing.Size(35, 25);
            this.btn_premier.TabIndex = 35;
            this.btn_premier.Text = "<<";
            this.btn_premier.UseVisualStyleBackColor = true;
            this.btn_premier.Click += new System.EventHandler(this.btn_premier_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(722, 9);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(75, 23);
            this.btn_quitter.TabIndex = 34;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Enabled = false;
            this.btn_annuler.Location = new System.Drawing.Point(640, 9);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 33;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(558, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 32;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_liste
            // 
            this.btn_liste.Enabled = false;
            this.btn_liste.Location = new System.Drawing.Point(476, 9);
            this.btn_liste.Name = "btn_liste";
            this.btn_liste.Size = new System.Drawing.Size(75, 23);
            this.btn_liste.TabIndex = 31;
            this.btn_liste.Text = "En dév";
            this.btn_liste.UseVisualStyleBackColor = true;
            // 
            // btn_consulter
            // 
            this.btn_consulter.Enabled = false;
            this.btn_consulter.Location = new System.Drawing.Point(257, 9);
            this.btn_consulter.Name = "btn_consulter";
            this.btn_consulter.Size = new System.Drawing.Size(75, 23);
            this.btn_consulter.TabIndex = 30;
            this.btn_consulter.Text = "Consulter";
            this.btn_consulter.UseVisualStyleBackColor = true;
            this.btn_consulter.Click += new System.EventHandler(this.btn_consulter_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Enabled = false;
            this.btn_supprimer.Location = new System.Drawing.Point(175, 9);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 29;
            this.btn_supprimer.Text = "En dév";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Enabled = false;
            this.btn_modifier.Location = new System.Drawing.Point(93, 9);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 28;
            this.btn_modifier.Text = "En dév";
            this.btn_modifier.UseVisualStyleBackColor = true;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(12, 9);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 27;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // TA_Chambre
            // 
            this.TA_Chambre.ClearBeforeFill = true;
            // 
            // TA_Ayant
            // 
            this.TA_Ayant.ClearBeforeFill = true;
            // 
            // TA_Comm
            // 
            this.TA_Comm.ClearBeforeFill = true;
            // 
            // BS_Comm
            // 
            this.BS_Comm.DataMember = "Commodite";
            this.BS_Comm.DataSource = this.DS_bd;
            // 
            // TA_Loc
            // 
            this.TA_Loc.ClearBeforeFill = true;
            // 
            // BS_Loc
            // 
            this.BS_Loc.DataMember = "Localisation";
            this.BS_Loc.DataSource = this.DS_bd;
            // 
            // TA_T_Cham
            // 
            this.TA_T_Cham.ClearBeforeFill = true;
            // 
            // BS_T_Cham
            // 
            this.BS_T_Cham.DataMember = "TypeCham";
            this.BS_T_Cham.DataSource = this.DS_bd;
            // 
            // BS_Ayantt
            // 
            this.BS_Ayantt.DataMember = "Ayant";
            this.BS_Ayantt.DataSource = this.DS_bd;
            // 
            // TA_BK_Comm
            // 
            this.TA_BK_Comm.ClearBeforeFill = true;
            // 
            // btn_supp
            // 
            this.btn_supp.Enabled = false;
            this.btn_supp.Location = new System.Drawing.Point(104, 165);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.Size = new System.Drawing.Size(75, 23);
            this.btn_supp.TabIndex = 20;
            this.btn_supp.Text = "Suppression";
            this.btn_supp.UseVisualStyleBackColor = true;
            this.btn_supp.Click += new System.EventHandler(this.btn_supp_Click);
            // 
            // codComDataGridViewTextBoxColumn
            // 
            this.codComDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codComDataGridViewTextBoxColumn.DataPropertyName = "CodCom";
            this.codComDataGridViewTextBoxColumn.HeaderText = "CodCom";
            this.codComDataGridViewTextBoxColumn.Name = "codComDataGridViewTextBoxColumn";
            this.codComDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descComDataGridViewTextBoxColumn
            // 
            this.descComDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descComDataGridViewTextBoxColumn.DataPropertyName = "DescCom";
            this.descComDataGridViewTextBoxColumn.HeaderText = "DescCom";
            this.descComDataGridViewTextBoxColumn.Name = "descComDataGridViewTextBoxColumn";
            this.descComDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // f_e2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.MaximumSize = new System.Drawing.Size(825, 545);
            this.MinimumSize = new System.Drawing.Size(825, 545);
            this.Name = "f_e2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chambres";
            this.Load += new System.EventHandler(this.f_e2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_selecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Ayant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Comm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Loc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_T_Cham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Ayantt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_lister;
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
        private DS_bd DS_bd;
        private DS_bdTableAdapters.ChambreTableAdapter TA_Chambre;
        private System.Windows.Forms.BindingSource BS_Chambre;
        private System.Windows.Forms.TextBox tb_Cham;
        private System.Windows.Forms.TextBox tb_Memo;
        private System.Windows.Forms.TextBox tb_D_Loc;
        private System.Windows.Forms.TextBox tb_D_Type;
        private System.Windows.Forms.TextBox tb_Type;
        private System.Windows.Forms.TextBox tb_Loc;
        private System.Windows.Forms.TextBox tb_Etat;
        private System.Windows.Forms.TextBox tb_Etage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Prix;
        private System.Windows.Forms.DataGridView dg_selecteur;
        private DS_bdTableAdapters.AyantTableAdapter TA_Ayant;
        private System.Windows.Forms.BindingSource BS_Ayant;
        private DS_bdTableAdapters.CommoditeTableAdapter TA_Comm;
        private System.Windows.Forms.BindingSource BS_Comm;
        private DS_bdTableAdapters.LocalisationTableAdapter TA_Loc;
        private System.Windows.Forms.BindingSource BS_Loc;
        private DS_bdTableAdapters.TypeChamTableAdapter TA_T_Cham;
        private System.Windows.Forms.BindingSource BS_T_Cham;
        private System.Windows.Forms.BindingSource BS_Ayantt;

        private System.Windows.Forms.ErrorProvider error1;
        private DS_bdTableAdapters.BK_CommoditeTableAdapter TA_BK_Comm;
        private System.Windows.Forms.Button btn_Ajout_Comm;
        private System.Windows.Forms.Button btn_supp;
        private System.Windows.Forms.DataGridViewTextBoxColumn codComDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descComDataGridViewTextBoxColumn;
    }
}