using System.Collections.Generic;
using System.Linq;

namespace Algo.Backtracking
{
    public class ClimbingStaircaseAlgo
    {
        public int[][] climbingStaircase(int n, int k)
        {
            var output = new List<List<int>>();

            Climb(k, n, new List<int>(), ref output);

            return output.Select(a => a.ToArray()).ToArray();
        }

        void Climb(int maxStep, int remaining, List<int> solution, ref List<List<int>> output)
        {
            if (remaining == 0) {
                output.Add(solution);
                return;
            }

            if (remaining < 0) {
                return;
            }

            for (var i = 1; i <= maxStep; i++) {
                Climb(maxStep, remaining - i, new List<int>(solution.Concat(new []{i})), ref output);
            }
        }
    }
}
