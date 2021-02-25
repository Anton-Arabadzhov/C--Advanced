using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFightforGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] platesNum = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> plates = new Queue<int>();
                Stack<int> orcs = new Stack<int>();

            for (int i = 0; i < platesNum.Length; i++)
            {
                plates.Enqueue(platesNum[i]);
            }

            

            for (int i = 1; i < n + 1; i++)
            {

                int[] orcsNum = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < orcsNum.Length; j++)
                {
                    orcs.Push(orcsNum[j]);
                }
                if (i % 3 == 0)
                {
                    int extraplate = int.Parse(Console.ReadLine());
                    plates.Enqueue(extraplate);
                }

                while (orcs.Count > 0 && plates.Count > 0)
                {
                    int orcAtack = orcs.Peek();
                    int plateToAtack = plates.Peek();
                    
                    if (plateToAtack > orcAtack)
                    {
                        int nePlate = plateToAtack - orcAtack;
                        plates.Dequeue();
                        plates.Enqueue(nePlate);
                        orcs.Pop();
                    }
                    else if (orcAtack > plateToAtack)
                    {
                        int newOrk = orcAtack - plateToAtack;
                        plates.Dequeue();
                        orcs.Pop();
                        orcs.Push(newOrk);
                    }
                    else if (orcAtack == plateToAtack)
                    {
                        orcs.Pop();
                        plates.Dequeue();
                    }

                }
                if (plates.Count == 0)
                {
                    break;
                }
                
            }

            if (plates.Count > 0)
            {
                Console.WriteLine($"The people successfully repulsed the orc's attack.");
                    Console.Write("Plates left: ");
                
                    Console.Write(string.Join(", ", plates));
                

            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.Write("Orcs left: ");
                
                
                    Console.Write(string.Join(", ", orcs));
                
                   
                
            }

        }
    }
}
