namespace _06._Middle_Characters
{
    internal class MiddleCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintStringMiddleLetter(input);

        }

        public static void PrintStringMiddleLetter(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length / 2 && input.Length % 2 == 0)
                {
                    Console.WriteLine($"{input[i - 1]}{input[i]}");
                }
                else if (i == input.Length / 2 && input.Length % 2 != 0)
                {
                    Console.WriteLine(input[i]);
                }

            }
        }
    }
}