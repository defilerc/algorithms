namespace HackerEarth.Trees
{
    using System;
    using System.Linq;

    public class TreeDiameter
    {
        public static void Main(string[] args)
        {
            var tree = ParseTree();

            var diameter = FindTreeDiameter(tree);

            Console.WriteLine(diameter);
        }

        public static int FindTreeDiameter(Tree node)
        {
            if (node == null) {
                return 0;
            }

            var l = MaxDepth(node.left);
            var r = MaxDepth(node.right);

            var max = l + r + 1;

            var ld = FindTreeDiameter(node.left);
            var rd = FindTreeDiameter(node.right);

            return Math.Max(max, Math.Max(ld, rd));
        }

        private static int MaxDepth(Tree node)
        {
            if (node == null) {
                return 0;
            }

            /* compute the depth of each subtree */
            var lDepth = MaxDepth(node.left);
            var rDepth = MaxDepth(node.right);

            /* use the larger one */
            return lDepth > rDepth 
                ? lDepth + 1 
                : rDepth + 1;
        }

        private static Tree ParseTree()
        {
            var nr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var n = nr[0];
            var root = nr[1];

            var tree = new Tree(root);

            while (n-- > 1) {
                var cur = tree;
                var dir = Console.ReadLine();
                var value = int.Parse(Console.ReadLine());

                for (var i = 0; i < dir.Length; i++) {
                    if (dir[i] == 'L') {
                        if (cur.left == null) {
                            cur.left = new Tree();
                        }
                        cur = cur.left;
                    } else if (dir[i] == 'R') {
                        if (cur.right == null) {
                            cur.right = new Tree();
                        }
                        cur = cur.right;
                    }
                }

                cur.value = value;
            }

            return tree;
        }
    }
}
