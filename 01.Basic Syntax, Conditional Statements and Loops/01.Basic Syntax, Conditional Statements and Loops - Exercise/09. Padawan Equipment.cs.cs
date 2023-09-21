using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            int freebelts = studentCount / 6;

            double finalPrice = (lightsaberPrice * Math.Ceiling(studentCount * 1.10)) + (robePrice * studentCount) + (beltPrice * (studentCount - freebelts));

            if(money>=finalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {finalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {finalPrice-money:F2}lv more.");
            }

        }
    }
}