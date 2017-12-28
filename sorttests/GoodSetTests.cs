using System;
using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class GoodSetTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var someSet = new[] {0, 1, 2, 3};

            var algo = new GoodSet();
            var result = algo.goodSet(someSet);
            Assert.IsFalse(result);

            someSet = new[] {1, 2, 4};

            result = algo.goodSet(someSet);
            Assert.IsTrue(result);

            someSet = new[] {1, 3, 5, 7};
            result = algo.goodSet(someSet);
            Assert.IsTrue(result);

            someSet = new[] {1, 2, 4, 6};
            result = algo.goodSet(someSet);
            Assert.IsFalse(result);

            someSet = new[] {0, 0, 0, 0};
            result = algo.goodSet(someSet);
            Assert.IsFalse(result);
        }
    }
}
