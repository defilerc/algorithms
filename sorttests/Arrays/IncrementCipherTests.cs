using System;
using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class IncrementCipherTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new IncrementCipher();
            var result = algo.incrementCipher("abc", new[] {1, 2, 3});

            Assert.AreEqual("bde", result);
        }
    }
}
