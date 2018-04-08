using System;
using HackerEarth.CodeMonk.Checkpoint2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerEarthTests.CodeMonk.Checkpoint2
{
    [TestClass]
    public class LISNLogNTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var A = new[] { 2, 5, 3, 7, 11, 8, 10, 13, 6 };

            var result = LISNLogN.LongestIncreasingSubsequenceLength(A, A.Length);
        }
    }
}
