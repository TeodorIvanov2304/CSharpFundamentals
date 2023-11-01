namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Четем n числа от конзолата
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!synonyms.ContainsKey(word))
                {
                    synonyms[word] = new List<string>
                    {
                        synonym
                    };
                    //synonyms[word] = new List<string>();
                    //synonyms[word].Add(synonym);
                }
                else
                {
                    synonyms[word].Add(", " + synonym);
                }
            }

            foreach (KeyValuePair<string,List<string>> kvp in synonyms)
            {
                Console.Write($"{kvp.Key} - ");
                foreach (string value in kvp.Value)
                {
                    Console.Write($"{value}");
                }
                Console.WriteLine();
            }
        }

        
    }

    
}