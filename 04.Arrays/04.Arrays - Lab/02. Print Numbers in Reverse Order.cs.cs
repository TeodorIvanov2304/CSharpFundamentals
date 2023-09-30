using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class PrintReversedNumbers
    {
        static void Main(string[] args)
        {   
            // Четем n числа от конзолата
            int n = int.Parse(Console.ReadLine());

            // Създаваме масив от стринг с дължината на n
            int[] integerArray = new int[n];

            // Създаваме цикъл, който да върти от 0 до n
            for (int i = 0; i < n; i++)
            {   
                // Попълваме масива с числа от конзолата
                integerArray[i] = int.Parse(Console.ReadLine());
            }

            // Създаваме нов цикъл, който да започне да обръща integerArray наобратно
            for (int j = integerArray.Length - 1; j >= 0; j--)
            {   
                // Изпечатваме на конзолата
                Console.Write($"{integerArray[j]} ");
            }
            
        }
    }
}