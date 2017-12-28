using System.Collections.Generic;
using System.Linq;

namespace Algo.CommonTechniques
{
    public class LongestSubArrayBySum
    {
        public int[] findLongestSubarrayBySum(int s, int[] arr)
        {
            int start = 0, end = 0, sum = 0, longest = -1;
            var solution = new[] { -1, -1 };

            while (end < arr.Length) {

                while (sum <= s && end < arr.Length) {
                    sum += arr[end];

                    if (sum == s && (end - start + 1) > longest) {
                        solution = new []{start + 1, end + 1};
                        longest = end - start + 1;
                    }

                    if (sum > s) {
                        break;
                    }

                    end++;
                }

                while (sum > s & start < end) {
                    sum -= arr[start];
                    start++;

                    if (sum == s && (end - start + 1) > longest) {
                        solution = new[] {start + 1, end + 1};
                        longest = end - start + 1;
                    }
                }
                end++;
            }

            return solution[0] == -1 ? new[] {-1} : solution;
        }

        // wrong algorithm
        public int[] findLongestSubarrayBySumKadane(int k, int[] arr)
        {
            var n = arr.Length;
            int idx = 0, sum = 0, i = 0;

            for (; i < n; i++) {
                sum += arr[i];
                if (sum > k) {
                    i = idx++;
                    sum = 0;
                }
                else if (sum == k) {
                    return new int[] { idx + 1, i + 1 };
                }
            }

            return new[] {-1};
        }
    }
}
