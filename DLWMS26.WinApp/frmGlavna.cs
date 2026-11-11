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
    }
}
