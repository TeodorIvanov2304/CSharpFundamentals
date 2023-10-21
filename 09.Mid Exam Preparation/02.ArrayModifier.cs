namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToArray();
            string commands = "";

            while ((commands = Console.ReadLine()) != "end")
            {
                string[] commandsArgs = commands.Split().ToArray();
                string command = commandsArgs[0];
                
              
                switch (command)
                {
                    case "swap":
                        int index1 = int.Parse(commandsArgs[1]);
                        int index2 = int.Parse(commandsArgs[2]);
                        int temp = arrayOfInts[index1];
                        arrayOfInts[index1] = arrayOfInts[index2];
                        arrayOfInts[index2] = temp;
                        break;
                    case "multiply":
                        index1 = int.Parse(commandsArgs[1]);
                        index2 = int.Parse(commandsArgs[2]);
                        arrayOfInts[index1] = arrayOfInts[index1] * arrayOfInts[index2];
                        break;
                    case "decrease":
                        for (int i = 0; i < arrayOfInts.Length; i++)
                        {
                            arrayOfInts[i] -= 1;
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", arrayOfInts));
        }
    }
}
