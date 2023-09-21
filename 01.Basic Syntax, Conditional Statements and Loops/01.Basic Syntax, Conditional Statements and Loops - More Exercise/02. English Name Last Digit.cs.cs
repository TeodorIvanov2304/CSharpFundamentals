using System;

namespace _02._English_Name_Last_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Divide();
        }
        
        static void Divide()
        {
            int integer = int.Parse(Console.ReadLine());
            
            if(integer %10 == 0) 
            {
                Console.WriteLine("zero");
            }
            else if(integer %10  == 1) 
            {
                Console.WriteLine("one");
            }
            else if (integer % 10 == 2)
            {
                Console.WriteLine("two");
            }
            else if (integer % 10 == 3)
            {
                Console.WriteLine("three");
            }
            else if (integer % 10 == 4)
            {
                Console.WriteLine("four");
            }
            else if (integer % 10 == 5)
            {
                Console.WriteLine("five");
            }
            else if (integer % 10 == 6)
            {
                Console.WriteLine("six");
            }
            else if (integer % 10 == 7)
            {
                Console.WriteLine("seven");
            }
            else if (integer % 10 == 8)
            {
                Console.WriteLine("eight");
            }
            else if (integer % 10 == 9)
            {
                Console.WriteLine("nine");
            }
        }
    }
}