using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find online more information about ASCII(American Standard Code for Information Interchange) and write a program that prints part of the ASCII table of characters at the console.  On the first line of input, you will receive the char index you should start with, and on the second line -the index of the last character you should print.

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <=end; i++) 
            {
                char symbol = (char)i; // кастване на int към char и изпечатване
                Console.Write(symbol + " ");
                //Console.WriteLine($"{(char)i} ");This is the equivalent of the above 2 lines!
            }
        }
    }
}