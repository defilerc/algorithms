using Algo;
using Algo.HeapStackQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.HeapStackQueue
{
    [TestClass]
    public class KThLargestInArrayTests
    {
        [TestMethod]
        public void KThLargestInArrayTest()
        {
            var algo = new KthLargestInArray();

            var heap = new Heap(new[] {7, 6, 5, 4, 3, 2, 1});
            heap.HeapSort();

            var result = algo.FindKthLargestInArray(heap.Elements, 2);
            Assert.AreEqual(6, result);

            heap = new Heap(new [] { 99, 99 });
            heap.HeapSort();

            result = algo.FindKthLargestInArray(heap.Elements, 1);
            Assert.AreEqual(99, result);

            heap = new Heap(new[] { 1 });
            heap.HeapSort();

            result = algo.FindKthLargestInArray(heap.Elements, 1);
            Assert.AreEqual(1, result);
        }
    }
}
