namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {   
            //Четем масив от string от конзолата, защото нямаме математически операции
            string[] array = Console.ReadLine()
                          .Split();

            //Създаваме променлива-брояч, която броя последователни еднакви числа
            int bestCount = 0;
            //Създаваме променлива, която пази началния индекс на на най-дългата променлива
            int bestIdex = 0;
            //Създаваме for цикъл, който върти по дължината на масива
            for (int i = 0; i < array.Length; i++)
            {   
                //Създаваме променлива, която пази текущият елемент
                string currentElement = array[i];
                //Създаваме променлива, която брои последователните еднакви елементи
                int currentCounter = 1;
                
                //Създаваме цикъл, който върти от i + 1 до края на масива
                for (int j = i + 1; j < array.Length; j++)
                {   
                    //Проверяваме дали текущият елемент == на следващията елемент [j] (i + 1)
                    if (currentElement == array[j])
                    {   
                        //Ако да , добавяме към текущият брояч 1
                        currentCounter++;
                    }
                    //Ако не, брейкваме текущата итерация на j цикъла
                    else
                    {
                        break;
                    }
                }
                //Проверяваме дали текущият брояч > от брояча за най-дългата последователност
                if (currentCounter > bestCount) 
                {   
                    //Ако да
                    bestCount = currentCounter;
                    //Най-добрият индекс се приравнява на текущият индекс i
                    bestIdex = i;
                }
            }
            //Създаваме цикъл, който започва от 0 до bestCount
            for (int i = 0; i < bestCount; i++)
            {   
                //Изпечатваме на конзолата от bestIndex съответният брой интерации до bestCount
                Console.Write($"{array[bestIdex]} ");
            }

        }
    }
}