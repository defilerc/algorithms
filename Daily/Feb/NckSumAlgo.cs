using System.Collections.Generic;
using System.Linq;

namespace Daily.Feb
{
    public class NckSumAlgo
    {
        public object nckSum(int n, int k)
        {
            var s = new List<int>();
            var o = new List<List<int>>();

            S(k, 1, s, n, o);

            return o.SelectMany(x => x).ToArray();
        }

        void S(int k, int i, List<int> s,
            int n, List<List<int>> o)
        {
            if (k == 0) {
                if (n == 0) o.Add(s);
                return;
            }

            if (k > 1 && i > n / 2 || i > n) return;

            if (n - i >= 0)
                S(k - 1, i + 1, new List<int>(s) {i}, n - i, o);

            S(k, i + 1, s, n, o);
        }

        public object nckSumShort(int n, int k) => F(n, k, 0);

        List<List<int>> F(int n, int k, int i)
        {
            var subsets = new List<List<int>>();
            if (n < ++i)
                return subsets;

            if (k < 2) {
                subsets.Add(new List<int> {n});
                return subsets;
            }

            var output = F(n - i, k - 1, i);

            output.ForEach(x => x.Insert(0, i));

            output.AddRange(F(n, k, i));

            return output;
        }
    }
}