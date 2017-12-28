//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Algo.DP2
//{
//    public class WaysToSumNumber
//    {
//        public string[] Solution(int n, int[] nums)
//        {
//            var dp = new List<List<string>>();
//            var solutions = new List<string>();

//            SumUpTo(n, nums, ref dp, ref solutions);

//            return solutions.ToArray();
//        }

//        private List<string> SumUpTo(int n, int[] nums, ref List<List<string>> dp, ref List<string> solutions)
//        {
//            if (n <= 0) {
//                return new List<string>();
//            }

//            if (dp[n] != null) {
//                return dp[n];
//            }

//            if (nums.Contains(n)) {
//                return dp[n] = $"{n}";
//            }

//            for (var i = 0; i < nums.Length; i++) {
//                solutions.Add(dp[n] = $"{nums[i]}+{SumUpTo(n - nums[i], nums, ref dp, ref solutions)}");
//            }

//            return "";
//        }
//    }
//}
