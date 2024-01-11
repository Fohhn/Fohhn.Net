/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace UnitTests
{
    [TestClass]
    public class UnitTestRouting
    {
        [TestMethod]
        public void TestMethodRouting()
        {
            byte[] expected, actual, reply;
            float vol;
            int flags;
            bool result;

            expected = [0xf0, 0x01, 0x03, 0x81, 0x01, 0x02, 0x00, 0x00, 0x00];
            actual = Routing.BuildWriteCmd(1, 1, 2, 0.0f, 0);
            CollectionAssert.AreEqual(expected, actual);

            expected = [0xf0, 0x01, 0x03, 0x81, 0x01, 0x01, 0xfc, 0xe0, 0x01];
            actual = Routing.BuildWriteCmd(1, 1, 1, -80.0f, Volume.FlagOn);
            CollectionAssert.AreEqual(expected, actual);

            expected = [0xf0, 0x01, 0x03, 0x81, 0x01, 0x01, 0xff, 0x01, 0xb5, 0x01];
            actual = Routing.BuildWriteCmd(1, 1, 1, -7.5f, Volume.FlagOn);
            CollectionAssert.AreEqual(expected, actual);

            expected = [0xf0, 0xff, 0x00, 0x03, 0x81, 0x01, 0x01, 0x00, 0x78, 0x01];
            actual = Routing.BuildWriteCmd(240, 1, 1, 12.0f, Volume.FlagOn);
            CollectionAssert.AreEqual(expected, actual);

            expected = [0xf0, 0x01, 0x01, 0x0A, 0x01, 0x02, 0x81];
            actual = Routing.BuildReadCmd(1, 1, 2);
            CollectionAssert.AreEqual(expected, actual);

            reply = [0x00, 0x0a, 0x01];
            vol = 0;
            flags = 0;
            result = Routing.ParseReadBack(reply, ref vol, ref flags);
            Assert.AreEqual(true, result);
            Assert.AreEqual(1.0f, vol);
            Assert.AreEqual(Routing.FlagOn, flags);

            reply = [0xfc, 0xe0, 0x00];
            vol = 0;
            flags = 0;
            result = Routing.ParseReadBack(reply, ref vol, ref flags);
            Assert.AreEqual(true, result);
            Assert.AreEqual(-80.0f, vol);
            Assert.AreEqual(0, flags);

            reply = [];
            vol = 0;
            flags = 0;
            result = Routing.ParseReadBack(reply, ref vol, ref flags);
            Assert.AreEqual(false, result);
            Assert.AreEqual(0, vol);
            Assert.AreEqual(0, flags);
        }
    }
}
