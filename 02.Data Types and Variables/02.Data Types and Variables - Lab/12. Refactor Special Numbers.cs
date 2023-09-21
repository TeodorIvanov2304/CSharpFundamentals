using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperNumber = int.Parse(Console.ReadLine());
            
            
            
            for (int number = 1; number <= upperNumber; number++)
            {
                
                int currentNumber = 0;
                currentNumber = number;
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currentNumber, isSpecial);
                sum = 0;
                number = currentNumber;
            }


        }
    }
}