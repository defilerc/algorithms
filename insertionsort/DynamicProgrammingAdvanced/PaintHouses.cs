using System;
using System.Linq;

namespace Algo.DynamicProgrammingAdvanced
{
    public class PaintHouses
    {
        public int paintHouses(int[][] cost)
        {
            var minCost = new int[cost.Length, 3];

            minCost[0, 0] = cost[0][0];
            minCost[0, 1] = cost[0][1];
            minCost[0, 2] = cost[0][2];

            for (var i = 1; i < cost.Length; i++) {
                minCost[i, 0] = Math.Min(minCost[i - 1, 1], minCost[i - 1, 2]) + cost[i][0];
                minCost[i, 1] = Math.Min(minCost[i - 1, 0], minCost[i - 1, 2]) + cost[i][1];
                minCost[i, 2] = Math.Min(minCost[i - 1, 0], minCost[i - 1, 1]) + cost[i][2];
            }

            return Min(minCost[cost.Length - 1, 0], minCost[cost.Length - 1, 1], minCost[cost.Length - 1, 2]);
        }


        public int paintHousesMemo(int[][] cost)
        {
            var dp = new int[cost.Length, 3];

            var minCost = Min(
                GetCost(cost, cost.Length - 1, Color.Red, ref dp),
                GetCost(cost, cost.Length - 1, Color.Blue, ref dp),
                GetCost(cost, cost.Length - 1, Color.Green, ref dp));

            return minCost;
        }

        private int GetCost(int[][] cost, int n, Color color, ref int[,] dp)
        {
            if (n == 0) {
                return cost[0][(int)color];
            }

            if (dp[n, (int) color] > 0) {
                return dp[n, (int) color];
            }

            var others = new[] {Color.Red, Color.Blue, Color.Green}.Except(new [] {color}).ToList();

            return dp[n, (int)color] = Math.Min(
                cost[n][(int)color] + GetCost(cost, n - 1, others[0], ref dp), cost[n][(int) color] + GetCost(cost, n - 1, others[1], ref dp));
        }

        private int Min(int i1, int i2, int i3) => Math.Min(i1, Math.Min(i2, i3));

        private enum Color
        {
            Red = 0,
            Blue = 1,
            Green = 2
        }
    }
}
