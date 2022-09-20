using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] matrixSize = Console.ReadLine().Split();
            int rows = int.Parse(matrixSize[0]);
            int cols = int.Parse(matrixSize[1]);

            if (rows < 3 || cols <3)
            {
                return;
            }

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] fillingMatrix = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = fillingMatrix[col];
                }
            }
            int sum = int.MinValue;
            int matrixRow = 0;
            int matrixCol = 0;
            

            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    int currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                                + matrix[row+1, col] + matrix[row+1, col + 1] + matrix[row+1, col + 2]
                                + matrix[row+2, col] + matrix[row+2, col + 1] + matrix[row+2, col + 2];
                    if (currSum>sum)
                    {
                        sum = currSum;
                        matrixRow = row;
                        matrixCol = col;
                    }

                }
            }
            Console.WriteLine($"Sum = {sum}");
            for (int row = 0; row < matrixRow+3; row++)
            {
                for (int col = matrixCol; col < matrixCol+3; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
