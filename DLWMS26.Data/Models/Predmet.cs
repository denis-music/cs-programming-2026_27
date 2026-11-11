namespace DLWMS26.Data.Models
{
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
}
