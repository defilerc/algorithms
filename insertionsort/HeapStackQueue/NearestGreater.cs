using System;
using System.Collections.Generic;
using System.Linq;

namespace Algo.HeapStackQueue
{
    public class NearestGreaterAlgo
    {
        public int[] NearestGreater(int[] a)
        {
            var output = new int[a.Length];
            var leftCandidates = new List<NumIndex>();
            var rightCandidates = new Stack<NumIndex>();

            for (var i = 1; i < a.Length; i++) {
                if (a[i - 1] > a[i]) {
                    leftCandidates.Add(new NumIndex {Num = a[i - 1], Index = i - 1});
                }
            }

            for (var i = a.Length - 2; i >= 0; i--) {
                if (a[i] < a[i + 1]) {
                    rightCandidates.Push(new NumIndex {Num = a[i + 1], Index = i + 1});
                }
            }

            for (var i = 0; i < a.Length; i++) {
                var left = PeekLeftCandidate(leftCandidates, a, i);
                var right = PeekRightCandidate(rightCandidates, a, i);

                if (left.Index == -1 && right.Index == -1) {
                    output[i] = -1;
                    continue;
                }

                if (left.Index == -1) {
                    output[i] = right.Index;
                    continue;
                }
               
                if (right.Index == -1) {
                    output[i] = left.Index;
                    continue;
                }

                var leftDistance = Math.Abs(left.Index - i);
                var rightDistance = Math.Abs(right.Index - i);

                output[i] = leftDistance <= rightDistance
                    ? left.Index : right.Index;
            }

            return output;
        }

        private NumIndex PeekRightCandidate(Stack<NumIndex> rightCandidates, int[] a, int i)
        {
            var candidate = new NumIndex() { Num = Int32.MinValue, Index = -1 };

            while (rightCandidates.Any()) {
                candidate = rightCandidates.Peek();

                if (i < candidate.Index && a[i] < candidate.Num) {
                    return candidate;
                }
                
                candidate = rightCandidates.Pop();
            }

            return (a[i] >= candidate.Num || i >= candidate.Index)
                ? new NumIndex { Index = -1 }
                : candidate;
        }

        private NumIndex PeekLeftCandidate(List<NumIndex> leftCandidates, int[] a, int i)
        {
            var candidate = new NumIndex {Num = Int32.MinValue, Index = -1};
            
            while (leftCandidates.Any()) {
                candidate = leftCandidates.First();

                if (leftCandidates.Count > 1 && i > leftCandidates.ElementAt(1).Index) {
                    leftCandidates.RemoveAt(0);
                    candidate = leftCandidates.First();
                }

                if (candidate.Index >= i) {
                    return new NumIndex {Index = -1};
                }

                if (a[i] < candidate.Num) {
                    return candidate;
                }

                candidate = leftCandidates.ElementAt(0);
                leftCandidates.RemoveAt(0);
            }

            return (a[i] >= candidate.Num)
                ? new NumIndex { Index = -1 }
                : candidate;
        }
    }

    public class NumIndex
    {
        public int Num { get; set; }
        public int Index { get; set; }

        public override string ToString()
        {
            return $"Num: {Num}, Index: {Index}";
        }
    }
}
