using System.ComponentModel;
using System;

namespace _03._P_th_Bit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints the bit at position p of the given integer. We use the standard counting: from right to left, starting from 0.
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int shiftedNumber = number >> position;
            int leastSignificantBit = shiftedNumber & 1;
            Console.WriteLine(leastSignificantBit);
        }
    }
}