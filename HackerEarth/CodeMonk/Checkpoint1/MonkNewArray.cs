namespace HackerEarth.CodeMonk.Checkpoint1
{
    using System;
    using System.Linq;

    public class MonkNewArray
    {
        public static void Main(string[] args)
        {
            var d = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = d[0], m = d[1];

            var array = new decimal[n][];

            for (var i = 0; i < n; i++) {
                array[i] = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
                Array.Sort(array[i]);
            }

            var ans = decimal.MaxValue;
            for (var i = 0; i < n-1; i++) {
                for (var j = 0; j < m; j++) {
                    var p = BinSearch(0, m - 1, array[i][j], array[i + 1]);
                    ans = Math.Min(ans, Math.Abs(array[i + 1][p] - array[i][j]));

                    if (p - 1 >= 0) {
                        ans = Math.Min(ans,
                            Math.Abs(array[i + 1][p - 1] - array[i][j]));
                    }
                }
            }

            Console.WriteLine(ans);
        }

        static int BinSearch(int low, int high, decimal n, decimal[] arr)
        {
            var mid = (low + high) / 2;

            if (low < high) {
                return arr[mid] < n 
                    ? BinSearch(mid + 1, high, n, arr) 
                    : BinSearch(low, mid - 1, n, arr);
            }

            return low;
        }
    }
}
