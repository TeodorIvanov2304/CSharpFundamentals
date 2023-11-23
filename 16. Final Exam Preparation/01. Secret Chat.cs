using System.Text;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string concealedMsg = Console.ReadLine();
            StringBuilder msgBuilder = new StringBuilder();
            msgBuilder.Append(concealedMsg);
            string commands = "";
            while ((commands = Console.ReadLine()) != "Reveal")
            {
                string[] commandArgs = commands.Split(":|:").ToArray();
                string command = commandArgs[0];

                switch (command)
                {
                    case "InsertSpace":
                        int index = int.Parse(commandArgs[1]);
                        //concealedMsg = concealedMsg.Insert(index, " ");
                        msgBuilder.Insert(index, " ");
                        Console.WriteLine(msgBuilder);
                        break;
                    case "Reverse":
                        string subStr = commandArgs[1];
                        //Като му кажем ToString() и се отварят други опции за chaining
                        int substringIndex = msgBuilder.ToString().IndexOf(subStr);

                        if (substringIndex != -1)
                        {
                            string reversedStr = new string(subStr.Reverse().ToArray());
                            msgBuilder.Remove(substringIndex, subStr.Length);
                            msgBuilder.Append(reversedStr);
                            Console.WriteLine(msgBuilder);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "ChangeAll":
                        subStr = commandArgs[1];
                        string replacementStr = commandArgs[2];
                        msgBuilder.Replace(subStr, replacementStr);
                        Console.WriteLine(msgBuilder);
                        break;
                }


            }
            Console.WriteLine($"You have a new text message: {msgBuilder}");
        }
    }
}