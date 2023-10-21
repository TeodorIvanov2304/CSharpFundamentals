namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
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