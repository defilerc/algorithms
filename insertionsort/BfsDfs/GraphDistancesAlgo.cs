using System;

namespace Algo.BfsDfs
{
    public class GraphDistancesAlgo
    {
        public int[] graphDistances(int[][] g, int s)
        {
            var distances = new int[g.Length];

            for (var i = 0; i < g.Length; i++) {
                distances[i] = Int32.MaxValue;
            }

            distances[s] = 0;

            for (var v = 0; v < g.Length; v++) {
                for (var i = 0; i < g.Length; i++) {
                    for (var j = 0; j < g[0].Length; j++) {
                        if (g[i][j] == -1 || j == s) {
                            continue;
                        }

                        Relax(distances, g, i, j);
                    }
                }
            }

            return distances;
        }

        public void Relax(int[] distances, int [][] g, int i, int j)
        {
            if (distances[j] > distances[i] + g[i][j]) {
                distances[j] = distances[i] + g[i][j];
            }
        }
    }
}
