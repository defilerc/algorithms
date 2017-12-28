namespace HackerRank
{
    public class CoinChangeAlgo
    {
        public long getWays(long n, long[] c)
        {
            var table = new long[n + 1, c.Length + 1];

            table[0, 0] = 1;

            for (var m = 1; m <= c.Length; m++) {
                for (var s = 0; s <= n; s++) {
                    if (s < c[m - 1]) {
                        table[s, m] = table[s, m - 1];
                        continue;
                    }

                    table[s, m] = table[s, m - 1] + table[s - c[m-1], m];
                }
            }

            return table[n, c.Length];
        }
    }
}
