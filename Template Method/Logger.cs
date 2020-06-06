﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    abstract class Logger
    {
        protected string GetSeverity(int severity)
        {
            switch (severity)
            {
                case 0:
                    return "Emergency";
                case 1:
                    return "Alert";
                case 2:
                    return "Critical";
                case 3:
                    return "Error";
                case 4:
                    return "Warning";
                case 5:
                    return "Notice";
                case 6:
                    return "Information";
                case 7:
                    return "Debug";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected abstract string WriteText(int severity, string message);

        public void WriteLog(int severity, string message)
        {
            TextWriter writer = new StreamWriter(path, append: true);
            writer.WriteLine(WriteText(severity, message));
            writer.Close();
        }

        protected string path;
    }
}
