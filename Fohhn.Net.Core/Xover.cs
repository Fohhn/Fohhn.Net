/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace Fohhn.Net.Core
{
    public class Xover
    {
        public const byte FlagOn = 0x01;
        public const byte TypeHighPass = 0x01;
        public const byte TypeLowPass = 0x02;

        public static byte[] BuildWriteCmd(byte id, byte channel, ushort frequency, byte type, int flags)
        {
            byte[] data = [Convert16.Msb(frequency), Convert16.Lsb(frequency), type, (byte)flags];
            return Command.Encode(id, Commands.Xover, channel, type, data);
        }

        public static byte[] BuildReadCmd(byte id, byte channel, byte type)
        {
            return Command.Encode(id, Commands.Read, channel, type, [Commands.Xover]);
        }

        public static bool ParseReadBack(byte[] data, ref ushort frequency, ref int flags)
        {
            if (data.Length != 4)
                return false;

            frequency = Convert16.UnsignedWord(data[0], data[1]);
            flags = data[3];

            return true;
        }
    }
}
