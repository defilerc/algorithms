using System;

namespace Algo
{
    public class MergeSort
    {
        public void Sort(int[] array, int l, int r)
        {
            if (l == r) {
                return;
            }

            var half = (r + l) / 2;

            Sort(array, l, half);
            Sort(array, half + 1, r);

            Merge(array, l, half, r);
        }

        private void Merge(int[] array, int l, int half, int r)
        {
            var length1 = half - l + 2;
            var length2 = r - half + 1;

            var sorted1 = new int[length1];
            var sorted2 = new int[length2];

            for (var i = 0; i < length1 - 1; i++) {
                sorted1[i] = array[l + i];
            }
            sorted1[length1 - 1] = Int32.MaxValue;

            for (var i = 0; i < length2 - 1; i++) {
                sorted2[i] = array[half + 1 + i];
            }
            sorted2[length2 - 1] = Int32.MaxValue;

            var index1 = 0;
            var index2 = 0;

            for (var i = l; i <= r; i++) {
                if (sorted1[index1] <= sorted2[index2]) {
                    array[i] = sorted1[index1++];
                } else {
                    array[i] = sorted2[index2++];
                }
            }
        }
    }
}
