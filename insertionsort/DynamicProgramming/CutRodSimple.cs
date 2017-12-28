using System;

namespace Algo.DynamicProgramming
{
    public class CutRodSimple
    {
        public int CutRod(int[] p, int n)
        {
            if (n == 0)
            {
                return 0;
            }

            var max = Int32.MinValue;

            for (var i = 0; i < n; i++)
            {
                max = Math.Max(max, p[i] + CutRod(p, n - i - 1));
            }

            return max;
        }
    }
}
