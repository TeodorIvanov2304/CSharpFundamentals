using System.Text;
using System.Xml;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {   
                char currentSymbol = text[i];
                if (char.IsDigit(currentSymbol))
                {
                    digits.Append(currentSymbol).ToString();
                }
                else if (char.IsLetter(currentSymbol))
                {
                    letters.Append(currentSymbol);
                }
                else
                {
                    symbols.Append(currentSymbol);
                }

            }
            
            Console.WriteLine($"{digits}\n{letters}\n{symbols}");
        }
    }
}