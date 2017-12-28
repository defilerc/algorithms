using Algo.HeapStackQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.HeapStackQueue
{
    [TestClass]
    public class CountCloudsTest
    {
        [TestMethod]
        public void CountClouds()
        {
            var skyMap = new char[][] {
                new []{'0', '1', '1', '0', '1'},
                new []{'0', '1', '1', '1', '1'},
                new []{'0', '0', '0', '0', '1'},
                new []{'1', '0', '0', '1', '1'}
            };

            var algo = new CountCloudsAlgo();
            var result = algo.CountClouds(skyMap);
        }
    }
}
