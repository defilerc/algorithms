namespace HackerEarth.CodeMonk.Checkpoint2
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class DynamicArray
    {
        public static void Main(string[] args)
        {
            var nq = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

            var q = nq[1];

            while (q-- > 0) {

                var query = Console.ReadLine().Trim().Split(' ')
                    .Select(int.Parse).ToArray();

                if (query[0] == 1) {
                    list.Insert(list.Count, query[1]);
                } else {
                    list.RemoveAt(list.Count - 1);
                }

                Console.WriteLine(Lis(list, list.Count));
            }
        }

        static int Lis(List<int> arr, int n)
        {
            int i, j, max = 0;
            var lis = new int[n];

            /* Initialize LIS values for all indexes */
            for (i = 0; i < n; i++)
                lis[i] = 1;

            /* Compute optimized LIS values in bottom up manner */
            for (i = 1; i < n; i++)
                for (j = 0; j < i; j++)
                    if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                        lis[i] = lis[j] + 1;

            /* Pick maximum of all LIS values */
            for (i = 0; i < n; i++)
                if (max < lis[i])
                    max = lis[i];

            return max;
        }

    }
}
