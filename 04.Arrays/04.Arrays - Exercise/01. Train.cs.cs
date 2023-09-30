using System;

namespace _01._Day_of_Week_IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
            };
            int number = int.Parse(Console.ReadLine());

            if(number<1||number>7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[number-1]);
            }
        }
    }
}