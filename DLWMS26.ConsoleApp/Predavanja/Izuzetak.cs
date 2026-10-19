namespace DLWMS26.ConsoleApp.Predavanja
{
    public class Izuzetak
    {
        public static void Info(Exception ex)
        {
            if (ex is ArgumentException ax)
                Ispisi(ex, ax.ParamName);
            else if(ex is FileNotFoundException fnfx)
                Ispisi(ex, fnfx.FileName);
        }
        private static void Ispisi(Exception ex, string? detalji)
        {
            string crt = new string('-', 50);
            Console.WriteLine($"{crt}\nPoruka: {ex.Message}\n{crt}");
            Console.WriteLine($"Stek: {ex.StackTrace}\n{crt}");
            Console.WriteLine($"Izvor: {ex.Source}\n{crt}");
            Console.WriteLine($"Detalji: {detalji}\n{crt}");
        }
    }
}
