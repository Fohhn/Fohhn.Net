/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

// 16-Bit MSB/LSB converter functions

namespace Fohhn.Net.Core
{
    public static class Convert16
    {
        public static byte Lsb(ushort word)
        {
            return (byte)(word & 0xFF);
        }

        public static byte Msb(ushort word)
        {
            return (byte)((word >> 8) & 0xFF);
        }

        public static byte Lsb(short word)
        {
            return (byte)(word & 0xFF);
        }

        public static byte Msb(short word)
        {
            return (byte)((word >> 8) & 0xFF);
        }

        public static ushort UnsignedWord(byte msb, byte lsb)
        {
            return (ushort)((msb << 8) + lsb);
        }

        public static short SignedWord(byte msb, byte lsb)
        {
            return (short)((msb << 8) + lsb);
        }

    }
}
