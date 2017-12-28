using System.Collections.Generic;
using System.Linq;

namespace Daily
{
    public class ChristmasThiefAlgo
    {
        public string[] christmasThief(string[][] c)
        {
            var g = new List<string>();
            var r = new Dictionary<string, List<string>>();

            var w = c.Select(p => p[0]).ToList();

            foreach (var p in c) {
                if (p[0] == p[1]) {
                    g.Add(p[0]);
                    continue;
                }

                if (!w.Contains(p[1])) {
                    g.Add(p[0]);
                    continue;
                }

                if (!r.ContainsKey(p[1])) {
                    r.Add(p[1], new List<string> {p[0]});
                } else {
                    if (r[p[1]].Count == 1) {
                        g.Add(r[p[1]].Single());
                    }
                    g.Add(p[0]);
                    r[p[1]].Add(p[0]);
                }
            }

            return g.OrderBy(i => i).ToArray();
        }
    }
}
