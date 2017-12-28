using System;

namespace Algo
{
    public class MaxSubArray
    {
        public int arrayMaxConsecutiveSum2(int[] inputArray)
        {
            return MaxSubarray(inputArray, 0, inputArray.Length - 1).Max;
        }

        MaxInfo MaxSubarray(int[] array, int start, int end)
        {
            if (start == end) {
                return new MaxInfo { Left = start, Right = end, Max = array[start] };
            }

            var half = (end + start) / 2;

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

        MaxInfo MaxCrossing(int[] array, int start, int halfIndex, int end)
        {
            var leftSum = Int32.MinValue;
            var rightSum = Int32.MinValue;

            var endIndex = 0;
            var startIndex = 0;
            var sum = 0;

            for (var i = halfIndex; i >= start; i--) {
                sum += array[i];

                if (sum > leftSum) {
                    leftSum = sum;
                    startIndex = i;
                }
            }

            sum = 0;
            for (var i = halfIndex + 1; i <= end; i++) {
                sum += array[i];

                if (sum > rightSum) {
                    rightSum = sum;
                    endIndex = i;
                }
            }

            return new MaxInfo { Left = startIndex, Right = endIndex, Max = leftSum + rightSum };
        }

        class MaxInfo
        {
            public int Max { get; set; }
            public int Left { get; set; }
            public int Right { get; set; }
        }
    }
}
