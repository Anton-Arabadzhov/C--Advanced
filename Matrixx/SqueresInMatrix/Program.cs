using System;
using System.Linq;

namespace SqueresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int roww = input[0];
            int coll = input[1];

            char[,] charMatrix = new char[roww, coll];

            for (int row = 0; row < roww; row++)
            {
                char[] chars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < coll; col++)
                {
                    charMatrix[row, col] = chars[col];
                }
            }
            int counter = 0;
            for (int row = 0; row < roww - 1; row++)
            {
                for (int col = 0; col < coll - 1; col++)
                {
                   // if (isSquere(charMatrix, row, col))
                   if (charMatrix[row, col] == charMatrix[row, col + 1] && charMatrix[row, col] == charMatrix[row + 1, col] && charMatrix[row, col] == charMatrix[row + 1, col + 1])
                    {
                        counter++;
                        
                    }
                }
            }
            Console.WriteLine(counter);
        }
        
       // static bool isSquere(char[,] charMatrix, int row, int col)
       // {
       //     return charMatrix[row, col] == charMatrix[row, col + 1] && charMatrix[row, col] == charMatrix[row + 1, col] && charMatrix[row, col] == charMatrix[row + 1, col + 1];
       // }
    }
}
