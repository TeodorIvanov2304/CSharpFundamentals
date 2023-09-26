using System;
using System.Collections.Generic;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that receives an integer n and print all triples of the first n small Latin letters, ordered
            //alphabetically:
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    
                    for (int k = 0; k < n; k++)
                    {
                        char firstChar = (char)('a' + i);    // Casting i(int) to char!!
                        //char firstChar = (char)(97 + i);    // Casting i(int) to char!!
                        char secondChar = (char)('a' + j);   // Casting j(int) to char!!
                        char thirdChar = (char)('a' + k);    // Casting k(int) to char!!
                        Console.Write($"{firstChar}{secondChar}{thirdChar}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}