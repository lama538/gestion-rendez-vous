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
    public partial class frmMedecin : Form
    {
        bdRvMedicalContext db = new bdRvMedicalContext();
        public frmMedecin()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {
           ResetForm();

        }
        private List<SelectListViewModel> LoadCbbSpecialite()
        {
            var m = db.specialites.ToList();
            List<SelectListViewModel> liste = new List<SelectListViewModel>();
            SelectListViewModel b = new SelectListViewModel();
            b.Text = "SELECTIONNEZ ...";
            b.Value = "";
            liste.Add(b);

            foreach (var c in m)
            {
                SelectListViewModel a = new SelectListViewModel();
                a.Text = c.nomSpecialite;
                a.Value=c.Idspecialite.ToString();
                liste.Add(a);
            }
            return liste;
        }

            

         
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Medecin m = new Medecin();
            m.Adresse=txtx_adresse.Text;
            m.NumeroOrdre=txt_NumeroOM.Text;
            m.Email=txt_email.Text;
            m.NomPrenom=txt_nom_prenom.Text;
            m.Tel=txt_tel.Text;
            m.Idspecialite=int.Parse(cbbSpecialite.SelectedValue.ToString());
            m.Identifiant=txt_Identifiant.Text;
            m.status=false;
            db.medecins.Add(m);
            db.SaveChanges();
            ResetForm();


        }
        private void ResetForm()
        {
            txtx_adresse.Text=String.Empty;
            txt_email.Text=String.Empty;
            txt_Identifiant.Text=String.Empty ;
            cbbSpecialite.SelectedValue=String.Empty ;
            txt_tel.Text=String.Empty ;
            txt_nom_prenom.Text=String.Empty ;
            txt_NumeroOM.Text=String.Empty ;
            cbbSpecialite.DataSource = LoadCbbSpecialite();
            cbbSpecialite.ValueMember = "Value";
            cbbSpecialite.DisplayMember = "Text";
            dgMedecin.DataSource = db.medecins.Select(a => new { a.IdU, a.NumeroOrdre, a.Identifiant,a.specialite.nomSpecialite, a.NomPrenom, a.Tel, a.Email }).ToList();
            txt_nom_prenom.Focus();
        }

        private void btn_choisir_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            var m= db.medecins.Find(id);
            if(m == null)
            {
                txtx_adresse.Text= m.Adresse;
                txt_email.Text= m.Email;
                txt_Identifiant.Text = m.Identifiant;   
                txt_nom_prenom.Text = m.NomPrenom;
                txt_NumeroOM.Text = m.NumeroOrdre;
                cbbSpecialite.SelectedValue=m.Idspecialite;
                txt_tel.Text = m.Tel;
            }


        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            var m = db.medecins.Find(id);
            m.Adresse = txtx_adresse.Text;
            m.NumeroOrdre = txt_NumeroOM.Text;
            m.Email = txt_email.Text;
            m.NomPrenom = txt_nom_prenom.Text;
            m.Tel = txt_tel.Text;
            m.Idspecialite = int.Parse(cbbSpecialite.SelectedValue.ToString());
            m.Identifiant = txt_Identifiant.Text;
            m.status = false;
            
            db.SaveChanges();
            ResetForm();

        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            var m = db.medecins.Find(id);
            db.medecins.Remove(m);
            db.SaveChanges();
            ResetForm();
        }

        private void btn_agenda_Click(object sender, EventArgs e)
        {
            frmAgenda a = new frmAgenda();
            a.idMedecin= int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString()) ;
            var m  = db.medecins.Find(a.idMedecin);
            a.Show();
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
