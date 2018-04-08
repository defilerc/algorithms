using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Daily.Feb;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests.Feb
{
    [TestClass]
    public class MSquareTests
    {
        [TestMethod]
        public void Test()
        {
            var s = new Stack<int>();

            var algo = new MSquareAlgo();
            //var result = algo.mSquare(2147483638);
            var result = algo.mSquare(65535);
        }
    }
}
