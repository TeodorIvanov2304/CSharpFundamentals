namespace _02._Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The pirates need to carry a treasure chest safely back to the ship, looting along the way.
            //Create a program that manages the state of the treasure chest along the way. On the first line, you will receive the initial loot of the treasure chest, which is a string of items separated by a "|".
            //"{loot1}|{loot2}|{loot3} … {lootn}"
            //The following lines represent commands until "Yohoho!" which ends the treasure hunt:
            //•	"Loot {item1} {item2}…{itemn}":
            //o Pick up treasure loot along the way. Insert the items at the beginning of the chest.
            //o If an item is already contained, don't insert it.
            //•	"Drop {index}":
            //o Remove the loot at the given position and add it at the end of the treasure chest. 
            //o If the index is invalid, skip the command.
            //•	"Steal {count}":
            //o Someone steals the last count of loot items.If there are fewer items than the given count, remove as many as there are.
            //o Print the stolen items separated by ", ":
            //"{item1}, {item2}, {item3} … {itemn}"
            //In the end, output the average treasure gain, which is the sum of all treasure items' length divided by the count of all items inside the chest formatted to the second decimal point:
            //"Average treasure gain: {averageGain} pirate credits."
            //If the chest is empty, print the following message:
            //"Failed treasure hunt."

            List<string> treasureChest = Console.ReadLine()
                                            .Split("|")
                                            .ToList();

            string commands = "";

            while ((commands = Console.ReadLine()) != "Yohoho!")
            {
                string[] commandArguments = commands.Split()
                                                    .ToArray();

                string command = commandArguments[0];

                switch (command)
                {
                    case "Loot":
                        for (int i = 1; i <= commandArguments.Length - 1; i++)
                        {
                            if (!treasureChest.Contains(commandArguments[i]))
                            {
                                treasureChest.Insert(0, commandArguments[i]);
                            }
                        }
                        break;
                    case "Drop":
                        int index = int.Parse(commandArguments[1]);

                        if (index >= 0 && index < treasureChest.Count - 1)
                        {
                            string treasure = treasureChest[index];
                            treasureChest.RemoveAt(index);
                            treasureChest.Add(treasure);
                        }
                        break;
                    case "Steal":
                        int count = int.Parse(commandArguments[1]);
                        List<string> stealedItems = new List<string>();
                        if (treasureChest.Count < count)
                        {
                            count = treasureChest.Count;

                        }

                        for (int i = 0; i < count; i++)
                        {
                            string stealedItem = treasureChest[treasureChest.Count - 1];
                            treasureChest.RemoveAt(treasureChest.Count - 1);
                            stealedItems.Insert(0, stealedItem);
                        }

                        Console.WriteLine(string.Join(", ", stealedItems));
                        break;
                }
            }

            string allItems = string.Join("", treasureChest);
            double averageTreasureGain = (double)allItems.Length / (double)treasureChest.Count;

            if (treasureChest.Count > 0)
            {
                Console.WriteLine($"Average treasure gain: {averageTreasureGain:F2} pirate credits.");
            }
            else
            {
                Console.WriteLine($"Failed treasure hunt.");
            }

        }
    }
}