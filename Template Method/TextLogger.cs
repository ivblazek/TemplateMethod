using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Template_Method
{
    class TextLogger : Logger
    {
        public TextLogger(string path)
        {
            this.path = path;
        }

        protected override string WriteText(int severity, string message)
        {
            StringBuilder logMessage = new StringBuilder();
            logMessage.Append("Log: ");
            logMessage.Append(GetSeverity(severity));
            logMessage.Append(", ");
            logMessage.Append(DateTime.Now.ToString());
            logMessage.Append(", ");
            logMessage.Append(message);
            return logMessage.ToString();
        }
    }
}
