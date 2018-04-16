namespace Projet_equipe
{
    partial class f_e2selectComm
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
            this.dg_selecteur = new System.Windows.Forms.DataGridView();
            this.btn_ok = new System.Windows.Forms.Button();
            this.DS_bd = new Projet_equipe.DS_bd();
            this.TA_Comm = new Projet_equipe.DS_bdTableAdapters.CommoditeTableAdapter();
            this.BS_Comm = new System.Windows.Forms.BindingSource(this.components);
            this.codComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_selecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Comm)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_selecteur
            // 
            this.dg_selecteur.AutoGenerateColumns = false;
            this.dg_selecteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_selecteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codComDataGridViewTextBoxColumn,
            this.descComDataGridViewTextBoxColumn});
            this.dg_selecteur.DataSource = this.BS_Comm;
            this.dg_selecteur.Location = new System.Drawing.Point(13, 13);
            this.dg_selecteur.Name = "dg_selecteur";
            this.dg_selecteur.Size = new System.Drawing.Size(398, 150);
            this.dg_selecteur.TabIndex = 0;
            this.dg_selecteur.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_selecteur_CellMouseDoubleClick);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(171, 204);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // DS_bd
            // 
            this.DS_bd.DataSetName = "DS_bd";
            this.DS_bd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // codComDataGridViewTextBoxColumn
            // 
            this.codComDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codComDataGridViewTextBoxColumn.DataPropertyName = "CodCom";
            this.codComDataGridViewTextBoxColumn.HeaderText = "CodCom";
            this.codComDataGridViewTextBoxColumn.Name = "codComDataGridViewTextBoxColumn";
            // 
            // descComDataGridViewTextBoxColumn
            // 
            this.descComDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descComDataGridViewTextBoxColumn.DataPropertyName = "DescCom";
            this.descComDataGridViewTextBoxColumn.HeaderText = "DescCom";
            this.descComDataGridViewTextBoxColumn.Name = "descComDataGridViewTextBoxColumn";
            // 
            // f_e2selectComm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 261);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.dg_selecteur);
            this.Name = "f_e2selectComm";
            this.Text = "f_e2selectComm";
            this.Load += new System.EventHandler(this.f_e2selectComm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_selecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Comm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_selecteur;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn codComDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descComDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource BS_Comm;
        private DS_bd DS_bd;
        private DS_bdTableAdapters.CommoditeTableAdapter TA_Comm;
    }
}