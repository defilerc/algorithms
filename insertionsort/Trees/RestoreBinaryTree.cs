using System.Collections.Generic;

namespace Algo.Trees
{
    public class RestoreBinaryTree
    {
        public Tree<int> restoreBinaryTree(int[] inorder, int[] preorder)
        {
            if (inorder.Length == 0) {
                return null;
            }

            Tree<int> returnHead = null;
            var exists = new Dictionary<int, bool>();
            
            Tree<int> prevHead = null;
            Tree<int> prevLeft = null;
            var index = 0;

            foreach (var value in inorder) {

                if (exists.ContainsKey(value)) {
                    continue;
                }

                Tree<int> head = null;

                do {

                    var node = new Tree<int>() {
                        value = preorder[index]
                    };

                    exists.Add(preorder[index], true);

                    if (returnHead == null) {
                        returnHead = node;
                    }

                    if (head == null) {
                        head = node;
                    }

                    if (prevLeft != null) {
                        prevLeft.left = node;
                    }

                    prevLeft = node;

                } while (preorder[index++] != value);

                if (prevHead != null) {
                    prevHead.right = head;
                }

                prevHead = head;
                prevLeft = null;
            }

            return returnHead;
        }
    }
}
