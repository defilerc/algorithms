using System;
using System.Collections.Generic;
using System.Linq;

namespace Daily
{

    public class ChristmasToysAlgo
    {

        public int[][] christmasToys(int[][] toys)
        {
            var output = new List<List<int>> {
                new List<int> {0}, 
                new List<int>(toys[0])
            };

            var remaining = new List<int>(toys[0]);

            while (remaining.Any()) {
                var next = new List<int>(); // output[i+1] 

                for (var i = 0; i < remaining.Count; i++) {
                    next.AddRange(toys[remaining[i]].Select(x => x));
                }

                if (next.Any()) {
                    output.Add(new List<int>(next));
                }

                remaining = next;
            }

            return output.Select(o => o.ToArray()).ToArray();
        }

        public object christmasToysShort(int[][] t)
        {
            var o = new List<int[]> {
                new[] {0}, t[0]
            };

            var r = o[1];

            while (r.Any()) {
                var n = new List<int>();

                r.ToList().ForEach(x => n.AddRange(t[x].Select(y => y)));
                var a = n.ToArray();

                if (n.Any()) {
                    o.Add(a);
                }

                r = a;
            }

            return o;
        }
    }
}
