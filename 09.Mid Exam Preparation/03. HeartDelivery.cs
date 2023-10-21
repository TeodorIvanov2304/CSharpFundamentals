﻿namespace HeartDelivery
{
    class HeartDelivery
    {
        static void Main(string[] args)
        {
            // Valentine's day is coming, and Cupid has minimal time to spread some love across the neighborhood. Help him with his mission!
            //You will receive a string with even integers, separated by a "@" - this is our neighborhood. After that, a series of Jump commands will follow until you receive "Love!".Every house in the neighborhood needs a certain number of hearts delivered by Cupid so it can celebrate Valentine's day. The integers in the neighborhood indicate those needed hearts.
            //Cupid starts at the position of the first house(index 0) and must jump by a given length.The jump commands will be in this format: "Jump {length}".
            //Every time he jumps from one house to another, the needed hearts for the visited house are decreased by 2: 
            //•	If the needed hearts for a certain house become equal to 0, print on the console "Place {house_index} has Valentine's day." 
            //•	If Cupid jumps to a house where the needed hearts are already 0, print on the console "Place {house_index} already had Valentine's day."
            //•	Keep in mind that Cupid can have a larger jump length than the size of the neighborhood, and if he does jump outside of it, he should start from the first house again(index 0).
            //For example, we are given this neighborhood: 6@6@6.Cupid is at the start and jumps with a length of 2.He will end up at index 2 and decrease the needed hearts by 2: [6, 6, 4]. Next, he jumps again with a length of 2 and goes outside the neighborhood, so he goes back to the first house(index 0) and again decreases the needed hearts there: [4, 6, 4].
            //Input
            //•	On the first line, you will receive a string with even integers separated by "@" – the neighborhood and the number of hearts for each house.
            //•	On the next lines, until "Love!" is received, you will be getting jump commands in this format: "Jump {length}".
            //Output
            //In the end, print Cupid's last position and whether his mission was successful or not:
            //•	"Cupid's last position was {last_position_index}."
            //•	If each house has had Valentine's day, print: 
            //o   "Mission was successful."
            //•	If not, print the count of all houses that didn't celebrate Valentine's Day:
            //o   "Cupid has failed {houseCount} places."

            int[] neighborhood = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int lastPosition = 0;
            int houses = 0;

            while (command[0] != "Love!")
            {
                int length = int.Parse(command[1]);
                lastPosition += length;

                if (lastPosition < 0 || lastPosition >= neighborhood.Length)
                {
                    lastPosition = 0;
                }

                if (neighborhood[lastPosition] != 0)
                {
                    neighborhood[lastPosition] -= 2;

                    if (neighborhood[lastPosition] == 0)
                    {
                        houses++;
                        Console.WriteLine($"Place {lastPosition} has Valentine's day.");
                    }
                }
                else
                {
                    Console.WriteLine($"Place {lastPosition} already had Valentine's day.");
                }

                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine($"Cupid's last position was {lastPosition}.");

            if (houses == neighborhood.Length)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neighborhood.Length - houses} places.");
            }
        }
    }
}