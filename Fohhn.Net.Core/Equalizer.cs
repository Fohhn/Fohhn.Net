/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace Fohhn.Net.Core
{
    public class Equalizer
    {
        public const byte FlagOn = 0x01;

        public static byte[] BuildWriteCmd(byte id, byte channel, byte number, ushort frequency, float q, float gain, int flags)
        {
            short qVal = (short)Math.Round(q * 10.0);
            short gainVal = (short)Math.Round(gain * 10.0);
            byte[] data = [Convert16.Msb(frequency), Convert16.Lsb(frequency), Convert16.Msb(qVal), Convert16.Lsb(qVal), Convert16.Msb(gainVal), Convert16.Lsb(gainVal), (byte)flags];
            return Command.Encode(id, Commands.Equalizer, channel, number, data);
        }

        public static byte[] BuildReadCmd(byte id, byte channel, byte number)
        {
            return Command.Encode(id, Commands.Read, channel, number, [Commands.Equalizer]);
        }

        public static bool ParseReadBack(byte[] data, ref ushort frequency, ref float q, ref float gain, ref int flags)
        {
            if (data.Length != 7)
                return false;

            frequency = Convert16.UnsignedWord(data[0], data[1]);
            q = Convert16.SignedWord(data[2], data[3]) / 10.0f;
            gain = Convert16.SignedWord(data[4], data[5]) / 10.0f;
            flags = data[6];

            return true;
        }
    }
}
