/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace UnitTests
{
    [TestClass]
    public class UnitTestDelay
    {
        [TestMethod]
        public void TestMethodDelay()
        {
            byte[] expected, actual, reply;
            float time;
            int flags;
            bool result;

            expected = [0xf0, 0x01, 0x03, 0x86, 0x01, 0x01, 0x03, 0xE8, 0x01];
            actual = Delay.BuildWriteCmd(1, 1, 10.0f, Delay.FlagOn);
            CollectionAssert.AreEqual(expected, actual);

            expected = [0xf0, 0x01, 0x01, 0x0A, 0x01, 0x01, 0x86];
            actual = Delay.BuildReadCmd(1, 1);
            CollectionAssert.AreEqual(expected, actual);

            reply = [0x03, 0xE8, 0x01];
            time = 0;
            flags = 0;
            result = Delay.ParseReadBack(reply, ref time, ref flags);
            Assert.AreEqual(true, result);
            Assert.AreEqual(10.0f, time);
            Assert.AreEqual(Delay.FlagOn, flags);

            reply = [];
            time = 0;
            flags = 0;
            result = Delay.ParseReadBack(reply, ref time, ref flags);
            Assert.AreEqual(false, result);
            Assert.AreEqual(0, time);
            Assert.AreEqual(0, flags);
        }
    }
}
