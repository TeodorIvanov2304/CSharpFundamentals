using System.Globalization;

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now1 = DateTime.Now; //Времето сега
            DateTime now2 = DateTime.UtcNow; // Времето сега в UTC (Coordinated Universal Time) формат
            DateTime now3 = DateTime.Today; // Времето днешна дата
            Console.WriteLine(now1);
            Console.WriteLine(now2);
            Console.WriteLine(now3);
            Console.WriteLine("----------------");
            var dateString = "5/1/2008 8:30:52 AM";
            DateTime date1 = DateTime.Parse(dateString,CultureInfo.InvariantCulture);
            // парсване на стринг към DateTime
            var iso8601String = "20080501T08:30:52Z";
            DateTime dateISO8602 = DateTime.ParseExact(iso8601String, "yyyyMMddTHH:mm:ssZ",CultureInfo.InvariantCulture);

            
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(dateISO8602);
            Console.WriteLine(dateString);

            string input = "2 is a number";

            int num = int.Parse(input[0].ToString());
            Console.WriteLine(num);
        }
    }
}