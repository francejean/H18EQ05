namespace Projet_equipe
{
    partial class f_e2Arrive
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
            this.DS_bd = new Projet_equipe.DS_bd();
            this.TA_Arrive = new Projet_equipe.DS_bdTableAdapters.ArriveTableAdapter();
            this.BS_Arrive = new System.Windows.Forms.BindingSource(this.components);
            this.dg_selecteur = new System.Windows.Forms.DataGridView();
            this.idArriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateArriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Arrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_selecteur)).BeginInit();
            this.SuspendLayout();
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
            // BS_Arrive
            // 
            this.BS_Arrive.DataMember = "Arrive";
            this.BS_Arrive.DataSource = this.DS_bd;
            // 
            // dg_selecteur
            // 
            this.dg_selecteur.AutoGenerateColumns = false;
            this.dg_selecteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_selecteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArriveDataGridViewTextBoxColumn,
            this.dateArriveDataGridViewTextBoxColumn,
            this.idCliDataGridViewTextBoxColumn,
            this.idReserDataGridViewTextBoxColumn,
            this.noChamDataGridViewTextBoxColumn});
            this.dg_selecteur.DataSource = this.BS_Arrive;
            this.dg_selecteur.Location = new System.Drawing.Point(13, 13);
            this.dg_selecteur.Name = "dg_selecteur";
            this.dg_selecteur.Size = new System.Drawing.Size(545, 150);
            this.dg_selecteur.TabIndex = 0;
            this.dg_selecteur.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_selecteur_CellMouseDoubleClick);
            // 
            // idArriveDataGridViewTextBoxColumn
            // 
            this.idArriveDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idArriveDataGridViewTextBoxColumn.DataPropertyName = "IdArrive";
            this.idArriveDataGridViewTextBoxColumn.HeaderText = "IdArrive";
            this.idArriveDataGridViewTextBoxColumn.Name = "idArriveDataGridViewTextBoxColumn";
            this.idArriveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateArriveDataGridViewTextBoxColumn
            // 
            this.dateArriveDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateArriveDataGridViewTextBoxColumn.DataPropertyName = "DateArrive";
            this.dateArriveDataGridViewTextBoxColumn.HeaderText = "DateArrive";
            this.dateArriveDataGridViewTextBoxColumn.Name = "dateArriveDataGridViewTextBoxColumn";
            // 
            // idCliDataGridViewTextBoxColumn
            // 
            this.idCliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idCliDataGridViewTextBoxColumn.DataPropertyName = "IdCli";
            this.idCliDataGridViewTextBoxColumn.HeaderText = "IdCli";
            this.idCliDataGridViewTextBoxColumn.Name = "idCliDataGridViewTextBoxColumn";
            // 
            // idReserDataGridViewTextBoxColumn
            // 
            this.idReserDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idReserDataGridViewTextBoxColumn.DataPropertyName = "IdReser";
            this.idReserDataGridViewTextBoxColumn.HeaderText = "IdReser";
            this.idReserDataGridViewTextBoxColumn.Name = "idReserDataGridViewTextBoxColumn";
            // 
            // noChamDataGridViewTextBoxColumn
            // 
            this.noChamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noChamDataGridViewTextBoxColumn.DataPropertyName = "NoCham";
            this.noChamDataGridViewTextBoxColumn.HeaderText = "NoCham";
            this.noChamDataGridViewTextBoxColumn.Name = "noChamDataGridViewTextBoxColumn";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(245, 203);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // f_e2Arrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 261);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.dg_selecteur);
            this.Name = "f_e2Arrive";
            this.Text = "f_e2Arrive";
            this.Load += new System.EventHandler(this.f_e2Arrive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Arrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_selecteur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS_bd DS_bd;
        private DS_bdTableAdapters.ArriveTableAdapter TA_Arrive;
        private System.Windows.Forms.BindingSource BS_Arrive;
        private System.Windows.Forms.DataGridView dg_selecteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateArriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_ok;
    }
}