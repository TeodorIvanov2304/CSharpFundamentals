using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will receive a journal with some collecting items, separated with a comma and a space(", ").After that, until receiving "Craft!" you will be receiving different commands split by " - ":
            //•	"Collect - {item}" - you should add the given item to your inventory. If the item already exists, you should skip this line.
            //•	"Drop - {item}" - you should remove the item from your inventory if it exists.
            //•	"Combine Items - {old_item}:{new_item}" - you should check if the old item exists.If so, add the new item after the old one. Otherwise, ignore the command.
            //•	"Renew – {item}" – if the given item exists, you should change its position and put it last in your inventory.

            List<string> inventory = Console.ReadLine()
                                            .Split(", ")
                                            .ToList();
            string commands = "";

            while ((commands = Console.ReadLine()) != "Craft!") 
            {

                string[] commandsArgs = commands.Split(" - ").ToArray();
                string command = commandsArgs[0];
                string item = commandsArgs[1];

                switch(command)
                {
                    case "Collect":
                        if(!inventory.Contains(item))
                        {
                            inventory.Add(item);
                        }
                        break;
                    case "Drop":
                        if(inventory.Contains(item))
                        {
                            inventory.Remove(item);
                        }
                        break;
                    case "Combine Items":
                        string[] itemsForCombine = item.Split(":");
                        string oldItem = itemsForCombine[0];
                        string newItem = itemsForCombine[1];

                        if(inventory.Contains(oldItem))
                        {
                            int index = inventory.IndexOf(oldItem);
                            inventory.Insert(index + 1, newItem);
                        }
                        break;
                    case "Renew":
                        if(inventory.Contains(item))
                        {
                            int index = inventory.IndexOf(item);
                            string itemToRenew = item;
                            inventory.RemoveAt(index);
                            inventory.Add(itemToRenew);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}