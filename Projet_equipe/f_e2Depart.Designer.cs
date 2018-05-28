namespace Projet_equipe
{
    partial class f_e2Depart
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
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_List = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.l_reser = new System.Windows.Forms.Label();
            this.l_cli = new System.Windows.Forms.Label();
            this.l_cham = new System.Windows.Forms.Label();
            this.tb_reser = new System.Windows.Forms.TextBox();
            this.tb_cli = new System.Windows.Forms.TextBox();
            this.tb_cham = new System.Windows.Forms.TextBox();
            this.tb_conf = new System.Windows.Forms.TextBox();
            this.l_conf = new System.Windows.Forms.Label();
            this.dp_Depart = new System.Windows.Forms.DateTimePicker();
            this.l_date = new System.Windows.Forms.Label();
            this.DS_bd = new Projet_equipe.DS_bd();
            this.TA_Arrive = new Projet_equipe.DS_bdTableAdapters.ArriveTableAdapter();
            this.TA_Depart = new Projet_equipe.DS_bdTableAdapters.DepartTableAdapter();
            this.TA_De = new Projet_equipe.DS_bdTableAdapters.DeTableAdapter();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BS_Arrive = new System.Windows.Forms.BindingSource(this.components);
            this.BS_Depart = new System.Windows.Forms.BindingSource(this.components);
            this.BS_De = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Arrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Depart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_De)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(407, 13);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(75, 23);
            this.btn_quit.TabIndex = 0;
            this.btn_quit.Text = "Quitter";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(326, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_List
            // 
            this.btn_List.Location = new System.Drawing.Point(245, 12);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(75, 23);
            this.btn_List.TabIndex = 3;
            this.btn_List.Text = "Lister";
            this.btn_List.UseVisualStyleBackColor = true;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Ajouter";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // l_reser
            // 
            this.l_reser.AutoSize = true;
            this.l_reser.Location = new System.Drawing.Point(13, 63);
            this.l_reser.Name = "l_reser";
            this.l_reser.Size = new System.Drawing.Size(49, 13);
            this.l_reser.TabIndex = 5;
            this.l_reser.Text = "NoReser";
            // 
            // l_cli
            // 
            this.l_cli.AutoSize = true;
            this.l_cli.Location = new System.Drawing.Point(13, 99);
            this.l_cli.Name = "l_cli";
            this.l_cli.Size = new System.Drawing.Size(47, 13);
            this.l_cli.TabIndex = 6;
            this.l_cli.Text = "NoClient";
            // 
            // l_cham
            // 
            this.l_cham.AutoSize = true;
            this.l_cham.Location = new System.Drawing.Point(13, 133);
            this.l_cham.Name = "l_cham";
            this.l_cham.Size = new System.Drawing.Size(48, 13);
            this.l_cham.TabIndex = 7;
            this.l_cham.Text = "NoCham";
            // 
            // tb_reser
            // 
            this.tb_reser.Location = new System.Drawing.Point(88, 60);
            this.tb_reser.Name = "tb_reser";
            this.tb_reser.ReadOnly = true;
            this.tb_reser.Size = new System.Drawing.Size(100, 20);
            this.tb_reser.TabIndex = 8;
            // 
            // tb_cli
            // 
            this.tb_cli.Location = new System.Drawing.Point(88, 96);
            this.tb_cli.Name = "tb_cli";
            this.tb_cli.ReadOnly = true;
            this.tb_cli.Size = new System.Drawing.Size(100, 20);
            this.tb_cli.TabIndex = 9;
            // 
            // tb_cham
            // 
            this.tb_cham.Location = new System.Drawing.Point(88, 130);
            this.tb_cham.Name = "tb_cham";
            this.tb_cham.ReadOnly = true;
            this.tb_cham.Size = new System.Drawing.Size(100, 20);
            this.tb_cham.TabIndex = 10;
            // 
            // tb_conf
            // 
            this.tb_conf.Location = new System.Drawing.Point(88, 165);
            this.tb_conf.Name = "tb_conf";
            this.tb_conf.Size = new System.Drawing.Size(100, 20);
            this.tb_conf.TabIndex = 11;
            this.tb_conf.Validating += new System.ComponentModel.CancelEventHandler(this.tb_conf_Validating);
            // 
            // l_conf
            // 
            this.l_conf.AutoSize = true;
            this.l_conf.Location = new System.Drawing.Point(13, 168);
            this.l_conf.Name = "l_conf";
            this.l_conf.Size = new System.Drawing.Size(69, 13);
            this.l_conf.TabIndex = 12;
            this.l_conf.Text = "Confirmer par";
            // 
            // dp_Depart
            // 
            this.dp_Depart.Enabled = false;
            this.dp_Depart.Location = new System.Drawing.Point(284, 113);
            this.dp_Depart.Name = "dp_Depart";
            this.dp_Depart.Size = new System.Drawing.Size(200, 20);
            this.dp_Depart.TabIndex = 13;
            this.dp_Depart.Value = new System.DateTime(2018, 5, 28, 0, 0, 0, 0);
            // 
            // l_date
            // 
            this.l_date.AutoSize = true;
            this.l_date.Location = new System.Drawing.Point(213, 119);
            this.l_date.Name = "l_date";
            this.l_date.Size = new System.Drawing.Size(65, 13);
            this.l_date.TabIndex = 14;
            this.l_date.Text = "Date Depart";
            // 
            // DS_bd
            // 
            this.DS_bd.DataSetName = "DS_bd";
            this.DS_bd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TA_Arrive
            // 
            this.TA_Arrive.ClearBeforeFill = true;
            // 
            // TA_Depart
            // 
            this.TA_Depart.ClearBeforeFill = true;
            // 
            // TA_De
            // 
            this.TA_De.ClearBeforeFill = true;
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // BS_Arrive
            // 
            this.BS_Arrive.DataMember = "Arrive";
            this.BS_Arrive.DataSource = this.DS_bd;
            // 
            // BS_Depart
            // 
            this.BS_Depart.DataMember = "Depart";
            this.BS_Depart.DataSource = this.DS_bd;
            // 
            // BS_De
            // 
            this.BS_De.DataMember = "De";
            this.BS_De.DataSource = this.DS_bd;
            // 
            // f_e2Depart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 208);
            this.Controls.Add(this.l_date);
            this.Controls.Add(this.dp_Depart);
            this.Controls.Add(this.l_conf);
            this.Controls.Add(this.tb_conf);
            this.Controls.Add(this.tb_cham);
            this.Controls.Add(this.tb_cli);
            this.Controls.Add(this.tb_reser);
            this.Controls.Add(this.l_cham);
            this.Controls.Add(this.l_cli);
            this.Controls.Add(this.l_reser);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_quit);
            this.Name = "f_e2Depart";
            this.Text = "Depart";
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Arrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Depart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_De)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label l_reser;
        private System.Windows.Forms.Label l_cli;
        private System.Windows.Forms.Label l_cham;
        private System.Windows.Forms.TextBox tb_reser;
        private System.Windows.Forms.TextBox tb_cli;
        private System.Windows.Forms.TextBox tb_cham;
        private System.Windows.Forms.TextBox tb_conf;
        private System.Windows.Forms.Label l_conf;
        private System.Windows.Forms.DateTimePicker dp_Depart;
        private System.Windows.Forms.Label l_date;
        private DS_bd DS_bd;
        private DS_bdTableAdapters.ArriveTableAdapter TA_Arrive;
        private System.Windows.Forms.BindingSource BS_Arrive;
        private DS_bdTableAdapters.DepartTableAdapter TA_Depart;
        private System.Windows.Forms.BindingSource BS_Depart;
        private DS_bdTableAdapters.DeTableAdapter TA_De;
        private System.Windows.Forms.BindingSource BS_De;
        private System.Windows.Forms.ErrorProvider error1;
    }
}