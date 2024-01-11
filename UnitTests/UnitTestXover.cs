/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace UnitTests
{
    [TestClass]
    public class UnitTestXover
    {
        [TestMethod]
        public void TestMethodXover()
        {
            byte[] expected, actual, reply;
            ushort frequency;
            int flags;
            bool result;

            expected = [0xf0, 0x01, 0x04, 0x82, 0x01, 0x01, 0x00, 0x78, 0x01, 0x01];
            actual = Xover.BuildWriteCmd(1, 1, 120, Xover.TypeHighPass, Xover.FlagOn);
            CollectionAssert.AreEqual(expected, actual);

            expected = [0xf0, 0x01, 0x04, 0x82, 0x01, 0x02, 0x00, 0x78, 0x02, 0x01];
            actual = Xover.BuildWriteCmd(1, 1, 120, Xover.TypeLowPass, Xover.FlagOn);
            CollectionAssert.AreEqual(expected, actual);

            expected = [0xf0, 0x01, 0x01, 0x0A, 0x01, 0x02, 0x82];
            actual = Xover.BuildReadCmd(1, 1, Xover.TypeLowPass);
            CollectionAssert.AreEqual(expected, actual);

            reply = [0x03, 0xE8, 0x01, 0x01];
            frequency = 0;
            flags = 0;
            result = Xover.ParseReadBack(reply, ref frequency, ref flags);
            Assert.AreEqual(true, result);
            Assert.AreEqual(1000, frequency);
            Assert.AreEqual(Xover.FlagOn, flags);

            reply = [];
            frequency = 0;
            flags = 0;
            result = Xover.ParseReadBack(reply, ref frequency, ref flags);
            Assert.AreEqual(false, result);
        }
    }
}
