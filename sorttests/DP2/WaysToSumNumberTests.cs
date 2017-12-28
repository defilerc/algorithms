using System;
using Algo.DP2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.DP2
{
    [TestClass]
    public class WaysToSumNumberTests
    {
        [TestMethod]
        public void WaysToSumNumber()
        {
            var algo = new WaysToSumNumber();

            var result = algo.Solution(5, new[] {1, 3, 4});
        }
    }
}
