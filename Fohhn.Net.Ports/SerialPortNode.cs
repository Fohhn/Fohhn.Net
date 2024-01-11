/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

using Fohhn.Net.Core;
using System.IO.Ports;

namespace Fohhn.Net.Ports
{
    public class SerialPortNode : Node
    {
        public SerialPortNode(string portName, int baudRate)
        {
            serialPort = new SerialPort(portName, baudRate);
            serialPort.DataReceived += SerialPort_DataReceived;
            serialPort.Open();
        }

        public const int B19200 = 19200;
        public const int B115200 = 115200;

        SerialPort? serialPort = null;

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort != null)
            {
                int len = serialPort.BytesToRead;
                byte[] receivedBytes = new byte[len];
                serialPort.Read(receivedBytes, 0, len);
                OnDataReceived(receivedBytes);
            }
        }

        public override void Send(byte[] cmd)
        {
            try
            {
                serialPort?.Write(cmd, 0, cmd.Length);
            }
            catch { }
        }

        public override void Close()
        {
            base.Close();
            serialPort?.Close();
        }
    }
}
