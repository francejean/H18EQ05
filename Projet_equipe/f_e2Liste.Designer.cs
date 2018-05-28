namespace Projet_equipe
{
    partial class f_e2Liste
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
            this.TA_Depart = new Projet_equipe.DS_bdTableAdapters.DepartTableAdapter();
            this.BS_Depart = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmerParDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Depart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DS_bd
            // 
            this.DS_bd.DataSetName = "DS_bd";
            this.DS_bd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TA_Depart
            // 
            this.TA_Depart.ClearBeforeFill = true;
            // 
            // BS_Depart
            // 
            this.BS_Depart.DataMember = "Depart";
            this.BS_Depart.DataSource = this.DS_bd;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDepartDataGridViewTextBoxColumn,
            this.dateDepartDataGridViewTextBoxColumn,
            this.confirmerParDataGridViewTextBoxColumn,
            this.idReserDataGridViewTextBoxColumn,
            this.noChamDataGridViewTextBoxColumn,
            this.idCliDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.BS_Depart;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(517, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDepartDataGridViewTextBoxColumn
            // 
            this.idDepartDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDepartDataGridViewTextBoxColumn.DataPropertyName = "IdDepart";
            this.idDepartDataGridViewTextBoxColumn.HeaderText = "IdDepart";
            this.idDepartDataGridViewTextBoxColumn.Name = "idDepartDataGridViewTextBoxColumn";
            this.idDepartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDepartDataGridViewTextBoxColumn
            // 
            this.dateDepartDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDepartDataGridViewTextBoxColumn.DataPropertyName = "DateDepart";
            this.dateDepartDataGridViewTextBoxColumn.HeaderText = "DateDepart";
            this.dateDepartDataGridViewTextBoxColumn.Name = "dateDepartDataGridViewTextBoxColumn";
            this.dateDepartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // confirmerParDataGridViewTextBoxColumn
            // 
            this.confirmerParDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.confirmerParDataGridViewTextBoxColumn.DataPropertyName = "ConfirmerPar";
            this.confirmerParDataGridViewTextBoxColumn.HeaderText = "ConfirmerPar";
            this.confirmerParDataGridViewTextBoxColumn.Name = "confirmerParDataGridViewTextBoxColumn";
            this.confirmerParDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idReserDataGridViewTextBoxColumn
            // 
            this.idReserDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idReserDataGridViewTextBoxColumn.DataPropertyName = "IdReser";
            this.idReserDataGridViewTextBoxColumn.HeaderText = "IdReser";
            this.idReserDataGridViewTextBoxColumn.Name = "idReserDataGridViewTextBoxColumn";
            this.idReserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noChamDataGridViewTextBoxColumn
            // 
            this.noChamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noChamDataGridViewTextBoxColumn.DataPropertyName = "NoCham";
            this.noChamDataGridViewTextBoxColumn.HeaderText = "NoCham";
            this.noChamDataGridViewTextBoxColumn.Name = "noChamDataGridViewTextBoxColumn";
            this.noChamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCliDataGridViewTextBoxColumn
            // 
            this.idCliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idCliDataGridViewTextBoxColumn.DataPropertyName = "IdCli";
            this.idCliDataGridViewTextBoxColumn.HeaderText = "IdCli";
            this.idCliDataGridViewTextBoxColumn.Name = "idCliDataGridViewTextBoxColumn";
            this.idCliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // f_e2Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 222);
            this.Controls.Add(this.dataGridView1);
            this.Name = "f_e2Liste";
            this.Text = "f_e2Liste";
            this.Load += new System.EventHandler(this.f_e2Liste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Depart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS_bd DS_bd;
        private DS_bdTableAdapters.DepartTableAdapter TA_Depart;
        private System.Windows.Forms.BindingSource BS_Depart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDepartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmerParDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliDataGridViewTextBoxColumn;
    }
}