namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7.List Manipulation Advanced
            //Next, we are going to implement more complicated list commands, extending the previous task. Again, read a list
            //and keep reading commands until you receive "end":
            //• Contains { number} – check if the list contains the number and if so - print "Yes", otherwise print
            //"No such number".
            //• PrintEven – print all the even numbers, separated by a space.
            //• PrintOdd – print all the odd numbers, separated by a space.
            //• GetSum – print the sum of all the numbers.
            //• Filter { condition} { number} – print all the numbers that fulfill the given condition.The condition
            //will be either '<', '>', ">=", "<=".
            //After the end command, print the list only if you have made some changes to the original list. Changes are made
            //only from the commands from the previous task.

            List<int> numbers = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToList();

            //Създаваме празна променлива, която ще отговаря за командите
            string line = string.Empty;
            //Създаваме нов празен лист
            List<int> numbersOriginal = new List<int>();
            //Пълним празният лист с числата от първия лист
            //НЕ СЕ ПРАВИ С = !!!
            for (int i = 0; i < numbers.Count; i++)
            {
                numbersOriginal.Add(numbers[i]);
            }
            //Създаваме цикъл, който приема команди до "end"
            while ((line = Console.ReadLine()) != "end")
            {
                //Създаваме масив, който ще пази командата, разделена на части
                string[] lineTokens = line.Split().ToArray();
                //Взимаме първата команда, която е стринг
                string command = lineTokens[0];
                //Взимаме втората команда и я парсваме към новата променлива number 
                //int number = 0;
                //if (lineTokens.Length > 1) 
                //{
                //    int number = int.Parse(lineTokens[1]);
                //}


                //Създаваме switch, който ще върти командите
                switch (command)
                {

                    case "Add":
                        int number = int.Parse(lineTokens[1]);
                        numbers.Add(number);
                        break;
                    case "Insert":
                        //Създавме променлива индекс, която взима второто чосло от командата
                        number = int.Parse(lineTokens[1]);
                        int index = int.Parse(lineTokens[2]);
                        numbers.Insert(index, number);
                        break;
                    case "Remove":
                        number = int.Parse(lineTokens[1]);
                        numbers.Remove(number);
                        break;
                    //В случая с RemoveAt number играе индекс
                    case "RemoveAt":
                        number = int.Parse(lineTokens[1]);
                        numbers.RemoveAt(number);
                        break;
                    case "Contains":

                        number = int.Parse(lineTokens[1]);
                        if (numbers.Contains(number) == true)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        int sum = numbers.Sum();
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = lineTokens[1];
                        number = int.Parse(lineTokens[2]);
                        if (condition == "<")
                        {
                            //Създаваме нов лист и прилагаме метода FindAll на number
                            //Като е => е < number означава всички елементи са елементите по-малки
                            //от number
                            List<int> filtered = numbers.FindAll(e => e < number);
                            Console.WriteLine(string.Join(" ", filtered));
                        }
                        else if (condition == ">")
                        {
                            List<int> filtered = numbers.FindAll(e => e > number);
                            Console.WriteLine(string.Join(" ", filtered));
                        }
                        else if (condition == ">=")
                        {
                            List<int> filtered = numbers.FindAll(e => e >= number);
                            Console.WriteLine(string.Join(" ", filtered));
                        }
                        else
                        {
                            List<int> filtered = numbers.FindAll(e => e <= number);
                            Console.WriteLine(string.Join(" ", filtered));
                        }
                        break;
                }
            }
            //Създаваме булева промелива = false
            bool notEqual = false;

            //Създаваме for-цикъл, който върти по дължината на по-големия лист
            for (int i = 0; i < Math.Max(numbers.Count, numbersOriginal.Count); i++)
            {
                //Сравняваме броя на елементите в двата листа
                if (numbers.Count > numbersOriginal.Count || numbersOriginal.Count > numbers.Count)
                {
                    notEqual = true;
                    break;
                }

                //Сравняваме елементите 1 по 1
                if (numbers[i] != numbersOriginal[i])
                {
                    notEqual = true;
                    break;
                }
            }

            //Ако не са еднакви, отпечатваме
            if (notEqual)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}