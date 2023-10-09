using System.ComponentModel;
using System.Reflection.Metadata;
using System;

namespace _04._Tribonacci_Sequence
{
    internal class TribonacciSequence
    {
        static void Main(string[] args)
        {
            //In the "Tribonacci" sequence, every number is formed by the sum of the previous 3 numbers.
            //You are given a number num. Write a program that prints num numbers from the Tribonacci sequence, on a single line, starting from 1.The input comes as a parameter named num.The value num will always be a positive integer.

            int num = int.Parse(Console.ReadLine());
            int[] tribonacci = new int[num];
            //Създаваме циък, който ще върти от 1 до n и ще отговаря на броя цифри от Трибоначи
            Tribonacci(tribonacci);
            PrintResult(tribonacci);
        }

        static void PrintResult(int[] tribonacci)
        {
            Console.Write($"{string.Join(" ", tribonacci)} ");
        }

        //Намиране на Трибоначи
        static void Tribonacci(int[] tribonacci)
        {
            for (int i = 0; i < tribonacci.Length; i++)
            {
                //Първите 2 числа от Трибоначи трябваа да са 1
                if (i < 2)
                {
                    tribonacci[i] = 1;
                }
                //Третото число трябва да е 2
                if (i == 2)
                {
                    tribonacci[i] = 2;
                }
                //От третото число нататък всички числа са сбор на предишните 3
                FindNextNumber(tribonacci, i);

            }
        }
        //Намиране на всички числа след 3-тото
        static void FindNextNumber(int[] tribonacci, int i)
        {
            if (i > 2)
            {
                tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
            }
        }
    }
}