using System.Collections.Generic;
using System.Linq;

namespace Algo.Backtracking
{
    public class CombinationSum
    {
        public string combinationSum(int[] a, int sum)
        {
            var input = a.ToList();
            input.Sort();
            var b = input.ToArray();

            var solutions = new List<List<int>>();

            for (var i = 0; i < b.Length; i++) {
                Sum(b, sum, i, new List<int>(new[] { b[i] }), ref solutions);
            }

            return string.Join("", 
                solutions.Select(s => $"({string.Join(" ", s.Select(e => e))})"));

        }

        private void Sum(int[] a, int sum, int i, List<int> possible, ref List<List<int>> solutions)
        {
            if (i >= a.Length || possible.Sum() > sum) {
                return;
            }

            if (possible.Sum() == sum) {
                solutions.Add(possible);
                return;
            }

            for (var j = i; j < a.Length; j++) {
                Sum(a, sum, j, new List<int>(possible.Concat(new[] { a[j] })), ref solutions);
            }
        }
    }
}

