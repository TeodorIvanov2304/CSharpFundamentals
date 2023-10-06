using System;

namespace _03._Characters_in_Range
{
    internal class CharsInRange
    {
        static void Main(string[] args)
        {
            // Create a method that receives two characters and prints all the characters between them according to ASCII(on a single line).
            //NOTE: If the second letter's ASCII value is less than that of the first one, then the two initial letters should be swapped.

            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            char swap = ' ';

            //Swap chars if needed
            if (secondSymbol < firstSymbol)
            {
                swap = firstSymbol;
                firstSymbol = secondSymbol;
                secondSymbol = swap;
            }
            //Call the method
            IterrateSymbols(firstSymbol, secondSymbol);
        }

        //Print all chars between two symbols
        public static void IterrateSymbols(char firstSymbol, char secondSymbol)
        {
            for (char i = (char)(firstSymbol + 1); i < secondSymbol; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}