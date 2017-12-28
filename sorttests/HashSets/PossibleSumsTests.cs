using System;
using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class PossibleSumsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new PossibleSums();

            //var result = algo.possibleSumsRec(new[] {10, 50}, new[] {1, 2});
            var result = algo.possibleSumsRec(new[] {10, 50, 100}, new[] {1, 2, 1});
        }
    }
}
