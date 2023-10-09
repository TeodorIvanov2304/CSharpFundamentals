using System.ComponentModel;

namespace _05._Multiplication_Sign
{
    internal class MultiplicationSign
    {
        static void Main(string[] args)
        {
            //You are given a number num1, num2 and num3. Write a program that finds if num1 * num2 * num3(the product) is negative, positive or zero.Try to do this WITHOUT multiplying the 3 numbers.
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int negativeCount = 0;
            string result = string.Empty;
            if (CheckForZero(num1, num2, num3))
            {
                result = "zero";
                PrintResult(result);
                return;
            }

            negativeCount = CheckForNegativeNumbers(num1, num2, num3, negativeCount);
            result = CheckForPostiveOrNegativeProduct(negativeCount, result);

        }

        static string CheckForPostiveOrNegativeProduct(int negativeCount, string result)
        {
            if (negativeCount == 0 || negativeCount == 2)
            {
                result = "positive";
                PrintResult(result);
            }
            else if (negativeCount == 1 || negativeCount == 3)
            {
                result = "negative";
                PrintResult(result);
            }

            return result;
        }

        static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }

        static int CheckForNegativeNumbers(int num1, int num2, int num3, int negativeCount)
        {
            if (num1 < 0)
            {
                negativeCount++;
            }
            if (num2 < 0)
            {
                negativeCount++;
            }
            if (num3 < 0)
            {
                negativeCount++;
            }

            return negativeCount;
        }

        static bool CheckForZero(int num1, int num2, int num3)
        {
            return num1 == 0 || num2 == 0 || num3 == 0;
        }
    }
}