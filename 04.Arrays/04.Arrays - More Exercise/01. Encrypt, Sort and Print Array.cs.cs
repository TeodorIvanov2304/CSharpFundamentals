using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    internal class EncryptSortPrintArray
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());

            string[] arr = new string[numberOfStrings];

            int[] currentArray = new int[numberOfStrings];

            int sum = 0;


            for (int i = 0; i < numberOfStrings; i++)
            {

                arr[i] = Console.ReadLine();

                string currentName = arr[i];

                sum = 0;

                for (int j = 0; j < currentName.Length; j++)
                {

                    char currentLetter = currentName[j];
                    int value = (int)currentLetter;
                    bool isVowel = "aeiouAEIOU".Contains(currentLetter);

                    if (isVowel)
                    
                    {
                        sum += value * currentName.Length;

                    }
                    else
                    {
                        sum += value / currentName.Length;
                    }


                }
                currentArray[i] = sum;



            }
            Array.Sort(currentArray);
            foreach (int item in currentArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}
