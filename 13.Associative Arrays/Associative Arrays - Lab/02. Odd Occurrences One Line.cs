namespace _02._Odd_Occurrences_One_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine()
                                                .Split()
                                                .Select(x=>x.ToLower())
                                                .GroupBy(x=>x)
                                                .Where(x=>x.Count() % 2 == 1)
                                                .SelectMany(x=>x)
                                                .Distinct()
                                                .ToList()));
        }
    }
}