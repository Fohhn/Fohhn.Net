/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace Fohhn.Net.Core
{
    public class Delay
    {
        public const byte FlagOn = 0x01;

        public static byte[] BuildWriteCmd(byte id, byte channel, float time, int flags)
        {
            ushort val = (ushort)Math.Round(time * 100.0);
            byte[] data = [Convert16.Msb(val), Convert16.Lsb(val), (byte)flags];
            return Command.Encode(id, Commands.Delay, channel, 1, data);
        }

        public static byte[] BuildReadCmd(byte id, byte channel)
        {
            return Command.Encode(id, Commands.Read, channel, 1, [Commands.Delay]);
        }

        public static bool ParseReadBack(byte[] data, ref float time, ref int flags)
        {
            if (data.Length != 3)
                return false;

            time = Convert16.UnsignedWord(data[0], data[1]) / 100.0f;
            flags = data[2];

            return true;
        }
    }
}
