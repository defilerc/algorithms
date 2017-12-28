using System.Collections.Generic;
using System.Linq;

namespace Algo.HeapStackQueue
{
    public class NextLargerAlgo
    {
        public int[] NextLarger(int[] a)
        {
            var output = new int[a.Length];
            output[a.Length - 1] = -1;

            var stack = new Stack<int>(new[] { a[a.Length - 1] });

            for (var i = a.Length - 2; i >= 1; i--) {

                while (stack.Any() && a[i] > stack.Peek()) {
                    stack.Pop();
                }

                output[i] = stack.Any() && a[i] < stack.Peek() 
                    ? stack.Peek()
                    : -1;

                if (i > 1 && a[i] > a[i - 1]) {
                    stack.Push(a[i]);
                }
            }

            return output;
        }
    }

    public class NextLargerSubmitted
    {
        int[] nextLarger(int[] a)
        {
            for (var i = 0; i < a.Length; i++)
            {
                a[i] = FindNext(a, i);
            }

            return a;
        }

        public int FindNext(int[] a, int i)
        {
            var k = i + 1;
            while (k < a.Length)
            {
                if (a[k] > a[i])
                {
                    return a[k];
                }

                k++;
            }

            return -1;
        }

    }
}
