// See https://aka.ms/new-console-template for more information

using System.Globalization;

public class Timer
{
    public static void Main()
    {
        DateTime localDate = DateTime.Now;
        DateTime utcDate = DateTime.UtcNow;
        if (!(CultureInfo.CurrentCulture.NativeName != "Invariant Language (Invariant Country)"))
        {
            Console.WriteLine($"{CultureInfo.CurrentCulture.NativeName}:");
            Console.WriteLine($"\tLocal date and time: {localDate.ToString("s", CultureInfo.CurrentCulture)}, {localDate.Kind}");
            Console.WriteLine($"\tUTC date and time: {utcDate.ToString("s", CultureInfo.CurrentCulture)}, {utcDate.Kind}");
        }
        else
        {
            string cultureName = "en-US";
            CultureInfo culture = new CultureInfo(cultureName);
            Console.WriteLine($"{culture.NativeName}:");
            Console.WriteLine($"\tLocal date and time: {localDate.ToString("s", culture)}, {localDate.Kind}");
            Console.WriteLine($"\tUTC date and time: {utcDate.ToString("s", culture)}, {utcDate.Kind}");
        }
    }
}