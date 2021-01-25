using System;
using System.Collections.Generic;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < input; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int action = int.Parse(command[0]);
                
                if (action == 1 && command.Length > 0)
                {
                    if (stack.Count > 0 )
                    {
                        string word = stack.Peek() + command[1];
                        stack.Push(word);
                    }
                    else
                    {
                        stack.Push(command[1]);
                    }
                    
                }
                else if (action == 2 && int.Parse(command[1]) > 0)
                {
                    int count = int.Parse(command[1]);
                    if (stack.Count > 0)
                    {

                        if (stack.Peek().Length > count)
                        {
                            string word = stack.Peek().Remove(count);
                            stack.Push(word);
                        }
                        else
                        {
                            string word = "";
                            stack.Push(word);
                        }
                    }
                   
                }
                else if (action == 3 && int.Parse(command[1]) > 0)
                {
                    int count = int.Parse(command[1]);
                    if (stack.Count > 0)
                    {


                        if (stack.Peek().Length >= count)
                        {
                            string word = stack.Peek();

                            Console.WriteLine(word.Substring(count - 1, 1));
                        }
                    }
                }
                else if (action == 4)
                {
                    if (stack.Count > 0)
                    {


                        stack.Pop();
                    }
                }
            }
        }
    }
}
