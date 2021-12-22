using System;
using System.Collections.Generic;
using Interfaces;

namespace Assignment1
{
    class Program 
    {
        private static void Main()
        {
            const string message = "Hello, World";

            List<ILogger> loggers = new List<ILogger>();

            // add each one of the classes that implement 'ILogger' to the list
            // 'loggers' for use in the 'foreach' loop

            ILogger colorLogger = new ColorfulConsoleLogger();

            loggers.Add(colorLogger);

            ILogger consoleLogger = new ConsoleLogger();

            loggers.Add(consoleLogger);

            ILogger fileLogger = new FileLogger();

            loggers.Add(fileLogger);

            foreach (ILogger logger in loggers)
            {
                LogMessage(logger, message);
            }

            Console.Write("Press any key to exit. . .");

            Console.ReadKey();
        }

        private static void LogMessage(ILogger logger, string message)
        {
            logger.Log(message);
        }
    }
}
