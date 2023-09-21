using System;
using System.ComponentModel;

namespace _09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads 3 lines of input.
            //On each line you get a single character. Combine all the characters into one string and print it on the console.

            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());
            string concatenateChars = $"{firstChar}{secondChar}{thirdChar}";

            Console.WriteLine(concatenateChars);
        }
    }
}