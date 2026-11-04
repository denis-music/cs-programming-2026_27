using DLWMS26.WinApp.Igre.Vjesala;
using DLWMS26.WinApp.Igre.XO;

namespace DLWMS26.WinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Form startnaForma = new frmVjesala();
            //Osoba osoba = new Student();
            Application.Run(startnaForma);
        }
    }
}