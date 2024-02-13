/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace Fohhn.Net.Devices
{
    public static class DeviceLookup
    {
        public static string GetDeviceString(ushort device)
        {
            switch (device & DeviceConstants.MaskDevice)
            {
                case DeviceConstants.DeviceBootloader: return "Bootloader";
                case DeviceConstants.DeviceFailsave: return "Failsave";
                case DeviceConstants.DeviceA22100: return "A-2.2100";
                case DeviceConstants.DeviceAAX2300: return "AAX-2.300";
                case DeviceConstants.DeviceAM10: return "AM-10";
                case DeviceConstants.DeviceAM20: return "AM-20";
                case DeviceConstants.DeviceAM44ANA: return "AM-4.4 ANA";
                case DeviceConstants.DeviceAM44DAN: return "AM-4.4 DAN";
                case DeviceConstants.DeviceAM40: return "AM-40";
                case DeviceConstants.DeviceAM50: return "AM-50";
                case DeviceConstants.DeviceAS06ASX: return "AS-06 ASX";
                case DeviceConstants.DeviceAS10ASX: return "AX-10 ASX";
                case DeviceConstants.DeviceAS206: return "AS-206";
                case DeviceConstants.DeviceAS112: return "AS-112";
                case DeviceConstants.DeviceAS115: return "AS-115";
                case DeviceConstants.DeviceAS22ASX: return "AS-22 ASX";
                case DeviceConstants.DeviceAT35a: return "AT-35a";
                case DeviceConstants.DeviceAT40a: return "AT-40a";
                case DeviceConstants.DeviceAT50a: return "AT-50a";
                case DeviceConstants.DeviceCVB: return "CVB";
                case DeviceConstants.DeviceD21500: return "D-2.1500";
                case DeviceConstants.DeviceD2750: return "D-2.750";
                case DeviceConstants.DeviceD41200: return "D-4.1200";
                case DeviceConstants.DeviceD4750: return "D-4.750";
                case DeviceConstants.DeviceDFM100: return "FM-100";
                case DeviceConstants.DeviceDFM110: return "FM-110";
                case DeviceConstants.DeviceDFM400: return "FM-400";
                case DeviceConstants.DeviceDI22000: return "DI-2.2000";
                case DeviceConstants.DeviceDI24000: return "DI-2.4000";
                case DeviceConstants.DeviceDI41000: return "DI-4.1000";
                case DeviceConstants.DeviceDI42000: return "DI-4.2000";
                case DeviceConstants.DeviceDLI130: return "DLI-130";
                case DeviceConstants.DeviceDLI230: return "DLI-230";
                case DeviceConstants.DeviceDLI330: return "DLI-330";
                case DeviceConstants.DeviceDLI430: return "DLI-430";
                case DeviceConstants.DeviceFC8: return "FC-8";
                case DeviceConstants.DeviceFC9: return "FC-9";
                case DeviceConstants.DeviceFM100: return "FM-100";
                case DeviceConstants.DeviceFM110: return "FM-110";
                case DeviceConstants.DeviceFM400: return "FM-400";
                case DeviceConstants.DeviceFMI100: return "FMI-100";
                case DeviceConstants.DeviceFMI110: return "FMI-110";
                case DeviceConstants.DeviceFMI400: return "FMI-400";
                case DeviceConstants.DeviceFR10: return "FR-10";
                case DeviceConstants.DeviceFR20: return "FR-20";
                case DeviceConstants.DeviceFR21: return "FR-21";
                case DeviceConstants.DeviceFS110: return "FS-110";
                case DeviceConstants.DeviceFS150: return "FS-150";
                case DeviceConstants.DeviceFS220: return "FS-220";
                case DeviceConstants.DeviceFS70: return "FS-70";
                case DeviceConstants.DeviceFSC1: return "FSC-1";
                case DeviceConstants.DeviceFV100: return "FV-100";
                case DeviceConstants.DeviceFV200: return "FV-200";
                case DeviceConstants.DeviceHybrid1: return "Hybrid-1";
                case DeviceConstants.DeviceLF120: return "LF-120";
                case DeviceConstants.DeviceLF220: return "LF-220";
                case DeviceConstants.DeviceLFI120: return "LFI-120";
                case DeviceConstants.DeviceLFI220: return "LFI-220";
                case DeviceConstants.DeviceLFI350: return "LFI-350";
                case DeviceConstants.DeviceLFI450: return "LFI-450";
                case DeviceConstants.DeviceLX10ASX: return "LX-10 ASX";
                case DeviceConstants.DeviceLX20ASX: return "LX-20 ASX";
                case DeviceConstants.DeviceLX60ASX: return "LX-60 ASX";
                case DeviceConstants.DeviceMA21200: return "MA-2.1200";
                case DeviceConstants.DeviceMA21200ANA: return "MA-2.1200 ANA";
                case DeviceConstants.DeviceMA21200DAN: return "MA-2.1200 DAN";
                case DeviceConstants.DeviceMA4100: return "MA-4.100";
                case DeviceConstants.DeviceMA4100ANA: return "MA-4.100 ANA";
                case DeviceConstants.DeviceMA4100DAN: return "MA-4.100 DAN";
                case DeviceConstants.DeviceMA4600: return "MA-4.600";
                case DeviceConstants.DeviceMA4600ANA: return "MA-4.600 ANA";
                case DeviceConstants.DeviceMA4600DAN: return "MA-4.600 DAN";
                case DeviceConstants.DeviceNA3: return "NA-3";
                case DeviceConstants.DevicePS9: return "PS-9";
                case DeviceConstants.DeviceScale1PoE: return "Scale-1 PoE";
                case DeviceConstants.DeviceSL20PoE: return "SL-20 PoE";
                case DeviceConstants.DeviceX16: return "X-16";
                case DeviceConstants.DeviceXS10a: return "XS-10";
                case DeviceConstants.DeviceXS20a: return "XS-20";
                case DeviceConstants.DeviceXS22: return "XS-22";
                case DeviceConstants.DeviceXS30a: return "XS-30";
                case DeviceConstants.DeviceXS4a: return "XS-4";
                case DeviceConstants.DeviceXT33a: return "XT-33 active";
                case DeviceConstants.DeviceXT4a: return "XT-4 active";
                case DeviceConstants.DeviceXT5a: return "XT-5 active";
                default: return "Unknown";
            }
        }

        public static byte GetNumberOfOutputChannels(ushort device)
        {
            switch (device & DeviceConstants.MaskDevice)
            {
                case DeviceConstants.DeviceA22100: return 2;
                case DeviceConstants.DeviceAAX2300: return 2;
                case DeviceConstants.DeviceAM10: return 0;
                case DeviceConstants.DeviceAM20: return 0;
                case DeviceConstants.DeviceAM44ANA: return 8;
                case DeviceConstants.DeviceAM44DAN: return 8;
                case DeviceConstants.DeviceAM40: return 0;
                case DeviceConstants.DeviceAM50: return 0;
                case DeviceConstants.DeviceAS06ASX: return 1;
                case DeviceConstants.DeviceAS10ASX: return 1;
                case DeviceConstants.DeviceAS206: return 1;
                case DeviceConstants.DeviceAS112: return 1;
                case DeviceConstants.DeviceAS115: return 1;
                case DeviceConstants.DeviceAS22ASX: return 1;
                case DeviceConstants.DeviceAT35a: return 2;
                case DeviceConstants.DeviceAT40a: return 2;
                case DeviceConstants.DeviceAT50a: return 2;
                case DeviceConstants.DeviceCVB: return 2;
                case DeviceConstants.DeviceD21500: return 2;
                case DeviceConstants.DeviceD2750: return 2;
                case DeviceConstants.DeviceD41200: return 6;
                case DeviceConstants.DeviceD4750: return 6;
                case DeviceConstants.DeviceDFM100: return 1;
                case DeviceConstants.DeviceDFM110: return 1;
                case DeviceConstants.DeviceDFM400: return 1;
                case DeviceConstants.DeviceDI22000: return 2;
                case DeviceConstants.DeviceDI24000: return 2;
                case DeviceConstants.DeviceDI41000: return 4;
                case DeviceConstants.DeviceDI42000: return 4;
                case DeviceConstants.DeviceDLI130: return 1;
                case DeviceConstants.DeviceDLI230: return 1;
                case DeviceConstants.DeviceDLI330: return 1;
                case DeviceConstants.DeviceDLI430: return 1;
                case DeviceConstants.DeviceFC8: return 6;
                case DeviceConstants.DeviceFC9: return 6;
                case DeviceConstants.DeviceFM100: return 1;
                case DeviceConstants.DeviceFM110: return 1;
                case DeviceConstants.DeviceFM400: return 1;
                case DeviceConstants.DeviceFMI100: return 1;
                case DeviceConstants.DeviceFMI110: return 1;
                case DeviceConstants.DeviceFMI400: return 1;
                case DeviceConstants.DeviceFS110: return 1;
                case DeviceConstants.DeviceFS150: return 1;
                case DeviceConstants.DeviceFS220: return 1;
                case DeviceConstants.DeviceFS70: return 1;
                case DeviceConstants.DeviceFSC1: return 8;
                case DeviceConstants.DeviceFV100: return 1;
                case DeviceConstants.DeviceFV200: return 1;
                case DeviceConstants.DeviceHybrid1: return 2;
                case DeviceConstants.DeviceLF120: return 1;
                case DeviceConstants.DeviceLF220: return 1;
                case DeviceConstants.DeviceLFI120: return 1;
                case DeviceConstants.DeviceLFI220: return 1;
                case DeviceConstants.DeviceLFI350: return 1;
                case DeviceConstants.DeviceLFI450: return 1;
                case DeviceConstants.DeviceLX10ASX: return 1;
                case DeviceConstants.DeviceLX20ASX: return 1;
                case DeviceConstants.DeviceLX60ASX: return 1;
                case DeviceConstants.DeviceMA21200: return 4;
                case DeviceConstants.DeviceMA21200ANA: return 4;
                case DeviceConstants.DeviceMA21200DAN: return 4;
                case DeviceConstants.DeviceMA4100: return 4;
                case DeviceConstants.DeviceMA4100ANA: return 4;
                case DeviceConstants.DeviceMA4100DAN: return 4;
                case DeviceConstants.DeviceMA4600: return 4;
                case DeviceConstants.DeviceMA4600ANA: return 4;
                case DeviceConstants.DeviceMA4600DAN: return 4;
                case DeviceConstants.DevicePS9: return 1;
                case DeviceConstants.DeviceScale1PoE: return 1;
                case DeviceConstants.DeviceSL20PoE: return 1;
                case DeviceConstants.DeviceX16: return 16;
                case DeviceConstants.DeviceXS10a: return 2;
                case DeviceConstants.DeviceXS20a: return 2;
                case DeviceConstants.DeviceXS22: return 2;
                case DeviceConstants.DeviceXS30a: return 2;
                case DeviceConstants.DeviceXS4a: return 2;
                case DeviceConstants.DeviceXT33a: return 2;
                case DeviceConstants.DeviceXT4a: return 2;
                case DeviceConstants.DeviceXT5a: return 2;

                default: return 0;
            }

        }

        public static byte GetNumberOfInputChannels(ushort device) // number of input channels with dsp functions
        {
            switch (device & DeviceConstants.MaskDevice)
            {
                case DeviceConstants.DeviceA22100: return 0;
                case DeviceConstants.DeviceAAX2300: return 0;
                case DeviceConstants.DeviceAM10: return 0;
                case DeviceConstants.DeviceAM20: return 0;
                case DeviceConstants.DeviceAM44ANA: return 8;
                case DeviceConstants.DeviceAM44DAN: return 8;
                case DeviceConstants.DeviceAM40: return 0;
                case DeviceConstants.DeviceAM50: return 0;
                case DeviceConstants.DeviceAS06ASX: return 0;
                case DeviceConstants.DeviceAS10ASX: return 0;
                case DeviceConstants.DeviceAS206: return 2;
                case DeviceConstants.DeviceAS112: return 2;
                case DeviceConstants.DeviceAS115: return 2;
                case DeviceConstants.DeviceAS22ASX: return 0;
                case DeviceConstants.DeviceAT35a: return 0;
                case DeviceConstants.DeviceAT40a: return 0;
                case DeviceConstants.DeviceAT50a: return 0;
                case DeviceConstants.DeviceCVB: return 2;
                case DeviceConstants.DeviceD21500: return 0;
                case DeviceConstants.DeviceD2750: return 0;
                case DeviceConstants.DeviceD41200: return 0;
                case DeviceConstants.DeviceD4750: return 0;
                case DeviceConstants.DeviceDFM100: return 0;
                case DeviceConstants.DeviceDFM110: return 0;
                case DeviceConstants.DeviceDFM400: return 0;
                case DeviceConstants.DeviceDI22000: return 0;
                case DeviceConstants.DeviceDI24000: return 0;
                case DeviceConstants.DeviceDI41000: return 0;
                case DeviceConstants.DeviceDI42000: return 0;
                case DeviceConstants.DeviceDLI130: return 2;
                case DeviceConstants.DeviceDLI230: return 2;
                case DeviceConstants.DeviceDLI330: return 2;
                case DeviceConstants.DeviceDLI430: return 2;
                case DeviceConstants.DeviceFC8: return 0;
                case DeviceConstants.DeviceFC9: return 0;
                case DeviceConstants.DeviceFM100: return 0;
                case DeviceConstants.DeviceFM110: return 0;
                case DeviceConstants.DeviceFM400: return 0;
                case DeviceConstants.DeviceFMI100: return 0;
                case DeviceConstants.DeviceFMI110: return 0;
                case DeviceConstants.DeviceFMI400: return 0;
                case DeviceConstants.DeviceFS110: return 2;
                case DeviceConstants.DeviceFS150: return 2;
                case DeviceConstants.DeviceFS220: return 2;
                case DeviceConstants.DeviceFS70: return 2;
                case DeviceConstants.DeviceFSC1: return 8;
                case DeviceConstants.DeviceFV100: return 2;
                case DeviceConstants.DeviceFV200: return 2;
                case DeviceConstants.DeviceHybrid1: return 2;
                case DeviceConstants.DeviceLF120: return 0;
                case DeviceConstants.DeviceLF220: return 0;
                case DeviceConstants.DeviceLFI120: return 0;
                case DeviceConstants.DeviceLFI220: return 0;
                case DeviceConstants.DeviceLFI350: return 0;
                case DeviceConstants.DeviceLFI450: return 0;
                case DeviceConstants.DeviceLX10ASX: return 0;
                case DeviceConstants.DeviceLX20ASX: return 0;
                case DeviceConstants.DeviceLX60ASX: return 0;
                case DeviceConstants.DeviceMA21200: return 4;
                case DeviceConstants.DeviceMA21200ANA: return 4;
                case DeviceConstants.DeviceMA21200DAN: return 4;
                case DeviceConstants.DeviceMA4100: return 4;
                case DeviceConstants.DeviceMA4100ANA: return 4;
                case DeviceConstants.DeviceMA4100DAN: return 4;
                case DeviceConstants.DeviceMA4600: return 4;
                case DeviceConstants.DeviceMA4600ANA: return 4;
                case DeviceConstants.DeviceMA4600DAN: return 4;
                case DeviceConstants.DevicePS9: return 0;
                case DeviceConstants.DeviceScale1PoE: return 1;
                case DeviceConstants.DeviceSL20PoE: return 1;
                case DeviceConstants.DeviceX16: return 16;
                case DeviceConstants.DeviceXS10a: return 0;
                case DeviceConstants.DeviceXS20a: return 0;
                case DeviceConstants.DeviceXS22: return 0;
                case DeviceConstants.DeviceXS30a: return 0;
                case DeviceConstants.DeviceXS4a: return 0;
                case DeviceConstants.DeviceXT33a: return 0;
                case DeviceConstants.DeviceXT4a: return 0;
                case DeviceConstants.DeviceXT5a: return 0;

                default: return 0;
            }
        }

        private static byte ReturnOutputChannel(ushort device, byte channel, bool isBinary = false)
        {
            if (channel < 1)
                return 0;
            if (channel > GetNumberOfOutputChannels(device))
                return 0;
            if (isBinary)
            {
                return (byte)(2 ^ (channel - 1));
            }
            else
            {
                return channel;
            }
        }

        public static byte GetOutputChannelValue(ushort device, byte channel)
        {
            switch (device & DeviceConstants.MaskDevice)
            {
                case DeviceConstants.DeviceA22100: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceAAX2300: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceAM10: return 0;
                case DeviceConstants.DeviceAM20: return 0;
                case DeviceConstants.DeviceAM44ANA: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceAM44DAN: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceAM40: return 0;
                case DeviceConstants.DeviceAM50: return 0;
                case DeviceConstants.DeviceAS06ASX: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceAS10ASX: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceAS206: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceAS112: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceAS115: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceAS22ASX: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceAT35a: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceAT40a: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceAT50a: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceCVB: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceD21500: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceD2750: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceD41200: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceD4750: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceDFM100: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceDFM110: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceDFM400: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceDI22000: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceDI24000: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceDI41000: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceDI42000: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceDLI130: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceDLI230: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceDLI330: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceDLI430: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceFC8: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceFC9: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceFM100: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceFM110: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceFM400: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceFMI100: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceFMI110: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceFMI400: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceFS110: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceFS150: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceFS220: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceFS70: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceFSC1: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceFV100: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceFV200: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceHybrid1: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceLF120: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceLF220: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceLFI120: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceLFI220: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceLFI350: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceLFI450: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceLX10ASX: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceLX20ASX: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceLX60ASX: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceMA21200: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceMA21200ANA: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceMA21200DAN: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceMA4100: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceMA4100ANA: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceMA4100DAN: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceMA4600: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceMA4600ANA: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceMA4600DAN: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DevicePS9: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceScale1PoE: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceSL20PoE: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceX16: return ReturnOutputChannel(device, channel);
                case DeviceConstants.DeviceXS10a: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceXS20a: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceXS22: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceXS30a: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceXS4a: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceXT33a: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceXT4a: return ReturnOutputChannel(device, channel, true);
                case DeviceConstants.DeviceXT5a: return ReturnOutputChannel(device, channel, true);

                default: return 0;
            }
        }

        private static byte ReturnInputChannel(ushort device, byte channel)
        {
            if (channel < 1)
                return 0;
            if (channel > GetNumberOfInputChannels(device))
                return 0;
            return (byte)(GetNumberOfOutputChannels(device) + channel);
        }

        public static byte GetInputChannelValue(ushort device, byte channel)
        {
            switch (device & DeviceConstants.MaskDevice)
            {
                case DeviceConstants.DeviceA22100: return 0;
                case DeviceConstants.DeviceAAX2300: return 0;
                case DeviceConstants.DeviceAM10: return 0;
                case DeviceConstants.DeviceAM20: return 0;
                case DeviceConstants.DeviceAM44ANA: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceAM44DAN: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceAM40: return 0;
                case DeviceConstants.DeviceAM50: return 0;
                case DeviceConstants.DeviceAS06ASX: return 0;
                case DeviceConstants.DeviceAS10ASX: return 0;
                case DeviceConstants.DeviceAS206: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceAS112: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceAS115: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceAS22ASX: return 0;
                case DeviceConstants.DeviceAT35a: return 0;
                case DeviceConstants.DeviceAT40a: return 0;
                case DeviceConstants.DeviceAT50a: return 0;
                case DeviceConstants.DeviceCVB: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceD21500: return 0;
                case DeviceConstants.DeviceD2750: return 0;
                case DeviceConstants.DeviceD41200: return 0;
                case DeviceConstants.DeviceD4750: return 0;
                case DeviceConstants.DeviceDFM100: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceDFM110: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceDFM400: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceDI22000: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceDI24000: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceDI41000: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceDI42000: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceDLI130: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceDLI230: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceDLI330: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceDLI430: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceFC8: return 0;
                case DeviceConstants.DeviceFC9: return 0;
                case DeviceConstants.DeviceFM100: return 0;
                case DeviceConstants.DeviceFM110: return 0;
                case DeviceConstants.DeviceFM400: return 0;
                case DeviceConstants.DeviceFMI100: return 0;
                case DeviceConstants.DeviceFMI110: return 0;
                case DeviceConstants.DeviceFMI400: return 0;
                case DeviceConstants.DeviceFS110: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceFS150: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceFS220: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceFS70: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceFV100: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceFV200: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceHybrid1: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceLF120: return 0;
                case DeviceConstants.DeviceLF220: return 0;
                case DeviceConstants.DeviceLFI120: return 0;
                case DeviceConstants.DeviceLFI220: return 0;
                case DeviceConstants.DeviceLFI350: return 0;
                case DeviceConstants.DeviceLFI450: return 0;
                case DeviceConstants.DeviceLX10ASX: return 0;
                case DeviceConstants.DeviceLX20ASX: return 0;
                case DeviceConstants.DeviceLX60ASX: return 0;
                case DeviceConstants.DeviceMA21200: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceMA21200ANA: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceMA21200DAN: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceMA4100: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceMA4100ANA: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceMA4100DAN: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceMA4600: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceMA4600ANA: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceMA4600DAN: return ReturnInputChannel(device, channel);
                case DeviceConstants.DevicePS9: return 0;
                case DeviceConstants.DeviceScale1PoE: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceSL20PoE: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceX16: return ReturnInputChannel(device, channel);
                case DeviceConstants.DeviceXS10a: return 0;
                case DeviceConstants.DeviceXS20a: return 0;
                case DeviceConstants.DeviceXS22: return 0;
                case DeviceConstants.DeviceXS30a: return 0;
                case DeviceConstants.DeviceXS4a: return 0;
                case DeviceConstants.DeviceXT33a: return 0;
                case DeviceConstants.DeviceXT4a: return 0;
                case DeviceConstants.DeviceXT5a: return 0;

                default: return 0;
            }
        }

    }
}
