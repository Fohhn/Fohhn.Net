/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace Fohhn.Net.Core
{
    public class Routing
    {
        public const byte FlagOn = 0x01;
        public const byte FlagInv = 0x02;

        public static byte[] BuildWriteCmd(byte id, byte channel, byte input, float gain, int flags)
        {
            short val = (short)Math.Round(gain * 10.0);
            byte[] data = [Convert16.Msb(val), Convert16.Lsb(val), (byte)flags];
            return Command.Encode(id, Commands.Routing, channel, input, data);
        }

        public static byte[] BuildReadCmd(byte id, byte channel, byte input)
        {
            return Command.Encode(id, Commands.Read, channel, input, [Commands.Routing]);
        }

        public static bool ParseReadBack(byte[] data, ref float gain, ref int flags)
        {
            if (data.Length != 3)
                return false;

            gain = Convert16.SignedWord(data[0], data[1]) / 10.0f;
            flags = data[2];

            return true;
        }
    }
}
