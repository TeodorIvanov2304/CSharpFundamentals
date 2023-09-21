using System;
using System.ComponentModel;

namespace _06._Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes 3 lines of characters and prints them in reversed order with space between them.

            string chars = string.Empty; 
            // Създаваме променлива, която пази символите
            string reversedChars = string.Empty; 
            // Създаваме променлива, която пази символите в обратен ред
            
            for (int i = 1; i <=3; i++)
            //Създаваме цикъл, който чете от конзолата три символа
            {
                char input = char.Parse(Console.ReadLine());
                // Пълним chars със символите
                chars = chars + input;
                
            }
            // Създаваме цикъл, който обръща string chars наобратно
            for (int j = chars.Length - 1; j >= 0; j--)
            {
                // Пълним reversedChars с обърнатите символи
                reversedChars += chars[j] + " ";
            }
            Console.WriteLine(reversedChars);

        }
    }
}