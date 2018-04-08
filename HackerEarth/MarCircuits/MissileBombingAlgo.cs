namespace HackerEarth.MarCircuits
{
    using System;
    using System.Linq;

    public class MissileBombingAlgo
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var A = new int[n][];

            for (var i = 0; i < n; i++) {
                A[i] = new int[n];
            }

            while (m-- > 0) {
                var x = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int p = x[0], a = x[1], b = x[2], c = x[3], d = x[4];

                for (var i = a - 1; i <= c - 1; i++) {
                    for (var j = b - 1; j <= d - 1; j++) {
                        A[i][j] ^= p;
                    }
                }
            }

            Console.WriteLine(string.Join("\n", A.Select(i => string.Join(" ", i))));
        }
    }
}
