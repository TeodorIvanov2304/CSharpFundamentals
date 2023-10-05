using System.Collections.Generic;

namespace _03._Calculations
{
    internal class Calculations
    {
        static void Main(string[] args)
        {
            //Create a program that receives three lines of input:
            //• On the first line – a string – "add", "multiply", "subtract", "divide".
            //• On the second line – a number.
            //• On the third line – another number.
            //You should create four methods(for each calculation) and invoke the corresponding method depending on the
            //command.The method should also print the result(needs to be void).

            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            // Създаване Switch-case за командите събиране, изваждане, умножение и деление
            switch (command)
            {
                case "add":
                    Add(firstNumber, secondNumber); // Повикваме метода
                    break;
                case "substract":
                    Subtract(firstNumber, secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNumber, secondNumber);
                    break;
                case "divide":
                    Divide(firstNumber, secondNumber);
                    break;


            }

            

        }

        private static void Divide(int firstNumber, int secondNumber) //Метод, който дели числата
        {
            Console.WriteLine(firstNumber / secondNumber);
        }

        private static void Multiply(int firstNumber, int secondNumber) //Метод, който умножава числата
        {
            Console.WriteLine(firstNumber * secondNumber);
        }

        private static void Subtract(int firstNumber, int secondNumber) //Метод, който вади числата
        {
            Console.WriteLine(firstNumber - secondNumber);
        }

        private static void Add(int firstNumber, int secondNumber) //Метод, който събира числата
        {
            Console.WriteLine(firstNumber + secondNumber);
        }
    }
}