namespace _03._Word_Synonyms_Second_Variant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<string,string> ();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synoym = Console.ReadLine();

                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = synoym;
                }
                else
                {
                    dictionary[word] += ", " + synoym;
                }
            }

            foreach (KeyValuePair<string,string>kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}