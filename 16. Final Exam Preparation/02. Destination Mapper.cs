﻿/*
 Now that you have planned out your tour, you are ready to go! Your next task is to mark all the points on the map that you are going to visit.
You will be given a string representing some places on the map. You have to filter only the valid ones. A valid location is:
•	Surrounded by "=" or "/" on both sides (the first and the last symbols must match)
•	After the first "=" or "/" there should be only letters (the first must be upper-case, other letters could be upper or lower-case)
•	The letters must be at least 3
Example: In the string "=Hawai=/Cyprus/=Invalid/invalid==i5valid=/I5valid/=i=" only the first two locations are valid.
After you have matched all the valid locations, you have to calculate travel points. They are calculated by summing the lengths of all the valid destinations that you have found on the map. 
In the end, on the first line, print: "Destinations: {destinations joined by ', '}". 
On the second line, print "Travel Points: {travel_points}".
Input / Constraints
•	You will receive a string representing the locations on the map.
•	JavaScript: you will receive a single parameter: string.

*/
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([=|/]{1})(?<Destination>[A-Z][A-Za-z]{2,})\1";
            string places = Console.ReadLine();

            MatchCollection matches = Regex.Matches(places, pattern);


            int travelPoints = 0;
            StringBuilder travelBuilder = new StringBuilder();
            foreach (Match match in matches) 
            {
                travelPoints += match.Groups["Destination"].Length;
                string destination = match.Groups["Destination"].Value;
                travelBuilder.Append(destination + ", ");

            }

            if (travelBuilder.Length > 0)
            {
                // Премахване на последната запетая и интервала след нея
                travelBuilder.Length -= 2; 
            }

            Console.WriteLine($"Destinations: {travelBuilder}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}