/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

using System.Text;

namespace Fohhn.Net.Core
{
    public class Preset
    {
        public const byte ActivePreset = 0;

        public static byte[] BuildLoadCmd(byte id, byte preset)
        {
            return Command.Encode(id, Commands.LoadPreset, 1, preset, [0]);
        }

        public static byte[] BuildReadCmd(byte id, byte preset = ActivePreset)
        {
            return Command.Encode(id, Commands.ReadPresetName, 1, preset, [0]);
        }

        public static bool ParseReadBack(byte[] data, ref byte preset, ref string name)
        {
            if (data.Length != 20)
                return false;
            preset = data[0];
            StringBuilder sb = new StringBuilder();
            for (int i = 2; i < 18; i++)
            {
                if (data[i] >= 0x28 && data[i] <= 0x7A)
                    sb.Append((char)data[i]);
                else
                    sb.Append(' ');
            }
            name = sb.ToString().Trim();
            return true;
        }
    }
}
