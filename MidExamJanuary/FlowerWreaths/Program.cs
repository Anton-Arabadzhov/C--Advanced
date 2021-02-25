using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> Lilies = new Stack<int>();
            Queue<int> roses = new Queue<int>();

            int storedFlowers = 0;
            int CreatedWreaths = 0;

            int[] InputLillies = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < InputLillies.Length; i++)
            {
                int LilFlower = InputLillies[i];
                Lilies.Push(LilFlower);
                
            }



            int[] InputRoses = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < InputRoses.Length; i++)
            {
                int RosesFlower = InputRoses[i];
                roses.Enqueue(RosesFlower);
                
            }

            while (Lilies.Count > 0 && roses.Count > 0)
            {
                int sumFlow = Lilies.Peek() + roses.Peek();
                if (sumFlow == 15)
                {
                    CreatedWreaths++;
                    Lilies.Pop();
                    roses.Dequeue();
                }
                else if (sumFlow > 15 )
                {
                    int LilPop = Lilies.Pop();
                    LilPop -= 2;
                    Lilies.Push(LilPop);
                    continue;
                }
                else if (sumFlow < 15)
                {
                    storedFlowers += sumFlow;
                    Lilies.Pop();
                    roses.Dequeue();
                }



            }
            if (storedFlowers > 15)
            {
                CreatedWreaths += (storedFlowers / 15);
            }
            if (CreatedWreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {CreatedWreaths} wreaths!");
            }
            else
            {
                int result = 5 - CreatedWreaths;
                Console.WriteLine($"You didn't make it, you need {result} wreaths more!");
            }
        }
    }
}
