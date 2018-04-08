using System;
using Daily.Jan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests.Jan
{
    [TestClass]
    public class DonkeyKongCountryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new DonkeyKongCountryAlgo();
            var result = algo.donkeyKongCountry(new[] {
                "96D1 = Klaptrap (walking b/f semi-backward)",
                "96E3 = Klaptrap (walking b/f semi-foward)",
                "96F5 = Klaptrap",
                "9703 = Klaptrap"
            });
        }
    }
}
