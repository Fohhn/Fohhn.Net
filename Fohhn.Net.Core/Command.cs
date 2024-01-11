/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace Fohhn.Net.Core
{
    public static class Command
    {
        private const byte StartByte = 0xF0;
        private const byte ControlByte = 0xFF;

        public const int MinDataLen = 1;
        public const int MaxDataLen = 256;

        public const int MinId = 1;
        public const int MaxId = 254;

        public static byte[] Encode(byte id, byte cmd, byte msb, byte lsb, byte[] data)
        {
            byte len;
            if (data.Length >= MinDataLen && data.Length < MaxDataLen)
            {
                len = (byte)data.Length;
            }
            else if (data.Length == MaxDataLen)
            {
                len = 0;
            }
            else
            {
                throw new Exception("Invalid data length.");
            }
            List<byte> list = [StartByte];
            AddByte(list, id);
            AddByte(list, len);
            AddByte(list, cmd);
            AddByte(list, msb);
            AddByte(list, lsb);
            for (int i = 0; i < len; i++)
                AddByte(list, data[i]);
            return [.. list];
        }

        private static void AddByte(List<byte> list, byte d)
        {
            if (d == StartByte)
            {
                list.Add(ControlByte);
                list.Add(0x00);
            }
            else if (d == ControlByte)
            {
                list.Add(ControlByte);
                list.Add(0x01);
            }
            else
            {
                list.Add(d);
            }
        }
    }
}
