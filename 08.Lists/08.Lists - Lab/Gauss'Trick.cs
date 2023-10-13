namespace _02._Gauss__Trick
{
    internal class Program
    {
        //Create a program that sums all numbers in a list in the following order:
        //first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            List<int> result = new List<int>();
            //Създаваме цикъл, който върти до средата на листа
            for (int i = 0; i < numbers.Count/2; i++)
            {   

                ///Създаваме променлива, в която ще пазим първото число
                int first = numbers[i];
                ///Създаваме променлива, в която ще пазим последното число
                int last = numbers[numbers.Count - i - 1 ];
                result.Add(first+last);

            }

            if (numbers.Count % 2 == 1)
            {
                int middleNumber = numbers.Count / 2;
                result.Add(numbers[middleNumber]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}