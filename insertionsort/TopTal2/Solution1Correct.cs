using System;
using System.Collections.Generic;


namespace Algo.TopTal2
{
    public class Solution1Correct
    {
        public int solution(Tree T)
        {
            if (T == null) {
                return 0;
            }

            var seen = new HashSet<int>();

            return Distinct(T, 0, seen);
        }

        private int Distinct(Tree tree, int max, HashSet<int> seen)
        {
            if (tree == null) {
                return max;
            }

            if (!seen.Contains(tree.x)) {
                max++;
                seen.Add(tree.x);
            }

            if (tree.l != null && tree.r != null) {
                return Math.Max(
                    Distinct(tree.l, max, new HashSet<int>(seen)), 
                    Distinct(tree.r, max, new HashSet<int>(seen)));
            }

            return Distinct(tree.l ?? tree.r, max, seen);
        }
    }
}
