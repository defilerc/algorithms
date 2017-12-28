using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class MaxSubArrayTests
    {
        [TestMethod]
        public void Find()
        {
            var array = new[] {2, -3, 3, -5, 1, -2};
            
            var msa = new MaxSubArray();
            
            var result = msa.arrayMaxConsecutiveSum2(array);

            Assert.AreEqual(3, result);

            array = new[]
            {
                13, -3, -25, 20, -3, -16, -23, 18, 20, -7,
                12, -5, -22, 15, -4, 7
            };

            result = msa.arrayMaxConsecutiveSum2(array);
        }
    }
}
