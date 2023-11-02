namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                                 .Split()
                                 .Where(s => s.Length % 2 == 0)
                                 .ToList();

            Console.WriteLine(string.Join("\n", words));
        }
    }
}