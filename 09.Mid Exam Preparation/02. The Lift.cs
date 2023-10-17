using System;
using System.Collections.Generic;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds a place for the tourist on a lift.
            //Every wagon should have a maximum of 4 people on it.If a wagon is full, you should direct the people to the next one with space available.

            int groupOfPeople = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

            for (int i = 0; i < lift.Length; i++)
            {

                if (groupOfPeople == 0)
                {
                    break;
                }

                int people = 4;

                if (groupOfPeople < 4)
                {
                    people = groupOfPeople;
                }

                if (lift[i] == 4)
                {
                    continue;
                }
                if (lift[i] + people > 4)
                {
                    people = 4 - lift[i];
                }

                lift[i] += people;
                groupOfPeople -= people;
            }

            int emptySpaces = lift.Length * 4 - lift.Sum();
            if (groupOfPeople == 0 && emptySpaces >0)
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else
            {
                Console.WriteLine($"There isn't enough space! {groupOfPeople} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }


        }
    }
}