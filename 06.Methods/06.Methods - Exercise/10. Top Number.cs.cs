using System.Collections.Generic;
using System.Security.Cryptography;
using System;

namespace _10._Top_Number
{
    internal class TopNumber
    {
        static void Main(string[] args)
        {
            // A top number is an integer that holds the following properties:
            //• Its sum of digits is divisible by 8, e.g. 8, 17, 88
            //• Holds at least one odd digit, e.g. 232, 707, 87578
            //• Some examples of top numbers are: 17, 161, 251, 4310, 123200
            //Create a program to print all top numbers in the range[1…n].
            //You will receive a single integer from the console, representing the end value.

            int number = int.Parse(Console.ReadLine());

            FindTopNumbers(number);
        }

        //Finding Top Numbers Method
        static void FindTopNumbers(int number)
        {
            //Iterrate all numbers from [1 - number]
            for (int i = 1; i <= number; i++)
            {
                //Creating variables for counting odd digits and current digits sum
                int oddCounter = 0;
                int sumDigits = 0;

                //Cheking if the digits are more than 1
                if (i >= 10)
                {
                    int currentDigit = i;

                    //Creating While-Loop to add digits to the sum
                    while (currentDigit > 0)
                    {
                        int lastDigit = currentDigit % 10;
                        //Summing the digits
                        sumDigits = SumDigits(sumDigits, lastDigit);
                        //Odd digits counter
                        oddCounter = CountOddDigits(oddCounter, lastDigit);
                        //Dividing by 10 to find next last digit
                        currentDigit = FindNextLastDigit(currentDigit);
                    }
                }
                //Cheks if the current number is Top Number
                IsNumberTopOrNot(i, oddCounter, sumDigits);
            }
        }

        static int FindNextLastDigit(int currentDigit)
        {
            currentDigit /= 10;
            return currentDigit;
        }

        static int SumDigits(int sumDigits, int lastDigit)
        {
            sumDigits += lastDigit;
            return sumDigits;
        }

        static int CountOddDigits(int oddCounter, int lastDigit)
        {
            if (lastDigit % 2 != 0)
            {
                oddCounter++;
            }

            return oddCounter;
        }

        static void IsNumberTopOrNot(int i, int oddCounter, int sumDigits)
        {
            if (sumDigits % 8 == 0 && oddCounter > 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}