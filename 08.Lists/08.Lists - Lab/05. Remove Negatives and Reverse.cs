using System.Xml.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order. If
            //there are no elements left in the list, print "empty".

            //Четем листа от конзолата
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            //Пускасме цикъл по дължината на листа
            for (int i = 0; i < numbers.Count; i++)
            {   
                //Ако числото е отрицателно, го премахваме от листа
                if (numbers[i] < 0)
                {
                    numbers.Remove(numbers[i]);
                    //Връщаме индекса с едно назад, защото иначе пропуска следващото число 
                    //след смаляването на листа(remove)
                    i--;
                }
            }

            //Обръщаме наобратно листа
            numbers.Reverse();

            //Ако е празен, изпечатваме "empty"
            if(numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }

            //Ако не е , изпечатваме с foreach
            else
            {
                foreach (int i in numbers)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}