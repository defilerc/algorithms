namespace Algo.Trees
{
    public class IsSubTree
    {
        public bool isSubtree(Tree<int> t1, Tree<int> t2) {
            if (t2 == null) {
                return true;
            }
    
            if (t1 == null) {
                return false;
            }
    
            if (AreTheSame(t1, t2)) {
                return true;
            }
    
            return isSubtree(t1.left, t2) || isSubtree(t1.right, t2);
        }

        bool AreTheSame(Tree<int> t1, Tree<int> t2) {
            if (t1 == null && t2 == null) {
                return true;
            }
    
            if (t1 != null || t2 != null) {
                return false;
            }
    
            return (t1.value == t2.value &&
                    AreTheSame(t1.left, t2.left) &&
                    AreTheSame(t1.right, t2.right));
        }
    }
}
