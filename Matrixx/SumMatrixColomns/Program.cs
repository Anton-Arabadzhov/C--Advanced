using System;
using System.Linq;

namespace SumMatrixColomns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int colons = input[0];
            int rolss = input[1];

            int[,] matrix = new int[colons, rolss];

            for (int col = 0; col < colons; col++)
            {
                int[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int row = 0; row < rolss; row++)
                {
                    matrix[col, row] = rowData[row];
                }
            }
            
            for (int row = 0; row < matrix.GetLength(1); row++)

            {
                int sum = 0;
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    sum += matrix[col, row];
                }
                Console.WriteLine(sum);
                
                
            }
            
        }
    }
}
