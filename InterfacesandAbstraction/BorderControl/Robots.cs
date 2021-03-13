using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robots : IRobotable
    {
        public Robots(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get ; set ; }
        public string Id { get ; set ; }
    }
}
