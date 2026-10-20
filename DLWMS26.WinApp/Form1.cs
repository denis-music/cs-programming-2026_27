using DLWMS26.Data.Models;
using DLWMS26.Servis;

namespace DLWMS26.WinApp
{
    public partial class Form1 : Form
    {
        StudentServis db = new StudentServis();

        public Form1()
        {
            InitializeComponent();
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
    }
}
