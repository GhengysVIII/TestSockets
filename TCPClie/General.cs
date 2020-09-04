using System;
using System.Collections.Generic;
using System.Text;

namespace TCPClie
{
    internal class General
    {
        public ClientTCP client = new ClientTCP();

        public void InitializeClient()
        {
            client.ConnectToServer();
        }
    }
}