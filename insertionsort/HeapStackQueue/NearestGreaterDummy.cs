using System;

namespace Algo.HeapStackQueue
{
    public class NearestGreaterDummy
    {
        public int[] nearestGreater(int[] a)
        {
            var output = new int[a.Length];

            for (var i = 0; i < a.Length; i++) {
                output[i] = this.NearestGreater(a, i);
            }

            return output;
        }

        private int NearestGreater(int[] a, int i)
        {
            var right = -1;
            for (var k = i + 1; k < a.Length; k++) {
                if (a[k] > a[i]) {
                    right = k;
                    break;
                }
            }

            var left = -1;
            for (var k = i - 1; k >= 0; k--) {
                if (a[k] > a[i]) {
                    left = k;
                    break;
                }
            }

            if (left == -1 && right == -1) {
                return -1;
            }

            if (left == -1) {
                return right;
            }

            if (right == -1) {
                return left;
            }

            return Math.Abs(left - i) <= Math.Abs(right - i) ? left : right;
        }
    }
}
