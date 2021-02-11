using System;
using System.Collections.Generic;

namespace LinekedList1
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftuniLinktList linkedList = new SoftuniLinktList();


            for (int i = 0; i <= 10; i++)
            {
                linkedList.AddLast(new Node(i));
            }

            

            Console.WriteLine("Remove head: " + linkedList.RemoveHead().Value);
            Console.WriteLine("Remove head: " + linkedList.RemoveHead().Value);
            Console.WriteLine("Remove head: " + linkedList.RemoveHead().Value);

            
            Console.WriteLine("Remove Tail: " + linkedList.RemoveTail().Value);
            Console.WriteLine("Remove Tail: " + linkedList.RemoveTail().Value);
            Console.WriteLine("Remove Tail: " + linkedList.RemoveTail().Value);

            var currNote = linkedList.Tail;

            Console.WriteLine("Foreach from head:");
            linkedList.ForeachHead((node) =>
            {
                Console.WriteLine($"From action: {node.Value}");
            });
            Console.WriteLine("Foreach from Tail:");
            linkedList.ForeachTail((node) =>
            {
                Console.WriteLine($"From action: {node.Value}");
            });


            int[] linketListToArray = linkedList.ToArray();
        }
    }
}
