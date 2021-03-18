using Solid.Layout;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Appendance
{
    public abstract class Appender : IAppender
    {
        protected ILayout layout;

        protected Appender(ILayout Layout)
        {
            this.layout = Layout;
        }

        public abstract void Append(string date, string reportLevel, string message);
        
    }
}
