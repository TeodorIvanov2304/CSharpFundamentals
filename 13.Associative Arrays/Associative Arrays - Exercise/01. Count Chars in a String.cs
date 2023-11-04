using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> characterOccurances = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];
                if (!characterOccurances.ContainsKey(currentSymbol) && currentSymbol != ' ')
                {
                    characterOccurances[currentSymbol] = 1;
                    //characterOccurances.Add(currentSymbol,1);
                }
                else if(characterOccurances.ContainsKey(currentSymbol) && currentSymbol != ' ') 
                {
                    characterOccurances[currentSymbol]++;
                }
            }

            Dictionary<char, int> ordered = new Dictionary<char, int>();
            characterOccurances.OrderBy(c => c);

            foreach(KeyValuePair<char,int> kvp in characterOccurances)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}