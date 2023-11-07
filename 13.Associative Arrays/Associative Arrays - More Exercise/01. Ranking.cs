namespace _01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> candidates = new SortedDictionary<string, Dictionary<string, int>>();
            string inputContest = string.Empty;

            while ((inputContest = Console.ReadLine()) != "end of contests")
            {
                string[] str = inputContest.Split(':');
                string contest = str[0];
                string password = str[1];
                contests.Add(contest, password);
            }
            string inputCollection = string.Empty;
            while ((inputCollection = Console.ReadLine()) != "end of submissions")
            {
                string[] str2 = inputCollection.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = str2[0];
                string password = str2[1];
                string name = str2[2];
                int points = int.Parse(str2[3]);
                if (contests.ContainsKey(contest)
                    && contests.ContainsValue(password))
                {
                    if (candidates.ContainsKey(name) == false)
                    {
                        candidates.Add(name, new Dictionary<string, int>());
                        candidates[name].Add(contest, points);
                    }
                    if (candidates[name].ContainsKey(contest))
                    {
                        if (candidates[name][contest] < points)
                        {
                            candidates[name][contest] = points;
                        }
                    }
                    else
                    {
                        candidates[name].Add(contest, points);
                    }
                }

            }
            Dictionary<string, int> totalPoints = new Dictionary<string, int>();
            foreach (var kvp in candidates)
            {
                totalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }
            string bestName = totalPoints
                .Keys
                .Max();
            int bestPoints = totalPoints
                .Values
                .Max();

            foreach (var kvp in totalPoints)
            {
                if (kvp.Value == bestPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");

                }
            }
            Console.WriteLine("Ranking:");
            foreach (var name in candidates)
            {
                Dictionary<string, int> dict = name.Value;
                dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                Console.WriteLine("{0}", name.Key);
                foreach (var kvp in dict)
                {
                    Console.WriteLine("#  {0} -> {1}", kvp.Key, kvp.Value);
                }

            }
        }
    }
}