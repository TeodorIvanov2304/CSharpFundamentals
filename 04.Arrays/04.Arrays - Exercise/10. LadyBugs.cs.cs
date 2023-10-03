namespace _10._LadyBugs
{
    internal class LadyBugs
    {
        static void Main(string[] args)
        {
            long fieldLength = int.Parse(Console.ReadLine());
            int[] bugPlaces = Console.ReadLine()
                              .Split()
                              .Select(int.Parse)
                              .ToArray();

            int[] field = new int[fieldLength];

            for (int i = 0; i < bugPlaces.Length; i++)
            {
                int bugIndex = bugPlaces[i];
                if (bugIndex>=0 && bugIndex<field.Length)
                {
                    field[bugIndex] = 1;
                }
            }

            string command = "";
            //!!!
            while ((command=Console.ReadLine())!="end") 
            {
                string[] arguments = command.Split();

                int bugIndex = int.Parse(arguments[0]);
                string direction = arguments[1];
                int flightLength = int.Parse(arguments[2]);

                if (bugIndex < 0 || bugIndex > field.Length - 1 || field[bugIndex] == 0)
                {
                    continue;
                }

                field[bugIndex] = 0;
                int landIndex;
                
                switch (direction) 
                {
                    case "right":
                        landIndex = bugIndex + flightLength; 
                        if(landIndex>field.Length-1)
                        {
                            continue;
                        }

                        if (field[landIndex] == 1) 
                        {
                            while (field[landIndex] == 1)
                            {
                                landIndex += flightLength;
                                if(landIndex>field.Length-1)
                                {
                                    break;
                                }
                            }
                        }

                        if(landIndex<=field.Length-1)
                        {
                            field[landIndex] = 1;
                        }

                        break;

                        case "left":
                        landIndex = bugIndex - flightLength;

                        if(landIndex<0)
                        {
                            continue;
                        }

                        if (field[landIndex] == 1)
                        {   
                            while(field[landIndex] == 1)
                            {
                                landIndex -= flightLength;

                                if (landIndex < 0)
                                {
                                    break;
                                }
                            }
                            

                        }

                        if(landIndex>=0)
                        {
                            field[landIndex] = 1;
                        }

                        break;
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}