using System.Runtime.Intrinsics.X86;

namespace _10._Multiply_Evens_by_Odds
{
    internal class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            // Create a program that multiplies the sum of all even digits of a number by the sum of all odd digits of the same number:
            //• Create a method called GetMultipleOfEvenAndOdds()
            //• Create a method GetSumOfEvenDigits()
            //• Create GetSumOfOddDigits()
            //• You may need to use Math.Abs() for negative numbers

            //Четем число от конзолата
            int number = int.Parse(Console.ReadLine());

            //Презаписваме number в абсолютната му стойност
            number = ConvertToAbsoluteValue(number);

            //Създаваме промелнива, която пази върнатия резултат от методите
            int result = MultyplyEvensByOds(number);

            //Изпечатваме на конзолата
            Console.WriteLine(result);

        }

        //Метод с целият алгоритъм, който връща резултата
        private static int MultyplyEvensByOds(int number)
        {
            int evenSum = 0;
            int oddSum = 0;
            AlgorithmForFindingSum(ref number, ref evenSum, ref oddSum);
            return evenSum * oddSum;
        }


        //Намираме сумата на всички цифри
        private static void AlgorithmForFindingSum(ref int number, ref int evenSum, ref int oddSum)
        {
            while (number > 0)
            {
                int currentNumber = DetermineCurrentNumber(number);
                DetermineOddEvenAndSum(ref evenSum, ref oddSum, currentNumber);
                number = DivideBy10(number);
            }
        }

        //Определяме дали цифрата е четна/нечетна и добавяме към съответната сума
        private static void DetermineOddEvenAndSum(ref int evenSum, ref int oddSum, int currentNumber)
        {
            if (currentNumber % 2 == 0)
            {
                evenSum += currentNumber;
            }
            else
            {
                oddSum += currentNumber;
            }
        }

        //Намиране на текущото число
        private static int DetermineCurrentNumber(int number)
        {
            return number % 10;
        }

        //Намаляване на числото с 1 цифра, като го делим на 10
        private static int DivideBy10(int number)
        {
            return number / 10;
        }

        //Конвертиране на число в абсолютната му стойност
        private static int ConvertToAbsoluteValue(int number)
        {
            number = Math.Abs(number);
            return number;
        }
    }
}