/*
abcdefghijklmnopqrstuvwxyz
Flip>>>Upper>>>3>>>14

 */
namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Четем първоначалният стринг от конзолата
            string rawKey = Console.ReadLine();

            //Създаване променлива, която ще пази командите
            string commands = "";

            //Създаваме цикъл, който ще върти докато не дойде команда Generate
            while ((commands = Console.ReadLine()) != "Generate") 
            {
                //Създаваме помощна променлива, в която ще държим командите
                string[] commandTokens = commands.Split(">>>");

                //Създаваме която държи 1-ва команда
                string command = commandTokens[0];

                //Създаваме switch, в който ще въртим командите
                switch (command)
                {   
                    
                    case "Contains":
                        //Създаваме проемнлива, substring в която пазим частта от rewKey която търсим
                        string substring = commandTokens[1];

                        //Ако се substring се сърдържа в rawKey
                        if (rawKey.Contains(substring)) 
                        {
                            Console.WriteLine($"{rawKey} contains {substring}");
                        }
                        //Ако не
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        //Създаваме променлива, която пази компандата голяма/малка буква
                        string caseLetter = commandTokens[1];
                        //Създаваме променлива, която пази начлния индекс
                        int startIndex = int.Parse(commandTokens[2]);
                        //Създаваме променлива, която пази крайния индекс
                        int endIndex = int.Parse(commandTokens[3]); 
                        //Създаваме променлива, която пази новият символ
                        char newChar = ' ';
                        //Ако командата е Главна буква
                        if (caseLetter == "Upper")
                        {   
                            //Създаваме цикъл, който върти между индексите
                            for (int i = startIndex; i < endIndex; i++)
                            {
                                //Създаваме променлива, която пази сегашната буква
                                char oldChar = rawKey[i];
                                //Новата буква става главна
                                newChar = char.ToUpper(oldChar);
                                //Заместваме буквите с Remove, и след това Insert
                                rawKey = rawKey.Remove(i, 1).Insert(i, newChar.ToString());
                            }
                            Console.WriteLine(rawKey);
                        }
                        else //Ако е малка
                        {
                            for (int i = startIndex; i < endIndex; i++)
                            {
                                char oldChar = rawKey[i];
                                newChar = char.ToLower(oldChar);
                                rawKey = rawKey.Remove(i, 1).Insert(i, newChar.ToString());
                            }
                            Console.WriteLine(rawKey);
                        }
                        break;
                    case "Slice":
                        startIndex = int.Parse(commandTokens[1]);
                        endIndex = int.Parse(commandTokens[2]);
                        //Изрязваме rawKey между индексите. Използваме ПРЕЗАПИСВАНЕ, иначе се създава 
                        //НОВ СТРИНГ, който изчезва
                        rawKey = rawKey.Remove(startIndex, endIndex-startIndex);
                        
                        Console.WriteLine(rawKey);
                        break;
                }
            }

            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}