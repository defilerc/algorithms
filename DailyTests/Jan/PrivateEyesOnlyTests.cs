using System;
using Daily.Jan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests.Jan
{
    [TestClass]
    public class PrivateEyesOnlyTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new PrivateEyesOnlyAlgo();
            var result = algo.privateEyesOnly("Uijt jt b sfbebcmf tusjoh jo Fohmjti!");
        }
    }
}
