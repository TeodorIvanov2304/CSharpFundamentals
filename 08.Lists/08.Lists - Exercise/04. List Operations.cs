using System.Diagnostics.Metrics;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The first input line will hold a list of integers. Until we receive the "End" command, we will be given operations we
            //have to apply to the list.
            //The possible commands are:
            //• Add { number} – add the given number to the end of the list
            //• Insert { number} { index} – insert the number at the given index
            //• Remove { index} – remove the number at the given index
            //• Shift left { count} – first number becomes last. This has to be repeated the specified number of times
            //• Shift right { count} – last number becomes first. To be repeated the specified number of times
            //Note: the index given may be outside of the bounds of the array. In that case print: "Invalid index".

            List<int> integerList = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            string commands = "";


            while ((commands = Console.ReadLine()) != "End")
            {
                string[] command = commands.Split();
                string firstCommand = command[0];
                int number = 0;
                int index = 0;
                switch (firstCommand)
                {
                    case "Add":
                        number = int.Parse(command[1]);
                        integerList.Add(number);
                        break;
                    case "Insert":
                        number = int.Parse(command[1]);
                        index = int.Parse(command[2]);
                        if (index > integerList.Count || index < 0)
                        {
                            Console.WriteLine("Invalid index");

                        }
                        else
                        {
                            integerList.Insert(index, number);
                        }

                        break;
                    case "Remove":
                        index = int.Parse(command[1]);
                        if (index > integerList.Count || index < 0)
                        {
                            Console.WriteLine("Invalid index");

                        }
                        else
                        {
                            integerList.RemoveAt(index);
                        }

                        break;
                    case "Shift":
                        //Местим налявао като премахваме първия елемент, и го добавяме отзад
                        if (command[1] == "left")
                        {
                            int count = int.Parse(command[2]);


                            for (int i = 0; i < count; i++)
                            {
                                int firstNumber = integerList[0];
                                integerList.RemoveAt(0);
                                integerList.Add(firstNumber);
                            }


                        }
                        //Местим надясно, като премахваме последния елемент и го добавяме отпред
                        else if (command[1] == "right")
                        {
                            int count = int.Parse(command[2]);

                            for (int i = 0; i < count; i++)
                            {
                                int lastNumber = integerList[integerList.Count - 1];
                                integerList.RemoveAt(integerList.Count - 1);
                                integerList.Insert(0, lastNumber);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", integerList));
        }
    }
}