using System;
using System.Globalization;

class DifferenceBetweenDates
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        DateTime firstDate = DateTime.ParseExact(first, "hh:mm", CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(second, "hh:mm", CultureInfo.InvariantCulture);
        Console.WriteLine((secondDate - firstDate).TotalDays);
    }
}
