/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace Fohhn.Net.Core
{
    public static class Volume
    {
        public const byte FlagOn = 0x01;
        public const byte FlagInv = 0x02;
        public const byte FlagAesInput = 0x10;
        public const byte FlagPlus12 = 0x20;
        public const byte FlagPlus24 = 0x40;
        public const byte FlagPhantomPower = 0x80;

        public static byte[] BuildWriteCmd(byte id, byte channel, float gain, int flags)
        {
            short val = (short)Math.Round(gain * 10.0);
            byte[] data = [Convert16.Msb(val), Convert16.Lsb(val), (byte)flags];
            return Command.Encode(id, Commands.Volume, channel, 1, data);
        }

        public static byte[] BuildReadCmd(byte id, byte channel)
        {
            return Command.Encode(id, Commands.Read, channel, 1, [Commands.Volume]);
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
