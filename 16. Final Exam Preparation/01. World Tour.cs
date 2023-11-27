﻿/*
 You are a world traveler, and your next goal is to make a world tour. To do that, you have to plan out everything first. To start with, you would like to plan out all of your stops where you will have a break.
On the first line, you will be given a string containing all of your stops. Until you receive the command "Travel", you will be given some commands to manipulate that initial string. The commands can be:
•	"Add Stop:{index}:{string}":
o	Insert the given string at that index only if the index is valid.
•	"Remove Stop:{start_index}:{end_index}":
o	Remove the elements of the string from the starting index to the end index (inclusive) if both indices are valid.
•	"Switch:{old_string}:{new_string}":
o	If the old string is in the initial string, replace it with the new one (all occurrences).
Note: After each command, print the current state of the string!
After the "Travel" command, print the following: "Ready for world tour! Planned stops: {string}".
Input / Constraints
•	JavaScript: you will receive a list of strings.
•	An index is valid if it is between the first and the last element index (inclusive) (0 ….. Nth) in the sequence.
Output
•	Print the proper output messages in the proper cases as described in the problem description.

*/
namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string allStops = Console.ReadLine();
            string commands = "";
            while ((commands = Console.ReadLine()) != "Travel")
            {
                string[] commandArgs = commands.Split(":").ToArray();
                string command = commandArgs[0];
                switch (command)
                {
                    case "Add Stop":
                        int index = int.Parse(commandArgs[1]);
                        string stopToAdd = commandArgs[2];

                        if (index > -1 && index < allStops.Length)
                        {
                            allStops = allStops.Insert(index, stopToAdd);
                        }

                        Console.WriteLine(allStops);

                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(commandArgs[1]);
                        int endIndex = int.Parse(commandArgs[2]);

                        if (startIndex > -1 && startIndex < allStops.Length && endIndex > -1 && endIndex < allStops.Length)
                        {
                            allStops = allStops.Remove(startIndex, endIndex - startIndex + 1);

                        }
                        Console.WriteLine(allStops);
                        break;
                    case "Switch":
                        string oldString = commandArgs[1];
                        string newString = commandArgs[2];

                        if (allStops.Contains(oldString))
                        {
                            allStops = allStops.Replace(oldString, newString);

                        }
                        Console.WriteLine(allStops);
                        break;
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {allStops}");
        }
    }
}