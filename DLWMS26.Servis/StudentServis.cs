using DLWMS26.Data.Models;

namespace DLWMS26.Servis
{
    //CRUD - Create, Read, Update, Delete
    public class StudentServis
    {
        static List<Student> studenti = new List<Student>()
        {
            new Student { Id = 1, BrojIndeksa = "IB200001", Ime = "Goran", Prezime = "Skondric", Email = "goran.skondric@edu.fit.ba", Lozinka = "password", DatumRodjenja = new DateTime(2000, 1, 1), Slika = null, Aktivan = true },
            new Student { Id = 2, BrojIndeksa = "IB200002", Ime = "Haris", Prezime = "Vejzovic", Email = "haris.vejzovic@edu.fit.ba", Lozinka = "password", DatumRodjenja = new DateTime(2000, 2, 2), Slika = null, Aktivan = true },
            new Student { Id = 3, BrojIndeksa = "IB200003", Ime = "Amar", Prezime = "Azemovic", Email = "amar.azemovic@edu.fit.ba", Lozinka = "password", DatumRodjenja = new DateTime(2000, 3, 3), Slika = null, Aktivan = true },
            new Student { Id = 4, BrojIndeksa = "IB200004", Ime = "Amina", Prezime = "Hodzic", Email = "amina.hodzic@edu.fit.ba", Lozinka = "password", DatumRodjenja = new DateTime(2000, 4, 4), Slika = null, Aktivan = true },
        };

        public void Add(Student student)
        {
            student.Id = GetPosljednjiId() + 1;
            studenti.Add(student);
        }

        public int GetPosljednjiId() {
            return studenti.Max(s => s.Id);
        }

        public List<Student> GetAll()
        {
            return studenti;
        }
        public Student? GetByIndeks(string indeks)//IB209002
        {
            return studenti.Find(s => s.BrojIndeksa == indeks);
        }
    }
}
