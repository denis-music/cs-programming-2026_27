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
    public partial class frmStudentiNovi : Form
    {

        StudentServis db = new StudentServis();

        public frmStudentiNovi()
        {
            InitializeComponent();
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            if (ofdSlikaStudenta.ShowDialog() == DialogResult.OK)
            {
                pbSlikaStudenta.Image = Image.FromFile(ofdSlikaStudenta.FileName);
            }
        }

        private void frmStudentiNovi_Load(object sender, EventArgs e)
        {
            try
            {
                GenerisiBrojIndeksa();
                GeneriLozinku();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GeneriLozinku(int brojZnakova = 15)
        {
            string znakovi = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789*/_+-!$%&()=";
            StringBuilder lozinka = new StringBuilder();//Ifh3*/M
            Random random = new Random();
            for (int i = 0; i < brojZnakova; i++)
            {
                int naredniZnak = random.Next(znakovi.Length);//50... 23, 7
                lozinka.Append(znakovi[naredniZnak]);
            }
            txtLozinka.Text = lozinka.ToString();
        }

        private void GenerisiEmail()
        {
            txtEmail.Text = $"{txtIme.Text.ToLower()}.{txtPrezime.Text.ToLower()}@edu.fit.ba";
        }

        private void GenerisiBrojIndeksa()
        {
            var indeks = (db.GetPosljednjiId() + 1).ToString().PadLeft(4, '0');
            txtBrojIndeksa.Text = $"IB{DateTime.Now.Year % 100}{indeks}";
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiEmail();
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiEmail();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                BrojIndeksa = txtBrojIndeksa.Text,
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Email = txtEmail.Text,
                Lozinka = txtLozinka.Text,
                DatumRodjenja = dtpDatumRodjenja.Value,
                Slika = pbSlikaStudenta.Image,
                Aktivan = cbAktivan.Checked
            };
            db.Add(student);
            MessageBox.Show("Student je uspješno dodan.");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
