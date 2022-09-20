using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[,] matrix = new int[rows, cols];

           
            int maxSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputCols = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputCols[col];
                }

            }

            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {

                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    int currSum = matrix[row, col]
                        + matrix[row, col + 1]
                        + matrix[row, col + 2]
                        + matrix[row + 1, col]
                        + matrix[row + 1, col + 1]
                        + matrix[row + 1, col + 2]
                        + matrix[row + 2, col]
                        + matrix[row + 2, col + 1]
                        + matrix[row + 2, col + 2];
                    if (currSum >= maxSum)
                    {
                        maxSum = currSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }

            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {

            }
        }
    }
}
