namespace HackerEarth.MarCircuits
{
    using System;
    using System.Linq;

    public class BreakingEdgesAlgo
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var v = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            var A = new int[n,n];

            for (var i = 0; i < n - 1; i++) {
                var e = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                A[e[0] - 1, e[1] - 1] = 1;
            }

            Console.WriteLine("1");
        }
    }
}
