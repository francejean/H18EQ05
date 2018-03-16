namespace Projet_equipe
{
    partial class f_accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_reservation = new System.Windows.Forms.Button();
            this.btn_chambre = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_reservation
            // 
            this.btn_reservation.Location = new System.Drawing.Point(12, 182);
            this.btn_reservation.Name = "btn_reservation";
            this.btn_reservation.Size = new System.Drawing.Size(75, 23);
            this.btn_reservation.TabIndex = 0;
            this.btn_reservation.Text = "Réservation";
            this.btn_reservation.UseVisualStyleBackColor = true;
            this.btn_reservation.Click += new System.EventHandler(this.btn_reservation_Click);
            // 
            // btn_chambre
            // 
            this.btn_chambre.Location = new System.Drawing.Point(93, 182);
            this.btn_chambre.Name = "btn_chambre";
            this.btn_chambre.Size = new System.Drawing.Size(75, 23);
            this.btn_chambre.TabIndex = 1;
            this.btn_chambre.Text = "Chambre";
            this.btn_chambre.UseVisualStyleBackColor = true;
            this.btn_chambre.Click += new System.EventHandler(this.btn_chambre_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(351, 182);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(75, 23);
            this.btn_quitter.TabIndex = 2;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projet_equipe.Properties.Resources._17_hotel_logo_idea;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // f_accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 216);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_chambre);
            this.Controls.Add(this.btn_reservation);
            this.MaximumSize = new System.Drawing.Size(455, 255);
            this.MinimumSize = new System.Drawing.Size(455, 255);
            this.Name = "f_accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_reservation;
        private System.Windows.Forms.Button btn_chambre;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

