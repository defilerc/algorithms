using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class VigenereKeyTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new VigenereKeyAlgo();
            string result;

            result = algo.vigenereKey("cupcakesorthetea", "jukgaxmusnxloxrd");
            result = algo.vigenereKey("whatwillittakejusttofindthatspecialday", "nlaeebjcmteidcaysebhdzrdeptrjtenqtjuey");
            result = algo.vigenereKey("theladywhoknowseverything", "yleehhpblodusnxivxyckmmnz");
            result = algo.vigenereKey("okayeveryone", "qvuzggysazhf");
        }
    }
}
