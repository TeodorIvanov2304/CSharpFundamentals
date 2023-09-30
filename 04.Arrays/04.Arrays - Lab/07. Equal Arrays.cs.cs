using System;
using System.Collections.Generic;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read two arrays and determine whether they are identical or not.The arrays are identical, if all their elements are equal. If the arrays are identical, find the sum of the elements of one of them and print the following message to the console: "Arrays are identical. Sum: {sum}"
            //Otherwise, find the first index where the arrays differ and print the following message to the console:  "Arrays are not identical. Found difference at {index} index"

            //Четем двата масива от конзолата
            int[] array1 = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

            int[] array2 = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

            //Създаваме променлива, която пази сумата, ако двата масива са идентични
            int sum = 0;

            //Създаваме флаг-променлива тип bool
            bool flag = false;

            //Създаваме цикъл, който върти по дължинатан едната променлива
            for (int i = 0; i < array1.Length; i++)
            {   
                //Проверяваме дали двата масива са еднакви
                if (array1[i] != array2[i])
                {   
                    //Ако не изпечатваме съответния изход и прекъсваме цикъла
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    flag = true;
                    break;
                }
                
                else
                {   
                    //Ако да, добавяме към сумата
                    int currentNumber = array1[i];
                    sum += currentNumber;
                }
                
            }

            //След края на цикъла проверяваме дали flag = true, ако не , изпечатваме сумата
            if(!flag)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            
        }
    }
}
