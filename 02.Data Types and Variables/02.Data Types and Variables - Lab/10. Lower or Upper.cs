using System;
using System.ComponentModel;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints whether a given character is upper -case or lower case.

            char ch = char.Parse(Console.ReadLine());

            if(ch>='A' && ch<='Z') 
            {
                Console.WriteLine("upper-case");
            }
            if(ch>='a' && ch<='z')
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}