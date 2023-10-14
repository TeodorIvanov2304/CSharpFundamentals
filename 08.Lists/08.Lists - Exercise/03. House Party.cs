using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Xml.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that keeps track of the guests that are going to a house party. On the first line, of input you are
            //going to receive the number of commands that will follow.
            //On the next lines, you are going to receive some of the following: "{name} is going!"
            //• You have to add the person, if they are not on the guestlist already.
            //• If the person is on the list print the following to the console: "{name} is already in the list!"
            //"{name} is not going!"
            //• You have to remove the person, if they are on the list.
            //• If not, print out: "{name} is not in the list!"
            //Finally, print all of the guests, each on a new line.

            int commands = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();
            AddRemoveGuests(commands, guestList);
            PrintGuests(guestList);

        }

        public static void AddRemoveGuests(int commands, List<string> guestList)
        {
            for (int i = 0; i < commands; i++)
            {
                string[] command = SplitCommand();
                string currentName = command[0];

                switch (command[2])
                {
                    case "going!":
                        if (CheckIfGuestIsInTheList(guestList, currentName))
                        {
                            Console.WriteLine($"{currentName} is already in the list!");
                        }
                        else
                        {
                            AddGuest(guestList, currentName);
                        }
                        break;

                    case "not":
                        if (guestList.Contains(currentName))
                        {
                            RemoveGuest(guestList, currentName);
                        }
                        else
                            Console.WriteLine($"{currentName} is not in the list!");
                        break;
                }
            }
            
        }

        public static void PrintGuests(List<string> guestList)
        {
            foreach (string name in guestList)
            {
                Console.WriteLine(name);
            }
        }

        public static bool CheckIfGuestIsInTheList(List<string> guestList, string currentName)
        {
            return guestList.Contains(currentName);
        }

        public static string[] SplitCommand()
        {
            return Console.ReadLine().Split();
        }

        
        public static void RemoveGuest(List<string> guestList, string currentName)
        {
            guestList.Remove(currentName);
        }

        public static void AddGuest(List<string> guestList, string currentName)
        {
            guestList.Add(currentName);
        }
    }
}