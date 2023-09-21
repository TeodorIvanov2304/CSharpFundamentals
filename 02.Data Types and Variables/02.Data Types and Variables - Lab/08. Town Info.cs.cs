using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace _08._Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will be given 3 lines of input.On the first line you will be given the name of the town, on the second – the population and on the third the area. Use the correct data types and print the result in the following format:
            //"Town {town name} has population of {population} and area {area} square km".

            string townName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");

        }
    }
}