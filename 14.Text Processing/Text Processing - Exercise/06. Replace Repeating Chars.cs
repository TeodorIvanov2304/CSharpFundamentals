using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    result.Append(input[i]);
                }
            }

            // Append the last character
            result.Append(input[input.Length - 1]);

            string output = result.ToString();
            Console.WriteLine(output);
        }
    }
}