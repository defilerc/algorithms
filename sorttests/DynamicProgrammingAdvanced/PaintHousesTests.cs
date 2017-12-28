using System;
using Algo.DynamicProgrammingAdvanced;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.DynamicProgrammingAdvanced
{
    [TestClass]
    public class PaintHousesTests
    {
        [TestMethod]
        public void PaintHouses()
        {
            var algo = new PaintHouses();
            
            var result = algo.paintHouses(new int[][] {
                new [] {1, 3, 4},
                new[] {2, 3, 3},
                new[] {3, 1, 4}
            });
            Assert.AreEqual(5, result);
        }
    }
}
