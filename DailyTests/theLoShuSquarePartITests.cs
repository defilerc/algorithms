using System;
using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class theLoShuSquarePartITests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new theLoShuSquarePartIAlgo();
            var result = algo.theLoShuSquarePartIShortest(2013);
        }
        
    }
}
