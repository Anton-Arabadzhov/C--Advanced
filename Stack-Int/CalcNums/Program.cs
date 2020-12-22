using System;
using System.Collections.Generic;
using System.Linq;

namespace CalcNums
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine().Split(' ').Reverse().ToArray();
            Stack<string> stack = new Stack<string>(expression);

            while (stack.Count > 1)
            {
                PrintStack(stack);
                int first = int.Parse(stack.Pop());
                char sign = char.Parse(stack.Pop());
                int second = int.Parse(stack.Pop());

                if (sign == '+')
                {
                    stack.Push((first + second).ToString());
                }
                else
                {
                    stack.Push((first - second).ToString());
                }

            }
            Console.WriteLine(stack.Pop());
        }
        static void PrintStack(Stack<string> stack)
        {
            foreach (var item in stack)
            {


                Console.Write(item);
            }
                Console.WriteLine();
             
        }
    }
}
