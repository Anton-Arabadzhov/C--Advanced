using System;

namespace StackConstruct
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack myStack = new CustomStack();
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);


            myStack.MySelect(e => e * 10);
            myStack.ForEach((element) => Console.WriteLine(element));
            

            
        }
    }
}
