using System;
using System.Reflection;

namespace _04._Refactoring_Prime_Checker
{
    internal class RefactoringPrimeChecker
    {
        static void Main(string[] args)
        {
            //You are given a program that checks if numbers in a given range[2...N] are prime. For each number is printed "{number} -> {true or false}".The code, however, is not very well written.Your job is to modify it in a way that is easy to read and understand.

            int upperBound = int.Parse(Console.ReadLine());
            for (int startingNumber = 2; startingNumber <= upperBound; startingNumber++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor < startingNumber; divisor++)
                {
                    if (startingNumber % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{startingNumber} -> {isPrime.ToString().ToLower()}");
            }
        }
    }
}