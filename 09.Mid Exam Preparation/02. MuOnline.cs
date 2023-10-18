//rat 99|bat 20|potion 10|rat 10|chest 100|boss 70|chest 1000

//chest 100|bat 100|potion 100

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You have initial health 100 and initial bitcoins 0.You will be given a string representing the dungeon's rooms. Each room is separated with ' | ' (vertical bar): "room1|room2|room3…"
            //Each room contains a command and a number, separated by space. The command can be:
            //•	"potion"
            //o You are healed with the number in the second part.But your health cannot exceed your initial health(100).
            //o First print: "You healed for {amount} hp."
            //o After that, print your current health: "Current health: {health} hp."
            //•	"chest"
            //o You've found some bitcoins, the number in the second part.
            //o Print: "You found {amount} bitcoins."
            //•	In any other case, you are facing a monster, which you will fight. The second part of the room contains the attack of the monster. You should remove the monster's attack from your health. 
            //o If you are not dead(health <= 0), you've slain the monster, and you should print: "You slayed {monster}."
            //o If you've died, print "You died! Killed by {monster}." and your quest is over. Print the best room you've managed to reach: "Best room: {room}"
            //If you managed to go through all the rooms in the dungeon, print on the following three lines:
            //"You've made it!
            //Bitcoins: { bitcoins}
            //Health: { health}

            int health = 100;
            int bitcoins = 0;
            bool isAlive = true;
            string[] rooms = Console.ReadLine()
                             .Split("|")
                             .ToArray();

            for (int i = 0; i < rooms.Length; i++)
            {
                string commands = rooms[i];
                string[] commandArguments = commands.Split().ToArray();
                string command = commandArguments[0];
                int number = int.Parse(commandArguments[1]);

                switch (command)
                {
                    case "potion":

                        int initialHealth = health;
                        
                        if (health + number > 100)
                        {
                            health = 100;
                            number = 100 - initialHealth;
                            Console.WriteLine($"You healed for {number} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        else
                        {
                            health += number;
                            Console.WriteLine($"You healed for {number} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }

                        break;
                    case "chest":
                        Console.WriteLine($"You found {number} bitcoins.");
                        bitcoins += number;
                        break;
                    default:
                        health -= number;
                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {command}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {command}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            isAlive = false;
                            return;
                        }
                        break;
                }

            }

            if (isAlive)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}