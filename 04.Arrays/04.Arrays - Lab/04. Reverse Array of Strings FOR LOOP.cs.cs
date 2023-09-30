using System;
using System.Linq;
namespace _04._Reverse_Array_of_Strings_FOR_LOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split(" ").ToArray();

            for (int i = 0; i < items.Length/2; i++)
            {
                string odlElements = items[i];
                items[i] = items[items.Length - 1 - i];
                items[items.Length - 1 - i] = odlElements;
            }
            Console.WriteLine(string.Join(" ", items));
        }
    }
}
