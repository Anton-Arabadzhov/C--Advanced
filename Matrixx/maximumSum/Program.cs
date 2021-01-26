using System;
using System.Linq;

namespace maximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int roww = input[0];
            int coll = input[1];

            int[,] Matrix = new int[roww, coll];

            for (int row = 0; row < roww; row++)
            {
                int[] chars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < coll; col++)
                {
                    Matrix[row, col] = chars[col];
                }
            }
            int maxSum = int.MinValue;
            int rowIndex = -1;
            int cowIndex = -1;

            for (int row = 0; row < roww - 2; row++)
            {
                for (int col = 0; col < coll - 2; col++)
                {
                    int sum = Matrix[row, col];
                    sum += Matrix[row, col + 1];
                    sum += Matrix[row, col + 2];

                    sum += Matrix[row + 1, col];
                    sum += Matrix[row+ 1, col+1];
                    sum += Matrix[row + 1, col + 2];

                    sum += Matrix[row + 2, col];
                    sum += Matrix[row + 2, col + 1];
                    sum += Matrix[row + 2, col + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowIndex = row;
                        cowIndex = col;
                    }
                }
                
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int row = rowIndex; row < rowIndex+ 3; row++)
            {
                for (int col = cowIndex; col < cowIndex + 3; col++)
                {
                    Console.Write(Matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
