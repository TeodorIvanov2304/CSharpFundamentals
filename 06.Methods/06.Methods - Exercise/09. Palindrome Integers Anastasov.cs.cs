namespace _09._Palindrome_Integers
{
    internal class PalindromeIntegers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            input = CheksForPalindromes(input);
        }

        static string CheksForPalindromes(string input)
        {
            while (input != "END")
            {
                string reversed = string.Empty;
                reversed = StringReverse(input, reversed);
                bool result = input == reversed;
                PrintResult(result);
                input = Console.ReadLine();
            }

            return input;
        }

        static void PrintResult(bool result)
        {
            Console.WriteLine(result);
        }

        static string StringReverse(string input, string reversed)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            return reversed;
        }
    }
}