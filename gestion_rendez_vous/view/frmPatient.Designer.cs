namespace gestion_rendez_vous.view
{
    partial class frmPatient
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
            this.dgPatient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nom_prenom = new System.Windows.Forms.TextBox();
            this.txtx_adresse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_taille = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_poids = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_gsangin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_choisir = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPatient
            // 
            this.dgPatient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatient.GridColor = System.Drawing.SystemColors.Control;
            this.dgPatient.Location = new System.Drawing.Point(394, 77);
            this.dgPatient.Name = "dgPatient";
            this.dgPatient.Size = new System.Drawing.Size(491, 441);
            this.dgPatient.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom Prenom";
            // 
            // txt_nom_prenom
            // 
            this.txt_nom_prenom.Location = new System.Drawing.Point(12, 77);
            this.txt_nom_prenom.Name = "txt_nom_prenom";
            this.txt_nom_prenom.Size = new System.Drawing.Size(254, 20);
            this.txt_nom_prenom.TabIndex = 1;
            // 
            // txtx_adresse
            // 
            this.txtx_adresse.Location = new System.Drawing.Point(12, 136);
            this.txtx_adresse.Name = "txtx_adresse";
            this.txtx_adresse.Size = new System.Drawing.Size(254, 20);
            this.txtx_adresse.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adresse";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(12, 259);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(254, 20);
            this.txt_tel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telephone";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(12, 200);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(254, 20);
            this.txt_email.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // txt_taille
            // 
            this.txt_taille.Location = new System.Drawing.Point(12, 450);
            this.txt_taille.Name = "txt_taille";
            this.txt_taille.Size = new System.Drawing.Size(254, 20);
            this.txt_taille.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Taille";
            // 
            // txt_poids
            // 
            this.txt_poids.Location = new System.Drawing.Point(12, 386);
            this.txt_poids.Name = "txt_poids";
            this.txt_poids.Size = new System.Drawing.Size(254, 20);
            this.txt_poids.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Poids";
            // 
            // txt_gsangin
            // 
            this.txt_gsangin.Location = new System.Drawing.Point(12, 327);
            this.txt_gsangin.Name = "txt_gsangin";
            this.txt_gsangin.Size = new System.Drawing.Size(254, 20);
            this.txt_gsangin.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Groupe Sanguin";
            // 
            // btn_choisir
            // 
            this.btn_choisir.Location = new System.Drawing.Point(810, 48);
            this.btn_choisir.Name = "btn_choisir";
            this.btn_choisir.Size = new System.Drawing.Size(75, 23);
            this.btn_choisir.TabIndex = 9;
            this.btn_choisir.Text = "Choisir";
            this.btn_choisir.UseVisualStyleBackColor = true;
            this.btn_choisir.Click += new System.EventHandler(this.btn_choisir_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(103, 486);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 10;
            this.btn_modifier.Text = "&Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(191, 486);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 11;
            this.btn_supprimer.Text = "&Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(15, 486);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 8;
            this.btn_ajouter.Text = "&Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(489, 71);
            this.label5.TabIndex = 55;
            this.label5.Text = "Clinique Amitie";
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 530);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_choisir);
            this.Controls.Add(this.txt_taille);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_poids);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_gsangin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtx_adresse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nom_prenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPatient);
            this.Name = "frmPatient";
            this.Text = "frmPatient";
            this.Load += new System.EventHandler(this.frmPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nom_prenom;
        private System.Windows.Forms.TextBox txtx_adresse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_taille;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_poids;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_gsangin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_choisir;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label label5;
    }
}