namespace DLWMS26.Data.Models
{
    public class Korisnik(int id = 0, string korisnickoIme = "", string lozinka = "")
    {
        public int Id { get; set; } = id;
        public string KorisnickoIme { get; set; } = korisnickoIme;
        public string Lozinka { get; set; } = lozinka;

        public override string ToString()
        {
            return $"{KorisnickoIme} {Lozinka}";
        }
    }
}
