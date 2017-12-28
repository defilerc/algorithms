using System;
using System.Diagnostics;
using Algo.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.DynamicProgramming
{
    [TestClass]
    public class CutRodTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p = new[] {1, 5, 8, 9, 10, 17, 17, 20, 24, 30};

            var algo = new CutRodSimple();

            for (var i = 0; i < 10; i++)
            {
                var sw = Stopwatch.StartNew();
                var result = algo.CutRod(p, i);
                sw.Stop();
            }
        }
    }
}
