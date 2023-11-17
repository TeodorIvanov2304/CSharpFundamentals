using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+([359]+)([- ])2(\2)(\d{3})(\2)(\d{4})\b";
            string phoneInputs = Console.ReadLine();
            Regex phonePatters = new Regex(pattern);
            

            var matches = phonePatters.Matches(phoneInputs);

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}