using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedMatrix = new int[n][];

            for (int row = 0; row < jaggedMatrix.GetLength(0); row++)
            {
                jaggedMatrix[row] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

            }

            for (int row = 0; row < jaggedMatrix.GetLength(0) - 1; row++)
            {
               
                    if (jaggedMatrix[row].Length == jaggedMatrix[row + 1].Length)
                    {
                        for (int i = 0; i < jaggedMatrix[row].Length; i++)
                        {
                            jaggedMatrix[row][i] *= 2;
                            jaggedMatrix[row + 1][i] *= 2;
                        }

                    }
                    else
                    {
                        for (int i = 0; i < jaggedMatrix[row].Length; i++)
                        {
                            jaggedMatrix[row][i] /= 2;
                        }
                        for (int i = 0; i < jaggedMatrix[row + 1].Length; i++)
                        {
                            jaggedMatrix[row + 1][i] /= 2;
                        }
                    }
                
            }
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "End")
                {
                    break;
                }
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);
                if (!IsValid(row, col, jaggedMatrix))
                {
                    continue;
                }
                if (tokens[0] == "Add")
                {
                    jaggedMatrix[row][col] += value;
                }
                else if (tokens[0] == "Subtract")
                {
                    jaggedMatrix[row][col] -= value;
                }
            }
            PrintJaggedMatrix(jaggedMatrix);
        }

       

        static bool IsValid(int row, int col, int[][] jaggedMatrix)
        {
            return row >= 0 && row < jaggedMatrix.GetLength(0) && col >= 0 && col < jaggedMatrix[row].Length;
        }
         static void PrintJaggedMatrix(int[][] jaggedMatrix)
        {
            foreach (int[] intArray in jaggedMatrix)
            {
                Console.WriteLine(string.Join(" ", intArray));
            }
        }
    }
}
