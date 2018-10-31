namespace HackerEarth.Graphs
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class BellmanFord
    {
        const int MAX = 2000000000;

        public static void Main(string[] args)
        {
            var nm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nm[0], m = nm[1];
            var v = new List<int>[m];
            var dis = new int[n];

            for (var i = 0; i < n; i++) {
                dis[i] = MAX;
            }

            for (var i = 0; i < m; i++) {
                var line = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(line)) {
                    continue;
                }
                var e = line.Split(' ').Select(int.Parse).ToArray();
                int x = e[0], y = e[1], w = e[2];

                if (v[i] == null) {
                    v[i] = new List<int>();
                }

                v[i].AddRange(new[] { x, y, w});
            }

            dis[0] = 0;

            for (var i = 0; i < n - 1; i++) {
                var j = 0;

                while (j < v.Length && v[j] != null && v[j].Count != 0) {
                    int x = v[j][0] - 1, y = v[j][1] - 1, w = v[j][2];

                    dis[y] = Math.Min(dis[y], dis[x] + w);
                    j++;
                }
            }

            Console.WriteLine(string.Join(" ", dis).Substring(2));
        }
    }
}
