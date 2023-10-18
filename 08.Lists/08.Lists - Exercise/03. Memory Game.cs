/*
a 2 4 a 2 4
4 0
0 2
0 1
0 1
end

a 2 4 a 2 4
0 3
0 2
0 1
0 1
end

 
 */

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that recreates the Memory game.
            //On the first line, you will receive a sequence of elements. Each element in the sequence will have a twin. Until the player receives "end" from the console, you will receive strings with two integers separated by a space, representing the indexes of elements in the sequence.
            //If the player tries to cheat and enters two equal indexes or indexes which are out of bounds of the sequence, you should add two matching elements at the middle of the sequence in the following format: "-{number of moves until now}a"
            //Then print this message on the console:
            //"Invalid input! Adding additional elements to the board"

            List<string> elements = Console.ReadLine()
                                        .Split()
                                        .ToList();
            int moves = 0;
            string integers = "";
            int elementCount = elements.Count;
            int removedCount = 0;

            while ((integers = Console.ReadLine()) != "end") 
            {
                int[] numbers = integers.Split()
                                        .Select(int.Parse)
                                        .ToArray();
                moves++;
                int index1 = numbers[0];
                int index2 = numbers[1];

                //COUNT-1 !!! not COUNT
                if (index1 == index2 || index1<0 || index1 > elements.Count-1 || index2 <0 || index2>elements.Count-1)
                { 
                    string elementToInsert = $"-{moves}a";
                    elements.Insert(elements.Count / 2, elementToInsert);
                    elements.Insert(elements.Count / 2, elementToInsert);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }

                else if(elements[index1] == elements[index2])
                {   
                    string currentElement = elements[index1];
                    elements.RemoveAll(x => x == currentElement);
                    //elements.RemoveAt(index1);
                    //elements.RemoveAt(index2-1);
                    Console.WriteLine($"Congrats! You have found matching elements - {currentElement}!");
                    removedCount += 2;
                }
                            
                else if (elements[index1] != elements[index2]) 
                {
                    Console.WriteLine("Try again!");
                }
   
                if(removedCount == elementCount)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    return;
                }
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}