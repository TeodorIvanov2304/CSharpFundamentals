namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that helps you keep track of your shot targets. You will receive a sequence with integers, separated by a single space, representing targets and their value.Afterward, you will be receiving indices until the "End" command is given, and you need to print the targets and the count of shot targets.
            //Every time you receive an index, you need to shoot the target on that index, if it is possible.
            //Every time you shoot a target, its value becomes -1, and it is considered shot. Along with that, you also need to:
            //•	Reduce all the other targets, which have greater values than your current target, with its value. 
            //•	Increase all the other targets, which have less than or equal value to the shot target, with its value.
            //Keep in mind that you can't shoot a target, which is already shot. You also can't increase or reduce a target, which is considered a shot.
            //When you receive the "End" command, print the targets in their current state and the count of shot targets in the following format:
            // "Shot targets: {count} -> {target1} {target2}… {targetn}"

            int[] targets = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();
            
            int shotCount = 0;
            string indices = "";

            while ((indices = Console.ReadLine()) != "End") 
            {
                int index = int.Parse(indices);
                int currentTarget = 0;
                for (int i = 0; i < targets.Length; i++)
                {   
                    //Shoot
                    if(i == index && index >= 0 && index < targets.Length && targets[i] != -1)
                    {
                        currentTarget = targets[index];
                        targets[index] = -1;
                        shotCount++;
                    }
                }

                //Add and reduce other targets
                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] != -1)
                    {
                        if (targets[i]>currentTarget)
                        {
                            targets[i] -= currentTarget;
                        }

                        else
                        {
                            targets[i] += currentTarget;
                        }
                    }
                }
            }

            Console.WriteLine($"Shot targets: {shotCount} -> {string.Join(" ", targets)} ");
        }
    }
}