using Algo;

namespace AlgoTests.Trees
{
    public class DeleteFromBST
    {
        public Tree<int> deleteFromBST(Tree<int> t, int[] queries) {
            foreach (var q in queries) {
                DeleteOneFromBst(ref t, q);
            }
    
            return t;
        }

        void DeleteOneFromBst(ref Tree<int> t, int q) {
            var parent = default(Tree<int>);
            var node = Find(t, q, ref parent);
    
            // case 1: node not found
            if (node == null) {
                return;
            }

            // case 2: node has left subtree
            if (node.left != null) {
                var rightMostParent = node;
                var rightmost = FindRightmost(node.left, ref rightMostParent);

                SetParentNodeValue(rightMostParent, rightmost, rightmost.left);
                node.value = rightmost.value;

                return;
            }

            if (parent == null) {
                t = t.right;
                return;
            }

            // case 3: node has not left subtree
            SetParentNodeValue(parent, node, node.right);
        }

        private void SetParentNodeValue(Tree<int> nodeParent, Tree<int> node, Tree<int> value)
        {
            if (node.value < nodeParent.value) {
                nodeParent.left = value;
            }
            else {
                nodeParent.right = value;
            }
        }

        Tree<int> Find(Tree<int> t, int q, ref Tree<int> parent) {
            
            if (t == null || t.value == q) {
                return t;
            }

            parent = t;

            return q < t.value 
                ? Find(t.left, q, ref parent) 
                : Find(t.right, q, ref parent);
        }

        Tree<int> FindRightmost(Tree<int> t, ref Tree<int> parent) {
            if (t.right == null) {
                return t;
            }

            parent = t;
            return FindRightmost(t.right, ref parent);
        }
    }
}
