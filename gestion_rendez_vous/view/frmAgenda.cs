using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_rendez_vous.model;

namespace gestion_rendez_vous.view
{
    public partial class frmAgenda : Form

    {
        public int idMedecin;
        public frmAgenda()
        {
            InitializeComponent();
        }
        bdRvMedicalContext db = new bdRvMedicalContext();

        private void dgMedecin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {

        }

        private void btn_choisir_Click(object sender, EventArgs e)
        {

        }

        private void txt_NumeroOM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_Specialite_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_Identifiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtx_adresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_nom_prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Agenda a = new Agenda();
            a.Creneau = int.Parse(txt_creneau.Text);
            a.HeureDebut = txt_heuredebut.Text;
            a.HeureFin = txt_heurefin.Text;
            a.IdMedecin = idMedecin;
            a.DatePlanifie = txtDate.Value;
            a.Statut = "brouillon";
            a.Lieu = txt_lieu.Text;
            a.Titre = txt_titre.Text;
            db.agendas.Add(a);
            db.SaveChanges();
            Resetform();

        }
        private void Resetform()
        {
            dgAgence.DataSource = db.agendas.Where(a => a.DatePlanifie >= DateTime.Now && a.IdMedecin == idMedecin).ToList();
            txt_creneau.Text=string.Empty;
            txtDate.Value = DateTime.Now;
            txt_heuredebut.Text=string.Empty;
            txt_heurefin.Text=string.Empty;
            txt_lieu.Text=string.Empty;
            txt_titre.Text=string.Empty;
            txt_titre.Focus();


        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            var m = db.medecins.Find(idMedecin);
            lbl_medecin.Text = string.Format("N Ordre:{0},Nom Prenom: {1}", m.NumeroOrdre, m.NomPrenom);
            lbl_idmedecin.Text=m.IdU.ToString();
            lbl_idmedecin.Visible = false;
            Resetform();

        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
