using System;
using System.Threading;

namespace TCPServerCore
{
    internal class Program
    {
        private static Thread threadConsole;
        private static General general = new General();

        private static void Main(string[] args)
        {
            threadConsole = new Thread(new ThreadStart(ConsoleThread));
            threadConsole.Start();
            general.initializeServer();
        }

        private static void ConsoleThread()
        {
            string line;
            string[] parts;
            Console.WriteLine("Initialize Console Thread...");
        }
    }
}