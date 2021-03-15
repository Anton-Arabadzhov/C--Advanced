using System;
using System.Collections.Generic;
using System.Text;

namespace Virus
{
    public class File : IProgresable
    {
        public string Name { get; set; }

        public int Length { get; set; }

        public int Sent { get; set; }
    }
}
