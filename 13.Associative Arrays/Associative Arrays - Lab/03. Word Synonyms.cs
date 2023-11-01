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
                    //Ако не напишеш new List, няма да работи
                    synonyms[word] = new List<string>
                    {
                        synonym
                    };
                    //synonyms[word] = new List<string>();
                    //synonyms[word].Add(synonym);
                }
                else
                {
                    synonyms[word].Add(synonym);
                }
            }

            //Със string.Join можем да изпечатама всички стойноти срещу ключа, ако са повече от 1
            foreach (KeyValuePair<string,List<string>> kvp in synonyms)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ",kvp.Value)}");
            }
        }

        
    }

    
}