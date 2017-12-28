using System;

namespace Algo.DynamicProgrammingAdvanced
{
    public class MaximalSquare
    {
        public int maximalSquareDp(char[][] matrix)
        {
            if (matrix == null || matrix.Length == 0) {
                return 0;
            }

            var maxSoFar = 0;
            var dp = new int[matrix.Length, matrix[0].Length];

            for (var i = 0; i < matrix.Length; i++) {
                for (var j = 0; j < matrix[0].Length; j++) {
                    if (matrix[i][j] == '0') {
                        continue;
                    }

                    if (i < 1 || j < 1 || matrix[i - 1][j - 1] == '0') {
                        dp[i, j] = 1;

                        if (maxSoFar == 0) {
                            maxSoFar = 1;
                        }

                        continue;
                    }

                    var growsByOne = true;
                    for (var k = 0; k <= dp[i - 1, j - 1]; k++) {
                        if (i < k || j < k) {
                            growsByOne = false;
                            break;
                        }

                        if (matrix[i][j] == '0' || matrix[i - k][j] == '0' || matrix[i][j - k] == '0') {

                            dp[i, j] = k - 1;
                            growsByOne = false;
                            break;
                        }
                    }

                    if (growsByOne) {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }

                    if (maxSoFar < dp[i, j]) {
                        maxSoFar = dp[i, j];
                    }
                }
            }

            return maxSoFar * maxSoFar;
        }

        public int maximalSquare(char[][] matrix)
        {
            if (matrix == null || matrix.Length == 0) {
                return 0;
            }

            var maxSquare = 0;

            for (var i = 0; i < matrix.Length; i++) {
                for (var j = 0; j < matrix[0].Length; j++) {
                    if (matrix[i][j] > '0') {

                        if (maxSquare == 0) {
                            maxSquare = 1;
                        }

                        for (var x = 0; x <= char.GetNumericValue(matrix[i][j]) + 1; x++) {

                            if (i < matrix.Length - 1 && j < matrix[0].Length - 1 && i + 1 - x < matrix.Length && j + 1 - x < matrix[0].Length) {
                                if (matrix[i + 1][j + 1] == '1' && matrix[i + 1][j + 1 - x] == '1' && matrix[i + 1 - x][j + 1] == '1') {
                                    matrix[i + 1][j + 1] = (char) (matrix[i][j] + 1);

                                    if (char.GetNumericValue(matrix[i + 1][j + 1]) > maxSquare) {
                                        maxSquare = (int) char.GetNumericValue(matrix[i + 1][j + 1]);
                                    }
                                }
                            }

                        }
                    }
                }
            }

            return maxSquare * maxSquare;
        }

        public int FindSquare(char[][] matrix, int x, int y)
        {
            if (x < 0 || y < 0) {
                return 0;
            }

            if (x == 0 && y == 0) {
                return matrix[x][y] == '1' ? 1 : 0;
            }

            var horizontal = matrix[x + 1][y];
            var vertical = matrix[x][y + 1];
            var diagonal = matrix[x + 1][y + 1];

            return Math.Max(horizontal,
                Math.Max(vertical, diagonal));

        }
    }
}
