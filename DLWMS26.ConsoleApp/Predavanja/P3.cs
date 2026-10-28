using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace DLWMS26.ConsoleApp.Predavanja
{
    internal class P3
    {
        static ILogger _logger;


        private static void Indekseri()
        {
            //Studenti denis = new Studenti(150051, "Denis", "Hodzic");
            //denis["PRII"] = 8;
            //Console.WriteLine(denis["PRII"]);
            //denis["PRII"] = 10;
            //Console.WriteLine(denis["PRIII"]);
        }
        public static void Pokreni(ILogger logger)
        {
            _logger = logger;


            //Indekseri();
            //Nasljedjivanje();
            //Apstrakcija();
            Interfejsi();
        }


        private static void Apstrakcija()
        {

            _logger.Log("Pokrenuta metoda Apstrakcija");

            Osoba[] osobe = [
               new Studenti(150051, "Goran", "Skondric"),
                new Nastavnik("Denis", "Hodzic", "Prof. Dr.")
           ];
            foreach (var osoba in osobe)
            {
                Console.WriteLine(osoba.Info());
            }
        }

        private static void Nasljedjivanje()
        {
            _logger.Log("Pokrenuta metoda Nasljedjivanje");


            Osoba[] osobe = [
                new Studenti(150051, "Goran", "Skondric"),
                new Nastavnik("Denis", "Hodzic", "Prof. Dr.")
            ];
            foreach (var osoba in osobe)
            {
                Console.WriteLine(osoba.Info());
            }

        }
        private static void Interfejsi()
        {
            IPristupSistemu[] osobe = [
                new Studenti(150051, "Goran", "Skondric"),
                new Nastavnik("Denis", "Hodzic", "Prof. Dr.")                
            ];

            IPristupSistemu nastavnik = new Nastavnik("Denis", "Hodzic", "Prof. Dr.");
            foreach (var osoba in osobe)
            {
                Console.WriteLine($"Korisnicko ime: {osoba.KorisnickoIme}");
                Console.WriteLine($"Prijava: {osoba.PrijaviSe("nastavnik123")}");
            }

        }
    }
    public interface IPristupSistemu
    {
        string KorisnickoIme { get; }
        bool PrijaviSe(string lozinka);
    }

    public interface ILogger
    {
        void Log(string poruka);
    }

    public class FileLogger : ILogger
    {
        string putanja = "C:\\Users\\online\\source\\repos\\DLWMS26\\DLWMS26.ConsoleApp\\log.txt";
        public void Log(string poruka)
        {
            Console.WriteLine($"FileLogger: {poruka}");
        }
    }
    public class DBLogger : ILogger
    {
        string konekcijskiString = "Server=localhost;Database=DLWMS26;Trusted_Connection=True;";
        public void Log(string poruka)
        {
            Console.WriteLine($"DBLogger: {poruka}");
        }
    }





    public class DLStudent { }

    public abstract class Osoba
    {
        public string Ime { get; set; } = string.Empty;
        public string Prezime { get; set; } = string.Empty;
        public string ImePrezime => $"{Ime} {Prezime}";
        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
        public override string ToString()
        {
            return ImePrezime;           
        }
        public abstract string Info();        
    }    
    public class Studenti : Osoba, IPristupSistemu
    {
        public int BrojIndeks { get; set; }

        public string KorisnickoIme => $"student{BrojIndeks}";//150051

        public bool PrijaviSe(string lozinka)
        {
            return lozinka == "student123";
        }

        public Studenti(int brojIndeksa, string ime, string prezime) : base(ime, prezime)
        {
            BrojIndeks = brojIndeksa;
        }
        public override string Info()
        {
            return $"Student: {ImePrezime}, Broj Indeksa: {BrojIndeks}";
        }

    }
    public class Nastavnik : Osoba, IPristupSistemu
    {
        public string KorisnickoIme => $"nastavnik{ImePrezime.Replace(" ", "")}";//nastavnikDenisMusic
        public bool PrijaviSe(string lozinka)
        {
            return lozinka == "nastavnik123";
        }



        public string Zvanje { get; set; } = string.Empty;
        public Nastavnik(string ime, string prezime, string zvanje) : base(ime, prezime)
        {
            Zvanje = zvanje;
        }
        public override string Info()
        {
            return $"Nastavnik: {ImePrezime}, Zvanje: {Zvanje}";
        }
    }


}
