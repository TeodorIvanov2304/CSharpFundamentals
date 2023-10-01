using System;
using System.Linq;
using System.Collections.Generic; // Включваме масивите и листовете

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
                {
                    1,2,3,4,5,6,7,8,9,10
                };
            Console.WriteLine(String.Join(", ", numbers));
            // String. Join се използва за съединяване в един стринг на всички интове на масива
            //Console.WriteLine($"{numbers} ");
            double[] floatNumbers = new double[]
            {
                2.3,2.2,44.1,44.9,5.1
            };
            Console.WriteLine(String.Join(", ", floatNumbers));
            floatNumbers[0] = 10;

            Console.WriteLine(String.Join(", ", floatNumbers));
            
            // извиква средно аритметично за числа с десет. запетая
            Console.WriteLine(floatNumbers.Average());
            
            // floatNumber.Contains(търсеното число). Показва, дали определено число се съдържа в масива
            Console.WriteLine(floatNumbers.Contains(5.1));
            
            Console.WriteLine(floatNumbers.Min()); // връща минималната стойност в масива
            Console.WriteLine(floatNumbers.Max()); // връща максималната стойност в масива
            
            // Обръща масива, но не в нов масив, а в абстрактна колекция
            Console.WriteLine(String.Join(" ", floatNumbers.Reverse())); 
            string[] words = new string[]
                {
                    "Kuche",
                    "Kotka",
                    "Papagal",
                    "Maimuna",
                    "Zmia",
                    "Govedo"
                };

            Console.WriteLine(words.Length); //Изпечатва дължината на масива
            words[5] = "Koza";
            Console.WriteLine(String.Join(", ", words));

            // чете масив от int директно от конзолата без използване на други променливи
            int[] array = Console.ReadLine()
                          .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();

            //Foreach цикъл за показване на елементите от масива
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            // Сумира елементите на масива
	    int sum = array.Sum();
        }
    }
}