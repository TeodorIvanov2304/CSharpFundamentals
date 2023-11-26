/*
You are an astronaut who just embarked on a mission across the solar system. Since you will be in space for a long time, you have packed a lot of food with you. Create a program, which helps you identify how much food you have left and gives you information about its expiration date.
On the first line of the input, you will be given a text string. You must extract the information about the food and calculate the total calories. 
First, you must extract the food info. It will always follow the same pattern rules:
•	It will be surrounded by "|" or "#" (only one of the two) in the following pattern: 
#{item name}#{expiration date}#{calories}#   or 
|{item name}|{expiration date}|{calories}|
•	The item name will contain only lowercase and uppercase letters and whitespace.
•	The expiration date will always follow the pattern: "{day}/{month}/{year}", where the day, month, and year will be exactly two digits long.
•	The calories will be an integer between 0-10000.
Calculate the total calories of all food items and then determine how many days you can last with the food you have. Keep in mind that you need 2000kcal a day.
Input / Constraints
•	You will receive a single string.
Output
•	First, print the number of days you will be able to last with the food you have:
"You have food to last you for: {days} days!"
•	The output for each food item should look like this:
"Item: {item name}, Best before: {expiration date}, Nutrition: {calories}"
 
*/
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([#|\|]{1})(?<ItemName>[A-Za-z]+[ ]?[A-Za-z]+)\1(?<Date>[0-9]{2}/[0-9]{2}/[0-9]{2})\1(?<Calories>[0-9]{1,5})\1";

            MatchCollection foods = Regex.Matches(input, pattern);
            ulong calories = 0L;
            if (foods.Count > 0)
            {
                foreach (Match food in foods)
                {
                    string foodPatern = @"[#|\|]";
                    Match match = Regex.Match(food.Value, foodPatern);
                    if (match.Success)
                    {
                        string[] foodTokens = food.Value
                                               .Split(match.ToString(), StringSplitOptions.RemoveEmptyEntries)
                                               .ToArray();
                        ulong caloriesToAdd = ulong.Parse(foodTokens[2]);
                        calories += (ulong)caloriesToAdd;
                    }

                }
            }

            Console.WriteLine($"You have food to last you for: {calories / 2000} days!");

            if (foods.Count > 0)
            {
                foreach (Match food in foods)
                {
                    Console.WriteLine($"Item: {food.Groups["ItemName"]}, Best before: {food.Groups["Date"]}, Nutrition: {food.Groups["Calories"]}");
                }
            }


        }
    }
}