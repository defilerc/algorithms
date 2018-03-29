namespace HackerEarth.Graphs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Bfs
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            var adj = new List<int>[n];

            for (var i = 0; i < n - 1; i++) {

                var edge = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (adj[edge[0] - 1] == null) {
                    adj[edge[0] - 1] = new List<int>();
                }

                if (adj[edge[1] - 1] == null) {
                    adj[edge[1] - 1] = new List<int>();
                }

                adj[edge[0] - 1].Add(edge[1] - 1);
                adj[edge[1] - 1].Add(edge[0] - 1);
            }

            var level = new int[n];
            var visited = new bool[n];
            var children = new Queue<int>();

            children.Enqueue(0);
            visited[0] = true;
            level[0] = 1;

            while (children.Count > 0) {

                var node = children.Dequeue();

                for (var i = 0; i < adj[node]?.Count; i++) {

                    if (visited[adj[node][i]]) {
                        continue;
                    }

                    visited[adj[node][i]] = true;
                    children.Enqueue(adj[node][i]);
                    level[adj[node][i]] = level[node] + 1;
                }
            }

            var x = int.Parse(Console.ReadLine());
            Console.WriteLine(level.Count(l => l == x));
        }
    }
}
