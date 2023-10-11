namespace _01._Binary_Digits_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You are given a positive integer number and one binary digit B(0 or 1). Your task is to write a program that finds the number of binary digits(B) in a given integer.

            //Четем числото
            int number = int.Parse(Console.ReadLine());
            //Четем бинарно число
            int binaryNumber = int.Parse(Console.ReadLine());
            //Създаваме брояч за бинарните числа
            int count = 0;

            //Създавме while-цикъл, който ще върти докато числото е 0
            while (number>0)
            {   
                //Създаваме променлива, която пази остатъка от делението на 2
                int remainder = number % 2;
                //Делим числото на 2
                number /= 2;

                //Ако остатъкът е == на търсеното бинарно чилсло, добавяме към брояча
                if (remainder == binaryNumber)
                {
                    count++;
                }
            }
            //Изпечатваме на конзолата
            Console.WriteLine(count);

        }
    }
}