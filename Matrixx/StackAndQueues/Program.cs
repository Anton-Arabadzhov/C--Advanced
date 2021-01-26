using System;

namespace StackAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            bool isTrue = true;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (symbol == matrix[row,col])
                    {
                        Console.WriteLine($"({row}, {col})");
                        isTrue = false;
                        break;
                    }

                }
                if (!isTrue)
                {
                    break;
                }
                    
            }
            if (isTrue)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
