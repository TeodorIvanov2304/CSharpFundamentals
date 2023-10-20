using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System;

namespace _03._Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The pirates encounter a huge Man-O - War at sea. 
            //Create a program that tracks the battle and either chooses a winner or prints a stalemate. On the first line, you will receive the status of the pirate ship, which is a string representing integer sections separated by ">".On the second line, you will receive the same type of status, but for the warship: 
            //"{section1}>{section2}>{section3}… {sectionn}"
            //On the third line, you will receive the maximum health capacity a section of the ship can reach.
            //The following lines represent commands until "Retire":
            //•	"Fire {index} {damage}" - the pirate ship attacks the warship with the given damage at that section.Check if the index is valid and if not, skip the command.If the section breaks(health <= 0) the warship sinks, print the following and stop the program: "You won! The enemy ship has sunken."
            //•	"Defend {startIndex} {endIndex} {damage}" - the warship attacks the pirate ship with the given damage at that range(indexes are inclusive). Check if both indexes are valid and if not, skip the command.If the section breaks(health <= 0) the pirate ship sinks, print the following and stop the program:
            //"You lost! The pirate ship has sunken."
            //•	"Repair {index} {health}" - the crew repairs a section of the pirate ship with the given health. Check if the index is valid and if not, skip the command.The health of the section cannot exceed the maximum health capacity.
            //•	"Status" - prints the count of all sections of the pirate ship that need repair soon, which are all sections that are lower than 20 % of the maximum health capacity. Print the following: "{count} sections need repair."
            //In the end, if a stalemate occurs, print the status of both ships, which is the sum of their individual sections, in the following format:
            //"Pirate ship status: {pirateShipSum}
            //Warship status: { warshipSum}

            List<int> pirateShip = Console.ReadLine()
                                          .Split(">")
                                          .Select(int.Parse)
                                          .ToList();
            List<int> warShip = Console.ReadLine()
                                          .Split(">")
                                          .Select(int.Parse)
                                          .ToList();
            sbyte maxHealthCapacity = sbyte.Parse(Console.ReadLine());
            string commands = "";

            while ((commands = Console.ReadLine()) != "Retire")
            {
                string[] commandArguments = commands.Split().ToArray();
                string command = commandArguments[0];
                int damage = 0;
                int index = 0;
                switch (command)
                {
                    case "Fire":
                        index = int.Parse(commandArguments[1]);
                        damage = int.Parse(commandArguments[2]);

                        if (IsValidIndex(warShip, index))
                        {
                            warShip[index] -= damage;
                            if (warShip[index] <= 0)
                            {
                                Console.WriteLine("You won! The enemy ship has sunken.");
                                return;
                            }
                        }
                        break;
                    case "Defend":
                        int startIndex = int.Parse(commandArguments[1]);
                        int endIndex = int.Parse(commandArguments[2]);
                        damage = int.Parse(commandArguments[3]);
                        if (IsValidIndex(pirateShip, startIndex) && IsValidIndex(pirateShip, endIndex))
                        {
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                pirateShip[i] -= damage;
                                if (pirateShip[i] <= 0)
                                {
                                    Console.WriteLine("You lost! The pirate ship has sunken.");
                                    return;
                                }
                            }
                        }
                        break;
                    case "Repair":
                        index = int.Parse(commandArguments[1]);
                        int healh = int.Parse(commandArguments[2]);
                        if (IsValidIndex(pirateShip, index))
                        {
                            pirateShip[index] += healh;
                            if (pirateShip[index] > maxHealthCapacity)
                            {
                                pirateShip[index] = maxHealthCapacity;
                            }
                        }
                        break;
                    case "Status":
                        double percetage = maxHealthCapacity * 0.20;
                        int repairCount = 0;

                        for (int i = 0; i < pirateShip.Count; i++)
                        {
                            if (pirateShip[i] < percetage)
                            {
                                repairCount++;
                            }
                        }
                        Console.WriteLine($"{repairCount} sections need repair.");
                        break;
                }
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");

        }

        static bool IsValidIndex(List<int> warShip, int index)
        {
            return index >= 0 && index < warShip.Count;
        }
    }
}