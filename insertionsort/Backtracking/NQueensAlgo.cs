using System;
using System.Collections.Generic;
using System.Linq;

namespace Algo.Backtracking
{
    public class NQueensAlgo
    {
        public int[][] nQueens(int n)
        {
            var solutions = new List<List<int>>();

            for (var i = 0; i < n; i++) {
                PlaceQueen(n, new List<int>(), i, ref solutions);
            }

            return solutions.Select(s => s.Select(e => e + 1).ToArray()).ToArray();
        }

        private void PlaceQueen(int n, List<int> queens, int row, ref List<List<int>> solutions)
        {
            if (queens.Count == n && row == 0) {
                solutions.Add(new List<int>(queens));
                return;
            }

            if (IsAttacked(queens, row)) {
                return;
            }

            for (var i = 0; i < n; i++) {
                PlaceQueen(n, new List<int>(queens.Concat(new []{row})), i, ref solutions);
            }
        }

        private bool IsAttacked(List<int> queens, int row)
        {
            if (!queens.Any()) {
                return false;
            }

            if (queens.Contains(row)) {
                return true;
            }

            var diagonal = Enumerable.Range(1, queens.Count).Reverse().ToList();
            var diagonalThreatForward = queens.Zip(diagonal, (x, y) => x + y).ToList();
            var diagonalThreatBackward = queens.Zip(diagonal, (x, y) => x - y).ToList();

            if (diagonalThreatForward.Contains(row) || diagonalThreatBackward.Contains(row)) {
                return true;
            }

            return false;
        }
    }
}
