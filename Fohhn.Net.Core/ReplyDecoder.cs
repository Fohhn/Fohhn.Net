/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace Fohhn.Net.Core
{
    public class ReplyDecoder
    {
        private const byte EndByte = 0xF0;
        private const byte ControlByte = 0xFF;
        private const int MaxDataLen = 256;
        private byte Id;
        private bool ControlByteReceived = false;
        private bool EndByteReceived = false;
        private bool Error = false;
        private readonly List<byte> ReceivedData = new(MaxDataLen + 1);
        private byte[]? DecodedData = null;
        public byte[]? Data { get { return DecodedData; } }

        public ReplyDecoder(byte id)
        {
            Id = id;
        }

        private void DecodeByte(byte d)
        {
            if (ReceivedData.Count > MaxDataLen)
            {
                Error = true;
                return;
            }

            if (EndByteReceived)
            {
                Error = true; // protocol error
            }
            else if (ControlByteReceived)
            {
                ControlByteReceived = false;
                switch (d)
                {
                    case 0x00:
                        ReceivedData.Add(EndByte);
                        break;
                    case 0x01:
                        ReceivedData.Add(ControlByte);
                        break;
                    default:
                        Error = true; // protocol error
                        break;
                }
            }
            else
            {
                switch (d)
                {
                    case ControlByte:
                        ControlByteReceived = true;
                        break;
                    case EndByte:
                        EndByteReceived = true;
                        if (ReceivedData.Count < 1)
                            Error = true;
                        break;
                    default:
                        ReceivedData.Add(d);
                        break;
                }
            }
        }

        public bool DecodeReceivedBytes(byte[] data) // returns true if ready
        {
            if (Error)
                return false;

            foreach (byte d in data)
                DecodeByte(d);

            if (Error)
                return false;

            if (EndByteReceived)
            {
                int count = ReceivedData.Count - 1;
                if (ReceivedData[count] == Id)
                {
                    ReceivedData.RemoveAt(count); // remove id
                    DecodedData = [.. ReceivedData];
                    return true;
                }
                else
                {
                    Error = true; // protocol error
                }
            }

            return false;
        }

    }
}
