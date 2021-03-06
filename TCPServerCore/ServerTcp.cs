﻿using System;
using System.Net;
using System.Net.Sockets;

namespace TCPServerCore
{
    internal class ServerTcp
    {
        private TcpListener _serverSocket;

        public void initializeNetwork()
        {
            _serverSocket = new TcpListener(IPAddress.Any, 5555);
            _serverSocket.Start();
            _serverSocket.BeginAcceptTcpClient(OnClientConnect, null);
        }

        private void OnClientConnect(IAsyncResult result)
        {
            TcpClient client = _serverSocket.EndAcceptTcpClient(result);
            _serverSocket.BeginAcceptTcpClient(OnClientConnect, null);
            Console.WriteLine("Connection recieved from {0}", client.Client.RemoteEndPoint.ToString());
            //_serverSocket.BeginAcceptTcpClient(OnClientConnect, null);
        }

        //Socket _socket = new Socket(SocketType.Stream,ProtocolType.Tcp);
    }
}