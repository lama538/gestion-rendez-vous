﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_rendez_vous.view;

namespace gestion_rendez_vous
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
           

        }
        private void fermer()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmMDI_load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Invalidate();
            this.Update();
            this.Location = new Point(0, 0);


        }
        private void pATIENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmPatient f = new frmPatient();
            
            f.Show();
           
        }

        private void mEDECINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmMedecin f = new frmMedecin();
            
            f.Show();
           
        }

        private void frmMDI_Load_1(object sender, EventArgs e)
        {

        }
    }
}

