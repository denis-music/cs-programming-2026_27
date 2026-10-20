using DLWMS26.Data.Models;

namespace DLWMS26.ConsoleApp.Predavanja
{
    internal class P1
    {
        public static void Pokreni()
        {
            //OsnovniTipoviPodataka();
            //BazniTip();
            //UpravljenjeIzuzecima();
            //VrijednostiReference();
            //Properties();
            Ekstenzije();
        }

        private static void Ekstenzije()
        {
            DateTime danas = DateTime.Now;            
            if (danas.JelVikend())
                Console.WriteLine("Super, nema predavanja :)");
            else
                Console.WriteLine(";(");
        }

        private static void Properties()
        {
            Predmet matematika = new Predmet() { Oznaka = "MAT101" };
            matematika.Naziv = "Matematika";
          
        }

        private static void VrijednostiReference()
        {
            Student student1 = new Student(1, "IB230032", "Goran", "Skondric");
            Student student2 = student1;
            student1.Ime = "Haris";

            Student student3 = new Student(3, "IB230032", "Goran", "Skondric");
            Student student4 = new Student(4, "IB230032", "Goran", "Skondric");
            if(student3 == student4)
                Console.WriteLine("Isti studenti");


            sStudent sStudent1 = new sStudent("IB230032", "Goran", "Skondric");
            sStudent sStudent2 = sStudent1;
            sStudent1.Ime = "Haris";


            int brojStudenata = 3;
            Student[] studenti = new Student[brojStudenata];
            sStudent[] sStudenti = new sStudent[brojStudenata];

            for (int i = 0; i < studenti.Length; i++)
            {
                studenti[i] = new Student();
                studenti[i].BrojIndeksa = $"IB2600{i + 1}";
                studenti[i].Ime = $"Ime {i + 1}";
                studenti[i].Prezime = $"Prezime {i + 1}";
            }
            for (int i = 0; i < sStudenti.Length; i++)
            {
                sStudenti[i].BrojIndeksa = $"IB2600{i + 1}";
                sStudenti[i].Ime = $"Ime {i + 1}";
                sStudenti[i].Prezime = $"Prezime {i + 1}";
            }
        }

        private static void UpravljenjeIzuzecima()
        {
            try
            {
                File.Open("nepostojeca.txt", FileMode.Open);
            }
            catch (Exception ex)
            {
               Izuzetak.Info(ex);
            }
        }

        private static void BazniTip()
        {
            object goran = new Student(1, "IB230032", "Goran", "Skondric");
            object godina = 2026;//boxing
            object imePrezime = "Goran Skondric";

            Info(godina);
            
            Console.WriteLine(goran);

            if (goran is Student s)
            {                
                Console.WriteLine($"Student: {s.Ime} {s.Prezime}");
            }
            //Osoba * o = new Student("IB230032", "Goran", "Skondric");            
            //Student *s = dynamic_cast<Student*>(o);//null
        }

        private static void Info(object obj)
        {
            if(obj is Student s)
            {
                Console.WriteLine($"Student: {s.Ime} {s.Prezime}");
            }
            else if (obj is int i)
            {
                Console.WriteLine($"Godina: {i}");
            }
            else if (obj is string str)
            {
                Console.WriteLine($"Ime i prezime: {str}");
            }

        }

        private static void OsnovniTipoviPodataka()
        {
            int godina = new int();//=0
            if(godina == 2026)
                Console.WriteLine("Godina je 2026.");

            bool isStudent = false;
            string imePrezime = "Goran Skondric";
        }
    }
}
