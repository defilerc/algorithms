namespace Algo.Trees
{
    public class HasPathWithGivenSum
    {
        public bool hasPathWithGivenSum(Tree<int> t, int s) {
    
            if (t == null && s == 0) {
                return true;
            }

            return hasSum(t, s, 0);
        }
    
        bool hasSum(Tree<int> t, int s, int sum) {
            if (t == null) {
                return false;
            }
    
            sum += t.value;
    
            if (sum == s && t.left == null && t.right == null) {
                return true;
            }
    
            return hasSum(t.left, s, sum) || hasSum(t.right, s, sum);
        }
    }
}
