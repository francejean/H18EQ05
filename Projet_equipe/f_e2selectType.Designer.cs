namespace Projet_equipe
{
    partial class f_e2selectType
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
            this.TA_T_Cham = new Projet_equipe.DS_bdTableAdapters.TypeChamTableAdapter();
            this.BS_T_Cham = new System.Windows.Forms.BindingSource(this.components);
            this.codTypChanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descTypDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbDispoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_selecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_T_Cham)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_selecteur
            // 
            this.dg_selecteur.AutoGenerateColumns = false;
            this.dg_selecteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_selecteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codTypChanDataGridViewTextBoxColumn,
            this.descTypDataGridViewTextBoxColumn,
            this.nbDispoDataGridViewTextBoxColumn});
            this.dg_selecteur.DataSource = this.BS_T_Cham;
            this.dg_selecteur.Location = new System.Drawing.Point(13, 13);
            this.dg_selecteur.Name = "dg_selecteur";
            this.dg_selecteur.Size = new System.Drawing.Size(445, 150);
            this.dg_selecteur.TabIndex = 0;
            this.dg_selecteur.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_selecteur_CellMouseDoubleClick);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(189, 201);
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
            // TA_T_Cham
            // 
            this.TA_T_Cham.ClearBeforeFill = true;
            // 
            // BS_T_Cham
            // 
            this.BS_T_Cham.DataMember = "TypeCham";
            this.BS_T_Cham.DataSource = this.DS_bd;
            // 
            // codTypChanDataGridViewTextBoxColumn
            // 
            this.codTypChanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codTypChanDataGridViewTextBoxColumn.DataPropertyName = "CodTypChan";
            this.codTypChanDataGridViewTextBoxColumn.HeaderText = "CodTypChan";
            this.codTypChanDataGridViewTextBoxColumn.Name = "codTypChanDataGridViewTextBoxColumn";
            // 
            // descTypDataGridViewTextBoxColumn
            // 
            this.descTypDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descTypDataGridViewTextBoxColumn.DataPropertyName = "DescTyp";
            this.descTypDataGridViewTextBoxColumn.HeaderText = "DescTyp";
            this.descTypDataGridViewTextBoxColumn.Name = "descTypDataGridViewTextBoxColumn";
            // 
            // nbDispoDataGridViewTextBoxColumn
            // 
            this.nbDispoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nbDispoDataGridViewTextBoxColumn.DataPropertyName = "NbDispo";
            this.nbDispoDataGridViewTextBoxColumn.HeaderText = "NbDispo";
            this.nbDispoDataGridViewTextBoxColumn.Name = "nbDispoDataGridViewTextBoxColumn";
            // 
            // f_e2selectType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 261);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.dg_selecteur);
            this.Name = "f_e2selectType";
            this.Text = "f_e2selectType";
            this.Load += new System.EventHandler(this.f_e2selectType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_selecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_T_Cham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_selecteur;
        private System.Windows.Forms.Button btn_ok;
        private DS_bd DS_bd;
        private DS_bdTableAdapters.TypeChamTableAdapter TA_T_Cham;
        private System.Windows.Forms.BindingSource BS_T_Cham;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTypChanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descTypDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbDispoDataGridViewTextBoxColumn;
    }
}