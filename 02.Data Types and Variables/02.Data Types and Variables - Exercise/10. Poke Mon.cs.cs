using System;
using System.Transactions;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exaustionFactor = int.Parse(Console.ReadLine());

            int count = 0;
            double temoraryPower = pokePower * 0.5;
            
            while (pokePower >= distance) 
            {
                count++;
                pokePower -= distance;

                if(pokePower == temoraryPower && exaustionFactor > 0)
                {
                    pokePower = pokePower / exaustionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(count);
        }
    }
}