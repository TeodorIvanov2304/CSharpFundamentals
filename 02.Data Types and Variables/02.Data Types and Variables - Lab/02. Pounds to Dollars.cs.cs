using System;
using System.ComponentModel;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that converts British pounds to US dollars formatted to 3th decimal point.
            //1 British Pound = 1.31 Dollars

            decimal dollars = decimal.Parse(Console.ReadLine());
            decimal pounds = dollars * 1.31M;

            Console.WriteLine($"{pounds:F3}");

        }
    }
}