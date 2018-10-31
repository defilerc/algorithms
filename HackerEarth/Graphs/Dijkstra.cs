namespace HackerEarth.Graphs
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class DijkstraAlgo
    {
        const int MAX = 2000000000;

        public class WeightVertexComparer : IComparer<WeightVertex>
        {
            public int Compare(WeightVertex x, WeightVertex y) => x.Weight.CompareTo(y.Weight);
        }

        public class WeightVertex
        {
            public int Weight { get; set; }
            public int Vertex { get; set; }

            public WeightVertex(int weight, int vertex)
            {
                Weight = weight; Vertex = vertex;
            }
        }

        public static void Main(string[] args)
        {
            var nm = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int n = nm[0], m = nm[1];
            var v = new List<WeightVertex>[n + 1];

            var line = "";
            for (var i = 0; i < m; i++) {
                line = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(line)) {
                    continue;
                }

                var e = line.Trim().Split(' ').Select(int.Parse).ToArray();
                int x = e[0], y = e[1], w = e[2];

                if (v[x] == null) {
                    v[x] = new List<WeightVertex>();
                }

                v[x].Add(new WeightVertex(w, y));
            }

            var dist = new int[n + 1];
            var vis = new bool[n + 1];

            for (var i = 0; i <= n; i++) {
                dist[i] = MAX;
            }

            dist[0] = 0; dist[1] = 0;

            var s = new SortedSet<WeightVertex>(new WeightVertexComparer());

            s.Add(new WeightVertex(0, 1));

            while (s.Any()) {

                var p = s.First();
                s.Remove(p);

                int x = p.Vertex; int wei = p.Weight;
                if (vis[x]) continue;
                vis[x] = true;

                if (v[x] == null) {
                    continue;
                }

                for (int i = 0; i < v[x].Count; i++) {
                    int e = v[x][i].Vertex; int w = v[x][i].Weight;
                    if (dist[x] + w < dist[e]) {            // check if the next vertex distance could be minimized
                        dist[e] = dist[x] + w;
                        s.Add(new WeightVertex(dist[e], e));           // insert the next vertex with the updated distance
                    }
                }
            }

            Console.WriteLine(string.Join(" ", dist).Substring(4));
        }
    }

    public class MinPriorityQueue
    {
        private static int Length = 0;
        private static int[] arr = new int[1000000];

        public static int Peek(int[] arr) => arr[1];

        public static int Pop()
        {
            if (Length == 0) {
                return -1;
            }

            var min = arr[1];
            arr[1] = arr[Length];

            Length--;
            MinHeapify(1);

            return min;
        }

        public static void MinHeapify(int i)
        {
            int smallest;
            int left = 2 * i;
            int right = 2 * i + 1;

            if (left <= Length && arr[left] < arr[i]) {
                smallest = left;
            } else {
                smallest = i;
            }

            if (right <= Length && arr[right] < arr[smallest]) {
                smallest = right;
            }

            if (smallest != i) {
                // Swap(arr[i], arr[smallest]);
                var tmp = arr[i];
                arr[i] = arr[smallest];
                arr[smallest] = tmp;

                MinHeapify(smallest);
            }
        }
    }

}
