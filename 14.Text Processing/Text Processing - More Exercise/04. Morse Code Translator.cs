using System.Text;

namespace _04._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reading the input
            string input = Console.ReadLine();

            //Splitting the input by separators
            string[] inputTokens = input.Split(' ', '|', StringSplitOptions.RemoveEmptyEntries).ToArray();

            //Foreach word in all words
            foreach (string word in inputTokens)
            {
                //We use the TranslateLetter method
                char letter = TranslateLetter(word);
                //Creating StringBuilder
                StringBuilder sb = new StringBuilder();
                //Append symbol
                sb.Append(letter);
                //Print
                Console.Write(string.Join(' ', sb));
            }

        }

        //Translates Morse code to English
        public static char TranslateLetter(string word)
        {
            //We write the Morse code in a dictionary - opposite it the corresponding letter
            SortedDictionary<string, char> rozettaStone = new SortedDictionary<string, char>()
            { {".-", 'A'},
                {"-...", 'B'},
                {"-.-.", 'C'},
                {"-..", 'D'},
                {".", 'E'},
                {"..-.", 'F'},
                {"--.", 'G'},
                {"....", 'H'},
                {"..", 'I'},
                {".---", 'J'},
                {"-.-", 'K'},
                {".-..", 'L'},
                {"--", 'M'},
                {"-.", 'N'},
                {"---", 'O'},
                {".--.", 'P'},
                {"--.-", 'Q'},
                {".-.", 'R'},
                {"...", 'S'},
                {"-", 'T'},
                {"..-", 'U'},
                {"...-", 'V'},
                {".--", 'W'},
                {"-..-", 'X'},
                {"-.--", 'Y'},
                {"--..", 'Z'}

        };

            //We create a variable that will hold the dictionary value corresponding to the corresponding morse code
            char result = default;

            //Check if the Morse letter is correct
            if (rozettaStone.ContainsKey(word))
            {
                result = rozettaStone[word];
            }
            //Check if symbol == " "
            else
            {
                result = ' ';
            }
            //Returns corresponding Enligsh letter
            return result;
        }
    }
}