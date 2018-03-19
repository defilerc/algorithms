namespace HackerEarth.Trees
{
    using System;

    public class BinarySearchTree
    {
        public static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var q = int.Parse(Console.ReadLine());

            var tree = CreateBST(array);
            var node = FindInBST(tree, q);
            PrintBSTPreOrder(node);
        }

        static Tree CreateBST(int[] array)
        {
            var i = 0;
            var root = new Tree(array[i++]);

            var cur = root;

            while (i < array.Length) {
                if (array[i] > cur.value) {
                    if (cur.right == null) {
                        cur.right = new Tree(array[i++]);
                        cur = root;
                    } else {
                        cur = cur.right;
                    }
                } else {
                    if (cur.left == null) {
                        cur.left = new Tree(array[i++]);
                        cur = root;
                    } else {
                        cur = cur.left;
                    }
                }
            }

            return root;
        }

        static Tree FindInBST(Tree node, int value)
        {
            while (true) {
                if (node == null) {
                    return null;
                }

                if (value == node.value) {
                    return node;
                }

                node = value > node.value ? node.right : node.left;
            }
        }

        static void PrintBSTPreOrder(Tree tree)
        {
            if (tree == null) {
                return;
            }

            Console.WriteLine(tree.value);
            PrintBSTPreOrder(tree.left);
            PrintBSTPreOrder(tree.right);
        }
    }
}
