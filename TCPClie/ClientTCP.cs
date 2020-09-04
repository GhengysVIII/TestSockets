using System;
using System.Net.Sockets;

namespace TCPClie
{
    internal class ClientTCP
    {
        public TcpClient playerSocket;
        private Byte[] asyncBuffer;

        public void ConnectToServer()
        {
            playerSocket = new TcpClient();
            playerSocket.ReceiveBufferSize = 4096;
            playerSocket.SendBufferSize = 4096;

            asyncBuffer = new Byte[playerSocket.ReceiveBufferSize + playerSocket.SendBufferSize];
            playerSocket.BeginConnect("127.0.0.1", 5555, new AsyncCallback(ConnectCallback), playerSocket);
        }

        private void ConnectCallback(IAsyncResult result)
        {
            try
            {
                playerSocket.EndConnect(result);
                if (playerSocket.Connected == false)
                {
                    Console.WriteLine("Cannot Connect to the server");
                    return;
                }
                else
                {
                    Console.WriteLine("Succesfully connected to the server!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot connect to the server");
            }
        }
    }
}