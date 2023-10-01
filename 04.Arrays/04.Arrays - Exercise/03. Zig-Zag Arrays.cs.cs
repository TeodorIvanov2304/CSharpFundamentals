using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;
using System;

namespace _03._Zig_Zag_Arrays
{
    internal class ZigZagArrays
    {
        static void Main(string[] args)
        {
            //Create a program that creates 2 arrays.You will be given an integer n.On the next n lines, you will get 2 integers.Form 2 new arrays in a zig-zag pattern as shown below.
            //Examples
            //Input   Output
            //4       1 10 31 20
            //1 5     5 9 81 41
            //9 10
            //31 81
            //41 20

            //Четем n редове от конзолата
            int n = int.Parse(Console.ReadLine());

            //Създаване два масива с дължина n
            int[] zigZagOne = new int[n];
            int[] zigZagTwo = new int[n];

            //Създаваме цикъл, който върти n пъти
            for (int i = 0; i < n; i++)
            {   
                //Създаваме string масив , който четем от конзолата и сплитваме по " ".
                string[] input = Console.ReadLine().Split();

                //Правим проверка дали реда на четене от конзолата е четен или не
                if(i%2==0)
                {   
                    //Ако да, прибавяме първият елемент [0] към втория масив. Ако не, прибавяме първият елемент [0] към първият масив и обратно
                    zigZagOne[i] += int.Parse(input[0]);
                    zigZagTwo[i] += int.Parse(input[1]);
                }
                else
                {
                    zigZagOne[i] += int.Parse(input[1]);
                    zigZagTwo[i] += int.Parse(input[0]);
                }
            }
            //Изпечатваме на конзолата
            Console.WriteLine(string.Join(" ", zigZagOne));
            Console.WriteLine(string.Join(" ", zigZagTwo));

        }
    }
}