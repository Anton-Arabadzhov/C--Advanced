using System;
using System.Linq;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] field = new char[n,n];

            int playerRow = -1;
            int playerCol = -1;

            int Flowers = 0;

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    char symbol = input[col];
                    field[row, col] = symbol;
                    if (field[row,col] == 'B')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
                
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                

                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;

                if (command == "up")
                {
                    newPlayerRow--;

                }
                else if (command == "down")
                {
                    newPlayerRow++;
                }
                else if (command == "left")
                {
                    newPlayerCol--;
                }
                else if (command == "right")
                {
                    newPlayerCol++;
                }

                if (!isValidCell(newPlayerRow, newPlayerCol, n,n))
                {
                    Console.WriteLine("The bee got lost!");
                    field[playerRow, playerCol] = '.';
                    break;
                }

                if (field[newPlayerRow, newPlayerCol] == 'f')
                {
                    field[playerRow, playerCol] = '.';
                    field[newPlayerRow, newPlayerCol] = 'B';
                    Flowers++;


                    
                }
                else if (field[newPlayerRow, newPlayerCol] == 'O')
                {
                    field[playerRow, playerCol] = '.';
                    field[newPlayerRow, newPlayerCol] = 'B';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                    continue;

                }
                else if (field[newPlayerRow, newPlayerCol] == '.')
                {
                    field[playerRow, playerCol] = '.';
                    field[newPlayerRow, newPlayerCol] = 'B';
                }
                playerRow = newPlayerRow;
                playerCol = newPlayerCol;

                command = Console.ReadLine();

            }

            if (Flowers < 5)
            {
                int resut = 5 - Flowers;
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {resut} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {Flowers} flowers!");
            }


            for (int row = 0; row < n; row++)
            {

                for (int col = 0; col < n; col++)
                {
                    Console.Write(field[row, col]);


                }
                Console.WriteLine();

            }

        }
        private static bool isValidCell(int row, int col, int n, int m)
        {
            return row >= 0 && row < n && col >= 0 && col < m;
        }
    }
}
