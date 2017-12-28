namespace Algo.DynamicProgramming
{
    public class ClimbingStairsAlgo
    {
        public int climbingStairs(int n)
        {
            var dp = new int[51];

            return ClimbDp(n, ref dp);
        }

        private int ClimbDp(int n, ref int[] dp)
        {
            if (n <= 0) {
                return 1;
            }

            if (n == 1) {
                return 1;
            }

            if (dp[n] != 0) {
                return dp[n];
            }

            dp[n] = climbingStairs(n - 1) + climbingStairs(n - 2);
            return dp[n];
        }

    }
}
