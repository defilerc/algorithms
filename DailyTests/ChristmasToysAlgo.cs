using System;
using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class ChristmasToysTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new ChristmasToysAlgo();
            var result = algo.christmasToys(new int[][] {
                new[] {6, 2, 4},
                new int[0],
                new int[0],
                new int[0],
                new[] {5, 1},
                new int[0],
                new[] {3}
            });
        }
    }
}
