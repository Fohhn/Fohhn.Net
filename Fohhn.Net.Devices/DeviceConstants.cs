/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace Fohhn.Net.Devices
{
    public static class DeviceConstants
    {
        public const ushort MaskDevice = 0xFFF0; // 12 Bit Fohhn Device 
        public const ushort MaskHw = 0x000F;  // 4 Bit HW-Version

        public const ushort DeviceBootloader = 0x0000; // bootloader
        public const ushort DeviceFailsave = 0xFFFF; // incomplete firmware update
        public const ushort DeviceA22100 = 0x0230 & MaskDevice;
        public const ushort DeviceAAX2300 = 0x0B10 & MaskDevice;
        public const ushort DeviceAM10 = 0x0B50 & MaskDevice;
        public const ushort DeviceAM20 = 0x0B40 & MaskDevice;
        public const ushort DeviceAM44ANA = 0x0BC0 & MaskDevice;
        public const ushort DeviceAM44DAN = 0x0BD0 & MaskDevice;
        public const ushort DeviceAM40 = 0x0B30 & MaskDevice;
        public const ushort DeviceAM50 = 0x0B60 & MaskDevice;
        public const ushort DeviceAS06ASX = 0x0BA0 & MaskDevice;
        public const ushort DeviceAS10ASX = 0x0B90 & MaskDevice;
        public const ushort DeviceAS206 = 0x0E00 & MaskDevice;
        public const ushort DeviceAS112 = 0x0E10 & MaskDevice;
        public const ushort DeviceAS115 = 0x0E20 & MaskDevice;
        public const ushort DeviceAS22ASX = 0x0B80 & MaskDevice;
        public const ushort DeviceAT35a = 0x0600 & MaskDevice;
        public const ushort DeviceAT40a = 0x0610 & MaskDevice;
        public const ushort DeviceAT50a = 0x0620 & MaskDevice;
        public const ushort DeviceCVB = 0x0640 & MaskDevice;
        public const ushort DeviceD21500 = 0x0330 & MaskDevice;
        public const ushort DeviceD2750 = 0x0300 & MaskDevice;
        public const ushort DeviceD41200 = 0x0321 & MaskDevice;
        public const ushort DeviceD4750 = 0x0310 & MaskDevice;
        public const ushort DeviceDFM100 = 0x0AB1 & MaskDevice;
        public const ushort DeviceDFM110 = 0x0AC1 & MaskDevice;
        public const ushort DeviceDFM400 = 0x0AD1 & MaskDevice;
        public const ushort DeviceDI22000 = 0x0C01 & MaskDevice;
        public const ushort DeviceDI24000 = 0x0C31 & MaskDevice;
        public const ushort DeviceDI41000 = 0x0C11 & MaskDevice;
        public const ushort DeviceDI42000 = 0x0C21 & MaskDevice;
        public const ushort DeviceDLI130 = 0x0D20 & MaskDevice;
        public const ushort DeviceDLI230 = 0x0D30 & MaskDevice;
        public const ushort DeviceDLI330 = 0x0D40 & MaskDevice;
        public const ushort DeviceDLI430 = 0x0D50 & MaskDevice;
        public const ushort DeviceFC8 = 0x0400 & MaskDevice;
        public const ushort DeviceFC9 = 0x0410 & MaskDevice;
        public const ushort DeviceFM100 = 0x0A01 & MaskDevice;
        public const ushort DeviceFM110 = 0x0A11 & MaskDevice;
        public const ushort DeviceFM400 = 0x0A41 & MaskDevice;
        public const ushort DeviceFMI100 = 0x0A21 & MaskDevice;
        public const ushort DeviceFMI110 = 0x0A31 & MaskDevice;
        public const ushort DeviceFMI400 = 0x0A61 & MaskDevice;
        public const ushort DeviceFR10 = 0x0810 & MaskDevice;
        public const ushort DeviceFR20 = 0x0820 & MaskDevice;
        public const ushort DeviceFR21 = 0x0880 & MaskDevice;
        public const ushort DeviceFS110 = 0x0D90 & MaskDevice;
        public const ushort DeviceFS150 = 0x0DA0 & MaskDevice;
        public const ushort DeviceFS220 = 0x0DB0 & MaskDevice;
        public const ushort DeviceFS70 = 0x0DC0 & MaskDevice;
        public const ushort DeviceFSC1 = 0x1200 & MaskDevice;
        public const ushort DeviceFV100 = 0x0A80 & MaskDevice;
        public const ushort DeviceFV200 = 0x0A90 & MaskDevice;
        public const ushort DeviceHybrid1 = 0x0630 & MaskDevice;
        public const ushort DeviceLF120 = 0x0701 & MaskDevice;
        public const ushort DeviceLF220 = 0x0711 & MaskDevice;
        public const ushort DeviceLFI120 = 0x0721 & MaskDevice;
        public const ushort DeviceLFI220 = 0x0731 & MaskDevice;
        public const ushort DeviceLFI350 = 0x0740 & MaskDevice;
        public const ushort DeviceLFI450 = 0x0750 & MaskDevice;
        public const ushort DeviceLX10ASX = 0x0B00 & MaskDevice;
        public const ushort DeviceLX20ASX = 0x0B20 & MaskDevice;
        public const ushort DeviceLX60ASX = 0x0B70 & MaskDevice;
        public const ushort DeviceMA21200 = 0x0CC0 & MaskDevice;
        public const ushort DeviceMA21200ANA = 0x0C80 & MaskDevice;
        public const ushort DeviceMA21200DAN = 0x0C90 & MaskDevice;
        public const ushort DeviceMA4100 = 0x0CA0 & MaskDevice;
        public const ushort DeviceMA4100ANA = 0x0C40 & MaskDevice;
        public const ushort DeviceMA4100DAN = 0x0C50 & MaskDevice;
        public const ushort DeviceMA4600 = 0x0CB0 & MaskDevice;
        public const ushort DeviceMA4600ANA = 0x0C60 & MaskDevice;
        public const ushort DeviceMA4600DAN = 0x0C70 & MaskDevice;
        public const ushort DeviceNA3 = 0x0850 & MaskDevice;
        public const ushort DevicePS9 = 0x0900 & MaskDevice;
        public const ushort DeviceScale1PoE = 0x0F10 & MaskDevice;
        public const ushort DeviceSL20PoE = 0x0F20 & MaskDevice;
        public const ushort DeviceX16 = 0x0420 & MaskDevice;
        public const ushort DeviceXS10a = 0x0130 & MaskDevice;
        public const ushort DeviceXS20a = 0x0120 & MaskDevice;
        public const ushort DeviceXS22 = 0x0150 & MaskDevice;
        public const ushort DeviceXS30a = 0x0110 & MaskDevice;
        public const ushort DeviceXS4a = 0x0100 & MaskDevice;
        public const ushort DeviceXT33a = 0x0500 & MaskDevice;
        public const ushort DeviceXT4a = 0x0510 & MaskDevice;
        public const ushort DeviceXT5a = 0x0520 & MaskDevice;
    }
}
