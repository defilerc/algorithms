namespace Daily
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HugeNumber
    {
        public string hugeNumber(string[] nums)
        {
            Array.Sort(nums, (a, b) => b.CompareTo(a));

            var nump = new List<string>();
            nump = nump.OrderByDescending(n => n).ToList();

            for (var i = 0; i < nums.Length; i++) {
                if (i == nums.Length - 1) {
                    nump.Add(nums[i]);
                }

                if (nums[i].Length == nums[i + 1].Length) {
                    nump.Add(nums[i]);
                }
            }

            return string.Concat(nump);
        }

        public string hugeNumberRec(string[] nums)
        {
            Array.Sort(nums, (a, b) => b.CompareTo(a));
            var nump = new List<string>();

            Compare(nums, 0, 1, ref nump);

            return string.Concat(nump);
        }

        private void Compare(string[] nums, int i1, int i2,
            ref List<string> nump)
        {
            if (i1 >= nums.Length) {
                return;
            }

            if (i2 >= nums.Length) {
                nump.Add(nums[i1]);
            }

            if (nums[i1].Length == nums[i2].Length) {
                nump.Add(nums[i1]);
                Compare(nums, i1+1, i2+1, ref nump);
            }
        }
    }
}