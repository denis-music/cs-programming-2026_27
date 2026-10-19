namespace DLWMS26.ConsoleApp.Predavanja
{
    public static class EkstenzijeTipova
    {
        extension(DateTime dt)
        {
            public bool JelVikend()
            {
                return dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday;
            }
        }
        
    }
}
