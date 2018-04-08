using System;

namespace Daily.Feb
{
    public class MSquareAlgo
    {
        public int mSquare(int n)
        {
            var d = new int[] {1, 1, 2, 3, 1};

            if (n < 5) return d[n];

            if (n % 4 == 1) {
                return 2;
            }

            if (!check(n)) {
                return 3;
            }

            return 4;
        }

        bool check(int n)
        {
            var p = new double[1000];
            var m = new double[1000];

            for (var i = 0; i < 30; i++) {
                p[i] = Math.Pow(4, i);
                m[i] = 8 * i + 7;
            }

            for (var i = 0; i < 30; i++) {
                for (var j = 0; j < 30; j++) {
                    if (p[i] * m[j] == n) {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}