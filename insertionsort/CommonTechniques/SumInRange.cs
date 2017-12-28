using System;

namespace Algo.CommonTechniques
{
    public class SumInRange
    {
        public int sumInRange(int[] nums, int[][] queries)
        {
            for (var i = 1; i < nums.Length; i++) {
                nums[i] += nums[i - 1];
            }

            long sum = 0;
            for (var i = 0; i < queries.Length; i++) {
                sum += (queries[i][0] == 0) 
                    ? nums[queries[i][1]]
                    : nums[queries[i][1]] - nums[queries[i][0] - 1];
            }

            while (sum < 0) {
                sum += 1000000007;
            }

            return (int)(sum % 1000000007);
        }
    }
}
