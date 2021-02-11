using System;
using System.Collections.Generic;
using System.Text;

namespace LinekedList1
{
    class SoftuniLinktList
    {
        private int count = 0;
        public Node Head { get; set; }

        public Node Tail { get; set; }

        public int[] ToArray()
        {
            int index = 0;
            int[] array = new int[count];

            ForeachHead((node) =>
            {
                array[index] = node.Value;
                index++;
            });
            return array;

        }

        public void ForeachHead(Action<Node> action)
        {
            Node currNode = Head;
            while (currNode != null)
            {
                action(currNode);
                currNode = currNode.Next;
            }
        }

        public void ForeachTail(Action<Node> action)
        {
            Node currNode = Tail;
            while (currNode != null)
            {
                action(currNode);
                currNode = currNode.Previous;
            }
        }



        public void AddHead(Node node)
        {
            count++;
            if (Head == null)

            {
                Head = node;
                Tail = node;
                return;
            }
            node.Next = Head;
            Head.Previous = node;
            Head = node;

        }
        public void AddLast(Node node)
        {
            count++;
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
        public Node RemoveHead()
        {
            if (Head == null)
            {
                return null;
            }

            count--;

            var nodeToReturn = Head;
            if (Head.Next != null)
            {
                Head = Head.Next;
                Head.Previous = null;
            }
            else
            {
                Head = null;
            }
            return nodeToReturn;
        }

        public Node RemoveTail()
        {
            if (Tail == null)
            {
                return null;
            }

            count--;

            var nodeToReturn = Tail;
            if (Tail.Previous != null)
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }
            else
            {
                Tail = null;
                Head = null;
            }
            return nodeToReturn;
        }
    }
}
