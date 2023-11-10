using System.Text;

namespace _02._Repeat_Strings_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                             .ToArray();

            StringBuilder result = new StringBuilder();
            foreach (string str in input) 
            {
                int index = str.Length;
                for (int i = 0; i < index; i++)
                {
                    result.Append(str);
                }
            }
            Console.WriteLine(result);
        }
    }
}