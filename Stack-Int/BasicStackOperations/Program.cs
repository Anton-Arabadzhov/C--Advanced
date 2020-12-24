using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int pushesh = comand[0];
            int pops = comand[1];
            int contained = comand[2];
            Stack<int> stack = new Stack<int>();
            int[] pushes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < pushes.Length; i++)
            {
                stack.Push(pushes[i]);
            }
            for (int i = 0; i < pops; i++)
            {
                stack.Pop();
            }
            if (stack.Count > 0)
            {

                if (stack.Contains(contained))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
            
        }
    }
}
