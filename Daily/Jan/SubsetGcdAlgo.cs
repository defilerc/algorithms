namespace Daily.Jan
{
    public class SubsetGcdAlgo
    {
        public int subsetGcd(int n, int g)
        {
            var s = new long[n + 1];

            for (var i = n; i >= 1; i--) {
                var r = 0L;
                var f = 1;

                for (var j = 2; j * i <= n; j++) {
                    f += 1;
                    r = r + s[j * i];
                }

                s[i] = P(2, f, 1000000007) - 1 - r;
            }

            return (int)(s[g] % 1000000007);
        }

        long P(long a, long x, long p)
        {
            long res = 1;
            while (x > 0) {
                if (x % 2 != 0)
                    res = (res * a) % p;
                a = a * a % p;
                x /= 2;
            }

            return res % p;
        }
    }
}
