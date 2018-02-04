using System.Linq;
using System.Text.RegularExpressions;

namespace Daily.Feb
{
    public class BreakDown2Algo
    {
        object breakDown2(string[] s)
        {
            var a = s.SelectMany(x => Regex.Split(x, @"[\D]+").Select(long.Parse)).ToList();
            var b = a[1] * a[3] * a[5];
            return new [] {a[0], a[2], a[4], b, b / a[1], b / a[3], b / a[5] };
        }
    }
}
