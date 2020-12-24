using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 demension matrix
            int[,] intMatrix = new int[3, 4];
            float[,] floatMatrix = new float[3, 4];
            int[,] matrix = { { 1, 2, 3, 4 },{ 5, 6, 7, 8 } };
            //getting element
            int[,] array = { {1,2 }, {3,4 } };
            int element = array[1, 1]; /*-> 4*/
            //3 demension matrix
            string[,,] stringMatrix = new string[3,5, 4];

            int[,] forMat = {
                { 1, 2, 3},
                { 4, 5, 6},
                { 7, 8, 9}
            };
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.WriteLine(matrix[i,k]);
                }
            }
            //for (int i = 0; i < forMat.GetLength(0); i++)
            //{
            //    for (int k = 0; k < forMat.GetLength(0); k++)
            //    {
            //        Console.WriteLine(matrix[i, k]);
            //    }
            //}

        }
    }
}
