using System;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> items;
        private int index;

        public ListyIterator(List<T> items)
        {
            this.items = items;
            this.index = 0;
        }

        public bool Move()
        {
            bool hasNext = this.HasNext();
            if (this.HasNext())
            {
                this.index++;
            }
            return hasNext;
        }

        public bool HasNext()
        {
            return this.index < this.items.Count - 1;
        }

        public void Print()
        {
            if (this.index >= this.items.Count)
            {
                throw new InvalidOperationException("InvalidOperation!");
            }

            Console.WriteLine(this.items[this.index]);
        }
    }
}
