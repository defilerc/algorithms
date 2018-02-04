namespace HackerEarth
{
    using System;
    using System.Linq;

    public class SortSubstring
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (var i = 0; i < N; i++) {
                var r = Console.ReadLine().Split(' ');
                Console.WriteLine(SortSub(r[0], int.Parse(r[1]), int.Parse(r[2])));
            }
        }

        static string SortSub(string s, int n, int m) => 
            $"{s.Substring(0, n)}{string.Concat(s.Substring(n, m-n+1).OrderByDescending(x => x))}{s.Substring(m + 1, s.Length - 1 - m)}";
    }
}
