using System.Collections.Generic;
using System;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a list of integers.Then until you receive "end", you will receive different commands:
            //• Add { number}: add a number to the end of the list.
            //• Remove { number}: remove a number from the list.
            //• RemoveAt { index}: remove a number at a given index.
            //• Insert { number} { index}: insert a number at a given index.
            //Note: All the indices will be valid!
            //When you receive the "end" command, print the final state of the list(separated by spaces).

            //Четем листа от конзолата
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            //Създаваме празна променлива, която ще отговаря за командите
            string line = string.Empty;

            //Създаваме цикъл, който приема команди до "end"
            while ((line = Console.ReadLine()) != "end")
            {   
                //Създаваме масив, който ще пази командата, разделена на части
                string[] lineTokens = line.Split().ToArray();
                //Взимаме първата команда, която е стринг
                string command = lineTokens[0];
                //Взимаме втората команда и я парсваме към новата променлива number 
                int number = int.Parse(lineTokens[1]);

                //Създаваме switch, който ще върти командите
                switch (command) 
                {
                    
                    case "Add":
                        numbers.Add(number);
                        break;
                    case "Insert":
                        //Създавме променлива индекс, която взима второто чосло от командата
                        int index = int.Parse(lineTokens[2]);
                        numbers.Insert(index, number);
                        break;
                    case "Remove":
                        numbers.Remove(number);
                        break;
                        //В случая с RemoveAt number играе индекс
                    case "RemoveAt":
                        numbers.RemoveAt(number);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}