namespace _01._Train_Sum_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A train has n number of wagons(integer, received as input).On the next n lines, you will receive the number of people that are going to get on each wagon. Print out the number of passengers in each wagon followed by the total number of passengers on the train.

            int wagons = int.Parse(Console.ReadLine());
            int[] peopleInWagon = new int[wagons];
            for (int i = 0; i < wagons; i++)
            {
                peopleInWagon[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(String.Join(" ", peopleInWagon));
            int sum = peopleInWagon.Sum();
            Console.WriteLine(sum);
        }
    }
}