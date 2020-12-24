using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rack = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothes);
            int count = 0;
            int campereRack = 0;

            while (stack.Count > 0)
            {
                int cloth = stack.Peek();
                if (cloth + campereRack <= rack)
                {
                    campereRack += cloth;
                    stack.Pop();
                }
                else
                {
                    count++;
                    campereRack = 0;
                }
                if (stack.Count == 0 && campereRack > 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
