/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

using Fohhn.Net.Core;
using System.Net;
using System.Net.Sockets;

namespace Fohhn.Net.IP
{
    public class IpNode : Node
    {
        public IpNode(string ipAddress, int port = 2101)
        {
            udpClient = new UdpClient(ipAddress, port);
            udpClient.Client.SendTimeout = 100;
            udpClient.Client.ReceiveTimeout = 500;

            Thread t = new(new ThreadStart(receiveThread))
            {
                IsBackground = true
            };
            t?.Start();
        }

        private readonly UdpClient? udpClient;

        private void receiveThread()
        {
            IPEndPoint local = new IPEndPoint(IPAddress.Any, 0);

            byte[]? receivedBytes = null;

            while (run && udpClient != null)
            {
                try
                {
                    receivedBytes = udpClient.Receive(ref local);
                }
                catch
                {
                    receivedBytes = null;
                }

                if (receivedBytes != null)
                    OnDataReceived(receivedBytes);
            }

            udpClient?.Close();
        }

        public override void Send(byte[] cmd)
        {
            try
            {
                udpClient?.Send(cmd);
            }
            catch { }
        }
    }
}
