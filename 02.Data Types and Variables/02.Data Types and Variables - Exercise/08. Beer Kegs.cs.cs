using System;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program, which calculates the volume of n beer kegs. You will receive in total 3 * n lines.Every three lines
            //will hold information for a single keg.First up is the model of the keg, after that is the radius of the keg, and lastly is the height of the keg.
            //Calculate the volume using the following formula: π* r^2 * h.
            //In the end, print the model of the biggest keg.

            byte bierKegs = byte.Parse(Console.ReadLine());
            double maxVolume = double.MinValue;
            string maxKeg = string.Empty;
            
            for (int i = 0; i < bierKegs; i++)
            {
                string kegModel = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                //double kegVolume = Math.PI * (radius * radius) * height;
                float kegVolume = (float)(Math.PI * (radius * radius) * height);

                if (kegVolume> maxVolume)
                {
                    maxVolume = kegVolume;
                    maxKeg = kegModel;
                }
            }
            Console.WriteLine(maxKeg);
        }
    }
}