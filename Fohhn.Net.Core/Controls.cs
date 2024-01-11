/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace Fohhn.Net.Core
{
    public static class Controls
    {
        public static byte[] BuildReadCmd(byte id)
        {
            byte[] data = [Commands.Volume];
            return Command.Encode(id, Commands.ReadControls, 1, 0, [0]);
        }

        public static bool ParseReadBack(byte[] data, ref byte flags, ref float temperature)
        {
            if (data.Length == 4 || data.Length == 5)
            {
                flags = data[0];
                temperature = Convert16.SignedWord(data[1], data[2]) / 10.0f;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
