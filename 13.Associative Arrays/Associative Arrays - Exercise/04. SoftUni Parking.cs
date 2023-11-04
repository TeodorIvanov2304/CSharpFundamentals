namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> database = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string commands = Console.ReadLine();
                string[] commandsTokens = commands.Split();
                string command = commandsTokens[0];
                string username = commandsTokens[1];
                switch (command)
                {   
                    //REGISTER USER
                    case "register":
                        string licensplate = commandsTokens[2];
                        if (!database.ContainsKey(username))
                        {
                            database.Add(username, licensplate);
                            Console.WriteLine($"{username} registered {licensplate} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensplate}");
                        }
                        break;

                        //DELETE USER
                    case "unregister":
                        if (!database.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            Console.WriteLine($"{username} unregistered successfully");
                            database.Remove(username);
                        }
                        break;
                }

            }

            foreach (KeyValuePair<string, string> kvp in database)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}