using System;
using System.Linq;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] coordinates = Console.ReadLine().Split(',',StringSplitOptions.RemoveEmptyEntries);

            int player1 = 0;
            int player2 = 0;
            int destroyedShips1 = 0;
            


            char[,] field = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    field[row, col] = rowData[col];
                    if (field[row, col] == '<')
                    {
                        player1++;
                    }
                    if (field[row,col] == '>')
                    {
                        player2++;
                    }
                }
            }
            int count = 0;
            while (player1 != 0 && player2 != 0)
            {
                int[] cordData = coordinates[count].Split().Select(int.Parse).ToArray();
                int row = cordData[0];
                int col = cordData[1];

                if (row >= 0 && row < n && col >= 0 && col < n)
                {



                    if (field[row, col] == '<')
                    {
                        player1--;
                        field[row, col] = 'X';
                        destroyedShips1++;
                    }
                    else if (field[row, col] == '>')
                    {
                        player2--;
                        field[row, col] = 'X';
                        destroyedShips1++;
                    }
                    else if (field[row, col] == '#')
                    {
                        field[row, col] = 'X';

                        if (row + 1 >= 0 && row + 1 < n && col >= 0 && col < n && field[row + 1, col] == '<')
                        {
                            
                            player1--;
                            field[row+1, col] = 'X';
                            destroyedShips1++;
                        }
                        if (row >= 0 && row < n && col+ 1 >= 0 && col + 1 < n && field[row, col + 1] == '<')
                        {
                            player1--;
                            field[row, col+1] = 'X';
                            destroyedShips1++;
                        }
                        if (row + 1 >= 0 && row + 1 < n && col + 1 >= 0 && col + 1 < n && field[row + 1, col + 1] == '<')
                        {
                            player1--;
                            field[row + 1, col + 1] = 'X';
                            destroyedShips1++;
                        }
                        if (row - 1 >= 0 && row - 1 < n && col >= 0 && col < n &&field[row - 1, col] == '<')
                        {
                            player1--;
                            field[row - 1, col] = 'X';
                            destroyedShips1++;
                        }
                        if (row >= 0 && row < n && col -1 >= 0 && col - 1 < n && field[row, col - 1] =='<')
                        {
                            player1--;
                            field[row, col - 1] = 'X';
                            destroyedShips1++;;
                        }
                        if (row - 1 >= 0 && row - 1 < n && col - 1 >= 0 && col - 1 < n && field[row - 1, col - 1] == '<')
                        {
                            player1--;
                            field[row - 1, col - 1] = 'X';
                            destroyedShips1++;
                        }
                        if (row + 1 >= 0 && row + 1 < n && col - 1 >= 0 && col - 1 < n && field[row + 1, col - 1] == '<')
                        {
                            player1--;
                            field[row + 1, col - 1] = 'X';
                            destroyedShips1++;
                        }
                        if (row - 1 >= 0 && row - 1 < n && col + 1 >= 0 && col + 1 < n && field[row - 1, col + 1] == '<')
                        {
                            player1--;
                            field[row - 1, col + 1] = 'X';
                            destroyedShips1++;
                        }
                        if (row + 1 >= 0 && row + 1 < n && col >= 0 && col < n && field[row + 1, col] == '>')
                        {

                            player2--;
                            field[row + 1, col] = 'X';
                            destroyedShips1++;
                        }
                        if (row >= 0 && row < n && col + 1 >= 0 && col + 1 < n && field[row, col + 1] == '>')
                        {
                            player2--;
                            field[row, col + 1] = 'X';
                            destroyedShips1++;

                        }
                        if (row + 1 >= 0 && row + 1 < n && col + 1 >= 0 && col + 1 < n && field[row + 1, col + 1] == '>')
                        {
                            player2--;
                            field[row + 1, col + 1] = 'X';
                            destroyedShips1++;
                        }
                        if (row - 1 >= 0 && row - 1 < n && col >= 0 && col < n && field[row - 1, col] == '>')
                        {
                            player2--;
                            field[row - 1, col] = 'X';
                            destroyedShips1++;
                        }
                        if (row >= 0 && row < n && col - 1 >= 0 && col - 1 < n && field[row, col - 1] == '>')
                        {
                            player2--;
                            field[row, col - 1] = 'X';
                            destroyedShips1++;
                        }
                        if (row - 1 >= 0 && row - 1 < n && col - 1 >= 0 && col - 1 < n && field[row - 1, col - 1] == '>')
                        {
                            player2--;
                            field[row - 1, col - 1] = 'X';
                            destroyedShips1++;
                        }
                        if (row + 1 >= 0 && row + 1 < n && col - 1 >= 0 && col - 1 < n && field[row + 1, col - 1] == '>')
                        {
                            player2--;
                            field[row + 1, col - 1] = 'X';
                            destroyedShips1++;
                        }
                        if (row - 1 >= 0 && row - 1 < n && col + 1 >= 0 && col + 1 < n && field[row - 1, col + 1] == '>')
                        {
                            player2--;
                            field[row - 1, col + 1] = 'X';
                            destroyedShips1++;
                        }
                    }
                }
                if (player2 == 0)
                {
                    Console.WriteLine($"Player One has won the game! {destroyedShips1} ships have been sunk in the battle.");
                }
                else if (player1 == 0)
                {
                    Console.WriteLine($"Player Two has won the game! {destroyedShips1} ships have been sunk in the battle.");
                }
                if (count == coordinates.Length - 1)
                {
                    break;
                }
                count++;

            }
            if (player1 > 0 && player2 > 0)
            {
            Console.WriteLine($"It's a draw! Player One has {player1} ships left. Player Two has {player2} ships left.");

            }



            

        }
    }
}
