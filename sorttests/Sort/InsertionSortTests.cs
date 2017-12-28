using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class InsertionSortTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new InsertionSort();

            var a = new int[] {5, 2, 4, 6, 1, 3};

            algo.Sort(a);

            for (int i = 1; i < a.Length; i++)
            {
                Assert.IsTrue(a[i - 1] <= a[i]);
            }

        }
    }
}
