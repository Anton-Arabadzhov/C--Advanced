using Solid.Appendance;
using Solid.ReportLevel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Logger
{
    public class Loggers : ILogger
    {
        private IAppender appender;

        public Loggers(IAppender appender)
        {
            this.appender = appender;
        }
        public void Error(string date, string message)
        {
            this.appender.Append(date, Repo, message);
        }

        public void Info(string date, string message)
        {
            this.appender.Append(date, "Info", message);
        }
    }
}
