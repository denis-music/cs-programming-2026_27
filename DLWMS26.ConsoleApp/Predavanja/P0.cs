using DLWMS26.Data.Models;

using System;
using System.Collections.Generic;
using System.Text;

namespace DLWMS26.ConsoleApp.Predavanja
{
    internal class P0
    {
        public static void Pokreni()
        {
            OsnoveKlasa();
        }

        private static void OsnoveKlasa()
        {
            Student gornaSkondric = new Student("IB230032", "Gorna", "Skondric");

            var denisMusic = new Student("IB230033", "Denis", "Music");

            Student jasminAzemovic = new("IB230034", "Jasmin", "Azemovic");


            Student johnDoe = new Student
            {
                BrojIndeksa = "12345",
                Ime = "John",
                Prezime = "Doe"
            };

            Console.WriteLine(johnDoe.BrojIndeksa + " " + johnDoe.Ime + " " + johnDoe.Prezime);
            Console.WriteLine($"{johnDoe.BrojIndeksa} {johnDoe.Ime} {johnDoe.Prezime}");

            Student janeSmith = new Student();
            janeSmith.BrojIndeksa = "67890";
            janeSmith.Ime = "Jane";
            janeSmith.Prezime = "Smith";
        }
    }
}
