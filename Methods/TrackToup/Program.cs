using System;
using System.Collections.Generic;
using System.Linq;

namespace TrackToup
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumpsCount = int.Parse(Console.ReadLine());
            Queue<string> pumpsData = new Queue<string>();

            for (int i = 0; i < pumpsCount; i++)
            {
                pumpsData.Enqueue(Console.ReadLine());
            }

            

            for (int i = 0; i < pumpsCount; i++)
            {
                bool isSuccesfull = true;
                int currentPetrolAmount = 0;
                for (int j = 0; j < pumpsCount; j++)
                {
                    int[] pumpData = pumpsData.Dequeue().Split(" ").Select(int.Parse).ToArray();
                    pumpsData.Enqueue(string.Join(" ", pumpData));
                    currentPetrolAmount += pumpData[0];

                    currentPetrolAmount -= pumpData[1];

                    if (currentPetrolAmount < 0)
                    {
                        isSuccesfull = false;
                    }
                }
                if (isSuccesfull)
                {
                    Console.WriteLine(i);
                    break;
                }
                string temdData = pumpsData.Dequeue();
                pumpsData.Enqueue(temdData);
            }

        }
    }
}
