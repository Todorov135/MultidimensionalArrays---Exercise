using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int removedKnight = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int mostAttacked = 0;
            while (true)
            {
                int countMostAttacking = 0;
                int rowMostAttacking = 0;
                int colMostAttacking = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        char currPosition = matrix[row, col];

                        if (currPosition == 'K')
                        {
                            int attackedKnight = AttackCounter(row, col, matrix);
                            if (countMostAttacking < attackedKnight)
                            {
                                countMostAttacking = attackedKnight;
                                rowMostAttacking = row;
                                colMostAttacking = col;
                            }

                        }
                    }

                }
                if (countMostAttacking == 0)
                {
                    break;
                }
                else
                {
                    matrix[rowMostAttacking, colMostAttacking] = '0';
                    removedKnight++;
                }
            }
            Console.WriteLine(removedKnight);
        }

        static int AttackCounter(int row, int col, char[,] matrix)
        {
            int targets = 0;
            //up-left
            if (ValidPosition(row - 2, col - 1, matrix))
            {
                char currChar = matrix[row - 2, col - 1];
                if (currChar == 'K')
                {
                    targets++;
                }
            }
            //up-right
            if (ValidPosition(row - 2, col + 1, matrix))
            {
                char currChar = matrix[row - 2, col + 1];
                if (currChar == 'K')
                {
                    targets++;
                }
            }
            //right-up
            if (ValidPosition(row - 1, col + 2, matrix))
            {
                char currChar = matrix[row - 1, col + 2];
                if (currChar == 'K')
                {
                    targets++;
                }
            }
            //right-down
            if (ValidPosition(row + 1, col + 2, matrix))
            {
                char currChar = matrix[row + 1, col + 2];
                if (currChar == 'K')
                {
                    targets++;
                }
            }
            //down-right
            if (ValidPosition(row + 2, col + 1, matrix))
            {
                char currChar = matrix[row + 2, col + 1];
                if (currChar == 'K')
                {
                    targets++;
                }
            }
            //down-left
            if (ValidPosition(row + 2, col - 1, matrix))
            {
                char currChar = matrix[row + 2, col - 1];
                if (currChar == 'K')
                {
                    targets++;
                }
            }
            //left-down
            if (ValidPosition(row + 1, col - 2, matrix))
            {
                char currChar = matrix[row + 1, col - 2];
                if (currChar == 'K')
                {
                    targets++;
                }
            }
            //left-up
            if (ValidPosition(row - 1, col - 2, matrix))
            {
                char currChar = matrix[row - 1, col - 2];
                if (currChar == 'K')
                {
                    targets++;
                }
            }

            return targets;
        }
        static bool ValidPosition(int row, int col, char[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
