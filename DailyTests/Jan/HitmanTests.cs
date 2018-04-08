using System;
using System.Collections.Generic;
using Daily.Jan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests.Jan
{
    [TestClass]
    public class HitmanTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var l = new List<string>();
            var algo = new HitmanAlgo();
            
            for (var i = 1; i <= 100; i++) {
                l.Add(i.ToString());

                Console.WriteLine($"{i}: {algo.hitman(l.ToArray())}");
            }
        }
    }
}
