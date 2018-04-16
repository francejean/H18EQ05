namespace Projet_equipe
{
    partial class f_e2selectLoc
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
            this.TA_Loc = new Projet_equipe.DS_bdTableAdapters.LocalisationTableAdapter();
            this.BS_Loc = new System.Windows.Forms.BindingSource(this.components);
            this.dg_selecteur = new System.Windows.Forms.DataGridView();
            this.codLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Loc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_selecteur)).BeginInit();
            this.SuspendLayout();
            // 
            // DS_bd
            // 
            this.DS_bd.DataSetName = "DS_bd";
            this.DS_bd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dg_selecteur
            // 
            this.dg_selecteur.AutoGenerateColumns = false;
            this.dg_selecteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_selecteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codLocDataGridViewTextBoxColumn,
            this.descLocDataGridViewTextBoxColumn});
            this.dg_selecteur.DataSource = this.BS_Loc;
            this.dg_selecteur.Location = new System.Drawing.Point(12, 12);
            this.dg_selecteur.Name = "dg_selecteur";
            this.dg_selecteur.Size = new System.Drawing.Size(527, 196);
            this.dg_selecteur.TabIndex = 0;
            this.dg_selecteur.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_selecteur_CellMouseDoubleClick);
            // 
            // codLocDataGridViewTextBoxColumn
            // 
            this.codLocDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codLocDataGridViewTextBoxColumn.DataPropertyName = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.HeaderText = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.Name = "codLocDataGridViewTextBoxColumn";
            this.codLocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descLocDataGridViewTextBoxColumn
            // 
            this.descLocDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descLocDataGridViewTextBoxColumn.DataPropertyName = "DescLoc";
            this.descLocDataGridViewTextBoxColumn.HeaderText = "DescLoc";
            this.descLocDataGridViewTextBoxColumn.Name = "descLocDataGridViewTextBoxColumn";
            this.descLocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(226, 226);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // f_e2selectLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 261);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.dg_selecteur);
            this.Name = "f_e2selectLoc";
            this.Text = "f_e2selectLoc";
            this.Load += new System.EventHandler(this.f_e2selectLoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Loc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_selecteur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS_bd DS_bd;
        private DS_bdTableAdapters.LocalisationTableAdapter TA_Loc;
        private System.Windows.Forms.BindingSource BS_Loc;
        private System.Windows.Forms.DataGridView dg_selecteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descLocDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_ok;
    }
}