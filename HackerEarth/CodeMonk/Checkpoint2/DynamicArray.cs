namespace HackerEarth.CodeMonk.Checkpoint2
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class DynamicArray
    {
        static int max;
        static List<int> lis;

        public static void Main(string[] args)
        {
            var nq = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

            var q = nq[1]; var n = nq[0];

            max = Lis(list, list.Count);

            while (q-- > 0) {

                var query = Console.ReadLine().Trim().Split(' ')
                    .Select(int.Parse).ToArray();

                if (query[0] == 1) {
                    list.Insert(list.Count, query[1]);
                    lis.Insert(lis.Count, 1);
                } else {
                    list.RemoveAt(list.Count - 1);
                    lis.RemoveAt(lis.Count - 1);
                }

                Console.WriteLine(LastLis(lis, list.Count));
            }
        }

        static int LastLis(List<int> arr, int n)
        {
            var max = 0;

            /* Compute optimized LIS values in bottom up manner */
            for (var i = n-1; i < n; i++)
                for (var j = 0; j < i; j++)
                    if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                        lis[i] = lis[j] + 1;

            /* Pick maximum of all LIS values */
            //for (var i = 0; i < n; i++)
            //    if (max < lis[i])
            //        max = lis[i];

            return Math.Max(max, lis[n-1]);
        }

        static int Lis(List<int> arr, int n)
        {
            lis = new List<int>();

            /* Initialize LIS values for all indexes */
            for (var i = 0; i < n; i++)
                lis.Add(1);

            var max = 0;

            /* Compute optimized LIS values in bottom up manner */
            for (var i = 1; i < n; i++)
                for (var j = 0; j < i; j++)
                    if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                        lis[i] = lis[j] + 1;

            /* Pick maximum of all LIS values */
            for (var i = 0; i < n; i++)
                if (max < lis[i])
                    max = lis[i];

            return max;
        }

    }
}
