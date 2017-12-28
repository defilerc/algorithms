using System;
using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class RearrangeLastNTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var l = Utils.CreateLinkedList(new[] {1, 2, 3, 4, 5});
            var n = 3;

            var algo = new RearrangeLastN();

            var result = algo.rearrangeLastN(l, n);
        }
    }
}
