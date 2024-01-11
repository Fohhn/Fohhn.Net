/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

using System.Text;

namespace Fohhn.Net.Core
{
    public class Speaker
    {
        public const byte ActiveSpeaker = 0;

        public static byte[] BuildLoadCmd(byte id, byte channel, byte speakerNumber)
        {
            return Command.Encode(id, Commands.LoadSpeaker, channel, speakerNumber, [0]);
        }

        public static byte[] BuildReadCmd(byte id, byte channel, byte speakerNumber = ActiveSpeaker)
        {
            return Command.Encode(id, Commands.ReadSpeaker, channel, speakerNumber, [0]);
        }

        public static bool ParseReadBack(byte[] data, ref byte preset, ref string name)
        {
            if (data.Length != 40)
                return false;
            preset = data[20];
            StringBuilder sb = new StringBuilder();
            for (int i = 22; i < 38; i++)
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
