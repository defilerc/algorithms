using System;

namespace Algo.TopTal
{
    public class MonkeyJump
    {
        public int Solution(int[] A, int D)
        {
            if (A == null || A.Length == 0) {
                return -1;
            }

            if (D > A.Length) {
                return 0;
            }

            var dp = new int[A.Length + 1];

            for (var i = 0; i < dp.Length; i++) {
                dp[i] = Int32.MaxValue;
            }

            var mintime = MinTimeForPos(A, D, A.Length, ref dp);

            return mintime == Int32.MaxValue ? -1 : mintime;
        }

        private int MinTimeForPos(int[] A, int D, int pos, ref int[] dp)
        {
            if (pos < 0) {
                return 0;
            }

            if (dp[pos] != Int32.MaxValue) {
                return dp[pos];
            }

            var minTime = Int32.MaxValue;

            for (var step = 1; step <= D; step++) {

                if (pos >= step && A[pos - step] == -1) {
                    continue;
                }

                var time = MinTimeForPos(A, D, pos - step, ref dp);

                if (time < minTime) {
                    minTime = time;
                }
            }

            var current = pos >= A.Length ? -1 : A[pos];
            return dp[pos] = Math.Max(minTime, current);
        }
    }
}
