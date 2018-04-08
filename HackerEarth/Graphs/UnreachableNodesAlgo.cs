namespace HackerEarth.Graphs
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class UnreachableNodesAlgo
    {
        public static void Main(string[] args)
        {
            var nm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nm[0]; int m = nm[1];

            var adj = new List<int>[n+1];

            while (m-- > 0) {
                var e = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (adj[e[0]] == null) {
                    adj[e[0]] = new List<int>();
                }

                if (adj[e[1]] == null) {
                    adj[e[1]] = new List<int>();
                }

                adj[e[0]].Add(e[1]);
                adj[e[1]].Add(e[0]);
            }

            var root = int.Parse(Console.ReadLine());

            var visited = new bool[adj.Length];
            Dfs(root, adj, ref visited);

            // counter for non-used 0 index
            Console.WriteLine(visited.Count(v => v == false) - 1);
        }

        static void Dfs(int node, List<int>[] adj, ref bool[] visited)
        {
            if (visited[node]) {
                return;
            }

            visited[node] = true;

            for (var i = 0; i < adj[node].Count; i++) {
                Dfs(adj[node][i], adj, ref visited);
            }
        }
    }
}
