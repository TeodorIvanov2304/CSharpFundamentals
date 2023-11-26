using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class EmojiDetector
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            BigInteger coolTreshold = 1;
            List<int> numbers = new List<int>();
            //FIND COOL TRESHOLD
            for (int i = 0; i < input.Length; i++)
            {
                bool isANumber = "1234567890".Contains(input[i]);

                if (isANumber)
                {
                    //Първо конвертваме char ToString, и ПОСЛЕ int.Parse за да вземем стойността, а не ASCII
                    int number = int.Parse(input[i].ToString());
                    numbers.Add(number);
                    coolTreshold *= number;
                }
            }

            Console.WriteLine($"Cool threshold: {coolTreshold}");

            //find emoji **Text** ::Text:: 
            string pattern = @"(\*{2}|\:{2})(?<Emoji>[A-Z][a-z]{2,})\1";
            MatchCollection emojis = Regex.Matches(input, pattern);
            int emojiCount = emojis.Count;
            List<string> coolEmojis = new List<string>();
            foreach (Match match in emojis) 
            {
                int coolnes = 0;
                for (int i = 2; i < match.Length-2; i++)
                {
                    char currentSymbol = match.Value[i];
                    
                    coolnes += (int)currentSymbol;
                }
                if (coolnes>coolTreshold) 
                {
                    coolEmojis.Add(match.Value);
                }
            }

            Console.WriteLine($"{emojiCount} emojis found in the text. The cool ones are:");

            
            foreach (string emoji in coolEmojis)
            {
                Console.WriteLine($"{emoji}");
            }

        }


    }
}