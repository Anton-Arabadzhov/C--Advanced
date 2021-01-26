using System;
using System.Collections.Generic;
using System.Linq;

namespace RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = dimensions[0];
            int m = dimensions[1];
            char[,] field = new char[n,m];
            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < m; col++)
                {
                    field[row, col] = rowData[col];
                    if (field[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }


            char[] directions = Console.ReadLine().ToCharArray();

            bool isWon = false;
            bool isDead = false;

            foreach (char direction in directions)
            {
                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;

                if (direction == 'U')
                {
                    newPlayerRow--;
                }
                else if (direction == 'D')
                {
                    newPlayerRow++;
                }
                else if (direction == 'L')
                {
                    newPlayerCol--;
                }
                else if (direction == 'R')
                {
                    newPlayerCol++;
                }

                if (!isValidCell(newPlayerRow, newPlayerCol, n, m))
                {
                    isWon = true;
                    field[playerRow, playerCol] = '.';
                    List<int[]> bunnuesCoordDinates = GetBunniesCooddinates(field);
                    SpreadBunnies(bunnuesCoordDinates, field);
                }
                else if (field[newPlayerRow,newPlayerCol] == '.')
                {
                    field[playerRow, playerCol] = '.';
                    field[newPlayerRow, newPlayerCol] = 'P';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                    List<int[]> bunnuesCoordDinates = GetBunniesCooddinates(field);
                    SpreadBunnies(bunnuesCoordDinates, field);

                    if (field[playerRow,playerCol] == 'B')
                    {
                        isDead = true;
                    }
                    
                }
                else if (field[newPlayerRow, newPlayerCol] == 'B')
                {
                    isDead = true;
                    field[playerRow, playerCol] = '.';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                    List<int[]> bunnuesCoordDinates = GetBunniesCooddinates(field);
                    SpreadBunnies(bunnuesCoordDinates, field);
                }

                

                if (isDead || isWon)
                {
                    break;
                }
            }
            PrintField(field);
            string ress = "";

            if (isWon)
            {
                ress = "won";
            }
            else
            {
                ress = "dead";
            }
            ress += $": {playerRow} {playerCol}";
            Console.WriteLine(ress);
        }

        private static void PrintField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {

                for (int col = 0; col < field.GetLength(1); col++)
                {

                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void SpreadBunnies(List<int[]> bunnuesCoordDinates, char[,] field)
        {
            

            foreach  (int[] BunnyCoordinates in bunnuesCoordDinates)
            {
                int row = BunnyCoordinates[0];
                int col = BunnyCoordinates[1];

                SpreadBunny(row - 1, col, field);
                SpreadBunny(row + 1, col, field);
                SpreadBunny(row , col - 1, field);
                SpreadBunny(row , col + 1, field);
            }
        }

        private static void SpreadBunny(int row, int col, char[,] field)
        {
            int rowsLenght = field.GetLength(0);
            int colsLenght = field.GetLength(1);
            if (isValidCell(row , col, rowsLenght, colsLenght))
            {
                field[row, col] = 'B';
            }
        }

        private static List<int[]> GetBunniesCooddinates(char[,] field)
        {
            List<int[]> bunnuesCoordDinates = new List<int[]>();

            for (int row = 0; row < field.GetLength(0); row++)
            {
                
                for (int col = 0; col < field.GetLength(1); col++)
                {

                    if (field[row, col] == 'B')
                    {
                        bunnuesCoordDinates.Add(new int[] { row, col });
                    }
                }
            }
            return bunnuesCoordDinates;
        }

        private static bool isValidCell(int row, int col, int n, int m)
        {
            return row >= 0 && row < n && col >= 0 && col < m;
        }
    }
}
