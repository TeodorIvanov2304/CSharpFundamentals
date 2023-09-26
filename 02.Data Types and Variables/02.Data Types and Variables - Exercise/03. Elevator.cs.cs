using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberOfPeople = double.Parse(Console.ReadLine());
            double elevatorCapacity = double.Parse(Console.ReadLine());
            double courses = numberOfPeople /elevatorCapacity;

            //int courses = (int)Math.Ceiling((double)numberOfPeople/elevatorCapacity); тук кастваме първо към double, а после към int Math Ceiling
            Console.WriteLine(Math.Ceiling(courses)); 
            
            // Закръгляме със Ceiling, защото хората винаги са цяло число
        }
    }
}