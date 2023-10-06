namespace _05._Add_and_Subtract
{
    internal class AddAndSubtract
    {
        static void Main(string[] args)
        {
            //You will receive 3 integers.Create a method that returns
            //the sum of the first two integers and another method that subtracts
            //the third integer from the result of the sum method.

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int addedNumbers = AddNumbers(firstNumber, secondNumber);

            Console.WriteLine(SubstractNumbers(thirdNumber, addedNumbers));
        }

        public static int SubstractNumbers(int thirdNumber, int afterAdd)
        {
            int finalSum = afterAdd - thirdNumber;
            return finalSum;
        }

        public static int AddNumbers(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }
    }
}