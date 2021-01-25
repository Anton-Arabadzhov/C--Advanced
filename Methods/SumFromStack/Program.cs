using System;
using System.Collections.Generic;
using System.Linq;

namespace SumFromStack
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine().ToLower();

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            while (command != "end")
            {
                string[] cmdarg = command.Split().ToArray();
                string action = cmdarg[0];
                int firstNum = int.Parse(cmdarg[1]);

                if (cmdarg[0] == "add")
                {
                    int secondNum = int.Parse(cmdarg[2]);
                    stack.Push(firstNum);
                    stack.Push(secondNum);


                }
                else if (cmdarg[0] == "remove")
                {
                    if (stack.Count >= firstNum)
                    {
                        for (int i = 0; i < firstNum; i++)
                        {
                            stack.Pop();
                        }
                    }

                }

                command = Console.ReadLine().ToLower();
            }
            int sum = 0;

            while (stack.Count > 0)
            {
                sum += stack.Peek();
                stack.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
