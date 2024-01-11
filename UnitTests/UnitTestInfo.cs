/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace UnitTests
{
    [TestClass]
    public class UnitTestInfo
    {
        [TestMethod]
        public void TestMethodInfo()
        {
            byte[] expected, actual, reply;
            ushort device;
            bool result;

            expected = [0xf0, 0x01, 0x01, 0x20, 0x00, 0x00, 0x01];
            actual = Info.BuildReadCmd(1);
            CollectionAssert.AreEqual(expected, actual);

            reply = [0x01, 0x00, 0x01, 0x02, 0x03];
            expected = [0x01, 0x02, 0x03];
            device = 0;
            result = Info.ParseReadBack(reply, ref device, ref actual);
            CollectionAssert.AreEqual(expected, actual);
            Assert.AreEqual(true, result);
            Assert.AreEqual(0x0100, device);

            reply = [0x01, 0x00, 0x01, 0x02];
            expected = [0x01, 0x02, 0x00];
            device = 0;
            result = Info.ParseReadBack(reply, ref device, ref actual);
            CollectionAssert.AreEqual(expected, actual);
            Assert.AreEqual(true, result);
            Assert.AreEqual(0x0100, device);

            reply = [];
            result = Info.ParseReadBack(reply, ref device, ref actual);
            Assert.AreEqual(false, result);
        }
    }
}