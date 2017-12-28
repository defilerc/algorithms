using System;
using System.Collections.Generic;
using System.Linq;

namespace Algo.BfsDfs
{
    public class LongestPathAlgo
    {
        public int longestPath(string fileSystem)
        {
            var max = new List<int>();
            var paths = fileSystem.Split('\r');

            for (var i = 0; i < paths.Length; i++) {
                if (paths[i].LastIndexOf("\t", StringComparison.Ordinal) == -1) {
                    FindPath(paths, i, 0, 0, ref max);
                }
            }

            //FindPath(paths, 0, 0, 0, ref max);

            return max.Any() ? max.Max() - 1 : 0;
        }

        private void FindPath(string[] paths, int i, int level, int cur, ref List<int> max)
        {
            cur += paths[i].Substring(level).Length + 1;

            for (var j = i + 1; j < paths.Length; j++) {
                if (paths[j].LastIndexOf("\t", StringComparison.Ordinal) == level - 1) {
                    break;
                }

                if (paths[j].LastIndexOf("\t", StringComparison.Ordinal) == level) {
                    FindPath(paths, j, level + 1, cur, ref max);
                }
            }

            if (paths[i].Contains(".")) {
                max.Add(cur);
            }
        }
    }
}
