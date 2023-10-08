/*
Peter has finally become a junior developer and has received his first task. It's about manipulating an array of integers. He is not quite happy about it, since he hates manipulating arrays. They are going to pay him a lot of money, though, and he is willing to give somebody half of it if they help him do his job. You, on the other hand, love arrays (and money), so you decide to try your luck.
The array may be manipulated by one of the following commands
• exchange {index} – splits the array after the given index and exchanges the places of the two resulting sub-arrays. E.g. [1, 2, 3, 4, 5] -> exchange 2 -> result: [4, 5, 1, 2, 3]
o If the index is outside the boundaries of the array, print "Invalid index"
• max even/odd – returns the INDEX of the max even/odd element -> [1, 4, 8, 2, 3] -> max odd -> print 4
• min even/odd – returns the INDEX of the min even/odd element -> [1, 4, 8, 2, 3] -> min even > print 3
o If there are two or more equal min/max elements, return the index of the rightmost one
o If a min/max even/odd element cannot be found, print "No matches"
• first {count} even/odd – returns the first {count} elements -> [1, 8, 2, 3] -> first 2 even -> print [8, 2]
• last {count} even/odd – returns the last {count} elements -> [1, 8, 2, 3] -> last 2 odd -> print [1, 3]
o If the count is greater than the array length, print "Invalid count"
o If there are not enough elements to satisfy the count, print as many as you can. If there are zero even/odd elements, print an empty array "[]"
• end – stop taking input and print the final state of the array
© SoftUni – about.softuni.bg. Copyrighted document. Unauthorized copy, reproduction or use is not permitted.
Follow us: Page 5 of 6
Input
• The input data should be read from the console.
• On the first line, the initial array is received as a line of integers, separated by a single space.
• On the next lines, until the command "end" is received, you will receive the array manipulation commands.
• The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
• The output should be printed on the console.
• On a separate line, print the output of the corresponding command.
• On the last line print the final array in square brackets with its elements separated by a comma and a space .
• See the examples below to get a better understanding of your task.
Constraints
• The number of input lines will be in the range [2…50].
• The array elements will be integers in the range [0…1000].
• The number of elements will be in the range [1…50].
• The split index will be an integer in the range [-231…231 – 1].
• The first/last count will be an integer in the range [1…231 – 1].
• There will not be redundant whitespace anywhere in the input.
• Allowed working time for your program: 0.1
*/

namespace _11._Array_Manipulator
{
    internal class ArrayManipulator
    {
        static void Main(string[] args)
        {
            //Четем входа от конзолата
            //1 3 5 7 9
            int[] numbersArray = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToArray();
            //Създаваме променлива, която ще пази командите
            string command;
            //Четем команди от конзолата, докато не получим команда end. Обърни внимание на този запис!
            //while ((command = Console.ReadLine()) != "end")
            while ((command = Console.ReadLine()) != "end")
            {
                //Сплитваме командата например min even/odd на min even
                string[] subCommands = command.Split();
                switch (subCommands[0])
                {
                    case "exchange":
                        //Създаваме променлива, която ще пази индексът от комндата exchange
                        int index = int.Parse(subCommands[1]);
                        //Презаписваме масива numbersArray с резултата от метода Exchange
                        numbersArray = Exchange(numbersArray, index);
                        break;
                    case "max":
                        string maxType = subCommands[1];
                        PrintMaxNumber(numbersArray, maxType);
                        break;
                    case "min":
                        string minType = subCommands[1];
                        PrintMinNumber(numbersArray, minType);
                        break;
                    case "first":
                        int firstCount = int.Parse(subCommands[1]);
                        //Четем третата команда
                        string firstType = subCommands[2];
                        PrintFirstElements(numbersArray, firstCount, firstType);
                        break;
                    case "last":
                        int lastCount = int.Parse(subCommands[1]);
                        string lastType = subCommands[2];
                        PrintLastElement(numbersArray, lastCount, lastType);
                        break;
                }

            }
            Console.WriteLine($"[{string.Join(", ", numbersArray)}]");
        }

        static int[] Exchange(int[] numbersArray, int index)
        {
            //Проверяваме, дали даденият индекс няма да ни изкара извън масива
            if (CheckForOutOfBounds(numbersArray, index))
            {
                Console.WriteLine("Invalid index");
                return numbersArray;
            }
            int[] changedArray = new int[numbersArray.Length];
            //Помощна променлива, за да се пълни правилно новия масив
            int changedArrayIndex = 0;
            //Създаваме цикъл, който върти от дадения индекс до край на масива numbersArray
            for (int i = index + 1; i < numbersArray.Length; i++)
            {
                //Използваме индексът на помощната променлива, защото иначе ще се пълни само първия елемент
                changedArray[changedArrayIndex] = numbersArray[i];
                changedArrayIndex++;
            }

            for (int i = 0; i <= index; i++)
            {
                changedArray[changedArrayIndex] = numbersArray[i];
                changedArrayIndex++;
            }
            return changedArray;
        }



        //TYPE = even or odd
        static void PrintMaxNumber(int[] numbersArray, string type)
        {
            int maxIndex = -1;
            int maxNumber = int.MinValue;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (IsOddOrEven(numbersArray[i], type))
                {
                    if (numbersArray[i] >= maxNumber)
                    {
                        maxNumber = numbersArray[i];
                        maxIndex = i;
                    }
                }
            }
            PrintIndex(maxIndex);
        }




        static void PrintMinNumber(int[] numbersArray, string type)
        {
            int minIndex = -1;
            int minNumber = int.MaxValue;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (IsOddOrEven(numbersArray[i], type))
                {
                    if (numbersArray[i] <= minNumber)
                    {
                        minNumber = numbersArray[i];
                        minIndex = i;
                    }
                }
            }
            PrintIndex(minIndex);
        }
        static void PrintFirstElements(int[] numbersArray, int count, string type)
        {
            if (count > numbersArray.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string firstElement = string.Empty;
            int elementCount = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                //Повикваме метода IsOddOrEven
                if (IsOddOrEven(numbersArray[i], type))
                {
                    // Запазваме намерените елементи и индексът им
                    firstElement += $"{numbersArray[i]}, ";
                    elementCount++;
                    if (elementCount >= count)
                    {
                        break;
                    }
                }
            }
            //Премахваме запетайката по-горе с Trim метод
            Console.WriteLine($"[{firstElement.Trim(' ', ',')}]");
        }
        static void PrintLastElement(int[] numbersArray, int count, string type)
        {
            if (count > numbersArray.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string lastElement = string.Empty;
            int elementCount = 0;
            for (int i = numbersArray.Length - 1; i >= 0; i--)
            {
                //Повикваме метода IsOddOrEven
                if (IsOddOrEven(numbersArray[i], type))
                {
                    // Запазваме намерените елементи и индексът им, но наобратно , не с +=
                    lastElement = $"{numbersArray[i]}, " + lastElement;
                    elementCount++;
                    if (elementCount >= count)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"[{lastElement.Trim(' ', ',')}]");
        }
        static bool CheckForOutOfBounds(int[] array, int index)
        {
            return index < 0 || index >= array.Length;
        }

        static void PrintIndex(int maxIndex)
        {
            if (maxIndex != -1)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        static bool IsOddOrEven(int numbersArray, string type)
        {
            return (type == "odd" && numbersArray % 2 != 0) ||
                   (type == "even" && numbersArray % 2 == 0);
        }
    }
}