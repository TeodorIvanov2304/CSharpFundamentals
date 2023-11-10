namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                 .ToArray();
            string text  = Console.ReadLine();

            foreach (string word in bannedWords) 
            {
                string newWord = "";
                
                for (int i = 0; i < word.Length; i++)
                {
                    newWord += "*";
                }
                while (text.Contains(word)) 
                {

                    text = text.Replace(word,newWord);
                }
            }
            Console.WriteLine(text);

        }
    }
}