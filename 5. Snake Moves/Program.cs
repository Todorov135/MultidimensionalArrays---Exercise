using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int cols = matrixSize[1];
            char[] snake = Console.ReadLine().ToCharArray();
            char[,] snakeMove = new char[rows, cols];
            Queue<char> snakeQueue = new Queue<char>(snake);

            for (int row = 0; row < snakeMove.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < snakeMove.GetLength(1); col++)
                    {
                        SnakePart(snakeMove, snakeQueue, row, col);
                    }
                }
                else
                {
                    for (int col = snakeMove.GetLength(1) - 1; col >= 0; col--)
                    {
                        SnakePart(snakeMove, snakeQueue, row, col);
                    }

                }


            }

            for (int i = 0; i < snakeMove.GetLength(0); i++)
            {
                for (int j = 0; j < snakeMove.GetLength(1); j++)
                {
                    Console.Write(snakeMove[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void SnakePart(char[,] snakeMove, Queue<char> snakeQueue, int row, int col)
        {
            char currChar = snakeQueue.Peek();
            snakeMove[row, col] = snakeQueue.Dequeue();
            snakeQueue.Enqueue(currChar);
        }
    }
}
