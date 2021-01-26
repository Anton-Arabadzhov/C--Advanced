using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] juggedMatrix = new double[n][];

            for (int row = 0; row < n; row++)
            {
                double[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                juggedMatrix[row] = rowData;
            }


            //  for (int row = 0; row < n; row++)
            //  {
            //      int[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //     juggedMatrix[row] = new int[rowData.Length];
            //      for (int col = 0; col < rowData.Length; col++)
            //      {
            //           juggedMatrix[row][col] = rowData[col];
            //           
            //       }
            //   }


            for (int row = 0; row < n - 1; row++)
            {
                double[] firstArr = juggedMatrix[row];
                double[] secondArr = juggedMatrix[row + 1];
                if (firstArr.Length == secondArr.Length)
                {
                    juggedMatrix[row] = firstArr.Select(e => e * 2).ToArray();
                    juggedMatrix[row + 1] = secondArr.Select(e => e * 2).ToArray();
                }
                else
                {
                    juggedMatrix[row] = firstArr.Select(e => e / 2).ToArray();
                    juggedMatrix[row + 1] = secondArr.Select(e => e / 2).ToArray();
                }
            }




            string command = Console.ReadLine();

            while (command != "End")
            {

                
                string[] commandData = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int rowIndex = int.Parse(commandData[1]);
                int colIndex = int.Parse(commandData[2]);
                int value = int.Parse(commandData[3]);

                
                 bool isValidCell = rowIndex >= 0 && rowIndex < n && colIndex >= 0 && colIndex < juggedMatrix[rowIndex].Length;

                if (!isValidCell)
                {
                     command = Console.ReadLine();
                     continue;
                }
                

                if (commandData[0] == "Add")
                {

                    juggedMatrix[rowIndex][colIndex] += value;
                }
                else if (commandData[0] == "Subtract")
                {
                    juggedMatrix[rowIndex][colIndex] -= value;
                }
                

                command = Console.ReadLine();
            }

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join(" ",juggedMatrix[row]));
            }
        }
    }
}
