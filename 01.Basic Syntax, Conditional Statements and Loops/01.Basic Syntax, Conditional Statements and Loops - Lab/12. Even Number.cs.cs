using System;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            while (true)
            {
                
                if(n%2==0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Please write an even number.");
                }    
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {Math.Abs(n)}");
        }
    }
}