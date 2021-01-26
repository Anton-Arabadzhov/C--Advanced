using System;
using System.Linq;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rolCol = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = rolCol[0];
            int cols = rolCol[1];
            
            char[,] snake = new char[rows, cols];

            string input = Console.ReadLine();
            int counter = 0;
            string direction = "right";
            int row = 0;
            int col = 0;

            for (int i = 0; i < rows * cols; i++)
            {
                snake[row, col] = input[counter];
                if (direction == "right")
                {
                    col++;
                    
                }
                if (direction == "left")
                {
                    col--;
                }

                if (col == cols  && direction == "right")
                {
                    col--;
                    row++;
                    direction = "left";
                }
                if (col == -1 && direction == "left")
                {
                    col++;
                    row++;
                    direction = "right";
                }

                counter++;
                if (counter == input.Length )
                {
                    counter = 0;
                }
            }

            for (int rowas = 0; rowas < rows; rowas++)
            {
                for (int colas = 0; colas < cols; colas++)
                {
                    Console.Write(snake[rowas,colas]);
                }
                Console.WriteLine();
            }
        }
        
    }
}
