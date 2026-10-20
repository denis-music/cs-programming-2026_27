using DLWMS26.Data.Models;

namespace DLWMS26.Servis
{
    //CRUD - Create, Read, Update, Delete
    public class StudentServis
    {
        static List<Student> studenti = new List<Student>()
        {
            new Student { Id = 1, BrojIndeksa = "IB200001", Ime = "Goran", Prezime = "Skondric" },
            new Student { Id = 2, BrojIndeksa = "IB200002", Ime = "Haris", Prezime = "Vejzovic" },
            new Student { Id = 3, BrojIndeksa = "IB200003", Ime = "Amar", Prezime = "Azemovic" },
            new Student { Id = 4, BrojIndeksa = "IB200004", Ime = "Amina", Prezime = "Hodzic" },
        };

        public void Add(Student student)
        {
            student.Id = studenti.Max(s => s.Id) + 1;
            studenti.Add(student);
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
