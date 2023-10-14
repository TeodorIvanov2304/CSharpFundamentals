namespace _01._Train
{
    internal class Train
    {
        static void Main(string[] args)
        {

            //On the first line, we will receive a list of wagons (integers). Each integer represents the number of passengers that are currently in each wagon of the passenger train. On the next line, you will receive the max capacity of a wagon, represented as a single integer. Until you receive the "end" command, you will be receiving two types of input:
            //• Add { passengers} – add a wagon to the end of the train with the given number of passengers.
            //• { passengers} – find a single wagon to fit all the incoming passengers(starting from the first wagon).
            //In the end, print the final state of the train(all the wagons separated by a space).


            //Четем вагоните от конзолата
            List<int> wagons = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();


            //Четем максималния капацитет на всеки вагон
            int maxCapacity = int.Parse(Console.ReadLine());

            
            string input = "";

            //Пускаме while-цикъл, който върти докато input === end
            while ((input = Console.ReadLine()) != "end")
            {   
                //Създаваме стринг масив, в който ще разделим командите на части, ако е нужно
                string[] inputArguments = input.Split();

                //Ако командата е add, добавяме цял вагон най-отзад
                if (inputArguments[0] == "Add")
                {
                    int passengers = int.Parse(inputArguments[1]);
                    wagons.Add(passengers);
                    //wagons.Add(int.Parse(arguments[1]));
                }
                else
                {   

                    //Ако не е add, търсим в кой от вагоните има място, да добавим въпросния брой пътници
                    int passengers = int.Parse(inputArguments[0]);

                    //Създаваме for-цикъл, който върти по дължината на wagons
                    for (int i = 0; i < wagons.Count; i++)
                    {   
                        //Създаване променлива, която пази хората в текущия вагон
                        int currentWagon = wagons[i];
                        //Създаваме булева променлива, която е истина ако във вагона има място да се добавят пътниците
                        bool isItFull = currentWagon + passengers <= maxCapacity;

                        //Ако има място, добавяме пътниците
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