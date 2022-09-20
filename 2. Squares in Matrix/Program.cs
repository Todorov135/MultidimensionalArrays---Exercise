using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputMatrixSize = Console.ReadLine();
            string[,] matrix = new string[int.Parse(inputMatrixSize.Split()[0]), int.Parse(inputMatrixSize.Split()[1])];
            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    if (matrix[row,col] == matrix[row+1,col]
                        && matrix[row, col] == matrix[row, col+1]
                        && matrix[row, col] == matrix[row+1, col]
                        && matrix[row, col] == matrix[row+1, col+1])
                    {
                        counter++;
                    }

                }
            }
            Console.WriteLine(counter);
        }
    }
}
