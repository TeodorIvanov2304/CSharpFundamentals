/*
 You have now returned from your world tour. On your way, you have discovered some new plants, and you want to gather some information about them and create an exhibition to see which plant is highest rated.
On the first line, you will receive a number n. On the next n lines, you will be given some information about the plants that you have discovered in the format: "{plant}<->{rarity}". Store that information because you will need it later. If you receive a plant more than once, update its rarity.
After that, until you receive the command "Exhibition", you will be given some of these commands:
•	"Rate: {plant} - {rating}" – add the given rating to the plant (store all ratings)
•	"Update: {plant} - {new_rarity}" – update the rarity of the plant with the new one
•	"Reset: {plant}" – remove all the ratings of the given plant
Note: If any given plant name is invalid, print "error"
After the command "Exhibition", print the information that you have about the plants in the following format:
"Plants for the exhibition:
- {plant_name1}; Rarity: {rarity}; Rating: {average_rating}
- {plant_name2}; Rarity: {rarity}; Rating: {average_rating}
…
- {plant_nameN}; Rarity: {rarity}; Rating: {average_rating}"
The average rating should be formatted to the second decimal place.

*/
using System;
using System.Collections.Generic;
using System.Linq;

class Plant
{
    public Plant(string name, int rarity)
    {
        Name = name;
        Rarity = rarity;
        Ratings = new List<double>();
    }

    public string Name { get; set; }
    public int Rarity { get; set; }
    public List<double> Ratings { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Plant> plants = new List<Plant>();
        int numberOfPlants = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPlants; i++)
        {
            string[] plantInfo = Console.ReadLine().Split("<->");
            string plantName = plantInfo[0];
            int rarity = int.Parse(plantInfo[1]);

            Plant existingPlant = plants.FirstOrDefault(p => p.Name == plantName);

            if (existingPlant != null)
            {
                existingPlant.Rarity = rarity;
            }
            else
            {
                Plant newPlant = new Plant(plantName, rarity);
                plants.Add(newPlant);
            }
        }

        string input;
        while ((input = Console.ReadLine()) != "Exhibition")
        {
            string[] command = input.Split(": ");
            string[] commandArgs = command[1].Split(" - ");
            string action = command[0];
            string plantName = commandArgs[0];

            Plant plant = plants.FirstOrDefault(p => p.Name == plantName);
            if (plant == null)
            {
                Console.WriteLine("error");
                continue;
            }

            switch (action)
            {
                case "Rate":
                    double rating = double.Parse(commandArgs[1]);
                    plant.Ratings.Add(rating);
                    break;
                case "Update":
                    int newRarity = int.Parse(commandArgs[1]);
                    plant.Rarity = newRarity;
                    break;
                case "Reset":
                    plant.Ratings.Clear();
                    break;
            }
        }

        Console.WriteLine("Plants for the exhibition:");
        foreach (Plant plant in plants)
        {   
            //Правим допълнителна променлиав, която ще смята average на рейтингите, и ако бр. на рейтингите е 0, средният рейтинг също ще е 0
            double averageRating = plant.Ratings.Count > 0 ? plant.Ratings.Average() : 0;
            Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {averageRating:F2}");
        }
    }
}