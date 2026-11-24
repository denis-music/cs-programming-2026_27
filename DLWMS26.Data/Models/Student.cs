using System.Drawing;
using System.Globalization;
using System.Security.Principal;

namespace DLWMS26.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string BrojIndeksa { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public Image? Slika { get; set; }
        public bool Aktivan { get; set; }


        public Student(int id = 0, string brojIndeksa = "", string ime = "", string prezime ="",
            string email = "", string lozinka = "", DateTime datumRodjenja = default, Image? slika = null, bool aktivan = true)
        {
            Id = id;
            BrojIndeksa = brojIndeksa;
            Ime = ime;
            Prezime = prezime;
            Email = email;
            Lozinka = lozinka;
            DatumRodjenja = datumRodjenja;
            Slika = slika;
            Aktivan = aktivan;
        }
        public override string ToString()
        {            
            return $"{Id} - {Ime} {Prezime} ({BrojIndeksa})";
        }
    }

    public struct sStudent
    {
        public string BrojIndeksa { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public sStudent(string brojIndeksa = "", string ime = "", string prezime = "")
        {
            BrojIndeksa = brojIndeksa;
            Ime = ime;
            Prezime = prezime;
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime} ({BrojIndeksa})";
        }
    }
}
