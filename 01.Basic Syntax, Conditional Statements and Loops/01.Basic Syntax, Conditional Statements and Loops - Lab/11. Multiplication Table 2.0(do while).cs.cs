using System;

namespace _11._Multiplication_Table_2._0_do_while_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            if (times > 10)
            {
                Console.WriteLine($"{number} X {times} = {number * times}"); 
            }
            do
            {
                Console.WriteLine($"{number} X {times} = {number*times}");
                times++;
            } while (times<=10);
        }
    }
}