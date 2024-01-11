/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace Fohhn.Net.Core
{
    internal static class Commands
    {
        public const byte Delay = 0x86;
        public const byte Dynamic = 0x83;
        public const byte DynamicGain = 0x84;
        public const byte DynamicTime = 0x85;
        public const byte Equalizer = 0x80;
        public const byte Gate = 0x89;
        public const byte GateTime = 0x8A;
        public const byte Light = 0x0D;
        public const byte LoadPreset = 0x05;
        public const byte LoadSpeaker = 0x21;
        public const byte Read = 0x0A;
        public const byte ReadControls = 0x07;
        public const byte ReadInfo = 0x20;
        public const byte ReadPresetName = 0x8E;
        public const byte ReadSpeaker = 0x22;
        public const byte RelativeVolume = 0x96; // not supported on new devices
        public const byte Routing = 0x81;
        public const byte Standby = 0x0C;
        public const byte Volume = 0x87;
        public const byte Xover = 0x82;
    }
}
