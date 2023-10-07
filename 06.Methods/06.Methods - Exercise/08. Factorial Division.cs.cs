using System.Collections.Generic;

namespace _08._Factorial_Division
{
    internal class FactorialDivision
    {
        static void Main(string[] args)
        {
            //Read two integers.Calculate the factorial of each number. Divide the first result by the second and print the result of the division formatted to the second decimal point.

            //Creating DECIMAL variables, becasuse decimal is more accurate
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            firstNumber = FindFactorial(firstNumber);
            secondNumber = FindFactorial(secondNumber);

            decimal result = Divide(firstNumber, secondNumber);

            PrintResult(result);
        }
        //PRINT FORMATTED RESULT
        public static void PrintResult(decimal result)
        {
            Console.WriteLine($"{result:F2}");
        }

        //FIND RESULT BY DIVIDE
        public static decimal Divide(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber / secondNumber;
        }

        //FIND FACTORIAL
        public static decimal FindFactorial(decimal firstNumber)
        {
            decimal factoriel = 1;
            while (true)
            {
                if (firstNumber <= 1)
                {
                    break;
                }
                factoriel = factoriel * firstNumber;
                firstNumber--;
            }

            return factoriel;
        }
    }
}