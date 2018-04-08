using System.Linq;
using HackerEarth.Disjoint;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerEarthTests.Disjoint
{
    [TestClass]
    public class DisjointAlgoTests
    {
        [TestMethod]
        public void TestDisjoint()
        {
            var a = Enumerable.Range(0, 10).ToArray();

            DisjointAlgo.QuickUnion(a, 2, 1);
            DisjointAlgo.QuickUnion(a, 4, 3);
            DisjointAlgo.QuickUnion(a, 8, 4);
            DisjointAlgo.QuickUnion(a, 9, 3);
            DisjointAlgo.QuickUnion(a, 6, 5);
        }

        [TestMethod]
        public void TestQuickDisoint()
        {
            var a = Enumerable.Range(0, 6).ToArray();

            DisjointAlgo.QuickUnion(a, 1, 0);
            DisjointAlgo.QuickUnion(a, 0, 2);
            DisjointAlgo.QuickUnion(a, 3, 4);
            DisjointAlgo.QuickUnion(a, 1, 4);

            Assert.IsTrue(DisjointAlgo.QuickFind(a, 1, 4));
            Assert.IsFalse(DisjointAlgo.QuickFind(a, 3, 5));
        }
    }
}
