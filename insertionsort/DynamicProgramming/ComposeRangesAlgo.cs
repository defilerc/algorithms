using System;
using System.Collections.Generic;
using System.Linq;

namespace Algo.DynamicProgramming
{
    public class ComposeRangesAlgo
    {
        public string[] composeRanges(int[] nums)
        {
            if (!nums.Any()) {
                return new string[] { };
            }

            var output = new List<List<int>> {
                new List<int> { nums[0] }
            };

            if (nums.Length == 1) {
                return new[] { nums[0].ToString() };
            }

            var rangeIndex = 0;
            for (var i = 1; i < nums.Length; i++) {
                if (nums[i] == nums[i - 1] + 1) {
                    output[rangeIndex].Add(nums[i]);
                }
                else {
                    output.Add(new List<int> { nums[i] });
                    rangeIndex++;
                }
            }

            return output.Select(r => r.Count == 1
                ? r.First().ToString()
                : $"{r.First()}->{r.Last()}").ToArray();
        }

        private string[] A(int[] nums)
        {
            if (!nums.Any()) {
                return new string[] {};
            }

            var output = new List<List<int>> {
                new List<int> { nums[0] }
            };

            if (nums.Length == 1) {
                return new[] { nums[0].ToString() };
            }

            var rangeIndex = 0;
            for (var i = 1; i < nums.Length; i++) {
                if (nums[i] == nums[i - 1] + 1) {
                    output[rangeIndex].Add(nums[i]);
                }
                else {
                    output.Add(new List<int> { nums[i] });
                    rangeIndex++;
                }
            }

            return output.Select(r => r.Count == 1 
                ? r.ToString() 
                : $"{r.First()}->{r.Last()}").ToArray();
        }

        //private List<int> Compose(int[] nums, int i, ref List<List<string>> outputs)
        //{
        //    if (!nums.Any()) {
        //        return new List<int>();
        //    }

        //    if (nums.Length == 1) {
        //        return new List<int>(new[] {nums[0] });
        //    }

        //    var range = Compose(nums, i - 1, outputs);

        //    if (range.Last() == nums[i] - 1) {
        //        return new List<int>(range.Concat(new[] {nums[i]}));
        //    }
        //    if (composeRanges())
        //        for (var i = 0; i < nums.Length; i++)
        //        {

        //        }
        //}
    }
}
