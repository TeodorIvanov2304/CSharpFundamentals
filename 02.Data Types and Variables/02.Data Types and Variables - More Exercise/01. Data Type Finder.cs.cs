using Microsoft.VisualBasic;
using System;

namespace _01._Data_Type_Finder
{
    internal class DataTypeFinder
    {
        static void Main(string[] args)
        {
            //You will receive input until you receive "END".Find what data type is the input. Possible data types are:
            //• Integer
            //• Floating point
            //• Characters
            //• Boolean
            //• Strings
            //Print the result in the following format: "{input} is {data type} type".

            string input = Console.ReadLine();

            while (input!="END")
            {
                int number;
                float floatingNumber;
                char ch;
                string str;
                string dataType = "";
                bool isBool = false;

                // We are using TryParse(name of the parsed variable, OUT wanted type) to detect what type is the input
                if(int.TryParse(input, out number))
                {
                    dataType = "integer";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if(float.TryParse(input, out floatingNumber))
                {
                    dataType="floating point";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if(char.TryParse(input,out ch))
                {
                    dataType = "character";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if(bool.TryParse(input, out isBool))
                {
                    dataType = "boolean";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else
                {
                    dataType = "string";
                    Console.WriteLine($"{input} is {dataType} type");
                }

                input = Console.ReadLine();
            }
        }
    }
}