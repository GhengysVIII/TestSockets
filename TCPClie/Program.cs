using System;
using System.Threading;
namespace TCPClie
{
    class Program
    {
        private static Thread threadConsole;
        public static General general = new General();
        static void Main(string[] args)
        {
            threadConsole = new Thread(new ThreadStart(ConsoleThread));
            threadConsole.Start();

            general.InitializeClient();
        }

        static void ConsoleThread()
        {
            string line;
            string[] parts;
            Console.WriteLine("Initialize Console Thread...");
            while (true)
            {

            }
        }
    }
}
