namespace _04._Text_Filter_Chaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                                   .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                                   .ToArray();
            string text = Console.ReadLine();

            foreach (string word in bannedWords) 
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}