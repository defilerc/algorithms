using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class MergeSortTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new MergeSort();

            var a = new[] {6, 8, 3, 7, 1, 9, 15, 4, 4, 4};

            algo.Sort(a, 0, 9);
        }
    }
}
