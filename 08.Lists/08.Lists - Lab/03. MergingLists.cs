using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You are going to receive two lists of numbers.Create a list that contains the numbers from both of the lists. The
            //first element should be from the first list, the second from the second list, and so on.If the length of the two lists is
            //not equal, just add the remaining elements at the end of the list.
            

            //Четем двата листа от конзолата
            List<int> firstList = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToList();

            List<int> secondList = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToList();
            //Създаваме празен лист който ще пази резултата от слетите листове
            List<int> result = new List<int>();

            //Създаваме променлива, която сравнява дължината на двата листа
            //за да намери по-големият. После променливата ще служи за да знае докъде
            //да върти for-цикъла
            int iterations = Math.Max(firstList.Count, secondList.Count);

            //Създаваме for-цикъла
            for (int i = 0; i < iterations; i++)
            {   

                //Проверяваме, дали някой от листовете е свършил. Ако е, пълним резултата само с останалия лист
                if(i<firstList.Count)
                {
                    result.Add(firstList[i]);
                }

                if (i < secondList.Count)
                {
                    result.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}