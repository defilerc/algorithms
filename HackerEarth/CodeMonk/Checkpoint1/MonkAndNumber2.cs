namespace HackerEarth.CodeMonk.Checkpoint1
{
    using System;
    using System.Collections.Generic;

    public class MonkAndNumberSol
    {
        private static int MOD = 1000000007;

        public static void Main(string[] args) 
        {
            var t = long.Parse(Console.ReadLine());

            while (t-- > 0) {
                var n = long.Parse(Console.ReadLine());

                var m = new Dictionary<long, long>();
                for (var i = 1; i <= 2 * n - 1; i++) {
                    var c = (char)Console.Read();
                    if (c == ' ') {
                        continue;
                    }
                    var temp = (long)char.GetNumericValue(c);

                    for (var j = 2; j <= Math.Sqrt(temp); j++) {
                        long cnt = 0;
                        while (temp % j == 0) {
                            temp /= j;
                            cnt++;
                        }

                        if (cnt > 0) {
                            if (m.ContainsKey(j)) {
                                m[j] += cnt;
                            }
                            else {
                                m.Add(j, cnt);
                            }
                        }
                    }

                    if (temp != 1) {
                        if (m.ContainsKey(temp)) {
                            m[temp]++;
                        } else {
                            m.Add(temp, 1);
                        }
                        
                    }
                }

                long ans = 1;

                foreach (var keypair in m) {
                    long pw = 1;
                    long sum = 0;
                    for (long i = keypair.Value + 1; i >= 1; i--) {
                        sum = (sum + ((long) i * (long) pw) % MOD) % MOD;
                        pw = ((long) pw * (long) keypair.Key) % MOD;
                    }

                    ans = (ans * sum) % MOD;
                }

                Console.WriteLine(ans);
            }
        }
    }
}