using System;

namespace HackerEarth.Sorting
{
    public class MergeSortAlgo
    {
        public static void Main(string[] args)
        {
            var a = new[] {5, 4, 3, 1, 2};

            MergeSort(a, 0, a.Length - 1);
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

        private static void Merge(int[] a, int start, int mid, int end)
        {
            int left = start, k = 0;
            var right = mid + 1;
            var sorted = new int[end - start + 1];

            for (var i = start; i <= end; i++) {
                if (left > right) {
                    sorted[k++] = a[right++];
                } else if (right > end) {
                    sorted[k++] = a[left++];
                } else if (a[left] > a[right]) {
                    sorted[k++] = a[right++];
                } else {
                    sorted[k++] = a[left++];
                }
            }

            k = 0;
            for (var i = start; i <= end; i++) {
                a[i] = sorted[k++];
            }
        }
    }
}
