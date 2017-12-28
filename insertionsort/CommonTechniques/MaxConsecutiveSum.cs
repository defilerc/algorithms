using System;

namespace Algo.CommonTechniques
{
    public class MaxConsecutiveSum
    {
        public int arrayMaxConsecutiveSum2(int[] inputArray)
        {
            return MaxSubarray(inputArray, 0, inputArray.Length - 1).Max;
        }

        private MaxInfo MaxSubarray(int[] array, int start, int end)
        {
            if (start == end) {
                return new MaxInfo {Max = array[start], Left = start, Right = end};
            }

            var half = (start + end) / 2;

            var left = MaxSubarray(array, start, half);
            var right = MaxSubarray(array, half + 1, end);
            var middle = MaxCrossing(array, start, half, end);

            if (left.Max >= right.Max && left.Max >= middle.Max) {
                return left;
            }

            if (right.Max >= left.Max && right.Max >= middle.Max) {
                return right;
            }

            return middle;
        }

        MaxInfo MaxCrossing(int[] array, int l, int middle, int r)
        {
            var leftSum = Int32.MinValue;
            var maxLeft = 0;

            var rightSum = Int32.MaxValue;
            var maxRight = 0;

            var sum = 0;
            for (var i = middle; i >= 0; i--) {
                sum += array[i];
                if (sum > leftSum) {
                    leftSum = sum;
                    maxLeft = i;
                }
            }

            sum = 0;
            for (var i = middle + 1; i <= r; i++) {
                sum += array[i];
                if (sum > rightSum) {
                    rightSum = sum;
                    maxRight = i;
                }
            }

            return new MaxInfo {Max = leftSum + rightSum, Left = maxLeft, Right = maxRight};
        }

        MaxInfo Max(MaxInfo i1, MaxInfo i2, MaxInfo i3)
        {
            if (i1.Max >= i2.Max) {
                if (i1.Max >= i3.Max) {
                    return new MaxInfo {Max = i1.Max, Left = i1.Left, Right = i1.Right};
                }
                return new MaxInfo {Max = i3.Max, Left = i3.Left, Right = i3.Right};
            }

            if (i2.Max >= i3.Max) {
                return new MaxInfo {Max = i2.Max, Left = i2.Left, Right = i2.Right};
            }

            return new MaxInfo {Max = i3.Max, Left = i3.Left, Right = i3.Right};
        }

        class MaxInfo 
        {
            public int Max { get; set; }
            public int Left { get; set; }
            public int Right { get; set; }
        }
    }
}
