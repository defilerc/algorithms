using System;

namespace Algo.DynamicProgramming
{
    public class CutRodMemoized
    {
        public int CutRod(int[] p, int n)
        {
            if (n == 0)
            {
                return 0;
            }

            var r = new int[n + 1];

            for (var i = 0; i <= n; i++)
            {
                r[i] = Int32.MinValue;
            }

            return CutRodAux(p, n, r);
        }

        private int CutRodAux(int[] p, int n, int[] r)
        {
            if (r[n] >= 0)
            {
                return r[n];
            }

            int q;
            if (n == 0)
            {
                q = 0;
            }
            else
            {
                q = Int32.MinValue;
                for (var i = 0; i < n; i++)
                {
                    q = Math.Max(q, p[i] + CutRodAux(p, n - i - 1, r));
                }
            }

            r[n] = q;
            return q;
        }
    }
}
