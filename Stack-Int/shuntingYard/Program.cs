using System;
using System.Collections.Generic;
using System.Linq;

namespace shuntingYard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RPNCalculator(ShuntingYard(Console.ReadLine())));

        }
        static string RPNCalculator(string input)
        {
            string[] expression = input.Split(' ').Reverse().ToArray();
            Stack<string> stack = new Stack<string>(expression);



            while (stack.Count > 2)
            {
                List<string> elements = new List<string>();
                var currentElement = stack.Pop();
                while (!IsOperator(currentElement))
                {
                    elements.Add(currentElement);
                    currentElement = stack.Pop();
                }
                int first = int.Parse(elements[elements.Count - 2]);
                int second = int.Parse(elements[elements.Count - 1]);

                int result = PerformOperation(currentElement, first, second);

                for (int i = elements.Count - 3; i >= 0; i--)
                {
                    stack.Push(elements[i]);
                }
                stack.Push(result.ToString());
            }
            return stack.Pop();

        }

        static string ShuntingYard(string input)
        {
            string[] expression = input.Split();
            //3 + 4 * 2 / ( 1 - 5 )
            Stack<string> operatorStack = new Stack<string>();
            string output = "";

            for (int i = 0; i < expression.Length; i++)
            {
                if (IsOperator(expression[i]))
                {
                    if (operatorStack.Count > 0)
                    {
                        var OldElementArity = OperatorPrecendence(operatorStack.Peek());
                        var elementArity = OperatorPrecendence(expression[i]);

                        if (OldElementArity >= elementArity)
                        {
                            output += operatorStack.Pop() + " ";
                        }
                    }
                    operatorStack.Push(expression[i]);

                }
                else if (expression[i] == "(")
                {
                    operatorStack.Push(expression[i]);
                }
                else if (expression[i] == ")")
                {
                    while (operatorStack.Peek() != "(")
                    {
                        output += operatorStack.Pop() + " ";
                    }
                    operatorStack.Pop();
                }
                else
                {
                    output += expression[i] + " ";
                }
            }
            while (operatorStack.Count > 0)
            {
                output += operatorStack.Pop() + " ";
            }
            return output;
        }

        static int OperatorPrecendence(string input)
        {
            switch (input)
            {
                case "+":
                    return 2;
                case "-":
                    return 2;
                case "/":
                    return 3;
                case "*":
                    return 3;
                case "(":
                    return 1;
                default:
                    break;
            }
            throw new ArgumentException();
        }

        private static int PerformOperation(string currentElement, int first, int second)
        {
            switch (currentElement)
            {
                case "+":
                    return first + second;
                case "-":
                    return first - second;
                case "/":
                    return first / second;
                case "*":
                    return first * second;

                default:
                    break;
            }
            throw new ArgumentException();
        }
        static bool IsOperator(string input)
        {
            switch (input)
            {
                case "+":
                    return true;
                case "-":
                    return true;
                case "/":
                    return true;
                case "*":
                    return true;

                default:
                    break;
            }
            return false;

        }
    }
}
