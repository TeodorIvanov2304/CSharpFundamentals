using System.Text;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Barcode pattern @#FreshFisH@#, @###Brea0D@###, @##Che46sE@##, @##Che46sE@###
            string pattern = @"@[#]+[A-Z][A-Za-z0-9]{4,}[A-Z]@[#]+";
            int barcodesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < barcodesCount; i++)
            {
                string barcode = Console.ReadLine();
                Match match = Regex.Match(barcode, pattern);
                StringBuilder productGroup = new StringBuilder();
                if (match.Success)
                {
                    for (int j = 0; j < barcode.Length; j++)
                    {   
                        char currentSymbol = barcode[j];
                        if (char.IsDigit(currentSymbol))
                        {
                            productGroup.Append(currentSymbol);
                        }
                        
                    }
                    if (productGroup.Length == 0) 
                    {
                        productGroup.Append("00");
                    }
                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}