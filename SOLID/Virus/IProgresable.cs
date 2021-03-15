using System;
using System.Collections.Generic;
using System.Text;

namespace Virus
{
    public interface IProgresable
    {
        int Length { get; }

        int Sent { get; }
    }
}
