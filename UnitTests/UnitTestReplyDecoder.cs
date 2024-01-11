/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace UnitTests
{
    [TestClass]
    public class UnitTestReplyDecoder
    {
        [TestMethod]
        public void TestMethodReplyDecoder()
        {
            byte[] expected;
            bool result;
            ReplyDecoder decoder;

            decoder = new ReplyDecoder(1);
            expected = [0xFF, 0x01, 0x01];

            result = decoder.DecodeReceivedBytes([0xFF]);
            Assert.AreEqual(false, result);
            result = decoder.DecodeReceivedBytes([0x01, 0x01, 0x01, 0x01, 0xF0]);
            Assert.AreEqual(true, result);
            CollectionAssert.AreEqual(expected, decoder.Data);

            decoder = new ReplyDecoder(240);
            expected = [];
            result = decoder.DecodeReceivedBytes([0xFF, 0x00, 0xF0]);
            Assert.AreEqual(true, result);
            CollectionAssert.AreEqual(expected, decoder.Data);
        }
    }
}
