using System;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will be given a string that will contain words separated by a single space. Randomize their order and print each word on a new line.

            string[] arrayOfWords = Console.ReadLine()
                                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                           .ToArray();
            //Създаваме random обект от клас Random
            Random random = new Random();
            //Създаваме цикъл, който ще върти по цялата дължина на масива от думи
            for (int i = 0; i < arrayOfWords.Length; i++)
            {
                //Създаваме променлива, която ще пази генерираният random индекс
                //Той ще е различен всяка интерация на цикъла
                int index = random.Next(0, arrayOfWords.Length);
                //Създаваме помощна променлива, която ще пази текущата дума от i
                string word = arrayOfWords[i];
                //Сменяме текущата дума с думата на създаденият random индекс
                arrayOfWords[i] = arrayOfWords[index];
                //Сменяме думата на random index с текущата дума
                arrayOfWords[index] = word;

            }
            
            //Изпечатваме с foreach
            foreach (string word in arrayOfWords) 
            {
                Console.WriteLine(word);
            }
        }
    }
}