using System.Numerics;

namespace _02._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will receive a number N in the range[0…1000]. Calculate the Factorial of N and print out the result.

            short n = short.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}