using Algo.CommonTechniques;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.CommonTechniques
{
    [TestClass]
    public class LongestSubArrayBySumTests
    {
        [TestMethod]
        public void LongestSubArrayBySum()
        {
            var algo = new LongestSubArrayBySum();

            int[] result;
            result = algo.findLongestSubarrayBySum(12, new[] {1, 2, 3, 7, 5});
            // 2 - 4

            result = algo.findLongestSubarrayBySum(3, new[] {0, 1, 1, 1, 0});
            // 1 - 5
            result = algo.findLongestSubarrayBySum(3, new[] {1, 1, 1});
            // 1 - 3
            result = algo.findLongestSubarrayBySum(3, new[] {0, 1, 2, 0, 1, 1, 1, 0});
            // 4 - 8

            result = algo.findLongestSubarrayBySum(12, new[] {1, 2, 3, 7, 5});
            // 2 - 4
        }
    }
}
