using System.Collections.Generic;

namespace Algo.HeapStackQueue
{
    public class MinimumOnStackAlgo
    {
        public int[] MinimumOnStack(string[] operations)
        {
            var mins = new Stack<int>();
            var nums = new Stack<int>();

            var output = new List<int>();

            for (var i = 0; i < operations.Length; i++)
            {
                if (operations[i] == "pop")
                {
                    var num = nums.Pop();

                    if (num == mins.Peek())
                    {
                        mins.Pop();
                    }
                }
                else if (operations[i] == "min")
                {
                    output.Add(mins.Peek());
                }
                else
                {
                    var num = int.Parse(operations[i].Substring(5));
                    nums.Push(num);

                    if (mins.Count == 0 || num < mins.Peek())
                    {
                        mins.Push(num);
                    }
                }
            }

            return output.ToArray();
        }
    }
}
