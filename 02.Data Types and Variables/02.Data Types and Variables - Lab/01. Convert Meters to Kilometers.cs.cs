using System;
using System.Diagnostics.Metrics;

namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Convert Meters to Kilometers
            // You will be given an integer that will be distance in meters.Write a program that converts   meters to kilometers formatted to the second decimal point.

            int meters = int.Parse(Console.ReadLine());
            float kilometers = meters / 1000.0F;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}