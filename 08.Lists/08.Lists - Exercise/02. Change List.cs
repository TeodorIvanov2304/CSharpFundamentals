using System.Collections.Generic;
using System.Xml.Linq;
using System;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program, that reads a list of integers from the console and receives commands to manipulate the list.
            //Your program may receive the following commands:
            //• Delete { element} – delete all elements in the array, which are equal to the given element.
            //• Insert { element} { position} – insert the element at the given position.
            //You should exit the program when you receive the "end" command.Print all numbers in the array, separated by a single whitespace.

            List<int> integerList = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArguments = command.Split();

                if (commandArguments[0] == "Delete")
                {
                    int element = int.Parse(commandArguments[1]);

                    for (int i = 0; i < integerList.Count; i++)
                    {
                        if (integerList.Contains(element))
                        {
                            integerList.Remove(element);
                        }
                    }

                }
                else
                {
                    int element = int.Parse(commandArguments[1]);
                    int position = int.Parse(commandArguments[2]);
                    integerList.Insert(position, element);

                }
            }
            Console.WriteLine(string.Join(" ", integerList));
        }
    }
}