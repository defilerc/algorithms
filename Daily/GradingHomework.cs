using System;
using System.Text.RegularExpressions;

namespace Daily
{
    public class GradingHomeworkAlgo
    {
        public double gradingHomework(string[][] q) {
            var s = 0D;
            foreach (var i in q) {
                var g = Regex.Match(Regex.Replace(i[0], @"\s+", ""), @"(-?\d+)=(-?\d*)x([\+-]?\d+)?").Groups;

                s += c(g[1].Value) == c(g[2].Value == "-" ? "-1" : g[2].Value) *
                     c(i[1]) + c(g[3].Value == "" ? "0" : g[3].Value) ? 100 : 0;
            }

            return Math.Round(s / q.Length, 3);
        }

        Func<string, int> c = Convert.ToInt32;
    }

}
