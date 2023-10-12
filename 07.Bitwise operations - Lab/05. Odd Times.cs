namespace _05._Odd_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            //Четем от конзолата масив от числа
            int[] array = Console.ReadLine()
                         .Split()
                         .Select(int.Parse)
                         .ToArray();

            //Създаваме помощна променлива 
            int result = 0;
            //Създаваме For-цикъл, който върти по дължината на масива
            for (int i = 0; i < array.Length; i++)
            {
                //Правим ^ XOR на всяко от числата на масива. Така се унищожават, числата които са еднакви на брой.
                result = result ^ array[i];
            }
            Console.WriteLine(result);

        }
    }
}