using System.Collections.Generic;
using System.Linq;

namespace Algo.Backtracking
{
    public class SumSubsetsAlgo
    {
        public int[][] sumSubsets(int[] arr, int num)
        {
            if (!arr.Any()) {
                return new int[][] { new int[] {} };
            }

            var solutions = new List<List<int>>();

            for (var i = 0; i < arr.Length; i++) {
                Sum(arr, num, i, new List<int>(new[] { arr[i] }), ref solutions);
            }

            return solutions.Select(s => s.ToArray()).ToArray();
        }

        private void Sum(int[] arr, int num, int i, List<int> possible, ref List<List<int>> solutions)
        {
            if (i > arr.Length || possible.Sum() > num) {
                return;
            }

            if (possible.Sum() == num && solutions.All(s => !s.SequenceEqual(possible))) {
                solutions.Add(possible);
                return;
            }

            for (var j = i + 1; j < arr.Length; j++) {
                Sum(arr, num, j, new List<int>(possible.Concat(new[] { arr[j] })), ref solutions);
            }
        }
    }
}
