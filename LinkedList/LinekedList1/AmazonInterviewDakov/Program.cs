using System;

namespace AmazonInterviewDakov
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftuniLinktListReverse list = new SoftuniLinktListReverse();

            for (int i = 0; i < 10; i++)
            {
                list.AddLast(new Node(i + 1));
            }
            list.Reverse();
            list.ForEach((node) =>
            {
                Console.WriteLine(node.Value);
            });
            list.Reverse();
            list.ForEach((node) =>
            {
                Console.WriteLine(node.Value);
            });
        }
    }
}
