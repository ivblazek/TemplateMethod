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
                
        protected override void CreateLogText(int severity, string message)
        {
            logWriter.Write("Log: ");
            logWriter.Write(GetSeverity(severity));
            logWriter.Write(", ");
            logWriter.Write(DateTime.Now.ToString());
            logWriter.Write(", ");
            logWriter.Write(message);
        }
    }
}
