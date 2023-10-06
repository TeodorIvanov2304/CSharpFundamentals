namespace _01._Smallest_of_Three_Numbers
{
    internal class SmallestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());

            int smallestInteger = 0;
            smallestInteger = IntegersCompare(firstInteger, secondInteger, thirdInteger, smallestInteger);
            PrintSmallest(smallestInteger);
        }

        static void PrintSmallest(int smallestInteger)
        {
            Console.WriteLine(smallestInteger);
        }

        static int IntegersCompare(int firstInteger, int secondInteger, int thirdInteger, int smallestInteger)
        {
            if (firstInteger <= secondInteger && firstInteger <= thirdInteger)
            {
                smallestInteger = firstInteger;
            }
            else if (secondInteger <= thirdInteger && secondInteger <= firstInteger)
            {
                smallestInteger = secondInteger;
            }
            else if (thirdInteger <= firstInteger && thirdInteger <= secondInteger)
            {
                smallestInteger = thirdInteger;
            }

            return smallestInteger;
        }
    }
}