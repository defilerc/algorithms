using System;
using System.Linq;

namespace Algo.DynamicProgramming
{
    public class HouseRobberAlgo
    {
        public int houseRobber(int[] nums)
        {
            if (!nums.Any()) {
                return 0;
            }

            if (nums.Length == 1) {
                return nums[0];
            }

            return Math.Max(
                houseRobber(nums.Take(nums.Length - 1).ToArray()),
                houseRobber(nums.Take(nums.Length - 2).ToArray()) + nums[nums.Length - 1]);
        }
    }
}
