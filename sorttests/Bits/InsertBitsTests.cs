using System;
using Algo.Bits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Bits
{
    [TestClass]
    public class InsertBitsTests
    {
        [TestMethod]
        public void InsertBits()
        {
            var algo = new InsertBitsAlgo();
            var result = algo.insertBits(1024, 1, 6, 17);

            Assert.AreEqual(1058, result);
        }
    }
}
