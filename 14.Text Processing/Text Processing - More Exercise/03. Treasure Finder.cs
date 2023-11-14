/*
1213
ikeg fp'jpne)bv=41P83X@
 
 
*/

using System.Text;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Четем масив от ключове
            int[] keyArray = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray();
            //Четем кодираното съобщение
            string input = string.Empty;
            
            //Докато кодираното съобщение != find, въртим цикъла
            while ((input = Console.ReadLine()) != "find") 
            {   
                //Създаваме променлива StringBuilder
                StringBuilder decryptedInput = new StringBuilder();
                //Създаваме променлива, която ще пази индекса на текущия ключ
                int currentKey = 0;
                //Пускаме цикъл, който ще върти по дължината на текущото кодирано съобщение
                for (int i = 0; i < input.Length; i++)
                {   
                    //Ако индекса на симовола от текущото съобщение е > от големината на масива от ключове, започваме да въртим ключовете отначало 
                    if (currentKey > keyArray.Length-1)
                    {
                        currentKey = 0;
                    }
                    
                    //Създаваме променлива, която пази текущия симовл от код. съобщение
                    char currentSymbol = input[i];
                    //Създаваме променлива, която пази новият симовол, след декриптиране
                    char encryptedChar = (char)(currentSymbol - keyArray[currentKey]);
                    //Добавяме декриптираният символ към СтрингБилдъра и го кастваме към Стринг !
                    decryptedInput.Append(encryptedChar.ToString());
                    //Добавяме едно към индекса на ключовете
                    currentKey++;
                }

                //Записваме декриптираното съобщение в нов стринг
                string coordinates = decryptedInput.ToString();

                //Намираме началният индекс на съкровището
                int startIndexTreasure = coordinates.IndexOf('&');
                //Крайният индекс
                int endIndexTreasure = coordinates.LastIndexOf('&');
                //Записваме съкровището в нова стринг променлива
                string treasure = coordinates.Substring(startIndexTreasure+1, endIndexTreasure - startIndexTreasure-1);

                //Намираме началният индекс на координатите
                int startIndexCoordinates = coordinates.IndexOf('<');
                //Крайният индекс
                int endIndexCoordinates = coordinates.LastIndexOf('>');
                //Записваме координатите в нова променлива
                string finalCoordinates = coordinates.Substring(startIndexCoordinates + 1, endIndexCoordinates - startIndexCoordinates-1);
                //Изпечатваме
                Console.WriteLine($"Found {treasure} at {finalCoordinates}");
            }
        }
    }
}