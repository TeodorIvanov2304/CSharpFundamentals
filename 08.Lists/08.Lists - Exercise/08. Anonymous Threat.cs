/*
abcdef ghi jkl
divide 0 0
3:1
 
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace _08._Anonymous_Threat
{
    internal class AnonymousThreat
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = Console.ReadLine()
                                         .Split()
                                         .ToList();

            string command = "";

            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] commandArgs = command.Split().ToArray();
                string firstCommand = commandArgs[0];
                List<string> splitList = new List<string>();
                switch (firstCommand)
                {
                    case "merge":
                        int startIndex = int.Parse(commandArgs[1]);
                        int endIndex = int.Parse(commandArgs[2]);

                        if (startIndex < 0 || startIndex > listOfStrings.Count - 1)
                        {
                            startIndex = 0;
                        }
                        if (endIndex < 0 || endIndex > listOfStrings.Count - 1)
                        {
                            endIndex = listOfStrings.Count - 1;
                        }
                        int count = endIndex - startIndex;

                        while (count > 0)
                        {
                            string str = listOfStrings[startIndex + 1];
                            listOfStrings.Remove(str);
                            listOfStrings[startIndex] += str;
                            count--;
                        }
                        break;
                    case "divide":
                        int index = int.Parse(commandArgs[1]);
                        int partitions = int.Parse(commandArgs[2]);
                        
                        if (partitions > 0 && listOfStrings[index].Length % partitions == 0)
                        {
                            int step = listOfStrings[index].Length / partitions;
                            for (int i = 0; i < listOfStrings[index].Length; i += step)
                            {
                                string toAdd = listOfStrings[index].Substring(i, step);

                                splitList.Add(toAdd);
                            }

                            listOfStrings.RemoveAt(index);
                            for (int i = splitList.Count - 1; i >= 0; i--)
                            {
                                listOfStrings.Insert(index, splitList[i]);
                            }
                        }
                        else if(partitions>0 && listOfStrings[index].Length % partitions != 0)
                        {

                            int step = listOfStrings[index].Length / partitions;
                            int remninder = listOfStrings[index].Length % partitions;
                            for (int i = 0; i < listOfStrings[index].Length; i++)
                            {
                                string toAdd = "";
                                if (listOfStrings[index].Length - 1 - i == remninder)
                                {
                                    toAdd = listOfStrings[index].Substring(i);
                                    splitList.Add(toAdd);
                                }
                                else
                                {
                                    toAdd = splitList[index].Substring(i, step);
                                    splitList.Add(toAdd);
                                }

                            }

                            listOfStrings.RemoveAt(index);
                            for (int i = splitList.Count - 1; i >= 0; i--)
                            {
                                listOfStrings.Insert(index, splitList[i]);
                            }
                        }

                        
                        break;
                }


            }
            Console.WriteLine(string.Join(" ", listOfStrings));
        }
    }
}