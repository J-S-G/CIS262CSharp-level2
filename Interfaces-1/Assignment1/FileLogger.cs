using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class FileLogger : ILogger
    {
        private const string FileNewLine = "\r\n";
        private const string Path = "log.txt";

        public void Log(string message)
        {
            LogToFile(message);
        }

        public void LogToFile(String message)
        {
            File.AppendAllText(Path, message + FileNewLine);
        }

    }
}
