namespace HackerEarth.Graphs
{
    using System;
    using System.Linq;

    public class GraphRepresentationAlgo
    {
        public static void Main(string[] args)
        {
            var nm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nm[0], m = nm[1];
            var adj = new bool[n+1][];

            for (var i = 0; i < n+1; i++) {
                adj[i] = new bool[n+1];
            }

            while (m-- > 0) {
                var e = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                adj[e[0]][e[1]] = true;
            }

            var q = int.Parse(Console.ReadLine());

            while (q-- > 0) {
                var e = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Console.WriteLine(adj[e[0]][e[1]] ? "YES" : "NO");
            }
        }
    }
}
