using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class XmlLogger : Logger
    {
        public XmlLogger (string path)
        {
            this.path = path;
        }

        protected override string WriteText(int severity, string message)
        {
            StringBuilder logMessage = new StringBuilder();
            logMessage.Append("<log type=\"");
            logMessage.Append(GetSeverity(severity));
            logMessage.Append("\" datetime=\"");
            logMessage.Append(DateTime.Now.ToString());
            logMessage.Append("\">");
            logMessage.Append(message);
            logMessage.Append("</log>");
            return logMessage.ToString();
        }
    }
}
