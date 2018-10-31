namespace UVa
{
    using System;
    using System.Collections.Generic;

    public class UVa10911
    {
        public double MinDistance(int N, int[][] houses) 
        {
            var sumMinDist = 0D;
            var list = new List<int[]>(houses);

            while (list.Count > 1) {

                var minIndex = 0;
                var dist = new double[2 * N];
                var minDist = double.MaxValue;

                for (var i = 1; i < list.Count; i++) {
                    dist[i] = Math.Sqrt(
                            Math.Pow(list[0][0] - list[i][0], 2) +
                            Math.Pow(list[0][1] - list[i][1], 2)
                        );

                    if (dist[i] < minDist) {
                        minIndex = i;
                        minDist = dist[i];
                    }
                }

                list.RemoveAt(0);
                list.RemoveAt(minIndex - 1);
                sumMinDist += minDist;
            }

            return Math.Round(sumMinDist, 2);
        }
    }
}
