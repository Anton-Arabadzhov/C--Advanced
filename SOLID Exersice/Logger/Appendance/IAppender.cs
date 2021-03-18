using System;
using System.Collections.Generic;
using System.Text;
using Solid.ReportLevel;

namespace Solid.Appendance
{
    public interface IAppender
    {
        void Append(string date, ReportLevels reportLevel, string message);
    }
}
