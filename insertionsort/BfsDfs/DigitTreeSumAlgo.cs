using System.Collections.Generic;
using System.Linq;

namespace Algo.BfsDfs
{
    public class DigitTreeSumAlgo
    {
        public long digitTreeSum(Tree<int> t)
        {
            var paths = new List<string>();
            CalculatePath(t, "", ref paths);

            return paths.Select(long.Parse).Sum();
        }

        void CalculatePath(Tree<int> t, string path, ref List<string> paths)
        {

            if (t == null)
            {
                return;
            }

            path += t.value.ToString();

            if (t.left == null && t.right == null)
            {
                paths.Add(path);
                return;
            }
            
            CalculatePath(t.left, path, ref paths);
            CalculatePath(t.right, path, ref paths);
        }
    }
}
