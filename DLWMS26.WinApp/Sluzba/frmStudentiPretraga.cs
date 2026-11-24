using DLWMS26.Data.Models;
using DLWMS26.Servis;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DLWMS26.WinApp.Sluzba
{
    public partial class frmStudentiPretraga : Form
    {

        StudentServis db = new StudentServis();

        public frmStudentiPretraga()
        {
            InitializeComponent();
        }

        private void frmStudentiPretraga_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajStudente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UcitajStudente(List<Student> studenti = null)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti ?? db.GetAll();
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            var noviStudent = new frmStudentiNovi();
            if (noviStudent.ShowDialog() == DialogResult.OK)
            {
                UcitajStudente();
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            string filter = txtPretraga.Text.ToLower();//G => g
            var rezultatPretrage = db.GetAll()
                .Where(s => s.Ime.ToLower().Contains(filter) ||
                            s.Prezime.ToLower().Contains(filter) ||
                            s.BrojIndeksa.ToLower().Contains(filter)).ToList();
            UcitajStudente(rezultatPretrage);

        }
    }
}
