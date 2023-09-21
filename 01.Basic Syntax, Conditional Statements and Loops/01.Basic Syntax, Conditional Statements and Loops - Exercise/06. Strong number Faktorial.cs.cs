using System;
using System.ComponentModel;

namespace _06._Strong_number_Faktorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that receives a single integer and calculates if it's strong or not. A number is strong, if the sum of the factorials of each digit is equal to the number itself.
            //Example: 145 is a strong number, because 1! + 4! + 5! = 145.
            //Print "yes", if the number is strong and "no", if the number is not strong.

            int integer = int.Parse(Console.ReadLine()); // четем числото от конзолата
            int number = integer;   // Създаваме променлива в която ще пазим числото, за да я сравним

            int currentNumber = 0; // създаваме променлива, в която пазим текущото число (последното)
            int factorialSum = 0; // Създаваме променлива, в която ще пазим сумата от факториелите

            while(number!=0) // В цикъла ще делим числото, докато остане 0; 
            {
                currentNumber = number % 10; // Намираме последното число (5 от 145)
                number = number / 10; // Делим на 10, за да премахнем последното число
                int factorial = 1; // Факториел е 1, а не 0, защото иначе няма да сработи

                for (int i = 1; i <=currentNumber; i++) //В този цикъл намираме n! на отделните числа, започвайки да умножаваме от 1, до текущото число.
                {
                    factorial = factorial * i; // умножаваме факториел по i , за да намерим n! на числото
                }
                factorialSum = factorialSum + factorial; //събираме сумите от n! на отделните числа
            }
            if(integer == factorialSum) // Проверяваме дали входа е = на сумата от n!
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}