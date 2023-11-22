using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //string pattern = @"(?'User'[a-z\._-]?)+@(?'Host'[a-z-\.]+)";    33/100
            //Регекс за извличане на имейли
            string pattern = @"((?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))";
            MatchCollection emails = Regex.Matches(input, pattern);
            foreach (Match match in emails)
            {
                Console.WriteLine(match);
            }
        }
    }
}