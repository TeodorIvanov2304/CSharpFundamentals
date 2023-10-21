namespace _01._Counter_Strike
{
    internal class CounterStrike
    {
        static void Main(string[] args)
        {
            short energy = short.Parse(Console.ReadLine());
            byte battlesCount = 0; 
            string input = "";

            while ((input = Console.ReadLine()) != "End of battle") 
            {
                short distance = short.Parse(input);

                if (energy>=distance)
                {
                    energy -= distance;
                    battlesCount++;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesCount} won battles and {energy} energy");
                    return;
                }

                if (battlesCount % 3 == 0)
                {
                    energy += battlesCount;
                }
            }

            Console.WriteLine($"Won battles: {battlesCount}. Energy left: {energy}");
        }
    }
}