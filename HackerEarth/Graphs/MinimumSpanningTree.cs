namespace HackerEarth.Graphs
{
    using System;
    using System.Linq;

    public class MinimumSpanningTree
    {
        static int[] id;
        static Tuple<long, Tuple<int, int>>[] p;

        static void Init()
        {
            for (int i = 0; i < id.Length; ++i)
                id[i] = i;
        }

        static int Root(int x)
        {
            while (id[x] != x) {
                id[x] = id[id[x]];
                x = id[x];
            }
            return x;
        }

        static void Union(int x, int y)
        {
            int p = Root(x);
            int q = Root(y);
            id[p] = id[q];
        }

        static long Kruskal(Tuple<long, Tuple<int, int>>[] p)
        {
            var edges = p.Length;
            long cost, minimumCost = 0;

            for (int i = 0; i < edges; ++i) {
                // Selecting edges one by one in increasing order from the beginning
                var x = p[i].Item2.Item1;
                var y = p[i].Item2.Item2;
                cost = p[i].Item1;

                // Check if the selected edge is creating a cycle or not
                if (Root(x) != Root(y)) {
                    minimumCost += cost;
                    Union(x, y);
                }
            }
            return minimumCost;
        }

        public static void Main(string[] args)
        {
            var nm = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int nodes = nm[0], edges = nm[1];

            id = new int[edges];
            Init();
            p = new Tuple<long, Tuple<int, int>>[edges];

            for (int i = 0; i < edges; ++i) {
                var inp = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

                int x = inp[0], y = inp[1], weight = inp[2];

                p[i] = new Tuple<long, Tuple<int, int>>(weight,
                    new Tuple<int, int>(x, y));
            }
            // Sort the edges in the ascending order
            Array.Sort(p);
            var minimumCost = Kruskal(p);

            Console.WriteLine(minimumCost);
        }
    }
}
