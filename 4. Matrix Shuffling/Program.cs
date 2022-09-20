using System;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string matrixSize = Console.ReadLine();
            int rows = int.Parse(matrixSize.Split()[0]);
            int cols = int.Parse(matrixSize.Split()[1]);
            string[,] matrix = FillingMatrix(rows, cols);

            string cmd = Console.ReadLine();

            while (cmd != "END")
            {
                if (!CommandValidation(cmd, matrix))
                {
                    Console.WriteLine("Invalid input!");
                    cmd = Console.ReadLine();
                    continue;
                }
                string[] command = cmd.Split();
                int row1 = int.Parse(command[1]);
                int col1 = int.Parse(command[2]);
                int row2 = int.Parse(command[3]);
                int col2 = int.Parse(command[4]);

                string firstEl = matrix[row1, col1];
                string secondEl = matrix[row2, col2];
                matrix[row2, col2] = firstEl;
                matrix[row1, col1] = secondEl;

                PrintMatrix(matrix);
                cmd = Console.ReadLine();
            }
            
        }

      


        static string[,] FillingMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            return matrix;
        }
        static bool CommandValidation(string cmd, string[,] matrix)
        {
            string[] command = cmd.Split();
            if (command[0] == "swap" && command.Length == 5)
            {
                int row1 = int.Parse(command[1]);
                int col1 = int.Parse(command[2]);
                int row2 = int.Parse(command[3]);
                int col2 = int.Parse(command[4]);

                if (row1 >= 0 && row1 < matrix.GetLength(0)
                    && col1 >= 0 && col1 < matrix.GetLength(1)
                    && row2 >= 0 && row2 < matrix.GetLength(0)
                    && col2 >= 0 && col2 < matrix.GetLength(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                return false;
            }
        }
        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
