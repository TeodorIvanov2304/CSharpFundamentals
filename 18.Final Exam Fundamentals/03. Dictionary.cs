namespace _03._Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            string[] inputArgs = input.Split(" | ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (string arg in inputArgs) 
            {
                string[] wordAndDef = arg.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string word = wordAndDef[0];
                string definition = wordAndDef[1];

                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, new List<string>());
                    dictionary[word].Add(definition);
                }
                else
                {
                    dictionary[word].Add(definition);
                }
            }

            string[] onlyWords = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string command = Console.ReadLine();

            if (command == "Test")
            {
                foreach (string word in onlyWords)
                {
                    if (dictionary.ContainsKey(word))
                    {
                        Console.WriteLine($"{word}:");
                        foreach (string definition in dictionary[word]) 
                        {
                            Console.WriteLine($" -{definition}");
                        }
                    }
                }
            }
            else
            {
                foreach(var kvp in dictionary)
                {
                    Console.Write($"{kvp.Key} ");
                }
            }
            
            
        }
    }
}