using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] fillingMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = fillingMatrix[col];
                }
            }
            int sumPrimeDiagonal = 0;
            int sumSecondDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        sumPrimeDiagonal += matrix[row, col];
                    }
                    if ((row + col) == matrixSize - 1)
                    {
                        sumSecondDiagonal += matrix[row, col];
                    }

                }

            }
          
            Console.WriteLine($"{Math.Abs(sumPrimeDiagonal - sumSecondDiagonal)}");
           
        }
    }
}
