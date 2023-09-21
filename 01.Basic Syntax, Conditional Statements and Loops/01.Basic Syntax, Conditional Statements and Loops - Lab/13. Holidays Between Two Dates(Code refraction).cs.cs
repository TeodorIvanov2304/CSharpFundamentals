using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        // ParseExact парсва дата
        var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture); // Като напишеш d, се появи падащо меню, от което избрах date (1-2) digits
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var holidaysCount = 0;
        // date.AddDays(1)) добавя едим ден

        for (var date = startDate; date <= endDate; date = date.AddDays(1))
        { // DayOfWeek е стандартна ЕНУМЕРАЦИЯ, която съдържа дните от седмицата
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }

        }
        Console.WriteLine(holidaysCount);
    }
}