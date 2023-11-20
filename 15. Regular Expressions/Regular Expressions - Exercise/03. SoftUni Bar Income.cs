using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%([A-Z][a-z]+)\%[^|$%.]*\<(\w+)\>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+(?:\.\d+)?)\$";
            double totalPrice = 0;
            string input = "";
            while ((input = Console.ReadLine()) != "end of shift") 
            {
                foreach (Match item in Regex.Matches(input,pattern))
                {
                    string name = item.Groups[1].Value;
                    string product = item.Groups[2].Value;
                    uint count = uint.Parse(item.Groups[3].Value);
                    double price = double.Parse(item.Groups[4].Value);
                    

                    Console.WriteLine($"{name}: {product} - {price*count:F2}");
                    totalPrice += price*count;
                }
            }
            Console.WriteLine($"Total income: {totalPrice:F2}");
        }
    }
}