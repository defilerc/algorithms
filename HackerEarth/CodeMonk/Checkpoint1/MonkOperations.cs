namespace HackerEarth.CodeMonk.Checkpoint1
{
    using System;
    using System.Linq;

    public class MonkOperations
    {
        public static void Main(string[] args)
        {
            var d = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var n = d[0];

            var array = new long[n][];

            for (var i = 0; i < n; i++) {
                array[i] = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            }

            var m = array[0].Length;
            var v = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long[] rowsum = new long[n], rowadd = new long[n], rowuni = new long[n], rowmax = new long[n];
            long[] colsum = new long[n], coladd = new long[n], coluni = new long[n], colmax = new long[n];
            
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < m; j++) {
                    rowsum[i] += Math.Abs(array[i][j]);
                    rowadd[i] += Math.Abs(array[i][j] + v[0]);
                }
                rowuni[i] = Math.Abs(v[1]) * n;
                rowmax[i] = Math.Max(Math.Max(rowsum[i], rowadd[i]), rowuni[i]);
            }

            for (var j = 0; j < m; j++) {
                for (var i = 0; i < n; i++) {
                    colsum[j] += Math.Abs(array[i][j]);
                    coladd[j] += Math.Abs(array[i][j] + v[2]);
                }

                coluni[j] = Math.Abs(v[3]) * n;
                colmax[j] = Math.Max(Math.Max(colsum[j], coladd[j]), coluni[j]);
            }

            Console.WriteLine(Math.Max(rowmax.Sum(), colmax.Sum()));
        }
    }
}
