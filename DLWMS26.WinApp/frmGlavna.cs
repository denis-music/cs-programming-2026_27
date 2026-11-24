using DLWMS26.WinApp.Sluzba;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DLWMS26.WinApp
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmGlavna_Load(object sender, EventArgs e)
        {
            PrikaziPrijavljenogKorisnika();
        }

        private void PrikaziPrijavljenogKorisnika()
        {
            tslblPrijavljeniKorisnik.Text = $"Korisnik: {Aplikacija.PrijavljeniKorisnik}";
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmStudentiPretraga());        
        }

        private void PrikaziFormu(Form form)
        {            
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void noviStudetnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmStudentiNovi());
        }
    }
}
