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


    public class Predmet
    {
        //string _naziv;
        //public string GetNaziv(){ return _naziv; }
        //public void SetNaziv(string naziv) { _naziv = naziv; }

        public required string Oznaka { get; set; }
        public string Naziv { //string _naziv; => field
            get {
                if(string.IsNullOrEmpty(field))
                    return "N/A";
                return field;
            } 
            set { 
                field = 
                    string.IsNullOrEmpty(value)
                    ? throw new ArgumentException("Naziv predmeta ne smije biti prazan.")
                    : value;
            } 
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
