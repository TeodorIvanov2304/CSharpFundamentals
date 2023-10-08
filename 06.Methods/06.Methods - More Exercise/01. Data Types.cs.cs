using System.Collections.Generic;
using System.ComponentModel;

namespace _01._Data_Types
{
    internal class DataTypes
    {
        static void Main(string[] args)
        {
            //Write a program that, depending on the first line of the input, reads an int, a double or a string.
            //•	If the data type is int, multiply the number by 2.
            //•	If the data type is real, multiply the number by 1.5 and format it to the second decimal point.
            //•	If the data type is a string, surround the input with '$'.
            //Print the result on the console.
            //Try to solve the problem using only one method with different overloads.

            string type = Console.ReadLine();
            string number = Console.ReadLine();
            double result = 0;

            result = ChekType(type, number, result);
        }

        private static double ChekType(string type, string number, double result)
        {
            switch (type)
            {

                case "int":

                    result = int.Parse(number) * 2;
                    Console.WriteLine(result);
                    break;
                case "real":
                    result = double.Parse(number) * 1.5;
                    Console.WriteLine($"{result:F2}");
                    break;
                case "string":
                    string resultString = $"${number}$";
                    Console.WriteLine(resultString);
                    break;
            }

            return result;
        }

    }
}