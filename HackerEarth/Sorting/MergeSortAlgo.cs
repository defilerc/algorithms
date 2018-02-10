namespace HackerEarth.Sorting
{
    using System;
    using System.Linq;

    public class MergeSortAlgo
    {
        private static ulong count = 0;

        public static void Main(string[] args)
        {
            //var N = int.Parse(Console.ReadLine());
            //var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var array = new[] {5, 4, 3, 2, 1};
            //var array = new[] {1, 4, 3, 2, 5};
            int N = array.Length;

            MergeSort(array, 0, N - 1);

            Console.WriteLine(count);
        }

        private static void MergeSort(int[] a, int start, int end)
        {
            if (start >= end) {
                return;
            }

            var mid = start + (end - start) / 2;

            MergeSort(a, start, mid);
            MergeSort(a, mid + 1, end);

            Merge(a, start, mid, end);
        }

        private static void MyMerge(int[] a, int start, int mid, int end)
        {
            int p = start, k = 0;
            int q = mid + 1;
            var b = new int[end - start + 1];

            for (var i = start; i <= end; i++) {
                if (p > q) {
                    b[k++] = a[q++];
                } else if (q > end) {
                    b[k++] = a[p++];
                } else if (a[p] <= a[q]) {
                    b[k++] = a[p++];
                } else {
                    count += (ulong) (mid - p + 1);
                    b[k++] = a[q++];
                }
            }

            k = 0;
            for (var i = start; i <= end; i++) {
                a[i] = b[k++];
            }
        }

        private static void Merge(int[] a, int start, int mid, int end)
        {
            int p = start, k = 0;
            int q = mid + 1;
            var b = new int[end - start + 1];

            while (p <= mid && q <= end) {

                if (a[p] <= a[q])
                    b[k++] = a[p++];
                else if (a[p] > a[q]) {
                    b[k++] = a[q++];
                    count += (ulong) (mid - p + 1);
                }
            }

            while (p <= mid) {
                b[k++] = a[p++];
            }

            while (q <= end) {
                b[k++] = a[q++];
            }

            k = 0;
            for (var i = start; i <= end; i++) {
                a[i] = b[k++];
            }
        }
    }
}
