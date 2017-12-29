namespace Daily
{
    using System.Collections.Generic;
    using System.Linq;

    public class HugeNumber
    {
        public string hugeNumber(string[] nums)
        {
            var maxLength = nums.Max(n => n.Length);
            var nump = new List<string>();

            foreach (var num in nums) {
                nump.Add(num.PadRight(maxLength, 'x'));
            }

            nump = nump.OrderByDescending(n => n).ToList();
            //Array.Sort(nump, (a, b) => b.CompareTo(a));
            return string.Concat(nump).Replace("x", "");
        }
    }
}
