using System;

namespace Daily
{
    public class HugeNumber
    {
        public string hugeNumber(string[] nums)
        {
            Array.Sort(nums, (a, b) => b.CompareTo(a));
            return string.Concat(nums);
        }
    }
}
