using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\W(?<Name>[A-Z][a-z]+)\W+(?<Product>[A-Z][a-z]+)\W+(\D*|W+)(?<Count>[0-9]+)\W+(?<Price>[0-9]+\.[0-9]|[A-z]+\d+|\W*)\$";
            double totalPrice = 0;
            string input = "";
            while ((input = Console.ReadLine()) != "end of shift") 
            {
                foreach (Match item in Regex.Matches(input,pattern))
                {
                    string name = item.Groups["Name"].Value;
                    string product = item.Groups["Product"].Value;
                    uint count = uint.Parse(item.Groups["Count"].Value);
                    double price = 0;
                    string numberPattern = @"[^\.\d]";
                    string number = Regex.Replace(item.Groups["Price"].Value, numberPattern, "").ToString();

                    price = double.Parse(number);
                    
                    Console.WriteLine($"{name}: {product} - {price*count:F2}");
                    totalPrice += price*count;
                }
            }
            Console.WriteLine($"Total income: {totalPrice:F2}");
        }
    }
}