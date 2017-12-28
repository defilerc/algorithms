namespace Algo.Trees
{
    public class KthLargestInBST
    {
        public int kthLargestInBST(Tree<int> t, int k)
        {
            var output = 0;

            traverse(t, ref k, ref output);

            return output;
        }

        void traverse(Tree<int> t, ref int remaining, ref int v)
        {
            if (t == null)
            {
                return;
            }

            if (t.left == null && t.right == null)
            {
                if (--remaining == 0)
                {
                    v = t.value;
                }
                return;
            }

            traverse(t.left, ref remaining, ref v);

            if (--remaining == 0)
            {
                v = t.value;
                return;
            }

            traverse(t.right, ref remaining, ref v);
        }
    }
}
