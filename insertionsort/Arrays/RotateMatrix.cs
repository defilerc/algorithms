namespace Algo
{
    public class RotateMatrix
    {
        public int[][] rotateImage(int[][] a) {

            var n = a.Length;
            var circles = n / 2;

            for (var c = 0; c < circles; c++)
            {
                for (var i = c; i < n - (c + 1); i++)
                {
                    var tmp = a[c][i];

                    a[c][i] = a[n - i - 1][c];

                    a[n - i - 1][c] = a[n - (c + 1)][n - i - 1];

                    a[n - (c + 1)][n - i - 1] = a[i][n - (c + 1)];

                    a[i][n - (c + 1)] = tmp;
                }
            }

            return a;
        }
    }
}
