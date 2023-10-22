namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte cities = sbyte.Parse(Console.ReadLine());
            double totalProfit = 0;
            for (int i = 1; i <= cities; i++)
            {
                string cityName = Console.ReadLine();
                float income = float.Parse(Console.ReadLine());
                float expenses = float.Parse(Console.ReadLine());

                if (i % 3 == 0 && i % 5 != 0)
                {
                    expenses = expenses * 1.50f;
                }
                if (i % 5 == 0)
                {
                    income = income * 0.90f;
                }
                totalProfit += income - expenses;

                Console.WriteLine($"In {cityName} Burger Bus earned {income-expenses:F2} leva.");
            }
            Console.WriteLine($"Burger Bus total profit: {totalProfit:F2} leva.");
        }
    }
}