using System;
using Algo.CommonTechniques;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.CommonTechniques
{
    [TestClass]
    public class ProductExceptSelfTests
    {
        [TestMethod]
        public void ProductExceptSelf()
        {
            var algo = new ProductExceptSelf();
            int result;

            result = algo.productExceptSelf(
                new[] {2, 100}, 24);

            Assert.AreEqual(6, result);

            result = algo.productExceptSelf(
                new[] {5, 8, 6, 3, 2}, 8);

            Assert.AreEqual(4, result);

            result = algo.productExceptSelf(
                new[] {1, 2, 3, 4}, 12);

            Assert.AreEqual(2, result);

            result = algo.productExceptSelf(
                new[] {27, 37, 47, 30, 17, 6, 20, 17, 21, 43, 5, 49, 49, 50, 20, 42, 45, 1, 22, 44},
                40);

            Assert.AreEqual(0, result);
        }
    }
}
