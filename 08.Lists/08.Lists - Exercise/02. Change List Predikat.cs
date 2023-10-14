namespace _02._Change_List_Predikat
{
    internal class ChangeListPredikat
    {
        static void Main(string[] args)
        {
            List<int> listOfInt = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            string command = Console.ReadLine();

            while (command!="end") 
            {
                string[] commandArgs = command.Split();
                string firstCommand = commandArgs[0];
                int element = int.Parse(commandArgs[1]);

                if (firstCommand=="Delete") 
                {   
                    //ПРЕДИКАТ! Намира всички елементи == х и ги премахва!
                    listOfInt.RemoveAll(x => x == element);
                }

                else if(firstCommand == "Insert")
                {
                    int index = int.Parse(commandArgs[2]);
                    listOfInt.Insert(index, element);
                }


                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", listOfInt));
        }
    }
}