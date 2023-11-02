namespace _04._Word_Filter_One_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\n", Console.ReadLine()
                                 .Split()
                                 .Where(s => s.Length % 2 == 0)
                                 .ToList()));
        }
    }
}