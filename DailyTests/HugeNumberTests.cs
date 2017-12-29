using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class HugeNumberTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new HugeNumber();

            var result = algo.hugeNumber(new [] {"286", "973", "572", "907", "193", "929", "93", "552", "842", "789", 
                "910", "11", "906", "998", "298", "12", "78", "294", "999", "24", "117"});
            Assert.AreEqual("9999989739392991090790684278978572552298294286241931211711", result);

            result = algo.hugeNumber(new [] {"20", "3005", "2"});
            Assert.AreEqual("3005220", result);
        }
    }
}
