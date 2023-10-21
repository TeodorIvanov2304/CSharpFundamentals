namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                                            .Split("!")
                                            .ToList();
            string commands = "";

            while ((commands = Console.ReadLine()) != "Go Shopping!")
            {
                string[] commandsArgs = commands.Split().ToArray();
                string command = commandsArgs[0];
                string item = commandsArgs[1];

                switch (command)
                {
                    case "Urgent":
                        if (!groceries.Contains(item))
                        {
                            groceries.Insert(0, item);
                        }
                        break;
                    case "Unnecessary":
                        if (groceries.Contains(item))
                        {
                            groceries.Remove(item);
                        }
                        break;
                    case "Correct":
                        string newItem = commandsArgs[2];
                        if (groceries.Contains(item))
                        {
                            int index = groceries.IndexOf(item);
                            groceries[index] = newItem;
                        }
                        break;
                    case "Rearrange":
                        if (groceries.Contains(item))
                        {
                            string itemToRearrange = item;
                            groceries.Remove(item);
                            groceries.Add(itemToRearrange);
                        }
                        break;

                }
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}