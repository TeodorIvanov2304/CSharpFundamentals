using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace _11._Math_operations
{
    internal class MathOperations
    {
        static void Main(string[] args)
        {
            // Write a method that receives two numbers and an operator, calculates the result and returns it. You will be given three lines of input. The first will be the first number, the second one will be the operator and the last one will be the second number.
            //The possible operators are: /, *, +and -.

            //Четем първото число
            int firstNumber = int.Parse(Console.ReadLine());
            //Четем операцията
            char operation = char.Parse(Console.ReadLine());
            //Четем второто число
            int secondNumber = int.Parse(Console.ReadLine());
            //Създаваме променлива, която пази резултата и извикваме метода
            int result = Opretions(firstNumber, operation, secondNumber); ;
            //Изпечатваме резултата
            Console.WriteLine(result);



        }

        //Функция, която връща резултата в зависимост от опреацията 
        static int Opretions(int firstNumber, char operation, int secondNumber)
        {
            int result = 0;
            switch (operation)
            {

                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    result = firstNumber / secondNumber;
                    break;
            }
            return result;
        }
    }
}


                