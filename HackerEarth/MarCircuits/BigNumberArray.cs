namespace HackerEarth.MarCircuits
{
    using System;
    using System.Linq;

    public class BigNumberArray
    {
        public static void Main (string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            var nq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nq[0], q = nq[1];

            var array = new long[n];

            while (t-- > 0) { 
                while (q-- > 0) {
                    var query = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    int x = query[1] - 1, y = query[2] - 1;

                    if (query[0] == 2) {
                        Console.WriteLine(array[x] == array[y] ? "YES" : "NO");
                        continue;
                    }
                
                    int l = query[3], r = query[4];
                    long mask = (1 << (r + 1)) - (1 << l);
                    for (var i = x; i <= y; i++) {
                        array[i] ^= mask;
                    }
                }
            }
        }
    }
}
