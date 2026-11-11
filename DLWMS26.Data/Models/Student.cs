using System.Globalization;

namespace DLWMS26.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string BrojIndeksa { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Student(int id = 0, string brojIndeksa = "", string ime = "", string prezime ="")
        {
            Id = id;
            BrojIndeksa = brojIndeksa;
            Ime = ime;
            Prezime = prezime;
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
