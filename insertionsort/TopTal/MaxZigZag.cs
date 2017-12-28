using System;

namespace Algo.TopTal
{
    public class MaxZigZag
    {
        public int Solution(Tree<int> tree)
        {
            if (tree == null) {
                return 0;
            }

            if (tree.left == null && tree.right == null) {
                return 0;
            }

            return Math.Max(CountTurns(tree?.left, isLeft: true), CountTurns(tree?.right, isLeft: false)) - 1;
        }

        private int CountTurns(Tree<int> tree, bool isLeft)
        {
            if (tree == null) {
                return 0;
            }

            return isLeft
                ? Math.Max(
                    CountTurns(tree.left, isLeft: true),
                    1 + CountTurns(tree.right, isLeft: false))
                : Math.Max(
                    1 + CountTurns(tree.left, isLeft: true),
                    CountTurns(tree.right, isLeft: false));
        }
    }
}
