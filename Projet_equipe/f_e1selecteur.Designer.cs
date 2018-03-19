namespace Projet_equipe
{
    partial class f_e1selecteur
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
            this.button1 = new System.Windows.Forms.Button();
            this.DS_bd = new Projet_equipe.DS_bde1();
            this.BS_reservation = new System.Windows.Forms.BindingSource(this.components);
            this.reservationTableAdapter = new Projet_equipe.DS_bde1TableAdapters.ReservationTableAdapter();
            this.idReserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_selecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_reservation)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_selecteur
            // 
            this.dg_selecteur.AllowUserToAddRows = false;
            this.dg_selecteur.AllowUserToDeleteRows = false;
            this.dg_selecteur.AutoGenerateColumns = false;
            this.dg_selecteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_selecteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReserDataGridViewTextBoxColumn,
            this.dateReserDataGridViewTextBoxColumn,
            this.dateDebutDataGridViewTextBoxColumn,
            this.dateFinDataGridViewTextBoxColumn,
            this.idCliDataGridViewTextBoxColumn});
            this.dg_selecteur.DataSource = this.BS_reservation;
            this.dg_selecteur.Location = new System.Drawing.Point(13, 13);
            this.dg_selecteur.Name = "dg_selecteur";
            this.dg_selecteur.ReadOnly = true;
            this.dg_selecteur.Size = new System.Drawing.Size(630, 200);
            this.dg_selecteur.TabIndex = 0;
            this.dg_selecteur.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DS_bd
            // 
            this.DS_bd.DataSetName = "DS_bde1";
            this.DS_bd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BS_reservation
            // 
            this.BS_reservation.DataMember = "Reservation";
            this.BS_reservation.DataSource = this.DS_bd;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // idReserDataGridViewTextBoxColumn
            // 
            this.idReserDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idReserDataGridViewTextBoxColumn.DataPropertyName = "IdReser";
            this.idReserDataGridViewTextBoxColumn.HeaderText = "IdReser";
            this.idReserDataGridViewTextBoxColumn.Name = "idReserDataGridViewTextBoxColumn";
            this.idReserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateReserDataGridViewTextBoxColumn
            // 
            this.dateReserDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateReserDataGridViewTextBoxColumn.DataPropertyName = "DateReser";
            this.dateReserDataGridViewTextBoxColumn.HeaderText = "DateReser";
            this.dateReserDataGridViewTextBoxColumn.Name = "dateReserDataGridViewTextBoxColumn";
            // 
            // dateDebutDataGridViewTextBoxColumn
            // 
            this.dateDebutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDebutDataGridViewTextBoxColumn.DataPropertyName = "DateDebut";
            this.dateDebutDataGridViewTextBoxColumn.HeaderText = "DateDebut";
            this.dateDebutDataGridViewTextBoxColumn.Name = "dateDebutDataGridViewTextBoxColumn";
            // 
            // dateFinDataGridViewTextBoxColumn
            // 
            this.dateFinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateFinDataGridViewTextBoxColumn.DataPropertyName = "DateFin";
            this.dateFinDataGridViewTextBoxColumn.HeaderText = "DateFin";
            this.dateFinDataGridViewTextBoxColumn.Name = "dateFinDataGridViewTextBoxColumn";
            // 
            // idCliDataGridViewTextBoxColumn
            // 
            this.idCliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idCliDataGridViewTextBoxColumn.DataPropertyName = "IdCli";
            this.idCliDataGridViewTextBoxColumn.HeaderText = "IdCli";
            this.idCliDataGridViewTextBoxColumn.Name = "idCliDataGridViewTextBoxColumn";
            // 
            // f_e1selecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 263);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dg_selecteur);
            this.MaximumSize = new System.Drawing.Size(671, 302);
            this.MinimumSize = new System.Drawing.Size(671, 302);
            this.Name = "f_e1selecteur";
            this.Text = "f_e1selecteur";
            this.Load += new System.EventHandler(this.f_e1selecteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_selecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_reservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_selecteur;
        private System.Windows.Forms.Button button1;
        private DS_bde1 DS_bd;
        private System.Windows.Forms.BindingSource BS_reservation;
        private DS_bde1TableAdapters.ReservationTableAdapter reservationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliDataGridViewTextBoxColumn;
    }
}