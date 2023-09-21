using System;
using System.Dynamic;

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 1.0F + 0.33F;
            Console.WriteLine(result); 
            //1.3300000429153442 -> загуба на точност, трябва да е 1.33. Получава се заради суфиксът F, който неправилно е сложен на double стойност, той е за float!!

            double result2 = 1.0 + 0.33;
            Console.WriteLine(result2);

            int digits = 5 % 10;
            Console.WriteLine(digits);
            // Тук работи правилно


            Console.WriteLine("Въведете символ");
            char ch = char.Parse(Console.ReadLine());

            Console.WriteLine((int)ch);

            // Конверитране на инт в Бинарен код!!!
            int number = 42;
            string bynaryString = Convert.ToString(number,2); 

            // Ако сменим 2, с 4, 8, 10,
            // или 16, се сменя системата
            // Например string bynaryString = Convert.ToString(number,16) за 16-ичен код
            Console.WriteLine(bynaryString);

        }
    }
}