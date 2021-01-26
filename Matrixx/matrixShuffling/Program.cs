using System;
using System.Linq;

namespace matrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int roww = input[0];
            int coll = input[1];

            string[,] Matrix = new string[roww, coll];

            for (int row = 0; row < roww; row++)
            {
                string[] chars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < coll; col++)
                {
                    Matrix[row, col] = chars[col];
                }
            }

            ;

            while (true)
            {
               string command = Console.ReadLine();
                if (command ==  "END")
                {
                    break;
                }
                string[] commandData = command.Split();

                if (commandData.Length != 5 || commandData[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }


                int rowOne = int.Parse(commandData[1]);
                int rowTwo = int.Parse(commandData[2]);
                int colOne = int.Parse(commandData[3]);
                int coltwo = int.Parse(commandData[4]);

                bool isValidOne = rowOne >= 0 && rowOne < roww && colOne >= 0 && colOne < coll;
                bool isValidtho = rowTwo >= 0 && rowTwo < roww && coltwo >= 0 && coltwo < coll;

                if (!isValidOne || !isValidtho)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string valueOne = Matrix[rowOne, colOne];
                string valueTwo = Matrix[rowTwo, coltwo];

                Matrix[rowOne, colOne] = valueTwo;
                Matrix[rowTwo, coltwo] = valueOne;

                for (int row = 0; row < roww; row++)
                {
                    for (int col = 0; col < coll; col++)
                    {
                        Console.Write(Matrix[row,col] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
