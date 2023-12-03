using System.Drawing;
using System.Text.RegularExpressions;

namespace _02._Easter_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[@|#]{1,}(?<Color>[a-z]{3,})[@|#]{1,}[^A-Za-z0-9]*[\/]{1,}(?<Amount>[0-9]+)[\/]{1,}";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches) 
            {
                Console.WriteLine($"You found {match.Groups["Amount"]} {match.Groups["Color"]} eggs!");
            }
        }
    }
}