namespace _08._Math_Power
{
    internal class MathPowerMethod
    {
        static void Main(string[] args)
        {
            // Create a method, which receives two numbers as parameters:
            //• The first number – the base
            //• The second number – the power
            //The method should return the base raised to the given power.


            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = RaiseToPower(number, power);
            Console.WriteLine(result);

        }

        static double RaiseToPower(double number, double power)
        {
            double result = 0d;
            result = Math.Pow(number, power);
            return result;
        }
    }
}