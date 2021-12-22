using System;
using System.Threading;

namespace Assignment02.MutualExclusion
{
    class Program
    {

        static object _lock = new object();

        static void Main()
        {
            Thread thread1 = new Thread(() => Write("+"));

            Thread thread2 = new Thread(() => Write("-"));

            thread1.Start();

            thread2.Start();

            thread1.Join();

            thread2.Join();
        }

        static void Write(string message)
        {
            Monitor.Enter(_lock);

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(message);
            }

            Monitor.Exit(_lock);
        }
    }
}
