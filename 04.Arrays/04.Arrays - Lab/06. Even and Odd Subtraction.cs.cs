using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    internal class SumEvenNumbers
    {
        static void Main(string[] args)
        {
            //Read an array from the console and sum only its even values. 

            // Четем числата от конзолата и ги запазваме в масив int
            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            // Създаваме променлива, която пази сумата на четните числа
            int sum = 0;

            //Създаване цикъл, който върти от 0 до края на масива(numbers.Length)
            for (int i = 0; i < numbers.Length; i++)
            {   
                //Създаваме променлива, която пази текущото число
                int currentNumber = numbers[i];

                // Проверяваме дали текущото число е четно
                if(currentNumber%2==0)
                {   
                    // Ако да, добавяме го към сумата
                    sum += currentNumber;
                }
            }

            //Изпечатваме сумата
            Console.WriteLine(sum);
        }
    }
}