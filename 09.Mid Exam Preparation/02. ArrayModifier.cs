/*
You are given an array with integers. Write a program to modify the elements after receiving the following commands:
•	"swap {index1} {index2}" takes two elements and swap their places.
•	"multiply {index1} {index2}" takes element at the 1st index and multiply it with the element at 2nd index. Save the product at the 1st index.
•	"decrease" decreases all elements in the array with 1.
Input
On the first input line, you will be given the initial array values separated by a single space.
On the next lines, you will receive commands until you receive the command "end". The commands are as follows: 
•	"swap {index1} {index2}"
•	"multiply {index1} {index2}"
•	"decrease"

*/
namespace _02._Array_Modifier
{
    internal class ArrayModifier
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToArray();
            string commands = "";

            while ((commands = Console.ReadLine()) != "end")
            {
                string[] commandsArgs = commands.Split().ToArray();
                string command = commandsArgs[0];
                
              
                switch (command)
                {
                    case "swap":
                        int index1 = int.Parse(commandsArgs[1]);
                        int index2 = int.Parse(commandsArgs[2]);
                        int temp = arrayOfInts[index1];
                        arrayOfInts[index1] = arrayOfInts[index2];
                        arrayOfInts[index2] = temp;
                        break;
                    case "multiply":
                        index1 = int.Parse(commandsArgs[1]);
                        index2 = int.Parse(commandsArgs[2]);
                        arrayOfInts[index1] = arrayOfInts[index1] * arrayOfInts[index2];
                        break;
                    case "decrease":
                        for (int i = 0; i < arrayOfInts.Length; i++)
                        {
                            arrayOfInts[i] -= 1;
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", arrayOfInts));
        }
    }
}