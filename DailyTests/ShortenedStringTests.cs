using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    using Algo;

    [TestClass]
    public class ShortenedStringTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new ShortenedStringAlgo();
            var result = algo.shortenedString("(X3Y2(Z1)3 M4B0)2H2O");
            result = algo.shortenedString("A3");
            result = algo.shortenedString("(AB)3 B5");
        }
    }
}
