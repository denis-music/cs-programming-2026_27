using DLWMS26.Data.Models;
using DLWMS26.Servis;

using System;
using System.Collections.Generic;
using System.Text;

namespace DLWMS26.ConsoleApp.Predavanja
{
    internal class P2
    {

        static StudentServis db = new StudentServis();
        public static void Pokreni()
        {
            //CRUDoperacije();
            //NullProjevera();
            //Var();
            //Imutabilnost();
            Params();

        }

        private static void Params()
        {
            int suma1 = Sumiraj(new int[]{2, 5, 8,12, 9});
            int suma2 = Sumiraj([2, 5, 8, 9, 10]);
            int suma3 = Sumiraj(2, 5, 8, 9, 10,10,25, "Denis", true);


            string rezultat = string.Join("-", "denis", 29, 2.5, true, "Goran");
            Console.WriteLine(rezultat);

        }

        private static int Sumiraj(params object[] niz)   
        {
            string rezultat = "";
            foreach (var obj in niz)
            {
                if(obj is int broj)
                rezultat += broj + "-";
                if(obj is double d)
                    rezultat += d + "-";
                if(obj is Student s)
                    rezultat += s.ToString() + "-";
            }


            return 0;
        }

        private static void Imutabilnost()
        {
            string ime = "Amar";//Amar
           ime = ime.ToUpper();//AMAR
            Console.WriteLine(ime);//AMAR

            DateTime danas = DateTime.Now;//19.10.2026
            DateTime za5dana = danas.AddDays(5);//24.10.2026 //19.10.2026                                                
        }

        private static void Var()
        {
            var ime = "Amar";
            var denis = new Student() { Ime = "Denis", Prezime = "Hodžić", BrojIndeksa = "IB123/2023" };

            Student goran = new() { Id = 1, BrojIndeksa = "IB124/2023" };

            List<Student> podaci = db.GetAll();
        }

        private static void NullProjevera()
        {
            Student pronadjeni = db.GetByIndeks("IB20*002");//null
            // null
            pronadjeni ??= new Student();

            if (pronadjeni is not null)
                Console.WriteLine(pronadjeni?.Ime ?? "NEMA PODATAKA");//Haris -> Amar);

            if (pronadjeni is { Ime: "Denis" })
                Console.WriteLine("Student se zove Denis");

            ArgumentNullException.ThrowIfNull(pronadjeni, "Student ne postoji");
            ArgumentNullException.ThrowIfNull(pronadjeni);

            if (string.IsNullOrEmpty(pronadjeni?.Ime))
                throw new ArgumentNullException("Ime studenta ne smije biti null ili prazan string");

            int? godina = null;
            Nullable<int> godina2 = null;
        }

        private static void CRUDoperacije()
        {
            List<Student> sviStudenti = db.GetAll();
            PrikaziDetalje(sviStudenti);
            db.Add(new Student { Ime = "Amar", Prezime = "Hodžić", BrojIndeksa = "IB123/2023" });
            sviStudenti = db.GetAll();
            PrikaziDetalje(sviStudenti);

        }

        private static void PrikaziDetalje(List<Student> sviStudenti)
        {
            Console.WriteLine("----------------------------------------");
            foreach (var student in sviStudenti)
                Console.WriteLine(student);
        }
    }

    public class AplikacijaInfo
    {
        public const string Naziv = "DLWMS26";
        public readonly string Verzija;

        public AplikacijaInfo(string verzija)
        {
            Verzija = verzija;
        }
    }

}