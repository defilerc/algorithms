using System.Linq;

namespace Daily.Feb
{
    public class CommonPointsAlgo
    {
        public int commonPoints(int l1, int r1, int l2, int r2)
        {
            int x = 0;
            for (var i = -10; i <= 10; i++) {
                x += (l1 < i && i < r1 && l2 < i && i < r2) ? 1 : 0;
            }

            return x;
        }

        public int commonPointsShort(int a, int b, int c, int d) =>
            Enumerable.Range(-10,21).Count(x => a < x && x < b && c < x && x < d);

        int commonPointsStudy(int l1, int r1, int l2, int r2) =>
            r1 <= l2 ? 0 : ((r1 < r2 ? r1 : r2) - (l1 > l2 ? l1 : l2) - 1);

    }
}
