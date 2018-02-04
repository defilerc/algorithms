using System;
using System.Collections.Generic;

namespace Algo.TopTal2
{
    public class Solution1
    {
        public int solution(Tree T)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (T == null) {
                return 0;
            }

            int max = 1;
            var seen = new HashSet<int>();

            //return Distinct(T, max, seen);
            return Math.Max(Distinct(T.l, max, new HashSet<int>(new[] { T.x })), Distinct(T.r, max, new HashSet<int>(
                new[] {T.x})));
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

            return Math.Max(Distinct(tree.l, max, seen), Distinct(tree.r, max, seen));
        }
    }
}
