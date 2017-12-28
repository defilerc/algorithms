using System;
using System.Linq;

namespace HackerRank
{
    public class BoardCuttingAlgo
    {
        public static void Main(String[] args)
        {
            var q = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < q; i++) {

                Console.ReadLine().Split(' ');

                var cy = Console.ReadLine().Split(' ').Select(x => Convert.ToUInt64(x));
                var cx = Console.ReadLine().Split(' ').Select(x => Convert.ToUInt64(x));

                Console.WriteLine(BoardCutting(cx.ToArray(), cy.ToArray()));
            }

            Console.ReadLine();
        }

        public static ulong BoardCutting(ulong[] cx, ulong[] cy)
        {
            Array.Sort(cx, (a, b) => b.CompareTo(a));
            Array.Sort(cy, (a, b) => b.CompareTo(a));

            int xi = 0, yi = 0;
            ulong xcuts = 0, ycuts = 0;
            ulong total = 0;

            while (xi < cx.Length || yi < cy.Length) {
                if (xi >= cx.Length) {
                    ycuts++;
                    total += cy[yi++] * (xcuts + 1);
                    continue;
                }

                if (yi >= cy.Length) {
                    xcuts++;
                    total += cx[xi++] * (ycuts + 1);
                    continue;
                }

                if (cy[yi] >= cx[xi]) {
                    ycuts++;
                    total += cy[yi++] * (xcuts + 1);
                }
                else {
                    xcuts++;
                    total += cx[xi++] * (ycuts + 1);
                }
            }

            return total % 1000000007;
        }
    }
}