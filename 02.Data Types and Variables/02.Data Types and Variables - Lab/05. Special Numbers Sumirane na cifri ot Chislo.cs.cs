using System;
using System.ComponentModel;
using System.Text;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A number is special when its sum of digits is 5, 7 or 11.
            //Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is special or not (True / False).

            int n = int.Parse(Console.ReadLine());// четем n от конзолата

            for (int num = 1; num <=n; num++) // пускаме цикъл от 1 до n
            {
                int sumOfDigits = 0; // създаваме променлива, която пази сумата от числата
                int digits = num;    // създаваме променлива digits, която приравняваме на текущото число num

                while (digits > 0) // пускаме while цикъл, който върти докато digits>0
                {
                    sumOfDigits = sumOfDigits + digits % 10; // в сумата добавяме числото, като го % 10;
                    digits = digits / 10; // делим на 10 да премахнем последното число, докато = 0
                }

                // създаване булева променлива която да разбере дали числото е специално (5,7,11)
                bool isSpecial = (sumOfDigits == 5) || 
                                 (sumOfDigits == 7) || 
                                 (sumOfDigits == 11);

                if (isSpecial) 
                {
                    Console.WriteLine($"{num} -> True");
                }
                else
                {
                    Console.WriteLine($"{num} -> False");
                }
            }
            

        }
    }
}