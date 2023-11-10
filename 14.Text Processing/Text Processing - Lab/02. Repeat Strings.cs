namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                             .ToArray();
            string allWords = "";
            foreach (string word in words) 
            {
                
                int repeats = word.Length;
                for (int i = 0; i < repeats; i++)
                {
                    allWords += word;
                }
            }
            Console.WriteLine(allWords);
        }
    }
}