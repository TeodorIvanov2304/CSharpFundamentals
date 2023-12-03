namespace _18._Final_Exam_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string commands = "";

            while ((commands = Console.ReadLine()) != "Finish") 
            {
                string[] commandsArgs = commands.Split().ToArray();
                string command = commandsArgs[0];
                switch (command) 
                {
                    case  "Replace":
                        string currentChar = commandsArgs[1];
                        string newChar = commandsArgs[2];
                        if (input.Contains(currentChar)) 
                        {
                            input = input.Replace(currentChar, newChar);
                            Console.WriteLine(input);
                        }
                        break;
                    case "Cut":
                        int startIndex = int.Parse(commandsArgs[1]);
                        int endIndex = int.Parse(commandsArgs[2]);
                        bool isValidIndex = startIndex>0 
                                         && startIndex<input.Length 
                                         && endIndex<input.Length
                                         && endIndex>0;

                        if (isValidIndex)
                        {
                            input = input.Remove(startIndex, endIndex - startIndex+1);
                            Console.WriteLine(input);
                        } 
                        else
                        {
                            Console.WriteLine($"Invalid indices!");
                        }
                        
                        break;
                    case "Make":
                        string upperOrLower = commandsArgs[1];
                        if (upperOrLower == "Upper")
                        {
                            input = input.ToUpper();
                            Console.WriteLine(input);
                        }
                        else if(upperOrLower == "Lower")
                        {
                            input = input.ToLower();
                            Console.WriteLine(input);
                        }
                        break;
                    case "Check":
                        string substring = commandsArgs[1];

                        if (input.Contains(substring))
                        {
                            Console.WriteLine($"Message contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine($"Message doesn't contain {substring}");
                        }
                        break;
                    case "Sum":
                        startIndex = int.Parse(commandsArgs[1]);
                        endIndex = int.Parse(commandsArgs[2]);
                        isValidIndex = startIndex > 0
                                         && startIndex < input.Length
                                         && endIndex < input.Length
                                         && endIndex > 0;
                        if (isValidIndex) 
                        {
                            string cutString = input.Substring(startIndex, endIndex - startIndex+1);
                            int sum = 0;

                            for (int i = 0; i < cutString.Length; i++)
                            {
                                char currentSymbol = cutString[i];
                                sum += (char)currentSymbol;
                            }
                            Console.WriteLine(sum);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        break;
                }
            }
        }
    }
}