namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You are given an input of two values of the same type. The values can be of type int, char or string.Create methods called GetMax(), which can compare int, char or string and returns the biggest of the two values.

            string type = Console.ReadLine();

            // Правим проверка за string type
            if(type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = GetMax(a, b); // Method calling
                Console.WriteLine(result);

            }
            else if(type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char result = GetMax(a, b); // Method calling
                Console.WriteLine(result);

            }
            else if(type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string result = GetMax(a, b); // Method calling
                Console.WriteLine(result);

            }
        }

        
        // ================================ METHOD OVERLOADS ===============================================
        static int GetMax(int a, int b) // Проверява дали числото а > b int
        {
            return a > b ? a : b;
        }

        static char GetMax(char a, char b) //Проверява дали символът е > от другия символ по ASCII char
        {
            return a > b ? a : b;
        }

        static string GetMax(string a, string b) // Проверява дали string а > b string
        {
            return a.Equals(b) ? a : b;
        }
        //==================================================================================================
    }
}