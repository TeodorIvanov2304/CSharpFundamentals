using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Regex for finding First and Last name
            string pattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)";
            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.Write($"{m.Value} ");
            }
        }
    }
}