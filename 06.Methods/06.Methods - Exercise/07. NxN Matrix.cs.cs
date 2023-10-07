using System;

namespace _07._NxN_Matrix
{
    internal class NxNMatrix
    {
        static void Main(string[] args)
        {
            //Create a method that receives a single integer n and prints an NxN matrix using this number as a filler.

            int MatrixBase = int.Parse(Console.ReadLine());
            int[] matrix = new int[MatrixBase];

            FillMatrixWithN(MatrixBase, matrix);
            PrintMatrix(MatrixBase, matrix);

        }

        private static void PrintMatrix(int MatrixBase, int[] matrix)
        {
            for (int i = 0; i < MatrixBase; i++)
            {
                PrintMatrixRow(matrix);
            }
        }

        private static void PrintMatrixRow(int[] matrix)
        {
            Console.WriteLine(string.Join(" ", matrix));
        }

        private static void FillMatrixWithN(int MatrixBase, int[] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = MatrixBase;
            }
        }
    }
}