using System.ComponentModel;
using System;

namespace _02._Bit_at_Position_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints the bit at position 1 of the given integer. We use the standard counting: from right to left, starting from 0

            int number = int.Parse(Console.ReadLine());
            int shiftedNumber = number >> 1;

            //Проверяваме какъв е последният символ, като добавяме 0001 (1).Ако е 1, връща 1.
            //Ако е 0, връща 0
            int leastSignificantBit = shiftedNumber & 1;

            Console.WriteLine(leastSignificantBit);
        }
    }
}