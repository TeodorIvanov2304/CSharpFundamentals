using System;
using System.ComponentModel;
using System.Numerics;

namespace _03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write program to enter n numbers and calculate and print their exact sum(without rounding).

            int n = int.Parse(Console.ReadLine());
            decimal sum = 0.0M;
            for (int i = 1; i <= n; i++)
            {
                
                sum += decimal.Parse(Console.ReadLine());

            }
            
            Console.WriteLine(sum);
        }
    }
}