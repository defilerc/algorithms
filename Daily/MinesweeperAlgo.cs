using System.Linq;

namespace Daily
{
    public class MinesweeperAlgo
    {
        public int[][] minesweeper(bool[][] m)
        {
            int l = m.Length, i = 0, j = 0;
            var n = new int[l][];

            for (; i < l; i++) {
                var o = m[i].Length;
                n[i] = new int[o];
                for (; j < o; j++) {
                    n[i][j] =
                        C(m, i - 1, j - 1) + C(m, i - 1, j) + C(m, i - 1, j + 1) +
                        C(m, i, j - 1) + C(m, i, j + 1) +
                        C(m, i + 1, j - 1) + C(m, i + 1, j) + C(m, i + 1, j + 1);
                }
            }

            return n;
        }

        int C(bool[][] m, int i, int j) => i < 0 || j < 0 || i >= m.Length || j >= m[i].Length ? 0 :
            m[i][j] ? 1 : 0;

        object minesweeperShort(bool[][] m) => m.Select((w, i) => w.Select((x, j) =>
            C(m, i - 1, j - 1) + C(m, i - 1, j) + C(m, i - 1, j + 1) +
            C(m, i, j - 1) + C(m, i, j + 1) +
            C(m, i + 1, j - 1) + C(m, i + 1, j) + C(m, i + 1, j + 1)
        ));
    }

    public class MinesweeperAlgoShort
    {
        bool[][] z;

        object minesweeper(bool[][] m) => (z = m).Select((w, i) => w.Select((x, j) =>
            C(i - 1, j - 1) + C(i - 1, j) + C(i - 1, j + 1) +
            C(i, j - 1) + C(i, j + 1) +
            C(i + 1, j - 1) + C(i + 1, j) + C(i + 1, j + 1)
        ));

        int C(int i, int j) => i < 0 || j < 0 || i >= z.Length || j >= z[i].Length ? 0 :
            z[i][j] ? 1 : 0;
    }

}
