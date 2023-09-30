using System;
using System.Text;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read an array of real numbers(space separated), round them in "away from 0" style and print the output as in the examples:
            //0.9 1.5 2.4 2.5 3.14
            //0.9 => 1
            //1.5 => 2
            //2.4 => 2
            //2.5 => 3
            //3.14 => 3

            // Създаваме масив array
            //                      Четем масива от конзолата,
            //                      Сплитваме го със " " 
            //                      Селектваме числата с double.Parse
            //                      cast-ваме го към масив
            double[] numbers = Console.ReadLine()
                             .Split()
                             .Select(double.Parse)
                             .ToArray();

            //Създаваме нов масив от тип int който ще пази закръглените числа
            int[] roundedNumbers = new int[numbers.Length];

            // Създаваме for-цикъл, който върти по дължината на масива
            for (int i = 0; i < numbers.Length; i++)
            {
                //Запазваме закръглените числа в новия масив roundedNumbers го закръгляме след .5 нагоре, "далече от 0"
                roundedNumbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);

                //Изпечатваме на конзолата
                Console.WriteLine($"{numbers[i]} => {roundedNumbers[i]}");
            }
        }
    }
}