namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                             .Split()
                             .Select(x => x.ToLower())
                             .ToArray();

            Dictionary<string,int> extractedWords = new Dictionary<string,int>();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (!extractedWords.ContainsKey(currentWord))
                {
                    extractedWords[currentWord] = 1;
                }
                else
                {
                    extractedWords[currentWord]++;
                }
            }

            foreach(KeyValuePair<string,int> keyValuePair in extractedWords) 
            {
                if (keyValuePair.Value % 2 != 0) 
                {
                    Console.Write($"{keyValuePair.Key} ");
                }
            }
        }
    }
}