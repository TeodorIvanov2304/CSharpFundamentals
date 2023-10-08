namespace _08._Factorial_Division_FOR_LOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            //След като направим задачата, унищожаваме тези променливи
            //double firstFactorial = FindFactorial(first);
            //double secondFactorial = FindFactorial(second);

            Console.WriteLine($"{FindFactorial(first) / FindFactorial(second):F2}");
        }

        private static double FindFactorial(int number)
        {
            double firstFactorial = 1;
            for (int i = 1; i <= number; i++)
            {
                firstFactorial *= i;
            }

            return firstFactorial;
        }
    }
}