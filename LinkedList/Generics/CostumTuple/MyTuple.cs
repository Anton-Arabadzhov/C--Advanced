using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CostumTuple
{
    public class MyTuple<T1,T2>
        

    {
        public MyTuple(T1 value,T2 value2)
        {
            this.Value = value;
            this.Value2 = value2;
        }
        public T1 Value { get; set; }
        public T2 Value2 { get; set; }

        public override string ToString()
        {
            return $"{this.Value} -> {this.Value2}";
        }
    }
}
