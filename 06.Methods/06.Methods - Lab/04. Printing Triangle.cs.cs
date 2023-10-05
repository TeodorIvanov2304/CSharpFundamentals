namespace _04._Printing_Triangle
{
    internal class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Четем число n

            PrintTriangle(n);


            // ТОВА Е ЦЯЛАТА ПРОГРАМА САМО В MAIN МЕТОДА
            //*****************************************************
            //for (int row = 1; row <= n; row++)
            //{
            //    for (int col = 1; col <= row; col++)   С CTRL + . разделяме на методи двата вложени цикъла
            //    {
            //        Console.Write(col);
            //    }
            //    Console.WriteLine();
            //}

            //for (int row = n - 1; row >= 1; row--)
            //{
            //    for (int col = 1; col <= row; col++)
            //    {
            //        Console.Write(col);
            //    }
            //    Console.WriteLine();
            //}
            //*****************************************************
        }

        static void PrintTriangle(int n) // Печата целия триъгълник
        {
            PrintUpperPartOfTriangle(n);
            PrintBottomPart(n);
        }

        static void PrintBottomPart(int n) // Печата долната част на триъгълника
        {
            for (int row = n - 1; row >= 1; row--)
            {
                PrintLineAndSpace(row);
            }
        }

        static void PrintUpperPartOfTriangle(int n) // Печата горната част на триъгълника
        {
            for (int row = 1; row <= n; row++)
            {
                PrintLineAndSpace(row);
            }
        }

        static void PrintLineAndSpace(int row) // Печата нов ред и space
        {
            for (int col = 1; col <= row; col++) //С CTRL + .разделяме на методи двата вложени цикъла
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }
}