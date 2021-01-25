using System;
using System.Collections.Generic;
using System.Linq;

namespace FeshionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(clothes);
            int box = int.Parse(Console.ReadLine());

            int counter = 0;
            int fullbox = 0;
            while (true)
            {
                
                int cloth = stack.Peek();
                if (fullbox + cloth <= box)
                {
                    fullbox += cloth;
                    stack.Pop();
                }
                else
                {
                    counter++;
                    fullbox = 0;
                }
                if (fullbox > 0 && stack.Count == 0)
                {
                    counter++;
                }
                if (stack.Count == 0)
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
