/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace UnitTests
{
    [TestClass]
    public class UnitTestPreset
    {
        [TestMethod]
        public void TestMethodPreset()
        {
            byte[] expected, actual, reply;
            byte preset = 0;
            string name = "";
            bool result = false;

            expected = [0xf0, 0x01, 0x01, 0x05, 0x01, 0x14, 0x00];
            actual = Preset.BuildLoadCmd(1, 20);
            CollectionAssert.AreEqual(expected, actual);

            expected = [0xf0, 0x01, 0x01, 0x8E, 0x01, 0x00, 0x00];
            actual = Preset.BuildReadCmd(1, Preset.ActivePreset);
            CollectionAssert.AreEqual(expected, actual);

            expected = [0xf0, 0x01, 0x01, 0x8E, 0x01, 0x14, 0x00];
            actual = Preset.BuildReadCmd(1, 20);
            CollectionAssert.AreEqual(expected, actual);

            reply = [0x01, 0x00, (byte)'T', (byte)'e', (byte)'s', (byte)'t', (byte)' ', 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00];
            result = Preset.ParseReadBack(reply, ref preset, ref name);
            Assert.AreEqual(true, result);
            Assert.AreEqual(1, preset);
            Assert.AreEqual("Test", name);
        }
    }
}
