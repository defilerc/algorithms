using System;
using System.Linq;

namespace Daily
{
    public class theLoShuSquarePartIAlgo
    {
        public int[][] theLoShuSquarePartI(int y)
        {
            Func<int, int> f = a => {
                var d = (a + (2013 - y) % 9) % 9;
                return d > 0 ? d : 9 + d;
            };

            return new[] {
                new[] { f(4), f(9), f(2)},
                new[] { f(3), f(5), f(7)},
                new[] { f(8), f(1), f(6)}
            };
        }

        public int[][] theLoShuSquarePartIShort(int y) => new[] {
                new[] {4, 9, 2}, new[] {3, 5, 7}, new[] {8, 1, 6}
            }
            .Select(a => a.Select(b => {
                var d = (b + (2013 - y) % 9) % 9;
                return d > 0 ? d : 9 + d;
            }).ToArray()).ToArray();

        public object theLoShuSquarePartIShortest(int y) {
            var j = "735 681 240".Split();
                
                j.Select(s => {
                var a = s.Select(c => {
                    var b = (c - y) % 9 + 9;
                    return b;
                });
                return a;
            });

            return j;
        }
            
    }
}
