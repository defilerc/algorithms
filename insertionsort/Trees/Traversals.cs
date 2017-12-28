using System;

namespace Algo.Trees
{
    public class Traversals
    {
        public void PreOrder(Tree<int> t)
        {
            if (t == null) {
                return;
            }

            Console.Write($"{t.value} ");
            PreOrder(t.left);
            PreOrder(t.right);
        }

        public void InOrder(Tree<int> t)
        {
            if (t == null) {
                return;
            }

            InOrder(t.left);
            Console.Write($"{t.value} ");
            InOrder(t.right);
        }

        public void PostOrder(Tree<int> t)
        {
            if (t == null) {
                return;
            }

            PostOrder(t.left);
            PostOrder(t.right);
            Console.Write($"{t.value} ");
        }
    }
}
