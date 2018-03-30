namespace HackerEarth.Disjoint
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DisjointAlgo
    {
        public static void Main(string[] args)
        {
            var nm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = nm[0]; var m = nm[1];

            var dict = new Dictionary<int, int>();
            var set = Init(n, dict);

            while (m-- > 0) {
                var edge = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                Union(set, edge[0], edge[1], dict);
                Console.WriteLine(string.Join(" ", dict.Values.Where(v => v > 0).OrderBy(v => v)));
            }
        }

        public static int[] Init(int length, Dictionary<int, int> dict)
        {
            var array = new int[length + 1];

            for (var i = 1; i <= length; i++) {
                array[i] = i;
                dict.Add(i, 1);
            }

            return array;
        }

        public static void Union(int[] array, int a, int b, Dictionary<int, int> dict)
        {
            var tmp = array[a];
            for (var i = 0; i < array.Length; i++) {
                if (array[i] == tmp) {
                    array[i] = array[b];
                    dict[tmp]--;
                    dict[array[b]]++;
                }
            }
        }

        public static bool Find(int[] array, int a, int b)
        {
            return a < array.Length && b < array.Length && array[a] == array[b];
        }

        public static bool QuickFind(int[] array, int a, int b)
        {
            return 
                a < array.Length && 
                b < array.Length && 
                Root(array, a) == Root(array, b);
        }

        public static void QuickUnion(int[] array, int a, int b)
        {
            var roota = Root(array, a);
            var rootb = Root(array, b);

            array[roota] = array[rootb];
        }

        public static int Root(int[] array, int i)
        {
            while (array[i] != i) {
                i = array[i];
            }

            return i;
        }
    }
}
