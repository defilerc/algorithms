namespace HackerEarth.CodeMonk.Checkpoint1
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class MonkAndNumberAlgo
    {
        public static int Mod = 1000000007;
        public static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());

            while (t-- > 0) {
                var n = int.Parse(Console.ReadLine());
                var a = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);
                MonkAndNumber(a);
            }
        }

        public static void MonkAndNumber(int[] A)
        {
            var n = A.Aggregate<int, long>(1, (cur, next) => (cur * next) % Mod) % Mod;
            n = 1541207250;

            var divs = GetDivisors(n);

            long sum = 0;

            for (var i = 0; i < divs.Count; i++) {
                var d = GetDivisors(divs[i]);

                for (var j = 0; j < d.Count; j++) {
                    sum = (sum % Mod + d[j] % Mod) % Mod;
                }
            }

            Console.WriteLine(sum);
        }

        public static void MonkAndNumberNaive(int[] A)
        {
            var n = A.Aggregate<int, long>(1, (cur, next) => (cur * next));

            var d = new List<long>();
            for (var i = 1; i <= n; i++) {
                if (n % i == 0) {
                    d.Add(i);
                }
            }
        }

        public static List<long> GetDivisors(long n)
        {
            var d = new List<long>();

            for (var i = 1; i <= Math.Sqrt(n); i++) {

                if (n % i != 0) {
                    continue;
                }
                
                d.Add(i);

                if (i != n / i) {
                    d.Add(n / i);
                }
            }

            return d;
        }
    }
}
