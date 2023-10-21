using System.ComponentModel;

namespace _03._Numbers
{
    internal class Numbers
    {
        static void Main(string[] args)
        {
            //Write a program to read a sequence of integers and find and print the top 5 numbers greater than the average value in the sequence, sorted in descending order.
            //Input
            //•	Read from the console a single line holding space - separated integers.
            //Output
            //•	Print the above - described numbers on a single line, space - separated.
            //•	If less than 5 numbers hold the property mentioned above, print less than 5 numbers.
            //•	Print "No" if no numbers hold the above property.
            //Constraints
            //•	All input numbers are integers in the range[-1 000 000 … 1 000 000]. 
            //•	The count of numbers is in the range[1…10 000].

            List<int> sequenceOfIntegers = Console.ReadLine()
                                                  .Split()
                                                  .Select(int.Parse)
                                                  .ToList();
            int average = (int)sequenceOfIntegers.Average();
            List<int> top5 = new List<int>();
            ChekIfIsBiggerThanAverage(sequenceOfIntegers, average, top5);
            top5.Sort();
            top5.Reverse();

            if (top5.Count < 1)
            {
                Console.WriteLine("No");
            }

            int index = 0;
            index = CheckForTop5Count(top5);
            PrintNumbersForLoop(top5, index);
        }

        public static void PrintNumbersForLoop(List<int> top5, int index)
        {
            for (int i = 0; i < index; i++)
            {
                Console.Write($"{top5[i]} ");
            }
        }

        public static int CheckForTop5Count(List<int> top5)
        {
            int index;
            if (top5.Count < 5)
            {
                index = top5.Count;
            }
            else
            {
                index = 5;
            }

            return index;
        }

        public static void ChekIfIsBiggerThanAverage(List<int> sequenceOfIntegers, int average, List<int> top5)
        {
            for (int i = 0; i < sequenceOfIntegers.Count; i++)
            {
                if (sequenceOfIntegers[i] > average)
                {
                    top5.Add(sequenceOfIntegers[i]);
                }
            }
        }
    }
}