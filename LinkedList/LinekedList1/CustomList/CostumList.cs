using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStructure
{
    class CostumList

    {
        private const int initialCapacity = 2;

        private int[] array;

        public CostumList()
        {
            this.array = new int[initialCapacity];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                ValidayteIndex(index);
                return this.array[index];
            }
            set 
            {
                ValidayteIndex(index);
                 
                this.array[index] = value; 
            }
        }

        private void ValidayteIndex(int index)
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("Nema mqsto be");
            }
        }

        public void Add(int number)
        {
            if (this.Count == this.array.Length)
            {
                this.Resize();
            }
            this.array[this.Count] = number;
            this.Count++;
        }

        public bool Contains(int number)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.array[i] == number)
                {
                    return true;
                }
            }
            return false;
        }

       

        public void Swap(int firstIndex, int secondIndex)
        {
            ValidayteIndex(firstIndex);
            ValidayteIndex(secondIndex);

            int firstNum = this.array[firstIndex];
            this.array[firstIndex] = this.array[secondIndex];
            this.array[secondIndex] = firstNum;
        }
        private void Resize()
        {
            int[] copy = new int[this.array.Length * 2];

            for (int i = 0; i < this.array.Length * 2; i++)
            {
                copy[i] = this.array[i];
            }
            this.array = copy;
        }

        public int RemoveAt(int index)
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("Nema mqsto be");
            }

            int number = this.array[index];
            this.array[index] = default(int);
            this.Shift(index);
            this.Count--;

            if (this.Count == this.array.Length / 4)
            {
                this.Shrink();
            }

            return number;
        }

        public void Insert(int index, int number)
        {
            if (index > this.Count)
            {
                throw new ArgumentOutOfRangeException("Nema mqsto");
            }
            if (this.Count == this.array.Length)
            {
                this.Resize();
            }

            this.ShiftRight(index);
            this.array[index] = number;
            Count++;
        }

        private void ShiftRight(int index)
        {
            for (int i = this.Count; i > index; i--)
            {
                this.array[i] = this.array[i - 1];
            }
        }


        private void Shrink()
        {
            int[] copy = new int[this.array.Length / 2];
            Array.Copy(this.array, copy, this.Count);
            this.array = copy;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
            this.array[this.Count - 1] = default;
        }

       
    }
}
