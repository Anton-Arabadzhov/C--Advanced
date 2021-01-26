using System;
using System.Linq;

namespace SumElements
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
                int[] rowData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int row = 0; row < rolss; row++)
                {
                    matrix[col, row] = rowData[row];
                }
            }
            int sum = 0;
            for (int col = 0; col < colons; col++)

            {
                for (int row = 0; row < rolss; row++)
                {
                    sum += matrix[col, row];
                   // Console.Write(matrix[col,row] + " " );
                }
               // Console.WriteLine();
            }
            Console.WriteLine(colons);
            Console.WriteLine(rolss);
            Console.WriteLine(sum);
        }
    }
}
