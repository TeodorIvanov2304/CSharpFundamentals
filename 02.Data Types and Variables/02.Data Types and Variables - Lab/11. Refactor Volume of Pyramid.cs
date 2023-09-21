using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Length: ");
            double length = double.Parse(Console.ReadLine());
            //Console.WriteLine("Width: ");
            double width = double.Parse(Console.ReadLine());
            //Console.WriteLine("Height: ");
            double height = double.Parse(Console.ReadLine());
            double volume = (length * width) / 3 * height;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");

        }
    }
}