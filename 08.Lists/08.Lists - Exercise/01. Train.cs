using System.Data;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input = "";

            while ((input = Console.ReadLine())!="end") 
            {
                string[] inputArguments = input.Split();

                if (inputArguments[0] == "Add")
                {
                    int passengers = int.Parse(inputArguments[1]);
                    wagons.Add(passengers);
                    //wagons.Add(int.Parse(arguments[1]));
                }
                else
                {
                    int passengers = int.Parse(inputArguments[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentWagon = wagons[i];
                        bool isItFull = currentWagon + passengers <= maxCapacity;

                        if (isItFull)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}