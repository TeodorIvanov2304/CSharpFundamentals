﻿/*
 
You will be given a list of numbers and a string. For each element of the list you must calculate the sum of its digits and take the element, corresponding to that index from the text. If the index is greater than the length of the text, start counting from the beginning (so that you always have a valid index). After you get that element from the text, you must remove the character you have taken from it (so for the next index the text will be with one characterless). 
*/
namespace _01._Messaging
{
    internal class Messaging
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();
            string text = Console.ReadLine();

            string finalText = "";
            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = 0;
                string sums = numbers[i].ToString();
                for (int j = 0; j < sums.Length; j++)
                {
                    int currentNumber = int.Parse(sums[j].ToString());
                    sum += currentNumber;
                }

                int index = sum;

                if (index > text.Length)
                {
                    index = index - text.Length;
                }

                finalText += text[index];
                text = text.Remove(index, 1);

            }
            Console.WriteLine(finalText);

        }
    }
}