using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DLWMS26.WinApp.Igre.Vjesala
{
    public partial class frmVjesala : Form
    {

        string[] _rijeci = { "programiranje", "kompjuter", "softver", "hardver", "algoritam" };
        Random _random = new Random();
        string _trenutnaRijec;
        char[] _prikazRijeci;
        int _preostaliPokusaji;
        const int _maxPokusaja = 6;

        public frmVjesala()
        {
            InitializeComponent();
        }
        private void frmVjesala_Load(object sender, EventArgs e)
        {
            PokreniNovuIgru();
        }

        private void PokreniNovuIgru()
        {
            _trenutnaRijec = _rijeci[_random.Next(_rijeci.Length)];//2
            _prikazRijeci = new string('_', _trenutnaRijec.Length).ToCharArray();
            _preostaliPokusaji = _maxPokusaja;

            progresPokusaji.Maximum = _maxPokusaja;
            progresPokusaji.Minimum = 0;
            progresPokusaji.Value = 0;

            UpdatePrikaz();
            txtSlovo.Clear();
            txtSlovo.Focus();
        }

        private void UpdatePrikaz()
        {
            lblPrikaz.Text = string.Join(' ', _prikazRijeci);
            progresPokusaji.Value = _maxPokusaja - _preostaliPokusaji;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var unos = txtSlovo.Text.ToLower();//d
            if(unos.Length!= 1 || !char.IsLetter(unos[0]))
            {
                MessageBox.Show("Unesite jedno slovo.");
                return;
            }

            var slovo = unos[0];//o
            if(_trenutnaRijec.Contains(slovo))//softver
            {
                for (int i = 0; i < _trenutnaRijec.Length; i++)
                {
                    if (_trenutnaRijec[i] == slovo)
                    {
                        _prikazRijeci[i] = slovo;
                    }
                }
            }
            else
            {
                _preostaliPokusaji--;
            }

            UpdatePrikaz();
        }
    }
}
