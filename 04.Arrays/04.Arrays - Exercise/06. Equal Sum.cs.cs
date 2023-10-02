using System.Xml.Linq;
using System;
using System.Collections;

namespace _06._Equal_Sum
{
    internal class EqualSum
    {
        static void Main(string[] args)
        {
            //Create a program that determines if an element exists in an array for which the sum of all elements to its left is equal to the sum of all elements to its right.If there are no elements to the left or right, their sum is considered to be 0.Print the index of the element that satisfies the condition or "no" if there is no such element.

            //Четем масива от конзолата
            int[] array = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();

            //Създаваме флаг променлива, която = false
            bool isFound = false;

            //Създаваме цикъл, който върти по дължината на целия масив array
            for (int current = 0; current<array.Length; current++)
            {   
                //Създаваме променлива, която пази дясната сума и ще се нулира на края на всеки current цикъл
                int rightSum = 0;

                //Създаваме цикъл, който върти от текущото(current) число + 1 до края на масива
                for (int i = current + 1; i < array.Length; i++)
                {   
                    //Пълним променливата за дясна сума с текущото [i] число от масива
                    rightSum += array[i];
                }
                //Създаваме променлива, която пази лявата сума от current числото
                int leftSum = 0;

                //Създаваме обратен цикъл, който върти налявао от current числото
                for (int i = current-1; i>=0; i--)
                {
                    //Пълним променливата с лявата сума с [i] число от масива
                    leftSum += array[i];
                }

                //Сравняваме дали лява и дясна сума са равни
                if(rightSum == leftSum)
                {   
                    //Ако да, отпечатваме current числото, което пази индекса на "разделителя"
                    Console.WriteLine(current);
                    //Активираме флаг променливата и брейкваме цикъла
                    isFound = true;
                    break;
                }
            }
            //Ако няма такова число(разделителя) изпечатваме "no"
            if (!isFound) 
            {
                Console.WriteLine("no");
            }
        }
    }
}