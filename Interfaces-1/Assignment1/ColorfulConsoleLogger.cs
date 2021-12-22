using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ColorfulConsoleLogger : ILogger
    {
        private const Char NewLine = '\n';

        public void Log(string message)
        {
            LogToColor(message);
        }

        public void LogToColor(string message)
        {
            Int32 num = Enum.GetNames(typeof(ConsoleColor)).Length;

            Random rng = new Random(DateTime.UtcNow.Millisecond);

            ConsoleColor original = Console.ForegroundColor;

            foreach (char c in message)
            {
                ConsoleColor newColor;

                do
                {
                    newColor = (ConsoleColor)rng.Next(0, num);
                }
                while (newColor == Console.BackgroundColor);

                Console.ForegroundColor = newColor;

                Console.Write(c);
            }

            Console.Write(NewLine);

            Console.ForegroundColor = original;


        }
    }
}
