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
        protected override void OpenFile()
        {
            fileWriter = new StreamWriter("log.xml", append: true);
        }

        protected override void CreateLogText(int severity, string message)
        {
            logWriter.Write("<log type=\"");
            logWriter.Write(GetSeverity(severity));
            logWriter.Write("\" datetime=\"");
            logWriter.Write(DateTime.Now.ToString());
            logWriter.Write("\">");
            logWriter.Write(message);
            logWriter.Write("</log>");            
        }

        protected override void WriteToFile()
        {
            fileWriter.WriteLine(logWriter);
        }

        protected override void CloseFile()
        {
            fileWriter.Close();
        }

        TextWriter fileWriter;
    }
}
