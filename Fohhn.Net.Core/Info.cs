/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace Fohhn.Net.Core
{
    public static class Info
    {
        public static byte[] BuildReadCmd(byte id)
        {
            byte[] data = [Commands.Volume];
            return Command.Encode(id, Commands.ReadInfo, 0, 0, [1]);
        }

        public static bool ParseReadBack(byte[] data, ref ushort device, ref byte[] version)
        {
            if (data.Length == 5)
            {
                device = Convert16.UnsignedWord(data[0], data[1]);
                version = [data[2], data[3], data[4]];
                return true;
            }
            else if (data.Length == 4)
            {
                device = Convert16.UnsignedWord(data[0], data[1]);
                version = [data[2], data[3], 0];
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
