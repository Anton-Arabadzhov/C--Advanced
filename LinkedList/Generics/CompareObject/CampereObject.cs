using System;
using System.Collections.Generic;
using System.Text;

namespace CompareObject
{
    public class CampereObject<T> : IComparable
        where T : IComparable
    {
        public CampereObject(T value)
        {
            this.Value = value;
        }
        public T Value { get; set; }

        public int CompareTo(object obj)
        {
            CampereObject<T> box = obj as CampereObject<T>;

            int compare = this.Value.CompareTo(box.Value);
            return compare;
        }
        
    }
}
