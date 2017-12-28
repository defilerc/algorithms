using System;
using Algo.BfsDfs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.BfsDfs
{
    [TestClass]
    public class LongestPathTests
    {
        [TestMethod]
        public void LongestPath()
        {
            var algo = new LongestPathAlgo();

            var fileSystem = "rzzmf\rv\r\tix\r\t\tiklav\r\t\t\ttqse\r\t\t\t\ttppzf\r\t\t\t\t\tzav\r\t\t\t\t\t\tkktei\r\t\t\t\t\t\t\thhmav\r\t\t\t\t\t\t\t\tbzvwf.txt";
            var result = algo.longestPath(fileSystem);
        }
    }
}
