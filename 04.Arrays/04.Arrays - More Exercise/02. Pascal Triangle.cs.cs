using System.Numerics;

namespace _02._Pascal_Triangle
{
    internal class PascalTriangle
    {
        static void Main(string[] args)
        {
            //The triangle may be constructed in the following manner: In row 0(the topmost row), there is a unique nonzero entry 1.Each entry of each subsequent row is constructed by adding the number above and to the left with the number above and to the right, treating blank entries as 0.For example, the initial number in the first(or any other) row is 1(the sum of 0 and 1), whereas the numbers 1 and 3 in the third row are added to produce the number 4 in the fourth row.
            //If you want more info about it: https://en.wikipedia.org/wiki/Pascal's_triangle
            //Print each row element separated with whitespace.

            //Четем броя редове от конзолата
            int lines = int.Parse(Console.ReadLine());
            //Създаваме пробменлива масив, която пази променливи колкото са редовете
            long[] row = new long[lines];
            //Създаввам помощна променлива, със същата големина
            long[] currentArray = new long[lines];
            //Първият ред винаги е 1
            row[0] = 1; 
            Console.WriteLine(row[0]);

            //Създавме циък, който ще върти колкото са редовете
            for (int i = 1; i < lines; i++)
            {
                //Всяка първа стойност от масива винаги е 1
                currentArray[0] = 1;
                Console.Write($"{currentArray[0]} ");
                //Създаваме цикъл, който върти до i
                for (int k = 1; k <= i; k++)
                {   
                    //Добавяме към текущият масив стойностите на к-1 и к
                    currentArray[k] = row[k - 1] + row[k];
                    Console.Write($"{currentArray[k]} ");
                }
                //Презаписваме стойностите то currentArray в row
                for (int j = 0; j < lines; j++)
                {
                    row[j] = currentArray[j];
                }
                Console.WriteLine();
            }
        }
    }
}
