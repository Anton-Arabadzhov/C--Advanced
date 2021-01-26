using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int primaryDiagonal = 0;
            int secondDiagonal = 0;
            int counter = n-1;
            for (int row = 0; row < n; row++)
            {
                primaryDiagonal += matrix[row,row];
                secondDiagonal += matrix[row, counter];
                counter--;
            }
            Console.WriteLine(Math.Abs(primaryDiagonal - secondDiagonal));
            
        }
    }
}
