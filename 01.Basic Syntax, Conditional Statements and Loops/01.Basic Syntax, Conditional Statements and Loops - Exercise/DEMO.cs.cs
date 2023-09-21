using System;
using System.Numerics;

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uvajaemi zriteli, parvata mi funkcia!!!");
            MoyataParvaFunkcia();
            Add();
            Substract();
            Multiply();
            Divide();
            Reminder();
            DivideDouble();
            Factoriel();
            DoWhileFactoriel();
            LongProduct();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("End");
        }

        static void MoyataParvaFunkcia()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Za Bebeto!!!");
        }
        static void Add(int a = 5, int b = 10)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(a + b);
        }
        static void Substract(int a = 5, int b = 10)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(a - b);
        }
        static void Multiply(int a = 5, int b = 10)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(a * b);
        }
        static void Divide(int a = 5, int b = 10)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(a / b);
        }
        static void DivideDouble(double a = 5, double b = 10)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(a / b);
        }
        static void Reminder(int a = 5, int b = 10)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(a % b);
        }
        static void Factoriel() // Намиране на факториел от 5
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter number for finding Factoriel: ");
            int a = int.Parse(Console.ReadLine());
            decimal factoriel = 1;
            while (true)
            {
                if (a <= 1)
                {
                    break;
                }
                factoriel = factoriel * a;
                a--;
            }
            Console.WriteLine("n! = " + factoriel);
        }
        static void DoWhileFactoriel()
        // Използваме BigInteger за пръв път, за голям факториел, очевидно нямаше нужда да го добавям чрез Reference / System.Numerics
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter number for finding Factoriel: ");
            int a = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;
            do
            {
                factoriel *= a;
                a--;
            }
            while (a > 0);
            Console.WriteLine("n! = " + factoriel);
        }
        static void LongProduct()
        {
            Console.WriteLine("Finding factoriel from n to m with do-while loop");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            int num = n;
            long product = 1;
            do
            {
                product = product * num;
                num++;
            } while (num <= m);
            Console.WriteLine("Product[n..m] = " + product);
        }

    }
}