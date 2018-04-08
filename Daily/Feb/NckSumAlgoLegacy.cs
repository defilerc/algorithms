using System.Collections.Generic;
using System.Linq;

namespace Daily.Feb
{
    public class NckSumAlgoLegacy
    {
        public int[][] nckSum(int n, int k)
        {
            var set = new HashSet<int>();
            var sums = new List<HashSet<int>>();

            Subset(k, 1, set, n, sums);

            return sums.Select(s => s.ToArray()).ToArray();
        }

        void Subset(int k, int i, HashSet<int> set,
            int n, List<HashSet<int>> sums)
        {
            if (k == 0) {
                if (n == 0) {
                    sums.Add(set);
                }

                return;
            }

            if (k > 1 && i > n / 2) {
                return;
            }


            if (i > n) {
                return;
            }

            if (n - i >= 0) {
                var newSet = new HashSet<int>(set) {i};
                Subset(k - 1, i + 1, newSet, n - i, sums);
            }

            Subset(k, i + 1, set, n, sums);
        }
    }
}
