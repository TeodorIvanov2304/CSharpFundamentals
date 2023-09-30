using System;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ",Console.ReadLine()
                                                .Split()
                                                .Reverse()));
        }
    }
}