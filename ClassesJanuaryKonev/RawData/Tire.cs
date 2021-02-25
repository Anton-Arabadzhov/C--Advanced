using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        public double Pressure { get; set; }

        public int Age { get; set; }

        public Tire(double presure, int age)
        {
            this.Pressure = presure;
            this.Age = age;
        }
    }
}
