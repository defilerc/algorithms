using System.Linq;

namespace Algo.DP2
{
    public class WaysToSumNumber
    {
        public int Solution(int n, int[] nums)
        {
            var dp = new int[n+1];

            return SumUpTo(n, nums, ref dp);
        }

        private int SumUpTo(int n, int[] nums, ref int[] dp)
        {
            if (n <= 0) {
                return 0;
            }

            if (dp[n] > 0) {
                return dp[n];
            }

            for (var i = 0; i < nums.Length; i++) {
                dp[n] = 1 + SumUpTo(n - nums[i], nums, ref dp);
            }

            return 0;
        }
    }
}
