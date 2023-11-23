using System.Linq;

namespace _03._P_rates
{
    internal class Program
    {
        class Town
        {
            public Town(string name, int population, int gold)
            {
                Name = name;
                Population = population;
                Gold = gold;
            }

            public string Name { get; set; }
            public int Population { get; set; }
            public int Gold { get; set; }
        }
        static void Main(string[] args)
        {
            List<Town> townsForAttack = new List<Town>();
            string goldAndPopulation = "";
            while ((goldAndPopulation = Console.ReadLine()) != "Sail")
            {
                string[] townInfo = goldAndPopulation.Split("||").ToArray();
                string townName = townInfo[0];
                int townPopulation = int.Parse(townInfo[1]);
                int townGold = int.Parse(townInfo[2]);

                //Създаваме променлива от тип Town, с която ще проверим, дали town с това име се съдържа в листа от градове за нападение
                //FirstOrDefault и после if (town != null) проверява, дали града съществува
                Town town = townsForAttack.FirstOrDefault(n=>n.Name == townName);

                if (town != null)
                {
                    town.Gold += townGold;
                    town.Population += townPopulation;
                    
                }

                else
                {
                    Town newTown = new Town(townName, townPopulation, townGold);
                    townsForAttack.Add(newTown);
                }
            }

            string commands = "";
            while ((commands = Console.ReadLine()) != "End")
            {
                string[] commandArgs = commands.Split("=>").ToArray();
                string command = commandArgs[0];
                string name = commandArgs[1];
                int gold = 0;
                int population = 0;
                //Проверяваме всеки town в townsForAttack, където името съвпада с името на града, който ще атакуваме. Накрая му казваме ToList(), защото иначе като се изтрие град и дава грешка
                foreach (Town town in townsForAttack.Where(n => n.Name == name).ToList())
                {
                    switch (command)
                    {
                        case "Plunder":

                            
                            if(town.Population>0 && town.Gold>0)
                            {
                                population = int.Parse(commandArgs[2]);
                                town.Population -= population;
                                gold = int.Parse(commandArgs[3]);
                                town.Gold -= gold;
                                Console.WriteLine($"{town.Name} plundered! {gold} gold stolen, {population} citizens killed.");
                                if (town.Population <= 0 || town.Gold <= 0)
                                {
                                    Console.WriteLine($"{town.Name} has been wiped off the map!");
                                    townsForAttack.Remove(town);
                                }
                            }
                            

                            break;
                        case "Prosper":
                            gold = int.Parse(commandArgs[2]);
                            if (gold < 0)
                            {
                                Console.WriteLine($"Gold added cannot be a negative number!");
                            }
                            else
                            {
                                town.Gold += gold;
                                Console.WriteLine($"{gold} gold added to the city treasury. {town.Name} now has {town.Gold} gold.");
                            }
                            break;
                    }

                }

            }
            if (townsForAttack.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {townsForAttack.Count} wealthy settlements to go to:");

                foreach (Town town in townsForAttack)
                {
                    Console.WriteLine($"{town.Name} -> Population: {town.Population} citizens, Gold: {town.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}