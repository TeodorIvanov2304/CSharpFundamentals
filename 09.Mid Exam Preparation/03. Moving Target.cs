using System.Collections.Generic;
using System;
using System.Reflection;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You are at a shooting gallery and you need a program that helps you keep track of moving targets.On the first line, you will receive a sequence of targets with their integer values, split by a single space. Then, you will start receiving commands for manipulating the targets until the "End" command.The commands are the following:
            //•	"Shoot {index} {power}"
            //o   Shoot the target at the index, if it exists, by reducing its value by the given power(integer value). 
            //o Remove the target, if it is shot.A target is considered shot when its value reaches 0.
            //•	"Add {index} {value}"
            //o Insert a target with the received value at the received index, if it exists.
            //o If not, print: "Invalid placement!".
            //•	"Strike {index} {radius}"
            //o Remove the target at the given index and the ones before and after it, depending on the radius.
            //o If any of the indices in the range is invalid, print: "Strike missed!" and skip this command.

            //"End"
            //o Print the sequence with targets in the following format and end the program:
            //"{target1}|{target2}…|{targetn}"

            List<int> targets = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();

            string commands = "";

            while ((commands = Console.ReadLine()) != "End")
            {
                string[] commandArgs = commands.Split().ToArray();
                string command = commandArgs[0];
                int index = int.Parse(commandArgs[1]);
                int value = int.Parse(commandArgs[2]);

                switch (command)
                {
                    case "Shoot":

                        if (CheckIndex(targets, index))
                        {   
                            //!!!
                            targets[index] -= value;
                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                        }

                        break;
                    case "Add":

                        if (CheckIndex(targets, index))
                        {
                            targets.Insert(index, value);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid placement!");
                        }
                        break;
                    case "Strike":

                        if (CheckIndex(targets, index)
                            && CheckIndex(targets, index + value)
                            && CheckIndex(targets, index - value))
                        {
                            //Надясно до радиуса
                            for (int i = 1; i <= value; i++)
                            {
                                targets.RemoveAt(index + 1);
                            }
                            targets.RemoveAt(index);

                            for (int i = 1; i <= value; i++)
                            {
                                targets.RemoveAt(index - 1);
                            }

                        }

                        else
                        {
                            Console.WriteLine($"Strike missed!");
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join("|", targets));
        }

        public static bool CheckIndex(List<int> targets, int index)
        {
            return index >= 0 && index < targets.Count;
        }
    }
}