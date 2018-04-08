using System;
using System.Text.RegularExpressions;

namespace Daily
{
    public class HugeNumber
    {
        public string hugeNumber(string[] n)
        {
            Array.Sort(n, (a, b) => (b+a).CompareTo(a+b));
            var o = string.Concat(n).TrimStart('0');
            return o == "" ? "0" : o;
        }
    }
}
