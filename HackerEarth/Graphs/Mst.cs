namespace HackerEarth.Graphs
{
    using System;
    using System.Linq;

    public class MinimumSpanningTree
    {

        const int MAX = 10005;
        static int[] id = new int[MAX];
        static int nodes, edges;
        static Tuple<long, Tuple<int, int>>[] p = new Tuple<long, Tuple<int, int>>[MAX];

        static void Init()
        {
            for (int i = 0; i < MAX; ++i)
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
            int x, y;
            long cost, minimumCost = 0;
            for (int i = 0; i < edges; ++i) {
                // Selecting edges one by one in increasing order from the beginning
                x = p[i].Item2.Item1;
                y = p[i].Item2.Item2;
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
            Init();

            var nm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int nodes = nm[0], edges = nm[1];

            for (int i = 0; i < edges; ++i) {
                var inp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

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
