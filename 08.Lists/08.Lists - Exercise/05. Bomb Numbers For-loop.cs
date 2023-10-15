namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a sequence of numbers and a special bomb number holding a certain power. Your task is to detonate every occurrence of the special bomb number and according to its power the numbers to its left and right.The bomb power refers to how many numbers to the left and right will be removed, no matter their values.Detonations are performed from left to right and all the detonated numbers disappear.Finally, print the sum of the remaining elements in the sequence.

            //Четем листа от номреа
            List<int> numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();

            //Четем числото-бомба и силата му
            int[] bombArray = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();
            //Създаваме променлива, която пази числото-бомба
            int bombNumber = bombArray[0];
            //Създаваме променлива, която пази силата на бомбата
            int bombPower = bombArray[1];

            //Създаваме for-цикъл, който върти по дължината на листа
            for (int i = 0; i < numbers.Count; i++)
            {
                //Създаваме променлива, която пази текущото число Numbers[i]
                int currentNumber = numbers[i];

                //Проверяваме, дали текущото число == числото-бомба
                if (currentNumber == bombNumber)
                {
                    //Ако е равно, определяме силата на бомбата с i+bombPower и i-bombpower
                    int startIndex = i - bombPower;
                    int endIndex = i + bombPower;

                    //Проверяваме, дали бомбата няма да гръмне извън листа :)

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }

                    //Намираме count на числата, които ще премахнем, за да гo използваме с Remove Range
                    // Трябва ни стартовия индекс, и колко числа след това трябва да се махнат(count)
                    int endIndexToRemove = endIndex - startIndex + 1;
                    //Премахваме числата около бомбата, заедно с нея
                    numbers.RemoveRange(startIndex, endIndexToRemove);

                    //С този ред си гарантираме, че след като гръмне бомбата i няма да започне да брои
                    //от несъществуващ вече индекс и да даде IndexOutOfRange Exeption
                    i = startIndex - 1;
                }
            }
            //Изпечатваме сумата на останалите числа
            Console.WriteLine(numbers.Sum());
        }
    }
}