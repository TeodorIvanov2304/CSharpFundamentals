namespace _02._Vowels_Count
{
    internal class VowelsCount
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int vowelCounter = 0;
            vowelCounter = StringIterrator(input, vowelCounter);
            Console.WriteLine(vowelCounter);

        }

        public static int StringIterrator(string input, int vowelCounter)
        {
            for (int i = 0; i < input.Length; i++)
            {
                vowelCounter = CountVowels(input, vowelCounter, i);
            }

            return vowelCounter;
        }

        public static int CountVowels(string input, int vowelCounter, int i)
        {
            bool isVowel = "aeiouAEIOU".Contains(input[i]);

            if (isVowel)
            {
                vowelCounter++;
            }

            return vowelCounter;
        }
    }
}