using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> text = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];
                if (!text.ContainsKey(currentSymbol) && currentSymbol != ' ')
                {
                    text[currentSymbol] = 1;
                }
                else if(text.ContainsKey(currentSymbol) && currentSymbol != ' ') 
                {
                    text[currentSymbol]++;
                }
            }

            Dictionary<char, int> ordered = new Dictionary<char, int>();
            text.OrderBy(c => c);

            foreach(KeyValuePair<char,int> kvp in text)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}