using System;
using System.Collections.Generic;
using Daily.Jan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests.Jan
{
    [TestClass]
    public class TypingDinstanceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new TypingDinstanceAlgo();

            int result = 0;

            result = algo.typingDistance(new[] {
                "qwerty",
                "asdfghjkl",
                "^zxcvbnm ",
            }, "QA");

            result = algo.typingDistance(new[] {
                "qwerty",
                "asdfghjkl",
                "^zxcvbnm ",
            }, "qym");
            Assert.AreEqual(9, result);

            result = algo.typingDistance(new[] {
                "qwerty",
                "asdfghjkl",
                "^zxcvbnm ",
            }, "ytrewq");
            Assert.AreEqual(5, result);

            result = algo.typingDistance(new[] {
                "qwerty",
                "asdfghjkl",
                "^zxcvbnm ",
            }, "qwerty");
            Assert.AreEqual(5, result);

            result = algo.typingDistance(new[] {
                "qwerty",
                "asdfghjkl",
                "^zxcvbnm ",
            }, "qasz");
            Assert.AreEqual(3, result);

            result = algo.typingDistance(new[] {
                "qwerty",
                "asdfghjkl",
                "^zxcvbnm ",
            }, "rfcxzsaq");
            Assert.AreEqual(7, result);
        }
    }
}
