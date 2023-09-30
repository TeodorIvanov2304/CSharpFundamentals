using System.Numerics;
using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program to read an array of integers and condense them by summing all adjacent couples of elements until a single integer remains.
            //For example, let us say we have 3 elements - { 2, 10, 3}. We sum the first two and the second two elements and get { 2 + 10, 10 + 3} = { 12, 13}, then we sum all adjacent elements again.This results in { 12 + 13} = { 25}.

            int[] array = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();
           
            int[] condensedArray = new int[array.Length-1];

            if (array.Length == 1)
            {
                Console.WriteLine(array[0]);
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < condensedArray.Length-i; j++)
                {
                    condensedArray[j] = array[j] + array[j + 1];
                }
                array = condensedArray;
            }
            Console.WriteLine(condensedArray[0]);


        }
    }
}