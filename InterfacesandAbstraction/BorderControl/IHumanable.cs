using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface IHumanable : IIdentiable
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
