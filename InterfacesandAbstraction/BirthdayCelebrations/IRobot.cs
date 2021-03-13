using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public interface IRobot : IIdentifiable
    {
        string Model { get; }
    }
}
