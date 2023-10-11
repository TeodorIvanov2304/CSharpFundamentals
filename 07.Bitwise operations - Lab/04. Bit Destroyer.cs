using System.ComponentModel;

namespace _04._Bit_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that sets the bit at position p to 0.Print the resulting integer.

            //Четем число и позиция от конзолата
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            //Създаваме помощна променлива-маска, която ще е равна на бинарно 1, отместено с position наляво
            int mask = 1 << position;
            
            //Обръщаме знака на маската
            mask = ~mask;

            //Събираме с побитово &
            int result = number & mask;

            //Изпечатваме новото число
            Console.WriteLine(result);
        }
    }
}