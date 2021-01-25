using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedPerenthesses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            bool isTrue = true;

            foreach (var item in input)
            {
                if (item == '{' || item == '[' || item == '(')
                {
                    stack.Push(item);
                }
                else
                {
                    if (item == '}' && stack.Pop() == '{')
                    {
                        isTrue = true;
                    }
                    else if (item == ']' && stack.Pop() == '[')
                    {
                        isTrue = true;
                    }
                    else if (item == ')' && stack.Pop() == '(')
                    {
                        isTrue = true;
                    }
                    else
                    {
                        isTrue = false;
                        break;
                    }
                }
            }
            if (stack.Count > 0)
            {
                isTrue = false;
            }
            if (isTrue)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
