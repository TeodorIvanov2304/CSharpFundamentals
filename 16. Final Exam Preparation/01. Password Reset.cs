/*
Yet again, you have forgotten your password. Naturally, it's not the first time this has happened. Actually, you got so tired of it that you decided to help yourself with an intelligent solution.
Write a password reset program that performs a series of commands upon a predefined string. First, you will receive a string, and afterward, until the command "Done" is given, you will be receiving strings with commands split by a single space. The commands will be the following:
•	"TakeOdd"
o	 Takes only the characters at odd indices and concatenates them to obtain the new raw password and then prints it.
•	"Cut {index} {length}"
o	Gets the substring with the given length starting from the given index from the password and removes its first occurrence, then prints the password on the console.
o	The given index and the length will always be valid.
•	"Substitute {substring} {substitute}"
o	If the raw password contains the given substring, replace all of its occurrences with the substitute text given and print the result.
o	If it doesn't, prints "Nothing to replace!".
Input
•	You will be receiving strings until the "Done" command is given.
Output
•	After the "Done" command is received, print:
o	"Your password is: {password}"
Constraints
•	The indexes from the "Cut {index} {length}" command will always be valid.
*/
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