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
            this.TxT_Cham = new System.Windows.Forms.TextBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxT_Etage = new System.Windows.Forms.TextBox();
            this.TxT_Etat = new System.Windows.Forms.TextBox();
            this.TxT_Loc = new System.Windows.Forms.TextBox();
            this.TxT_Type = new System.Windows.Forms.TextBox();
            this.D_Type = new System.Windows.Forms.TextBox();
            this.D_Loc = new System.Windows.Forms.TextBox();
            this.TxT_Memo = new System.Windows.Forms.TextBox();
            this.TxT_Prix = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DS_bd = new Projet_equipe.DS_bd();
            this.TA_Chambre = new Projet_equipe.DS_bdTableAdapters.ChambreTableAdapter();
            this.BS_Chambre = new System.Windows.Forms.BindingSource(this.components);
            this.TA_Ayant = new Projet_equipe.DS_bdTableAdapters.AyantTableAdapter();
            this.BS_Ayant = new System.Windows.Forms.BindingSource(this.components);
            this.TA_Comm = new Projet_equipe.DS_bdTableAdapters.CommoditeTableAdapter();
            this.BS_Comm = new System.Windows.Forms.BindingSource(this.components);
            this.TA_Loc = new Projet_equipe.DS_bdTableAdapters.LocalisationTableAdapter();
            this.BS_Loc = new System.Windows.Forms.BindingSource(this.components);
            this.TA_T_Cham = new Projet_equipe.DS_bdTableAdapters.TypeChamTableAdapter();
            this.BS_T_Cham = new System.Windows.Forms.BindingSource(this.components);
            this.noChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Ayant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Comm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Loc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_T_Cham)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_lister
            // 
            this.btn_lister.Location = new System.Drawing.Point(339, 9);
            this.btn_lister.Name = "btn_lister";
            this.btn_lister.Size = new System.Drawing.Size(75, 23);
            this.btn_lister.TabIndex = 40;
            this.btn_lister.Text = "Lister";
            this.btn_lister.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.TxT_Prix);
            this.panel1.Controls.Add(this.TxT_Memo);
            this.panel1.Controls.Add(this.D_Loc);
            this.panel1.Controls.Add(this.D_Type);
            this.panel1.Controls.Add(this.TxT_Type);
            this.panel1.Controls.Add(this.TxT_Loc);
            this.panel1.Controls.Add(this.TxT_Etat);
            this.panel1.Controls.Add(this.TxT_Etage);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxT_Cham);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 428);
            this.panel1.TabIndex = 39;
            // 
            // TxT_Cham
            // 
            this.TxT_Cham.Location = new System.Drawing.Point(104, 29);
            this.TxT_Cham.Name = "TxT_Cham";
            this.TxT_Cham.Size = new System.Drawing.Size(100, 20);
            this.TxT_Cham.TabIndex = 0;
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
            this.btn_annuler.Location = new System.Drawing.Point(640, 9);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 33;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(558, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 32;
            this.btn_save.Text = "Sauvegarde";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_liste
            // 
            this.btn_liste.Location = new System.Drawing.Point(476, 9);
            this.btn_liste.Name = "btn_liste";
            this.btn_liste.Size = new System.Drawing.Size(75, 23);
            this.btn_liste.TabIndex = 31;
            this.btn_liste.Text = "Liste";
            this.btn_liste.UseVisualStyleBackColor = true;
            // 
            // btn_consulter
            // 
            this.btn_consulter.Location = new System.Drawing.Point(257, 9);
            this.btn_consulter.Name = "btn_consulter";
            this.btn_consulter.Size = new System.Drawing.Size(75, 23);
            this.btn_consulter.TabIndex = 30;
            this.btn_consulter.Text = "Consulter";
            this.btn_consulter.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(175, 9);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 29;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(93, 9);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 28;
            this.btn_modifier.Text = "Modifier";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Étage :";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Code Type :";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Prix :";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Desc :";
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
            // TxT_Etage
            // 
            this.TxT_Etage.Location = new System.Drawing.Point(104, 69);
            this.TxT_Etage.Name = "TxT_Etage";
            this.TxT_Etage.Size = new System.Drawing.Size(100, 20);
            this.TxT_Etage.TabIndex = 10;
            // 
            // TxT_Etat
            // 
            this.TxT_Etat.Location = new System.Drawing.Point(104, 103);
            this.TxT_Etat.Name = "TxT_Etat";
            this.TxT_Etat.Size = new System.Drawing.Size(100, 20);
            this.TxT_Etat.TabIndex = 11;
            // 
            // TxT_Loc
            // 
            this.TxT_Loc.Location = new System.Drawing.Point(360, 69);
            this.TxT_Loc.Name = "TxT_Loc";
            this.TxT_Loc.Size = new System.Drawing.Size(100, 20);
            this.TxT_Loc.TabIndex = 12;
            // 
            // TxT_Type
            // 
            this.TxT_Type.Location = new System.Drawing.Point(360, 29);
            this.TxT_Type.Name = "TxT_Type";
            this.TxT_Type.Size = new System.Drawing.Size(100, 20);
            this.TxT_Type.TabIndex = 13;
            // 
            // D_Type
            // 
            this.D_Type.Location = new System.Drawing.Point(550, 35);
            this.D_Type.Name = "D_Type";
            this.D_Type.Size = new System.Drawing.Size(100, 20);
            this.D_Type.TabIndex = 14;
            // 
            // D_Loc
            // 
            this.D_Loc.Location = new System.Drawing.Point(550, 69);
            this.D_Loc.Name = "D_Loc";
            this.D_Loc.Size = new System.Drawing.Size(100, 20);
            this.D_Loc.TabIndex = 15;
            // 
            // TxT_Memo
            // 
            this.TxT_Memo.Location = new System.Drawing.Point(446, 149);
            this.TxT_Memo.Name = "TxT_Memo";
            this.TxT_Memo.Size = new System.Drawing.Size(323, 20);
            this.TxT_Memo.TabIndex = 16;
            // 
            // TxT_Prix
            // 
            this.TxT_Prix.Location = new System.Drawing.Point(293, 100);
            this.TxT_Prix.Name = "TxT_Prix";
            this.TxT_Prix.Size = new System.Drawing.Size(100, 20);
            this.TxT_Prix.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noChamDataGridViewTextBoxColumn,
            this.codComDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.BS_Ayant;
            this.dataGridView1.Location = new System.Drawing.Point(17, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 208);
            this.dataGridView1.TabIndex = 18;
            // 
            // DS_bd
            // 
            this.DS_bd.DataSetName = "DS_bd";
            this.DS_bd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TA_Chambre
            // 
            this.TA_Chambre.ClearBeforeFill = true;
            // 
            // BS_Chambre
            // 
            this.BS_Chambre.DataMember = "Chambre";
            this.BS_Chambre.DataSource = this.DS_bd;
            // 
            // TA_Ayant
            // 
            this.TA_Ayant.ClearBeforeFill = true;
            // 
            // BS_Ayant
            // 
            this.BS_Ayant.DataMember = "Ayant";
            this.BS_Ayant.DataSource = this.DS_bd;
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
            // noChamDataGridViewTextBoxColumn
            // 
            this.noChamDataGridViewTextBoxColumn.DataPropertyName = "NoCham";
            this.noChamDataGridViewTextBoxColumn.HeaderText = "NoCham";
            this.noChamDataGridViewTextBoxColumn.Name = "noChamDataGridViewTextBoxColumn";
            // 
            // codComDataGridViewTextBoxColumn
            // 
            this.codComDataGridViewTextBoxColumn.DataPropertyName = "CodCom";
            this.codComDataGridViewTextBoxColumn.HeaderText = "CodCom";
            this.codComDataGridViewTextBoxColumn.Name = "codComDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Ayant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Comm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Loc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_T_Cham)).EndInit();
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
        private System.Windows.Forms.TextBox TxT_Cham;
        private System.Windows.Forms.TextBox TxT_Memo;
        private System.Windows.Forms.TextBox D_Loc;
        private System.Windows.Forms.TextBox D_Type;
        private System.Windows.Forms.TextBox TxT_Type;
        private System.Windows.Forms.TextBox TxT_Loc;
        private System.Windows.Forms.TextBox TxT_Etat;
        private System.Windows.Forms.TextBox TxT_Etage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxT_Prix;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DS_bdTableAdapters.AyantTableAdapter TA_Ayant;
        private System.Windows.Forms.BindingSource BS_Ayant;
        private DS_bdTableAdapters.CommoditeTableAdapter TA_Comm;
        private System.Windows.Forms.BindingSource BS_Comm;
        private DS_bdTableAdapters.LocalisationTableAdapter TA_Loc;
        private System.Windows.Forms.BindingSource BS_Loc;
        private DS_bdTableAdapters.TypeChamTableAdapter TA_T_Cham;
        private System.Windows.Forms.BindingSource BS_T_Cham;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codComDataGridViewTextBoxColumn;
    }
}