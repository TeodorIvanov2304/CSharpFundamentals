using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Condense_Array_to_Number_Resize_Method
{
    internal class CondenseArrayТoNumberResizeMethod
    {
        static void Main(string[] args)
        {   
            //Създаваме масив, който четем от конзолата
            int[] array = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();

            //Създаваме нов масив, който да пази събраните стойности
            int[] condensedArray = new int[array.Length - 1];

            //Създавме while цикъл, който върти до array.Length > 1
            while (array.Length > 1)
            {   
                //Създаваме for цикъл който върти до дължината - 1
                for (int i = 0; i < array.Length - 1; i++)
                {   
                    //Събираме кондензирания масив, с итерациите от масива array[i] + array[i+1]
                    condensedArray[i] = array[i] + array[i + 1];
                    array[i] = condensedArray[i];
                }
                //Използваме класът System.Array и функцията му Resize(реферираме масива, дължината на масива - 1)
                Array.Resize(ref condensedArray, condensedArray.Length - 1);
                Array.Resize(ref array, array.Length - 1);
            }

            //Създаваме foreach цикъл за да изпирнтим резултата
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}