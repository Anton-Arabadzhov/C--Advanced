using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonInterviewDakov
{
    class SoftuniLinktListReverse
    {
        private int count = 0;
        private bool reversed = false;
        public Node Head { get; set; }

        public Node Tail { get; set; }

        public void Reverse()
        {
            var temp = Head;
            Head = Tail;
            Tail = temp;
            reversed = !reversed;
        }

        public void AddLast(Node node)
        {
            if (Tail == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            node.Previous = Tail;
            Tail.Next = node;
            Tail = node;
        }

        public void ForEach(Action<Node> action)
        {
            Node currNode = Head;
            while (currNode != null)
            {
                action(currNode);
                if (reversed)
                {

                    currNode = currNode.Previous;
                }
                else
                {
                    currNode = currNode.Next;
                }
               
            }
        }
    }
}
