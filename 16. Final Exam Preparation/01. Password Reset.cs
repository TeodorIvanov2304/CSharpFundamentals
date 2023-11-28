using System.Text;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string commands = "";
            StringBuilder passBuilder = new StringBuilder(input);
            while ((commands = Console.ReadLine()) != "Done")
            {
                string[] commandsArgs = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commandsArgs[0];

                switch (command)
                {
                    case "TakeOdd":

                        //Имаше голям проблем, с изчистването на StringBuilder, за това го презаписах в нова променлива, и после изчистих StringBuilder, преди да започна да го пълня наново
                        string temopraryString = passBuilder.ToString();
                        passBuilder.Clear();
                        for (int i = 0; i < temopraryString.Length; i++)
                        {

                            if (i % 2 != 0)
                            {
                                passBuilder = passBuilder.Append(temopraryString[i]);
                            }
                        }

                        Console.WriteLine(passBuilder.ToString());

                        break;
                    case "Cut":
                        int index = int.Parse(commandsArgs[1]);
                        int length = int.Parse(commandsArgs[2]);
                        passBuilder = passBuilder.Remove(index, length);

                        Console.WriteLine(passBuilder.ToString());
                        break;
                    case "Substitute":
                        string subsring = commandsArgs[1];
                        string substitute = commandsArgs[2];

                        if (passBuilder.ToString().Contains(subsring))
                        {
                            passBuilder = passBuilder.Replace(subsring, substitute);
                            Console.WriteLine(passBuilder.ToString());
                        }
                        else
                        {
                            Console.WriteLine($"Nothing to replace!");
                        }
                        break;
                }
            }

            Console.WriteLine($"Your password is: {passBuilder}");
        }
    }
}