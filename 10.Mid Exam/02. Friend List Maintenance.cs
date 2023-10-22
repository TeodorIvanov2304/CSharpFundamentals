namespace _02._Friend_List_Maintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            int blacklistCount = 0;
            int lostCount = 0;
            string commands = "";
            while ((commands = Console.ReadLine()) != "Report")
            {
                string[] commandsArgs = commands.Split().ToArray();
                string command = commandsArgs[0];

                switch (command)
                {
                    case "Blacklist":
                        string name = commandsArgs[1];
                        int index = 0;
                        if (names.Contains(name))
                        {
                            index = Array.IndexOf(names, name);
                            if (names[index] == name)
                            {
                                string currentName = names[index];
                                names[index] = "Blacklisted";
                                blacklistCount++;
                                Console.WriteLine($"{currentName} was blacklisted.");
                            }
                            
                        }
                        else // Does not contain that name
                        {
                            Console.WriteLine($"{name} was not found.");
                        }
                        break;
                    case "Error":
                        index = int.Parse(commandsArgs[1]);
                        if (IsValidIndex(names, index))
                        {
                            if (names[index] != "Lost" && names[index] != "Blacklisted")
                            {
                                string currentName = names[index];
                                names[index] = "Lost";
                                lostCount++;
                                Console.WriteLine($"{currentName} was lost due to an error.");
                            }
                        }
                        break;
                    case "Change":
                        index = int.Parse(commandsArgs[1]);
                        name = commandsArgs[2];
                        if (IsValidIndex(names, index))
                        {
                            string currentName = names[index];
                            names[index] = name;
                            Console.WriteLine($"{currentName} changed his username to {name}.");
                        }
                        break;

                }
            }
            //Print result
            Console.WriteLine($"Blacklisted names: {blacklistCount}");
            Console.WriteLine($"Lost names: {lostCount}");
            Console.WriteLine(string.Join(" ", names));
        }

        //Check if index is valid
        public static bool IsValidIndex(string[] names, int index)
        {
            return index >= 0 && index < names.Length;
        }
    }
}