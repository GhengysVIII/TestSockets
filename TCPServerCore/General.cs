using System;
using System.Collections.Generic;
using System.Text;

namespace TCPServerCore
{
    internal class General
    {
        public ServerTcp server = new ServerTcp();
        public int GetTickCount()
        {
            return Environment.TickCount;
        }
        public void initializeServer()
        {
            int startTime = 0, endTime = 0;
            startTime = GetTickCount();
            Console.WriteLine("Initializing server...");
            // initialize all data arrays

            // start the networking
            Console.WriteLine("Initializing the network...");
            server.initializeNetwork();
            endTime = GetTickCount();

            Console.WriteLine("Initialization complete. Server loaded in {0} ms.", (endTime-startTime));
            
        }
    }
}
