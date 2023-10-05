namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A single integer is given, create a method that checks if the given number is positive, negative, or zero. As a result print:
            //• For positive number: "The number {number} is positive. "
            //• For negative number: "The number {number} is negative. "
            //• For zero number: "The number {number} is zero. "

            int numberForChecking = int.Parse(Console.ReadLine());
            PrintNumberSign(numberForChecking);

        }

        private static void PrintNumberSign(int numberForChecking) //Cheking number sign
        {
            if (numberForChecking > 0) // Positive
            {
                Console.WriteLine($"The number {numberForChecking} is positive. ");
            }
            else if (numberForChecking < 0)  // Negative
            {
                Console.WriteLine($"The number {numberForChecking} is negative. ");
            }
            else // Zero
            {
                Console.WriteLine($"The number {numberForChecking} is zero. ");
            }
        }

    }
}