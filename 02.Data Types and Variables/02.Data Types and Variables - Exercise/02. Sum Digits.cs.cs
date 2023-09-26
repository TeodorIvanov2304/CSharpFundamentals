using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that receives a single integer. Your task is to find the sum of its digits.
            //For example: 12345 → 1 + 2 + 3 + 4 + 5 = 15

            string number = Console.ReadLine();
            
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                //int nextNumber = (int)Char.GetNumericValue(number[i]); // Кастване на Int към Char Time: 0.100 s
                int nextNumber = int.Parse(number[i].ToString()); // Time: 0.120 s
                sum += nextNumber;
            }
            Console.WriteLine(sum);

        }
    }
}