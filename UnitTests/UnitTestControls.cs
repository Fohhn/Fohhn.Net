/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace UnitTests
{
    [TestClass]
    public class UnitTestControls
    {
        [TestMethod]
        public void TestMethodControls()
        {
            byte[] expected, actual, reply;
            float temperature;
            byte flags;
            bool result;

            expected = [0xf0, 0x01, 0x01, 0x07, 0x01, 0x00, 0x00];
            actual = Controls.BuildReadCmd(1);
            CollectionAssert.AreEqual(expected, actual);

            reply = [0x01, 0x01, 0xA4, 0x00];
            flags = 0;
            temperature = 0;
            result = Controls.ParseReadBack(reply, ref flags, ref temperature);
            Assert.AreEqual(true, result);
            Assert.AreEqual(0x01, flags);
            Assert.AreEqual(42.0f, temperature);

            reply = [];
            result = Controls.ParseReadBack(reply, ref flags, ref temperature);
            Assert.AreEqual(false, result);
        }
    }
}