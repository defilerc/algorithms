using System.Linq;
using HackerEarth.Disjoint;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerEarthTests.Disjoint
{
    [TestClass]
    public class DisjointAlgoTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = Enumerable.Range(0, 10).ToArray();

            DisjointAlgo.Union(a, 2, 1);
            DisjointAlgo.Union(a, 4, 3);
            DisjointAlgo.Union(a, 8, 4);
            DisjointAlgo.Union(a, 9, 3);
            DisjointAlgo.Union(a, 6, 5);
        }
    }
}
