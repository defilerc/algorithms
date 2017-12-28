using Algo.HeapStackQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.HeapStackQueue
{
    [TestClass]
    public class NextLargerTests
    {
        [TestMethod]
        public void NextLarger()
        {
            var a = new[] {6, 7, 3, 8};
            var algo = new NextLargerAlgo();

            var result = algo.NextLarger(a);
        }
    }
}
