namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reading three variables to compare
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            //Printing the smallest variable
            Console.WriteLine(CompareVariables(first, second, third));
        }

        public static int CompareVariables(int first, int second, int third)
        {
            //Comparing the 3 variables with double Math.Min Method
            int result = Math.Min(first, Math.Min(second, third));
            return result;
        }
    }
}