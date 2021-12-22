using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class ConsoleLogger : ILogger
    {
        public void LogToConsole(String message)
        {
            Console.WriteLine(message);
        }

        void ILogger.Log(string message)
        {
            LogToConsole(message);
        }
    }
}
