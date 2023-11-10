using System.Security;

namespace _01._Reverse_Strings_Reverse_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string input = "";
            //Създаваме нова променлива от тип речник, в който ще пазим стринг и объртнат стринг
            Dictionary<string, string> strings = new Dictionary<string, string>();
            
            //Създавме цикъл, който върти докато получим end
            while ((input = Console.ReadLine()) != "end") 
            {   
                //Създаваме променлива, която да пази текущия стринг
                string currentString = input;
                //Създавме char[], който ще пази обърнатият стринг като последователност от char
                char[] reversed = input.Reverse().ToArray();
                //Създаваме нова стринг променлива, в която ще пазим обърнатият масив от char, вече като дума. Ако опиташ с обърнатата дума , input.Reverse, няма да стане. Трябва да се обърне char по char, и после да се запише на нов стринг!!
                string result = new string(reversed);

                strings.Add(currentString, result);
            }

            foreach (KeyValuePair<string, string> kvp in strings) 
            {
                Console.WriteLine($"{kvp.Key} = {kvp.Value}");
            }
        }
    }
}