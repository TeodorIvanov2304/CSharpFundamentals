namespace _04._SoftUni_Parking_classs_User
{   
    class User
    {
        

        public User(string userName, string licensePlate)
        {
            UserName = userName;
            LicensePlate = licensePlate;
        }

        public string UserName { get; set; }
        public string LicensePlate { get; set; }

        public override string ToString()
        {
            return $"{UserName} => {LicensePlate}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> users = new Dictionary<string, User>();
            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string command = arguments[0];
                string userName = arguments[1];

                switch (command) 
                {
                    case "register":
                        string licensePlate = arguments[2];
                        User newUser = new User(userName, licensePlate);

                        if (!users.ContainsKey(userName))
                        {
                            users.Add(newUser.UserName, newUser);
                            Console.WriteLine($"{newUser.UserName} registered {newUser.LicensePlate} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {newUser.LicensePlate}");
                        }
                        
                        break;
                    case "unregister":
                        if (users.ContainsKey(userName))
                        {   
                            //Когато използваме Dictionary, когато изтриеш ключа, се изтрива и стойността срещу ключа. Ако e SortedDictionary, мястото остава празно след изтриването
                            users.Remove(userName);
                            Console.WriteLine($"{userName} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        break;
                }
            }

            foreach (var kvp in users.Values)
            {
                Console.WriteLine(kvp);
            }
        }
    }
}