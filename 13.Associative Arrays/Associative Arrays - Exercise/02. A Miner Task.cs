namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            
            Dictionary<string,int> resources = new Dictionary<string, int>();
            string resource = "";
            while ((resource = Console.ReadLine()) != "stop") 
            {   

                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = quantity;
                }
                else
                {
                    resources[resource] += quantity;
                }

            }

            foreach(KeyValuePair<string, int> kvp in resources) 
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}