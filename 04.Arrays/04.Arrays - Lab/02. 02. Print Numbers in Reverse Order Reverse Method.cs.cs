using System;

namespace _02._Print_Numbers_in_Reverse_Order_Reverse_Method
{
    internal class Program
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

            // Изпечатваме на конзолата използвайки String.Join където в скобите слагаме " " и делегат,
            // в случая метода Reverse() от integerArray
            Console.WriteLine(String.Join(" ",integerArray.Reverse()));
        }
    }
}