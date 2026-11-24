using DLWMS26.Data.Models;
using DLWMS26.Servis;

using System.DirectoryServices;

namespace DLWMS26.WinApp
{
    public partial class Form1 : Form
    {
        StudentServis db = new StudentServis();
        /*
         //delegat
	    int (*ptr2)(int, int);
	*/


        //dogadjaj (event) = kupovina
        //umanjiti stanje na skladistu
        //pokrenuti proceduru pakovanja
        //pokrenuti proceduru slanja

        delegate void Skladiste(int kolicina);
        event Skladiste Kupovina;

        private int Stanje { get; set; } = 150;
        public void UmanjiStanje(int kolicina)
        {
            Stanje -= kolicina;
            txtStudenti.Text = $"Stanje na skladistu je: {Stanje}";
            Task.Delay(1000).Wait();
        }
        public void PokreniPakovanje(int kolicina)
        {
            txtStudenti.Text += $"\r\nPokrenuto pakovanje za {kolicina} proizvoda.";
            Task.Delay(1000).Wait();
        }

        public void PokreniSlanje(int kolicina)
        {
            txtStudenti.Text += $"\r\nPokrenuto slanje za {kolicina} proizvoda.";
            Task.Delay(1000).Wait();
        }

        public Form1()
        {
            InitializeComponent();

            Kupovina += UmanjiStanje;
            Kupovina += PokreniPakovanje;
            Kupovina += PokreniSlanje;            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> sviStudenti = db.GetAll();
            PrikaziDetalje(sviStudenti);
            db.Add(new Student { Ime = "Amar", Prezime = "Hodžić", BrojIndeksa = "IB123/2023" });
            sviStudenti = db.GetAll();
            PrikaziDetalje(sviStudenti);
        }

        private void PrikaziDetalje(List<Student> sviStudenti)
        {
            txtStudenti.Text += "----------------------------------------\r\n";
            foreach (var student in sviStudenti)
                txtStudenti.Text += student + "\r\n";
        }

        private void btnKupovina_Click(object sender, EventArgs e)
        {
            int kolicina = int.Parse(txtKolicina.Text);
            Kupovina?.Invoke(kolicina);
        }
    }
}
