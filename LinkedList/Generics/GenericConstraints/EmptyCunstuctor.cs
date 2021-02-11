using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConstraints
{
    class EmptyCunstuctor<T>
        where T : new()
    {
        public EmptyCunstuctor()
        {
            T x = new T();
        }
    }
}
