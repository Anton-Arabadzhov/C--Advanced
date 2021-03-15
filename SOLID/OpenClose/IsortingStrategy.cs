using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose
{
    public interface IsortingStrategy
    {
        List<int> Sort(List<int> list);
    }
}
