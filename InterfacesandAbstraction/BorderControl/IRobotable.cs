using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface IRobotable : IIdentiable
    {
        public string Model { get; set; }
    }
}
