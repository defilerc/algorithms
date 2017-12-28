using Algo.HeapStackQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.HeapStackQueue
{
    [TestClass]
    public class NearestGreaterTests
    {
        [TestMethod]
        public void NearestGreater()
        {
            var algo = new NearestGreaterDummy();

            var a = new[] { 1, 4, 2, 1, 7, 6 };
            var result = algo.nearestGreater(a);
            // expected: [1, 4, 1, 2, -1, 4]

            a = new[] { 2, 1, 2, 1, 2 };
            result = algo.nearestGreater(a);

            a = new[] {2, 1, 1, 1, 2};
            result = algo.nearestGreater(a);
            // expected: [-1, 0, 0, 4, -1]

            a = new[] { 100000, 99999, 99999, 99999, 99999 };
            result = algo.nearestGreater(a);
            // expected: [-1, 0, 0, 0, 0 ,0...]
        }
    }
}
