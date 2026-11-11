using DLWMS26.Data.Models;
using DLWMS26.Servis;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Reflection.Emit;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace DLWMS26.WinApp
{
    public partial class frmPrijava : Form
    {
        KorisnikServis db = new KorisnikServis();
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            var korisnickoIme = txtKorisnickoIme.Text;
            var lozinka = txtLozinka.Text;

            if (ValidanUnos())
            {
                var korisnik = db.GetByKorisnickoIme(korisnickoIme);
                if (korisnik != null)
                {
                    if (korisnik.Lozinka == lozinka)
                    {
                        Hide();

                        Aplikacija.PrijavljeniKorisnik = korisnik;

                        var glavna = new frmGlavna();
                        if (glavna.ShowDialog() == DialogResult.OK)
                        {
                            OcistiPolja();
                            Show();
                        }
                        else
                            Close();
                    }
                    else
                    {
                        MessageBox.Show("Pogresna lozinka");
                    }
                }
                else
                {
                    MessageBox.Show("Korisnik ne postoji");
                }
            }
        }

        private void OcistiPolja()
        {
            txtKorisnickoIme.Text = txtLozinka.Text = "";
        }

        private bool ValidanUnos()
        {
            return Validator.ObaveznoPolje(txtKorisnickoIme, err)
                && Validator.ObaveznoPolje(txtLozinka, err);
        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {           
        }

        private void cmbJezik_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resursi.PromijeniJezik(cmbJezik.Text.ToLower());
            PostaviJezik();
        }

        private void PostaviJezik()
        {
            lblKorisnickoIme.Text = Resursi.GetString(Kljucevi.UserName);
            lblLozinka.Text = Resursi.GetString(Kljucevi.Password);
        }
    }
    public class Validator
    {
        public static bool ObaveznoPolje(object control, ErrorProvider err)
        {
            if(control is TextBox textBox)
            {
                if(string.IsNullOrWhiteSpace(textBox.Text))
                {
                    err.SetError(textBox, "Obavezno polje");
                    return false;
                }                
            }
            err.Clear();
            return true;
        }
    }
    public class Aplikacija
    {
        public static Korisnik? PrijavljeniKorisnik { get; set; }
    }

    public class Resursi
    {
        static ResourceManager rm = new ResourceManager(
            "DLWMS26.WinApp.Properties.Resources", 
            typeof(Resursi).Assembly);

        public static CultureInfo TrenutnaKultura { get; set; } = new CultureInfo("bs");

        public static void PromijeniJezik(string oznakaKulture)//en, de, fr
        {
            TrenutnaKultura = new CultureInfo(oznakaKulture);
            CultureInfo.DefaultThreadCurrentUICulture = TrenutnaKultura;
            Thread.CurrentThread.CurrentUICulture = TrenutnaKultura;
        }

        public static string GetString(string key)//user_name
        {
            return rm.GetString(key);
        }

    }
    public class Kljucevi
    {
        public const string UserName = "user_name";
        public const string Password = "password";
    }
}
