using System;

namespace _09._Spice_Must_Flow__not_included_in_final_score_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int spice = 0;
            int days = 0;
            while (yield >= 100) 
            {
                spice += yield;
                spice -= 26;
                yield -= 10;
                days++;
            }
            if (spice >= 26)
            {
                spice -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(spice);

        }
    }
}