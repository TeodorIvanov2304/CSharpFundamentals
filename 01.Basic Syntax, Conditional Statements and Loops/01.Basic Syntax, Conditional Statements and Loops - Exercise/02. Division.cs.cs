using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You will be given an integer, write a program which checks if the given integer is divisible by 2 or 3, or 6, or 7, or 10 without a remainder. You should always take the bigger division:
            //• If the number is divisible by both 2, 3, and 6, you should print the division by 6 only.
            //• If a number is divisible by 2 and 10, you should print the division by 10.
            //If the number is not divisible by any of the given numbers, print "Not divisible".Otherwise, print "The number is divisible by {number}".

            int integer = int.Parse(Console.ReadLine());
            int number = 0;
            if (integer % 10 == 0) 
            {
                number = 10;
                Console.WriteLine($"The number is divisible by {number}");
            }
            else if(integer % 7 == 0)
            {   
                number = 7;
                Console.WriteLine($"The number is divisible by {number}");
            }
            else if(integer % 6 == 0)
            {   
                number = 6;
                Console.WriteLine($"The number is divisible by {number}");
            }
            else if(integer % 3 == 0)
            {   
                number = 3;
                Console.WriteLine($"The number is divisible by {number}");
            }
            else if (integer % 2 == 0)
            {
                number = 2;
                Console.WriteLine($"The number is divisible by {number}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}