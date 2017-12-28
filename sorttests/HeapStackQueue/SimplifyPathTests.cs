using System;
using Algo.HeapStackQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.HeapStackQueue
{
    [TestClass]
    public class SimplifyPathTests
    {
        [TestMethod]
        public void SimplifyPath()
        {
            var path = "/home/a/./x/../b//c/";
            var algo = new SimplifyPath();

            var result = algo.simplifyPath(path);

            path = "/..";
            result = algo.simplifyPath(path);
        }
    }
}
