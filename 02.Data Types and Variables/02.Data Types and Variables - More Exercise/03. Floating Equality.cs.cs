using System;
namespace _03._Floating_Equality
{
    internal class FloatingEquality
    {
        static void Main(string[] args)
        {
            // Write a program that safely compares floating - point numbers(double) with precision eps = 0.000001.Note that we cannot directly compare two floating - point numbers a and b by a == b, because of the nature of the floating - point arithmetic.Therefore, we assume two numbers are equal if they are more close to each other than some fixed constant eps.
            //You will receive two lines, each containing a floating-point number.Your task is to compare the values of the two numbers.


            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            //Тук се използва Math.Abs за да се изчисли абсолютната стойност на разликата между двата double числа, и след това се сравнява тази разлика с предварително зададената точност epsilon. Ако абсолютната разлика е по-малка от epsilon, тогава числата се считат за равни с точност до 0.000001.

            if (Math.Abs(numberA - numberB)<eps) 
            {
                Console.WriteLine("True");
                //Console.WriteLine($"{Math.Abs(numberA - numberB):F8}");
            }
            else
            {
                Console.WriteLine("False");
                //Console.WriteLine($"{Math.Abs(numberA - numberB):F8}");
            }

        }
    }
}