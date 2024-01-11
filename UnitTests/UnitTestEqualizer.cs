/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace UnitTests
{
    [TestClass]
    public class UnitTestEqualizer
    {
        [TestMethod]
        public void TestMethodEqualizer()
        {
            byte[] expected, actual, reply;
            ushort frequency;
            float q;
            float gain;
            int flags;
            bool result;

            expected = [0xf0, 0x01, 0x07, 0x80, 0x01, 0x0A, 0x3E, 0x80, 0x00, 0x14, 0x00, 0x0A, 0x01];
            actual = Equalizer.BuildWriteCmd(1, 1, 10, 16000, 2.0f, 1.0f, Equalizer.FlagOn);
            CollectionAssert.AreEqual(expected, actual);

            expected = [0xf0, 0x01, 0x07, 0x80, 0x01, 0x0A, 0x3E, 0x80, 0x00, 0x14, 0xFF, 0x01, 0xF6, 0x01];
            actual = Equalizer.BuildWriteCmd(1, 1, 10, 16000, 2.0f, -1.0f, Equalizer.FlagOn);
            CollectionAssert.AreEqual(expected, actual);

            reply = [0x3E, 0x80, 0x00, 0x14, 0x00, 0x0A, 0x01];
            frequency = 0;
            q = 0;
            gain = 0;
            flags = 0;
            result = Equalizer.ParseReadBack(reply, ref frequency, ref q, ref gain, ref flags);
            Assert.AreEqual(true, result);
            Assert.AreEqual(16000, frequency);
            Assert.AreEqual(2.0f, q);
            Assert.AreEqual(1.0f, gain);
            Assert.AreEqual(Volume.FlagOn, flags);

            reply = [];
            result = Equalizer.ParseReadBack(reply, ref frequency, ref q, ref gain, ref flags);
            Assert.AreEqual(false, result);
        }
    }
}
