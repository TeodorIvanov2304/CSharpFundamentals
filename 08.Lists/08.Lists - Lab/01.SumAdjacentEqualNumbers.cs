namespace Lists___Lab
{
    internal class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            //Create a program to sum all of the adjacent equal numbers in a list of decimal numbers, starting from left to right.
            //• After two numbers are summed, the result could be equal to some of its neighbors and should be summed
            //as well (see the examples below)
            //• Always sum the leftmost two equal neighbors(if several couples of equal neighbors are available)

            //Четем лист от конзолата
            List<double> numbers = Console.ReadLine()
                                    .Split()
                                    .Select(double.Parse)
                                    .ToList();

            //Създаваме for-цикъл, който върти до предпоследното число от листа 
            for (int i = 0; i < numbers.Count-1; i++)
            {   
                //Ако две последователни числа са равни ги събираме
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    //Премахваме второто число, което е еднакво с RemoveAt(index)
                    numbers.RemoveAt(i + 1);
                    //Презаписваме i на -1, за да не излезнем от масива/ Рестартираме цикъла
                    i = -1;
                }
            }
            //Изпечатваме с foreach
            foreach (double number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
}
}