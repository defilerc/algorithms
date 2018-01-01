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
            var result = "";

            result = algo.hugeNumber(new[] {"78", "788"});
            result = algo.hugeNumber(new[] {"78", "781"});

            //result = algo.hugeNumber(new[] {"20", "3005", "2"});
            //Assert.AreEqual("3005220", result);
            result = algo.hugeNumber(new[] { "7878781", "78", "572" });
            result = algo.hugeNumber(new[] { "782", "78", "100" });
            result = algo.hugeNumber(new[] { "789", "78", "100" });
            result = algo.hugeNumber(new[] { "787", "78", "8" });
            Assert.AreEqual("9999989739392991090790684278978572552298294286241931211711", result);
            
            result = algo.hugeNumber(new[] {"286", "973", "572", "907", "193", "929", "93", "552", "842", "781", "910", "11", "906", "998", "298", "12", "78", "294", "999", "24", "117"});
            Assert.AreEqual("9999989739392991090790684278978572552298294286241931211711", result);

        }
    }
}
