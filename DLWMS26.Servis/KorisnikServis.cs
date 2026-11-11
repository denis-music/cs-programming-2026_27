using DLWMS26.Data.Models;

namespace DLWMS26.Servis
{
    public class KorisnikServis
    {
        static List<Korisnik> korisnici = new List<Korisnik>()
        {
            new Korisnik { Id = 1, KorisnickoIme = "Goran", Lozinka = "Skondric" },
            new Korisnik { Id = 2, KorisnickoIme = "Haris", Lozinka = "Vejzovic" },
            new Korisnik { Id = 3, KorisnickoIme = "Amar", Lozinka = "Azemovic" },
            new Korisnik { Id = 4, KorisnickoIme = "Amina", Lozinka = "Hodzic" },
        };

        public Korisnik? GetByKorisnickoIme(string korisnickoIme)//Haris
        {
            ////OPCIJA 1
            //for (int i = 0; i < korisnici.Count; i++)
            //{
            //    if (korisnici[i].KorisnickoIme == korisnickoIme)
            //        return korisnici[i];
            //}
            //return null;

            ////OPCIJA 2
            //foreach (var korisnik in korisnici)
            //{
            //    if (korisnik.KorisnickoIme == korisnickoIme)
            //        return korisnik;
            //}
            //return null;

            ////OPCIJA 3
            //return korisnici.Where(k => k.KorisnickoIme == korisnickoIme).FirstOrDefault();


            //OPCIJA 4
            return korisnici.Find(k => k.KorisnickoIme == korisnickoIme);
        }

    }






}
