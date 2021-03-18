using Solid.Layout;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Appendance
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout Layout) 
            : base(Layout)
        {
        }

        public override void Append(string date, string reportLevel, string message)
        {
            string content = string.Format(this.layout.Template, date, reportLevel, message);
            Console.WriteLine(content);
        }
    }
}
